Public Class Form1
    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ds_estudio)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ds_estudio.login' Puede moverla o quitarla según sea necesario.
        Me.LoginTableAdapter.Fill(Me.Ds_estudio.login)
        NombreTextBox.Text = ""
        ContraseñaTextBox.Text = ""

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If Me.LoginTableAdapter.buscarUC(Me.Ds_estudio.login, NombreTextBox.Text, ContraseñaTextBox.Text) Then
            Me.Hide()
            Form2.ShowDialog()
        End If
    End Sub
End Class
