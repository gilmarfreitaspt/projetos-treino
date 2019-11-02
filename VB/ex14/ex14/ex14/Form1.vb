Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Form1_Load:
        For ctd = 1 To 10
            ComboNumero.Items.Add(ctd)

        Next
    End Sub

    Private Sub ComboNumero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNumero.SelectedIndexChanged
        Dim numero As Integer
        numero = Val(ComboNumero.Text)
        ListTabuada.Items.Clear()
        For ctd = 1 To 10
            ListTabuada.Items.Add(numero & "x" & ctd & "=" & numero * ctd)
        Next
    End Sub
End Class
