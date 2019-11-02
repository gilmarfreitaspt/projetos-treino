Imports System.IO
Public Class Form1

    Structure Infoprodutos
        Dim codigo As Integer
        Dim descricao As String
        Dim categoria As String
        Dim preco As Decimal
    End Structure
    ' Dim ArreyList()
    Dim Registo As Infoprodutos
    Dim Produtos As New ArrayList

    Dim Root As String = Application.StartupPath
    Dim Pasta As String = "\Dados\"
    Dim FixeA As String = "Produtos.txt"
    Dim Caminho As String = Root & Pasta & FixeA

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttActualizar.Click
        Dim mensagem, titulo, botoes, icone
        If TxtCodigo.Text = Nothing Or TxtDescricao.Text = Nothing Or
        ComboCategoria.Text = Nothing Or IsNumeric(TxtPreco.Text) = False Then
            mensagem = " Preencha todos os campos e " & vbNewLine & "Verifique os tipos de dados."
            titulo = "registo de produtos"
            botoes = MessageBoxButtons.OK
            icone = MessageBoxIcon.Error
            MessageBox.Show(mensagem, titulo, botoes, icone)

        Else
            EscreverRegArray()

            If LstNome.SelectedIndex <> -1 Then 'aCTUALIZAR
                Produtos.RemoveAt(LstNome.SelectedIndex)
                Produtos.Insert(LstNome.SelectedIndex, Registo)
                LstNome.SelectedIndex = -1
            Else
                Produtos.Add(Registo) ' NOVO
            End If

            LstNome.Items.Clear()
            For Each Registo In Produtos
                LstNome.Items.Add(Registo.descricao)
            Next
            Limpar()

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim FSFicheiro As New FileStream(Caminho, FileMode.Open, FileAccess.Read)
            Dim BRProdutos As New BinaryReader(FSFicheiro)
            Do Until BRProdutos.PeeKchar = -1
                Registo.codigo = BRProdutos.ReadInt32
                Registo.descricao = BRProdutos.ReadString
                Registo.categoria = BRProdutos.ReadString
                Registo.preco = BRProdutos.ReadDecimal
                Produtos.Add(Registo)
                LstNome.Items.Add(Registo.descricao)
            Loop
            BRProdutos.close()
        Catch ex As System.IO.FileNotFoundException
            Dim FSFicheiro As New FileStream(Caminho, FileMode.CreateNew)
            FSFicheiro.Close()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro:" & ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bttSair.Click

        Dim FSFicheiro As New FileStream(Caminho, FileMode.Open, FileAccess.Write)
        Dim BRProdutos As New BinaryWriter(FSFicheiro)

        For Each Registo In Produtos
            BRProdutos.Write(Registo.codigo)
            BRProdutos.Write(Registo.descricao)
            BRProdutos.Write(Registo.categoria)
            BRProdutos.Write(Registo.preco)
        Next
        BRProdutos.Close()
        Me.Close()
    End Sub

    Private Sub bttnovo_Click(sender As Object, e As EventArgs) Handles bttnovo.Click
        TxtCodigo.ResetText()
        TxtDescricao.ResetText()
        ComboCategoria.SelectedIndex = -1
        TxtDescricao.ResetText()
        LstNome.SelectedIndex = -1

        TxtCodigo.Focus()
        Limpar()
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        If LstNome.SelectedIndex = -1 Then
            Limpar()
        Else
            Registo = Produtos(LstNome.SelectedIndex)
            LerRegArrey()
        End If
    End Sub

    Private Sub lstnome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstNome.SelectedIndexChanged

        If LstNome.SelectedIndex <> -1 Then
            Registo = Produtos(LstNome.SelectedIndex)
            LerRegArrey()

        End If
    End Sub
    Public Sub Limpar()

        TxtCodigo.ResetText()
        TxtDescricao.ResetText()
        TxtPreco.ResetText()

    End Sub
    Public Sub LerRegArrey()
        TxtCodigo.Text = Registo.codigo
        TxtDescricao.Text = Registo.descricao
        ComboCategoria.Text = Registo.categoria
        TxtPreco.Text = Registo.preco
    End Sub

    Public Sub EscreverRegArray()
        Registo.codigo = CInt(TxtCodigo.Text)
        Registo.descricao = TxtDescricao.Text
        Registo.categoria = ComboCategoria.Text
        Registo.preco = CDec(TxtPreco.Text)
    End Sub
End Class
