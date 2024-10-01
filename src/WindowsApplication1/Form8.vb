Public Class Form8

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        TextBox2.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.BackgroundImage = Nothing
        Form2.BackColor = ColorDialog1.Color()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then

        Else
            Form2.BackgroundImage = Image.FromFile(TextBox1.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Pick me a photo!"
        OpenFileDialog1.InitialDirectory = "Pictures"
        OpenFileDialog1.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp"
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.wpp1
    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = OpenFileDialog1.FileName.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

End Class