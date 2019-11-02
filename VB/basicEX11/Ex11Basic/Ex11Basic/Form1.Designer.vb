<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RadQuadrado = New System.Windows.Forms.RadioButton()
        Me.RedRectangulo = New System.Windows.Forms.RadioButton()
        Me.RadTriangulo = New System.Windows.Forms.RadioButton()
        Me.RadTrapezio = New System.Windows.Forms.RadioButton()
        Me.RadCirculo = New System.Windows.Forms.RadioButton()
        Me.RadLosango = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkVolume = New System.Windows.Forms.CheckBox()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.LbAltura = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbResultado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadQuadrado
        '
        Me.RadQuadrado.AutoSize = True
        Me.RadQuadrado.Checked = True
        Me.RadQuadrado.Location = New System.Drawing.Point(16, 30)
        Me.RadQuadrado.Name = "RadQuadrado"
        Me.RadQuadrado.Size = New System.Drawing.Size(103, 23)
        Me.RadQuadrado.TabIndex = 0
        Me.RadQuadrado.TabStop = True
        Me.RadQuadrado.Text = "Quadrado"
        Me.RadQuadrado.UseVisualStyleBackColor = True
        '
        'RedRectangulo
        '
        Me.RedRectangulo.AutoSize = True
        Me.RedRectangulo.Location = New System.Drawing.Point(16, 63)
        Me.RedRectangulo.Name = "RedRectangulo"
        Me.RedRectangulo.Size = New System.Drawing.Size(115, 23)
        Me.RedRectangulo.TabIndex = 1
        Me.RedRectangulo.Text = "Rectângulo"
        Me.RedRectangulo.UseVisualStyleBackColor = True
        '
        'RadTriangulo
        '
        Me.RadTriangulo.AutoSize = True
        Me.RadTriangulo.Location = New System.Drawing.Point(16, 96)
        Me.RadTriangulo.Name = "RadTriangulo"
        Me.RadTriangulo.Size = New System.Drawing.Size(99, 23)
        Me.RadTriangulo.TabIndex = 2
        Me.RadTriangulo.Text = "Triângulo"
        Me.RadTriangulo.UseVisualStyleBackColor = True
        '
        'RadTrapezio
        '
        Me.RadTrapezio.AutoSize = True
        Me.RadTrapezio.Location = New System.Drawing.Point(16, 129)
        Me.RadTrapezio.Name = "RadTrapezio"
        Me.RadTrapezio.Size = New System.Drawing.Size(93, 23)
        Me.RadTrapezio.TabIndex = 3
        Me.RadTrapezio.Text = "Trapézio"
        Me.RadTrapezio.UseVisualStyleBackColor = True
        '
        'RadCirculo
        '
        Me.RadCirculo.AutoSize = True
        Me.RadCirculo.Location = New System.Drawing.Point(16, 162)
        Me.RadCirculo.Name = "RadCirculo"
        Me.RadCirculo.Size = New System.Drawing.Size(82, 23)
        Me.RadCirculo.TabIndex = 4
        Me.RadCirculo.Text = "Circulo"
        Me.RadCirculo.UseVisualStyleBackColor = True
        '
        'RadLosango
        '
        Me.RadLosango.AutoSize = True
        Me.RadLosango.Location = New System.Drawing.Point(16, 195)
        Me.RadLosango.Name = "RadLosango"
        Me.RadLosango.Size = New System.Drawing.Size(95, 23)
        Me.RadLosango.TabIndex = 5
        Me.RadLosango.Text = "Losango"
        Me.RadLosango.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadTriangulo)
        Me.GroupBox1.Controls.Add(Me.RadLosango)
        Me.GroupBox1.Controls.Add(Me.RadQuadrado)
        Me.GroupBox1.Controls.Add(Me.RadCirculo)
        Me.GroupBox1.Controls.Add(Me.RedRectangulo)
        Me.GroupBox1.Controls.Add(Me.RadTrapezio)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 224)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Áreas"
        '
        'ChkVolume
        '
        Me.ChkVolume.AutoSize = True
        Me.ChkVolume.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVolume.Location = New System.Drawing.Point(56, 296)
        Me.ChkVolume.Name = "ChkVolume"
        Me.ChkVolume.Size = New System.Drawing.Size(85, 23)
        Me.ChkVolume.TabIndex = 7
        Me.ChkVolume.Text = "Volume"
        Me.ChkVolume.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(376, 32)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(39, 13)
        Me.Lb1.TabIndex = 8
        Me.Lb1.Text = "Label1"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(376, 109)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(39, 13)
        Me.Lb2.TabIndex = 9
        Me.Lb2.Text = "Label2"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(376, 186)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(39, 13)
        Me.Lb3.TabIndex = 10
        Me.Lb3.Text = "Label3"
        Me.Lb3.Visible = False
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(376, 67)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 20)
        Me.Txt1.TabIndex = 11
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(376, 144)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 20)
        Me.Txt2.TabIndex = 12
        Me.Txt2.Visible = False
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(376, 221)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(100, 20)
        Me.Txt3.TabIndex = 13
        Me.Txt3.Visible = False
        '
        'bttCalcular
        '
        Me.bttCalcular.ForeColor = System.Drawing.Color.Black
        Me.bttCalcular.Location = New System.Drawing.Point(376, 264)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(105, 23)
        Me.bttCalcular.TabIndex = 14
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = True
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(48, 360)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(136, 20)
        Me.TxtAltura.TabIndex = 15
        Me.TxtAltura.Visible = False
        '
        'LbAltura
        '
        Me.LbAltura.AutoSize = True
        Me.LbAltura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAltura.Location = New System.Drawing.Point(48, 336)
        Me.LbAltura.Name = "LbAltura"
        Me.LbAltura.Size = New System.Drawing.Size(144, 16)
        Me.LbAltura.TabIndex = 17
        Me.LbAltura.Text = "Altura / Profundidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Resultado"
        '
        'LbResultado
        '
        Me.LbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbResultado.Location = New System.Drawing.Point(352, 360)
        Me.LbResultado.Name = "LbResultado"
        Me.LbResultado.Size = New System.Drawing.Size(112, 24)
        Me.LbResultado.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 413)
        Me.Controls.Add(Me.LbResultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbAltura)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.ChkVolume)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Areas e Volumes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadQuadrado As RadioButton
    Friend WithEvents RedRectangulo As RadioButton
    Friend WithEvents RadTriangulo As RadioButton
    Friend WithEvents RadTrapezio As RadioButton
    Friend WithEvents RadCirculo As RadioButton
    Friend WithEvents RadLosango As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkVolume As CheckBox
    Friend WithEvents Lb1 As Label
    Friend WithEvents Lb2 As Label
    Friend WithEvents Lb3 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents bttCalcular As Button
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents LbAltura As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbResultado As Label
End Class
