Public Class MVTMMnew

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TextBox1.KeyUp

        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim Lbels() As Object = {Nothing, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14}
        Dim procnum As Integer
        Dim processcount As Integer
        Dim checkint As Integer

        If Integer.TryParse(TextBox1.Text, checkint) Then

            If TextBox1.Text = Nothing Then

                GoTo NoneHappens
            ElseIf TextBox1.Text = 0 Then
                TextBox1.Text = 10

            End If

            processcount = TextBox1.Text


            If TextBox1.Text Is Nothing Then
                Label4.Text = "Process input empty."
            ElseIf TextBox1.Text > 10 Then
                Label4.Text = "Invalid Input"
            Else
                For procnum = 1 To processcount
                    TBox(procnum).Visible = True
                    Lbels(procnum).visible = True
                Next procnum
                Label4.Text = "Process inputs created."
                TextBox1.Enabled = False

                TextBox2.Enabled = True

            End If
        Else
            TextBox1.Text = ""
            Label4.Text = "Process input not an integer"
        End If
NoneHappens:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TextBox2.KeyUp
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}
        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim Lbels2() As Object = {Nothing, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label24}
        Dim framnum As Integer
        Dim procnum As Integer
        Dim blockcount As Integer
        Dim processcount As Integer
        Dim checkint As Integer



        If Integer.TryParse(TextBox2.Text, checkint) Then

            TextBox23.Text = TextBox2.Text

            If TextBox2.Text = Nothing Then

                GoTo NoneHappens
            ElseIf TextBox2.Text = 0 Then
                TextBox2.Text = 10

            End If

            blockcount = TextBox2.Text
            processcount = TextBox1.Text

            If TextBox2.Text Is Nothing Then
                Label4.Text = "Frame input empty."
            ElseIf TextBox2.Text > 10 Then
                Label4.Text = "Invalid input"
            Else
                For framnum = 1 To blockcount
                    TBox2(framnum).Visible = True
                    Lbels2(framnum).visible = True

                Next framnum

                For procnum = 1 To processcount
                    TBox(procnum).enabled = True
                Next procnum

                Label4.Text = "Frame inputs created."
                TextBox2.Enabled = False
                Button5.Enabled = True
                Button3.Enabled = True

            End If
        Else
            TextBox2.Text = ""
            Label4.Text = "Frame input not an integer"
        End If
NoneHappens:
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox2.Items.Clear()

        ' CHECK FOR 0 AND STRING INPUT IN PROCESS AND BLOCKS!
        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}
        Dim totalb As Integer = TextBox2.Text
        Dim totalp As Integer = TextBox1.Text

        Dim checkint As Integer

        'If Integer.TryParse(TextBox2.Text, checkint) And Integer.TryParse(TextBox1.Text, checkint) Then

        For checkzero As Integer = 1 To totalp

            If Integer.TryParse(TBox(checkzero).text, checkint) Then
                If TBox(checkzero).text = 0 Then
                    ListBox2.Items.Add("Cannot accept 0")
                    ListBox2.Items.Add("as a process value")
                    Label4.Text = "Proc. Input error"
                    GoTo NoneHappens2
                End If
            Else
                ListBox2.Items.Add("Cannot accept strings")
                ListBox2.Items.Add("as a process value")
                Label4.Text = "Proc. Input error"
                GoTo NoneHappens2
            End If

        Next checkzero

        For checkzero As Integer = 1 To totalb

            If Integer.TryParse(TBox2(checkzero).text, checkint) Then
                If TBox2(checkzero).text = 0 Then
                    ListBox2.Items.Add("Cannot accept 0")
                    ListBox2.Items.Add("as a block value")
                    Label4.Text = "Block Input error"
                    GoTo NoneHappens2
                End If
            Else
                ListBox2.Items.Add("Cannot accept strings")
                ListBox2.Items.Add("as a block value")
                Label4.Text = "Block Input error"
                GoTo NoneHappens2
            End If


        Next checkzero


        TextBox34.Text = TextBox2.Text

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True

        If RadioButton2.Checked Then
            Qfit()
        ElseIf RadioButton1.Checked Then
            Nfit()
        ElseIf RadioButton3.Checked Then
            BFit()
        ElseIf RadioButton4.Checked Then
            WFit()
        End If

NoneHappens2:
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm = New MVTMMnew
        frm.Show()
        frm.ListBox2.Items.Add("Values Reset")
        Me.Close()

    End Sub

    '===============================
    'quick fit
    '===============================

    Public Sub Qfit()

        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Add("Log Cleared")
        ListBox2.Items.Add("Quick Fit initiated")

        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}

        'hbox are composed of hidden textboxes. they serve as the temp.

        Dim Hbox() As Object = {Nothing, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30, TextBox31, TextBox32, TextBox33}
        Dim Panels() As Object = {Nothing, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14}

        Dim currentblocksize As Integer
        Dim currentprocsize As Integer


        Dim loc As Double
        Dim processcount As Integer
        Dim blockcount As Integer

        'get block
        blockcount = TextBox2.Text
        processcount = TextBox1.Text
        loc = 0

        'frames initialize first
        For i As Integer = 1 To blockcount
            Panels(i).location = New System.Drawing.Point(0, loc)
            Panels(i).size = New System.Drawing.Size(159, (TBox2(i).text) / blockcount * 2.75)
            If i = 1 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ElseIf i = 2 Then
                Panels(i).BackColor = System.Drawing.Color.Maroon
            ElseIf i = 3 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 4 Then
                Panels(i).BackColor = System.Drawing.Color.Olive
            ElseIf i = 5 Then
                Panels(i).BackColor = System.Drawing.Color.Green
            ElseIf i = 6 Then
                Panels(i).BackColor = System.Drawing.Color.Teal
            ElseIf i = 7 Then
                Panels(i).BackColor = System.Drawing.Color.Navy
            ElseIf i = 8 Then
                Panels(i).BackColor = System.Drawing.Color.Purple
            ElseIf i = 9 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 10 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            End If
            loc = loc + (TBox2(i).text / blockcount * 2.75)
            Hbox(i).text = TBox2(i).text
            ListBox2.Items.Add("Frame " + i.ToString + " added with size " + Hbox(i).Text)
        Next i

        '-----------------------------------

        Dim cb As Integer

        For currentproc As Integer = 1 To processcount
            For currentblock As Integer = 1 To blockcount


                currentblocksize = Hbox(currentblock).text
                currentprocsize = TBox(currentproc).text
                cb = currentblock


                If currentblocksize >= currentprocsize Then
                    If currentproc = 1 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 2 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 3 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 4 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 5 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 6 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 7 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 8 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 9 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                        GoTo fits
                    ElseIf currentproc = 10 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
                        GoTo fits
                    End If



                End If

            Next currentblock

            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Process " + currentproc.ToString + " is unallocated")
            ListBox1.Items.Add("Process " + currentproc.ToString + " is unallocated")
            GoTo nextproc

fits:
            Hbox(cb).text = 0
            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
            ListBox2.Items.Add("at frame " + cb.ToString)
            TextBox34.Text = CInt(TextBox34.Text) - 1
nextproc:
        Next currentproc

    End Sub


    '===============================
    'next fit
    '===============================

    Public Sub Nfit()

        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Add("Log Cleared")
        ListBox2.Items.Add("Allocation initiated")

        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}

        'hbox are composed of hidden textboxes. they serve as the temp.

        Dim Hbox() As Object = {Nothing, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30, TextBox31, TextBox32, TextBox33}
        Dim Panels() As Object = {Nothing, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14}

        Dim currentblocksize As Integer
        Dim currentprocsize As Integer


        Dim loc As Double
        Dim processcount As Integer
        Dim blockcount As Integer

        'get block
        blockcount = TextBox2.Text
        processcount = TextBox1.Text
        loc = 0

        'frames initialize first
        For i As Integer = 1 To blockcount
            Panels(i).location = New System.Drawing.Point(0, loc)
            Panels(i).size = New System.Drawing.Size(159, (TBox2(i).text) / blockcount * 2.75)
            If i = 1 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ElseIf i = 2 Then
                Panels(i).BackColor = System.Drawing.Color.Maroon
            ElseIf i = 3 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 4 Then
                Panels(i).BackColor = System.Drawing.Color.Olive
            ElseIf i = 5 Then
                Panels(i).BackColor = System.Drawing.Color.Green
            ElseIf i = 6 Then
                Panels(i).BackColor = System.Drawing.Color.Teal
            ElseIf i = 7 Then
                Panels(i).BackColor = System.Drawing.Color.Navy
            ElseIf i = 8 Then
                Panels(i).BackColor = System.Drawing.Color.Purple
            ElseIf i = 9 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 10 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            End If
            loc = loc + (TBox2(i).text / blockcount * 2.75)
            Hbox(i).text = TBox2(i).text
            ListBox2.Items.Add("Frame " + i.ToString + " added with size " + Hbox(i).Text)
        Next i

        '-----------------------------------

        Dim cb As Integer
        Dim currentproc As Integer = 1
        Dim currentblock As Integer = 1


        Do Until currentproc > processcount
            Do Until currentblock > blockcount


                currentblocksize = Hbox(currentblock).text

                If TBox(currentproc).text = "" Then
                    GoTo stophere
                End If

                currentprocsize = TBox(currentproc).text
                cb = currentblock


                If currentblocksize >= currentprocsize Then
                    If currentproc = 1 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 2 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 3 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 4 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 5 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc +=
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 6 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 7 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc +=
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 8 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 9 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc += 1
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    ElseIf currentproc = 10 Then
                        Panels(currentblock).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
                        Hbox(cb).text = 0
                        ListBox2.Items.Add("===")
                        ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
                        ListBox2.Items.Add("at frame " + cb.ToString)
                        currentproc +=
                        TextBox34.Text = CInt(TextBox34.Text) - 1
                    End If


                End If
        currentblock += 1
        Loop


        If currentproc <= processcount Then
            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Process " + currentproc.ToString + " is unallocated")
            ListBox2.Items.Add("Reached end of memory")
            ListBox1.Items.Add("Process " + currentproc.ToString + " is unallocated")
            currentproc += 1
        End If

        Loop
stophere:
    End Sub

    '===============================
    'best fit
    '===============================

    Public Sub BFit()

        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Add("Log Cleared")
        ListBox2.Items.Add("Best Fit initiated")

        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}

        'hbox are composed of hidden textboxes. they serve as the temp.

        Dim Hbox() As Object = {Nothing, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30, TextBox31, TextBox32, TextBox33}
        Dim Panels() As Object = {Nothing, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14}

        Dim currentblocksize As Integer
        Dim currentprocsize As Integer


        Dim loc As Double
        Dim processcount As Integer
        Dim blockcount As Integer

        'get block
        blockcount = TextBox2.Text
        processcount = TextBox1.Text
        loc = 0

        'frames initialize first
        For i As Integer = 1 To blockcount
            Panels(i).location = New System.Drawing.Point(0, loc)
            Panels(i).size = New System.Drawing.Size(159, (TBox2(i).text) / blockcount * 2.75)
            If i = 1 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ElseIf i = 2 Then
                Panels(i).BackColor = System.Drawing.Color.Maroon
            ElseIf i = 3 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 4 Then
                Panels(i).BackColor = System.Drawing.Color.Olive
            ElseIf i = 5 Then
                Panels(i).BackColor = System.Drawing.Color.Green
            ElseIf i = 6 Then
                Panels(i).BackColor = System.Drawing.Color.Teal
            ElseIf i = 7 Then
                Panels(i).BackColor = System.Drawing.Color.Navy
            ElseIf i = 8 Then
                Panels(i).BackColor = System.Drawing.Color.Purple
            ElseIf i = 9 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 10 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            End If
            loc = loc + (TBox2(i).text / blockcount * 2.75)
            Hbox(i).text = TBox2(i).text
            ListBox2.Items.Add("Frame " + i.ToString + " added with size " + Hbox(i).Text)
        Next i

        '-----------------------------------

        Dim bfid As Integer

        For currentproc As Integer = 1 To processcount

            For currentblock As Integer = 1 To blockcount

                currentblocksize = Hbox(currentblock).text
                currentprocsize = TBox(currentproc).text


                If currentblocksize >= currentprocsize Then

                    'algorithm matters. first off, check if bfid is nothing. if so, assign currentblock number to bfid
                    If bfid = Nothing Then
                        bfid = currentblock
                    End If

                    If currentblocksize = Hbox(bfid).text Then
                        GoTo nextbf
                    End If

                    If currentblocksize < Hbox(bfid).text Then
                        bfid = currentblock
                    End If
                End If

nextbf:

            Next currentblock

            If bfid = Nothing Then
                GoTo doesnotfit2
            End If

            If currentproc <= Hbox(bfid).text Then
                If currentproc = 1 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 2 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 3 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 4 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 5 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 6 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 7 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 8 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 9 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 10 Then
                    Panels(bfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
                    GoTo fits2
                End If
            End If

doesnotfit2:
            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Process " + currentproc.ToString + " is unallocated")
            ListBox1.Items.Add("Process " + currentproc.ToString + " is unallocated")
            'reset bfid value
            bfid = Nothing
            GoTo nextproc2


fits2:
            Hbox(bfid).text = 0
            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
            ListBox2.Items.Add("at frame " + bfid.ToString)
            'reset bfid value
            bfid = Nothing
            TextBox34.Text = CInt(TextBox34.Text) - 1
nextproc2:
        Next currentproc

    End Sub

    Public Sub WFit()

        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Add("Log Cleared")
        ListBox2.Items.Add("Worst Fit initiated")

        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}

        'hbox are composed of hidden textboxes. they serve as the temp.

        Dim Hbox() As Object = {Nothing, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30, TextBox31, TextBox32, TextBox33}
        Dim Panels() As Object = {Nothing, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14}

        Dim currentblocksize As Integer
        Dim currentprocsize As Integer


        Dim loc As Double
        Dim processcount As Integer
        Dim blockcount As Integer

        'get block
        blockcount = TextBox2.Text
        processcount = TextBox1.Text
        loc = 0

        'frames initialize first
        For i As Integer = 1 To blockcount
            Panels(i).location = New System.Drawing.Point(0, loc)
            Panels(i).size = New System.Drawing.Size(159, (TBox2(i).text) / blockcount * 2.75)
            If i = 1 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ElseIf i = 2 Then
                Panels(i).BackColor = System.Drawing.Color.Maroon
            ElseIf i = 3 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 4 Then
                Panels(i).BackColor = System.Drawing.Color.Olive
            ElseIf i = 5 Then
                Panels(i).BackColor = System.Drawing.Color.Green
            ElseIf i = 6 Then
                Panels(i).BackColor = System.Drawing.Color.Teal
            ElseIf i = 7 Then
                Panels(i).BackColor = System.Drawing.Color.Navy
            ElseIf i = 8 Then
                Panels(i).BackColor = System.Drawing.Color.Purple
            ElseIf i = 9 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            ElseIf i = 10 Then
                Panels(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            End If
            loc = loc + (TBox2(i).text / blockcount * 2.75)
            Hbox(i).text = TBox2(i).text
            ListBox2.Items.Add("Frame " + i.ToString + " added with size " + Hbox(i).Text)
        Next i

        '-----------------------------------

        Dim wfid As Integer

        For currentproc As Integer = 1 To processcount

            For currentblock As Integer = 1 To blockcount

                currentblocksize = Hbox(currentblock).text
                currentprocsize = TBox(currentproc).text


                If currentblocksize >= currentprocsize Then

                    'algorithm matters. first off, check if bfid is nothing. if so, assign currentblock number to bfid
                    If wfid = Nothing Then
                        wfid = currentblock
                    End If

                    If currentblocksize = Hbox(wfid).text Then
                        GoTo nextwf
                    End If

                    If currentblocksize > Hbox(wfid).text Then
                        wfid = currentblock
                    End If
                End If

nextwf:

            Next currentblock

            If wfid = Nothing Then
                GoTo doesnotfit2
            End If

            If currentproc <= Hbox(wfid).text Then
                If currentproc = 1 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 2 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 3 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 4 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 5 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 6 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 7 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 8 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 9 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                    GoTo fits2
                ElseIf currentproc = 10 Then
                    Panels(wfid).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
                    GoTo fits2
                End If
            End If

doesnotfit2:
            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Process " + currentproc.ToString + " is unallocated")
            ListBox1.Items.Add("Process " + currentproc.ToString + " is unallocated")
            'reset wfid value
            wfid = Nothing
            GoTo nextproc2


fits2:
            Hbox(wfid).text = 0
            ListBox2.Items.Add("===")
            ListBox2.Items.Add("Allocated Process " + currentproc.ToString)
            ListBox2.Items.Add("at frame " + wfid.ToString)
            'reset wfid value
            wfid = Nothing
            TextBox34.Text = CInt(TextBox34.Text) - 1
nextproc2:
        Next currentproc

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MVTMMnew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class