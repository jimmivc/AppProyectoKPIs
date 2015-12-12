<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roles))
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgRoles = New System.Windows.Forms.DataGridView()
        Me.RolIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgPermisos = New System.Windows.Forms.DataGridView()
        Me.PermisoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnEditarRol = New System.Windows.Forms.Button()
        Me.PermisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Silver
        Me.btnRegistrar.Location = New System.Drawing.Point(552, 521)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(103, 30)
        Me.btnRegistrar.TabIndex = 19
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Registrar Rol"
        '
        'dtgRoles
        '
        Me.dtgRoles.AutoGenerateColumns = False
        Me.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RolIDDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dtgRoles.DataSource = Me.RolBindingSource
        Me.dtgRoles.Location = New System.Drawing.Point(24, 69)
        Me.dtgRoles.Name = "dtgRoles"
        Me.dtgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgRoles.Size = New System.Drawing.Size(492, 303)
        Me.dtgRoles.TabIndex = 23
        '
        'RolIDDataGridViewTextBoxColumn
        '
        Me.RolIDDataGridViewTextBoxColumn.DataPropertyName = "RolID"
        Me.RolIDDataGridViewTextBoxColumn.HeaderText = "RolID"
        Me.RolIDDataGridViewTextBoxColumn.Name = "RolIDDataGridViewTextBoxColumn"
        Me.RolIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.RolIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataSource = GetType(AppProyectoKPI.Rol)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 26)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Listado de Roles"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(548, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 26)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Permisos de Rol"
        '
        'dtgPermisos
        '
        Me.dtgPermisos.AllowUserToDeleteRows = False
        Me.dtgPermisos.AllowUserToResizeColumns = False
        Me.dtgPermisos.AutoGenerateColumns = False
        Me.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PermisoIDDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PAccionDataGridViewTextBoxColumn})
        Me.dtgPermisos.DataSource = Me.PermisoBindingSource1
        Me.dtgPermisos.Location = New System.Drawing.Point(552, 69)
        Me.dtgPermisos.Name = "dtgPermisos"
        Me.dtgPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgPermisos.Size = New System.Drawing.Size(569, 303)
        Me.dtgPermisos.TabIndex = 27
        '
        'PermisoBindingSource1
        '
        Me.PermisoBindingSource1.DataSource = GetType(AppProyectoKPI.Permiso)
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.BackColor = System.Drawing.SystemColors.Control
        Me.txtBoxNombre.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBoxNombre.Location = New System.Drawing.Point(153, 521)
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(363, 25)
        Me.txtBoxNombre.TabIndex = 29
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblNombre.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(21, 521)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(103, 24)
        Me.lblNombre.TabIndex = 28
        Me.lblNombre.Text = "Nombre :"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEditarRol
        '
        Me.btnEditarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEditarRol.FlatAppearance.BorderSize = 0
        Me.btnEditarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnEditarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarRol.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnEditarRol.ForeColor = System.Drawing.Color.Silver
        Me.btnEditarRol.Location = New System.Drawing.Point(24, 409)
        Me.btnEditarRol.Name = "btnEditarRol"
        Me.btnEditarRol.Size = New System.Drawing.Size(119, 30)
        Me.btnEditarRol.TabIndex = 31
        Me.btnEditarRol.Text = "Editar Rol"
        Me.btnEditarRol.UseVisualStyleBackColor = False
        '
        'PermisoBindingSource
        '
        Me.PermisoBindingSource.DataSource = GetType(AppProyectoKPI.Permiso)
        '
        'PermisoIDDataGridViewTextBoxColumn
        '
        Me.PermisoIDDataGridViewTextBoxColumn.DataPropertyName = "PermisoID"
        Me.PermisoIDDataGridViewTextBoxColumn.HeaderText = "PermisoID"
        Me.PermisoIDDataGridViewTextBoxColumn.Name = "PermisoIDDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'PAccionDataGridViewTextBoxColumn
        '
        Me.PAccionDataGridViewTextBoxColumn.DataPropertyName = "pAccion"
        Me.PAccionDataGridViewTextBoxColumn.HeaderText = "Accion"
        Me.PAccionDataGridViewTextBoxColumn.Name = "PAccionDataGridViewTextBoxColumn"
        '
        'Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 572)
        Me.Controls.Add(Me.btnEditarRol)
        Me.Controls.Add(Me.txtBoxNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.dtgPermisos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgRoles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1160, 610)
        Me.MinimumSize = New System.Drawing.Size(1160, 610)
        Me.Name = "Roles"
        Me.Text = "Roles"
        CType(Me.dtgRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgRoles As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgPermisos As DataGridView
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents IdPermisoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PermisoBindingSource As BindingSource
    Friend WithEvents txtBoxNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnEditarRol As Button
    Friend WithEvents RolIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PermisoBindingSource1 As BindingSource
    Friend WithEvents PermisoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
