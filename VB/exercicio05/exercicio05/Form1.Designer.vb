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
        Me.NudIdade = New System.Windows.Forms.NumericUpDown()
        Me.RadioMasculino = New System.Windows.Forms.RadioButton()
        Me.RadioFeminino = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioNao = New System.Windows.Forms.RadioButton()
        Me.RadioSim = New System.Windows.Forms.RadioButton()
        Me.bttOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbNMasculino = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbNFeminino = New System.Windows.Forms.Label()
        Me.LbMedia = New System.Windows.Forms.Label()
        Me.LbMulheres35 = New System.Windows.Forms.Label()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.candidato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.experiencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NudIdade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NudIdade
        '
        Me.NudIdade.Location = New System.Drawing.Point(67, 43)
        Me.NudIdade.Maximum = New Decimal(New Integer() {45, 0, 0, 0})
        Me.NudIdade.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.NudIdade.Name = "NudIdade"
        Me.NudIdade.Size = New System.Drawing.Size(69, 20)
        Me.NudIdade.TabIndex = 0
        Me.NudIdade.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'RadioMasculino
        '
        Me.RadioMasculino.AutoSize = True
        Me.RadioMasculino.Checked = True
        Me.RadioMasculino.Location = New System.Drawing.Point(6, 24)
        Me.RadioMasculino.Name = "RadioMasculino"
        Me.RadioMasculino.Size = New System.Drawing.Size(73, 17)
        Me.RadioMasculino.TabIndex = 1
        Me.RadioMasculino.TabStop = True
        Me.RadioMasculino.Text = "Masculino"
        Me.RadioMasculino.UseVisualStyleBackColor = True
        '
        'RadioFeminino
        '
        Me.RadioFeminino.AutoSize = True
        Me.RadioFeminino.Location = New System.Drawing.Point(6, 56)
        Me.RadioFeminino.Name = "RadioFeminino"
        Me.RadioFeminino.Size = New System.Drawing.Size(67, 17)
        Me.RadioFeminino.TabIndex = 2
        Me.RadioFeminino.Text = "Feminino"
        Me.RadioFeminino.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioFeminino)
        Me.GroupBox1.Controls.Add(Me.RadioMasculino)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(82, 84)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEXO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Idade"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioNao)
        Me.GroupBox2.Controls.Add(Me.RadioSim)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(81, 89)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Experiência"
        '
        'RadioNao
        '
        Me.RadioNao.AutoSize = True
        Me.RadioNao.Location = New System.Drawing.Point(17, 54)
        Me.RadioNao.Name = "RadioNao"
        Me.RadioNao.Size = New System.Drawing.Size(45, 17)
        Me.RadioNao.TabIndex = 6
        Me.RadioNao.Text = "Não"
        Me.RadioNao.UseVisualStyleBackColor = True
        '
        'RadioSim
        '
        Me.RadioSim.AutoSize = True
        Me.RadioSim.Checked = True
        Me.RadioSim.Location = New System.Drawing.Point(17, 19)
        Me.RadioSim.Name = "RadioSim"
        Me.RadioSim.Size = New System.Drawing.Size(42, 17)
        Me.RadioSim.TabIndex = 7
        Me.RadioSim.TabStop = True
        Me.RadioSim.Text = "Sim"
        Me.RadioSim.UseVisualStyleBackColor = True
        '
        'bttOK
        '
        Me.bttOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttOK.Location = New System.Drawing.Point(44, 266)
        Me.bttOK.Name = "bttOK"
        Me.bttOK.Size = New System.Drawing.Size(105, 23)
        Me.bttOK.TabIndex = 6
        Me.bttOK.Text = "&OK"
        Me.bttOK.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(562, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'LbNMasculino
        '
        Me.LbNMasculino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNMasculino.Location = New System.Drawing.Point(379, 318)
        Me.LbNMasculino.Name = "LbNMasculino"
        Me.LbNMasculino.Size = New System.Drawing.Size(100, 20)
        Me.LbNMasculino.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nº de Candidatos do Sexo Masculino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Estatisticas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(269, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Média das Idades dos Homens com Experiência"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 14)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Nº de Candidatos do Sexo Feminino"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 14)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nº de Mulheres com Idade Superior a 35 anos"
        '
        'LbNFeminino
        '
        Me.LbNFeminino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNFeminino.Location = New System.Drawing.Point(379, 347)
        Me.LbNFeminino.Name = "LbNFeminino"
        Me.LbNFeminino.Size = New System.Drawing.Size(100, 20)
        Me.LbNFeminino.TabIndex = 17
        '
        'LbMedia
        '
        Me.LbMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMedia.Location = New System.Drawing.Point(379, 376)
        Me.LbMedia.Name = "LbMedia"
        Me.LbMedia.Size = New System.Drawing.Size(100, 20)
        Me.LbMedia.TabIndex = 18
        '
        'LbMulheres35
        '
        Me.LbMulheres35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMulheres35.Location = New System.Drawing.Point(379, 405)
        Me.LbMulheres35.Name = "LbMulheres35"
        Me.LbMulheres35.Size = New System.Drawing.Size(100, 20)
        Me.LbMulheres35.TabIndex = 19
        '
        'Grelha
        '
        Me.Grelha.AllowUserToDeleteRows = False
        Me.Grelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.candidato, Me.idade, Me.sexo, Me.experiencia})
        Me.Grelha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grelha.Location = New System.Drawing.Point(224, 43)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(398, 217)
        Me.Grelha.TabIndex = 20
        '
        'candidato
        '
        Me.candidato.HeaderText = "Candidato"
        Me.candidato.Name = "candidato"
        '
        'idade
        '
        Me.idade.HeaderText = "Idade"
        Me.idade.Name = "idade"
        '
        'sexo
        '
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        '
        'experiencia
        '
        Me.experiencia.HeaderText = "Experiência"
        Me.experiencia.Name = "experiencia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 453)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.LbMulheres35)
        Me.Controls.Add(Me.LbMedia)
        Me.Controls.Add(Me.LbNFeminino)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LbNMasculino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bttOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NudIdade)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Emprego"
        CType(Me.NudIdade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NudIdade As NumericUpDown
    Friend WithEvents RadioMasculino As RadioButton
    Friend WithEvents RadioFeminino As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioNao As RadioButton
    Friend WithEvents RadioSim As RadioButton
    Friend WithEvents bttOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbNMasculino As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LbNFeminino As Label
    Friend WithEvents LbMedia As Label
    Friend WithEvents LbMulheres35 As Label
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents candidato As DataGridViewTextBoxColumn
    Friend WithEvents idade As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents experiencia As DataGridViewTextBoxColumn
End Class
