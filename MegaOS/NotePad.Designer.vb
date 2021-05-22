<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotePad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotePad))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorFonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorFundoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarAjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Texto = New System.Windows.Forms.TextBox()
        Me.CorFonte = New System.Windows.Forms.ColorDialog()
        Me.CorFundo = New System.Windows.Forms.ColorDialog()
        Me.Fonte = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.SobreToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.AbrirToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovoToolStripMenuItem.Text = "Novo.."
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FonteToolStripMenuItem, Me.CorFonteToolStripMenuItem, Me.CorFundoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'FonteToolStripMenuItem
        '
        Me.FonteToolStripMenuItem.Name = "FonteToolStripMenuItem"
        Me.FonteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FonteToolStripMenuItem.Text = "Fonte"
        '
        'CorFonteToolStripMenuItem
        '
        Me.CorFonteToolStripMenuItem.Name = "CorFonteToolStripMenuItem"
        Me.CorFonteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CorFonteToolStripMenuItem.Text = "Cor Fonte"
        '
        'CorFundoToolStripMenuItem
        '
        Me.CorFundoToolStripMenuItem.Name = "CorFundoToolStripMenuItem"
        Me.CorFundoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CorFundoToolStripMenuItem.Text = "Cor Fundo"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarAjudaToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'MostrarAjudaToolStripMenuItem
        '
        Me.MostrarAjudaToolStripMenuItem.Name = "MostrarAjudaToolStripMenuItem"
        Me.MostrarAjudaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MostrarAjudaToolStripMenuItem.Text = "Mostrar Ajuda"
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(0, 27)
        Me.Texto.Multiline = True
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(693, 487)
        Me.Texto.TabIndex = 2
        '
        'NotePad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 514)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NotePad"
        Me.Text = "NotePad - Bloco de Notas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FonteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorFonteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorFundoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarAjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Texto As TextBox
    Friend WithEvents CorFonte As ColorDialog
    Friend WithEvents CorFundo As ColorDialog
    Friend WithEvents Fonte As FontDialog
End Class
