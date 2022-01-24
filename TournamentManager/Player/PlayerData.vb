
' Data the manager tracks about each player. Player entries in the DB have the same columns
Public Class PlayerData
    ' Real life name of the player
    Public Property PlayerName As String
    ' In game identifier
    Public Property GamerTag As String
    ' Number of matches won
    Public Property Wins As Integer
    ' Number of matches lost
    Public Property Losses As Integer

    Public Sub New(name As String, gTag As String, winsInit As Integer, lossesInit As Integer)
        PlayerName = name
        GamerTag = gTag
        Wins = winsInit
        Losses = lossesInit
    End Sub
End Class
