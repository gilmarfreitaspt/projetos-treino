Public Class Form1
    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click
        LbResultado.Text = factorial(NudNumero.Value)



    End Sub
    Function factorial(ByVal numero As Double) As Double
        Dim resultado As Double
        Dim linha As Integer

        Grelha.Rows.Clear()
        resultado = numero
        If numero <> 0 Then

            For ctd = numero - 1 To 1 Step -1
                Grelha.Rows.Add()
                Grelha.Item(0, linha).Value = resultado & "x" & ctd & "=" & resultado * ctd
                resultado = resultado * ctd
                linha += 1
            Next ctd
        Else
            resultado = 1



        End If
        factorial = resultado
    End Function
End Class
