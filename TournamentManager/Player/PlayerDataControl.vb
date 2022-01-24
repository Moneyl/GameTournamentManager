
' Displays the name, gamertag, wins, and losses of a player
Public Class PlayerDataControl
    Public Player As PlayerData

    Public Sub New(playerInit As PlayerData)
        InitializeComponent()
        Player = playerInit
        UpdateLabels()
    End Sub

    Private Sub PlayerDataControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim editPlayerDialog = New PlayerEditDialog(MainForm.Players, Player)
        If editPlayerDialog.ShowDialog() = DialogResult.OK Then
            UpdateLabels()
            MainForm.SaveChangesToDb()
        End If
    End Sub
    Private Sub UpdateLabels()
        NameLabel.Text = $"{Player.GamerTag} ({Player.PlayerName})"
        StatsLabel.Text = $"{Player.Wins} wins, {Player.Losses} losses"
    End Sub
End Class
