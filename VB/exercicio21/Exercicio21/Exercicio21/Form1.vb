Option Explicit Off
Public Class Form1
    Dim vector1(10), vector2(10), vector3(10) As Integer

    Private Sub bttOk2_Click(sender As Object, e As EventArgs) Handles bttOk2.Click
        If posicao2 <= 9 And IsNumeric(TxtVector2.Text) = True Then
            vector2(posicao2) = Val(TxtVector2.Text)
            posicao2 += 1
            LstVector2.Items.Clear()
            For ctd = 0 To posicao2 - 1
                LstVector2.Items.Add(vector2(ctd))
            Next
            TxtVector2.ResetText()
            TxtVector2.Select()

        End If
    End Sub

    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click

        If posicao1 = 10 And posicao2 = 10 Then
            LstVector3.Items.Clear()
            For ctd = 0 To 9
                vector3(ctd) = vector1(ctd) + vector2(ctd)
                LstVector3.Items.Add(vector3(ctd))

            Next
        Else
            mensagem = "Os Vectores não estão totalmente preenchidos"
            Titulo = "Somar Vectores"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Information
            MessageBox.Show(mensagem, Titulo, botões, icone)
        End If
    End Sub

    Dim posicao1, posicao2 As Integer

    Private Sub bttOk1_Click(sender As Object, e As EventArgs) Handles bttOk1.Click

        If posicao1 <= 9 And IsNumeric(TxtVector1.Text) = True Then
            vector1(posicao1) = Val(TxtVector1.Text)
            posicao1 += 1
            LstVector1.Items.Clear()
            For ctd = 0 To posicao1 - 1
                LstVector1.Items.Add(vector1(ctd))
            Next
            TxtVector1.ResetText()
            TxtVector1.Select()

        End If
    End Sub

End Class
