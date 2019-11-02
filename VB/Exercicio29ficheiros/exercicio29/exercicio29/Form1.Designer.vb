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
        Me.bttnovo = New System.Windows.Forms.Button()
        Me.bttActualizar = New System.Windows.Forms.Button()
        Me.bttCancelar = New System.Windows.Forms.Button()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.LstNome = New System.Windows.Forms.ListBox()
        Me.ComboCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtPreco = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Preço"
        '
        'bttnovo
        '
        Me.bttnovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttnovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnovo.Location = New System.Drawing.Point(66, 313)
        Me.bttnovo.Name = "bttnovo"
        Me.bttnovo.Size = New System.Drawing.Size(75, 23)
        Me.bttnovo.TabIndex = 4
        Me.bttnovo.Text = "Novo"
        Me.bttnovo.UseVisualStyleBackColor = False
        '
        'bttActualizar
        '
        Me.bttActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttActualizar.Location = New System.Drawing.Point(202, 313)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(86, 23)
        Me.bttActualizar.TabIndex = 5
        Me.bttActualizar.Text = "Actualizar"
        Me.bttActualizar.UseVisualStyleBackColor = False
        '
        'bttCancelar
        '
        Me.bttCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCancelar.Location = New System.Drawing.Point(343, 313)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bttCancelar.TabIndex = 6
        Me.bttCancelar.Text = "Cancelar"
        Me.bttCancelar.UseVisualStyleBackColor = False
        '
        'bttSair
        '
        Me.bttSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSair.Location = New System.Drawing.Point(465, 313)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(117, 23)
        Me.bttSair.TabIndex = 7
        Me.bttSair.Text = "Sair e Guardar"
        Me.bttSair.UseVisualStyleBackColor = False
        '
        'LstNome
        '
        Me.LstNome.FormattingEnabled = True
        Me.LstNome.Location = New System.Drawing.Point(565, 64)
        Me.LstNome.Name = "LstNome"
        Me.LstNome.Size = New System.Drawing.Size(155, 225)
        Me.LstNome.TabIndex = 8
        '
        'ComboCategoria
        '
        Me.ComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCategoria.FormattingEnabled = True
        Me.ComboCategoria.Items.AddRange(New Object() {"Acessórios", "Computadores", "Imagem", "Impressão", "Software", "Tablets"})
        Me.ComboCategoria.Location = New System.Drawing.Point(202, 187)
        Me.ComboCategoria.Name = "ComboCategoria"
        Me.ComboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.ComboCategoria.Sorted = True
        Me.ComboCategoria.TabIndex = 9
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(202, 62)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 10
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(202, 128)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescricao.TabIndex = 11
        '
        'TxtPreco
        '
        Me.TxtPreco.Location = New System.Drawing.Point(202, 243)
        Me.TxtPreco.Name = "TxtPreco"
        Me.TxtPreco.Size = New System.Drawing.Size(100, 20)
        Me.TxtPreco.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtPreco)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.ComboCategoria)
        Me.Controls.Add(Me.LstNome)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttActualizar)
        Me.Controls.Add(Me.bttnovo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Produtos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bttnovo As Button
    Friend WithEvents bttActualizar As Button
    Friend WithEvents bttCancelar As Button
    Friend WithEvents bttSair As Button
    Friend WithEvents LstNome As ListBox
    Friend WithEvents ComboCategoria As ComboBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents TxtPreco As TextBox
End Class
