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
        Me.bttEntrada = New System.Windows.Forms.Button()
        Me.bttSaida = New System.Windows.Forms.Button()
        Me.LbDataEntrada = New System.Windows.Forms.Label()
        Me.LbDataSaida = New System.Windows.Forms.Label()
        Me.LbHoraEntrada = New System.Windows.Forms.Label()
        Me.LbHoraSaida = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbPagar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttEntrada
        '
        Me.bttEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttEntrada.Location = New System.Drawing.Point(24, 48)
        Me.bttEntrada.Name = "bttEntrada"
        Me.bttEntrada.Size = New System.Drawing.Size(75, 23)
        Me.bttEntrada.TabIndex = 0
        Me.bttEntrada.Text = "Entrada"
        Me.bttEntrada.UseVisualStyleBackColor = False
        '
        'bttSaida
        '
        Me.bttSaida.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttSaida.Enabled = False
        Me.bttSaida.Location = New System.Drawing.Point(24, 104)
        Me.bttSaida.Name = "bttSaida"
        Me.bttSaida.Size = New System.Drawing.Size(75, 23)
        Me.bttSaida.TabIndex = 1
        Me.bttSaida.Text = "Saida"
        Me.bttSaida.UseVisualStyleBackColor = False
        '
        'LbDataEntrada
        '
        Me.LbDataEntrada.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDataEntrada.Location = New System.Drawing.Point(128, 48)
        Me.LbDataEntrada.Name = "LbDataEntrada"
        Me.LbDataEntrada.Size = New System.Drawing.Size(88, 24)
        Me.LbDataEntrada.TabIndex = 3
        '
        'LbDataSaida
        '
        Me.LbDataSaida.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbDataSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDataSaida.Location = New System.Drawing.Point(128, 104)
        Me.LbDataSaida.Name = "LbDataSaida"
        Me.LbDataSaida.Size = New System.Drawing.Size(88, 24)
        Me.LbDataSaida.TabIndex = 4
        '
        'LbHoraEntrada
        '
        Me.LbHoraEntrada.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbHoraEntrada.Location = New System.Drawing.Point(280, 48)
        Me.LbHoraEntrada.Name = "LbHoraEntrada"
        Me.LbHoraEntrada.Size = New System.Drawing.Size(88, 24)
        Me.LbHoraEntrada.TabIndex = 5
        '
        'LbHoraSaida
        '
        Me.LbHoraSaida.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbHoraSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbHoraSaida.Location = New System.Drawing.Point(280, 104)
        Me.LbHoraSaida.Name = "LbHoraSaida"
        Me.LbHoraSaida.Size = New System.Drawing.Size(88, 24)
        Me.LbHoraSaida.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Data"
        '
        'LbPagar
        '
        Me.LbPagar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPagar.Location = New System.Drawing.Point(280, 208)
        Me.LbPagar.Name = "LbPagar"
        Me.LbPagar.Size = New System.Drawing.Size(88, 24)
        Me.LbPagar.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Valor a pagar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Valor 15Min"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(144, 208)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(100, 25)
        Me.TxtValor.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.exercicio07basic.My.Resources.Resources.minha_foto
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 530)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbPagar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbHoraSaida)
        Me.Controls.Add(Me.LbHoraEntrada)
        Me.Controls.Add(Me.LbDataSaida)
        Me.Controls.Add(Me.LbDataEntrada)
        Me.Controls.Add(Me.bttSaida)
        Me.Controls.Add(Me.bttEntrada)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Estacionamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttEntrada As Button
    Friend WithEvents bttSaida As Button
    Friend WithEvents LbDataEntrada As Label
    Friend WithEvents LbDataSaida As Label
    Friend WithEvents LbHoraEntrada As Label
    Friend WithEvents LbHoraSaida As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbPagar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtValor As TextBox
End Class
