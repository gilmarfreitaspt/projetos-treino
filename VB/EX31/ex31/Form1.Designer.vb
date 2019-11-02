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
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.LstPalavras = New System.Windows.Forms.ListBox()
        Me.LbPalavras = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttAbrir = New System.Windows.Forms.Button()
        Me.bttVerificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtTexto
        '
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.Location = New System.Drawing.Point(68, 44)
        Me.TxtTexto.Multiline = True
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(126, 223)
        Me.TxtTexto.TabIndex = 0
        '
        'LstPalavras
        '
        Me.LstPalavras.FormattingEnabled = True
        Me.LstPalavras.Location = New System.Drawing.Point(294, 44)
        Me.LstPalavras.Name = "LstPalavras"
        Me.LstPalavras.Size = New System.Drawing.Size(120, 225)
        Me.LstPalavras.TabIndex = 1
        '
        'LbPalavras
        '
        Me.LbPalavras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPalavras.Location = New System.Drawing.Point(216, 387)
        Me.LbPalavras.Name = "LbPalavras"
        Me.LbPalavras.Size = New System.Drawing.Size(74, 23)
        Me.LbPalavras.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total de Palavras"
        '
        'bttAbrir
        '
        Me.bttAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAbrir.Location = New System.Drawing.Point(68, 330)
        Me.bttAbrir.Name = "bttAbrir"
        Me.bttAbrir.Size = New System.Drawing.Size(88, 31)
        Me.bttAbrir.TabIndex = 4
        Me.bttAbrir.Text = "Abrir"
        Me.bttAbrir.UseVisualStyleBackColor = True
        '
        'bttVerificar
        '
        Me.bttVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttVerificar.Location = New System.Drawing.Point(183, 330)
        Me.bttVerificar.Name = "bttVerificar"
        Me.bttVerificar.Size = New System.Drawing.Size(88, 31)
        Me.bttVerificar.TabIndex = 5
        Me.bttVerificar.Text = "Verificar"
        Me.bttVerificar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Texto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Palavras Distintas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttVerificar)
        Me.Controls.Add(Me.bttAbrir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbPalavras)
        Me.Controls.Add(Me.LstPalavras)
        Me.Controls.Add(Me.TxtTexto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Palavras Distintas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents LstPalavras As ListBox
    Friend WithEvents LbPalavras As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttAbrir As Button
    Friend WithEvents bttVerificar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
