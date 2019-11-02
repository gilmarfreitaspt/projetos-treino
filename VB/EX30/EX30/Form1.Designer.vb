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
        Me.bttPais = New System.Windows.Forms.Button()
        Me.bttCidade = New System.Windows.Forms.Button()
        Me.LstPaises = New System.Windows.Forms.ListBox()
        Me.LstCidades = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paises"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cidades"
        '
        'bttPais
        '
        Me.bttPais.Location = New System.Drawing.Point(63, 412)
        Me.bttPais.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttPais.Name = "bttPais"
        Me.bttPais.Size = New System.Drawing.Size(131, 34)
        Me.bttPais.TabIndex = 2
        Me.bttPais.Text = "Adicionar País"
        Me.bttPais.UseVisualStyleBackColor = True
        '
        'bttCidade
        '
        Me.bttCidade.Location = New System.Drawing.Point(324, 412)
        Me.bttCidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttCidade.Name = "bttCidade"
        Me.bttCidade.Size = New System.Drawing.Size(131, 34)
        Me.bttCidade.TabIndex = 3
        Me.bttCidade.Text = "Adicionar Cidade"
        Me.bttCidade.UseVisualStyleBackColor = True
        '
        'LstPaises
        '
        Me.LstPaises.FormattingEnabled = True
        Me.LstPaises.ItemHeight = 15
        Me.LstPaises.Location = New System.Drawing.Point(63, 149)
        Me.LstPaises.Name = "LstPaises"
        Me.LstPaises.Size = New System.Drawing.Size(131, 244)
        Me.LstPaises.TabIndex = 4
        '
        'LstCidades
        '
        Me.LstCidades.FormattingEnabled = True
        Me.LstCidades.ItemHeight = 15
        Me.LstCidades.Location = New System.Drawing.Point(324, 149)
        Me.LstCidades.Name = "LstCidades"
        Me.LstCidades.Size = New System.Drawing.Size(131, 244)
        Me.LstCidades.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EX30.My.Resources.Resources.Paises
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 501)
        Me.Controls.Add(Me.LstCidades)
        Me.Controls.Add(Me.LstPaises)
        Me.Controls.Add(Me.bttCidade)
        Me.Controls.Add(Me.bttPais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Paises e Cidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bttPais As Button
    Friend WithEvents bttCidade As Button
    Friend WithEvents LstPaises As ListBox
    Friend WithEvents LstCidades As ListBox
End Class
