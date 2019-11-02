Public Class Form1
    Dim mes As Double
    Dim dia As Double
    Dim caminho As String = Application.StartupPath & "\imagens\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub DtpCalendario_ValueChanged(sender As Object, e As EventArgs) Handles DtpCalendario.ValueChanged
        dia = DtpCalendario.Value.Day
        Mes = DtpCalendario.Value.Month

        LbSigno.Text = signo(dia, mes, caminho)
    End Sub
    Function signo(ByVal dia As Integer, ByVal mes As Integer, Root As String) As String
        Select Case mes
            Case 1
                If dia < 20 Then
                    signo = "Capricórnio"
                    Root = Root & "foto1.jpg"
                Else
                    signo = "Aquário"
                    Root = Root & "foto2.jpg"
                End If
            Case 2
                If dia < 19 Then
                    signo = "Aquário"
                    Root = Root & "foto2.jpg"
                Else
                    signo = "Peixes"
                    Root = Root & "foto3.jpg"
                End If
            Case 3
                If dia < 20 Then
                    signo = "Peixes"
                    Root = Root & "foto3.jpg"
                Else
                    signo = "Carneiro"
                    Root = Root & "foto4.jpg"
                End If
            Case 4
                If dia < 21 Then
                    signo = "Carneiro"
                    Root = Root & "foto4.jpg"
                Else
                    signo = "Touro"
                    Root = Root & "foto5.jpg"
                End If
            Case 5
                If dia < 20 Then
                    signo = "Touro"
                    Root = Root & "foto5.jpg"
                Else
                    signo = "Gémeos"
                    Root = Root & "foto6.jpg"
                End If
            Case 6
                If dia < 20 Then
                    signo = "Gémeos"
                    Root = Root & "foto6.jpg"
                Else
                    signo = "Caranguejo"
                    Root = Root & "foto7.jpg"
                End If
            Case 7
                If dia < 21 Then
                    signo = "Caranguejo"
                    Root = Root & "foto7.jpg"
                Else
                    signo = "Leão"
                    Root = Root & "foto8.jpg"
                End If
            Case 8
                If dia < 22 Then
                    signo = "Leão"
                    Root = Root & "foto8.jpg"
                Else
                    signo = "Virgem"
                    Root = Root & "foto9.jpg"
                End If
            Case 9
                If dia < 23 Then
                    signo = "Virgem"
                    Root = Root & "foto9.jpg"
                Else
                    signo = "Balança"
                    Root = Root & "foto10.jpg"
                End If
            Case 10
                If dia < 22 Then
                    signo = "Balança"
                    Root = Root & "foto10.jpg"
                Else
                    signo = "Escorpião"
                    Root = Root & "foto11.jpg"
                End If
            Case 11
                If dia < 21 Then
                    signo = "Escorpião"
                    Root = Root & "foto11.jpg"

                Else
                    signo = "Sagitário"
                    Root = Root & "foto12.jpg"
                End If
            Case 12
                If dia < 21 Then
                    signo = "Sagitário"
                    Root = Root & "foto12.jpg"
                Else
                    signo = "Capricórnio"
                    Root = Root & "foto1.jpg"
                End If

        End Select

        PicMain.Image = Image.FromFile(Root)
    End Function
End Class
