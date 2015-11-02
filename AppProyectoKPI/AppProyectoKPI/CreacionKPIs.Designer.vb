<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarKPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarKPI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtgListarKPIs = New System.Windows.Forms.DataGridView()
        Me.lstCampo = New System.Windows.Forms.ComboBox()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnAgregarValor = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.txtFormula = New System.Windows.Forms.TextBox()
        Me.lstFormatoKPI = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnConfigurar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.DescKpiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjetivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dtgListarKPIs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Registrar Indicador KPI"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Objetivo :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripcion : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 142)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(363, 29)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(14, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(469, 11)
        Me.Label4.TabIndex = 6
        '
        'txtObjetivo
        '
        Me.txtObjetivo.BackColor = System.Drawing.SystemColors.Control
        Me.txtObjetivo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObjetivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtObjetivo.Location = New System.Drawing.Point(120, 198)
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.Size = New System.Drawing.Size(121, 29)
        Me.txtObjetivo.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Formato :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(275, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtgListarKPIs
        '
        Me.dtgListarKPIs.AllowUserToAddRows = False
        Me.dtgListarKPIs.AllowUserToDeleteRows = False
        Me.dtgListarKPIs.AutoGenerateColumns = False
        Me.dtgListarKPIs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListarKPIs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescKpiDataGridViewTextBoxColumn, Me.FormatoDataGridViewTextBoxColumn, Me.ObjetivoDataGridViewTextBoxColumn})
        Me.dtgListarKPIs.DataSource = Me.KPIBindingSource
        Me.dtgListarKPIs.Location = New System.Drawing.Point(644, 99)
        Me.dtgListarKPIs.Name = "dtgListarKPIs"
        Me.dtgListarKPIs.ReadOnly = True
        Me.dtgListarKPIs.RowTemplate.Height = 24
        Me.dtgListarKPIs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListarKPIs.Size = New System.Drawing.Size(446, 379)
        Me.dtgListarKPIs.TabIndex = 17
        '
        'lstCampo
        '
        Me.lstCampo.AutoCompleteCustomSource.AddRange(New String() {"Llamadas", "Llamadas Efectivas"})
        Me.lstCampo.FormattingEnabled = True
        Me.lstCampo.Items.AddRange(New Object() {"", "Llamadas", "Llamadas efectivas"})
        Me.lstCampo.Location = New System.Drawing.Point(19, 331)
        Me.lstCampo.Name = "lstCampo"
        Me.lstCampo.Size = New System.Drawing.Size(121, 28)
        Me.lstCampo.TabIndex = 18
        '
        'btnRestar
        '
        Me.btnRestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRestar.FlatAppearance.BorderSize = 0
        Me.btnRestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestar.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.ForeColor = System.Drawing.Color.Silver
        Me.btnRestar.Location = New System.Drawing.Point(401, 331)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(27, 29)
        Me.btnRestar.TabIndex = 16
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = False
        '
        'btnDividir
        '
        Me.btnDividir.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDividir.FlatAppearance.BorderSize = 0
        Me.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDividir.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.ForeColor = System.Drawing.Color.Silver
        Me.btnDividir.Location = New System.Drawing.Point(444, 331)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(27, 29)
        Me.btnDividir.TabIndex = 16
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = False
        '
        'btnSumar
        '
        Me.btnSumar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSumar.FlatAppearance.BorderSize = 0
        Me.btnSumar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnSumar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumar.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumar.ForeColor = System.Drawing.Color.Silver
        Me.btnSumar.Location = New System.Drawing.Point(357, 331)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(27, 29)
        Me.btnSumar.TabIndex = 16
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = False
        '
        'btnAgregarValor
        '
        Me.btnAgregarValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAgregarValor.FlatAppearance.BorderSize = 0
        Me.btnAgregarValor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAgregarValor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAgregarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarValor.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnAgregarValor.ForeColor = System.Drawing.Color.Silver
        Me.btnAgregarValor.Location = New System.Drawing.Point(260, 328)
        Me.btnAgregarValor.Name = "btnAgregarValor"
        Me.btnAgregarValor.Size = New System.Drawing.Size(81, 32)
        Me.btnAgregarValor.TabIndex = 16
        Me.btnAgregarValor.Text = "agregar"
        Me.btnAgregarValor.UseVisualStyleBackColor = False
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnMultiplicar.FlatAppearance.BorderSize = 0
        Me.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiplicar.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.ForeColor = System.Drawing.Color.Silver
        Me.btnMultiplicar.Location = New System.Drawing.Point(487, 331)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(27, 29)
        Me.btnMultiplicar.TabIndex = 16
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = False
        '
        'txtFormula
        '
        Me.txtFormula.Location = New System.Drawing.Point(19, 397)
        Me.txtFormula.Multiline = True
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(495, 81)
        Me.txtFormula.TabIndex = 20
        '
        'lstFormatoKPI
        '
        Me.lstFormatoKPI.FormattingEnabled = True
        Me.lstFormatoKPI.Items.AddRange(New Object() {"%"})
        Me.lstFormatoKPI.Location = New System.Drawing.Point(120, 254)
        Me.lstFormatoKPI.Name = "lstFormatoKPI"
        Me.lstFormatoKPI.Size = New System.Drawing.Size(121, 28)
        Me.lstFormatoKPI.TabIndex = 21
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Control
        Me.txtValor.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(152, 332)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(93, 29)
        Me.txtValor.TabIndex = 22
        Me.txtValor.Tag = ""
        '
        'btnConfigurar
        '
        Me.btnConfigurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConfigurar.FlatAppearance.BorderSize = 0
        Me.btnConfigurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnConfigurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnConfigurar.ForeColor = System.Drawing.Color.Silver
        Me.btnConfigurar.Location = New System.Drawing.Point(260, 201)
        Me.btnConfigurar.Name = "btnConfigurar"
        Me.btnConfigurar.Size = New System.Drawing.Size(100, 30)
        Me.btnConfigurar.TabIndex = 16
        Me.btnConfigurar.Text = "Configurar"
        Me.btnConfigurar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(639, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(451, 38)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "KPIs Registrados"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.Silver
        Me.btnConsultar.Location = New System.Drawing.Point(644, 501)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 30)
        Me.btnConsultar.TabIndex = 24
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnModificar.ForeColor = System.Drawing.Color.Silver
        Me.btnModificar.Location = New System.Drawing.Point(823, 501)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.Silver
        Me.btnEliminar.Location = New System.Drawing.Point(990, 501)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Silver
        Me.btnBorrar.Location = New System.Drawing.Point(152, 502)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(88, 29)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'DescKpiDataGridViewTextBoxColumn
        '
        Me.DescKpiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescKpiDataGridViewTextBoxColumn.DataPropertyName = "DescKpi"
        Me.DescKpiDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescKpiDataGridViewTextBoxColumn.Name = "DescKpiDataGridViewTextBoxColumn"
        Me.DescKpiDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescKpiDataGridViewTextBoxColumn.Width = 112
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
        'CreacionKPIs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 626)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lstFormatoKPI)
        Me.Controls.Add(Me.txtFormula)
        Me.Controls.Add(Me.lstCampo)
        Me.Controls.Add(Me.dtgListarKPIs)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnConfigurar)
        Me.Controls.Add(Me.btnAgregarValor)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtObjetivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreacionKPIs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Principal"
        CType(Me.dtgListarKPIs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtObjetivo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dtgListarKPIs As System.Windows.Forms.DataGridView
    Friend WithEvents lstCampo As System.Windows.Forms.ComboBox
    Friend WithEvents btnRestar As System.Windows.Forms.Button
    Friend WithEvents btnDividir As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarValor As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
    Friend WithEvents txtFormula As System.Windows.Forms.TextBox
    Friend WithEvents lstFormatoKPI As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnConfigurar As System.Windows.Forms.Button
    Friend WithEvents KPIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescKpiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObjetivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
End Class
