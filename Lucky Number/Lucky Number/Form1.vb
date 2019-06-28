Public Class Form1
    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim number As Integer
        number = txtnum.Text
        If number >= 20 And number <= 30 Then
            MsgBox("Yaay you won a prize!")
        Else
            MsgBox("No prize for you!")
        End If
    End Sub
End Class
