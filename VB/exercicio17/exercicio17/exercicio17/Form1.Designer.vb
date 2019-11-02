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
        Me.TabDigitoControl = New System.Windows.Forms.TabControl()
        Me.TabDigitoControlo = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbControloBI = New System.Windows.Forms.Label()
        Me.bttCalcularBI = New System.Windows.Forms.Button()
        Me.MtxtBI = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LbContribuinte = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MtxtContribuinte = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbDigitocont = New System.Windows.Forms.Label()
        Me.bttCalcularContr = New System.Windows.Forms.Button()
        Me.bttReiniciar = New System.Windows.Forms.Button()
        Me.TabDigitoControl.SuspendLayout()
        Me.TabDigitoControlo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabDigitoControl
        '
        Me.TabDigitoControl.Controls.Add(Me.TabDigitoControlo)
        Me.TabDigitoControl.Controls.Add(Me.TabPage2)
        Me.TabDigitoControl.Location = New System.Drawing.Point(40, 40)
        Me.TabDigitoControl.Name = "TabDigitoControl"
        Me.TabDigitoControl.SelectedIndex = 0
        Me.TabDigitoControl.Size = New System.Drawing.Size(384, 304)
        Me.TabDigitoControl.TabIndex = 0
        '
        'TabDigitoControlo
        '
        Me.TabDigitoControlo.Controls.Add(Me.Label4)
        Me.TabDigitoControlo.Controls.Add(Me.Label1)
        Me.TabDigitoControlo.Controls.Add(Me.LbControloBI)
        Me.TabDigitoControlo.Controls.Add(Me.bttCalcularBI)
        Me.TabDigitoControlo.Controls.Add(Me.MtxtBI)
        Me.TabDigitoControlo.Location = New System.Drawing.Point(4, 22)
        Me.TabDigitoControlo.Name = "TabDigitoControlo"
        Me.TabDigitoControlo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDigitoControlo.Size = New System.Drawing.Size(376, 278)
        Me.TabDigitoControlo.TabIndex = 0
        Me.TabDigitoControlo.Text = "Bilhete de Identidade"
        Me.TabDigitoControlo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nº. Bilhete Identidade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Digito de Contrlo"
        '
        'LbControloBI
        '
        Me.LbControloBI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbControloBI.Location = New System.Drawing.Point(176, 136)
        Me.LbControloBI.Name = "LbControloBI"
        Me.LbControloBI.Size = New System.Drawing.Size(104, 23)
        Me.LbControloBI.TabIndex = 2
        '
        'bttCalcularBI
        '
        Me.bttCalcularBI.Location = New System.Drawing.Point(264, 88)
        Me.bttCalcularBI.Name = "bttCalcularBI"
        Me.bttCalcularBI.Size = New System.Drawing.Size(75, 23)
        Me.bttCalcularBI.TabIndex = 1
        Me.bttCalcularBI.Text = "Calcular"
        Me.bttCalcularBI.UseVisualStyleBackColor = True
        '
        'MtxtBI
        '
        Me.MtxtBI.Location = New System.Drawing.Point(168, 88)
        Me.MtxtBI.Mask = "00000000"
        Me.MtxtBI.Name = "MtxtBI"
        Me.MtxtBI.Size = New System.Drawing.Size(80, 20)
        Me.MtxtBI.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LbContribuinte)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.MtxtContribuinte)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.LbDigitocont)
        Me.TabPage2.Controls.Add(Me.bttCalcularContr)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "N.º Contribuinte"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LbContribuinte
        '
        Me.LbContribuinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbContribuinte.Location = New System.Drawing.Point(112, 216)
        Me.LbContribuinte.Name = "LbContribuinte"
        Me.LbContribuinte.Size = New System.Drawing.Size(104, 23)
        Me.LbContribuinte.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nº. Contribuinte Completo"
        '
        'MtxtContribuinte
        '
        Me.MtxtContribuinte.Location = New System.Drawing.Point(144, 104)
        Me.MtxtContribuinte.Mask = "00000000"
        Me.MtxtContribuinte.Name = "MtxtContribuinte"
        Me.MtxtContribuinte.Size = New System.Drawing.Size(100, 20)
        Me.MtxtContribuinte.TabIndex = 12
        Me.MtxtContribuinte.ValidatingType = GetType(Integer)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nº. Contribuinte"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Digito de Contrlo"
        '
        'LbDigitocont
        '
        Me.LbDigitocont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDigitocont.Location = New System.Drawing.Point(187, 152)
        Me.LbDigitocont.Name = "LbDigitocont"
        Me.LbDigitocont.Size = New System.Drawing.Size(56, 23)
        Me.LbDigitocont.TabIndex = 9
        '
        'bttCalcularContr
        '
        Me.bttCalcularContr.Location = New System.Drawing.Point(275, 104)
        Me.bttCalcularContr.Name = "bttCalcularContr"
        Me.bttCalcularContr.Size = New System.Drawing.Size(75, 23)
        Me.bttCalcularContr.TabIndex = 8
        Me.bttCalcularContr.Text = "Calcular"
        Me.bttCalcularContr.UseVisualStyleBackColor = True
        '
        'bttReiniciar
        '
        Me.bttReiniciar.Location = New System.Drawing.Point(312, 368)
        Me.bttReiniciar.Name = "bttReiniciar"
        Me.bttReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.bttReiniciar.TabIndex = 1
        Me.bttReiniciar.Text = "Reiniciar"
        Me.bttReiniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 450)
        Me.Controls.Add(Me.bttReiniciar)
        Me.Controls.Add(Me.TabDigitoControl)
        Me.Name = "Form1"
        Me.Text = "Digitto de Controlo"
        Me.TabDigitoControl.ResumeLayout(False)
        Me.TabDigitoControlo.ResumeLayout(False)
        Me.TabDigitoControlo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabDigitoControl As TabControl
    Friend WithEvents TabDigitoControlo As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbControloBI As Label
    Friend WithEvents bttCalcularBI As Button
    Friend WithEvents MtxtBI As MaskedTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LbContribuinte As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MtxtContribuinte As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LbDigitocont As Label
    Friend WithEvents bttCalcularContr As Button
    Friend WithEvents bttReiniciar As Button
End Class
