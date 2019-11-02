Public Class Form1

    Dim candidatos, SomaIdades, ctdhomens As Integer



    Private Sub bttOK_Click(sender As Object, e As EventArgs) Handles bttOK.Click
        Grelha.Rows.Add()

        Grelha.Item(0, candidatos).Value = candidatos + 1

        Grelha.Item(1, candidatos).Value = NudIdade.Value
        If RadioMasculino.Checked = True Then
            Grelha.Item(2, candidatos).Value = "Masc."
            LbNMasculino.Text = Val(LbNMasculino.Text) + 1
            If RadioSim.Checked = True Then
                SomaIdades += NudIdade.Value
                ctdhomens += 1
                LbMedia.Text = SomaIdades / ctdhomens

            End If
        Else
            Grelha.Item(2, candidatos).Value = "Fem"
            LbNFeminino.Text = Val(LbNFeminino.Text) + 1
            If NudIdade.Value > 35 Then
                LbMulheres35.Text = Val(LbMulheres35.Text) + 1
            End If

        End If
        If RadioSim.Checked = True Then
            Grelha.Item(3, candidatos).Value = "Sim"
        Else
            Grelha.Item(3, candidatos).Value = "Não"

        End If

        candidatos += 1













    End Sub


End Class