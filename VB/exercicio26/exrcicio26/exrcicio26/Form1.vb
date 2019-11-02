


Public Class Form1
    Dim temperaturas(11) As Double
    Dim meses As New List(Of String)
    Dim Texto As String
    Dim posicao As Integer
    Dim Mensagem As String
    Dim Titulo As String





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        For ctd = 0 To 11
            meses.Add(ComboMes.Items.Item(ctd))

        Next

    End Sub

    Private Sub bttInserir_Click(sender As Object, e As EventArgs) Handles bttInserir.Click
        If ComboMes.SelectedIndex <> -1 And IsNumeric(TxtTemp.Text) = True Then
            Texto = ComboMes.Text
            posicao = meses.IndexOf(Texto)
            temperaturas(posicao) = TxtTemp.Text
            ComboMes.Items.Remove(ComboMes.Text)

            ComboMes.Refresh()
            TxtTemp.ResetText()
            ComboMes.Select()

        Else
            Mensagem = "Valores Inválidos"
            Titulo = "Temperaturas Médias"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Error
            MessageBox.Show(Mensagem, Titulo, botoes, icone)

        End If
        If ComboMes.Items.Count = 0 Then
            bttInserir.Enabled = False
            TxtTemp.ResetText()
            TxtTemp.Enabled = False
            ComboMes.Enabled = False
        End If


    End Sub

    Private Sub bttApresentar_Click(sender As Object, e As EventArgs) Handles bttApresentar.Click

        Dim Maior, Menor, Soma As Double
        Dim mesMaior, mesMenor As Integer
        For posicao = 0 To 11
            If posicao = 0 Then
                Maior = temperaturas(posicao)
                Menor = temperaturas(posicao)
                mesMaior = posicao
                mesMenor = posicao
            Else
                If temperaturas(posicao) > Maior Then
                    Maior = temperaturas(posicao)
                    mesMaior = posicao
                End If
                If temperaturas(posicao) < Menor Then
                    Menor = temperaturas(posicao)
                    mesMenor = posicao
                End If



            End If

            Soma += temperaturas(posicao)

        Next
        LbMesAlta.Text = meses(mesMaior)
        LbMesBaixa.Text = meses(mesMenor)
        LbValorAlta.Text = Maior
        LbValorBaixa.Text = Menor
        LbMedia.Text = Soma / 12
    End Sub


End Class
