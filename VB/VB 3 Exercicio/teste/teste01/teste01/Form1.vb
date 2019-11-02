Public Class Eleicao

    Dim MaximoVotos, TotalDeVotos As Integer
    Dim CandidatoVencedor As String

    Private Sub BttCandidatoA_Click(sender As Object, e As EventArgs) Handles bttCandidatoA.Click


        TotalDeVotos = TotalDeVotos + 1

        lbVotosA.Text = Val(lbVotosA.Text) + 1
        If Val(lbVotosA.Text) > MaximoVotos Then
            MaximoVotos = Val(lbVotosA.Text)
            CandidatoVencedor = "Candidato A "
        End If
        lbPVotosA.Text = Format(Val(lbVotosA.Text) / TotalDeVotos, "0.00%")
        lbPVotosB.Text = Format(Val(lbVotosB.Text) / TotalDeVotos, "0.00%")
        lbPVotosC.Text = Format(Val(lbVotosC.Text) / TotalDeVotos, "0.00%")
        lbPVotosD.Text = Format(Val(lbVotosD.Text) / TotalDeVotos, "0.00%")
    End Sub

    Private Sub BttCandidatoB_Click(sender As Object, e As EventArgs) Handles bttCandidatoB.Click
        TotalDeVotos = TotalDeVotos + 1
        lbVotosB.Text = Val(lbVotosB.Text) + 1
        If Val(lbVotosB.Text) > MaximoVotos Then
            MaximoVotos = Val(lbVotosB.Text)
            CandidatoVencedor = "Candidato B "
        End If

        lbPVotosA.Text = Format(Val(lbVotosA.Text) / TotalDeVotos, "0.00%")
        lbPVotosB.Text = Format(Val(lbVotosB.Text) / TotalDeVotos, "0.00%")
        lbPVotosC.Text = Format(Val(lbVotosC.Text) / TotalDeVotos, "0.00%")
        lbPVotosD.Text = Format(Val(lbVotosD.Text) / TotalDeVotos, "0.00%")
    End Sub

    Private Sub BttCandidatoC_Click(sender As Object, e As EventArgs) Handles bttCandidatoC.Click
        TotalDeVotos = TotalDeVotos + 1
        lbVotosC.Text = Val(lbVotosC.Text) + 1
        If Val(lbVotosC.Text) > MaximoVotos Then
            MaximoVotos = Val(lbVotosC.Text)
            CandidatoVencedor = "Candidato C "
        End If

        lbPVotosA.Text = Format(Val(lbVotosA.Text) / TotalDeVotos, "0.00%")
        lbPVotosB.Text = Format(Val(lbVotosB.Text) / TotalDeVotos, "0.00%")
        lbPVotosC.Text = Format(Val(lbVotosC.Text) / TotalDeVotos, "0.00%")
        lbPVotosD.Text = Format(Val(lbVotosD.Text) / TotalDeVotos, "0.00%")
    End Sub



    Private Sub BttCandidatoD_Click(sender As Object, e As EventArgs) Handles bttCandidatoD.Click
        TotalDeVotos = TotalDeVotos + 1
        lbVotosD.Text = Val(lbVotosD.Text) + 1
        If Val(lbVotosD.Text) > MaximoVotos Then
            MaximoVotos = Val(lbVotosD.Text)
            CandidatoVencedor = "Candidato D "
        End If

        lbPVotosA.Text = Format(Val(lbVotosA.Text) / TotalDeVotos, "0.00%")
        lbPVotosB.Text = Format(Val(lbVotosB.Text) / TotalDeVotos, "0.00%")
        lbPVotosC.Text = Format(Val(lbVotosC.Text) / TotalDeVotos, "0.00%")
        lbPVotosD.Text = Format(Val(lbVotosD.Text) / TotalDeVotos, "0.00%")
    End Sub

    Private Sub Eleicoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''' Me.Height = 300

    End Sub

    Private Sub BttTerminar_Click(sender As Object, e As EventArgs) Handles bttTerminar.Click


        MessageBox.Show("O Vencedor foi o  " & CandidatoVencedor, " Vencedor",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.Height = 355

    End Sub






End Class
