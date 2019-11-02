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
        Me.bttApresentar = New System.Windows.Forms.Button()
        Me.bttInserir = New System.Windows.Forms.Button()
        Me.ComboMes = New System.Windows.Forms.ComboBox()
        Me.TxtTemp = New System.Windows.Forms.TextBox()
        Me.LbMesAlta = New System.Windows.Forms.Label()
        Me.LbValorAlta = New System.Windows.Forms.Label()
        Me.LbMesBaixa = New System.Windows.Forms.Label()
        Me.LbValorBaixa = New System.Windows.Forms.Label()
        Me.LbMedia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mês"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temperatura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mais Alta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mais Baixa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Média"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Valor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mês"
        '
        'bttApresentar
        '
        Me.bttApresentar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttApresentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttApresentar.Location = New System.Drawing.Point(251, 185)
        Me.bttApresentar.Name = "bttApresentar"
        Me.bttApresentar.Size = New System.Drawing.Size(209, 23)
        Me.bttApresentar.TabIndex = 7
        Me.bttApresentar.Text = "Apresentar Valores"
        Me.bttApresentar.UseVisualStyleBackColor = False
        '
        'bttInserir
        '
        Me.bttInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttInserir.Location = New System.Drawing.Point(357, 136)
        Me.bttInserir.Name = "bttInserir"
        Me.bttInserir.Size = New System.Drawing.Size(88, 23)
        Me.bttInserir.TabIndex = 8
        Me.bttInserir.Text = "Inserir"
        Me.bttInserir.UseVisualStyleBackColor = False
        '
        'ComboMes
        '
        Me.ComboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMes.FormattingEnabled = True
        Me.ComboMes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.ComboMes.Location = New System.Drawing.Point(251, 89)
        Me.ComboMes.Name = "ComboMes"
        Me.ComboMes.Size = New System.Drawing.Size(209, 23)
        Me.ComboMes.TabIndex = 9
        '
        'TxtTemp
        '
        Me.TxtTemp.Location = New System.Drawing.Point(251, 139)
        Me.TxtTemp.Name = "TxtTemp"
        Me.TxtTemp.Size = New System.Drawing.Size(100, 20)
        Me.TxtTemp.TabIndex = 10
        '
        'LbMesAlta
        '
        Me.LbMesAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMesAlta.Location = New System.Drawing.Point(251, 254)
        Me.LbMesAlta.Name = "LbMesAlta"
        Me.LbMesAlta.Size = New System.Drawing.Size(87, 26)
        Me.LbMesAlta.TabIndex = 11
        '
        'LbValorAlta
        '
        Me.LbValorAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbValorAlta.Location = New System.Drawing.Point(373, 254)
        Me.LbValorAlta.Name = "LbValorAlta"
        Me.LbValorAlta.Size = New System.Drawing.Size(87, 26)
        Me.LbValorAlta.TabIndex = 12
        '
        'LbMesBaixa
        '
        Me.LbMesBaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMesBaixa.Location = New System.Drawing.Point(251, 303)
        Me.LbMesBaixa.Name = "LbMesBaixa"
        Me.LbMesBaixa.Size = New System.Drawing.Size(87, 26)
        Me.LbMesBaixa.TabIndex = 13
        '
        'LbValorBaixa
        '
        Me.LbValorBaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbValorBaixa.Location = New System.Drawing.Point(373, 303)
        Me.LbValorBaixa.Name = "LbValorBaixa"
        Me.LbValorBaixa.Size = New System.Drawing.Size(87, 26)
        Me.LbValorBaixa.TabIndex = 14
        '
        'LbMedia
        '
        Me.LbMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMedia.Location = New System.Drawing.Point(251, 347)
        Me.LbMedia.Name = "LbMedia"
        Me.LbMedia.Size = New System.Drawing.Size(87, 26)
        Me.LbMedia.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exrcicio26.My.Resources.Resources.temperatura
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 450)
        Me.Controls.Add(Me.LbMedia)
        Me.Controls.Add(Me.LbValorBaixa)
        Me.Controls.Add(Me.LbMesBaixa)
        Me.Controls.Add(Me.LbValorAlta)
        Me.Controls.Add(Me.LbMesAlta)
        Me.Controls.Add(Me.TxtTemp)
        Me.Controls.Add(Me.ComboMes)
        Me.Controls.Add(Me.bttInserir)
        Me.Controls.Add(Me.bttApresentar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Temperatura"
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
    Friend WithEvents bttApresentar As Button
    Friend WithEvents bttInserir As Button
    Friend WithEvents ComboMes As ComboBox
    Friend WithEvents TxtTemp As TextBox
    Friend WithEvents LbMesAlta As Label
    Friend WithEvents LbValorAlta As Label
    Friend WithEvents LbMesBaixa As Label
    Friend WithEvents LbValorBaixa As Label
    Friend WithEvents LbMedia As Label
End Class
