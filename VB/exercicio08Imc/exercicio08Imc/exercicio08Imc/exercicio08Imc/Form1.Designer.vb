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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadFeminino = New System.Windows.Forms.RadioButton()
        Me.RadMasculino = New System.Windows.Forms.RadioButton()
        Me.NudAltura = New System.Windows.Forms.NumericUpDown()
        Me.NudPeso = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbObsIMC = New System.Windows.Forms.Label()
        Me.LbValorIMC = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NudAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.RadFeminino)
        Me.GroupBox1.Controls.Add(Me.RadMasculino)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'RadFeminino
        '
        Me.RadFeminino.AutoSize = True
        Me.RadFeminino.Location = New System.Drawing.Point(202, 28)
        Me.RadFeminino.Name = "RadFeminino"
        Me.RadFeminino.Size = New System.Drawing.Size(67, 17)
        Me.RadFeminino.TabIndex = 3
        Me.RadFeminino.Text = "Feminino"
        Me.RadFeminino.UseVisualStyleBackColor = True
        '
        'RadMasculino
        '
        Me.RadMasculino.AutoSize = True
        Me.RadMasculino.Checked = True
        Me.RadMasculino.Location = New System.Drawing.Point(24, 28)
        Me.RadMasculino.Name = "RadMasculino"
        Me.RadMasculino.Size = New System.Drawing.Size(73, 17)
        Me.RadMasculino.TabIndex = 2
        Me.RadMasculino.TabStop = True
        Me.RadMasculino.Text = "Masculino"
        Me.RadMasculino.UseVisualStyleBackColor = True
        '
        'NudAltura
        '
        Me.NudAltura.DecimalPlaces = 2
        Me.NudAltura.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NudAltura.Location = New System.Drawing.Point(55, 47)
        Me.NudAltura.Maximum = New Decimal(New Integer() {23, 0, 0, 65536})
        Me.NudAltura.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudAltura.Name = "NudAltura"
        Me.NudAltura.Size = New System.Drawing.Size(51, 20)
        Me.NudAltura.TabIndex = 2
        Me.NudAltura.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        '
        'NudPeso
        '
        Me.NudPeso.Location = New System.Drawing.Point(230, 40)
        Me.NudPeso.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NudPeso.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NudPeso.Name = "NudPeso"
        Me.NudPeso.Size = New System.Drawing.Size(48, 20)
        Me.NudPeso.TabIndex = 3
        Me.NudPeso.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.LbObsIMC)
        Me.GroupBox2.Controls.Add(Me.LbValorIMC)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(58, 259)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Indice de Massa Corporal"
        '
        'LbObsIMC
        '
        Me.LbObsIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbObsIMC.Location = New System.Drawing.Point(101, 67)
        Me.LbObsIMC.Name = "LbObsIMC"
        Me.LbObsIMC.Size = New System.Drawing.Size(158, 27)
        Me.LbObsIMC.TabIndex = 13
        '
        'LbValorIMC
        '
        Me.LbValorIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbValorIMC.Location = New System.Drawing.Point(101, 29)
        Me.LbValorIMC.Name = "LbValorIMC"
        Me.LbValorIMC.Size = New System.Drawing.Size(103, 27)
        Me.LbValorIMC.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Observação"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.NudAltura)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.NudPeso)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(58, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Medições"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Peso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Altura"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exercicio08Imc.My.Resources.Resources.DSCN0930
        Me.ClientSize = New System.Drawing.Size(433, 386)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "IMC - Versão 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NudAltura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudPeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadFeminino As RadioButton
    Friend WithEvents RadMasculino As RadioButton
    Friend WithEvents NudAltura As NumericUpDown
    Friend WithEvents NudPeso As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LbObsIMC As Label
    Friend WithEvents LbValorIMC As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
