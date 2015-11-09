<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seguimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seguimientos))
        Me.dtgSeguimientos = New System.Windows.Forms.DataGridView()
        Me.RegistroSeguimiento = New System.Windows.Forms.GroupBox()
        Me.cbxIsValido = New System.Windows.Forms.ComboBox()
        Me.cbxEfectiva = New System.Windows.Forms.ComboBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.txtDuracionLlamada = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtFechaSeguimiento = New System.Windows.Forms.TextBox()
        Me.txtNumLlamadas = New System.Windows.Forms.TextBox()
        Me.txtFechaHora = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.dtgSeguimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistroSeguimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgSeguimientos
        '
        Me.dtgSeguimientos.AllowUserToAddRows = False
        Me.dtgSeguimientos.AllowUserToDeleteRows = False
        Me.dtgSeguimientos.AllowUserToOrderColumns = True
        Me.dtgSeguimientos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dtgSeguimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgSeguimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSeguimientos.Location = New System.Drawing.Point(12, 41)
        Me.dtgSeguimientos.Name = "dtgSeguimientos"
        Me.dtgSeguimientos.ReadOnly = True
        Me.dtgSeguimientos.Size = New System.Drawing.Size(566, 146)
        Me.dtgSeguimientos.TabIndex = 0
        '
        'RegistroSeguimiento
        '
        Me.RegistroSeguimiento.Controls.Add(Me.cbxIsValido)
        Me.RegistroSeguimiento.Controls.Add(Me.cbxEfectiva)
        Me.RegistroSeguimiento.Controls.Add(Me.TextUsuario)
        Me.RegistroSeguimiento.Controls.Add(Me.txtDuracionLlamada)
        Me.RegistroSeguimiento.Controls.Add(Me.txtDescripcion)
        Me.RegistroSeguimiento.Controls.Add(Me.txtFechaSeguimiento)
        Me.RegistroSeguimiento.Controls.Add(Me.txtNumLlamadas)
        Me.RegistroSeguimiento.Controls.Add(Me.txtFechaHora)
        Me.RegistroSeguimiento.Controls.Add(Me.Label10)
        Me.RegistroSeguimiento.Controls.Add(Me.Label9)
        Me.RegistroSeguimiento.Controls.Add(Me.Label8)
        Me.RegistroSeguimiento.Controls.Add(Me.Label7)
        Me.RegistroSeguimiento.Controls.Add(Me.Label6)
        Me.RegistroSeguimiento.Controls.Add(Me.Label5)
        Me.RegistroSeguimiento.Controls.Add(Me.Label4)
        Me.RegistroSeguimiento.Controls.Add(Me.Label3)
        Me.RegistroSeguimiento.Controls.Add(Me.txtId)
        Me.RegistroSeguimiento.Controls.Add(Me.Label2)
        Me.RegistroSeguimiento.Controls.Add(Me.Label1)
        Me.RegistroSeguimiento.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroSeguimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegistroSeguimiento.Location = New System.Drawing.Point(12, 193)
        Me.RegistroSeguimiento.Name = "RegistroSeguimiento"
        Me.RegistroSeguimiento.Size = New System.Drawing.Size(566, 228)
        Me.RegistroSeguimiento.TabIndex = 1
        Me.RegistroSeguimiento.TabStop = False
        Me.RegistroSeguimiento.Text = "Registro de seguimiento"
        '
        'cbxIsValido
        '
        Me.cbxIsValido.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxIsValido.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxIsValido.FormattingEnabled = True
        Me.cbxIsValido.Location = New System.Drawing.Point(431, 96)
        Me.cbxIsValido.Name = "cbxIsValido"
        Me.cbxIsValido.Size = New System.Drawing.Size(126, 24)
        Me.cbxIsValido.TabIndex = 32
        '
        'cbxEfectiva
        '
        Me.cbxEfectiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxEfectiva.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxEfectiva.FormattingEnabled = True
        Me.cbxEfectiva.Location = New System.Drawing.Point(431, 70)
        Me.cbxEfectiva.Name = "cbxEfectiva"
        Me.cbxEfectiva.Size = New System.Drawing.Size(126, 24)
        Me.cbxEfectiva.TabIndex = 31
        '
        'TextUsuario
        '
        Me.TextUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextUsuario.Enabled = False
        Me.TextUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextUsuario.Location = New System.Drawing.Point(431, 122)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(126, 23)
        Me.TextUsuario.TabIndex = 23
        '
        'txtDuracionLlamada
        '
        Me.txtDuracionLlamada.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtDuracionLlamada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracionLlamada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtDuracionLlamada.Location = New System.Drawing.Point(431, 44)
        Me.txtDuracionLlamada.Name = "txtDuracionLlamada"
        Me.txtDuracionLlamada.Size = New System.Drawing.Size(126, 23)
        Me.txtDuracionLlamada.TabIndex = 20
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(149, 151)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 71)
        Me.txtDescripcion.TabIndex = 19
        '
        'txtFechaSeguimiento
        '
        Me.txtFechaSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtFechaSeguimiento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSeguimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtFechaSeguimiento.Location = New System.Drawing.Point(149, 122)
        Me.txtFechaSeguimiento.Name = "txtFechaSeguimiento"
        Me.txtFechaSeguimiento.Size = New System.Drawing.Size(126, 23)
        Me.txtFechaSeguimiento.TabIndex = 18
        '
        'txtNumLlamadas
        '
        Me.txtNumLlamadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtNumLlamadas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumLlamadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNumLlamadas.Location = New System.Drawing.Point(149, 96)
        Me.txtNumLlamadas.Name = "txtNumLlamadas"
        Me.txtNumLlamadas.Size = New System.Drawing.Size(126, 23)
        Me.txtNumLlamadas.TabIndex = 17
        '
        'txtFechaHora
        '
        Me.txtFechaHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtFechaHora.Enabled = False
        Me.txtFechaHora.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtFechaHora.Location = New System.Drawing.Point(149, 70)
        Me.txtFechaHora.Name = "txtFechaHora"
        Me.txtFechaHora.Size = New System.Drawing.Size(126, 23)
        Me.txtFechaHora.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(290, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Usuario"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(290, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Contacto válido:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Efectiva:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(290, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Duración llamada:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha seguimiento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Número llamadas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha/hora:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(149, 44)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(126, 23)
        Me.txtId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 5)
        Me.Label1.TabIndex = 0
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Silver
        Me.btnRegistrar.Location = New System.Drawing.Point(496, 427)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(73, 27)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Silver
        Me.btnNuevo.Location = New System.Drawing.Point(417, 427)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(73, 27)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Seguimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 460)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.RegistroSeguimiento)
        Me.Controls.Add(Me.dtgSeguimientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Seguimientos"
        Me.Text = "Seguimientos"
        CType(Me.dtgSeguimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistroSeguimiento.ResumeLayout(False)
        Me.RegistroSeguimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgSeguimientos As DataGridView
    Friend WithEvents RegistroSeguimiento As GroupBox
    Friend WithEvents txtDuracionLlamada As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtFechaSeguimiento As TextBox
    Friend WithEvents txtNumLlamadas As TextBox
    Friend WithEvents txtFechaHora As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cbxIsValido As ComboBox
    Friend WithEvents cbxEfectiva As ComboBox
    Friend WithEvents btnNuevo As Button
End Class
