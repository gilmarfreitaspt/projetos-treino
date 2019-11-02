Public Class Form1
    Dim linha As Integer
    Dim Valor1 As Integer
    Dim Valor2 As Integer
    Dim Valor3 As Integer
    Dim Valor4 As Integer
    Dim nivel As Integer
    Dim pontuacao As Integer
    Dim observacao As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreencherCombo(ComboEstatura)
        PreencherCombo(ComboDrible)
        PreencherCombo(ComboPasse)
        PreencherCombo(ComboRemate)
    End Sub
    Private Sub PreencherCombo(ByVal nome As Object)
        With nome
            .Items.Add("Insuficiente")
            .Items.Add("Suficiente")
            .Items.Add("Bom")
            .Items.Add("Muito Bom")
            .Items.Add("Excelente")
        End With
    End Sub
    Private Sub Escrevegrelha()

        Grelha.Rows.Add()
        Grelha.Item(0, linha).Value = TxtNome.Text
        Grelha.Item(1, linha).Value = ComboEstatura.Text
        Grelha.Item(2, linha).Value = ComboDrible.Text
        Grelha.Item(3, linha).Value = ComboPasse.Text
        Grelha.Item(4, linha).Value = ComboRemate.Text
        Grelha.Item(5, linha).Value = observacao
        linha += 1
    End Sub
    Function nota(ByVal Valor1 As Integer, ByVal Valor2 As Integer, ByVal Valor3 As Integer, ByVal Valor4 As Integer) As String
        Dim nivel As String = ""
        pontuacao = Valor1 + Valor2 * 3 + Valor3 * 3 + Valor4 * 3
        Select Case pontuacao
            Case 0 To 4
                nivel = "nivel 0"
            Case 5 To 10
                nivel = "Nivel 1"
            Case 11 To 15
                nivel = "Nivel 2"
            Case 16 To 20
                nivel = "nivel 3"
            Case 21 To 25
                nivel = "Nivel 4"
            Case Is > 26
                nivel = "Nivel 5"

        End Select
        Return nivel
    End Function

    Public Sub limpardados()
        TxtNome.ResetText()
        ComboEstatura.SelectedIndex = -1
        ComboPasse.SelectedIndex = -1
        ComboDrible.SelectedIndex = -1
        ComboRemate.SelectedIndex = -1
        TxtNome.Select()
    End Sub

    Private Sub bttOk_Click(sender As Object, e As EventArgs) Handles bttOk.Click


        If ComboDrible.SelectedIndex = -1 Or
        ComboEstatura.SelectedIndex = -1 Or
        ComboPasse.SelectedIndex = -1 Or
        ComboRemate.SelectedIndex = -1 Or
        TxtNome.Text = "" Then

            MessageBox.Show("Um ou Varios Valores não atribuidos", "Observação", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Valor1 = ComboEstatura.SelectedIndex
            Valor2 = ComboEstatura.SelectedIndex
            Valor3 = ComboEstatura.SelectedIndex
            Valor4 = ComboEstatura.SelectedIndex
            observacao = nota(Valor1, Valor2, Valor3, Valor4)
            Escrevegrelha()
            limpardados()
        End If
    End Sub
End Class
