Imports System.Windows.Forms

' UI for editing an existing player entry. Enforces uniqueness of PlayerName and GamerTag
Public Class PlayerEditDialog
    ' Temporary object that UI edits. Changes are only applied to Player if valid
    Private _data As PlayerData
    ' All players being tracked by the manager
    Public AllPlayers As List(Of PlayerData)
    ' Current state of the player being edited
    Public Player As PlayerData

    Public Sub New(players As List(Of PlayerData), playerInit As PlayerData)
        InitializeComponent()
        AllPlayers = players
        Player = playerInit
        _data = New PlayerData(New String(Player.PlayerName), New String(Player.GamerTag), Player.Wins, Player.Losses)
    End Sub

    ' Apply edits if name and gamer tag are unique
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Ensure name and gamer tag are unique
        Dim nameAlreadyUsed = AllPlayers.Any(Function(p) p IsNot Player And p.PlayerName = _data.PlayerName)
        Dim gamerTagAlreadyUsed = AllPlayers.Any(Function(p) p IsNot Player And p.GamerTag = _data.GamerTag)
        If nameAlreadyUsed Then
            MsgBox($"Edit failed. The player name '{_data.PlayerName}' is already being used.")
        ElseIf gamerTagAlreadyUsed Then
            MsgBox($"Edit failed. The gamer tag '{_data.GamerTag}' is already being used.")
        Else
            ' Unique name/gamertag. Apply changes to player object
            Player.PlayerName = _data.PlayerName
            Player.GamerTag = _data.GamerTag
            Player.Wins = _data.Wins
            Player.Losses = _data.Losses
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PlayerEditDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind PlayerData instance to dialogs
        PlayerNameTextBox.DataBindings.Add(New Binding("Text", _data, "PlayerName"))
        GamerTagTextBox.DataBindings.Add(New Binding("Text", _data, "GamerTag"))
        WinsNumericUpDown.DataBindings.Add(New Binding("Value", _data, "Wins"))
        LossesNumericUpDown.DataBindings.Add(New Binding("Value", _data, "Losses"))
    End Sub
End Class
