Imports System.Text
Imports System.IO
Imports System.IO.Ports
Public Class formMain

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If tbxMoshimo.Text = "" Or tbxWord.Text = "" Then
            MessageBox.Show("2つのテキストボックスをどちらとも入力してからクリックしてください！", "確認", MessageBoxButtons.OK)
            Return
        End If

        'Dim strKaerebaLink(42) As String
        'Dim strMoshimoLink(5) As String
        'Dim strKanseiLink(42) As String
        Dim strKansei As String = Nothing

        Dim txtFile As New StreamReader( _
            "###kaereba-link-default###.txt", Encoding.GetEncoding("UTF-8"))
        Dim strKaerebaLinkMoto As String = txtFile.ReadToEnd()
        txtFile.Close()

        If (strKaerebaLinkMoto.Where(Function(c) c = "<").Count()) <> 42 Then
            MessageBox.Show("初回準備である「###kaereba-link-default###.txt」へのカエレバリンク（原型）の作成→貼り付け→上書き保存が正しく行われていません。" & vbCrLf & vbCrLf & "・カエレバリンクのテンプレート選択（amazlet-2風(cssカスタマイズ用)）" & vbCrLf & "・商品キーワード「***」の入力" & vbCrLf & "・ショップリンクの3つチェック（Amazon、楽天、Yahoo!）" & vbCrLf & vbCrLf & "再度記事をお読みになりながら、上記3点を特にご確認ください。", "エラー", MessageBoxButtons.OK)
            Return
        End If

        Dim strKaerebaLink() As String = Split(strKaerebaLinkMoto, "<")
        '上記配列の[1]~[42]に格納されている（[0]は空白になるため）
        For i As Integer = 1 To 42
            strKaerebaLink(i) = "<" & strKaerebaLink(i)
        Next
        'For i As Integer = 0 To 42
        '    MessageBox.Show(strKaerebaLink(i))
        'Next

        Dim strMoshimoLink() As String = Split(tbxMoshimo.Text, "<")
        For i As Integer = 1 To 5
            strMoshimoLink(i) = "<" & strMoshimoLink(i)
        Next
        'For i As Integer = 0 To 5
        '    MessageBox.Show(strMoshimoLink(i))
        'Next

        'もしもに置き換え
        strKaerebaLink(4) = strMoshimoLink(1)
        strKaerebaLink(5) = strMoshimoLink(2)
        strKaerebaLink(7) = strMoshimoLink(5)
        strKaerebaLink(11) = strMoshimoLink(1) & strMoshimoLink(3)
        strKaerebaLink(13) = strMoshimoLink(5)

        '<br>を削除
        strKaerebaLink(11) = strKaerebaLink(11).Replace("<br />", "")

        '順番を変更
        Dim strTemp(4) As String
        For i As Integer = 0 To 4
            strTemp(i) = strKaerebaLink(i + 22)
            strKaerebaLink(i + 22) = strKaerebaLink(i + 27)
            strKaerebaLink(i + 27) = strTemp(i)
        Next

        'For i As Integer = 0 To 42
        '    MessageBox.Show(strKaerebaLink(i))
        'Next

        'ダブルエンコード
        Dim strSearchWord As String = tbxWord.Text
        Dim encodeWord As String = System.Web.HttpUtility.UrlEncode(strSearchWord)
        Dim encodeWord2 As String = System.Web.HttpUtility.UrlEncode(encodeWord)

        '検索ワード置き換え
        strKaerebaLink(23) = strKaerebaLink(23).Replace("%252A%252A%252A", encodeWord2)
        strKaerebaLink(28) = strKaerebaLink(28).Replace("%252A%252A%252A", encodeWord2)
        strKaerebaLink(33) = strKaerebaLink(33).Replace("%252A%252A%252A", encodeWord2)

        'For i As Integer = 0 To 42
        'MessageBox.Show(strKaerebaLink(23))
        'Next

        For i As Integer = 1 To 42
            strKansei = strKansei & strKaerebaLink(i)
        Next

        tbxResult.Text = strKansei
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetDataObject(tbxResult.Text)
    End Sub
End Class
