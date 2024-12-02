<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.whilebtn = New System.Windows.Forms.Button()
        Me.forbtn = New System.Windows.Forms.Button()
        Me.volverbtn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'whilebtn
        '
        Me.whilebtn.Location = New System.Drawing.Point(104, 196)
        Me.whilebtn.Name = "whilebtn"
        Me.whilebtn.Size = New System.Drawing.Size(75, 23)
        Me.whilebtn.TabIndex = 2
        Me.whilebtn.Text = "while"
        Me.whilebtn.UseVisualStyleBackColor = True
        '
        'forbtn
        '
        Me.forbtn.Location = New System.Drawing.Point(236, 196)
        Me.forbtn.Name = "forbtn"
        Me.forbtn.Size = New System.Drawing.Size(75, 23)
        Me.forbtn.TabIndex = 4
        Me.forbtn.Text = "for"
        Me.forbtn.UseVisualStyleBackColor = True
        '
        'volverbtn2
        '
        Me.volverbtn2.Location = New System.Drawing.Point(568, 333)
        Me.volverbtn2.Name = "volverbtn2"
        Me.volverbtn2.Size = New System.Drawing.Size(75, 23)
        Me.volverbtn2.TabIndex = 5
        Me.volverbtn2.Text = "volver"
        Me.volverbtn2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.volverbtn2)
        Me.Controls.Add(Me.forbtn)
        Me.Controls.Add(Me.whilebtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents whilebtn As Button
    Friend WithEvents forbtn As Button
    Friend WithEvents volverbtn2 As Button
End Class
