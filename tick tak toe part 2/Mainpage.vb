Public Class Mainpage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MAIN.Show()
        My.Computer.Audio.Play("C:\Users\ACER\Music\Minoru 187 - Gaming Background Music (HD).wav.wav")

    End Sub

    Private Sub PlayC_Click(sender As Object, e As EventArgs) Handles PlayC.Click
        ComputerT.Show()
        MAIN.Hide()
    End Sub

    Private Sub PlayM_Click(sender As Object, e As EventArgs) Handles PlayM.Click
        MULTIPLAYERT.Show()
        MAIN.Hide()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles t3.Click
        MTHREE.Show()

        Me.Hide()
    End Sub

    Private Sub Tile3_Click(sender As Object, e As EventArgs) Handles tile3.Click
        CTHREE.Show()
        Me.Hide()
    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Me.Close()
    End Sub

    Private Sub tile4_Click(sender As Object, e As EventArgs) Handles tile4.Click
        CFOUR.Show()
        Me.Hide()
    End Sub

    Private Sub t4_Click(sender As Object, e As EventArgs) Handles t4.Click
        MFOUR.Show()
        Me.Hide()
    End Sub
End Class

