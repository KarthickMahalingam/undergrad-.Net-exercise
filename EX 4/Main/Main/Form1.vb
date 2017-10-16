Public Class Form1
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Karthickmaha\Desktop\db.mdb'"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "insert into Table1(name,salary)values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("saved")
        End Sub
    End Class
