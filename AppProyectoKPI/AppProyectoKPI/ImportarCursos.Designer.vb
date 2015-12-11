<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarCursos))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnCargarArchivo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(433, 262)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(195, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnImportar.ForeColor = System.Drawing.Color.Silver
        Me.btnImportar.Location = New System.Drawing.Point(433, 229)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(195, 27)
        Me.btnImportar.TabIndex = 9
        Me.btnImportar.Text = "Importar datos"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPath.Location = New System.Drawing.Point(228, 187)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(400, 23)
        Me.txtPath.TabIndex = 8
        '
        'btnCargarArchivo
        '
        Me.btnCargarArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCargarArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCargarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarArchivo.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnCargarArchivo.ForeColor = System.Drawing.Color.Silver
        Me.btnCargarArchivo.Location = New System.Drawing.Point(29, 185)
        Me.btnCargarArchivo.Name = "btnCargarArchivo"
        Me.btnCargarArchivo.Size = New System.Drawing.Size(195, 27)
        Me.btnCargarArchivo.TabIndex = 7
        Me.btnCargarArchivo.Text = "Cargar archivo excel"
        Me.btnCargarArchivo.UseVisualStyleBackColor = False
        '
        'ImportarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 405)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnCargarArchivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportarCursos"
        Me.Text = "ImportarCursos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnImportar As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnCargarArchivo As Button
End Class
