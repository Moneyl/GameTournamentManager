Imports System.Windows.Forms

Public Class TournamentDialog
    Private CurrentPlayers As List(Of PlayerData) = New List(Of PlayerData)
    Private _stage = 0
    Private _matches As List(Of Match) = New List(Of Match)
    Public TournamentWinner As PlayerData

    Public Sub New(players As List(Of PlayerData))
        InitializeComponent()
        CurrentPlayers = players
        GenerateMatches()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ' Randomly generate matches for this stage.
    Private Sub GenerateMatches()
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
        StageLabel.Text = $"Stage {_stage} - Select winners"

        ' Update match list
        MatchList.Controls.Clear()
        For Each match In _matches
            MatchList.Controls.Add(New TournamentMatchControl(match))
        Next
    End Sub

    ' If there are more stages remaining, generate the next set of matches, otherwise show tournament completion popup.
    Private Sub NextStage()
        If CurrentPlayers.Count <= 1 Then
            ' Tournament complete!
            TournamentWinner = CurrentPlayers(0)
            MsgBox($"Tournament complete. {TournamentWinner.GamerTag} ({TournamentWinner.PlayerName}) is the winner!")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            ' Next stage
            GenerateMatches()
        End If
    End Sub

    ' Update win/loss numbers based on match results, remove losers from CurrentPleyrs, and generate next stage
    Private Sub NextStageButton_Click(sender As Object, e As EventArgs) Handles NextStageButton.Click
        ' Ensure all matches have a winner selected
        For i = 0 To _matches.Count - 1
            Dim matchControl As TournamentMatchControl = MatchList.Controls(i)
            Dim winnerComboBox = matchControl.WinnerComboBox
            If winnerComboBox.Text = "" Then
                MsgBox($"No winner selected for match '{matchControl.Match.Player0.GamerTag} vs {matchControl.Match.Player1.GamerTag}'. Can't continue to next stage.")
                Return
            End If
        Next

        ' Update win/loss button
        For Each match In _matches
            Dim matchControl As TournamentMatchControl = MatchList.Controls(_matches.IndexOf(match))
            Dim winnerComboBox = matchControl.WinnerComboBox
            Dim winnerGamerTag As String = winnerComboBox.Text
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
            loser.Losses += 1
            CurrentPlayers.Remove(loser)
        Next

        ' Generate matches for next stage of tournament
        NextStage()
    End Sub
End Class
