Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox2.Text = FormatCurrency(TextBox1.Text, , , TriState.True, TriState.True)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            If IsNumeric(TextBox1.Text) = True Then
                TextBox2.Text = FormatCurrency(TextBox1.Text, , , TriState.True, TriState.True)
            Else
                TextBox2.Text = ""
                TextBox1.Text = ""
            End If
        Else
            TextBox2.Text = ""
        End If
    End Sub
End Class
