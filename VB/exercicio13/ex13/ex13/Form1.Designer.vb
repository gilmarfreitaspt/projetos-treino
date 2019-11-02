<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.bttOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboEstatura = New System.Windows.Forms.ComboBox()
        Me.ComboPasse = New System.Windows.Forms.ComboBox()
        Me.ComboDrible = New System.Windows.Forms.ComboBox()
        Me.ComboRemate = New System.Windows.Forms.ComboBox()
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
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(200, 40)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(304, 20)
        Me.TxtNome.TabIndex = 0
        '
        'bttOk
        '
        Me.bttOk.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttOk.Location = New System.Drawing.Point(584, 96)
        Me.bttOk.Name = "bttOk"
        Me.bttOk.Size = New System.Drawing.Size(75, 72)
        Me.bttOk.TabIndex = 1
        Me.bttOk.Text = "OK"
        Me.bttOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estatura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Drible"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Remate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Passe"
        '
        'ComboEstatura
        '
        Me.ComboEstatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstatura.FormattingEnabled = True
        Me.ComboEstatura.Location = New System.Drawing.Point(136, 88)
        Me.ComboEstatura.Name = "ComboEstatura"
        Me.ComboEstatura.Size = New System.Drawing.Size(121, 21)
        Me.ComboEstatura.TabIndex = 6
        '
        'ComboPasse
        '
        Me.ComboPasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPasse.FormattingEnabled = True
        Me.ComboPasse.Location = New System.Drawing.Point(136, 136)
        Me.ComboPasse.Name = "ComboPasse"
        Me.ComboPasse.Size = New System.Drawing.Size(121, 21)
        Me.ComboPasse.TabIndex = 7
        '
        'ComboDrible
        '
        Me.ComboDrible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDrible.FormattingEnabled = True
        Me.ComboDrible.Location = New System.Drawing.Point(384, 88)
        Me.ComboDrible.Name = "ComboDrible"
        Me.ComboDrible.Size = New System.Drawing.Size(121, 21)
        Me.ComboDrible.TabIndex = 8
        '
        'ComboRemate
        '
        Me.ComboRemate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboRemate.FormattingEnabled = True
        Me.ComboRemate.Location = New System.Drawing.Point(384, 136)
        Me.ComboRemate.Name = "ComboRemate"
        Me.ComboRemate.Size = New System.Drawing.Size(121, 21)
        Me.ComboRemate.TabIndex = 9
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.AllowUserToDeleteRows = False
        Me.Grelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.Grelha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grelha.Location = New System.Drawing.Point(56, 224)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.Size = New System.Drawing.Size(608, 192)
        Me.Grelha.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome do Jogador"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Estatura"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = " Drible"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Passe"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Remate"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Observ"
        Me.Column6.Name = "Column6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ex13.My.Resources.Resources.campo2
        Me.ClientSize = New System.Drawing.Size(731, 450)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.ComboRemate)
        Me.Controls.Add(Me.ComboDrible)
        Me.Controls.Add(Me.ComboPasse)
        Me.Controls.Add(Me.ComboEstatura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttOk)
        Me.Controls.Add(Me.TxtNome)
        Me.Name = "Form1"
        Me.Text = "Observação de Jogadores"
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNome As TextBox
    Friend WithEvents bttOk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboEstatura As ComboBox
    Friend WithEvents ComboPasse As ComboBox
    Friend WithEvents ComboDrible As ComboBox
    Friend WithEvents ComboRemate As ComboBox
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
