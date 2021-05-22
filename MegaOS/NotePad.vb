Public Class NotePad
    Private Sub FonteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FonteToolStripMenuItem.Click
        Fonte.ShowDialog()
        Texto.Font = Fonte.Font

    End Sub

    Private Sub CorFonteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorFonteToolStripMenuItem.Click
        CorFonte.ShowDialog()
        Texto.ForeColor = CorFonte.Color

    End Sub

    Private Sub CorFundoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorFundoToolStripMenuItem.Click
        CorFundo.ShowDialog()
        Texto.BackColor = CorFundo.Color
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        SobreNotepad.Show()
        SobreNotepad.WindowState = FormWindowState.Minimized
        SobreNotepad.WindowState = FormWindowState.Normal

    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Texto.Text = ""

    End Sub

    Private Sub MostrarAjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarAjudaToolStripMenuItem.Click
        AjudaNTP.show

    End Sub
End Class