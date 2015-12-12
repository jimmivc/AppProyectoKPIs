<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesKPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesKPI))
        Me.dtgRoles = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgResultados = New System.Windows.Forms.DataGridView()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Formato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Objetivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resultados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroMercadeoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dtgRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroMercadeoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgRoles
        '
        Me.dtgRoles.AllowUserToAddRows = False
        Me.dtgRoles.AllowUserToDeleteRows = False
        Me.dtgRoles.AutoGenerateColumns = False
        Me.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn})
        Me.dtgRoles.DataSource = Me.RolBindingSource
        Me.dtgRoles.Location = New System.Drawing.Point(12, 218)
        Me.dtgRoles.Name = "dtgRoles"
        Me.dtgRoles.ReadOnly = True
        Me.dtgRoles.RowTemplate.Height = 24
        Me.dtgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgRoles.Size = New System.Drawing.Size(264, 370)
        Me.dtgRoles.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(9, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(469, 11)
        Me.Label4.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 38)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Roles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 38)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Asignar Indicadores KPI"
        '
        'dtgResultados
        '
        Me.dtgResultados.AllowUserToAddRows = False
        Me.dtgResultados.AllowUserToDeleteRows = False
        Me.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.usuario, Me.Formato, Me.Objetivo, Me.resultados, Me.color})
        Me.dtgResultados.Enabled = False
        Me.dtgResultados.Location = New System.Drawing.Point(323, 218)
        Me.dtgResultados.Name = "dtgResultados"
        Me.dtgResultados.ReadOnly = True
        Me.dtgResultados.RowTemplate.Height = 24
        Me.dtgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgResultados.Size = New System.Drawing.Size(827, 370)
        Me.dtgResultados.TabIndex = 0
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 150
        '
        'Formato
        '
        Me.Formato.HeaderText = "Formato"
        Me.Formato.Name = "Formato"
        Me.Formato.ReadOnly = True
        '
        'Objetivo
        '
        Me.Objetivo.HeaderText = "Objetivo"
        Me.Objetivo.Name = "Objetivo"
        Me.Objetivo.ReadOnly = True
        '
        'resultados
        '
        Me.resultados.HeaderText = "Resultado"
        Me.resultados.Name = "resultados"
        Me.resultados.ReadOnly = True
        '
        'color
        '
        Me.color.HeaderText = ""
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(319, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(831, 38)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Resultados Indicadores KPI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'RegistroMercadeoBindingSource
        '
        Me.RegistroMercadeoBindingSource.DataSource = GetType(AppProyectoKPI.RegistroMercadeo)
        '
        'ReportesKPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 612)
        Me.Controls.Add(Me.dtgRoles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgResultados)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportesKPI"
        Me.Text = "ReportesKPI"
        CType(Me.dtgRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroMercadeoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgRoles As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtgResultados As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistroMercadeoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Formato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Objetivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resultados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
