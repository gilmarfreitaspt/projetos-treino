
Option Explicit Off
Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtMensagem.TextChanged
        If TxtMensagem.Text <> "" Then
            bttEncripitar.Enabled = True
        Else
            bttEncripitar.Enabled = False
        End If
        bttDesencripitar.Enabled = False
    End Sub

    Private Sub bttEncripitar_Click(sender As Object, e As EventArgs) Handles bttEncripitar.Click


        TxtMensagem.Text = codificar(TxtMensagem.Text, 0)

        bttEncripitar.Enabled = False
        bttDesencripitar.Enabled = True

    End Sub

    Private Sub bttDesencripitar_Click(sender As Object, e As EventArgs) Handles bttDesencripitar.Click
        TxtMensagem.Text = codificar(TxtMensagem.Text, 1)
        bttEncripitar.Enabled = True
        bttDesencripitar.Enabled = False
    End Sub
    Function codificar(ByVal texto As String, ByVal metodo As Integer) As String
        Dim tamanhoTxt As Integer
        Dim textoEncr As String

        tamanhoTxt = Len(texto)
        If tamanhoTxt > 0 Then
            For ctd = 0 To tamanhoTxt - 1
                codigocaracter = Asc(texto(ctd))
                Select Case metodo
                    Case 0
                        If ctd Mod 2 = 0 Then
                            codigocaracter -= 4

                        Else
                            codigocaracter += 3
                        End If
                    Case 1
                        If ctd Mod 2 = 0 Then
                            codigocaracter += 4
                        Else
                            codigocaracter -= 3
                        End If
                End Select
                textoEncr = textoEncr & Chr(codigocaracter)

            Next ctd
        End If
        Return textoEncr
    End Function
End Class
