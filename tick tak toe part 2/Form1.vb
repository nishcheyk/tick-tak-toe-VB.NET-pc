Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startm.Hide()
        tiktak.Hide()

        MAIN.Show()
        My.Computer.Audio.Play("C:\Users\ACER\Music\Minoru 187 - Gaming Background Music (HD).wav.wav")
        XTURN.Visible = True
        OTURN.Visible = False
    End Sub

    Private Sub PlayC_Click(sender As Object, e As EventArgs) Handles PlayC.Click
        Startm.Show()
        MAIN.Hide()
    End Sub

    Private Sub PlayM_Click(sender As Object, e As EventArgs) Handles PlayM.Click
        Form2.Show()
        Me.Hide()
    End Sub









    ' TO SET THE  TURN OF PLAYER ONE BY ONE WHEN WE CLICK ON THE BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "" Then
            If XTURN.Visible = True Then

                Button1.Text = "X"
                Button1.BackColor = Color.CornflowerBlue
                Button1.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If


            ElseIf OTURN.Visible = True Then

                Button1.Text = "O"
                Button1.BackColor = Color.SteelBlue
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
                Button2.BackColor = Color.CornflowerBlue
                Button2.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button2.Text = "O"
                Button2.BackColor = Color.SteelBlue
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
                Button3.BackColor = Color.CornflowerBlue
                Button3.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button3.Text = "O"
                Button3.BackColor = Color.SteelBlue
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
                Button4.BackColor = Color.CornflowerBlue
                Button4.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button4.Text = "O"
                Button4.BackColor = Color.SteelBlue
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
                Button5.BackColor = Color.CornflowerBlue
                Button5.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button5.Text = "O"
                Button5.BackColor = Color.SteelBlue
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
                Button6.BackColor = Color.CornflowerBlue
                Button6.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button6.Text = "O"
                Button6.BackColor = Color.SteelBlue
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
                Button7.BackColor = Color.CornflowerBlue
                Button7.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If

            ElseIf OTURN.Visible = True Then

                Button7.Text = "O"
                Button7.BackColor = Color.SteelBlue
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
                Button8.BackColor = Color.CornflowerBlue
                Button8.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button8.Text = "O"
                Button8.BackColor = Color.SteelBlue
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
                Button9.BackColor = Color.CornflowerBlue
                Button9.ForeColor = Color.Black
                XTURN.Visible = False
                OTURN.Visible = True
                If XPLAYER1.Checked = True Then
                    ComputerturnO()
                End If
            ElseIf OTURN.Visible = True Then

                Button9.Text = "O"
                Button9.BackColor = Color.SteelBlue
                Button9.ForeColor = Color.White
                OTURN.Visible = False
                XTURN.Visible = True
                If OPLAYER1.Checked = True Then
                    ComputerturnX()
                End If


            End If
        End If

    End Sub








    'staring game with computer
    Private Sub Startc_Click_1(sender As Object, e As EventArgs) Handles Startc.Click
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

    'EXIT BUTTON 
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Close()
    End Sub


    'STARTING THE  GAME TO PLAY BY CLICKING STAT BUTTON
    Private Sub Startc_Click(sender As Object, e As EventArgs)


    End Sub



    'new game
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MAIN.Show()
        tiktak.Hide()
        TextBox1.Text = ""

        XPLAYER1.Checked = False

        OPLAYER1.Checked = False


        Resetbutton()
        Score1.Text = 0
        Score2.Text = 0
    End Sub


    'music playstop
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










    Private Sub XPLAYER1_CheckStateChanged(sender As Object, e As EventArgs)
        If XPLAYER1.Checked = True Then

            OPLAYER1.Checked = False

        End If



    End Sub




    Private Sub OPLAYER1_CheckStateChanged(sender As Object, e As EventArgs)
        If OPLAYER1.Checked = True Then

            XPLAYER1.Checked = False

        End If



    End Sub




    'all the functions use in the program 
    Public Function ComputerturnX()

        ' array of all the button
        Dim But As Button() = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
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
                    B.BackColor = Color.CornflowerBlue
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
            If (B Is Button1 Or B Is Button3 Or B Is Button7 Or B Is Button9) Then
                cornerbutton.Add(B)
            End If

        Next
        Dim tempbut As Button
        If cornerbutton.Count > 0 Then
            tempbut = cornerbutton(New Random().Next(0, cornerbutton.Count - 1))
            tempbut.Text = "X"
            tempbut.BackColor = Color.CornflowerBlue
            tempbut.ForeColor = Color.Black
            XTURN.Visible = False
            OTURN.Visible = True
            Return (True)
        End If
        ' Middle one
        If Possibleinput.Contains(Button5) Then
            Button5.Text = "X"
            Button5.BackColor = Color.CornflowerBlue
            Button5.ForeColor = Color.Black
            XTURN.Visible = False
            OTURN.Visible = True
            Return (True)
        End If
        'edgemiddel one
        Dim edge As New List(Of Button)

        For Each tB As Button In Possibleinput
            If (tB Is Button2 Or tB Is Button4 Or tB Is Button6 Or tB Is Button8) Then
                edge.Add(tB)
            End If
        Next

        If edge.Count > 0 Then
            tempbut = edge(New Random().Next(0, edge.Count - 1))
            tempbut.Text = "X"
            tempbut.BackColor = Color.CornflowerBlue
            Button7.ForeColor = Color.Black
            XTURN.Visible = False
            OTURN.Visible = True
            Return (True)
        End If
        Return (False)

    End Function


    Public Function Winnerfu(ByVal cor As Char)
        Return (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = cor Or
            Button4.Text = "X" And Button5.Text = "X" And Button6.Text = cor Or
            Button7.Text = "X" And Button8.Text = "X" And Button9.Text = cor Or
            Button1.Text = "X" And Button4.Text = "X" And Button7.Text = cor Or
            Button2.Text = "X" And Button5.Text = "X" And Button8.Text = cor Or
            Button3.Text = "X" And Button6.Text = "X" And Button9.Text = cor Or
            Button1.Text = "X" And Button5.Text = "X" And Button9.Text = cor Or
            Button3.Text = "X" And Button5.Text = "X" And Button7.Text = cor Or
            Button1.Text = "O" And Button2.Text = "O" And Button3.Text = cor Or
            Button4.Text = "O" And Button5.Text = "O" And Button6.Text = cor Or
            Button7.Text = "O" And Button8.Text = "O" And Button9.Text = cor Or
            Button1.Text = "O" And Button4.Text = "O" And Button7.Text = cor Or
            Button2.Text = "O" And Button5.Text = "O" And Button8.Text = cor Or
            Button3.Text = "O" And Button6.Text = "O" And Button9.Text = cor Or
            Button1.Text = "O" And Button5.Text = "O" And Button9.Text = cor Or
            Button3.Text = "O" And Button5.Text = "O" And Button7.Text = cor)


    End Function

    Public Function ComputerturnO()

        ' array of all the button
        Dim But As Button() = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
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
                    B.BackColor = Color.SteelBlue
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
            If (B Is Button1 Or B Is Button3 Or B Is Button7 Or B Is Button9) Then
                cornerbutton.Add(B)
            End If

        Next
        Dim tempbut As Button
        If cornerbutton.Count > 0 Then
            tempbut = cornerbutton(New Random().Next(0, cornerbutton.Count - 1))
            tempbut.Text = "O"
            tempbut.BackColor = Color.SteelBlue
            tempbut.ForeColor = Color.White
            OTURN.Visible = False

            XTURN.Visible = True
            Return (True)
        End If
        ' Middle one
        If Possibleinput.Contains(Button5) Then
            Button5.Text = "O"
            Button5.BackColor = Color.SteelBlue
            Button5.ForeColor = Color.White
            OTURN.Visible = False
            XTURN.Visible = True
            Return (True)
        End If
        'edgemiddel one
        Dim edge As New List(Of Button)

        For Each tB As Button In Possibleinput
            If (tB Is Button2 Or tB Is Button4 Or tB Is Button6 Or tB Is Button8) Then
                edge.Add(tB)
            End If
        Next

        If edge.Count > 0 Then
            tempbut = edge(New Random().Next(0, edge.Count - 1))
            tempbut.Text = "O"
            tempbut.BackColor = Color.SteelBlue
            tempbut.ForeColor = Color.White
            OTURN.Visible = False
            XTURN.Visible = True
            Return (True)
        End If
        Return (False)
    End Function


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
            Else
                Score1.Text += 1
                MessageBox.Show("Oh computer has defeted you ")


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
        Button9.Text <> "" Then


            Dim player2name As String = Label4.Text
            Dim player1name As String = " Computer"
            MessageBox.Show(" ooh " & player2name & " " & player1name & " tick tak toe game is draw  ")

            Resetbutton()


        End If

    End Sub

    Private Sub tiktak_VisibleChanged(sender As Object, e As EventArgs) Handles tiktak.VisibleChanged

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

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Resetbutton()

    End Sub

End Class