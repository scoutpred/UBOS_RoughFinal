Public Class Form1

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show()
        wait(1)

        Me.ProgressBar1.Maximum = 100
        For i = 0 To 100
            If i = 10 Then
                Label1.Text = "Asking for help..."
                wait(0.2)
            ElseIf i = 20 Then
                Label1.Text = "Breaking the OS..."
                wait(0.5)
            ElseIf i = 50 Then
                Label1.Text = "Making Sir Tandingan happy..."
                wait(0.7)
            ElseIf i = 70 Then
                Label1.Text = "Sending memes...."
                wait(0.5)
            ElseIf i = 75 Then
                Label1.Text = "Lurking 4chan.org/g/..."
                wait(0.4)
            ElseIf i = 80 Then
                Label1.Text = "Oh God no, I broke something..."
                wait(0.5)
            ElseIf i = 85 Then
                Label1.Text = "Oh wait, nevermind..."
                wait(0.5)
            ElseIf i = 90 Then
                Label1.Text = "Fixed it, LMAO."
                wait(0.5)
            ElseIf i = 100 Then
                Label1.Text = "Say Cheese!"
                wait(0.7)
            End If
            Me.ProgressBar1.Value = i
            For j As Double = 0 To 100 Step 0.00001 : Next

        Next
        Form6.Show()

    End Sub

End Class