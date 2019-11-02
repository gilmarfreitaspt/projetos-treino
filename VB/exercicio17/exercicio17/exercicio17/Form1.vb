Option Explicit Off
Public Class Form1
    Dim mensagem As String
    Dim titulo As String
    Dim numero As Integer
    Dim resto As Integer




    Private Sub bttCalcularBI_Click(sender As Object, e As EventArgs) Handles bttCalcularBI.Click
        Dim numero As String = MtxtBI.Text
        If Len(MtxtBI.Text) < 6 Then
            mensagem = "Número Incompleto"
            titulo = ("Digito de Controlo")
            Botao = MessageBoxButtons.OK
            icone = MessageBoxIcon.Error
            MessageBox.Show(mensagem, titulo, Botao, icone)

            MtxtContribuinte.Select()
        Else
            If Len(MtxtBI.Text) < 8 Then
                MtxtBI.Text = "0" & numero
            ElseIf Len(MtxtBI.Text) < 7 Then
                MtxtBI.Text = "00" & numero
            End If
            LbControloBI.Text = digitoC(MtxtBI.Text)
        End If
    End Sub

    Private Sub bttReiniciar_Click(sender As Object, e As EventArgs) Handles bttReiniciar.Click
        If TabDigitoControl.SelectedIndex = 0 Then
            MtxtBI.Text = ""
            LbControloBI.ResetText()
            MtxtBI.Select()
        Else
            MtxtContribuinte.Text = ""
            LbDigitocont.ResetText()
            LbContribuinte.ResetText()
            MtxtContribuinte.Select()
        End If
    End Sub
    Function digitoC(ByVal numero As String) As Integer
        Dim valor As String = numero
        Dim soma As Double = 0
        For ctd = 0 To 7
            soma += ((9 - ctd) * Val(valor(ctd)))

        Next
        resto = soma Mod 11
        If resto = 0 Or resto = 1 Then
            digitoC = 0
        Else
            digitoC = 11 - resto
        End If
    End Function

    Private Sub bttCalcularContr_Click(sender As Object, e As EventArgs) Handles bttCalcularContr.Click
        If Len(MtxtContribuinte.Text) <> 8 Then
            mensagem = "Número Incompleto"
            titulo = ("Digito de Controlo")
            Botao = MessageBoxButtons.OK
            icone = MessageBoxIcon.Error
            MessageBox.Show(mensagem, titulo, Botao, icone)
            MtxtContribuinte.Select()
        Else
            LbDigitocont.Text = digitoC(MtxtContribuinte.Text)
            LbContribuinte.Text = MtxtContribuinte.Text & LbDigitocont.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
