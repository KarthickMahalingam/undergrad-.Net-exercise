Public Class Form1
    Dim a As Object Main.Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (a.validation(TextBox1.Text)) Then
            MsgBox("valid")
        Else
            MsgBox("not valid")
        End If
    End Sub
End Class
