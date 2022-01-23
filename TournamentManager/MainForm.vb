Imports System.Data.SqlClient

Public Class MainForm
    Private dbConnection As SqlConnection
    Private adapter As SqlDataAdapter
    Private dataTable As DataTable
    Public Gamers As List(Of PlayerData) = New List(Of PlayerData)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to database
        dbConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=LukesDB;Integrated Security=yes;")
        dbConnection.Open()

        ' Query player list from DB
        Dim command = dbConnection.CreateCommand()
        command.CommandText = "SELECT * FROM dbo.PlayerDB;"
        Using reader As SqlDataReader = command.ExecuteReader() ' Closes reader on scope exit
            ' Read player data into memory row by row
            Do While reader.Read()
                Dim name = reader.GetString(0)
                Dim gamerTag = reader.GetString(1)
                Dim wins = reader.GetInt32(2)
                Dim losses = reader.GetInt32(3)
                Gamers.Add(New PlayerData(name, gamerTag, wins, losses))
            Loop
            UpdatePlayerList()
        End Using
    End Sub

    Private Sub AddPlayerButton_Click(sender As Object, e As EventArgs) Handles AddPlayerButton.Click
        ' Create and open new player dialog
        Dim newPlayerDialog = New NewPlayerDialog()
        Dim result As DialogResult = newPlayerDialog.ShowDialog()

        ' Dialog closed with 'Ok' button
        If result = DialogResult.OK Then
            ' Check for duplicate player name or gamer tag
            Dim newPlayer = newPlayerDialog.Player
            If Gamers.Any(Function(player) player.PlayerName = newPlayer.PlayerName) Then
                MsgBox($"Failed to add new player. The name '{newPlayer.PlayerName}' is already taken!")
            ElseIf Gamers.Any(Function(player) player.GamerTag = newPlayer.GamerTag) Then
                MsgBox($"Failed to add new player. The gamer tag '{newPlayer.GamerTag}' is already taken!")
            Else
                Gamers.Add(newPlayerDialog.Player)
                PlayerList.Controls.Add(New PlayerDataControl(newPlayerDialog.Player))
            End If
        End If
    End Sub

    Private Sub RefreshPlayersButton_Click(sender As Object, e As EventArgs) Handles RefreshPlayersButton.Click
        Debug.WriteLine("Clicked Refresh button!")
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveChangesToDb()
    End Sub

    Private Sub UpdatePlayerList()
        ' Create a GamerDataControl instance for each player
        PlayerList.Controls.Clear()
        For Each gamer In Gamers
            PlayerList.Controls.Add(New PlayerDataControl(gamer))
        Next
    End Sub

    ' Returns true if any entries in the Playername column of PlayerDB match playerName
    Private Function DbDoesPlayerExist(playerName As String) As Boolean
        Dim command = dbConnection.CreateCommand()
        command.CommandText = $"SELECT 1 FROM dbo.PlayerDB WHERE Playername = '{playerName}';"
        Using reader As SqlDataReader = command.ExecuteReader()
            Return reader.HasRows
        End Using
    End Function

    ' Save changes to existing players and new players to the database
    Private Sub SaveChangesToDb()
        For Each player In Gamers
            If DbDoesPlayerExist(player.PlayerName) Then
                ' Update existing entry
                Dim command = dbConnection.CreateCommand()
                command.CommandText = $"UPDATE dbo.PlayerDB
                                        SET Playername = '{player.PlayerName}', GamerTag = '{player.GamerTag}',
                                        Wins = {player.Wins}, Losses = {player.Losses}
                                        WHERE Playername = '{player.PlayerName}'"
                command.ExecuteNonQuery()
            Else
                ' Add new entry
                Dim command = dbConnection.CreateCommand()
                command.CommandText = $"INSERT INTO dbo.PlayerDB VALUES ('{player.PlayerName}', '{player.GamerTag}', {player.Wins}, {player.Losses})"
                command.ExecuteNonQuery()
            End If
        Next
    End Sub

    ' Open tournament dialog and handle its results
    Private Sub StartTournamentButton_Click(sender As Object, e As EventArgs) Handles StartTournamentButton.Click
        ' Open tournament creation dialog
        Dim startTournamentDialog = New StartTournamentDialog(Gamers)
        If startTournamentDialog.ShowDialog() = DialogResult.OK Then
            ' Open tournament dialog
            Dim tournamentDialog = New TournamentDialog(startTournamentDialog.SelectedPlayers)
            If tournamentDialog.ShowDialog() = DialogResult.OK Then
                UpdatePlayerList()
                SaveChangesToDb()
            End If
        End If
    End Sub
End Class
