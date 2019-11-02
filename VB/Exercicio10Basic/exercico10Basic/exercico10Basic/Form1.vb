Public Class Form1
    Dim Pessoas As Integer
    Dim idade As Integer
    Private Sub BttOK_Click(sender As Object, e As EventArgs) Handles BttOK.Click
        idade = Val(TxtIdade.Text)
        Select Case idade
            Case 1 To 15
                LbPessoas115.Text = Val(LbPessoas115.Text) + 1
            Case 16 To 30
                LbPessoas1630.Text = Val(LbPessoas1630.Text) + 1
            Case 31 To 45
                LbPessoas3145.Text = Val(LbPessoas3145.Text) + 1
            Case 46 To 60
                LbPessoas4660.Text = Val(LbPessoas4660.Text) + 1
            Case >= 61
                LbPessoas61.Text = Val(LbPessoas61.Text) + 1
            Case Else
                MessageBox.Show("Idade Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

        End Select
        Pessoas += 1
        LbTotal.Text = Pessoas
        LbP115.Text = Format(Val(LbPessoas115.Text) / Pessoas, "0.00%")
        LbP1630.Text = Format(Val(LbPessoas1630.Text) / Pessoas, "0.00%")
        LbP3145.Text = Format(Val(LbPessoas3145.Text) / Pessoas, "0.00%")
        LbP4660.Text = Format(Val(LbPessoas4660.Text) / Pessoas, "0.00%")
        LbP61.Text = Format(Val(LbPessoas61.Text) / Pessoas, "0.00%")

        TxtIdade.ResetText()
        TxtIdade.Select()



    End Sub

    Private Sub BttSair_Click(sender As Object, e As EventArgs) Handles BttSair.Click
        Dim resposta As DialogResult
        resposta = MessageBox.Show("Deseja Sair da Aplicação", "Confirmação da Saida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resposta = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class
