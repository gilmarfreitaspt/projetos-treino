Public Class lbvalor
    Private Sub bttcalcular_Click(sender As Object, e As EventArgs) Handles bttcalcular.Click
        Dim consumo, valor As Double


        consumo = CDbl(txtlitros.Text) / CDbl(txtdistancia.Text) * 100
        lbconsumo.Text = consumo
        valor = CDbl(txtpreco.Text) * consumo
        Label1.Text = valor

    End Sub
End Class
