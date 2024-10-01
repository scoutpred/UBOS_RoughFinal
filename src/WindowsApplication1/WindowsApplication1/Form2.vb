Public Class Form2

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.TimeToolStripMenuItem.Text = DateTime.Now.ToString()

        clc = Process.GetProcessesByName("Calculator")
        If clc.Count > 0 Then
            Me.CalculatorToolStripMenuItem1.Visible = True
        Else
            Me.CalculatorToolStripMenuItem1.Visible = False
        End If

        ntp = Process.GetProcessesByName("notepad")
        If ntp.Count > 0 Then
            Me.NotepadToolStripMenuItem1.Visible = True
        Else
            Me.NotepadToolStripMenuItem1.Visible = False
        End If

        cmdp = Process.GetProcessesByName("cmd")
        If cmdp.Count > 0 Then
            Me.CommandPromptToolStripMenuItem.Visible = True
        Else
            Me.CommandPromptToolStripMenuItem.Visible = False
        End If

        If Application.OpenForms().OfType(Of FCFS).Any Then
            Me.FCFSToolStripMenuItem1.Visible = True
        Else
            Me.FCFSToolStripMenuItem1.Visible = False
        End If

        If Application.OpenForms().OfType(Of FCFS).Any Then
            Me.MVTMMToolStripMenuItem.Visible = True
        Else
            Me.MVTMMToolStripMenuItem.Visible = False
        End If


    End Sub

    Dim p() As Process
    Dim clc() As Process
    Dim ntp() As Process
    Dim cmdp() As Process
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wait(0.5)
        Form6.Close()
        Timer1.Interval = 1
        Timer1.Start()
        Me.TimeToolStripMenuItem.Text = DateTime.Now.ToString()

    End Sub

    'shutdown prompt
    Private Sub ShutDownOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownOSToolStripMenuItem.Click
        Form3.Show()
    End Sub
    'restart prompt
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Form4.Show()
    End Sub

    'narcissistic button right here lmao
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    'open calc
    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Process.Start("calc.exe")
    End Sub

    'open notepad
    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub

    'opens cmd
    Private Sub CommandPromptToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommandPromptToolStripMenuItem1.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Form8.Show()
    End Sub

    Private Sub Label1_DoubleClick_1(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Form8.Show()
    End Sub

    Private Sub FCFSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FCFSToolStripMenuItem.Click
        FCFS.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        FCFS.Close()
    End Sub

    Private Sub AllocationStrategiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllocationStrategiesToolStripMenuItem.Click
        MVTMMnew.Show()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        MVTMMnew.Close()
    End Sub
End Class