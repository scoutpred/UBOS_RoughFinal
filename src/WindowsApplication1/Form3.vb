Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyMin As Integer = 1
        Dim MyMax As Integer = 3
        Dim dialog1 As Integer
        Dim Generator As System.Random = New System.Random()
        dialog1 = Generator.Next(MyMin, MyMax + 1)

        If dialog1 = 1 Then
            Label1.Text = "You wanna break the OS for good?"
        ElseIf dialog1 = 2 Then
            Label1.Text = "Oh, wait, you're leaving?"
        ElseIf dialog1 = 3 Then
            Label1.Text = "Done checking our work? :D"
        End If

    End Sub
End Class