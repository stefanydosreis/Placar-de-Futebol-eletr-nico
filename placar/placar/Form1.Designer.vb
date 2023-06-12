<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LbTcasa = New System.Windows.Forms.Label()
        Me.LbVISITANTE = New System.Windows.Forms.Label()
        Me.LbPlaca1 = New System.Windows.Forms.Label()
        Me.LbPlaca2 = New System.Windows.Forms.Label()
        Me.BtGol1 = New System.Windows.Forms.Button()
        Me.BtGol2 = New System.Windows.Forms.Button()
        Me.CbCasa = New System.Windows.Forms.ComboBox()
        Me.CbVisistante = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btComecar = New System.Windows.Forms.Button()
        Me.LbMinutos = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LbTempo = New System.Windows.Forms.Label()
        Me.LBstar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTcasa
        '
        Me.LbTcasa.AutoSize = True
        Me.LbTcasa.Location = New System.Drawing.Point(56, 20)
        Me.LbTcasa.Name = "LbTcasa"
        Me.LbTcasa.Size = New System.Drawing.Size(72, 13)
        Me.LbTcasa.TabIndex = 0
        Me.LbTcasa.Text = "Time da Casa"
        '
        'LbVISITANTE
        '
        Me.LbVISITANTE.AutoSize = True
        Me.LbVISITANTE.Location = New System.Drawing.Point(506, 20)
        Me.LbVISITANTE.Name = "LbVISITANTE"
        Me.LbVISITANTE.Size = New System.Drawing.Size(73, 13)
        Me.LbVISITANTE.TabIndex = 1
        Me.LbVISITANTE.Text = "Time Visitante"
        '
        'LbPlaca1
        '
        Me.LbPlaca1.AutoSize = True
        Me.LbPlaca1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPlaca1.Location = New System.Drawing.Point(41, 33)
        Me.LbPlaca1.Name = "LbPlaca1"
        Me.LbPlaca1.Size = New System.Drawing.Size(98, 108)
        Me.LbPlaca1.TabIndex = 2
        Me.LbPlaca1.Text = "0"
        '
        'LbPlaca2
        '
        Me.LbPlaca2.AutoSize = True
        Me.LbPlaca2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPlaca2.Location = New System.Drawing.Point(491, 33)
        Me.LbPlaca2.Name = "LbPlaca2"
        Me.LbPlaca2.Size = New System.Drawing.Size(98, 108)
        Me.LbPlaca2.TabIndex = 3
        Me.LbPlaca2.Text = "0"
        '
        'BtGol1
        '
        Me.BtGol1.Location = New System.Drawing.Point(43, 144)
        Me.BtGol1.Name = "BtGol1"
        Me.BtGol1.Size = New System.Drawing.Size(107, 24)
        Me.BtGol1.TabIndex = 4
        Me.BtGol1.Text = "Gol"
        Me.BtGol1.UseVisualStyleBackColor = True
        '
        'BtGol2
        '
        Me.BtGol2.Location = New System.Drawing.Point(482, 144)
        Me.BtGol2.Name = "BtGol2"
        Me.BtGol2.Size = New System.Drawing.Size(107, 24)
        Me.BtGol2.TabIndex = 5
        Me.BtGol2.Text = "Gol"
        Me.BtGol2.UseVisualStyleBackColor = True
        '
        'CbCasa
        '
        Me.CbCasa.FormattingEnabled = True
        Me.CbCasa.Items.AddRange(New Object() {"Vasco", "Flamengo", "Botafogo", "Fluminense"})
        Me.CbCasa.Location = New System.Drawing.Point(12, 174)
        Me.CbCasa.Name = "CbCasa"
        Me.CbCasa.Size = New System.Drawing.Size(150, 21)
        Me.CbCasa.TabIndex = 6
        '
        'CbVisistante
        '
        Me.CbVisistante.FormattingEnabled = True
        Me.CbVisistante.Items.AddRange(New Object() {"Vasco", "Flamengo", "Botafogo", "Fluminense"})
        Me.CbVisistante.Location = New System.Drawing.Point(457, 174)
        Me.CbVisistante.Name = "CbVisistante"
        Me.CbVisistante.Size = New System.Drawing.Size(150, 21)
        Me.CbVisistante.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(45, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LBstar)
        Me.Panel1.Controls.Add(Me.btComecar)
        Me.Panel1.Controls.Add(Me.LbMinutos)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Location = New System.Drawing.Point(185, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 230)
        Me.Panel1.TabIndex = 10
        '
        'btComecar
        '
        Me.btComecar.Location = New System.Drawing.Point(77, 103)
        Me.btComecar.Name = "btComecar"
        Me.btComecar.Size = New System.Drawing.Size(86, 26)
        Me.btComecar.TabIndex = 2
        Me.btComecar.Text = "Começar"
        Me.btComecar.UseVisualStyleBackColor = True
        '
        'LbMinutos
        '
        Me.LbMinutos.AutoSize = True
        Me.LbMinutos.Location = New System.Drawing.Point(87, 148)
        Me.LbMinutos.Name = "LbMinutos"
        Me.LbMinutos.Size = New System.Drawing.Size(13, 13)
        Me.LbMinutos.TabIndex = 1
        Me.LbMinutos.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 164)
        Me.ProgressBar1.Maximum = 90
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(212, 28)
        Me.ProgressBar1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(484, 213)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'LbTempo
        '
        Me.LbTempo.AutoSize = True
        Me.LbTempo.Location = New System.Drawing.Point(189, 144)
        Me.LbTempo.Name = "LbTempo"
        Me.LbTempo.Size = New System.Drawing.Size(43, 13)
        Me.LbTempo.TabIndex = 12
        Me.LbTempo.Text = "Tempo:"
        '
        'LBstar
        '
        Me.LBstar.AutoSize = True
        Me.LBstar.Location = New System.Drawing.Point(34, 148)
        Me.LBstar.Name = "LBstar"
        Me.LBstar.Size = New System.Drawing.Size(47, 13)
        Me.LBstar.TabIndex = 3
        Me.LBstar.Text = "Minutos:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 450)
        Me.Controls.Add(Me.LbTempo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CbVisistante)
        Me.Controls.Add(Me.CbCasa)
        Me.Controls.Add(Me.BtGol2)
        Me.Controls.Add(Me.BtGol1)
        Me.Controls.Add(Me.LbPlaca2)
        Me.Controls.Add(Me.LbPlaca1)
        Me.Controls.Add(Me.LbVISITANTE)
        Me.Controls.Add(Me.LbTcasa)
        Me.Name = "Form1"
        Me.Text = "Placar Eletrônico de Futubol"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTcasa As Label
    Friend WithEvents LbVISITANTE As Label
    Friend WithEvents LbPlaca1 As Label
    Friend WithEvents LbPlaca2 As Label
    Friend WithEvents BtGol1 As Button
    Friend WithEvents BtGol2 As Button
    Friend WithEvents CbCasa As ComboBox
    Friend WithEvents CbVisistante As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btComecar As Button
    Friend WithEvents LbMinutos As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LbTempo As Label
    Friend WithEvents LBstar As Label
End Class
