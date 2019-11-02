Public Class Form1
    Dim Matriz(4, 4) As Double
    Dim SomaVendedor, TotalVendedor As Double
    Dim Coluna As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Grelha.Rows.Add(6)
        For ctd = 1 To 5
            Grelha(0, ctd - 1).Value = "Vendedor" & ctd
            ComboVendedor.Items.Add(ctd)
            If ctd <= 4 Then
                ComboSemana.Items.Add(ctd)
            End If
            Grelha(0, 5).Value = "Total"
        Next

    End Sub

    Private Sub BttInserir_Click(sender As Object, e As EventArgs) Handles bttInserir.Click
        Dim Linha As Integer
        Dim mensagem, titulo, botoes, icone

        If ComboSemana.SelectedIndex <> -1 And
                ComboVendedor.SelectedIndex <> -1 And
                IsNumeric(TxtValor.Text) = True Then
            Coluna = ComboSemana.SelectedIndex
            Linha = ComboVendedor.SelectedIndex

            Matriz(Coluna, Linha) = TxtValor.Text
            Grelha(Coluna + 1, Linha).Value = Matriz(Coluna, Linha)

            ComboSemana.SelectedIndex = -1
            ComboVendedor.SelectedIndex = -1
            TxtValor.ResetText()
            ComboSemana.Select()
        Else
            mensagem = " Os Valores Não Estão todos Atribuidos"
            titulo = "Registro de Vendas"
            botoes = MessageBoxButtons.OK
            icone = MessageBoxIcon.Information
            MessageBox.Show(mensagem, titulo, botoes, icone)

        End If
    End Sub

    Private Sub BttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click
        Dim SomaSemana, ctdLinha As Integer
        Dim TotalVendas As Double
        For ctdColuna = 0 To 3
            SomaSemana = 0
            For ctdLinha = 0 To 4
                SomaSemana += Matriz(ctdColuna, ctdLinha)

            Next
            Grelha(ctdColuna + 1, 5).Value = SomaSemana

        Next
        For ctdLinha = 0 To 4
            SomaVendedor = 0
            For ctdColuna = 0 To 3
                SomaVendedor += Matriz(ctdColuna, ctdLinha)
            Next
            TotalVendas += SomaVendedor
            Grelha(5, ctdLinha).Value = SomaVendedor

        Next
        Grelha(5, 5).Value = TotalVendas

    End Sub
End Class
