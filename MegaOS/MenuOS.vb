Public Class MenuOS
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        configuracoes.Show()
        configuracoes.WindowState = FormWindowState.Minimized
        configuracoes.WindowState = FormWindowState.Normal
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PowerPlus.Show()
        PowerPlus.WindowState = FormWindowState.Minimized
        PowerPlus.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PainelDeControle.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class