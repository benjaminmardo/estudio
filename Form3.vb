Public Class Form3
    Private Sub volverbtn1_Click(sender As Object, e As EventArgs) Handles volverbtn1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = sumar(TextBox1.Text, TextBox2.Text)
    End Sub

    Function sumar(a As Integer, b As Integer) As Integer
        sumar = a + b
        Return (sumar)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles parimpbtn.Click
        TextBox3.Text = parimpar(TextBox1.Text)
    End Sub

    Function parimpar(q As Integer) As String
        If q Mod 2 = 0 Then
            Return "Par"
        Else
            Return "Impar"
        End If

    End Function

    Private Sub colorbtn_Click(sender As Object, e As EventArgs) Handles colorbtn.Click
        TextBox3.Text = altura1(TextBox1.Text)
    End Sub

    Function altura1(altura As Integer) As String
        If altura >= 180 Then
            Return "alto"
        ElseIf altura = 170 Then
            Return "mediano"
        ElseIf altura <= 160 Then
            Return "bajo"
        End If

    End Function
End Class