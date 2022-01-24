Imports System.Windows.Forms

Public Class NewPlayerDialog
    Public Player As PlayerData = New PlayerData("", "", 0, 0)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Ensure name and gamer tag are unique
        Dim nameAlreadyUsed = MainForm.Players.Any(Function(p) p.PlayerName = Player.PlayerName)
        Dim gamerTagAlreadyUsed = MainForm.Players.Any(Function(p) p.GamerTag = Player.GamerTag)
        If nameAlreadyUsed Then
            MsgBox($"The player name '{Player.PlayerName}' is already being used.")
        ElseIf gamerTagAlreadyUsed Then
            MsgBox($"The gamer tag '{Player.GamerTag}' is already being used.")
        Else
            ' Unique name/gamertag. Close dialog
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewPlayerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind PlayerData instance to dialogs
        PlayerNameTextBox.DataBindings.Add(New Binding("Text", Player, "PlayerName"))
        GamerTagTextBox.DataBindings.Add(New Binding("Text", Player, "GamerTag"))
        WinsNumericUpDown.DataBindings.Add(New Binding("Value", Player, "Wins"))
        LossesNumericUpDown.DataBindings.Add(New Binding("Value", Player, "Losses"))
    End Sub
End Class
