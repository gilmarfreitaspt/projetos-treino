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
        Me.LstVector1 = New System.Windows.Forms.ListBox()
        Me.bttOk1 = New System.Windows.Forms.Button()
        Me.TxtVector1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bttOk2 = New System.Windows.Forms.Button()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.TxtVector2 = New System.Windows.Forms.TextBox()
        Me.LstVector2 = New System.Windows.Forms.ListBox()
        Me.LstVector3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LstVector1
        '
        Me.LstVector1.FormattingEnabled = True
        Me.LstVector1.Location = New System.Drawing.Point(49, 134)
        Me.LstVector1.Name = "LstVector1"
        Me.LstVector1.Size = New System.Drawing.Size(129, 251)
        Me.LstVector1.TabIndex = 0
        '
        'bttOk1
        '
        Me.bttOk1.BackColor = System.Drawing.Color.Lime
        Me.bttOk1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttOk1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bttOk1.Location = New System.Drawing.Point(138, 79)
        Me.bttOk1.Name = "bttOk1"
        Me.bttOk1.Size = New System.Drawing.Size(40, 23)
        Me.bttOk1.TabIndex = 1
        Me.bttOk1.Text = "OK"
        Me.bttOk1.UseVisualStyleBackColor = False
        '
        'TxtVector1
        '
        Me.TxtVector1.Location = New System.Drawing.Point(49, 82)
        Me.TxtVector1.Name = "TxtVector1"
        Me.TxtVector1.Size = New System.Drawing.Size(83, 20)
        Me.TxtVector1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vector 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vector 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Soma dos Vectores"
        '
        'bttOk2
        '
        Me.bttOk2.BackColor = System.Drawing.Color.Lime
        Me.bttOk2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttOk2.Location = New System.Drawing.Point(311, 79)
        Me.bttOk2.Name = "bttOk2"
        Me.bttOk2.Size = New System.Drawing.Size(43, 23)
        Me.bttOk2.TabIndex = 6
        Me.bttOk2.Text = "OK"
        Me.bttOk2.UseVisualStyleBackColor = False
        '
        'bttCalcular
        '
        Me.bttCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttCalcular.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCalcular.Location = New System.Drawing.Point(417, 79)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(110, 23)
        Me.bttCalcular.TabIndex = 7
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = False
        '
        'TxtVector2
        '
        Me.TxtVector2.Location = New System.Drawing.Point(224, 82)
        Me.TxtVector2.Name = "TxtVector2"
        Me.TxtVector2.Size = New System.Drawing.Size(81, 20)
        Me.TxtVector2.TabIndex = 8
        '
        'LstVector2
        '
        Me.LstVector2.FormattingEnabled = True
        Me.LstVector2.Location = New System.Drawing.Point(226, 134)
        Me.LstVector2.Name = "LstVector2"
        Me.LstVector2.Size = New System.Drawing.Size(134, 251)
        Me.LstVector2.TabIndex = 9
        '
        'LstVector3
        '
        Me.LstVector3.FormattingEnabled = True
        Me.LstVector3.Location = New System.Drawing.Point(408, 134)
        Me.LstVector3.Name = "LstVector3"
        Me.LstVector3.Size = New System.Drawing.Size(129, 251)
        Me.LstVector3.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Exercicio21.My.Resources.Resources.papel_de_parede
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.LstVector3)
        Me.Controls.Add(Me.LstVector2)
        Me.Controls.Add(Me.TxtVector2)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.bttOk2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtVector1)
        Me.Controls.Add(Me.bttOk1)
        Me.Controls.Add(Me.LstVector1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstVector1 As ListBox
    Friend WithEvents bttOk1 As Button
    Friend WithEvents TxtVector1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bttOk2 As Button
    Friend WithEvents bttCalcular As Button
    Friend WithEvents TxtVector2 As TextBox
    Friend WithEvents LstVector2 As ListBox
    Friend WithEvents LstVector3 As ListBox
End Class
