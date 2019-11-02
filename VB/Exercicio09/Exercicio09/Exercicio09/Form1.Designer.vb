<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JOKER
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
        Me.bttRodar = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbJoker = New System.Windows.Forms.Label()
        Me.nudApostas = New System.Windows.Forms.NumericUpDown()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.Relogio = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudApostas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttRodar
        '
        Me.bttRodar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttRodar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttRodar.Location = New System.Drawing.Point(624, 248)
        Me.bttRodar.Margin = New System.Windows.Forms.Padding(4)
        Me.bttRodar.Name = "bttRodar"
        Me.bttRodar.Size = New System.Drawing.Size(112, 88)
        Me.bttRodar.TabIndex = 0
        Me.bttRodar.Text = "Apostar"
        Me.bttRodar.UseVisualStyleBackColor = False
        '
        'Lb1
        '
        Me.Lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(104, 50)
        Me.Lb1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(149, 123)
        Me.Lb1.TabIndex = 1
        Me.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 320)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nº de Joker's"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nº de Apostas"
        '
        'LbJoker
        '
        Me.LbJoker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbJoker.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJoker.Location = New System.Drawing.Point(208, 312)
        Me.LbJoker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbJoker.Name = "LbJoker"
        Me.LbJoker.Size = New System.Drawing.Size(82, 38)
        Me.LbJoker.TabIndex = 7
        '
        'nudApostas
        '
        Me.nudApostas.Location = New System.Drawing.Point(216, 264)
        Me.nudApostas.Margin = New System.Windows.Forms.Padding(4)
        Me.nudApostas.Name = "nudApostas"
        Me.nudApostas.Size = New System.Drawing.Size(82, 22)
        Me.nudApostas.TabIndex = 8
        '
        'Lb2
        '
        Me.Lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.Location = New System.Drawing.Point(310, 50)
        Me.Lb2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(149, 123)
        Me.Lb2.TabIndex = 9
        Me.Lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb3
        '
        Me.Lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.Location = New System.Drawing.Point(536, 50)
        Me.Lb3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(149, 123)
        Me.Lb3.TabIndex = 10
        Me.Lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Relogio
        '
        Me.Relogio.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Exercicio09.My.Resources.Resources.arlequina
        Me.PictureBox1.Location = New System.Drawing.Point(312, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'JOKER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Exercicio09.My.Resources.Resources.thZ4COXSES
        Me.ClientSize = New System.Drawing.Size(768, 476)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.nudApostas)
        Me.Controls.Add(Me.LbJoker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.bttRodar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JOKER"
        Me.Text = "JOCKER"
        CType(Me.nudApostas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttRodar As Button
    Friend WithEvents Lb1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbJoker As Label
    Friend WithEvents nudApostas As NumericUpDown
    Friend WithEvents Lb2 As Label
    Friend WithEvents Lb3 As Label
    Friend WithEvents Relogio As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
