Public Class Form5
    Private Sub lenbtn_Click(sender As Object, e As EventArgs) Handles lenbtn.Click
        MsgBox(Len(TextBox1.Text))
    End Sub

    Private Sub volverbtn3_Click(sender As Object, e As EventArgs) Handles volverbtn3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class