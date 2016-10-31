Public Class Form1
    Dim keyWord As String



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        keyWord = TextBox1.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WebBrowser1.Navigate("www.supremenewyork.com" + keyWord)

        WebBrowser1.Document.All("commit").InvokeMember("Click")

    End Sub

End Class
