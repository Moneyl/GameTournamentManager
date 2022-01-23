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

            ' Create a GamerDataControl instance for each player
            For Each gamer In Gamers
                PlayerList.Controls.Add(New PlayerDataControl(gamer))
            Next
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

    End Sub

    ' Returns true if any entries in the Playername column of PlayerDB match playerName
    Private Function DbDoesPlayerExist(playerName As String) As Boolean
        Dim command = dbConnection.CreateCommand()
        command.CommandText = $"SELECT 1 FROM dbo.PlayerDB WHERE Playername = '{playerName}';"
        Using reader As SqlDataReader = command.ExecuteReader()
            Return reader.HasRows
        End Using
    End Function

    ' Returns true if any entries in the Playername column of PlayerDB match gamerTag
    Private Function DbDoesGamerTagExist(gamerTag As String) As Boolean
        Dim command = dbConnection.CreateCommand()
        command.CommandText = $"SELECT 1 FROM dbo.PlayerDB WHERE GamerTag = '{gamerTag}';"
        Using reader As SqlDataReader = command.ExecuteReader()
            Return reader.HasRows
        End Using
    End Function
End Class
