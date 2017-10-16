Public Class UserControl1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = (Val(TextBox1.Text) * (Val(TextBox2.Text) / 1200) * (Math.Pow((1 + (Val(TextBox2.Text) / 1200)), Val(TextBox3.Text)))) / (Math.Pow((1 + (Val(TextBox2.Text) / 1200)), Val(TextBox3.Text)) - 1)
    End Sub
End Class
