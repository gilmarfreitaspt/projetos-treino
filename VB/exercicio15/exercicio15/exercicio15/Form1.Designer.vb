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
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.ComboLab = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboProj = New System.Windows.Forms.ComboBox()
        Me.ComboAval = New System.Windows.Forms.ComboBox()
        Me.LbAlunos = New System.Windows.Forms.Label()
        Me.LbMediaTurma = New System.Windows.Forms.Label()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.BttSair = New System.Windows.Forms.Button()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(184, 24)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(96, 20)
        Me.TxtNumero.TabIndex = 0
        '
        'ComboLab
        '
        Me.ComboLab.FormattingEnabled = True
        Me.ComboLab.Location = New System.Drawing.Point(184, 55)
        Me.ComboLab.Name = "ComboLab"
        Me.ComboLab.Size = New System.Drawing.Size(96, 21)
        Me.ComboLab.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número do Aluno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número do Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Média da Turma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº de  Alunos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Avaliação Semestral"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Projecto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Laborátorio"
        '
        'ComboProj
        '
        Me.ComboProj.FormattingEnabled = True
        Me.ComboProj.Location = New System.Drawing.Point(184, 87)
        Me.ComboProj.Name = "ComboProj"
        Me.ComboProj.Size = New System.Drawing.Size(96, 21)
        Me.ComboProj.TabIndex = 11
        '
        'ComboAval
        '
        Me.ComboAval.FormattingEnabled = True
        Me.ComboAval.Location = New System.Drawing.Point(184, 119)
        Me.ComboAval.Name = "ComboAval"
        Me.ComboAval.Size = New System.Drawing.Size(96, 21)
        Me.ComboAval.TabIndex = 12
        '
        'LbAlunos
        '
        Me.LbAlunos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbAlunos.Location = New System.Drawing.Point(208, 184)
        Me.LbAlunos.Name = "LbAlunos"
        Me.LbAlunos.Size = New System.Drawing.Size(76, 23)
        Me.LbAlunos.TabIndex = 13
        '
        'LbMediaTurma
        '
        Me.LbMediaTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMediaTurma.Location = New System.Drawing.Point(208, 224)
        Me.LbMediaTurma.Name = "LbMediaTurma"
        Me.LbMediaTurma.Size = New System.Drawing.Size(76, 23)
        Me.LbMediaTurma.TabIndex = 14
        '
        'bttCalcular
        '
        Me.bttCalcular.BackColor = System.Drawing.Color.Chartreuse
        Me.bttCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bttCalcular.Location = New System.Drawing.Point(40, 264)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(75, 32)
        Me.bttCalcular.TabIndex = 15
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = False
        '
        'BttSair
        '
        Me.BttSair.BackColor = System.Drawing.Color.Red
        Me.BttSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSair.Location = New System.Drawing.Point(208, 264)
        Me.BttSair.Name = "BttSair"
        Me.BttSair.Size = New System.Drawing.Size(75, 32)
        Me.BttSair.TabIndex = 16
        Me.BttSair.Text = "Sair"
        Me.BttSair.UseVisualStyleBackColor = False
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.AllowUserToOrderColumns = True
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.Grelha.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grelha.Location = New System.Drawing.Point(288, 24)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(456, 272)
        Me.Grelha.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.FillWeight = 80.0!
        Me.Column1.HeaderText = "Número"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Lab"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "Proj"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Aval"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Média"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Observação"
        Me.Column6.Name = "Column6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exercicio15.My.Resources.Resources.shutterstock_531995644
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(748, 450)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.BttSair)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.LbMediaTurma)
        Me.Controls.Add(Me.LbAlunos)
        Me.Controls.Add(Me.ComboAval)
        Me.Controls.Add(Me.ComboProj)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboLab)
        Me.Controls.Add(Me.TxtNumero)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents ComboLab As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboProj As ComboBox
    Friend WithEvents ComboAval As ComboBox
    Friend WithEvents LbAlunos As Label
    Friend WithEvents LbMediaTurma As Label
    Friend WithEvents bttCalcular As Button
    Friend WithEvents BttSair As Button
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
