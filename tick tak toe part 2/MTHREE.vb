Imports System.ComponentModel

Public Class Form2
    Private Const V As Boolean = False
    'EXIT BUTTON 
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Close()
    End Sub

    'STARTING THE  GAME TO PLAY BY CLICKING STAT BUTTON
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
    'LOADING OF THE GAME 
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiktaktoe.Hide()
        Start1.Show()

        My.Computer.Audio.Play("C:\Users\ACER\Music\Minoru 187 - Gaming Background Music (HD).wav.wav")


    End Sub
    ' WHEN X OF FIRST PLAYER  IS CLICK THEN O OF 2 PLAYER ALSO GET CHECK AND VIS VERSA
    Private Sub XPLAYER1_CheckStateChanged(sender As Object, e As EventArgs) Handles XPLAYER1.CheckStateChanged
        If XPLAYER1.Checked = True Then

            OPLAYER1.Checked = V
            OPLAYER2.Checked = True
            XPLAYER2.Checked = V
        End If

        If XPLAYER1.Checked = V Then
            XPLAYER2.Checked = True
            OPLAYER1.Checked = True
        End If

    End Sub


    Private Sub XPLAYER2_CheckStateChanged(sender As Object, e As EventArgs) Handles XPLAYER2.CheckStateChanged
        If XPLAYER2.Checked = True Then

            OPLAYER2.Checked = V
            OPLAYER1.Checked = True
            XPLAYER1.Checked = V
        End If

        If XPLAYER2.Checked = V Then
            XPLAYER1.Checked = True
            OPLAYER2.Checked = True
        End If

    End Sub


    Private Sub OPLAYER1_CheckStateChanged(sender As Object, e As EventArgs) Handles OPLAYER1.CheckStateChanged
        If OPLAYER1.Checked = True Then
            XPLAYER2.Checked = True
            OPLAYER2.Checked = V
            XPLAYER1.Checked = V

        End If


        If OPLAYER1.Checked = V Then
            OPLAYER2.Checked = True
            XPLAYER1.Checked = True
        End If


    End Sub

    Private Sub OPLAYER2_CheckStateChanged(sender As Object, e As EventArgs) Handles OPLAYER2.CheckStateChanged
        If OPLAYER2.Checked = True Then
            XPLAYER1.Checked = True
            OPLAYER1.Checked = V
            XPLAYER2.Checked = V

        End If

        If OPLAYER2.Checked = V Then
            OPLAYER1.Checked = True
            XPLAYER2.Checked = True
        End If


    End Sub

    ' WHEN GAME SHIFT FROM MAIN MENU TO THE GAME DATA WHOCH WILL BE SHARE
    Private Sub Tiktaktoe_VisibleChanged(sender As Object, e As EventArgs) Handles tiktaktoe.VisibleChanged


        XTURN.Visible = True
        OTURN.Visible = V




        If TextBox1.Text IsNot "" Then
            Label4.Text = TextBox1.Text
            XTURN.Text = TextBox1.Text
        End If
        If TextBox2.Text IsNot "" Then
            Label5.Text = TextBox2.Text

        End If
        If XPLAYER1.Checked = True Then
            XTURN.Text = Label4.Text & "'s turn(X)"
            OTURN.Text = Label5.Text & "'s turn(O)"

        End If

        If XPLAYER2.Checked = True Then
            XTURN.Text = Label5.Text & "'s turn(X)"
            OTURN.Text = Label4.Text & "'s turn(O)"

        End If


    End Sub

    '  FUNCTION TO CHECK IF SHOME ONE IS  WINS
    Public Sub Checkforwin()

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Or
            Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Or
            Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Or
            Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Or
            Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Or
            Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Or
            Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Or
            Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Resetbutton()

            If XPLAYER1.Checked = True Then

                Dim player1name As String = Label4.Text
                MessageBox.Show("Congratulation " + player1name + " you have won the game ")
                Score1.Text += 1
            End If

            If XPLAYER2.Checked = True Then
                Score2.Text += 1
                Dim player2name As String = Label5.Text
                MessageBox.Show("Congratulation " + player2name + " you have won the game ")


            End If
        End If

        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Or
           Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Or
           Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Or
           Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Or
           Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Or
           Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Or
           Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Or
           Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then


            Resetbutton()

            If XPLAYER1.Checked = True Then

                Dim player1name As String = Label5.Text
                MessageBox.Show("Congratulation " & player1name & " you have won the game ")
                Score2.Text += 1
            End If

            If XPLAYER2.Checked = True Then
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
        Button9.Text <> "" Then


            Dim player2name As String = Label4.Text
            Dim player1name As String = Label5.Text
            MessageBox.Show(" ooh " & player2name & " " & player1name & " tick tak toe game is draw  ")

            Resetbutton()


        End If





    End Sub



    'FUNCTION TO RESET THE GAME 
    Public Sub Resetbutton()
        XTURN.Visible = True
        OTURN.Visible = V

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""



    End Sub


    ' TO SET THE  TURN OF PLAYER ONE BY ONE WHEN WE CLICK ON THE BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "" Then
            If XTURN.Visible = True Then

                Button1.Text = "X"
                Button1.BackColor = Color.CornflowerBlue
                Button1.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True


            ElseIf OTURN.Visible = True Then

                Button1.Text = "O"
                Button1.BackColor = Color.SteelBlue
                Button1.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Button2.Text = "" Then
            If XTURN.Visible = True Then

                Button2.Text = "X"
                Button2.BackColor = Color.CornflowerBlue
                Button2.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True


            ElseIf OTURN.Visible = True Then

                Button2.Text = "O"
                Button2.BackColor = Color.SteelBlue
                Button2.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
            Checkforwin()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Button3.Text = "" Then
            If XTURN.Visible = True Then

                Button3.Text = "X"
                Button3.BackColor = Color.CornflowerBlue
                Button3.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True


            ElseIf OTURN.Visible = True Then

                Button3.Text = "O"
                Button3.BackColor = Color.SteelBlue
                Button3.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
            Checkforwin()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Button4.Text = "" Then
            If XTURN.Visible = True Then

                Button4.Text = "X"
                Button4.BackColor = Color.CornflowerBlue
                Button4.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True


            ElseIf OTURN.Visible = True Then

                Button4.Text = "O"
                Button4.BackColor = Color.SteelBlue
                Button4.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
        End If

        Checkforwin()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Button5.Text = "" Then
            If XTURN.Visible = True Then

                Button5.Text = "X"
                Button5.BackColor = Color.CornflowerBlue
                Button5.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True


            ElseIf OTURN.Visible = True Then

                Button5.Text = "O"
                Button5.BackColor = Color.SteelBlue
                Button5.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If Button6.Text = "" Then
            If XTURN.Visible = True Then

                Button6.Text = "X"
                Button6.BackColor = Color.CornflowerBlue
                Button6.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True



            ElseIf OTURN.Visible = True Then

                Button6.Text = "O"
                Button6.BackColor = Color.SteelBlue
                Button6.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If Button7.Text = "" Then
            If XTURN.Visible = True Then

                Button7.Text = "X"
                Button7.BackColor = Color.CornflowerBlue
                Button7.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True



            ElseIf OTURN.Visible = True Then

                Button7.Text = "O"
                Button7.BackColor = Color.SteelBlue
                Button7.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If Button8.Text = "" Then
            If XTURN.Visible = True Then

                Button8.Text = "X"
                Button8.BackColor = Color.CornflowerBlue
                Button8.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True




            ElseIf OTURN.Visible = True Then

                Button8.Text = "O"
                Button8.BackColor = Color.SteelBlue
                Button8.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If Button9.Text = "" Then
            If XTURN.Visible = True Then

                Button9.Text = "X"
                Button9.BackColor = Color.CornflowerBlue
                Button9.ForeColor = Color.Black
                XTURN.Visible = V
                OTURN.Visible = True



            ElseIf OTURN.Visible = True Then

                Button9.Text = "O"
                Button9.BackColor = Color.SteelBlue
                Button9.ForeColor = Color.White
                OTURN.Visible = V
                XTURN.Visible = True
            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Resetbutton()

    End Sub


    ' WHEN NEW GAME IS CLICK  EVERY THING RESET 
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form1.Show()
        Me.Hide()
        tiktaktoe.Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
        XPLAYER1.Checked = V
        XPLAYER2.Checked = V
        OPLAYER1.Checked = V
        OPLAYER2.Checked = V
        Resetbutton()
        Score1.Text = 0
        Score2.Text = 0
    End Sub


    ' TO START AND STOP THE MUSIC 
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Play("C:\Users\ACER\Music\Minoru 187 - Gaming Background Music (HD).wav.wav")
        Button13.Show()
        Button12.Hide()


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        My.Computer.Audio.Stop()
        Button12.Show()
        Button13.Hide()

    End Sub



    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Computer.Audio.Stop()
    End Sub
End Class