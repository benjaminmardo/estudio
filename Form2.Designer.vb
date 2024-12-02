<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lugartxt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombretxt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.merctxt1 = New System.Windows.Forms.TextBox()
        Me.insertbtn1 = New System.Windows.Forms.Button()
        Me.updatebtn1 = New System.Windows.Forms.Button()
        Me.deletbtn1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdlugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomblugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipomercDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_estudio = New estudio.ds_estudio()
        Me.MercadoTableAdapter = New estudio.ds_estudioTableAdapters.mercadoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MercadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_estudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdlugarDataGridViewTextBoxColumn, Me.NomblugarDataGridViewTextBoxColumn, Me.TipomercDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MercadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(105, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(475, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'lugartxt1
        '
        Me.lugartxt1.Location = New System.Drawing.Point(114, 63)
        Me.lugartxt1.Name = "lugartxt1"
        Me.lugartxt1.Size = New System.Drawing.Size(100, 22)
        Me.lugartxt1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "id_lugar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nombre lugar"
        '
        'nombretxt1
        '
        Me.nombretxt1.Location = New System.Drawing.Point(114, 137)
        Me.nombretxt1.Name = "nombretxt1"
        Me.nombretxt1.Size = New System.Drawing.Size(100, 22)
        Me.nombretxt1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "tipo de mercancia "
        '
        'merctxt1
        '
        Me.merctxt1.Location = New System.Drawing.Point(114, 214)
        Me.merctxt1.Name = "merctxt1"
        Me.merctxt1.Size = New System.Drawing.Size(100, 22)
        Me.merctxt1.TabIndex = 5
        '
        'insertbtn1
        '
        Me.insertbtn1.Location = New System.Drawing.Point(401, 63)
        Me.insertbtn1.Name = "insertbtn1"
        Me.insertbtn1.Size = New System.Drawing.Size(75, 23)
        Me.insertbtn1.TabIndex = 7
        Me.insertbtn1.Text = "insert"
        Me.insertbtn1.UseVisualStyleBackColor = True
        '
        'updatebtn1
        '
        Me.updatebtn1.Location = New System.Drawing.Point(401, 195)
        Me.updatebtn1.Name = "updatebtn1"
        Me.updatebtn1.Size = New System.Drawing.Size(75, 23)
        Me.updatebtn1.TabIndex = 8
        Me.updatebtn1.Text = "update"
        Me.updatebtn1.UseVisualStyleBackColor = True
        '
        'deletbtn1
        '
        Me.deletbtn1.Location = New System.Drawing.Point(401, 127)
        Me.deletbtn1.Name = "deletbtn1"
        Me.deletbtn1.Size = New System.Drawing.Size(75, 23)
        Me.deletbtn1.TabIndex = 8
        Me.deletbtn1.Text = "delet"
        Me.deletbtn1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionesToolStripMenuItem, Me.WhileToolStripMenuItem, Me.LenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.FuncionesToolStripMenuItem.Text = "funciones"
        '
        'WhileToolStripMenuItem
        '
        Me.WhileToolStripMenuItem.Name = "WhileToolStripMenuItem"
        Me.WhileToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.WhileToolStripMenuItem.Text = "while y if  y for"
        '
        'LenToolStripMenuItem
        '
        Me.LenToolStripMenuItem.Name = "LenToolStripMenuItem"
        Me.LenToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.LenToolStripMenuItem.Text = "len "
        '
        'IdlugarDataGridViewTextBoxColumn
        '
        Me.IdlugarDataGridViewTextBoxColumn.DataPropertyName = "id_lugar"
        Me.IdlugarDataGridViewTextBoxColumn.HeaderText = "id_lugar"
        Me.IdlugarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdlugarDataGridViewTextBoxColumn.Name = "IdlugarDataGridViewTextBoxColumn"
        Me.IdlugarDataGridViewTextBoxColumn.Width = 125
        '
        'NomblugarDataGridViewTextBoxColumn
        '
        Me.NomblugarDataGridViewTextBoxColumn.DataPropertyName = "nomb_lugar"
        Me.NomblugarDataGridViewTextBoxColumn.HeaderText = "nomb_lugar"
        Me.NomblugarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomblugarDataGridViewTextBoxColumn.Name = "NomblugarDataGridViewTextBoxColumn"
        Me.NomblugarDataGridViewTextBoxColumn.Width = 125
        '
        'TipomercDataGridViewTextBoxColumn
        '
        Me.TipomercDataGridViewTextBoxColumn.DataPropertyName = "tipo_merc"
        Me.TipomercDataGridViewTextBoxColumn.HeaderText = "tipo_merc"
        Me.TipomercDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipomercDataGridViewTextBoxColumn.Name = "TipomercDataGridViewTextBoxColumn"
        Me.TipomercDataGridViewTextBoxColumn.Width = 125
        '
        'MercadoBindingSource
        '
        Me.MercadoBindingSource.DataMember = "mercado"
        Me.MercadoBindingSource.DataSource = Me.Ds_estudio
        '
        'Ds_estudio
        '
        Me.Ds_estudio.DataSetName = "ds_estudio"
        Me.Ds_estudio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MercadoTableAdapter
        '
        Me.MercadoTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.deletbtn1)
        Me.Controls.Add(Me.updatebtn1)
        Me.Controls.Add(Me.insertbtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.merctxt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombretxt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lugartxt1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MercadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_estudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ds_estudio As ds_estudio
    Friend WithEvents MercadoBindingSource As BindingSource
    Friend WithEvents MercadoTableAdapter As ds_estudioTableAdapters.mercadoTableAdapter
    Friend WithEvents IdlugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomblugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipomercDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lugartxt1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombretxt1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents merctxt1 As TextBox
    Friend WithEvents insertbtn1 As Button
    Friend WithEvents updatebtn1 As Button
    Friend WithEvents deletbtn1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LenToolStripMenuItem As ToolStripMenuItem
End Class
