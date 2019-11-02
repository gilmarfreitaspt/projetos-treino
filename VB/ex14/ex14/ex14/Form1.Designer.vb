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
        Me.ComboNumero = New System.Windows.Forms.ComboBox()
        Me.ListTabuada = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboNumero
        '
        Me.ComboNumero.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboNumero.FormattingEnabled = True
        Me.ComboNumero.Location = New System.Drawing.Point(144, 65)
        Me.ComboNumero.Name = "ComboNumero"
        Me.ComboNumero.Size = New System.Drawing.Size(121, 21)
        Me.ComboNumero.TabIndex = 0
        '
        'ListTabuada
        '
        Me.ListTabuada.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTabuada.FormattingEnabled = True
        Me.ListTabuada.ItemHeight = 20
        Me.ListTabuada.Location = New System.Drawing.Point(136, 104)
        Me.ListTabuada.Name = "ListTabuada"
        Me.ListTabuada.Size = New System.Drawing.Size(136, 264)
        Me.ListTabuada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ex14.My.Resources.Resources._6e15c0e8c4c098e4184e1757a0b3d6fd
        Me.ClientSize = New System.Drawing.Size(404, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListTabuada)
        Me.Controls.Add(Me.ComboNumero)
        Me.Name = "Form1"
        Me.Text = "TABUADA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboNumero As ComboBox
    Friend WithEvents ListTabuada As ListBox
    Friend WithEvents Label1 As Label
End Class
