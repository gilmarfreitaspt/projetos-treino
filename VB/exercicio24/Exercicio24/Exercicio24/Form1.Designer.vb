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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValor2 = New System.Windows.Forms.TextBox()
        Me.TxtValor1 = New System.Windows.Forms.TextBox()
        Me.Grelha1 = New System.Windows.Forms.DataGridView()
        Me.bttSoma = New System.Windows.Forms.Button()
        Me.bttOk2 = New System.Windows.Forms.Button()
        Me.bttOk1 = New System.Windows.Forms.Button()
        Me.Grelha2 = New System.Windows.Forms.DataGridView()
        Me.GrelhaSoma = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grelha1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grelha2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrelhaSoma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matriz 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matriz 2"
        '
        'TxtValor2
        '
        Me.TxtValor2.Location = New System.Drawing.Point(466, 52)
        Me.TxtValor2.Name = "TxtValor2"
        Me.TxtValor2.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor2.TabIndex = 2
        '
        'TxtValor1
        '
        Me.TxtValor1.Location = New System.Drawing.Point(62, 52)
        Me.TxtValor1.Name = "TxtValor1"
        Me.TxtValor1.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor1.TabIndex = 3
        '
        'Grelha1
        '
        Me.Grelha1.AllowUserToAddRows = False
        Me.Grelha1.AllowUserToDeleteRows = False
        Me.Grelha1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Grelha1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grelha1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Grelha1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha1.ColumnHeadersVisible = False
        Me.Grelha1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grelha1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Grelha1.Location = New System.Drawing.Point(40, 87)
        Me.Grelha1.Name = "Grelha1"
        Me.Grelha1.ReadOnly = True
        Me.Grelha1.RowHeadersVisible = False
        Me.Grelha1.Size = New System.Drawing.Size(240, 90)
        Me.Grelha1.TabIndex = 6
        '
        'bttSoma
        '
        Me.bttSoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSoma.Location = New System.Drawing.Point(243, 272)
        Me.bttSoma.Name = "bttSoma"
        Me.bttSoma.Size = New System.Drawing.Size(214, 32)
        Me.bttSoma.TabIndex = 7
        Me.bttSoma.Text = "Soma"
        Me.bttSoma.UseVisualStyleBackColor = False
        '
        'bttOk2
        '
        Me.bttOk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttOk2.Location = New System.Drawing.Point(588, 49)
        Me.bttOk2.Name = "bttOk2"
        Me.bttOk2.Size = New System.Drawing.Size(75, 32)
        Me.bttOk2.TabIndex = 8
        Me.bttOk2.Text = "OK"
        Me.bttOk2.UseVisualStyleBackColor = True
        '
        'bttOk1
        '
        Me.bttOk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttOk1.Location = New System.Drawing.Point(168, 49)
        Me.bttOk1.Name = "bttOk1"
        Me.bttOk1.Size = New System.Drawing.Size(75, 32)
        Me.bttOk1.TabIndex = 9
        Me.bttOk1.Text = "OK"
        Me.bttOk1.UseVisualStyleBackColor = True
        '
        'Grelha2
        '
        Me.Grelha2.AllowUserToAddRows = False
        Me.Grelha2.AllowUserToDeleteRows = False
        Me.Grelha2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Grelha2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grelha2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.Grelha2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha2.ColumnHeadersVisible = False
        Me.Grelha2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grelha2.DefaultCellStyle = DataGridViewCellStyle10
        Me.Grelha2.Location = New System.Drawing.Point(450, 87)
        Me.Grelha2.Name = "Grelha2"
        Me.Grelha2.ReadOnly = True
        Me.Grelha2.RowHeadersVisible = False
        Me.Grelha2.Size = New System.Drawing.Size(240, 90)
        Me.Grelha2.TabIndex = 10
        '
        'GrelhaSoma
        '
        Me.GrelhaSoma.AllowUserToAddRows = False
        Me.GrelhaSoma.AllowUserToDeleteRows = False
        Me.GrelhaSoma.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GrelhaSoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrelhaSoma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.GrelhaSoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrelhaSoma.ColumnHeadersVisible = False
        Me.GrelhaSoma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrelhaSoma.DefaultCellStyle = DataGridViewCellStyle12
        Me.GrelhaSoma.Location = New System.Drawing.Point(243, 310)
        Me.GrelhaSoma.Name = "GrelhaSoma"
        Me.GrelhaSoma.ReadOnly = True
        Me.GrelhaSoma.RowHeadersVisible = False
        Me.GrelhaSoma.Size = New System.Drawing.Size(240, 90)
        Me.GrelhaSoma.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 450)
        Me.Controls.Add(Me.GrelhaSoma)
        Me.Controls.Add(Me.Grelha2)
        Me.Controls.Add(Me.bttOk1)
        Me.Controls.Add(Me.bttOk2)
        Me.Controls.Add(Me.bttSoma)
        Me.Controls.Add(Me.Grelha1)
        Me.Controls.Add(Me.TxtValor1)
        Me.Controls.Add(Me.TxtValor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Soma de Matrizes"
        CType(Me.Grelha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grelha2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrelhaSoma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValor2 As TextBox
    Friend WithEvents TxtValor1 As TextBox
    Friend WithEvents Grelha1 As DataGridView
    Friend WithEvents bttSoma As Button
    Friend WithEvents bttOk2 As Button
    Friend WithEvents bttOk1 As Button
    Friend WithEvents Grelha2 As DataGridView
    Friend WithEvents GrelhaSoma As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
