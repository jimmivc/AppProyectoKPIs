<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProspectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionProspectos))
        Me.RegistroProspecto = New System.Windows.Forms.GroupBox()
        Me.cbxEstatus = New System.Windows.Forms.ComboBox()
        Me.cbxIsPromociones = New System.Windows.Forms.ComboBox()
        Me.cbxIsTrabajando = New System.Windows.Forms.ComboBox()
        Me.cbxEvento = New System.Windows.Forms.ComboBox()
        Me.txtLugarTrabajo = New System.Windows.Forms.TextBox()
        Me.txtLugarEstudio = New System.Windows.Forms.TextBox()
        Me.txtAnioBachillerato = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.btnListarProspectos = New System.Windows.Forms.Button()
        Me.FormasContacto = New System.Windows.Forms.GroupBox()
        Me.dtg_FormasContacto = New System.Windows.Forms.DataGridView()
        Me.pnlGestionProspectos = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.RegistroProspecto.SuspendLayout()
        Me.FormasContacto.SuspendLayout()
        CType(Me.dtg_FormasContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistroProspecto
        '
        Me.RegistroProspecto.Controls.Add(Me.cbxEstatus)
        Me.RegistroProspecto.Controls.Add(Me.cbxIsPromociones)
        Me.RegistroProspecto.Controls.Add(Me.cbxIsTrabajando)
        Me.RegistroProspecto.Controls.Add(Me.cbxEvento)
        Me.RegistroProspecto.Controls.Add(Me.txtLugarTrabajo)
        Me.RegistroProspecto.Controls.Add(Me.txtLugarEstudio)
        Me.RegistroProspecto.Controls.Add(Me.txtAnioBachillerato)
        Me.RegistroProspecto.Controls.Add(Me.txtFechaNac)
        Me.RegistroProspecto.Controls.Add(Me.txtEdad)
        Me.RegistroProspecto.Controls.Add(Me.txtApellidos)
        Me.RegistroProspecto.Controls.Add(Me.txtNombre)
        Me.RegistroProspecto.Controls.Add(Me.txtAlias)
        Me.RegistroProspecto.Controls.Add(Me.txtIdentificacion)
        Me.RegistroProspecto.Controls.Add(Me.Label15)
        Me.RegistroProspecto.Controls.Add(Me.Label14)
        Me.RegistroProspecto.Controls.Add(Me.Label13)
        Me.RegistroProspecto.Controls.Add(Me.Label12)
        Me.RegistroProspecto.Controls.Add(Me.Label11)
        Me.RegistroProspecto.Controls.Add(Me.Label10)
        Me.RegistroProspecto.Controls.Add(Me.Label9)
        Me.RegistroProspecto.Controls.Add(Me.Label8)
        Me.RegistroProspecto.Controls.Add(Me.Label7)
        Me.RegistroProspecto.Controls.Add(Me.Label6)
        Me.RegistroProspecto.Controls.Add(Me.Label5)
        Me.RegistroProspecto.Controls.Add(Me.Label4)
        Me.RegistroProspecto.Controls.Add(Me.Label3)
        Me.RegistroProspecto.Controls.Add(Me.txtId)
        Me.RegistroProspecto.Controls.Add(Me.Label2)
        Me.RegistroProspecto.Controls.Add(Me.Label1)
        Me.RegistroProspecto.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroProspecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegistroProspecto.Location = New System.Drawing.Point(6, 0)
        Me.RegistroProspecto.Name = "RegistroProspecto"
        Me.RegistroProspecto.Size = New System.Drawing.Size(360, 412)
        Me.RegistroProspecto.TabIndex = 0
        Me.RegistroProspecto.TabStop = False
        Me.RegistroProspecto.Text = "Registro de prospecto"
        '
        'cbxEstatus
        '
        Me.cbxEstatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxEstatus.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxEstatus.FormattingEnabled = True
        Me.cbxEstatus.Location = New System.Drawing.Point(167, 381)
        Me.cbxEstatus.Name = "cbxEstatus"
        Me.cbxEstatus.Size = New System.Drawing.Size(182, 24)
        Me.cbxEstatus.TabIndex = 32
        '
        'cbxIsPromociones
        '
        Me.cbxIsPromociones.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxIsPromociones.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxIsPromociones.FormattingEnabled = True
        Me.cbxIsPromociones.Location = New System.Drawing.Point(167, 303)
        Me.cbxIsPromociones.Name = "cbxIsPromociones"
        Me.cbxIsPromociones.Size = New System.Drawing.Size(182, 24)
        Me.cbxIsPromociones.TabIndex = 31
        '
        'cbxIsTrabajando
        '
        Me.cbxIsTrabajando.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxIsTrabajando.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxIsTrabajando.FormattingEnabled = True
        Me.cbxIsTrabajando.Location = New System.Drawing.Point(167, 277)
        Me.cbxIsTrabajando.Name = "cbxIsTrabajando"
        Me.cbxIsTrabajando.Size = New System.Drawing.Size(182, 24)
        Me.cbxIsTrabajando.TabIndex = 30
        '
        'cbxEvento
        '
        Me.cbxEvento.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbxEvento.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cbxEvento.FormattingEnabled = True
        Me.cbxEvento.Location = New System.Drawing.Point(167, 251)
        Me.cbxEvento.Name = "cbxEvento"
        Me.cbxEvento.Size = New System.Drawing.Size(182, 24)
        Me.cbxEvento.TabIndex = 29
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(167, 356)
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(182, 23)
        Me.txtLugarTrabajo.TabIndex = 27
        '
        'txtLugarEstudio
        '
        Me.txtLugarEstudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtLugarEstudio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtLugarEstudio.Location = New System.Drawing.Point(167, 330)
        Me.txtLugarEstudio.Name = "txtLugarEstudio"
        Me.txtLugarEstudio.Size = New System.Drawing.Size(182, 23)
        Me.txtLugarEstudio.TabIndex = 26
        '
        'txtAnioBachillerato
        '
        Me.txtAnioBachillerato.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtAnioBachillerato.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnioBachillerato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtAnioBachillerato.Location = New System.Drawing.Point(167, 226)
        Me.txtAnioBachillerato.Name = "txtAnioBachillerato"
        Me.txtAnioBachillerato.Size = New System.Drawing.Size(182, 23)
        Me.txtAnioBachillerato.TabIndex = 22
        '
        'txtFechaNac
        '
        Me.txtFechaNac.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtFechaNac.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtFechaNac.Location = New System.Drawing.Point(167, 200)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(182, 23)
        Me.txtFechaNac.TabIndex = 21
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtEdad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtEdad.Location = New System.Drawing.Point(167, 174)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(182, 23)
        Me.txtEdad.TabIndex = 20
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtApellidos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtApellidos.Location = New System.Drawing.Point(167, 148)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(182, 23)
        Me.txtApellidos.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(167, 122)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 23)
        Me.txtNombre.TabIndex = 18
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtAlias.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtAlias.Location = New System.Drawing.Point(167, 96)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(182, 23)
        Me.txtAlias.TabIndex = 17
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdentificacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtIdentificacion.Location = New System.Drawing.Point(167, 70)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(182, 23)
        Me.txtIdentificacion.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 384)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 21)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Está Habilitado:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 358)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 21)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Lugar trabajo:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 21)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Lugar estudio ante.:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 21)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Recibe promociones:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 21)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Trabaja:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Evento captación:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Año bachillerato:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha de nacimiento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Edad:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Apellidos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alias:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Identificación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(167, 44)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(182, 23)
        Me.txtId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
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
        Me.Label1.Size = New System.Drawing.Size(346, 5)
        Me.Label1.TabIndex = 0
        '
        'btnListarProspectos
        '
        Me.btnListarProspectos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnListarProspectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnListarProspectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnListarProspectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarProspectos.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnListarProspectos.ForeColor = System.Drawing.Color.Silver
        Me.btnListarProspectos.Location = New System.Drawing.Point(371, 44)
        Me.btnListarProspectos.Name = "btnListarProspectos"
        Me.btnListarProspectos.Size = New System.Drawing.Size(73, 27)
        Me.btnListarProspectos.TabIndex = 2
        Me.btnListarProspectos.Text = "Listar"
        Me.btnListarProspectos.UseVisualStyleBackColor = False
        '
        'FormasContacto
        '
        Me.FormasContacto.Controls.Add(Me.dtg_FormasContacto)
        Me.FormasContacto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormasContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormasContacto.Location = New System.Drawing.Point(6, 411)
        Me.FormasContacto.Name = "FormasContacto"
        Me.FormasContacto.Size = New System.Drawing.Size(360, 157)
        Me.FormasContacto.TabIndex = 1
        Me.FormasContacto.TabStop = False
        Me.FormasContacto.Text = "Formas de contacto"
        '
        'dtg_FormasContacto
        '
        Me.dtg_FormasContacto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dtg_FormasContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_FormasContacto.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dtg_FormasContacto.Location = New System.Drawing.Point(9, 24)
        Me.dtg_FormasContacto.Name = "dtg_FormasContacto"
        Me.dtg_FormasContacto.Size = New System.Drawing.Size(341, 128)
        Me.dtg_FormasContacto.TabIndex = 0
        '
        'pnlGestionProspectos
        '
        Me.pnlGestionProspectos.Location = New System.Drawing.Point(451, 5)
        Me.pnlGestionProspectos.Name = "pnlGestionProspectos"
        Me.pnlGestionProspectos.Size = New System.Drawing.Size(689, 564)
        Me.pnlGestionProspectos.TabIndex = 2
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Silver
        Me.btnRegistrar.Location = New System.Drawing.Point(371, 112)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(73, 27)
        Me.btnRegistrar.TabIndex = 3
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
        Me.btnNuevo.Location = New System.Drawing.Point(371, 78)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(73, 27)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'GestionProspectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1144, 571)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.pnlGestionProspectos)
        Me.Controls.Add(Me.FormasContacto)
        Me.Controls.Add(Me.RegistroProspecto)
        Me.Controls.Add(Me.btnListarProspectos)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GestionProspectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Prospectos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RegistroProspecto.ResumeLayout(False)
        Me.RegistroProspecto.PerformLayout()
        Me.FormasContacto.ResumeLayout(False)
        CType(Me.dtg_FormasContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegistroProspecto As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAnioBachillerato As TextBox
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents cbxEvento As ComboBox
    Friend WithEvents txtLugarTrabajo As TextBox
    Friend WithEvents txtLugarEstudio As TextBox
    Friend WithEvents FormasContacto As GroupBox
    Friend WithEvents dtg_FormasContacto As DataGridView
    Friend WithEvents btnListarProspectos As Button
    Friend WithEvents pnlGestionProspectos As Panel
    Friend WithEvents cbxEstatus As ComboBox
    Friend WithEvents cbxIsPromociones As ComboBox
    Friend WithEvents cbxIsTrabajando As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnNuevo As Button
End Class
