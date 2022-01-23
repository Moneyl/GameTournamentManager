Imports System.Windows.Forms

Public Class TournamentDialog
    Private CurrentPlayers As List(Of PlayerData) = New List(Of PlayerData)
    Private _stage = 0
    Private _matches As List(Of Match) = New List(Of Match)
    Private _matchIndex = 0
    Public TournamentWinner As PlayerData

    Public Sub New(players As List(Of PlayerData))
        InitializeComponent()
        CurrentPlayers = players
        GenerateBracket()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ' Generates the next bracket (list of matches). Only one bracket is shown at a time
    Private Sub GenerateBracket()
        Dim options = New List(Of PlayerData)
        options.AddRange(CurrentPlayers)
        Dim numMatches = CurrentPlayers.Count / 2
        Dim rand = New Random(System.DateTime.Now.Second)

        ' Randomly select players from ones still in the tournament
        _matches.Clear()
        For i = 1 To numMatches
            ' Pick two players for the match
            Dim player0 As PlayerData = Nothing
            Dim player1 As PlayerData = Nothing
            While True
                Dim i0 = rand.Next(0, options.Count)
                Dim i1 = rand.Next(0, options.Count)
                If i0 = i1 Then
                    Continue While
                End If
                player0 = options(i0)
                player1 = options(i1)
                Exit While
            End While

            ' Add players to bracket and remove them from options
            _matches.Add(New Match(player0, player1))
            options.Remove(player0)
            options.Remove(player1)
        Next

        ' Update bracket label
        BracketLabel.Text = $"Bracket {_stage}"
        _matchIndex = -1
        UpdateMatch()
    End Sub

    Private Sub UpdateMatch()
        _matchIndex += 1
        Dim match = _matches(_matchIndex)
        MatchLabel.Text = $"{match.Player0.GamerTag} vs {match.Player1.GamerTag}"
        WinnerComboBox.ResetText()
        WinnerComboBox.Text = match.Player0.GamerTag
        WinnerComboBox.Items.Clear()
        WinnerComboBox.Items.Add(match.Player0.GamerTag)
        WinnerComboBox.Items.Add(match.Player1.GamerTag)
    End Sub

    Private Sub NextStage()
        If CurrentPlayers.Count <= 1 Then
            ' Tournament complete!
            TournamentWinner = CurrentPlayers(0)
            MsgBox($"Tournament complete. {TournamentWinner.GamerTag} ({TournamentWinner.PlayerName}) is the winner!")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            ' Next stage
            GenerateBracket()
        End If
    End Sub

    Private Sub SetWinnerButton_Click(sender As Object, e As EventArgs) Handles SetWinnerButton.Click
        Dim match = _matches(_matchIndex)
        Dim winnerGamerTag As String = WinnerComboBox.Text
        Dim winner As PlayerData = Nothing
        Dim loser As PlayerData = Nothing
        If winnerGamerTag = match.Player0.GamerTag Then
            winner = match.Player0
            loser = match.Player1
        ElseIf winnerGamerTag = match.Player1.GamerTag Then
            winner = match.Player1
            loser = match.Player0
        End If

        winner.Wins += 1
        loser.Losses = 1
        CurrentPlayers.Remove(loser)

        If _matchIndex < _matches.Count - 1 Then
            ' Go to next match
            UpdateMatch()
        Else
            ' Reached final match. Go to next stage of the tournament
            NextStage()
        End If
    End Sub
End Class
