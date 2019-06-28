Public Class sum

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim num1 As Single = Val(textnum1.Text)
        Dim num2 As Single = Val(textnum2.Text)
        Dim Sum As Single = num1 + num2
        LblAns.Text = Sum.ToString
    End Sub
End Class
