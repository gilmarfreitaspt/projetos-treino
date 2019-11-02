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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combolocal = New System.Windows.Forms.ComboBox()
        Me.NudIdade = New System.Windows.Forms.NumericUpDown()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.bttInserir = New System.Windows.Forms.Button()
        Me.bttOrdenar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NudIdade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Localidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Idade"
        '
        'Combolocal
        '
        Me.Combolocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combolocal.FormattingEnabled = True
        Me.Combolocal.Items.AddRange(New Object() {"Rio de Janeiro", "São Paulo", "Porto", "Lisboa", "Orlando"})
        Me.Combolocal.Location = New System.Drawing.Point(160, 91)
        Me.Combolocal.Name = "Combolocal"
        Me.Combolocal.Size = New System.Drawing.Size(121, 21)
        Me.Combolocal.TabIndex = 3
        '
        'NudIdade
        '
        Me.NudIdade.Location = New System.Drawing.Point(147, 140)
        Me.NudIdade.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NudIdade.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NudIdade.Name = "NudIdade"
        Me.NudIdade.Size = New System.Drawing.Size(48, 20)
        Me.NudIdade.TabIndex = 4
        Me.NudIdade.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(160, 47)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(100, 20)
        Me.TxtNome.TabIndex = 5
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Grelha.Location = New System.Drawing.Point(62, 197)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(304, 150)
        Me.Grelha.TabIndex = 6
        '
        'bttInserir
        '
        Me.bttInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttInserir.Location = New System.Drawing.Point(348, 40)
        Me.bttInserir.Name = "bttInserir"
        Me.bttInserir.Size = New System.Drawing.Size(75, 34)
        Me.bttInserir.TabIndex = 7
        Me.bttInserir.Text = "Inserir"
        Me.bttInserir.UseVisualStyleBackColor = True
        '
        'bttOrdenar
        '
        Me.bttOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttOrdenar.Location = New System.Drawing.Point(348, 103)
        Me.bttOrdenar.Name = "bttOrdenar"
        Me.bttOrdenar.Size = New System.Drawing.Size(75, 31)
        Me.bttOrdenar.TabIndex = 8
        Me.bttOrdenar.Text = "Ordenar"
        Me.bttOrdenar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Localidade"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Idade"
        Me.Column3.Name = "Column3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(449, 450)
        Me.Controls.Add(Me.bttOrdenar)
        Me.Controls.Add(Me.bttInserir)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.NudIdade)
        Me.Controls.Add(Me.Combolocal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ordenar Idade"
        CType(Me.NudIdade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Combolocal As ComboBox
    Friend WithEvents NudIdade As NumericUpDown
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents bttInserir As Button
    Friend WithEvents bttOrdenar As Button
End Class
