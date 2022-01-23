
' Control for editing a PlayerData instance
Public Class PlayerDataControl
    Public Player As PlayerData

    Public Sub New(playerInit As PlayerData)
        InitializeComponent()
        Player = playerInit

        ' Bind PlayerData instance to dialogs
        PlayerNameTextBox.DataBindings.Add(New Binding("Text", Player, "PlayerName"))
        GamerTagTextBox.DataBindings.Add(New Binding("Text", Player, "GamerTag"))
        WinsNumericUpDown.DataBindings.Add(New Binding("Value", Player, "Wins"))
        LossesNumericUpDown.DataBindings.Add(New Binding("Value", Player, "Losses"))
    End Sub

    Private Sub PlayerDataControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
