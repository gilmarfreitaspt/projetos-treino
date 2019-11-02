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
        Me.ComboSemana = New System.Windows.Forms.ComboBox()
        Me.ComboVendedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.bttInserir = New System.Windows.Forms.Button()
        Me.bttCalcular = New System.Windows.Forms.Button()
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
        'ComboSemana
        '
        Me.ComboSemana.AutoCompleteCustomSource.AddRange(New String() {"Segunda Feira", "Terça Feira", "Quarta Feira", "Quinta Feira", "Sexta Feira ", "Sabado", "Domingo"})
        Me.ComboSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSemana.FormattingEnabled = True
        Me.ComboSemana.Items.AddRange(New Object() {"Segunda Feira", "Terça Feira", "Quarta Feira", "Quinta Feira", "Sexta Feira", "Sabado", "Domingo"})
        Me.ComboSemana.Location = New System.Drawing.Point(171, 47)
        Me.ComboSemana.Name = "ComboSemana"
        Me.ComboSemana.Size = New System.Drawing.Size(121, 21)
        Me.ComboSemana.TabIndex = 0
        '
        'ComboVendedor
        '
        Me.ComboVendedor.AutoCompleteCustomSource.AddRange(New String() {"Vendedor 1", "Vendedor 2", "Vendedor 3", "Vendedor 4", "Vendedor 5"})
        Me.ComboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboVendedor.FormattingEnabled = True
        Me.ComboVendedor.Items.AddRange(New Object() {"Vendedor 1", "Vendedor 2", "Vendedor 3", "Vendedor 4", "Vendedor 5"})
        Me.ComboVendedor.Location = New System.Drawing.Point(171, 98)
        Me.ComboVendedor.Name = "ComboVendedor"
        Me.ComboVendedor.Size = New System.Drawing.Size(121, 21)
        Me.ComboVendedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Semana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor da Venda"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(171, 148)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor.TabIndex = 5
        '
        'bttInserir
        '
        Me.bttInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttInserir.ForeColor = System.Drawing.Color.Black
        Me.bttInserir.Location = New System.Drawing.Point(289, 148)
        Me.bttInserir.Name = "bttInserir"
        Me.bttInserir.Size = New System.Drawing.Size(63, 23)
        Me.bttInserir.TabIndex = 6
        Me.bttInserir.Text = "Inserir"
        Me.bttInserir.UseVisualStyleBackColor = False
        '
        'bttCalcular
        '
        Me.bttCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCalcular.ForeColor = System.Drawing.Color.Black
        Me.bttCalcular.Location = New System.Drawing.Point(367, 148)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(75, 23)
        Me.bttCalcular.TabIndex = 7
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = False
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.Grelha.Location = New System.Drawing.Point(12, 180)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(409, 150)
        Me.Grelha.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Vendedor"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sem 1"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sem 2"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 65
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sem 3"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 65
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sem 4"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 65
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 65
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 342)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.bttInserir)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboVendedor)
        Me.Controls.Add(Me.ComboSemana)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Vendas Mensal"
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboSemana As ComboBox
    Friend WithEvents ComboVendedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents bttInserir As Button
    Friend WithEvents bttCalcular As Button
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
