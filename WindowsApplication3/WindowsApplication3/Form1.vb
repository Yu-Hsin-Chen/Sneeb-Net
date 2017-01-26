Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = TextBox1.Text
        If a <> String.Empty Then
            Me.WebBrowser1.Navigate(a)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a = TextBox1.Text
        Dim getReader As New IO.StreamReader(WebBrowser1.DocumentStream, System.Text.Encoding.Default)
        Dim gethtml = getReader.ReadToEnd()
        TextBox2.Text = gethtml
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Now()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a = TextBox1.Text
        If RadioButton2.Checked Then
            If a <> String.Empty Then
                Me.WebBrowser1.Navigate("https://www.google.com.tw/webhp?sourceid=&gws_rd=ssl#safe=strict&q=" & a)
            End If
        ElseIf RadioButton1.Checked Then
            If a <> String.Empty Then
                Me.WebBrowser1.Navigate("https://tw.search.yahoo.com/search?fr=yfp-t-100-tw&p=" & a)
            End If
        ElseIf RadioButton3.Checked Then
            If a <> String.Empty Then
                Me.WebBrowser1.Navigate("https://www.bing.com/search?q=" & a)
            End If
        ElseIf RadioButton4.Checked Then
            If a <> String.Empty Then
                Me.WebBrowser1.Navigate("http://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=" & a)
            End If
        Else
            MsgBox("您尚未選擇搜尋引擎", 64 + 0, "提醒")
        End If
    End Sub
End Class
