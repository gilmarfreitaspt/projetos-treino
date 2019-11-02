Public Class Form1
    Private Sub bttIniciar_Click(sender As Object, e As EventArgs) Handles bttIniciar.Click
        Dim Idade, pessoas, MaisVelha, MaisNova, SomaIdades As Integer
        Do
            Idade = Val(InputBox("Indique a Idade", "Introdução de Valores"))
            If Idade > 0 Then

                pessoas += 1

                If pessoas = 1 Then
                    MaisVelha = Idade
                    MaisNova = Idade
                Else
                    If Idade > MaisVelha Then
                        MaisVelha = Idade

                    End If
                    If Idade < MaisNova Then
                        MaisNova = Idade

                    End If

                End If
                SomaIdades += Idade
            End If
        Loop Until Idade = 0
        LbNpessoas.Text = pessoas
        LbMaisVelha.Text = MaisVelha
        LbMaisNova.Text = MaisNova
        LbMedia.Text = SomaIdades / (pessoas - 1)

    End Sub
End Class
