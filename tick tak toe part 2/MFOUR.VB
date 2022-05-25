Public Class MFOUR
    Private Const V As Boolean = False
    Private Const V1 As Boolean = True

    Private Sub XPLAYER1_CheckStateChanged(sender As Object, e As EventArgs) Handles XPLAYER1.CheckStateChanged
        If XPLAYER1.Checked = V1 Then

            OPLAYER1.Checked = V
            OPLAYER2.Checked = V1
            XPLAYER2.Checked = V
        End If

        If XPLAYER1.Checked = V Then
            XPLAYER2.Checked = V1
            OPLAYER1.Checked = V1
        End If

    End Sub


    Private Sub XPLAYER2_CheckStateChanged(sender As Object, e As EventArgs) Handles XPLAYER2.CheckStateChanged
        If XPLAYER2.Checked = V1 Then

            OPLAYER2.Checked = V
            OPLAYER1.Checked = V1
            XPLAYER1.Checked = V
        End If

        If XPLAYER2.Checked = V Then
            XPLAYER1.Checked = V1
            OPLAYER2.Checked = V1
        End If

    End Sub


    Private Sub OPLAYER1_CheckStateChanged(sender As Object, e As EventArgs) Handles OPLAYER1.CheckStateChanged
        If OPLAYER1.Checked = V1 Then
            XPLAYER2.Checked = V1
            OPLAYER2.Checked = V
            XPLAYER1.Checked = V

        End If


        If OPLAYER1.Checked = V Then
            OPLAYER2.Checked = V1
            XPLAYER1.Checked = V1
        End If


    End Sub

    Private Sub OPLAYER2_CheckStateChanged(sender As Object, e As EventArgs) Handles OPLAYER2.CheckStateChanged
        If OPLAYER2.Checked = V1 Then
            XPLAYER1.Checked = V1
            OPLAYER1.Checked = V
            XPLAYER2.Checked = V

        End If

        If OPLAYER2.Checked = V Then
            OPLAYER1.Checked = V1
            XPLAYER2.Checked = V1
        End If


    End Sub
    Private Sub Tiktaktoe_VisibleChanged(sender As Object, e As EventArgs) Handles tiktaktoe.VisibleChanged


        XTURN.Visible = V1
        OTURN.Visible = V




        If TextBox1.Text IsNot "" Then
            Label4.Text = TextBox1.Text
            XTURN.Text = TextBox1.Text
        End If
        If TextBox2.Text IsNot "" Then
            Label5.Text = TextBox2.Text

        End If
        If XPLAYER1.Checked = V1 Then
            XTURN.Text = Label4.Text & "'s turn(X)"
            OTURN.Text = Label5.Text & "'s turn(O)"

        End If

        If XPLAYER2.Checked = V1 Then
            XTURN.Text = Label5.Text & "'s turn(X)"
            OTURN.Text = Label4.Text & "'s turn(O)"

        End If


    End Sub
    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Me.Close()
    End Sub



    Private Sub Newgame_Click(sender As Object, e As PaintEventArgs) Handles newgame.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub REest_Click(sender As Object, e As EventArgs) Handles REest.Click
        Resetbutton()
    End Sub


    Private Sub MFOUR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiktaktoe.Hide()
        Start1.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "" Then
            If XTURN.Visible = V1 Then

                Button1.Text = "X"
                Button1.BackColor = Color.Beige
                Button1.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = V1



            ElseIf OTURN.Visible = V1 Then

                Button1.Text = "O"
                Button1.BackColor = Color.BurlyWood
                Button1.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = V1



            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Button2.Text = "" Then
            If XTURN.Visible = V1 Then

                Button2.Text = "X"
                Button2.BackColor = Color.Beige
                Button2.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1


            ElseIf OTURN.Visible = V1 Then

                Button2.Text = "O"
                Button2.BackColor = Color.BurlyWood
                Button2.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1

            End If
            Checkforwin()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Button3.Text = "" Then
            If XTURN.Visible = V1 Then

                Button3.Text = "X"
                Button3.BackColor = Color.Beige
                Button3.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button3.Text = "O"
                Button3.BackColor = Color.BurlyWood
                Button3.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1



            End If
            Checkforwin()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Button4.Text = "" Then
            If XTURN.Visible = V1 Then

                Button4.Text = "X"
                Button4.BackColor = Color.Beige
                Button4.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button4.Text = "O"
                Button4.BackColor = Color.BurlyWood
                Button4.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Button5.Text = "" Then
            If XTURN.Visible = V1 Then

                Button5.Text = "X"
                Button5.BackColor = Color.Beige
                Button5.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button5.Text = "O"
                Button5.BackColor = Color.BurlyWood
                Button5.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If Button6.Text = "" Then
            If XTURN.Visible = V1 Then

                Button6.Text = "X"
                Button6.BackColor = Color.Beige
                Button6.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button6.Text = "O"
                Button6.BackColor = Color.BurlyWood
                Button6.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If Button7.Text = "" Then
            If XTURN.Visible = V1 Then

                Button7.Text = "X"
                Button7.BackColor = Color.Beige
                Button7.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button7.Text = "O"
                Button7.BackColor = Color.BurlyWood
                Button7.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If Button8.Text = "" Then
            If XTURN.Visible = V1 Then

                Button8.Text = "X"
                Button8.BackColor = Color.Beige
                Button8.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button8.Text = "O"
                Button8.BackColor = Color.BurlyWood
                Button8.ForeColor = Color.White

                OTURN.Visible = V
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If Button9.Text = "" Then
            If XTURN.Visible = V1 Then

                Button9.Text = "X"
                Button9.BackColor = Color.Beige
                Button9.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button9.Text = "O"
                Button9.BackColor = Color.BurlyWood
                Button9.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = V1



            End If
        End If
        Checkforwin()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If Button10.Text = "" Then
            If XTURN.Visible = V1 Then

                Button10.Text = "X"
                Button10.BackColor = Color.Beige
                Button10.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button10.Text = "O"
                Button10.BackColor = Color.BurlyWood
                Button10.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1


            End If
            Checkforwin()
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If Button11.Text = "" Then
            If XTURN.Visible = V1 Then

                Button11.Text = "X"
                Button11.BackColor = Color.Beige
                Button11.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button11.Text = "O"
                Button11.BackColor = Color.BurlyWood
                Button11.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1

            End If
        End If

        Checkforwin()

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If Button12.Text = "" Then
            If XTURN.Visible = V1 Then

                Button12.Text = "X"
                Button12.BackColor = Color.Beige
                Button12.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button12.Text = "O"
                Button12.BackColor = Color.BurlyWood
                Button12.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If Button13.Text = "" Then
            If XTURN.Visible = V1 Then

                Button13.Text = "X"
                Button13.BackColor = Color.Beige
                Button13.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button13.Text = "O"
                Button13.BackColor = Color.BurlyWood
                Button13.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If Button14.Text = "" Then
            If XTURN.Visible = V1 Then

                Button14.Text = "X"
                Button14.BackColor = Color.Beige
                Button14.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button14.Text = "O"
                Button14.BackColor = Color.BurlyWood
                Button14.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If Button15.Text = "" Then
            If XTURN.Visible = V1 Then

                Button15.Text = "X"
                Button15.BackColor = Color.Beige
                Button15.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button15.Text = "O"
                Button15.BackColor = Color.BurlyWood
                Button15.ForeColor = Color.White

                OTURN.Visible = False
                XTURN.Visible = V1


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If Button9.Text = "" Then
            If XTURN.Visible = V1 Then

                Button16.Text = "X"
                Button16.BackColor = Color.Beige
                Button16.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = V1

            ElseIf OTURN.Visible = V1 Then

                Button16.Text = "O"
                Button16.BackColor = Color.BurlyWood
                Button16.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = V1



            End If
        End If
        Checkforwin()
    End Sub







    Public Sub Resetbutton()
        XTURN.Visible = V1
        OTURN.Visible = False

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
        Button10.BackColor = Color.White
        Button11.BackColor = Color.White
        Button12.BackColor = Color.White
        Button13.BackColor = Color.White
        Button14.BackColor = Color.White
        Button15.BackColor = Color.White
        Button16.BackColor = Color.White


        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button10.Text = ""
        Button11.Text = ""
        Button12.Text = ""
        Button13.Text = ""
        Button14.Text = ""
        Button15.Text = ""
        Button16.Text = ""



    End Sub





    Public Sub Checkforwin()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" And Button4.Text = "X" Or
               Button5.Text = "X" And Button6.Text = "X" And Button7.Text = "X" And Button8.Text = "X" Or
               Button9.Text = "X" And Button10.Text = "X" And Button11.Text = "X" And Button12.Text = "X" Or
               Button13.Text = "X" And Button14.Text = "X" And Button15.Text = "X" And Button16.Text = "X" Or
               Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" And Button13.Text = "X" Or
               Button2.Text = "X" And Button6.Text = "X" And Button10.Text = "X" And Button14.Text = "X" Or
               Button3.Text = "X" And Button7.Text = "X" And Button11.Text = "X" And Button15.Text = "X" Or
               Button4.Text = "X" And Button8.Text = "X" And Button12.Text = "X" And Button16.Text = "X" Or
               Button1.Text = "X" And Button6.Text = "X" And Button11.Text = "X" And Button16.Text = "X" Or
            Button4.Text = "X" And Button7.Text = "X" And Button10.Text = "X" And Button13.Text = "X" Then

            Resetbutton()

            If XPLAYER1.Checked = V1 Then

                Dim player1name As String = Label4.Text
                MessageBox.Show("Congratulation " + player1name + " you have won the game ")
                Score1.Text += 1
            End If

            If XPLAYER2.Checked = V1 Then
                Score2.Text += 1
                Dim player2name As String = Label5.Text
                MessageBox.Show("Congratulation " + player2name + " you have won the game ")


            End If
        End If

        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" And Button4.Text = "O" Or
            Button5.Text = "O" And Button6.Text = "O" And Button7.Text = "O" And Button8.Text = "O" Or
               Button9.Text = "O" And Button10.Text = "O" And Button11.Text = "O" And Button12.Text = "O" Or
                  Button13.Text = "O" And Button14.Text = "O" And Button15.Text = "O" And Button16.Text = "O" Or
               Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" And Button13.Text = "O" Or
               Button2.Text = "O" And Button6.Text = "O" And Button10.Text = "O" And Button14.Text = "O" Or
               Button3.Text = "O" And Button7.Text = "O" And Button11.Text = "O" And Button15.Text = "O" Or
               Button4.Text = "O" And Button8.Text = "O" And Button12.Text = "O" And Button16.Text = "O" Or
               Button1.Text = "O" And Button6.Text = "O" And Button11.Text = "O" And Button16.Text = "O" Or
               Button4.Text = "O" And Button7.Text = "O" And Button10.Text = "O" And Button13.Text = "O" Then

            Resetbutton()

            If XPLAYER1.Checked = V1 Then

                Dim player1name As String = Label5.Text
                MessageBox.Show("Congratulation " & player1name & " you have won the game ")
                Score2.Text += 1
            End If

            If XPLAYER2.Checked = V1 Then
                Score1.Text += 1
                Dim player2name As String = Label4.Text
                MessageBox.Show("Congratulation " & player2name & " you have won the game ")


            End If
        End If

        If Button1.Text <> "" And
            Button2.Text <> "" And
            Button3.Text <> "" And
            Button4.Text <> "" And
            Button5.Text <> "" And
            Button6.Text <> "" And
            Button7.Text <> "" And
            Button8.Text <> "" And
            Button9.Text <> "" And
            Button10.Text <> "" And
           Button11.Text <> "" And
            Button12.Text <> "" And
            Button13.Text <> "" And
            Button14.Text <> "" And
            Button15.Text <> "" And
            Button16.Text <> "" Then




            Dim player2name As String = Label4.Text
            Dim player1name As String = Label5.Text
            MessageBox.Show(" ooh " & player2name & " " & player1name & " tick tak toe game is draw  ")

            Resetbutton()


        End If

    End Sub


    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click


        If XPLAYER1.Checked Or OPLAYER1.Checked Then


            If XPLAYER1.Checked AndAlso OPLAYER1.Checked Then
                MsgBox("Please select only one for player 1",, "ERROR")
            Else
                If XPLAYER2.Checked Or OPLAYER2.Checked Then


                    If XPLAYER2.Checked AndAlso OPLAYER2.Checked Then
                        MsgBox("Please select only one for player 2",, "ERROR")
                    Else

                        Start1.Hide()
                        tiktaktoe.Show()
                    End If

                Else
                    MsgBox("Please select one for player 2",, "ERROR")

                End If
            End If
        Else
            MsgBox("Please select one for player 1",, "ERROR")
        End If




    End Sub


End Class