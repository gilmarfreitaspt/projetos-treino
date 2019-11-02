Public Class JOKER
    Dim vez As Boolean = False
    Dim Apostas As Integer
    Private Sub BttRodar_Click(sender As Object, e As EventArgs) Handles bttRodar.Click
        PictureBox1.Visible = False
        If nudApostas.Value > 0 Then
            LbJoker.ResetText()
            Relogio.Enabled = True
            bttRodar.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Relogio.Tick

        Apostas += 1
        Randomize()
        Lb1.Text = Int(5 * Rnd() + 1)
        Lb2.Text = Int(5 * Rnd() + 1)
        Lb3.Text = Int(5 * Rnd() + 1)
        If Lb1.Text = Lb2.Text And Lb1.Text = Lb3.Text Then
            LbJoker.Text = Val(LbJoker.Text) + 1
            vez = True

        End If
        If Apostas = nudApostas.Value Then
            Relogio.Enabled = False
            Apostas = 0
            bttRodar.Enabled = True
            If vez Then PictureBox1.visible = True
        End If
    End Sub

    Private Sub JOKER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
