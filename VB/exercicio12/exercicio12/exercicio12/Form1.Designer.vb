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
        Me.DtpCalendario = New System.Windows.Forms.DateTimePicker()
        Me.PicMain = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbSigno = New System.Windows.Forms.Label()
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpCalendario
        '
        Me.DtpCalendario.Location = New System.Drawing.Point(64, 56)
        Me.DtpCalendario.Name = "DtpCalendario"
        Me.DtpCalendario.Size = New System.Drawing.Size(336, 20)
        Me.DtpCalendario.TabIndex = 0
        '
        'PicMain
        '
        Me.PicMain.Location = New System.Drawing.Point(104, 304)
        Me.PicMain.Name = "PicMain"
        Me.PicMain.Size = New System.Drawing.Size(272, 136)
        Me.PicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMain.TabIndex = 1
        Me.PicMain.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Signo"
        '
        'LbSigno
        '
        Me.LbSigno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSigno.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSigno.Location = New System.Drawing.Point(136, 264)
        Me.LbSigno.Name = "LbSigno"
        Me.LbSigno.Size = New System.Drawing.Size(208, 40)
        Me.LbSigno.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.exercicio12.My.Resources.Resources.círculo_de_signos
        Me.ClientSize = New System.Drawing.Size(485, 450)
        Me.Controls.Add(Me.LbSigno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicMain)
        Me.Controls.Add(Me.DtpCalendario)
        Me.Name = "Form1"
        Me.Text = "Zodíaco "
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpCalendario As DateTimePicker
    Friend WithEvents PicMain As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LbSigno As Label
End Class
