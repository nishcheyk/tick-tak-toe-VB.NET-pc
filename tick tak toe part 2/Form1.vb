Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerT.Hide()
        MULTIPLAYERT.Hide()
        MAIN.Show()


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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles t3.Click
        MTHREE.Show()

        Me.Hide()
    End Sub

    Private Sub Tile3_Click(sender As Object, e As EventArgs) Handles tile3.Click
        CTHREE.Show()
        Me.Hide()
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Me.Close()
    End Sub

    Private Sub Tile4_Click(sender As Object, e As EventArgs) Handles tile4.Click
        CFOUR.Show()
        Me.Hide()
    End Sub

    Private Sub T4_Click(sender As Object, e As EventArgs) Handles t4.Click
        MFOUR.Show()
        Me.Hide()
    End Sub
End Class

