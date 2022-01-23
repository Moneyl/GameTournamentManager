
' Control for editing a PlayerData instance
Public Class PlayerDataControl
    Public Player As PlayerData

    Public Sub New(playerInit As PlayerData)
        InitializeComponent()
        Player = playerInit

        ' Bind PlayerData instance to dialogs
        PlayerNameTextBox.DataBindings.Add(New Binding("Text", Player, "PlayerName", False, DataSourceUpdateMode.OnPropertyChanged))
        GamerTagTextBox.DataBindings.Add(New Binding("Text", Player, "GamerTag", False, DataSourceUpdateMode.OnPropertyChanged))
        WinsNumericUpDown.DataBindings.Add(New Binding("Value", Player, "Wins", False, DataSourceUpdateMode.OnPropertyChanged))
        LossesNumericUpDown.DataBindings.Add(New Binding("Value", Player, "Losses", False, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub PlayerDataControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
