Public Class Form1
    Private mensagem As String
    Private titulo As String
    Private botões As MessageBoxButtons
    Private icone As MessageBoxIcon
    Public Property DataAndTime As Object



    Private Sub bttEntrada_Click(sender As Object, e As EventArgs) Handles bttEntrada.Click
        LbDataEntrada.Text = DateAndTime.Today
        LbHoraEntrada.Text = DateAndTime.TimeOfDay

        bttSaida.Enabled = True

        LbDataSaida.ResetText()
        LbHoraSaida.ResetText()

    End Sub

    Private Sub bttSaida_Click(sender As Object, e As EventArgs) Handles bttSaida.Click
        Dim duracao As Double
        If TxtValor.Text <> "" Then
            LbDataSaida.Text = DateAndTime.Today
            LbHoraSaida.Text = DateAndTime.TimeOfDay

            duracao = Tempo(LbDataEntrada.Text, LbDataSaida.Text, LbHoraEntrada.Text, LbHoraSaida.Text)
            ' LbPagar.Text = Math.Round(duracao / 1, 0) + 1

            If duracao < 0.5 Then
                LbPagar.Text = TxtValor.Text
            Else
                LbPagar.Text = (Math.Round(duracao / 1, 0) + 1) * CDbl(TxtValor.Text)
            End If

        Else
                mensagem = " Valor não atribuido"
            titulo = "Estacionamento"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Stop



        End If
    End Sub

    Function Tempo(ByVal dataEntrada As Date, ByVal dataSaida As Date, ByVal HoraEntrada As Date, ByVal HoraSaida As Date) As Double
        Dim minutos, Dias, minutosSaida, minutosEntrada As Double
        If dataEntrada = dataSaida Then
            minutos = DateDiff(DateInterval.Minute, HoraEntrada, HoraSaida)

        Else
            Dias = DateDiff(DateInterval.Minute, HoraEntrada, HoraSaida)

            minutosEntrada = 1440 - (Hour(HoraEntrada) * 60 + Minute(HoraEntrada))

            minutosSaida = Hour(HoraSaida) * 60 + Minute(HoraSaida)

            minutos = (Dias - 1440) + minutosEntrada + minutosSaida
        End If
        Tempo = minutos
    End Function




End Class
