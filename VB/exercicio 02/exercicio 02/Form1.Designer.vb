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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbExtra = New System.Windows.Forms.Label()
        Me.lbSuplemento = New System.Windows.Forms.Label()
        Me.lbIrs = New System.Windows.Forms.Label()
        Me.lbSsocial = New System.Windows.Forms.Label()
        Me.lbReceber = New System.Windows.Forms.Label()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.bttLimpar = New System.Windows.Forms.Button()
        Me.txtVencimento = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtFilhos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vencimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horas Extraordinarias"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Qta. Filhos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor da Hora"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Horas Extras"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Suplementos (Filhos)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "IRS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "S.Social"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "A receber"
        '
        'lbHora
        '
        Me.lbHora.BackColor = System.Drawing.Color.SpringGreen
        Me.lbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbHora.Location = New System.Drawing.Point(159, 190)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(104, 22)
        Me.lbHora.TabIndex = 9
        '
        'lbExtra
        '
        Me.lbExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbExtra.Location = New System.Drawing.Point(159, 225)
        Me.lbExtra.Name = "lbExtra"
        Me.lbExtra.Size = New System.Drawing.Size(104, 24)
        Me.lbExtra.TabIndex = 10
        '
        'lbSuplemento
        '
        Me.lbSuplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSuplemento.Location = New System.Drawing.Point(159, 262)
        Me.lbSuplemento.Name = "lbSuplemento"
        Me.lbSuplemento.Size = New System.Drawing.Size(104, 20)
        Me.lbSuplemento.TabIndex = 11
        '
        'lbIrs
        '
        Me.lbIrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbIrs.Location = New System.Drawing.Point(159, 294)
        Me.lbIrs.Name = "lbIrs"
        Me.lbIrs.Size = New System.Drawing.Size(104, 20)
        Me.lbIrs.TabIndex = 12
        '
        'lbSsocial
        '
        Me.lbSsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSsocial.Location = New System.Drawing.Point(159, 330)
        Me.lbSsocial.Name = "lbSsocial"
        Me.lbSsocial.Size = New System.Drawing.Size(104, 20)
        Me.lbSsocial.TabIndex = 13
        '
        'lbReceber
        '
        Me.lbReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbReceber.Location = New System.Drawing.Point(159, 366)
        Me.lbReceber.Name = "lbReceber"
        Me.lbReceber.Size = New System.Drawing.Size(104, 20)
        Me.lbReceber.TabIndex = 14
        '
        'bttCalcular
        '
        Me.bttCalcular.Location = New System.Drawing.Point(29, 136)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(105, 35)
        Me.bttCalcular.TabIndex = 15
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = True
        '
        'bttLimpar
        '
        Me.bttLimpar.Location = New System.Drawing.Point(164, 136)
        Me.bttLimpar.Name = "bttLimpar"
        Me.bttLimpar.Size = New System.Drawing.Size(99, 35)
        Me.bttLimpar.TabIndex = 16
        Me.bttLimpar.Text = "Limpar"
        Me.bttLimpar.UseVisualStyleBackColor = True
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(175, 23)
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(83, 20)
        Me.txtVencimento.TabIndex = 17
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(175, 58)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(83, 20)
        Me.txtHoras.TabIndex = 18
        '
        'txtFilhos
        '
        Me.txtFilhos.Location = New System.Drawing.Point(175, 93)
        Me.txtFilhos.Name = "txtFilhos"
        Me.txtFilhos.Size = New System.Drawing.Size(83, 20)
        Me.txtFilhos.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(281, 400)
        Me.Controls.Add(Me.txtFilhos)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtVencimento)
        Me.Controls.Add(Me.bttLimpar)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.lbReceber)
        Me.Controls.Add(Me.lbSsocial)
        Me.Controls.Add(Me.lbIrs)
        Me.Controls.Add(Me.lbSuplemento)
        Me.Controls.Add(Me.lbExtra)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbHora As Label
    Friend WithEvents lbExtra As Label
    Friend WithEvents lbSuplemento As Label
    Friend WithEvents lbIrs As Label
    Friend WithEvents lbSsocial As Label
    Friend WithEvents lbReceber As Label
    Friend WithEvents bttCalcular As Button
    Friend WithEvents bttLimpar As Button
    Friend WithEvents txtVencimento As TextBox
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtFilhos As TextBox
End Class
