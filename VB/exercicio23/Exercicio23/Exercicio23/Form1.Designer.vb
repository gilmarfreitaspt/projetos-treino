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
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttInserir = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbSoma = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.bttCalcular = New System.Windows.Forms.Button()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Grelha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.ColumnHeadersVisible = False
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Grelha.Location = New System.Drawing.Point(103, 156)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(242, 150)
        Me.Grelha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'bttInserir
        '
        Me.bttInserir.BackColor = System.Drawing.Color.Lime
        Me.bttInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttInserir.Location = New System.Drawing.Point(270, 64)
        Me.bttInserir.Name = "bttInserir"
        Me.bttInserir.Size = New System.Drawing.Size(75, 23)
        Me.bttInserir.TabIndex = 2
        Me.bttInserir.Text = "Inserir"
        Me.bttInserir.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'LbSoma
        '
        Me.LbSoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSoma.Location = New System.Drawing.Point(168, 393)
        Me.LbSoma.Name = "LbSoma"
        Me.LbSoma.Size = New System.Drawing.Size(87, 26)
        Me.LbSoma.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Soma da Diagonal Principal"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(168, 64)
        Me.TxtValor.MaxLength = 5
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(72, 20)
        Me.TxtValor.TabIndex = 5
        '
        'bttCalcular
        '
        Me.bttCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCalcular.Location = New System.Drawing.Point(103, 312)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(242, 40)
        Me.bttCalcular.TabIndex = 6
        Me.bttCalcular.Text = "Calcular Diagonal"
        Me.bttCalcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 450)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbSoma)
        Me.Controls.Add(Me.bttInserir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grelha)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Diagonal Principal"
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grelha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents bttInserir As Button
    Friend WithEvents LbSoma As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents bttCalcular As Button
End Class
