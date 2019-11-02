Public Class Form2
    Dim tiroCero, TiroErrado, tiro, pos, posFinal, x, y As Integer
    Public Lbl As New ArrayList()


    Dim horiz As Integer
    Dim vert As Integer
    Dim frota3(15, 12) As Integer
    Dim grelha3(180) As Integer




    Private Sub bttStart3_Click(sender As Object, e As EventArgs) Handles bttStart3.Click
        'horiz = 1
        'vert = 2

        Randomize()

        tiro = Int((180 * Rnd()) + 1)
        x = tiro / 15 - 1
        y = tiro - (x * 15) - 13
        pos = y - (15 - y)
        posFinal = x * 15


        Randomize()
        pos = Int((2 * Rnd()) + 1)

        MsgBox(tiro & " " & pos)

        Lb00.Text += 1
        If Lb00.Text = 10 Then
            Lbcont3.Text = "já gastou 10 chances "

        End If

        If Lb00.Text = 20 Then
            Lbcont3.Text = "já gastou 20 chances es um falhado "
        End If





        If pos = 1 Then
            Lb25.Text = "5"
            Lb26.Text = "5"
            Lb27.Text = "5"
            Lb28.Text = "5"
            Lb29.Text = "5"
            Lb24.Text = "0"
            Lb40.Text = "0"
            Lb12.Text = "0"
            Lb13.Text = "0"
            Lb14.Text = "0"
            Lb15.Text = "0"
            Lb30.Text = "0"
            Lb44.Text = "0"
            Lb45.Text = "0"
            Lb43.Text = "0"
            Lb42.Text = "0"
            Lb41.Text = "0"
        Else
            Lb11.Text = "0"
            Lb9.Text = "0"
            Lb24.Text = "0"
            Lb26.Text = "0"
            Lb39.Text = "0"
            Lb41.Text = "0"
            Lb54.Text = "0"
            Lb56.Text = "0"
            Lb69.Text = "0"
            Lb71.Text = "0"
            Lb101.Text = "0"
            Lb86.Text = "0"
            Lb101.Text = "0"
            Lb99.Text = "0"
            Lb100.Text = "0"
            Lb84.Text = "0"
            Lb10.Text = "0"
            Lb25.Text = "5"
            Lb40.Text = "5"
            Lb55.Text = "5"
            Lb70.Text = "5"
            Lb85.Text = "5"
        End If


        monta()



    End Sub

    Sub monta()
        Dim x As Label

        Lbl.Add(Lb11)
        Lbl.Add(Lb12)
        Lbl.Add(Lb13)
        Lbl.Add(Lb14)
        Lbl.Add(Lb15)



        For Each x As Label In Lbl
            x.Text = 9
        Next
    End Sub

End Class