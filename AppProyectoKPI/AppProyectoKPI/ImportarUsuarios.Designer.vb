<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarUsuarios))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnCargarArchivo = New System.Windows.Forms.Button()
        Me.cbxImportar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(427, 268)
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
        Me.btnImportar.Location = New System.Drawing.Point(427, 235)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(195, 27)
        Me.btnImportar.TabIndex = 9
        Me.btnImportar.Text = "Importar datos"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPath.Location = New System.Drawing.Point(222, 193)
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
        Me.btnCargarArchivo.Location = New System.Drawing.Point(23, 191)
        Me.btnCargarArchivo.Name = "btnCargarArchivo"
        Me.btnCargarArchivo.Size = New System.Drawing.Size(195, 27)
        Me.btnCargarArchivo.TabIndex = 7
        Me.btnCargarArchivo.Text = "Cargar archivo excel"
        Me.btnCargarArchivo.UseVisualStyleBackColor = False
        '
        'cbxImportar
        '
        Me.cbxImportar.FormattingEnabled = True
        Me.cbxImportar.Items.AddRange(New Object() {"Profesores", "Estudiantes"})
        Me.cbxImportar.Location = New System.Drawing.Point(501, 166)
        Me.cbxImportar.Name = "cbxImportar"
        Me.cbxImportar.Size = New System.Drawing.Size(121, 21)
        Me.cbxImportar.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(497, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo de lista para importar"
        '
        'ImportarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 405)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxImportar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnCargarArchivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportarUsuarios"
        Me.Text = "ImportarUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnImportar As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnCargarArchivo As Button
    Friend WithEvents cbxImportar As ComboBox
    Friend WithEvents Label1 As Label
End Class
