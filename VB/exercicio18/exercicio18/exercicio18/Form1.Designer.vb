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
        Me.bttIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbNpessoas = New System.Windows.Forms.Label()
        Me.LbMedia = New System.Windows.Forms.Label()
        Me.LbMaisVelha = New System.Windows.Forms.Label()
        Me.LbMaisNova = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttIniciar
        '
        Me.bttIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttIniciar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttIniciar.Location = New System.Drawing.Point(56, 64)
        Me.bttIniciar.Name = "bttIniciar"
        Me.bttIniciar.Size = New System.Drawing.Size(312, 32)
        Me.bttIniciar.TabIndex = 0
        Me.bttIniciar.Text = "Iniciar a Introdução das Idades"
        Me.bttIniciar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Pessoas"
        '
        'LbNpessoas
        '
        Me.LbNpessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNpessoas.Location = New System.Drawing.Point(256, 152)
        Me.LbNpessoas.Name = "LbNpessoas"
        Me.LbNpessoas.Size = New System.Drawing.Size(104, 32)
        Me.LbNpessoas.TabIndex = 2
        Me.LbNpessoas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbMedia
        '
        Me.LbMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMedia.Location = New System.Drawing.Point(256, 202)
        Me.LbMedia.Name = "LbMedia"
        Me.LbMedia.Size = New System.Drawing.Size(104, 32)
        Me.LbMedia.TabIndex = 3
        Me.LbMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbMaisVelha
        '
        Me.LbMaisVelha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMaisVelha.Location = New System.Drawing.Point(256, 252)
        Me.LbMaisVelha.Name = "LbMaisVelha"
        Me.LbMaisVelha.Size = New System.Drawing.Size(104, 32)
        Me.LbMaisVelha.TabIndex = 4
        Me.LbMaisVelha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbMaisNova
        '
        Me.LbMaisNova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMaisNova.Location = New System.Drawing.Point(256, 302)
        Me.LbMaisNova.Name = "LbMaisNova"
        Me.LbMaisNova.Size = New System.Drawing.Size(104, 32)
        Me.LbMaisNova.TabIndex = 5
        Me.LbMaisNova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Média de Idades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pessoa mais velha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pessoa mais nova"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exercicio18.My.Resources.Resources.nuves
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(433, 382)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbMaisNova)
        Me.Controls.Add(Me.LbMaisVelha)
        Me.Controls.Add(Me.LbMedia)
        Me.Controls.Add(Me.LbNpessoas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttIniciar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttIniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbNpessoas As Label
    Friend WithEvents LbMedia As Label
    Friend WithEvents LbMaisVelha As Label
    Friend WithEvents LbMaisNova As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
