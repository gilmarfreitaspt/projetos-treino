Imports System.IO
Public Class Form1
    Dim Root As String = Application.StartupPath
    Dim Pasta As String = "\Dados\"
    Dim Caminho As String = Root & Pasta
    Dim mensagem, titulo, botoes, icone

    Private Sub LstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstPaises.SelectedIndexChanged
        CarregarLstCidades()
    End Sub

    Private Sub bttCidade_Click(sender As Object, e As EventArgs) Handles bttCidade.Click
        If LstPaises.SelectedIndex = -1 Then
            mensagem = "O País não está selecionado "
            titulo = "Paises e Cidades"
            botoes = MessageBoxButtons.OK
            icone = MessageBoxIcon.Information
            MessageBox.Show(mensagem, titulo, botoes, icone)
        Else
            Dim cidade As StreamWriter = New StreamWriter(Caminho & LstPaises.SelectedItem & ".txt", True)
            Dim novaCidade As String = ""
            novaCidade = InputBox("Escreva uma nova Cidade")

            If novaCidade <> "" Then
                cidade.WriteLine(novaCidade)
            End If
            cidade.Close()
            CarregarLstCidades()
        End If
    End Sub

    Private Sub bttPais_Click(sender As Object, e As EventArgs) Handles bttPais.Click
        Dim pais As StreamWriter = New StreamWriter(Caminho & "paises.txt", True)
        Dim novopais As String = ""
        novopais = InputBox("Escreva o novo País")
        If novopais <> "" Then
            pais.WriteLine(novopais)
            Dim criarPais As StreamWriter = New StreamWriter(Caminho & novopais & ".txt")
            criarPais.Close()
        End If
        pais.Close()
        CarregarLstPaises()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarLstPaises()

    End Sub
    Public Sub CarregarLstPaises()

        Try
            Dim pais
            Dim linha As StreamReader = New StreamReader(Caminho & "paises.txt")
            LstPaises.Items.Clear()
            Do Until linha.EndOfStream()
                pais = linha.ReadLine
                LstPaises.Items.Add(pais)
            Loop

            linha.Close()
        Catch ex As Exception
            mensagem = " Erro de ficheiros " & vbNewLine & ex.Message
            titulo = "Paises e Cidades"
            botoes = MessageBoxButtons.OK
            icone = MessageBoxIcon.Information
            MessageBox.Show(mensagem, titulo, botoes, icone)

        End Try
    End Sub
    Public Sub CarregarLstCidades()

        '  Dim xx As String = Caminho & LstPaises.SelectedItem.ToString & ".txt"
        Dim cidade
        Dim linha As StreamReader = New StreamReader(Caminho & LstPaises.SelectedItem.ToString & ".txt")

        LstCidades.Items.Clear()

        Do Until linha.EndOfStream()
            cidade = linha.ReadLine
            LstCidades.Items.Add(cidade)
        Loop

        linha.Close()

    End Sub
End Class
