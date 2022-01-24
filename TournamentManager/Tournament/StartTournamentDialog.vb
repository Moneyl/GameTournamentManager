Imports System.Windows.Forms

Public Class StartTournamentDialog
    Private AllPlayers As List(Of PlayerData) = New List(Of PlayerData)
    Public SelectedPlayers As List(Of PlayerData) = New List(Of PlayerData)

    Public Sub New(players As List(Of PlayerData))
        InitializeComponent()
        AllPlayers = players
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim evenPlayerCount As Boolean = PlayerList.CheckedItems.Count Mod 2 = 0
        If Not evenPlayerCount Then
            ' Odd player count. Warn user that tournament requires an even number of players
            MsgBox("An odd number of players are selected. Tournaments requires an even number of players to start. Please select or unselect one player.")
        Else
            ' Fill list of selected players
            SelectedPlayers.Clear()
            For Each selected In PlayerList.CheckedItems
                Dim selectedName As String = selected
                Dim player = AllPlayers.Find(Function(p) p.PlayerName = selectedName)
                If Not player Is Nothing Then
                    SelectedPlayers.Add(player)
                End If
            Next

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewTournamentDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playerNames = New List(Of String)
        For Each player In AllPlayers
            playerNames.Add(player.PlayerName)
        Next
        PlayerList.Items.AddRange(playerNames.ToArray())

        ' Check as many players as possible while still having an even number (roster must have even number of players)
        Dim numPlayersToCheck = playerNames.Count
        If numPlayersToCheck Mod 2 = 1 Then
            numPlayersToCheck -= 1
        End If
        For i = 0 To numPlayersToCheck - 1
            PlayerList.SetItemChecked(i, True)
        Next
    End Sub
End Class
