<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class desktop
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
		Me.components = New System.ComponentModel.Container()
		Me.BT = New System.Windows.Forms.Panel()
		Me.Dia = New System.Windows.Forms.Label()
		Me.Tempo = New System.Windows.Forms.Label()
		Me.Data = New System.Windows.Forms.Timer(Me.components)
		Me.Iniciar = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.PictureBox7 = New System.Windows.Forms.PictureBox()
		Me.PictureBox8 = New System.Windows.Forms.PictureBox()
		Me.PictureBox9 = New System.Windows.Forms.PictureBox()
		Me.PictureBox10 = New System.Windows.Forms.PictureBox()
		Me.PictureBox11 = New System.Windows.Forms.PictureBox()
		Me.PictureBox6 = New System.Windows.Forms.PictureBox()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.BT.SuspendLayout()
		Me.Iniciar.SuspendLayout()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BT
		'
		Me.BT.BackColor = System.Drawing.Color.Blue
		Me.BT.Controls.Add(Me.PictureBox6)
		Me.BT.Controls.Add(Me.PictureBox5)
		Me.BT.Controls.Add(Me.PictureBox4)
		Me.BT.Controls.Add(Me.PictureBox3)
		Me.BT.Controls.Add(Me.Dia)
		Me.BT.Controls.Add(Me.Tempo)
		Me.BT.Controls.Add(Me.PictureBox2)
		Me.BT.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.BT.Location = New System.Drawing.Point(0, 588)
		Me.BT.Name = "BT"
		Me.BT.Size = New System.Drawing.Size(1273, 54)
		Me.BT.TabIndex = 4
		'
		'Dia
		'
		Me.Dia.Dock = System.Windows.Forms.DockStyle.Right
		Me.Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Dia.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Dia.Location = New System.Drawing.Point(1130, 0)
		Me.Dia.Name = "Dia"
		Me.Dia.Size = New System.Drawing.Size(99, 54)
		Me.Dia.TabIndex = 6
		Me.Dia.Text = "00/00/00"
		'
		'Tempo
		'
		Me.Tempo.AutoSize = True
		Me.Tempo.Dock = System.Windows.Forms.DockStyle.Right
		Me.Tempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Tempo.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Tempo.Location = New System.Drawing.Point(1229, 0)
		Me.Tempo.Name = "Tempo"
		Me.Tempo.Size = New System.Drawing.Size(44, 16)
		Me.Tempo.TabIndex = 5
		Me.Tempo.Text = "00:00"
		'
		'Data
		'
		Me.Data.Enabled = True
		'
		'Iniciar
		'
		Me.Iniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Iniciar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Iniciar.Controls.Add(Me.PictureBox7)
		Me.Iniciar.Controls.Add(Me.Label4)
		Me.Iniciar.Controls.Add(Me.PictureBox8)
		Me.Iniciar.Controls.Add(Me.Label3)
		Me.Iniciar.Controls.Add(Me.PictureBox9)
		Me.Iniciar.Controls.Add(Me.Label2)
		Me.Iniciar.Controls.Add(Me.PictureBox10)
		Me.Iniciar.Controls.Add(Me.Label1)
		Me.Iniciar.Controls.Add(Me.PictureBox11)
		Me.Iniciar.Dock = System.Windows.Forms.DockStyle.Left
		Me.Iniciar.Location = New System.Drawing.Point(0, 0)
		Me.Iniciar.Name = "Iniciar"
		Me.Iniciar.Size = New System.Drawing.Size(246, 588)
		Me.Iniciar.TabIndex = 5
		Me.Iniciar.Visible = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(124, 293)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(63, 13)
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "- PowerPlus"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(124, 209)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(51, 13)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "- Explorer"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(124, 121)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(99, 13)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "- Painel de Controle"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(124, 31)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 13)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "- Configurações"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(558, 9)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(469, 18)
		Me.Label5.TabIndex = 6
		Me.Label5.Text = "Esta é uma versão de teste. Não representa a versão final do produto."
		'
		'PictureBox7
		'
		Me.PictureBox7.Image = Global.MegaOS.My.Resources.Resources.Shut_Down
		Me.PictureBox7.Location = New System.Drawing.Point(8, 360)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(33, 30)
		Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox7.TabIndex = 17
		Me.PictureBox7.TabStop = False
		'
		'PictureBox8
		'
		Me.PictureBox8.Image = Global.MegaOS.My.Resources.Resources.gnome_panel_force_quit
		Me.PictureBox8.Location = New System.Drawing.Point(35, 270)
		Me.PictureBox8.Name = "PictureBox8"
		Me.PictureBox8.Size = New System.Drawing.Size(78, 66)
		Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox8.TabIndex = 15
		Me.PictureBox8.TabStop = False
		'
		'PictureBox9
		'
		Me.PictureBox9.Image = Global.MegaOS.My.Resources.Resources.ftfolder_documents
		Me.PictureBox9.Location = New System.Drawing.Point(35, 186)
		Me.PictureBox9.Name = "PictureBox9"
		Me.PictureBox9.Size = New System.Drawing.Size(78, 66)
		Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox9.TabIndex = 13
		Me.PictureBox9.TabStop = False
		'
		'PictureBox10
		'
		Me.PictureBox10.Image = Global.MegaOS.My.Resources.Resources.lcd_option
		Me.PictureBox10.Location = New System.Drawing.Point(35, 98)
		Me.PictureBox10.Name = "PictureBox10"
		Me.PictureBox10.Size = New System.Drawing.Size(78, 66)
		Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox10.TabIndex = 11
		Me.PictureBox10.TabStop = False
		'
		'PictureBox11
		'
		Me.PictureBox11.Image = Global.MegaOS.My.Resources.Resources.Settings_Icone
		Me.PictureBox11.Location = New System.Drawing.Point(35, 8)
		Me.PictureBox11.Name = "PictureBox11"
		Me.PictureBox11.Size = New System.Drawing.Size(78, 66)
		Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox11.TabIndex = 9
		Me.PictureBox11.TabStop = False
		'
		'PictureBox6
		'
		Me.PictureBox6.Image = Global.MegaOS.My.Resources.Resources.notepad_icon_7
		Me.PictureBox6.Location = New System.Drawing.Point(428, 3)
		Me.PictureBox6.Name = "PictureBox6"
		Me.PictureBox6.Size = New System.Drawing.Size(61, 47)
		Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox6.TabIndex = 10
		Me.PictureBox6.TabStop = False
		'
		'PictureBox5
		'
		Me.PictureBox5.Image = Global.MegaOS.My.Resources.Resources.gnome_panel_force_quit1
		Me.PictureBox5.Location = New System.Drawing.Point(315, 3)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(61, 47)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox5.TabIndex = 9
		Me.PictureBox5.TabStop = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Image = Global.MegaOS.My.Resources.Resources.windows_phone_store_socialnetwork_17377
		Me.PictureBox4.Location = New System.Drawing.Point(206, 3)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(61, 47)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox4.TabIndex = 8
		Me.PictureBox4.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.MegaOS.My.Resources.Resources.ftfolder_documents1
		Me.PictureBox3.Location = New System.Drawing.Point(108, 3)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(61, 47)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 7
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.MegaOS.My.Resources.Resources._512x512bb_85
		Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(61, 47)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 3
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = Global.MegaOS.My.Resources.Resources._36595473_balloon_wallpaper
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1273, 642)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'desktop
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1273, 642)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Iniciar)
		Me.Controls.Add(Me.BT)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "desktop"
		Me.Text = "Form1"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.BT.ResumeLayout(False)
		Me.BT.PerformLayout()
		Me.Iniciar.ResumeLayout(False)
		Me.Iniciar.PerformLayout()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BT As Panel
    Friend WithEvents Dia As Label
    Friend WithEvents Tempo As Label
    Friend WithEvents Data As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Iniciar As Panel
	Friend WithEvents PictureBox7 As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox8 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox9 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox10 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox11 As PictureBox
	Friend WithEvents Label5 As Label
End Class
