Public Class Form1
    Dim objecto As Integer

    Private Sub RadQuadrado_CheckedChanged(sender As Object, e As EventArgs) Handles RadQuadrado.CheckedChanged
        EsconderObjectos()

        Lb1.text = "Lado"
        objecto = 1
    End Sub

    Private Sub RedRectangulo_CheckedChanged(sender As Object, e As EventArgs) Handles RedRectangulo.CheckedChanged
        EsconderObjectos()
        Lb1.text = "Lado Maior"
        Lb2.Visible = True
        Lb2.Text = "Lado Menor"
        Txt1.Select()
        Txt2.Visible = True
        objecto = 2
    End Sub

    Private Sub RadCirculo_CheckedChanged(sender As Object, e As EventArgs) Handles RadCirculo.CheckedChanged
        EsconderObjectos()
        Lb1.Text = "Raio"
        Txt1.Select()
        objecto = 5
    End Sub

    Private Sub RadTrapezio_CheckedChanged(sender As Object, e As EventArgs) Handles RadTrapezio.CheckedChanged
        EsconderObjectos()
        Lb1.Text = "Base Maior"
        Lb2.Visible = True
        Lb2.Text = "Base Menor"
        Lb3.Visible = True
        Lb3.Text = "Altura"
        Txt1.Select()
        Txt2.Visible = True
        Txt3.Visible = True
        objecto = 4
    End Sub

    Private Sub RadTriangulo_CheckedChanged(sender As Object, e As EventArgs) Handles RadTriangulo.CheckedChanged
        EsconderObjectos()
        Lb1.Text = "Base"
        Lb2.Visible = True
        Lb2.Text = "Altura"
        Txt1.Select()
        Txt2.Visible = True
        objecto = 3
    End Sub

    Private Sub RadLosango_CheckedChanged(sender As Object, e As EventArgs) Handles RadLosango.CheckedChanged
        EsconderObjectos()
        Lb1.Text = "Diagonal Maior"
        Lb2.Visible = True
        Lb2.Text = "Diagonal Menor"
        Txt1.Select()
        Txt2.Visible = True
        objecto = 6
    End Sub

    Private Sub ChkVolume_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVolume.CheckedChanged
        If ChkVolume.Checked = True Then
            LbAltura.Visible = True
            TxtAltura.Visible = True
            TxtAltura.Clear()
            TxtAltura.Select()
        Else
            LbAltura.Visible = False
            TxtAltura.Visible = False
        End If
    End Sub

    Private Sub bttCalcular_Click(sender As Object, e As EventArgs) Handles bttCalcular.Click
        LbResultado.Text = Area(objecto, Val(Txt1.Text), Val(Txt2.Text), Val(Txt3.Text))
        If ChkVolume.Checked = True Then
            LbResultado.Text = Val(LbResultado.Text) * Val(TxtAltura.Text)
        End If
    End Sub
    Public Sub EsconderObjectos()
        Txt1.Clear()
        Lb2.Visible = False
        Txt2.Visible = False
        Txt2.Clear()
        Lb3.Visible = False
        Txt3.Visible = False
        Txt3.Clear()
        LbResultado.ResetText()
    End Sub
    Function Area(ByVal tipo As Integer, ByVal valor1 As Integer, ByVal valor2 As Integer, ByVal valor3 As Integer) As Double
        Select Case tipo
            Case 1 'quadrado 
                Area = valor1 * valor1
            Case 2 'rectangulo
                Area = valor1 * valor2
            Case 3 'triangulo
                Area = (valor1 * valor2) / 2
            Case 4 'trapezio
                Area = (valor1 * valor2) / 2 * valor3
            Case 5 'circulo
                Area = (Math.PI + valor1) ^ 2
            Case 6 'losango
                Area = (valor1 * valor2) / 2
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lb1.Text = "Lado"
    End Sub
End Class
