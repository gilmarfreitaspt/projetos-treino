Public Class Form1



    Private Sub RadMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles RadMasculino.CheckedChanged
        LbValorIMC.Text = calcularIMC(NudPeso.Value, NudAltura.Value)
        LbObsIMC.Text = ObsIMC(Val(LbValorIMC.Text), "Masculino")
    End Sub

    Private Sub RadFeminino_CheckedChanged(sender As Object, e As EventArgs) Handles RadFeminino.CheckedChanged
        LbValorIMC.Text = calcularIMC(NudPeso.Value, NudAltura.Value)
        LbObsIMC.Text = ObsIMC(Val(LbValorIMC.Text), "Feminino")
    End Sub

    Private Sub NudAltura_ValueChanged(sender As Object, e As EventArgs) Handles NudAltura.ValueChanged
        Dim sexo As String
        If RadMasculino.Checked = True Then
            sexo = " Masculino"
        Else
            sexo = "Feminino"
        End If
        LbValorIMC.Text = calcularIMC(NudPeso.Value, NudAltura.Value)
        LbObsIMC.Text = ObsIMC(Val(LbValorIMC.Text), sexo)
    End Sub

    Private Sub NudPeso_ValueChanged(sender As Object, e As EventArgs) Handles NudPeso.ValueChanged
        Dim sexo As String
        If RadMasculino.Checked = True Then
            sexo = " Masculino"
        Else
            sexo = "Feminino"
        End If
        LbValorIMC.Text = calcularIMC(NudPeso.Value, NudAltura.Value)
        LbObsIMC.Text = ObsIMC(Val(LbValorIMC.Text), sexo)
    End Sub


    Function calcularIMC(ByVal peso As Integer, ByVal altura As Double) As Double
        calcularIMC = Math.Round(peso / (altura ^ 2), 1)
    End Function
    Function ObsIMC(ByVal IMC As Double, ByVal sexo As String) As String
        Dim excesso As Integer
        If sexo = "Masculino" Then
            excesso = 1
        End If

        Select Case IMC
            Case 0 To 18.4 + excesso
                ObsIMC = "Abaixo do Peso"

            Case 18.5 + excesso To 24.9 + excesso
                ObsIMC = "Peso Normal"
            Case 25 + excesso To 29.9 + excesso
                ObsIMC = " Acima do Peso"
            Case Is > 30 + excesso
                ObsIMC = " Obeso"

        End Select

    End Function



End Class
