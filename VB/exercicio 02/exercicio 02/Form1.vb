Public Class Form1


    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click

        Dim ValorHora, Extras, Suplemento, Bruto, SS, IRS As Double
        Const PHoraExtra As Double = 1.5
        Const Valorfilho As Integer = 50
        Const TaxaIRS As Double = 0.16
        Const TaxaSS As Double = 0.11

        ValorHora = CDbl(txtVencimento.Text) / 160
        lbHora.Text = ValorHora

        Extras = CDbl(txtHoras.Text) * ValorHora * PHoraExtra
        lbExtra.Text = Extras

        Suplemento = CDbl(txtFilhos.Text) * Valorfilho
        lbSuplemento.Text = Suplemento

        Bruto = CDbl(txtVencimento.Text) + Extras + Suplemento
        IRS = Bruto * TaxaIRS
        SS = Bruto * TaxaSS

        lbIrs.Text = IRS
        lbSsocial.Text = SS
        lbReceber.Text = Bruto - IRS - SS

    End Sub

    Private Sub bttLimpar_Click(sender As Object, e As EventArgs) Handles bttLimpar.Click
        txtVencimento.ResetText()
        txtHoras.ResetText()
        txtFilhos.ResetText()

        lbHora.ResetText()
        lbExtra.ResetText()
        lbSuplemento.ResetText()
        lbIrs.ResetText()
        lbSsocial.ResetText()
        lbReceber.ResetText()
    End Sub
End Class