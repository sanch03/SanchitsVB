Public Class Form1
    Private Sub Btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        WebBrowser1.Navigate(txturl.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Btnforward_Click(sender As Object, e As EventArgs) Handles btnforward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Txturl_TextChanged(sender As Object, e As EventArgs) Handles txturl.TextChanged

    End Sub
End Class
