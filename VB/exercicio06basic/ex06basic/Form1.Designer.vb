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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboEquipaA = New System.Windows.Forms.ComboBox()
        Me.ComboEquipaB = New System.Windows.Forms.ComboBox()
        Me.bttConfirmar = New System.Windows.Forms.Button()
        Me.NudGolosA = New System.Windows.Forms.NumericUpDown()
        Me.NudGolosB = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grelha = New System.Windows.Forms.DataGridView()
        Me.equipa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pontos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gmarcados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gsofridos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NudGolosA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudGolosB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboEquipaA
        '
        Me.ComboEquipaA.FormattingEnabled = True
        Me.ComboEquipaA.Location = New System.Drawing.Point(80, 72)
        Me.ComboEquipaA.Name = "ComboEquipaA"
        Me.ComboEquipaA.Size = New System.Drawing.Size(121, 27)
        Me.ComboEquipaA.TabIndex = 0
        '
        'ComboEquipaB
        '
        Me.ComboEquipaB.FormattingEnabled = True
        Me.ComboEquipaB.Location = New System.Drawing.Point(384, 72)
        Me.ComboEquipaB.Name = "ComboEquipaB"
        Me.ComboEquipaB.Size = New System.Drawing.Size(121, 27)
        Me.ComboEquipaB.TabIndex = 1
        '
        'bttConfirmar
        '
        Me.bttConfirmar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bttConfirmar.Location = New System.Drawing.Point(208, 160)
        Me.bttConfirmar.Name = "bttConfirmar"
        Me.bttConfirmar.Size = New System.Drawing.Size(168, 40)
        Me.bttConfirmar.TabIndex = 2
        Me.bttConfirmar.Text = "Confirmar"
        Me.bttConfirmar.UseVisualStyleBackColor = True
        '
        'NudGolosA
        '
        Me.NudGolosA.Location = New System.Drawing.Point(256, 72)
        Me.NudGolosA.Name = "NudGolosA"
        Me.NudGolosA.Size = New System.Drawing.Size(48, 26)
        Me.NudGolosA.TabIndex = 3
        '
        'NudGolosB
        '
        Me.NudGolosB.Location = New System.Drawing.Point(304, 72)
        Me.NudGolosB.Name = "NudGolosB"
        Me.NudGolosB.Size = New System.Drawing.Size(48, 26)
        Me.NudGolosB.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Equipa A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Equipa B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resultado"
        '
        'grelha
        '
        Me.grelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grelha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.equipa, Me.pontos, Me.gmarcados, Me.gsofridos})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grelha.DefaultCellStyle = DataGridViewCellStyle1
        Me.grelha.Enabled = False
        Me.grelha.Location = New System.Drawing.Point(104, 240)
        Me.grelha.Name = "grelha"
        Me.grelha.RowHeadersVisible = False
        Me.grelha.Size = New System.Drawing.Size(400, 216)
        Me.grelha.TabIndex = 8
        '
        'equipa
        '
        Me.equipa.HeaderText = "Equipa"
        Me.equipa.Name = "equipa"
        '
        'pontos
        '
        Me.pontos.HeaderText = "Pontos"
        Me.pontos.Name = "pontos"
        '
        'gmarcados
        '
        Me.gmarcados.HeaderText = "G.Marcados"
        Me.gmarcados.Name = "gmarcados"
        '
        'gsofridos
        '
        Me.gsofridos.HeaderText = "G.Sofridos"
        Me.gsofridos.Name = "gsofridos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 470)
        Me.Controls.Add(Me.grelha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NudGolosB)
        Me.Controls.Add(Me.NudGolosA)
        Me.Controls.Add(Me.bttConfirmar)
        Me.Controls.Add(Me.ComboEquipaB)
        Me.Controls.Add(Me.ComboEquipaA)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Torneio"
        CType(Me.NudGolosA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudGolosB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboEquipaA As ComboBox
    Friend WithEvents ComboEquipaB As ComboBox
    Friend WithEvents bttConfirmar As Button
    Friend WithEvents NudGolosA As NumericUpDown
    Friend WithEvents NudGolosB As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grelha As DataGridView
    Friend WithEvents equipa As DataGridViewTextBoxColumn
    Friend WithEvents pontos As DataGridViewTextBoxColumn
    Friend WithEvents gmarcados As DataGridViewTextBoxColumn
    Friend WithEvents gsofridos As DataGridViewTextBoxColumn
End Class
