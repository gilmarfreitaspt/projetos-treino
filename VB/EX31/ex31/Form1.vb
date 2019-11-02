
Public Class Form1
    Private Sub bttVerificar_Click(sender As Object, e As EventArgs) Handles bttVerificar.Click
        Dim texto, palavra As String
        Dim ArrayPalavras() As String
        Dim CtdPalavras, ctd As Integer
        Dim delimitadores() As Char = {CType(" ", Char), CType(".", Char), CType(",", Char),
        CType(";", Char), CType("!", Char), Chr(10), Chr(13), vbNewLine, vbTab}
        texto = TxtTexto.Text

        ArrayPalavras = texto.Split(delimitadores)
        For ctd = 0 To ArrayPalavras.GetUpperBound(0)
            palavra = ArrayPalavras(ctd).ToUpper
            If Not LstPalavras.Items.Contains(palavra) Then
                LstPalavras.Items.Add(palavra)
                CtdPalavras += 1
            End If
        Next
        LbPalavras.Text = CtdPalavras
    End Sub

    Private Sub bttAbrir_Click(sender As Object, e As EventArgs) Handles bttAbrir.Click
        OpenFileDialog1.DefaultExt = "Txt"
        OpenFileDialog1.Filter = "ficheiro de texto |*.txt"
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.AddExtension = True
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            StrTexto = file.opemText(OpenFileDialog1.Filename)
            TxtTexto.Clear()
            TxtTexto.Text = StrTexto.ReadToEnd()
        End If
        StrTexto.Close()
    End Sub
End Class
