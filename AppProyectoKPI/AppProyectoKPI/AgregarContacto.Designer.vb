<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarContacto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarContacto))
        Me.txtDescFormaContacto = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIsHabilitado = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.cbxEmpresa = New System.Windows.Forms.ComboBox()
        Me.ckxIsHabilitado = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtDescFormaContacto
        '
        Me.txtDescFormaContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtDescFormaContacto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescFormaContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtDescFormaContacto.Location = New System.Drawing.Point(13, 45)
        Me.txtDescFormaContacto.Name = "txtDescFormaContacto"
        Me.txtDescFormaContacto.Size = New System.Drawing.Size(216, 23)
        Me.txtDescFormaContacto.TabIndex = 28
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 21)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcion.Size = New System.Drawing.Size(216, 21)
        Me.lblDescripcion.TabIndex = 27
        Me.lblDescripcion.Text = "Descripción de contacto"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(130, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tipo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(159, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Empresa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtIsHabilitado
        '
        Me.txtIsHabilitado.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtIsHabilitado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsHabilitado.Location = New System.Drawing.Point(525, 21)
        Me.txtIsHabilitado.Name = "txtIsHabilitado"
        Me.txtIsHabilitado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIsHabilitado.Size = New System.Drawing.Size(79, 21)
        Me.txtIsHabilitado.TabIndex = 33
        Me.txtIsHabilitado.Text = "Habilitado"
        Me.txtIsHabilitado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Silver
        Me.btnRegistrar.Location = New System.Drawing.Point(280, 90)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(73, 27)
        Me.btnRegistrar.TabIndex = 35
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'cbxTipo
        '
        Me.cbxTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxTipo.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(231, 44)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(130, 24)
        Me.cbxTipo.TabIndex = 36
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxEmpresa.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxEmpresa.FormattingEnabled = True
        Me.cbxEmpresa.Location = New System.Drawing.Point(363, 44)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Size = New System.Drawing.Size(159, 24)
        Me.cbxEmpresa.TabIndex = 37
        '
        'ckxIsHabilitado
        '
        Me.ckxIsHabilitado.AutoSize = True
        Me.ckxIsHabilitado.Location = New System.Drawing.Point(557, 50)
        Me.ckxIsHabilitado.Name = "ckxIsHabilitado"
        Me.ckxIsHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.ckxIsHabilitado.TabIndex = 38
        Me.ckxIsHabilitado.UseVisualStyleBackColor = True
        '
        'AgregarContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 136)
        Me.Controls.Add(Me.ckxIsHabilitado)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtIsHabilitado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescFormaContacto)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarContacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescFormaContacto As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIsHabilitado As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents cbxEmpresa As ComboBox
    Friend WithEvents ckxIsHabilitado As CheckBox
End Class
