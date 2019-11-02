Public Class Form1
    Dim vector(6), numero As Integer

    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click
        LbPar.ResetText()
        LbImpar.ResetText()
        For ctd = 0 To 5
            If vector(ctd) Mod 2 = 0 Then
                LbPar.Text = Val(LbPar.Text) + 1
            Else
                LbImpar.Text = Val(LbImpar.Text) + 1

            End If
        Next
    End Sub

    Private Sub bttPreencher_Click(sender As Object, e As EventArgs) Handles bttPreencher.Click
        For ctd = 0 To 5
            numero = Val(InputBox(" Indique 0" & ctd + 1, "valor"))
            vector(ctd) = numero

        Next
    End Sub

End Class
