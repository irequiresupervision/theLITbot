Public Class Form1
    'Dim itemname As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName()


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        keyWord = TextBox1.Text
        usrNFull = flName.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WebBrowser1.Navigate("www.supremenewyork.com" + keyWord)
        WaitForPageLoad()
        WebBrowser1.Document.All("commit").InvokeMember("Click")
        sysLog.Text = "Item Added to Cart:" + keyWord
        WaitForPageLoad()

        WebBrowser1.Navigate("https://www.supremenewyork.com/checkout")
        With WebBrowser1
            .Document.GetElementById("order_billing_name").SetAttribute("value", flName.Text)
            .Document.GetElementById("order_email").SetAttribute("value", usrEM.Text)
        End With
        WebBrowser1.Document.All("commit").InvokeMember("Click")

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles flName.TextChanged

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles sysLog.TextChanged
        'set up log in this box
    End Sub



End Class
