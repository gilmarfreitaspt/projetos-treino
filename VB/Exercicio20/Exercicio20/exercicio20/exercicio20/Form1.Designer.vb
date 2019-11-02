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
        Me.TxtMensagem = New System.Windows.Forms.TextBox()
        Me.bttEncripitar = New System.Windows.Forms.Button()
        Me.bttDesencripitar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtMensagem
        '
        Me.TxtMensagem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMensagem.Location = New System.Drawing.Point(0, 27)
        Me.TxtMensagem.Multiline = True
        Me.TxtMensagem.Name = "TxtMensagem"
        Me.TxtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMensagem.Size = New System.Drawing.Size(247, 191)
        Me.TxtMensagem.TabIndex = 1
        '
        'bttEncripitar
        '
        Me.bttEncripitar.BackColor = System.Drawing.Color.Red
        Me.bttEncripitar.Enabled = False
        Me.bttEncripitar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttEncripitar.Location = New System.Drawing.Point(72, 288)
        Me.bttEncripitar.Name = "bttEncripitar"
        Me.bttEncripitar.Size = New System.Drawing.Size(94, 35)
        Me.bttEncripitar.TabIndex = 2
        Me.bttEncripitar.Text = "Encripitar"
        Me.bttEncripitar.UseVisualStyleBackColor = False
        '
        'bttDesencripitar
        '
        Me.bttDesencripitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttDesencripitar.Enabled = False
        Me.bttDesencripitar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttDesencripitar.Location = New System.Drawing.Point(51, 340)
        Me.bttDesencripitar.Name = "bttDesencripitar"
        Me.bttDesencripitar.Size = New System.Drawing.Size(128, 35)
        Me.bttDesencripitar.TabIndex = 3
        Me.bttDesencripitar.Text = "Desencripitar"
        Me.bttDesencripitar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mensagem"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exercicio20.My.Resources.Resources.sussurro_do_agente_secreto
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttDesencripitar)
        Me.Controls.Add(Me.bttEncripitar)
        Me.Controls.Add(Me.TxtMensagem)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Encripitação de Dados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMensagem As TextBox
    Friend WithEvents bttEncripitar As Button
    Friend WithEvents bttDesencripitar As Button
    Friend WithEvents Label1 As Label
End Class
