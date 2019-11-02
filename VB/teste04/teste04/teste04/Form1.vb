Public Class Form1
    Private Sub BttLancar_Click(sender As Object, e As EventArgs) Handles bttLancar.Click
        If RadioRtp1.Checked = True Then
            If RadioMasculino.Checked = True Then
                LbRtp1Masc.Text = Val(LbRtp1Masc.Text) + 1
            Else
                LbRtp1Fem.Text = Val(LbRtp1Fem.Text) + 1
            End If

            If Radio1430.Checked = True Then
                LbRtp11430.Text = Val(LbRtp11430.Text) + 1
            Else
                If Radio3145.Checked = True Then
                    LbRtp13145.Text = Val(LbRtp13145.Text) + 1
                Else
                    LbRtp145.Text = Val(LbRtp145.Text) + 1
                End If
            End If
        End If
        If RadioRtp2.Checked = True Then
            If RadioMasculino.Checked = True Then
                LbRtp2Masc.Text = Val(LbRtp2Masc.Text) + 1
            Else
                LbRtp2Fem.Text = Val(LbRtp2Fem.Text) + 1
            End If

            If Radio1430.Checked = True Then
                LbRtp21430.Text = Val(LbRtp21430.Text) + 1
            Else
                If Radio3145.Checked = True Then
                    LbRtp23145.Text = Val(LbRtp23145.Text) + 1
                Else
                    LbRtp245.Text = Val(LbRtp245.Text) + 1
                End If
            End If
        End If
        If RadioSic.Checked = True Then
            If RadioMasculino.Checked = True Then
                LbSicMasc.Text = Val(LbSicMasc.Text) + 1
            Else
                LbSicFem.Text = Val(LbSicFem.Text) + 1
            End If

            If Radio1430.Checked = True Then
                LbSic1430.Text = Val(LbSic1430.Text) + 1
            Else
                If Radio3145.Checked = True Then
                    LbSic3145.Text = Val(LbSic3145.Text) + 1
                Else
                    LbSic45.Text = Val(LbSic45.Text) + 1
                End If
            End If
        End If
        If RadioTvi.Checked = True Then
            If RadioMasculino.Checked = True Then
                LbTviMasc.Text = Val(LbTviMasc.Text) + 1
            Else
                LbTviFem.Text = Val(LbTviFem.Text) + 1
            End If

            If Radio1430.Checked = True Then
                LbTvi1430.Text = Val(LbTvi1430.Text) + 1
            Else
                If Radio3145.Checked = True Then
                    LbTvi3145.Text = Val(LbTvi3145.Text) + 1
                Else
                    LbTvi45.Text = Val(LbTvi45.Text) + 1
                End If
            End If
        End If
    End Sub

End Class
