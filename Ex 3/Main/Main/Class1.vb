Imports System.Text.RegularExpressions
Public Class Class1
    Function validation(ByVal str As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]+[_]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailidMatch As Match = Regex.Match(str, pattern)
        If emailidMatch.Success Then
            validation = True
        Else
            validation = False
        End If
    End Function
End Class
