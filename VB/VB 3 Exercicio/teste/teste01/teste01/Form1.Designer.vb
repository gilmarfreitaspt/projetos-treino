<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eleicao
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
        Me.lb1 = New System.Windows.Forms.Label()
        Me.bttCandidatoA = New System.Windows.Forms.Button()
        Me.bttCandidatoB = New System.Windows.Forms.Button()
        Me.bttCandidatoC = New System.Windows.Forms.Button()
        Me.bttCandidatoD = New System.Windows.Forms.Button()
        Me.bttTerminar = New System.Windows.Forms.Button()
        Me.lbVotosA = New System.Windows.Forms.Label()
        Me.lbVotosB = New System.Windows.Forms.Label()
        Me.lbVotosC = New System.Windows.Forms.Label()
        Me.lbVotosD = New System.Windows.Forms.Label()
        Me.lbPVotosA = New System.Windows.Forms.Label()
        Me.lbPVotosB = New System.Windows.Forms.Label()
        Me.lbPVotosC = New System.Windows.Forms.Label()
        Me.lbPVotosD = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.ForestGreen
        Me.lb1.Location = New System.Drawing.Point(80, 37)
        Me.lb1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(425, 23)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "Clique no botão correspondente ao seu voto"
        '
        'bttCandidatoA
        '
        Me.bttCandidatoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCandidatoA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bttCandidatoA.Location = New System.Drawing.Point(12, 111)
        Me.bttCandidatoA.Margin = New System.Windows.Forms.Padding(4)
        Me.bttCandidatoA.Name = "bttCandidatoA"
        Me.bttCandidatoA.Size = New System.Drawing.Size(115, 37)
        Me.bttCandidatoA.TabIndex = 1
        Me.bttCandidatoA.Text = "Candidato A"
        Me.bttCandidatoA.UseVisualStyleBackColor = True
        '
        'bttCandidatoB
        '
        Me.bttCandidatoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCandidatoB.Location = New System.Drawing.Point(142, 111)
        Me.bttCandidatoB.Margin = New System.Windows.Forms.Padding(4)
        Me.bttCandidatoB.Name = "bttCandidatoB"
        Me.bttCandidatoB.Size = New System.Drawing.Size(118, 37)
        Me.bttCandidatoB.TabIndex = 2
        Me.bttCandidatoB.Text = "Candidato B"
        Me.bttCandidatoB.UseVisualStyleBackColor = True
        '
        'bttCandidatoC
        '
        Me.bttCandidatoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCandidatoC.Location = New System.Drawing.Point(279, 111)
        Me.bttCandidatoC.Margin = New System.Windows.Forms.Padding(4)
        Me.bttCandidatoC.Name = "bttCandidatoC"
        Me.bttCandidatoC.Size = New System.Drawing.Size(122, 37)
        Me.bttCandidatoC.TabIndex = 3
        Me.bttCandidatoC.Text = "Candidato C"
        Me.bttCandidatoC.UseVisualStyleBackColor = True
        '
        'bttCandidatoD
        '
        Me.bttCandidatoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCandidatoD.Location = New System.Drawing.Point(418, 111)
        Me.bttCandidatoD.Margin = New System.Windows.Forms.Padding(4)
        Me.bttCandidatoD.Name = "bttCandidatoD"
        Me.bttCandidatoD.Size = New System.Drawing.Size(114, 37)
        Me.bttCandidatoD.TabIndex = 4
        Me.bttCandidatoD.Text = "Candidato D"
        Me.bttCandidatoD.UseVisualStyleBackColor = True
        '
        'bttTerminar
        '
        Me.bttTerminar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttTerminar.ForeColor = System.Drawing.Color.DarkBlue
        Me.bttTerminar.Location = New System.Drawing.Point(327, 211)
        Me.bttTerminar.Margin = New System.Windows.Forms.Padding(4)
        Me.bttTerminar.Name = "bttTerminar"
        Me.bttTerminar.Size = New System.Drawing.Size(169, 47)
        Me.bttTerminar.TabIndex = 5
        Me.bttTerminar.Text = "Terminar a Eleição"
        Me.bttTerminar.UseVisualStyleBackColor = True
        '
        'lbVotosA
        '
        Me.lbVotosA.BackColor = System.Drawing.Color.Ivory
        Me.lbVotosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVotosA.Location = New System.Drawing.Point(31, 302)
        Me.lbVotosA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbVotosA.Name = "lbVotosA"
        Me.lbVotosA.Size = New System.Drawing.Size(84, 26)
        Me.lbVotosA.TabIndex = 6
        '
        'lbVotosB
        '
        Me.lbVotosB.BackColor = System.Drawing.Color.Ivory
        Me.lbVotosB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVotosB.Location = New System.Drawing.Point(158, 302)
        Me.lbVotosB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbVotosB.Name = "lbVotosB"
        Me.lbVotosB.Size = New System.Drawing.Size(84, 23)
        Me.lbVotosB.TabIndex = 7
        '
        'lbVotosC
        '
        Me.lbVotosC.BackColor = System.Drawing.Color.Ivory
        Me.lbVotosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVotosC.Location = New System.Drawing.Point(284, 302)
        Me.lbVotosC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbVotosC.Name = "lbVotosC"
        Me.lbVotosC.Size = New System.Drawing.Size(84, 23)
        Me.lbVotosC.TabIndex = 8
        '
        'lbVotosD
        '
        Me.lbVotosD.BackColor = System.Drawing.Color.Ivory
        Me.lbVotosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVotosD.Location = New System.Drawing.Point(413, 302)
        Me.lbVotosD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbVotosD.Name = "lbVotosD"
        Me.lbVotosD.Size = New System.Drawing.Size(84, 23)
        Me.lbVotosD.TabIndex = 9
        '
        'lbPVotosA
        '
        Me.lbPVotosA.BackColor = System.Drawing.Color.Ivory
        Me.lbPVotosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPVotosA.Location = New System.Drawing.Point(31, 362)
        Me.lbPVotosA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPVotosA.Name = "lbPVotosA"
        Me.lbPVotosA.Size = New System.Drawing.Size(84, 23)
        Me.lbPVotosA.TabIndex = 10
        '
        'lbPVotosB
        '
        Me.lbPVotosB.BackColor = System.Drawing.Color.Ivory
        Me.lbPVotosB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPVotosB.Location = New System.Drawing.Point(158, 362)
        Me.lbPVotosB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPVotosB.Name = "lbPVotosB"
        Me.lbPVotosB.Size = New System.Drawing.Size(84, 23)
        Me.lbPVotosB.TabIndex = 11
        '
        'lbPVotosC
        '
        Me.lbPVotosC.BackColor = System.Drawing.Color.Ivory
        Me.lbPVotosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPVotosC.Location = New System.Drawing.Point(284, 362)
        Me.lbPVotosC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPVotosC.Name = "lbPVotosC"
        Me.lbPVotosC.Size = New System.Drawing.Size(84, 23)
        Me.lbPVotosC.TabIndex = 12
        '
        'lbPVotosD
        '
        Me.lbPVotosD.BackColor = System.Drawing.Color.Ivory
        Me.lbPVotosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPVotosD.Location = New System.Drawing.Point(413, 362)
        Me.lbPVotosD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPVotosD.Name = "lbPVotosD"
        Me.lbPVotosD.Size = New System.Drawing.Size(84, 23)
        Me.lbPVotosD.TabIndex = 13
        '
        'Eleicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(553, 417)
        Me.Controls.Add(Me.lbPVotosD)
        Me.Controls.Add(Me.lbPVotosC)
        Me.Controls.Add(Me.lbPVotosB)
        Me.Controls.Add(Me.lbPVotosA)
        Me.Controls.Add(Me.lbVotosD)
        Me.Controls.Add(Me.lbVotosC)
        Me.Controls.Add(Me.lbVotosB)
        Me.Controls.Add(Me.lbVotosA)
        Me.Controls.Add(Me.bttTerminar)
        Me.Controls.Add(Me.bttCandidatoD)
        Me.Controls.Add(Me.bttCandidatoC)
        Me.Controls.Add(Me.bttCandidatoB)
        Me.Controls.Add(Me.bttCandidatoA)
        Me.Controls.Add(Me.lb1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Eleicao"
        Me.Text = "Eleição"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1 As Label
    Friend WithEvents bttCandidatoA As Button
    Friend WithEvents bttCandidatoB As Button
    Friend WithEvents bttCandidatoC As Button
    Friend WithEvents bttCandidatoD As Button
    Friend WithEvents bttTerminar As Button
    Private WithEvents lbVotosA As Label
    Friend WithEvents lbVotosB As Label
    Friend WithEvents lbVotosC As Label
    Friend WithEvents lbVotosD As Label
    Friend WithEvents lbPVotosA As Label
    Friend WithEvents lbPVotosB As Label
    Friend WithEvents lbPVotosC As Label
    Friend WithEvents lbPVotosD As Label
End Class
