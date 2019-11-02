Public Class Form1
    Structure registro
        Dim nome As String
        Dim Local As String
        Dim Idade As Integer
    End Structure
    Dim pessoas(10) As registro
    Dim ctdPessoas As Integer
    Private Sub bttInserir_Click(sender As Object, e As EventArgs) Handles bttInserir.Click
        pessoas(ctdPessoas).nome = TxtNome.Text
        pessoas(ctdPessoas).Local = Combolocal.Text
        pessoas(ctdPessoas).Idade = NudIdade.Value

        Grelha.Rows.Add()
        Grelha(0, ctdPessoas).Value = pessoas(ctdPessoas).nome
        Grelha(1, ctdPessoas).Value = pessoas(ctdPessoas).Local
        Grelha(2, ctdPessoas).Value = pessoas(ctdPessoas).Idade
        ctdPessoas += 1
        If ctdPessoas > 9 Then
            bttInserir.Enabled = False
            TxtNome.Enabled = False
            Combolocal.Enabled = False
            NudIdade.Enabled = False
            bttOrdenar.Enabled = True
        End If
        TxtNome.ResetText()
        Combolocal.SelectedIndex = -1
        NudIdade.Value = 18
        TxtNome.Select()






    End Sub

    Private Sub bttOrdenar_Click(sender As Object, e As EventArgs) Handles bttOrdenar.Click
        Dim NomeTemp, LocalTemp As String
        Dim IdadeTemp, tamanho As Integer
        tamanho = Grelha.Rows.Count - 1


        Grelha.Rows.Clear()
        For posicao = 0 To tamanho

            For posicao2 = posicao + 1 To tamanho



                If pessoas(posicao).Idade > pessoas(posicao2).Idade Then
                    NomeTemp = pessoas(posicao).nome
                    LocalTemp = pessoas(posicao).Local
                    IdadeTemp = pessoas(posicao).Idade

                    pessoas(posicao).nome = pessoas(posicao2).nome
                    pessoas(posicao).Local = pessoas(posicao2).Local
                    pessoas(posicao).Idade = pessoas(posicao2).Idade

                    pessoas(posicao2).nome = NomeTemp
                    pessoas(posicao2).Local = LocalTemp
                    pessoas(posicao2).Idade = IdadeTemp

                End If

            Next

            Grelha.Rows.Add()

            Grelha(0, posicao).Value = pessoas(posicao).nome
            Grelha(1, posicao).Value = pessoas(posicao).Local
            Grelha(2, posicao).Value = pessoas(posicao).Idade

        Next
    End Sub
End Class
