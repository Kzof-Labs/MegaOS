Public Class configuracoes
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FundoBT.ShowDialog()
        desktop.BT.BackColor = FundoBT.Color
        Panel1.BackColor = FundoBT.Color



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IO.Directory.Exists(Environ("UserProfile") & "\megasystem") Then
        Else
            IO.Directory.CreateDirectory(Environ("UserProfile") & "\megasystem")
        End If
        PapelParede.ShowDialog()
        If IO.File.Exists(PapelParede.FileName) Then
            PictureBox1.ImageLocation = PapelParede.FileName
            FileCopy(PapelParede.FileName, Environ("UserProfile") & "\megasystem\wall.png")
            desktop.PictureBox1.ImageLocation = PapelParede.FileName

        Else
            MessageBox.Show("Papel parede invalido ou não escolhido!")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources._36595473_balloon_wallpaper
        IO.File.Delete(Environ("UserProfile") & "\megasystem\wall.png")
        desktop.PictureBox1.Image = My.Resources._36595473_balloon_wallpaper

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.above_adventure_aerial_air
        IO.File.Delete(Environ("UserProfile") & "\megasystem\wall.png")
        desktop.PictureBox1.Image = My.Resources.above_adventure_aerial_air
    End Sub

    Private Sub configuracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = desktop.PictureBox1.Image
        Panel1.BackColor = desktop.BT.BackColor

    End Sub
End Class