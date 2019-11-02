Option Explicit Off
Public Class Form1
    Dim valor, resto As Double



    Private Sub TxtValor_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged
        valor = Val(TxtValor.Text)
        recalcular()
        LbResto.Text = resto

    End Sub

    Private Sub Chk500_CheckedChanged(sender As Object, e As EventArgs) Handles Chk500.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk200_CheckedChanged(sender As Object, e As EventArgs) Handles Chk200.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk100_CheckedChanged(sender As Object, e As EventArgs) Handles Chk100.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk50_CheckedChanged(sender As Object, e As EventArgs) Handles Chk50.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk20_CheckedChanged(sender As Object, e As EventArgs) Handles Chk20.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk10_CheckedChanged(sender As Object, e As EventArgs) Handles Chk10.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk5_CheckedChanged(sender As Object, e As EventArgs) Handles Chk5.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Private Sub Chk1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk1.CheckedChanged
        recalcular()
        LbResto.Text = resto
    End Sub

    Public Sub limpavalores()
        Lb500.ResetText()
        Lb200.ResetText()
        Lb100.ResetText()
        Lb50.ResetText()
        Lb20.ResetText()
        Lb10.ResetText()
        Lb5.ResetText()
        Lb2.ResetText()
        Lb1.ResetText()
        LbResto.ResetText()

    End Sub
    Public Sub recalcular()


        valor = Val(TxtValor.Text)
        limpavalores()
        If Chk500.Checked Then
            Lb500.Text = trocar(valor, 500, resto)
        End If
        If Chk200.Checked Then
            Lb200.Text = trocar(valor, 200, resto)
        End If
        If Chk100.Checked Then
            Lb100.Text = trocar(valor, 100, resto)
        End If
        If Chk50.Checked Then
            Lb50.Text = trocar(valor, 50, resto)
        End If
        If Chk20.Checked Then
            Lb20.Text = trocar(valor, 20, resto)
        End If
        If Chk10.Checked Then
            Lb10.Text = trocar(valor, 10, resto)
        End If
        If Chk5.Checked Then
            Lb5.Text = trocar(valor, 5, resto)
        End If
        If Chk2.Checked Then
            Lb2.Text = trocar(valor, 2, resto)
        End If
        If Chk1.Checked Then
            Lb1.Text = trocar(valor, 1, resto)
        End If


    End Sub

    Private Sub bttReiniciar_Click(sender As Object, e As EventArgs) Handles bttReiniciar.Click
        limpavalores()
        TxtValor.ResetText()
        TxtValor.Select()
        valor = 0

        Chk500.Checked = False
        Chk200.Checked = False
        Chk100.Checked = False
        Chk50.Checked = False
        Chk20.Checked = False
        Chk10.Checked = False
        Chk5.Checked = False
        Chk2.Checked = False
        Chk1.Checked = False
        LbResto.ResetText()
    End Sub

    Private Sub bttSair_Click(sender As Object, e As EventArgs) Handles bttSair.Click
        Dim resposta As DialogResult

        mensagem = "Deseja sair da Aplicação"
        titulo = "Trocar Valores"
        botões = MessageBoxButtons.YesNo
        icone = MessageBoxIcon.Question

        resposta = MessageBox.Show(mensagem, titulo, botões, icone)
        If resposta = Windows.Forms.DialogResult.Yes Then
            End

        End If
    End Sub

    Function trocar(ByRef valor, ByVal parcela, ByRef resto) As Integer
        Do While valor >= parcela
            valor -= parcela
            trocar += 1

        Loop
        resto = valor
    End Function


End Class
