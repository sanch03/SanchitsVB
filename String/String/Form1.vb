Public Class Form1
    Dim myPhrase As String
    Dim pos As String
    Dim num As String
    Private Sub Btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        myPhrase = InputBox("Enter String")
        txttxt.Text = myPhrase
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        pos = txtpos.Text
        num = txtnum.Text
        txtfinal.Text = Mid(myPhrase, pos, num)
    End Sub
End Class
