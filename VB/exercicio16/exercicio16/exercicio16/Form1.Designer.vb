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
        Me.NudNumero = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.LbResultado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NudNumero
        '
        Me.NudNumero.Location = New System.Drawing.Point(184, 48)
        Me.NudNumero.Maximum = New Decimal(New Integer() {170, 0, 0, 0})
        Me.NudNumero.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudNumero.Name = "NudNumero"
        Me.NudNumero.Size = New System.Drawing.Size(56, 20)
        Me.NudNumero.TabIndex = 0
        Me.NudNumero.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número"
        '
        'bttCalcular
        '
        Me.bttCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bttCalcular.Location = New System.Drawing.Point(256, 48)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(96, 32)
        Me.bttCalcular.TabIndex = 2
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = False
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.Grelha.Location = New System.Drawing.Point(96, 192)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(208, 150)
        Me.Grelha.TabIndex = 3
        '
        'LbResultado
        '
        Me.LbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResultado.Location = New System.Drawing.Point(216, 104)
        Me.LbResultado.Name = "LbResultado"
        Me.LbResultado.Size = New System.Drawing.Size(136, 32)
        Me.LbResultado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Calculos Intermédios"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exercicio16.My.Resources.Resources.para_seguir_carreira_na_area_matematica_estudante_tem_que_se_identificar_com_numeros_calculos_517aeada52e1e
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(416, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LbResultado)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NudNumero)
        Me.Name = "Form1"
        Me.Text = "Factorial"
        CType(Me.NudNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NudNumero As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents bttCalcular As Button
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents LbResultado As Label
    Friend WithEvents Label3 As Label
End Class
