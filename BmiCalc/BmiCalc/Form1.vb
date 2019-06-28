Public Class BMICalc
    Private Sub Btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim height = txthei.Text
        Dim weight = txtwei.Text
        txtbmi.Text = weight / (height ^ 2)
    End Sub
End Class
