<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lbvalor
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
        Me.bttcalcular = New System.Windows.Forms.Button()
        Me.txtlitros = New System.Windows.Forms.TextBox()
        Me.txtpreco = New System.Windows.Forms.TextBox()
        Me.txtdistancia = New System.Windows.Forms.TextBox()
        Me.litros = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbconsumo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttcalcular
        '
        Me.bttcalcular.Location = New System.Drawing.Point(537, 66)
        Me.bttcalcular.Name = "bttcalcular"
        Me.bttcalcular.Size = New System.Drawing.Size(105, 36)
        Me.bttcalcular.TabIndex = 0
        Me.bttcalcular.Text = "Calcular"
        Me.bttcalcular.UseVisualStyleBackColor = True
        '
        'txtlitros
        '
        Me.txtlitros.Location = New System.Drawing.Point(145, 75)
        Me.txtlitros.Name = "txtlitros"
        Me.txtlitros.Size = New System.Drawing.Size(124, 20)
        Me.txtlitros.TabIndex = 1
        '
        'txtpreco
        '
        Me.txtpreco.Location = New System.Drawing.Point(145, 115)
        Me.txtpreco.Name = "txtpreco"
        Me.txtpreco.Size = New System.Drawing.Size(131, 20)
        Me.txtpreco.TabIndex = 2
        '
        'txtdistancia
        '
        Me.txtdistancia.Location = New System.Drawing.Point(145, 141)
        Me.txtdistancia.Name = "txtdistancia"
        Me.txtdistancia.Size = New System.Drawing.Size(132, 20)
        Me.txtdistancia.TabIndex = 3
        '
        'litros
        '
        Me.litros.AutoSize = True
        Me.litros.Location = New System.Drawing.Point(55, 75)
        Me.litros.Name = "litros"
        Me.litros.Size = New System.Drawing.Size(28, 13)
        Me.litros.TabIndex = 4
        Me.litros.Text = "litros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Preços por Litros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Distância"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Consumo"
        '
        'lbconsumo
        '
        Me.lbconsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbconsumo.Location = New System.Drawing.Point(145, 193)
        Me.lbconsumo.Name = "lbconsumo"
        Me.lbconsumo.Size = New System.Drawing.Size(114, 23)
        Me.lbconsumo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Valor"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(587, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 10
        '
        'lbvalor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbconsumo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.litros)
        Me.Controls.Add(Me.txtdistancia)
        Me.Controls.Add(Me.txtpreco)
        Me.Controls.Add(Me.txtlitros)
        Me.Controls.Add(Me.bttcalcular)
        Me.Name = "lbvalor"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttcalcular As Button
    Friend WithEvents txtlitros As TextBox
    Friend WithEvents txtpreco As TextBox
    Friend WithEvents txtdistancia As TextBox
    Friend WithEvents litros As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbconsumo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
