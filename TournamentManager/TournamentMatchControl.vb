
Public Class TournamentMatchControl
    Public Match As Match

    Public Sub New(matchInit As Match)
        InitializeComponent()
        Match = matchInit
    End Sub

    Private Sub TournamentMatchControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatchLabel.Text = $"{Match.Player0.GamerTag} vs {Match.Player1.GamerTag}"
        WinnerComboBox.Text = Match.Player0.GamerTag
        WinnerComboBox.Items.Add(Match.Player0.GamerTag)
        WinnerComboBox.Items.Add(Match.Player1.GamerTag)
    End Sub
End Class
