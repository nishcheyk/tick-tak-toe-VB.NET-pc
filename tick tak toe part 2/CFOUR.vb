Public Class CFOUR

    ' TO SET THE  TURN OF PLAYER ONE BY ONE WHEN WE CLICK ON THE BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "" Then
            If XTURN.Visible = True Then

                Button1.Text = "X"
                Button1.BackColor = Color.Beige
                Button1.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If


            ElseIf OTURN.Visible = True Then

                Button1.Text = "O"
                Button1.BackColor = Color.BurlyWood
                Button1.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Button2.Text = "" Then
            If XTURN.Visible = True Then

                Button2.Text = "X"
                Button2.BackColor = Color.Beige
                Button2.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button2.Text = "O"
                Button2.BackColor = Color.BurlyWood
                Button2.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If
            End If
            Checkforwin()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Button3.Text = "" Then
            If XTURN.Visible = True Then

                Button3.Text = "X"
                Button3.BackColor = Color.Beige
                Button3.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button3.Text = "O"
                Button3.BackColor = Color.BurlyWood
                Button3.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
            Checkforwin()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Button4.Text = "" Then
            If XTURN.Visible = True Then

                Button4.Text = "X"
                Button4.BackColor = Color.Beige
                Button4.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button4.Text = "O"
                Button4.BackColor = Color.BurlyWood
                Button4.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Button5.Text = "" Then
            If XTURN.Visible = True Then

                Button5.Text = "X"
                Button5.BackColor = Color.Beige
                Button5.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button5.Text = "O"
                Button5.BackColor = Color.BurlyWood
                Button5.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If Button6.Text = "" Then
            If XTURN.Visible = True Then

                Button6.Text = "X"
                Button6.BackColor = Color.Beige
                Button6.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button6.Text = "O"
                Button6.BackColor = Color.BurlyWood
                Button6.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If Button7.Text = "" Then
            If XTURN.Visible = True Then

                Button7.Text = "X"
                Button7.BackColor = Color.Beige
                Button7.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button7.Text = "O"
                Button7.BackColor = Color.BurlyWood
                Button7.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If Button8.Text = "" Then
            If XTURN.Visible = True Then

                Button8.Text = "X"
                Button8.BackColor = Color.Beige
                Button8.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button8.Text = "O"
                Button8.BackColor = Color.BurlyWood
                Button8.ForeColor = Color.White

                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If Button9.Text = "" Then
            If XTURN.Visible = True Then

                Button9.Text = "X"
                Button9.BackColor = Color.Beige
                Button9.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button9.Text = "O"
                Button9.BackColor = Color.BurlyWood
                Button9.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If Button10.Text = "" Then
            If XTURN.Visible = True Then

                Button10.Text = "X"
                Button10.BackColor = Color.Beige
                Button10.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button10.Text = "O"
                Button10.BackColor = Color.BurlyWood
                Button10.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
            Checkforwin()
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If Button11.Text = "" Then
            If XTURN.Visible = True Then

                Button11.Text = "X"
                Button11.BackColor = Color.Beige
                Button11.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button11.Text = "O"
                Button11.BackColor = Color.BurlyWood
                Button11.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If Button12.Text = "" Then
            If XTURN.Visible = True Then

                Button12.Text = "X"
                Button12.BackColor = Color.Beige
                Button12.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button12.Text = "O"
                Button12.BackColor = Color.BurlyWood
                Button12.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If Button13.Text = "" Then
            If XTURN.Visible = True Then

                Button13.Text = "X"
                Button13.BackColor = Color.Beige
                Button13.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button13.Text = "O"
                Button13.BackColor = Color.BurlyWood
                Button13.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If

            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If Button14.Text = "" Then
            If XTURN.Visible = True Then

                Button14.Text = "X"
                Button14.BackColor = Color.Beige
                Button14.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button14.Text = "O"
                Button14.BackColor = Color.BurlyWood
                Button14.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If Button15.Text = "" Then
            If XTURN.Visible = True Then

                Button15.Text = "X"
                Button15.BackColor = Color.Beige
                Button15.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button15.Text = "O"
                Button15.BackColor = Color.BurlyWood
                Button15.ForeColor = Color.White

                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

        Checkforwin()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If Button9.Text = "" Then
            If XTURN.Visible = True Then

                Button16.Text = "X"
                Button16.BackColor = Color.Beige
                Button16.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button16.Text = "O"
                Button16.BackColor = Color.BurlyWood
                Button16.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

    End Sub







    Public Function Winnerfu(ByVal cor As Char)
        Return (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" And Button4.Text = cor Or
               Button5.Text = "X" And Button6.Text = "X" And Button7.Text = "X" And Button8.Text = cor Or
               Button9.Text = "X" And Button10.Text = "X" And Button11.Text = "X" And Button12.Text = cor Or
                  Button13.Text = "X" And Button14.Text = "X" And Button15.Text = "X" And Button16.Text = cor Or
               Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" And Button13.Text = cor Or
               Button2.Text = "X" And Button6.Text = "X" And Button10.Text = "X" And Button14.Text = cor Or
               Button3.Text = "X" And Button7.Text = "X" And Button11.Text = "X" And Button15.Text = cor Or
               Button4.Text = "X" And Button8.Text = "X" And Button12.Text = "X" And Button16.Text = cor Or
               Button1.Text = "X" And Button6.Text = "X" And Button11.Text = "X" And Button16.Text = cor Or
               Button4.Text = "X" And Button7.Text = "X" And Button10.Text = "X" And Button13.Text = cor Or
               Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" And Button4.Text = cor Or
               Button5.Text = "O" And Button6.Text = "O" And Button7.Text = "O" And Button8.Text = cor Or
               Button9.Text = "O" And Button10.Text = "O" And Button11.Text = "O" And Button12.Text = cor Or
                  Button13.Text = "O" And Button14.Text = "O" And Button15.Text = "O" And Button16.Text = cor Or
               Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" And Button13.Text = cor Or
               Button2.Text = "O" And Button6.Text = "O" And Button10.Text = "O" And Button14.Text = cor Or
               Button3.Text = "O" And Button7.Text = "O" And Button11.Text = "O" And Button15.Text = cor Or
               Button4.Text = "O" And Button8.Text = "O" And Button12.Text = "O" And Button16.Text = cor Or
               Button1.Text = "O" And Button6.Text = "O" And Button11.Text = "O" And Button16.Text = cor Or
            Button4.Text = "O" And Button7.Text = "O" And Button10.Text = "O" And Button13.Text = cor)


    End Function


    Private Sub Tiktak_VisibleChanged(sender As Object, e As EventArgs) Handles tiktak.VisibleChanged

        If TextBox1.Text IsNot "" Then
            Label4.Text = TextBox1.Text

        End If
        If XPLAYER1.Checked = True Then
            XTURN.Text = Label4.Text & "'s turn(X)"
            OTURN.Text = "Computers's turn(O)"

        End If
        If OPLAYER1.Checked = True Then
            XTURN.Text = "Computers's turn(X)"
            OTURN.Text = Label4.Text & "'s turn(O)"

        End If

        XTURN.Visible = True
        If OPLAYER1.Checked = True Then
            ComputerturnX()
            XTURN.Visible = False
            OTURN.Visible = True

        End If

    End Sub






    Public Sub Checkforwin()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" And Button4.Text = "X" Or
               Button5.Text = "X" And Button6.Text = "X" And Button7.Text = "X" And Button8.Text = "X" Or
               Button9.Text = "X" And Button10.Text = "X" And Button11.Text = "X" And Button12.Text = "X" Or
               Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" And Button13.Text = "X" Or
               Button2.Text = "X" And Button6.Text = "X" And Button10.Text = "X" And Button14.Text = "X" Or
               Button3.Text = "X" And Button7.Text = "X" And Button11.Text = "X" And Button15.Text = "X" Or
               Button4.Text = "X" And Button8.Text = "X" And Button12.Text = "X" And Button16.Text = "X" Or
               Button1.Text = "X" And Button6.Text = "X" And Button11.Text = "X" And Button16.Text = "X" Or
            Button4.Text = "X" And Button7.Text = "X" And Button10.Text = "X" And Button13.Text = "X" Then

            Resetbutton()

            If XPLAYER1.Checked = True Then

                Dim player1name As String = Label4.Text
                MessageBox.Show("Congratulation " + player1name + " you have won the game ")
                Score1.Text += 1
            Else
                Score1.Text += 1
                MessageBox.Show("Oh computer has defeted you ")


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

            If XPLAYER1.Checked = True Then



                MessageBox.Show("Oh computer has defeted you ")
                Score2.Text += 1
            End If

            If OPLAYER1.Checked = True Then
                Score2.Text += 1
                Dim player1name As String = Label5.Text
                MessageBox.Show("Congratulation " & player1name & " you have won the game ")


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
            Dim player1name As String = " Computer"
            MessageBox.Show(" ooh " & player2name & " " & player1name & " tick tak toe game is draw  ")

            Resetbutton()


        End If

    End Sub



    Public Sub Resetbutton()
        XTURN.Visible = True
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




    Public Function ComputerturnO()



        ' array of all the button
        Dim But As Button() = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16}
        ' button which are not filled 
        Dim Possibleinput As New List(Of Button)

        For i = 0 To But.Length - 1
            If But(i).Text = "" Then
                Possibleinput.Add(But(i))

            End If

        Next

        Dim chara() As Char = {"O", "X"}
        ' TO CHECK IF X IS WINING SO HOW TO STOP IT 
        For Each c As Char In chara
            For Each B In Possibleinput
                B.Text = c
                If Winnerfu(c) Then
                    B.Text = "O"
                    B.BackColor = Color.BurlyWood
                    B.ForeColor = Color.White
                    OTURN.Visible = False
                    XTURN.Visible = True
                    Return (True)

                End If
                B.Text = ""
            Next
        Next



        ' CORNER BOXES 
        Dim cornerbutton As New List(Of Button)
        For Each B As Button In Possibleinput
            If (B Is Button1 Or B Is Button4 Or B Is Button13 Or B Is Button16) Then
                cornerbutton.Add(B)
            End If

        Next
        Dim tempbut As Button
        If cornerbutton.Count > 0 Then
            tempbut = cornerbutton(New Random().Next(0, cornerbutton.Count - 1))
            tempbut.Text = "O"
            tempbut.BackColor = Color.BurlyWood
            tempbut.ForeColor = Color.White
            OTURN.Visible = False

            XTURN.Visible = True
            Return (True)
        End If
        ' Middle one
        If Possibleinput.Contains(Button5) Then
            Button5.Text = "O"
            Button5.BackColor = Color.BurlyWood
            Button5.ForeColor = Color.White
            OTURN.Visible = False
            XTURN.Visible = True
            Return (True)
        End If
        'edgemiddel one
        Dim edge As New List(Of Button)

        For Each tB As Button In Possibleinput
            If (tB Is Button2 Or tB Is Button3 Or tB Is Button8 Or tB Is Button12 Or tB Is Button14 Or tB Is Button15 Or tB Is Button5 Or tB Is Button9) Then
                edge.Add(tB)
            End If
        Next

        If edge.Count > 0 Then
            tempbut = edge(New Random().Next(0, edge.Count - 1))
            tempbut.Text = "O"
            tempbut.BackColor = Color.BurlyWood
            tempbut.ForeColor = Color.White
            OTURN.Visible = False
            XTURN.Visible = True
            Return (True)
        End If
        Return (False)
    End Function



    Public Function ComputerturnX()

        ' array of all the button
        Dim But As Button() = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16}
        ' button which are not filled 
        Dim Possibleinput As New List(Of Button)

        For i = 0 To But.Length - 1
            If But(i).Text = "" Then
                Possibleinput.Add(But(i))

            End If

        Next

        Dim chara() As Char = {"X", "O"}
        ' TO CHECK IF X IS WINING SO HOW TO STOP IT 
        For Each c As Char In chara
            For Each B In Possibleinput
                B.Text = c
                If Winnerfu(c) Then
                    B.Text = "X"
                    B.BackColor = Color.Beige
                    B.ForeColor = Color.Black
                    XTURN.Visible = False
                    OTURN.Visible = True

                    Return (True)

                End If
                B.Text = ""
            Next
        Next



        ' CORNER BOXES 
        Dim cornerbutton As New List(Of Button)
        For Each B As Button In Possibleinput
            If (B Is Button1 Or B Is Button4 Or B Is Button13 Or B Is Button16) Then
                cornerbutton.Add(B)
            End If

        Next
        Dim tempbut As Button
        If cornerbutton.Count > 0 Then
            tempbut = cornerbutton(New Random().Next(0, cornerbutton.Count - 1))
            tempbut.Text = "X"
            tempbut.BackColor = Color.Beige
            tempbut.ForeColor = Color.Black
            XTURN.Visible = False
            OTURN.Visible = True
            Return (True)
        End If
        ' Middle one
        If Possibleinput.Contains(Button5) Then
            Button5.Text = "X"
            Button5.BackColor = Color.Beige
            Button5.ForeColor = Color.Black
            XTURN.Visible = False
            OTURN.Visible = True
            Return (True)
        End If
        'edgemiddel one
        Dim edge As New List(Of Button)

        For Each tB As Button In Possibleinput
            If (tB Is Button2 Or tB Is Button3 Or tB Is Button8 Or tB Is Button12 Or tB Is Button14 Or tB Is Button15 Or tB Is Button5 Or tB Is Button9) Then
                edge.Add(tB)
            End If
        Next

        If edge.Count > 0 Then
            tempbut = edge(New Random().Next(0, edge.Count - 1))
            tempbut.Text = "X"
            tempbut.BackColor = Color.Beige
            Button7.ForeColor = Color.Black
            XTURN.Visible = False
            OTURN.Visible = True
            Return (True)
        End If
        Return (False)

    End Function

    Private Sub CFOUR_Load(sender As Object, e As EventArgs) Handles Me.Load
        tiktak.Hide()
        Startm.Show()

        My.Computer.Audio.Play("C:\Users\ACER\Music\Minoru 187 - Gaming Background Music (HD).wav.wav")
        XTURN.Visible = True
        OTURN.Visible = False
    End Sub

    Private Sub Startc_Click(sender As Object, e As EventArgs) Handles Startc.Click
        If XPLAYER1.Checked Or OPLAYER1.Checked Then




            If XPLAYER1.Checked AndAlso OPLAYER1.Checked Then
                MsgBox("Please select only one for player 1",, "ERROR")

            Else

                Startm.Hide()
                tiktak.Show()
            End If

        Else
            MsgBox("Please select one for player 1",, "ERROR")
        End If



    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Me.Close()
    End Sub

    Private Sub Button1333_Click(sender As Object, e As EventArgs) Handles Button1333.Click
        My.Computer.Audio.Stop()
        Button133.Show()
        Button1333.Hide()
    End Sub

    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles Button133.Click
        My.Computer.Audio.Play("C:\Users\ACER\Music\Minoru 187 - Gaming Background Music (HD).wav.wav")
        Button1333.Show()
        Button133.Hide()

    End Sub

    Private Sub tiktak_Paint(sender As Object, e As PaintEventArgs) Handles tiktak.Paint
        Mainpage.Show()
        Me.Hide()
    End Sub

    Private Sub REest_Click(sender As Object, e As EventArgs) Handles REest.Click
        Resetbutton()
    End Sub
End Class