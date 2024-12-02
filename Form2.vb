Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ds_estudio.mercado' Puede moverla o quitarla según sea necesario.
        Me.MercadoTableAdapter.Fill(Me.Ds_estudio.mercado)

    End Sub

    Private Sub WhileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhileToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub insertbtn1_Click(sender As Object, e As EventArgs) Handles insertbtn1.Click
        Me.MercadoTableAdapter.Insert(id_lugar:=lugartxt1.Text, nomb_lugar:=nombretxt1.Text, tipo_merc:=merctxt1.Text)
        Me.MercadoTableAdapter.Fill(Me.Ds_estudio.mercado)
    End Sub

    Private Sub deletbtn1_Click(sender As Object, e As EventArgs) Handles deletbtn1.Click
        Me.MercadoTableAdapter.DELET2(id_lugar:=lugartxt1.Text)
        Me.MercadoTableAdapter.Fill(Me.Ds_estudio.mercado)

    End Sub

    Private Sub updatebtn1_Click(sender As Object, e As EventArgs) Handles updatebtn1.Click
        Me.MercadoTableAdapter.update2(id_lugar:=lugartxt1.Text, nomb_lugar:=nombretxt1.Text, tipo_merc:=merctxt1.Text)
        Me.MercadoTableAdapter.Fill(Me.Ds_estudio.mercado)
    End Sub

    Private Sub FuncionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionesToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub LenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LenToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class