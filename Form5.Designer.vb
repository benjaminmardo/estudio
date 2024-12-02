<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lenbtn = New System.Windows.Forms.Button()
        Me.volverbtn3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'lenbtn
        '
        Me.lenbtn.Location = New System.Drawing.Point(177, 165)
        Me.lenbtn.Name = "lenbtn"
        Me.lenbtn.Size = New System.Drawing.Size(75, 23)
        Me.lenbtn.TabIndex = 1
        Me.lenbtn.Text = "len "
        Me.lenbtn.UseVisualStyleBackColor = True
        '
        'volverbtn3
        '
        Me.volverbtn3.Location = New System.Drawing.Point(658, 348)
        Me.volverbtn3.Name = "volverbtn3"
        Me.volverbtn3.Size = New System.Drawing.Size(75, 23)
        Me.volverbtn3.TabIndex = 2
        Me.volverbtn3.Text = "volver"
        Me.volverbtn3.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.volverbtn3)
        Me.Controls.Add(Me.lenbtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lenbtn As Button
    Friend WithEvents volverbtn3 As Button
End Class
