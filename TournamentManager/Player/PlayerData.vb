
Public Class PlayerData
    Public Property PlayerName As String
    Public Property GamerTag As String
    Public Property Wins As Integer
    Public Property Losses As Integer

    Public Sub New(name As String, gTag As String, winsInit As Integer, lossesInit As Integer)
        PlayerName = name
        GamerTag = gTag
        Wins = winsInit
        Losses = lossesInit
    End Sub
End Class
