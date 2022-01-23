
' Two players competing in a tournament match
Public Class Match
    Public Player0 As PlayerData
    Public Player1 As PlayerData

    Public Sub New(p0 As PlayerData, p1 As PlayerData)
        Player0 = p0
        Player1 = p1
    End Sub
End Class