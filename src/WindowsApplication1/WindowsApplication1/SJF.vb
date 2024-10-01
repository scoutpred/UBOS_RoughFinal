Public Class SJF

    'compute
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'basis = p1 big is 535, 137 - small is 169, 137
        'basis = window big is 559, 330 - small is 191, 262



        If TextBox1.Text = Nothing Then
            nopls()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox2.Text = Nothing Then
            nopls()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox3.Text = Nothing Then
            nopls()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox4.Text = Nothing Then
            nopls()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox5.Text = Nothing Then
            nopls()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox1.Text > 10 Then
            nopls2()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox2.Text > 10 Then
            nopls2()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox3.Text > 10 Then
            nopls2()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox4.Text > 10 Then
            nopls2()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)
        ElseIf TextBox5.Text > 10 Then
            nopls2()
            Me.ClientSize = New System.Drawing.Size(191, 262)
            Me.Panel1.Size = New System.Drawing.Size(169, 137)

            'if the "if" statements above return false, it is safe to execute the algorithm without ever worrying about
            'breaking the requirements

        Else
            'algo() draws the panels and enlarges the form
            p1 = TextBox1.Text
            p2 = TextBox2.Text
            p3 = TextBox3.Text
            p4 = TextBox4.Text
            p5 = TextBox5.Text

            algo()
            Label14.Text = ""
            Me.ClientSize = New System.Drawing.Size(559, 330)
            Me.Panel1.Size = New System.Drawing.Size(535, 137)
        End If


    End Sub

    'clear
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.ClientSize = New System.Drawing.Size(191, 262)
        Me.Panel1.Size = New System.Drawing.Size(169, 137)
        allclear()

    End Sub



    'this SJF algorithm
    'yes, declare everything, for now.

    Dim p1, p2, p3, p4, p5 As Integer
    Dim arr() As Integer = {p1, p2, p3, p4, p5}

    Private Sub algo()

        Dim seq As Integer = 0

        Dim order As Integer = 1

        Do Until order > 6
            Array.Sort(arr)
            If order = 1 Then
                p1draw()
            ElseIf order = 2
                p2draw()
            ElseIf order = 3
                p3draw()
            ElseIf order = 4
                p4draw()
            ElseIf order = 5
                p5draw()
            End If
            order = order + 1
        Loop



        TextBox6.Text = 0

            TextBox7.Text = (arr(0)).ToString
            TextBox8.Text = (arr(1) + arr(0)).ToString
            TextBox9.Text = (arr(1) + arr(0) + arr(2)).ToString
            TextBox10.Text = (arr(1) + arr(0) + arr(2) + arr(3)).ToString


            TextBox11.Text = (p1).ToString
        Label21.Text = (arr(0)).ToString
        TextBox12.Text = (p1 + p2).ToString
        Label22.Text = (arr(1) + arr(0)).ToString
        TextBox13.Text = (p1 + p2 + p3).ToString
        Label23.Text = (arr(1) + arr(0) + arr(2)).ToString
        TextBox14.Text = (p1 + p2 + p3 + p4).ToString
        Label24.Text = (arr(1) + arr(0) + arr(2) + arr(3)).ToString
        TextBox15.Text = (p1 + p2 + p3 + p4 + p5).ToString
        Label25.Text = (arr(1) + arr(0) + arr(2) + arr(3) + arr(4)).ToString

        TextBox16.Text = (((arr(1) + arr(0) + arr(2) + arr(3) + arr(4)) / (p1 + p2 + p3 + p4 + p5)) * 100).ToString + "%"
        TextBox17.Text = "5/" + (p1 + p2 + p3 + p4 + p5).ToString

    End Sub

    Private Sub allclear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()

    End Sub

    Private Sub nopls()
        Label14.Text = "All Process Fields must be filled"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FCFS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Dim p1i As Integer
    Dim p1itotal As Integer
    Dim p2i As Integer
    Dim p2itotal As Integer
    Dim p3i As Integer
    Dim p3itotal As Integer
    Dim p4i As Integer
    Dim p4itotal As Integer
    Dim p5i As Integer
    Dim p5itotal As Integer

    Public Sub p1draw()

        p1i = 0
        p1itotal = 0

        Do Until p1i > Array.IndexOf(arr, p1)
            Label21.Location = New System.Drawing.Point(2, 32)
            Panel3.Location = New System.Drawing.Point(4, 4)
            p1itotal = p1itotal + arr(p1i)
            p1i = p1i + 1

        Loop


        Panel3.Size = New System.Drawing.Size((p1 * 10), 25)
        Panel3.BackColor = System.Drawing.Color.Maroon
        Label15.Location = New System.Drawing.Point(2, 3)
        Label15.ForeColor = System.Drawing.SystemColors.Window


    End Sub

    Public Sub p2draw()

        p2i = 0
        p2itotal = p1itotal

        Do Until p2i > Array.IndexOf(arr, p2)
            Panel4.Location = New System.Drawing.Point(4 + (p1itotal * 10), 4)
            Label22.Location = New System.Drawing.Point(2 + (p1itotal * 10), 32)
            p2itotal = arr(p2i)
            p2i = p2i + 1

        Loop


        Panel4.Size = New System.Drawing.Size((p2 * 10), 25)
        Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Label16.Location = New System.Drawing.Point(2, 3)
        Label16.ForeColor = System.Drawing.SystemColors.Window

    End Sub

    Public Sub p3draw()

        p3i = 0
        p3itotal = 0

        Do Until p3i > Array.IndexOf(arr, p3)
            Panel5.Location = New System.Drawing.Point(4 + (p2itotal * 10), 4)
            Label23.Location = New System.Drawing.Point(2 + (p2itotal * 10), 32)
            p3itotal = p3itotal + arr(p3i)
            p3i = p3i + 1

        Loop


        Panel5.Size = New System.Drawing.Size((p3 * 10), 25)
        Panel5.BackColor = System.Drawing.Color.Navy
        Label17.Location = New System.Drawing.Point(2, 3)
        Label17.ForeColor = System.Drawing.SystemColors.Window

    End Sub

    Public Sub p4draw()

        p4i = 0
        p4itotal = 0

        Do Until p4i > Array.IndexOf(arr, p4)
            Panel6.Location = New System.Drawing.Point(4 + (p3itotal * 10), 4)
            Label24.Location = New System.Drawing.Point(2 + (p3itotal * 10), 32)
            p4itotal = p4itotal + arr(p4i)
            p4i = p4i + 1


        Loop


        Panel6.Size = New System.Drawing.Size((p4 * 10), 25)
        Panel6.BackColor = System.Drawing.Color.Purple
        Label18.Location = New System.Drawing.Point(2, 3)
        Label18.ForeColor = System.Drawing.SystemColors.Window

    End Sub

    Public Sub p5draw()

        p5i = 0
        p5itotal = 0

        Do Until p5i > Array.IndexOf(arr, p5)
            Panel7.Location = New System.Drawing.Point(4 + (p4itotal * 10), 4)
            Label25.Location = New System.Drawing.Point(2 + (p4itotal * 10), 32)
            p5itotal = p5itotal + arr(p5i)
            p5i = p5i + 1

        Loop


        Panel7.Size = New System.Drawing.Size((p5 * 10), 25)
        Panel7.BackColor = System.Drawing.Color.Olive
        Label19.Location = New System.Drawing.Point(2, 3)
        Label19.ForeColor = System.Drawing.SystemColors.Window

    End Sub

    Private Sub nopls2()
        Label14.Text = "A burst time of a process should not be more than 10"
    End Sub
End Class