
Public Class Form1
    Dim ctdNumero, ctdEstrela As Integer
    Dim LinhaBoletim, Linha, Coluna, numero As Integer
    Dim Boletim(6, 9) As Double
    Dim SorteioNumeros(4), SorteioEstrelas(1), Aposta(4), Estrelas(1) As Integer

    Dim EstrelasCerta, numcerto As Integer
    Private Sub GrelhaNumeros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrelhaNumeros.CellContentClick

        If GrelhaNumeros.CurrentCell.Style.BackColor <> Color.Aqua Then

            If ctdNumero <= 4 Then
                Aposta(ctdNumero) = GrelhaNumeros.CurrentCell.Value
                ctdNumero += 1
                GrelhaNumeros.CurrentCell.Selected = False
                GrelhaNumeros.CurrentCell.Style.BackColor = Color.Aqua

                If ctdNumero = 5 Then
                    GrelhaNumeros.Enabled = False
                    Array.Sort(Aposta)
                End If
            End If
        Else
            MsgBox("Este Número já foi selecionado")
        End If
    End Sub

    Private Sub GrelhaEstrela_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrelhaEstrela.CellContentClick
        If GrelhaEstrela.CurrentCell.Style.BackColor <> Color.Aqua Then

            If ctdEstrela <= 1 Then
                Estrelas(ctdEstrela) = GrelhaEstrela.CurrentCell.Value
                ctdEstrela += 1
                GrelhaEstrela.CurrentCell.Selected = False
                GrelhaEstrela.CurrentCell.Style.BackColor = Color.Aqua

                If ctdEstrela = 2 Then
                    GrelhaEstrela.Enabled = False
                    Array.Sort(Estrelas)
                End If
            End If
        Else
            MsgBox("Essa Estrela já foi Selecionada")
        End If
    End Sub

    Private Sub BttLancar_Click(sender As Object, e As EventArgs) Handles bttLancar.Click

        If ctdNumero = 5 And ctdEstrela = 2 Then

            If LinhaBoletim <= 9 Then
                For Coluna = 0 To 4
                    GrelhaBoletim.Item(Coluna, LinhaBoletim).Selected = False
                    GrelhaBoletim.Item(Coluna, LinhaBoletim).Style.BackColor = Color.White
                    GrelhaBoletim.Item(Coluna, LinhaBoletim).Value = Aposta(Coluna)

                    Boletim(Coluna, LinhaBoletim) = Aposta(Coluna)

                Next
                For Coluna = 0 To 1
                    GrelhaBoletim.Item(Coluna + 5, LinhaBoletim).Selected = False
                    GrelhaBoletim.Item(Coluna + 5, LinhaBoletim).Style.BackColor = Color.Yellow
                    GrelhaBoletim.Item(Coluna + 5, LinhaBoletim).Value = Estrelas(Coluna)
                    Boletim(Coluna + 5, LinhaBoletim) = Estrelas(Coluna)
                Next
            End If
            LimparGrelhas()
            LinhaBoletim += 1
        Else
            MsgBox("A chave encontra-se INCOMPLETA")
        End If
    End Sub

    Private Sub BttAnular_Click(sender As Object, e As EventArgs) Handles bttAnular.Click
        LimparGrelhas()
    End Sub
    Public Sub LimparGrelhas()
        For Linha = 0 To 9
            For Coluna = 0 To 4
                GrelhaNumeros.Item(Coluna, Linha).Style.BackColor = Color.White
            Next
        Next
        For Linha = 0 To 2
            For Coluna = 0 To 2
                GrelhaEstrela.Item(Coluna, Linha).Style.BackColor = Color.Yellow
            Next
        Next
        GrelhaNumeros.Enabled = True
        GrelhaEstrela.Enabled = True
        ctdEstrela = 0
        ctdNumero = 0


    End Sub

    Private Sub BttSorteio_Click(sender As Object, e As EventArgs) Handles bttSorteio.Click

        Dim Estrelas
        For ctd = 0 To 4
            Randomize()
            Do
                numcerto = True
                numero = Int((50 * Rnd()) + 1)
                For ctd2 = 0 To 4
                    If numero = SorteioNumeros(ctd2) Then
                        numcerto = False
                    End If
                Next

            Loop Until numcerto = True
            SorteioNumeros(ctd) = numero
        Next
        For ctd = 0 To 1
            Randomize()
            Do
                EstrelasCerta = True
                Estrelas = Int((9 * Rnd()) + 1)
                For ctd2 = 0 To 1
                    If Estrelas = SorteioEstrelas(ctd2) Then
                        EstrelasCerta = False
                    End If
                Next

            Loop Until EstrelasCerta = True
            SorteioEstrelas(ctd) = Estrelas
        Next
        Array.Sort(SorteioNumeros)
        Array.Sort(SorteioEstrelas)
        For ctd = 0 To 4
            GrelhaSorteio.Item(ctd, 0).Selected = False
            GrelhaSorteio.Item(ctd, 0).Style.BackColor = Color.White
            GrelhaSorteio.Item(ctd, 0).Value = SorteioNumeros(ctd)
        Next
        For ctd = 0 To 1
            GrelhaSorteio.Item(ctd + 5, 0).Selected = False
            GrelhaSorteio.Item(ctd + 5, 0).Style.BackColor = Color.Yellow
            GrelhaSorteio.Item(ctd + 5, 0).Value = SorteioEstrelas(ctd)
        Next
        For numero = 0 To 4
            For Linha = 0 To 9
                For Coluna = 0 To 4
                    If SorteioNumeros(numero) = Boletim(Coluna, Linha) Then
                        GrelhaBoletim(Coluna, Linha).Style.BackColor = Color.DeepPink
                    End If
                Next
            Next
        Next
        For Estrelas = 0 To 1
            For Linha = 0 To 9
                For Coluna = 5 To 6
                    If SorteioEstrelas(Estrelas) = Boletim(Coluna, Linha) Then
                        GrelhaBoletim(Coluna, Linha).Style.BackColor = Color.DeepPink
                    End If
                Next
            Next
        Next





    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Numero As Integer
        GrelhaNumeros.Rows.Add(10)
        GrelhaEstrela.Rows.Add(3)
        GrelhaBoletim.Rows.Add(10)
        GrelhaSorteio.Rows.Add(1)
        For Linha = 0 To 9


            For Coluna = 0 To 4
                Numero += 1
                GrelhaNumeros.Item(Coluna, Linha).Value = Numero
                GrelhaNumeros.Item(Coluna, Linha).Selected = False
            Next
        Next
        Numero = 0
        For Linha = 0 To 2
            For Coluna = 0 To 2
                Numero += 1
                GrelhaEstrela.Item(Coluna, Linha).Value = Numero
                GrelhaEstrela.Item(Coluna, Linha).Selected = False
            Next
        Next


    End Sub
End Class
