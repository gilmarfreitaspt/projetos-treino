Public Class Form1
    Dim coluna, linha As Integer
    Dim matriz(3, 3) As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grelha.Rows.Add(3)
    End Sub

    Private Sub bttInserir_Click(sender As Object, e As EventArgs) Handles bttInserir.Click
        If IsNumeric(TxtValor.Text) = True Then
            Grelha(coluna, linha).Value = TxtValor.Text
            matriz(coluna, linha) = TxtValor.Text
            coluna += 1
            If coluna > 2 Then
                coluna = 0
                linha += 1
                If linha > 2 Then
                    bttInserir.Enabled = False
                    limparseleccao()
                    TxtValor.ResetText()
                    Exit Sub

                End If
            End If
            TxtValor.ResetText()
            TxtValor.Select()

            limparseleccao()
            Grelha(coluna, linha).Selected = True
        End If
    End Sub
    Public Sub limparseleccao()
        For ctdcoluna = 0 To 2
            For ctdlinha = 0 To 2
                Grelha(ctdcoluna, ctdlinha).Selected = False
            Next
        Next
    End Sub

    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click
        Dim soma As Double
        For ctdcoluna = 0 To 2
            For ctdlinha = 0 To 2
                If ctdcoluna = ctdlinha Then
                    soma += matriz(ctdcoluna, ctdlinha)

                End If

            Next
        Next
        LbSoma.Text = soma
    End Sub
End Class
