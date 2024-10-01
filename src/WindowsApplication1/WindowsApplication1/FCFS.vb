Public Class FCFS


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'basis = p1 big is 535, 137 - small is 169, 137
        'basis = window big is 559, 330 - small is 191, 262

        'nopls() function disallows execution if one of the textbox fields have no input or more than 10

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

            algo()
            Label14.Text = ""
            Me.ClientSize = New System.Drawing.Size(559, 330)
            Me.Panel1.Size = New System.Drawing.Size(535, 137)
        End If


    End Sub

    'clear
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'clears everything and returns the panel and client size to its original dimensions

        Me.ClientSize = New System.Drawing.Size(191, 262)
        Me.Panel1.Size = New System.Drawing.Size(169, 137)
        allclear()

    End Sub



    'this FCFS algorithm, pretty much straightforward
    'yes, declare everything, for now.

    Private Sub algo()
        Dim p1, p2, p3, p4, p5 As Integer

        'designate burst times

        p1 = TextBox1.Text
        p2 = TextBox2.Text
        p3 = TextBox3.Text
        p4 = TextBox4.Text
        p5 = TextBox5.Text

        'this is FCFS, no waiting time for the first process

        TextBox6.Text = 0

        'drawing the gantt chart using panels, designating label locations with respect to the panels of the gantt chart.

        Panel3.Location = New System.Drawing.Point(4, 4)
        Panel3.Size = New System.Drawing.Size((p1 * 10), 25)
        Panel3.BackColor = System.Drawing.Color.Maroon
        Label15.Location = New System.Drawing.Point(2, 3)
        Label15.ForeColor = System.Drawing.SystemColors.Window
        Label21.Location = New System.Drawing.Point(2 + (p1 * 10), 32)

        TextBox7.Text = (p1).ToString
        Panel4.Location = New System.Drawing.Point(4 + (p1 * 10), 4)
        Panel4.Size = New System.Drawing.Size((p2 * 10), 25)
        Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Label16.Location = New System.Drawing.Point(2, 3)
        Label16.ForeColor = System.Drawing.SystemColors.Window
        Label22.Location = New System.Drawing.Point(2 + (p1 * 10) + (p2 * 10), 32)

        TextBox8.Text = (p1 + p2).ToString
        Panel5.Location = New System.Drawing.Point((4 + (p1 * 10) + (p2 * 10)), 4)
        Panel5.Size = New System.Drawing.Size((p3 * 10), 25)
        Panel5.BackColor = System.Drawing.Color.Navy
        Label17.Location = New System.Drawing.Point(2, 3)
        Label17.ForeColor = System.Drawing.SystemColors.Window
        Label23.Location = New System.Drawing.Point(2 + (p1 * 10) + (p2 * 10) + (p3 * 10), 32)

        TextBox9.Text = (p1 + p2 + p3).ToString
        Panel6.Location = New System.Drawing.Point((4 + (p1 * 10) + (p2 * 10) + (p3 * 10)), 4)
        Panel6.Size = New System.Drawing.Size((p4 * 10), 25)
        Panel6.BackColor = System.Drawing.Color.Purple
        Label18.Location = New System.Drawing.Point(2, 3)
        Label18.ForeColor = System.Drawing.SystemColors.Window
        Label24.Location = New System.Drawing.Point(2 + (p1 * 10) + (p2 * 10) + (p3 * 10) + (p4 * 10), 32)

        TextBox10.Text = (p1 + p2 + p3 + p4).ToString
        Panel7.Location = New System.Drawing.Point((4 + (p1 * 10) + (p2 * 10) + (p3 * 10) + (p4 * 10)), 4)
        Panel7.Size = New System.Drawing.Size((p5 * 10), 25)
        Panel7.BackColor = System.Drawing.Color.Olive
        Label19.Location = New System.Drawing.Point(2, 3)
        Label19.ForeColor = System.Drawing.SystemColors.Window
        Label25.Location = New System.Drawing.Point(2 + (p1 * 10) + (p2 * 10) + (p3 * 10) + (p4 * 10) + (p5 * 10), 32)

        'burst times being added for the turnover time


        TextBox11.Text = (p1).ToString
        Label21.Text = (p1).ToString
        TextBox12.Text = (p1 + p2).ToString
        Label22.Text = (p1 + p2).ToString
        TextBox13.Text = (p1 + p2 + p3).ToString
        Label23.Text = (p1 + p2 + p3).ToString
        TextBox14.Text = (p1 + p2 + p3 + p4).ToString
        Label24.Text = (p1 + p2 + p3 + p4).ToString
        TextBox15.Text = (p1 + p2 + p3 + p4 + p5).ToString
        Label25.Text = (p1 + p2 + p3 + p4 + p5).ToString

        'FCFS is somehow linear, so constants are applied

        TextBox16.Text = (((p1 + p2 + p3 + p4 + p5) / (p1 + p2 + p3 + p4 + p5)) * 100).ToString + "%"
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

    'label to show an error if one of the process fields are empty
    Private Sub nopls()
        Label14.Text = "All Process Fields must be filled"
    End Sub

    'label to show an error if one of the processes is more than 10
    Private Sub nopls2()
        Label14.Text = "A burst time of a process should not be more than 10"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'keeps the program on top of the OS.
    Private Sub FCFS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class