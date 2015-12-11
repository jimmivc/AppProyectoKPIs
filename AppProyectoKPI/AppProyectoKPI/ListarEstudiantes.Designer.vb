<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarEstudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarEstudiantes))
        Me.dtgListarEstudiantes = New System.Windows.Forms.DataGridView()
        CType(Me.dtgListarEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgListarEstudiantes
        '
        Me.dtgListarEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dtgListarEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListarEstudiantes.Location = New System.Drawing.Point(12, 136)
        Me.dtgListarEstudiantes.Name = "dtgListarEstudiantes"
        Me.dtgListarEstudiantes.Size = New System.Drawing.Size(860, 397)
        Me.dtgListarEstudiantes.TabIndex = 0
        '
        'ListarEstudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 545)
        Me.Controls.Add(Me.dtgListarEstudiantes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListarEstudiantes"
        Me.Text = "ListarEstudiantes"
        CType(Me.dtgListarEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgListarEstudiantes As DataGridView
End Class
