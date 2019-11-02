Public Class Form1
    Dim Aluno As Integer
    Dim mediaturma As Double
    Dim media As Double
    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click
        Dim media As Double


        Grelha.Rows.Add()

        Grelha.Item(0, Aluno).Value = TxtNumero.Text
        Grelha.Item(1, Aluno).Value = ComboLab.Text
        Grelha.Item(2, Aluno).Value = ComboProj.Text
        Grelha.Item(3, Aluno).Value = ComboAval.Text

        media = (Val(ComboLab.Text) + Val(ComboProj.Text) +
            Val(ComboAval.Text)) / 3

        Grelha.Item(4, Aluno).Value = media
        If media > 10 Then
            Grelha.Item(5, Aluno).Value = "Aprovado"
        Else
            Grelha.Item(5, Aluno).Value = "Reprovado"
        End If
        Aluno += 1
        LbAlunos.Text = media

        mediaturma += media
        LbMediaTurma.Text = mediaturma / Aluno

        TxtNumero.ResetText()
        ComboLab.ResetText()
        ComboProj.ResetText()
        ComboAval.ResetText()

        TxtNumero.Focus()



    End Sub

    Private Sub Grelha_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grelha.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For ctd = 1 To 20
            ComboLab.Items.Add(ctd)
            ComboProj.Items.Add(ctd)
            ComboAval.Items.Add(ctd)
        Next
    End Sub

    Private Sub bttSair_Click(sender As Object, e As EventArgs) Handles BttSair.Click
        Dim resposta As DialogResult
        resposta = MessageBox.Show("Deseja sair da Aplicação",
        "Confirmação de Saida", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
        If resposta = Windows.Forms.DialogResult.Yes Then
            End

        End If
    End Sub
End Class
