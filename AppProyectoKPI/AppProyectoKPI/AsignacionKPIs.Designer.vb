<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionKPIs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignacionKPIs))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAsignarKPI = New System.Windows.Forms.Button()
        Me.dtgRoles = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtgListarKPIs = New System.Windows.Forms.DataGridView()
        Me.DescKpiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjetivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtgIndicadoresAsignados = New System.Windows.Forms.DataGridView()
        Me.DescKpiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnQuitar = New System.Windows.Forms.Button()
        CType(Me.dtgRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgListarKPIs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgIndicadoresAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resultados Indicadores KPI"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(14, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(469, 11)
        Me.Label4.TabIndex = 6
        '
        'btnAsignarKPI
        '
        Me.btnAsignarKPI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAsignarKPI.FlatAppearance.BorderSize = 0
        Me.btnAsignarKPI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAsignarKPI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAsignarKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignarKPI.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnAsignarKPI.ForeColor = System.Drawing.Color.Silver
        Me.btnAsignarKPI.Location = New System.Drawing.Point(698, 342)
        Me.btnAsignarKPI.Name = "btnAsignarKPI"
        Me.btnAsignarKPI.Size = New System.Drawing.Size(95, 34)
        Me.btnAsignarKPI.TabIndex = 16
        Me.btnAsignarKPI.Text = "Asignar>>"
        Me.btnAsignarKPI.UseVisualStyleBackColor = False
        '
        'dtgRoles
        '
        Me.dtgRoles.AllowUserToAddRows = False
        Me.dtgRoles.AllowUserToDeleteRows = False
        Me.dtgRoles.AutoGenerateColumns = False
        Me.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn})
        Me.dtgRoles.DataSource = Me.RolBindingSource
        Me.dtgRoles.Location = New System.Drawing.Point(17, 214)
        Me.dtgRoles.Name = "dtgRoles"
        Me.dtgRoles.ReadOnly = True
        Me.dtgRoles.RowTemplate.Height = 24
        Me.dtgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgRoles.Size = New System.Drawing.Size(264, 386)
        Me.dtgRoles.TabIndex = 17
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataSource = GetType(AppProyectoKPI.Rol)
        '
        'dtgListarKPIs
        '
        Me.dtgListarKPIs.AllowUserToAddRows = False
        Me.dtgListarKPIs.AllowUserToDeleteRows = False
        Me.dtgListarKPIs.AutoGenerateColumns = False
        Me.dtgListarKPIs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListarKPIs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescKpiDataGridViewTextBoxColumn, Me.FormatoDataGridViewTextBoxColumn, Me.ObjetivoDataGridViewTextBoxColumn})
        Me.dtgListarKPIs.DataSource = Me.KPIBindingSource
        Me.dtgListarKPIs.Location = New System.Drawing.Point(297, 214)
        Me.dtgListarKPIs.Name = "dtgListarKPIs"
        Me.dtgListarKPIs.ReadOnly = True
        Me.dtgListarKPIs.RowTemplate.Height = 24
        Me.dtgListarKPIs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListarKPIs.Size = New System.Drawing.Size(395, 386)
        Me.dtgListarKPIs.TabIndex = 22
        '
        'DescKpiDataGridViewTextBoxColumn
        '
        Me.DescKpiDataGridViewTextBoxColumn.DataPropertyName = "DescKpi"
        Me.DescKpiDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescKpiDataGridViewTextBoxColumn.Name = "DescKpiDataGridViewTextBoxColumn"
        Me.DescKpiDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescKpiDataGridViewTextBoxColumn.Width = 150
        '
        'FormatoDataGridViewTextBoxColumn
        '
        Me.FormatoDataGridViewTextBoxColumn.DataPropertyName = "Formato"
        Me.FormatoDataGridViewTextBoxColumn.HeaderText = "Formato"
        Me.FormatoDataGridViewTextBoxColumn.Name = "FormatoDataGridViewTextBoxColumn"
        Me.FormatoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObjetivoDataGridViewTextBoxColumn
        '
        Me.ObjetivoDataGridViewTextBoxColumn.DataPropertyName = "Objetivo"
        Me.ObjetivoDataGridViewTextBoxColumn.HeaderText = "Objetivo"
        Me.ObjetivoDataGridViewTextBoxColumn.Name = "ObjetivoDataGridViewTextBoxColumn"
        Me.ObjetivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KPIBindingSource
        '
        Me.KPIBindingSource.DataSource = GetType(AppProyectoKPI.KPI)
        '
        'dtgIndicadoresAsignados
        '
        Me.dtgIndicadoresAsignados.AllowUserToAddRows = False
        Me.dtgIndicadoresAsignados.AllowUserToDeleteRows = False
        Me.dtgIndicadoresAsignados.AutoGenerateColumns = False
        Me.dtgIndicadoresAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgIndicadoresAsignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescKpiDataGridViewTextBoxColumn1, Me.EstadoDataGridViewCheckBoxColumn})
        Me.dtgIndicadoresAsignados.DataSource = Me.KPIBindingSource
        Me.dtgIndicadoresAsignados.Location = New System.Drawing.Point(799, 214)
        Me.dtgIndicadoresAsignados.Name = "dtgIndicadoresAsignados"
        Me.dtgIndicadoresAsignados.ReadOnly = True
        Me.dtgIndicadoresAsignados.RowTemplate.Height = 24
        Me.dtgIndicadoresAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgIndicadoresAsignados.Size = New System.Drawing.Size(341, 386)
        Me.dtgIndicadoresAsignados.TabIndex = 22
        '
        'DescKpiDataGridViewTextBoxColumn1
        '
        Me.DescKpiDataGridViewTextBoxColumn1.DataPropertyName = "DescKpi"
        Me.DescKpiDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DescKpiDataGridViewTextBoxColumn1.Name = "DescKpiDataGridViewTextBoxColumn1"
        Me.DescKpiDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DescKpiDataGridViewTextBoxColumn1.Width = 150
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        Me.EstadoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(292, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Indicadores KPI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 38)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Roles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(811, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 38)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Indicadores asignados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormulaBindingSource
        '
        Me.FormulaBindingSource.DataMember = "Formula"
        Me.FormulaBindingSource.DataSource = Me.KPIBindingSource
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnQuitar.ForeColor = System.Drawing.Color.Silver
        Me.btnQuitar.Location = New System.Drawing.Point(698, 393)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(95, 34)
        Me.btnQuitar.TabIndex = 23
        Me.btnQuitar.Text = "<<Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'AsignacionKPIs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 612)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.dtgIndicadoresAsignados)
        Me.Controls.Add(Me.dtgListarKPIs)
        Me.Controls.Add(Me.dtgRoles)
        Me.Controls.Add(Me.btnAsignarKPI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AsignacionKPIs"
        Me.Text = "Principal"
        CType(Me.dtgRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgListarKPIs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgIndicadoresAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAsignarKPI As Button
    Friend WithEvents dtgRoles As System.Windows.Forms.DataGridView
    Friend WithEvents dtgListarKPIs As System.Windows.Forms.DataGridView
    Friend WithEvents dtgIndicadoresAsignados As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KPIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescKpiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObjetivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormulaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescKpiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
End Class
