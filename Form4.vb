Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub whilebtn_Click(sender As Object, e As EventArgs) Handles whilebtn.Click
        Dim limite As Integer = CInt(TextBox1.Text) 'usa de limite el text box'
        Dim contador As Integer = 1

        ' Bucle While
        While contador <= limite
            MsgBox("El número es: " & contador)
            contador += 1
        End While

    End Sub

    Private Sub forbtn_Click(sender As Object, e As EventArgs) Handles forbtn.Click
        Dim limite As Integer = CInt(TextBox1.Text)
        For i As Integer = 0 To 10
            MsgBox("El contador es: " & i)
        Next
    End Sub

    Private Sub volverbtn2_Click(sender As Object, e As EventArgs) Handles volverbtn2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class