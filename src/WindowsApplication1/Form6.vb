Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "clazzette" Then
            If TextBox2.Text = "delight" Then
                Form2.Show()
            Else
                Label2.Text = "Incorrect Password!"
            End If
        Else
            Label2.Text = "Username not found!"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Close()
        Form2.Close()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class