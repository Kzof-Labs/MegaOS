Public Class desktop
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Iniciar.Visible = False Then
            Iniciar.Visible = True

        ElseIf Iniciar.Visible = True Then
            Iniciar.Visible = False

        End If


    End Sub

    Private Sub Data_Tick(sender As Object, e As EventArgs) Handles Data.Tick
        Tempo.Text = TimeOfDay
        Dia.Text = Today

    End Sub

    Private Sub desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(Environ("UserProfile") & "\megasystem\wall.png") Then

            PictureBox1.ImageLocation = Environ("UserProfile") & "\megasystem\wall.png"
        Else

            PictureBox1.Image = My.Resources.above_adventure_aerial_air
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PowerPlus.Show()
        PowerPlus.WindowState = FormWindowState.Minimized
        PowerPlus.WindowState = FormWindowState.Normal

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NotePad.Show()
        NotePad.WindowState = FormWindowState.Minimized
        NotePad.WindowState = FormWindowState.Normal

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("O Explorador de Arquivos não está disponivel nesta versão.")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        configuracoes.Show()
        configuracoes.WindowState = FormWindowState.Minimized
        configuracoes.WindowState = FormWindowState.Normal
        Iniciar.Visible = False

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PainelDeControle.Show()
        Iniciar.Visible = False

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PowerPlus.Show()
        PowerPlus.WindowState = FormWindowState.Minimized
        PowerPlus.WindowState = FormWindowState.Normal
        Iniciar.Visible = False

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        MessageBox.Show("Desligando o sistema. ")
        MsgBox("Obrigado por usar MegaOS")
        End

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MsgBox("Impossível conectar-se com a Loja. Verifique sua conexão e tente novamente.")
    End Sub
End Class
