Public Class Form1
    Private equipaA As Integer
    Private equipaB As Integer
    Private Icone As Object
    Private menssagemBox As Object
    Public Property Botões As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboEquipaA.Items.Add("Forte CR")
        ComboEquipaB.Items.Add("Forte CR")
        ComboEquipaA.Items.Add("Povoa FC")
        ComboEquipaB.Items.Add("Povoa FC")
        ComboEquipaA.Items.Add("Academicos")
        ComboEquipaB.Items.Add("Academicos")
        ComboEquipaA.Items.Add("Sport Via Longa")
        ComboEquipaB.Items.Add("Sport Via Longa")
        grelha.Rows.Add(4)
        grelha.Item(0, 0).Value = "Forte CR"
        grelha.Item(0, 1).Value = "Povoa FC"
        grelha.Item(0, 2).Value = "Academicos"
        grelha.Item(0, 3).Value = "Sport Via Longa"




    End Sub

    Private Sub escrevergrelha(ByVal EquipaA As Integer, ByVal EquipaB As Integer, ByVal GolosA As Integer,
                               ByVal GolosB As Integer)
        If GolosA > GolosB Then
            grelha.Item(1, EquipaA).Value += 3
            grelha.Item(2, EquipaA).Value += GolosA
            grelha.Item(3, EquipaA).Value += GolosB

            grelha.Item(2, EquipaB).Value += GolosB
            grelha.Item(3, EquipaB).Value += GolosA

        Else
            If GolosA < GolosB Then
                grelha.Item(1, EquipaB).Value += 3
                grelha.Item(2, EquipaB).Value += GolosB
                grelha.Item(3, EquipaB).Value += GolosA

                grelha.Item(2, EquipaA).Value += GolosA
                grelha.Item(3, EquipaA).Value += GolosB
            Else

                grelha.Item(1, EquipaA).Value += 1
                grelha.Item(1, EquipaB).Value += 1

                grelha.Item(2, EquipaA).Value += GolosA
                grelha.Item(2, EquipaB).Value += GolosB

                grelha.Item(3, EquipaA).Value += GolosA
                grelha.Item(3, EquipaB).Value += GolosB


            End If
        End If
    End Sub

    Private Sub bttConfirmar_Click(sender As Object, e As EventArgs) Handles bttConfirmar.Click

        Dim Titulo = "Torneio"
        Dim Botões = MessageBoxButtons.OK

        Icone = MessageBoxIcon.Error
        If ComboEquipaA.Text <> "" And ComboEquipaB.Text <> "" Then
            If ComboEquipaA.Text <> ComboEquipaB.Text Then

                equipaA = ComboEquipaA.SelectedIndex
                equipaB = ComboEquipaB.SelectedIndex
                escrevergrelha(equipaA, equipaB, NudGolosA.Value, NudGolosB.Value)
            Else
                menssagemBox.Show("As equipas são iguais", Titulo, Botões, Icone)
            End If
        Else

            Dim menssagemBox As Object = Nothing
            menssagemBox.Show("Ás equipas não atribuidas", Titulo, Botões, Icone)

        End If
    End Sub
End Class
