Public Class FCFS

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub


    Dim p1h, p1w, p2h, p2w, wh, ww As Integer

    'compute
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'basis = p1 big is 535, 137 - small is 169, 137
        'basis = window big is 559, 330 - small is 191, 262

        Do Until ww = 559
            wait(0.000001)
            Me.ClientSize = New System.Drawing.Size(ww, wh)
            ww += 1
        Loop

        Do Until wh = 330
            wait(0.000001)
            Me.ClientSize = New System.Drawing.Size(ww, wh)
            wh += 1
        Loop

        Do Until p1w = 536
            wait(0.000001)
            Me.Panel1.Size = New System.Drawing.Size(p1w, p1h)
            p1w += 1
        Loop

        Do Until p1h = 137
            wait(0.000001)
            Me.Panel1.Size = New System.Drawing.Size(p1w, p1h)
            p1h += 1
        Loop


    End Sub

    'clear
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class