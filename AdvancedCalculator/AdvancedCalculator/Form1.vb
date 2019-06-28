Public Class Form1
    Private Sub Btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        lblerror.Visible = False
        On Error GoTo error_handle
        Dim num1, num2, difference, product, quotient, sum As Single
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        sum = num1 + num2
        difference = num1 - num2
        product = num1 * num2
        quotient = num1 / num2
        txtsum.Text = sum
        txtdif.Text = difference
        txtpro.Text = product
        txtquo.Text = quotient
        Exit Sub
error_handle:
        lblerror.Visible = True
    End Sub
End Class
