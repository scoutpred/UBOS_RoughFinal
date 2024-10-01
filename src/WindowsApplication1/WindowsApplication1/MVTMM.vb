Public Class MVTMM


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TextBox1.KeyUp

        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim Lbels() As Object = {Nothing, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14}
        Dim procnum As Integer
        Dim rescount As Integer

        If TextBox1.Text = Nothing Then

            GoTo NoneHappens
        ElseIf TextBox1.Text = 0 Then
            TextBox1.Text = 10

        End If

        rescount = TextBox1.Text


        If TextBox1.Text Is Nothing Then
            Label4.Text = "Process input is empty."
        ElseIf TextBox1.Text > 10 Then
            Label4.Text = "Process should be more than 10"
        Else
            For procnum = 1 To rescount
                TBox(procnum).Visible = True
                Lbels(procnum).visible = True
            Next procnum
            Label4.Text = "Process inputs created. Awaiting Frame Inputs."
            Button1.Enabled = False
            TextBox1.Enabled = False

            Button2.Enabled = True
            TextBox2.Enabled = True

        End If
NoneHappens:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TextBox2.KeyUp
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}
        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim Lbels2() As Object = {Nothing, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label24}
        Dim framnum As Integer
        Dim procnum As Integer
        Dim framcount As Integer
        Dim rescount As Integer

        If TextBox2.Text = Nothing Then

            GoTo NoneHappens
        ElseIf TextBox2.Text = 0 Then
            TextBox2.Text = 10

        End If

        framcount = TextBox2.Text
        rescount = TextBox1.Text

        If TextBox2.Text Is Nothing Then
            Label4.Text = "Frame input is empty."
        ElseIf TextBox2.Text > 10 Then
            Label4.Text = "Frame should be more than 10"
        Else
            For framnum = 1 To framcount
                TBox2(framnum).Visible = True
                Lbels2(framnum).visible = True

            Next framnum

            For procnum = 1 To rescount
                TBox(procnum).enabled = True
            Next procnum

            Label4.Text = "Frame inputs created. Please input process size."
            Button2.Enabled = False
            TextBox2.Enabled = False
            Button5.Enabled = True
            Button3.Enabled = True

            Button4.Enabled = True

        End If
NoneHappens:
    End Sub





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text Is Nothing Then
            Label4.Text = "Cannot count as frame input is invalid."
        Else
            TextBox23.Text = TextBox2.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm = New MVTMM
        frm.Show()
        frm.ListBox2.Items.Add("Values Reset")
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}
        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim Panels() As Object = {Nothing, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14}
        Dim framnum As Integer
        Dim procnum As Integer
        Dim framcount As Integer
        Dim rescount As Integer
        framcount = TextBox2.Text
        rescount = TextBox1.Text

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True

        ListBox2.Items.Add("Qfit Initiated")
        QFit()

    End Sub

    'FirstFit

    Public Sub QFit()
        Dim TBox2() As Object = {Nothing, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22}
        Dim TBox() As Object = {Nothing, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
        Dim Panels() As Object = {Nothing, Panel5, Panel6, Panel7, Panel8, Panel9, Panel10, Panel11, Panel12, Panel13, Panel14}

        Dim framnum As Integer
        Dim procnum As Integer
        Dim framcount As Integer
        Dim rescount As Integer
        Dim loc As Integer
        Dim p As Integer
        Dim currentres As Integer
        Dim currentfram As Integer

        framcount = TextBox2.Text
        ListBox2.Items.Add("Frame count set to " + framcount.ToString)
        rescount = TextBox1.Text
        ListBox2.Items.Add("Process count set to " + rescount.ToString)
        loc = 0


        'frame panels initialize first

        For i As Integer = 1 To framcount
            Panels(i).location = New System.Drawing.Point(0, loc)
            Panels(i).size = New System.Drawing.Size(159, (TBox2(i).text) / framcount * 2.75)
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
            loc = loc + (TBox2(i).text / framcount * 2.75)
            ListBox2.Items.Add("Panel " + i.ToString + " Initiated")
        Next i

        'FFit Implementation

        For i As Integer = 1 To rescount
            ListBox2.Items.Add("At Process " + i.ToString)
            For x As Integer = 1 To framcount
                ListBox2.Items.Add("At frame " + x.ToString)

                currentres = TBox(i).text
                ListBox2.Items.Add("Current Process Size " + i.ToString + " is " + currentres.ToString)
                currentfram = TBox2(x).text
                ListBox2.Items.Add("Current Frame Size " + x.ToString + " is " + currentfram.ToString)

                If currentfram >= currentres Then
                    ListBox2.Items.Add("Frame" + x.ToString + " with size " + currentfram.ToString + " is greater than " + currentres.ToString + ". Now assigning")

                    If x = 1 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 2 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 3 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 4 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 5 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 6 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 7 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 8 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 9 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                        GoTo nextfram
                    ElseIf x = 10 Then
                        Panels(x).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
                        GoTo nextfram
                    End If

                    If currentfram < currentres Then
                        ListBox2.Items.Add("Frame" + x.ToString + " with size " + currentfram.ToString + " is less than " + currentres.ToString + ". Skipping...")
                    End If
                End If
            Next x
nextfram:
            ListBox2.Items.Add(">>Process " + i.ToString + " assigned. Proceeding to next process.")
        Next i

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class