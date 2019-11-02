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
        Me.bttPreencher = New System.Windows.Forms.Button()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbPar = New System.Windows.Forms.Label()
        Me.LbImpar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttPreencher
        '
        Me.bttPreencher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttPreencher.Location = New System.Drawing.Point(64, 40)
        Me.bttPreencher.Name = "bttPreencher"
        Me.bttPreencher.Size = New System.Drawing.Size(248, 47)
        Me.bttPreencher.TabIndex = 0
        Me.bttPreencher.Text = "Prencher Vetor"
        Me.bttPreencher.UseVisualStyleBackColor = True
        '
        'bttCalcular
        '
        Me.bttCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttCalcular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCalcular.Location = New System.Drawing.Point(128, 112)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(112, 53)
        Me.bttCalcular.TabIndex = 2
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Números Pares"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Números Impares"
        '
        'LbPar
        '
        Me.LbPar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPar.Location = New System.Drawing.Point(256, 264)
        Me.LbPar.Name = "LbPar"
        Me.LbPar.Size = New System.Drawing.Size(100, 23)
        Me.LbPar.TabIndex = 5
        '
        'LbImpar
        '
        Me.LbImpar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImpar.Location = New System.Drawing.Point(256, 312)
        Me.LbImpar.Name = "LbImpar"
        Me.LbImpar.Size = New System.Drawing.Size(100, 23)
        Me.LbImpar.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 401)
        Me.Controls.Add(Me.LbImpar)
        Me.Controls.Add(Me.LbPar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.bttPreencher)
        Me.Name = "Form1"
        Me.Text = "Par e Impar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttPreencher As Button
    Friend WithEvents bttCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbPar As Label
    Friend WithEvents LbImpar As Label
End Class
