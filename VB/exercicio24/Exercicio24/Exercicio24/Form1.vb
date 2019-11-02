Public Class Form1
    Dim Matriz1(2, 2), Matriz2(2, 2), MatrizSoma(2, 2) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grelha1.Rows.Add(2)
        Grelha2.Rows.Add(2)
        GrelhaSoma.Rows.Add(2)
    End Sub

    Private Sub bttOk2_Click(sender As Object, e As EventArgs) Handles bttOk2.Click
        If IsNumeric(TxtValor2.Text) Then
            Matriz2(Coluna2, Linha2) = TxtValor2.Text
            Grelha2(Coluna2, Linha2).Value = TxtValor2.Text
            Coluna2 += 1

            If Coluna2 > 1 Then
                Coluna2 = 0
                Linha2 += 1
                If Linha2 > 1 Then
                    bttOk2.Enabled = False
                    TxtValor2.ResetText()
                    Exit Sub
                End If
            End If

            TxtValor2.ResetText()
            TxtValor2.Select()
        End If
    End Sub

    Private Sub bttSoma_Click(sender As Object, e As EventArgs) Handles bttSoma.Click
        Dim ctdColuna, ctdLinha As Integer

        For ctdColuna = 0 To 1
            For ctdLinha = 0 To 1
                MatrizSoma(ctdColuna, ctdLinha) = Matriz1(ctdColuna, ctdLinha) + Matriz2(ctdColuna, ctdLinha)

                GrelhaSoma(ctdColuna, ctdLinha).Value = MatrizSoma(ctdColuna, ctdLinha)
            Next
        Next
    End Sub

    Dim Linha1, Linha2, Coluna1, Coluna2 As Integer
    Private Sub bttOk1_Click(sender As Object, e As EventArgs) Handles bttOk1.Click
        If IsNumeric(TxtValor1.Text) Then
            Matriz1(Coluna1, Linha1) = TxtValor1.Text
            Grelha1(Coluna1, Linha1).Value = TxtValor1.Text
            Coluna1 += 1

            If Coluna1 > 1 Then
                Coluna1 = 0
                Linha1 += 1
                If Linha1 > 1 Then
                    bttOk1.Enabled = False
                    TxtValor1.ResetText()
                    Exit Sub
                End If
            End If

            TxtValor1.ResetText()
            TxtValor1.Select()
        End If
    End Sub
End Class
