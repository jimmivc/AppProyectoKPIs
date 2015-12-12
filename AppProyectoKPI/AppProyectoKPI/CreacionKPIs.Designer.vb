<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreacionKPIs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreacionKPIs))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
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
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblCampo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstPeriodicidad = New System.Windows.Forms.ComboBox()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.DescKpiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjetivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodicidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label1.Location = New System.Drawing.Point(10, 58)
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
        Me.Label2.Location = New System.Drawing.Point(11, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Objetivo :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 136)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(126, 128)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(363, 25)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(14, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(469, 11)
        Me.Label4.TabIndex = 6
        '
        'txtObjetivo
        '
        Me.txtObjetivo.BackColor = System.Drawing.SystemColors.Control
        Me.txtObjetivo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObjetivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtObjetivo.Location = New System.Drawing.Point(126, 187)
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.Size = New System.Drawing.Size(121, 25)
        Me.txtObjetivo.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Formato :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.btnRegistrar.Location = New System.Drawing.Point(275, 553)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(88, 29)
        Me.btnRegistrar.TabIndex = 16
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'dtgListarKPIs
        '
        Me.dtgListarKPIs.AllowUserToAddRows = False
        Me.dtgListarKPIs.AllowUserToDeleteRows = False
        Me.dtgListarKPIs.AutoGenerateColumns = False
        Me.dtgListarKPIs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListarKPIs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescKpiDataGridViewTextBoxColumn, Me.FormatoDataGridViewTextBoxColumn, Me.ObjetivoDataGridViewTextBoxColumn, Me.PeriodicidadDataGridViewTextBoxColumn})
        Me.dtgListarKPIs.DataSource = Me.KPIBindingSource
        Me.dtgListarKPIs.Location = New System.Drawing.Point(558, 99)
        Me.dtgListarKPIs.MultiSelect = False
        Me.dtgListarKPIs.Name = "dtgListarKPIs"
        Me.dtgListarKPIs.ReadOnly = True
        Me.dtgListarKPIs.RowTemplate.Height = 24
        Me.dtgListarKPIs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListarKPIs.Size = New System.Drawing.Size(517, 426)
        Me.dtgListarKPIs.TabIndex = 17
        '
        'lstCampo
        '
        Me.lstCampo.AutoCompleteCustomSource.AddRange(New String() {"Llamadas", "Llamadas Efectivas", "Promedio duracion llamadas efectivas", "Duracion llamadas efectivas", "Prospectos matriculados", "Monto ventas"})
        Me.lstCampo.FormattingEnabled = True
        Me.lstCampo.Items.AddRange(New Object() {"", "Llamadas", "Llamadas efectivas", "Promedio Duracion Efectivas", "Duracion Llamadas Efectivas", "Cantidad Ventas", "Monto Ventas"})
        Me.lstCampo.Location = New System.Drawing.Point(126, 363)
        Me.lstCampo.Name = "lstCampo"
        Me.lstCampo.Size = New System.Drawing.Size(223, 24)
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
        Me.btnRestar.Location = New System.Drawing.Point(406, 414)
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
        Me.btnDividir.Location = New System.Drawing.Point(353, 414)
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
        Me.btnSumar.Location = New System.Drawing.Point(456, 414)
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
        Me.btnAgregarValor.Location = New System.Drawing.Point(214, 410)
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
        Me.btnMultiplicar.Location = New System.Drawing.Point(304, 414)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(27, 29)
        Me.btnMultiplicar.TabIndex = 16
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = False
        '
        'txtFormula
        '
        Me.txtFormula.Location = New System.Drawing.Point(18, 461)
        Me.txtFormula.Multiline = True
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(465, 81)
        Me.txtFormula.TabIndex = 20
        '
        'lstFormatoKPI
        '
        Me.lstFormatoKPI.AutoCompleteCustomSource.AddRange(New String() {"%", "1234", "1234.56"})
        Me.lstFormatoKPI.FormattingEnabled = True
        Me.lstFormatoKPI.Items.AddRange(New Object() {"%", "123", "123.4"})
        Me.lstFormatoKPI.Location = New System.Drawing.Point(126, 233)
        Me.lstFormatoKPI.Name = "lstFormatoKPI"
        Me.lstFormatoKPI.Size = New System.Drawing.Size(121, 24)
        Me.lstFormatoKPI.TabIndex = 21
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Control
        Me.txtValor.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(126, 412)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(82, 25)
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
        Me.btnConfigurar.Location = New System.Drawing.Point(266, 190)
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
        Me.Label5.Location = New System.Drawing.Point(554, 58)
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
        Me.btnConsultar.Location = New System.Drawing.Point(558, 558)
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
        Me.btnModificar.Location = New System.Drawing.Point(777, 558)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDeshabilitar.FlatAppearance.BorderSize = 0
        Me.btnDeshabilitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnDeshabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeshabilitar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnDeshabilitar.ForeColor = System.Drawing.Color.Silver
        Me.btnDeshabilitar.Location = New System.Drawing.Point(974, 559)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(101, 30)
        Me.btnDeshabilitar.TabIndex = 24
        Me.btnDeshabilitar.Text = "Deshabilitar"
        Me.btnDeshabilitar.UseVisualStyleBackColor = False
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
        Me.btnBorrar.Location = New System.Drawing.Point(152, 553)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(88, 29)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Silver
        Me.btnGuardar.Location = New System.Drawing.Point(275, 552)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 29)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        Me.btnGuardar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.Silver
        Me.btnCancelar.Location = New System.Drawing.Point(777, 559)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'lblValor
        '
        Me.lblValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblValor.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblValor.Location = New System.Drawing.Point(14, 416)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(100, 24)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor :"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCampo
        '
        Me.lblCampo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCampo.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblCampo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblCampo.Location = New System.Drawing.Point(14, 365)
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(100, 24)
        Me.lblCampo.TabIndex = 8
        Me.lblCampo.Text = "Campo : "
        Me.lblCampo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(11, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 24)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Periodicidad :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstPeriodicidad
        '
        Me.lstPeriodicidad.AutoCompleteCustomSource.AddRange(New String() {"%", "1234", "1234.56"})
        Me.lstPeriodicidad.FormattingEnabled = True
        Me.lstPeriodicidad.Items.AddRange(New Object() {"mensual", "cuatrimestral", "anual"})
        Me.lstPeriodicidad.Location = New System.Drawing.Point(126, 280)
        Me.lstPeriodicidad.Name = "lstPeriodicidad"
        Me.lstPeriodicidad.Size = New System.Drawing.Size(121, 24)
        Me.lstPeriodicidad.TabIndex = 26
        '
        'lblFormula
        '
        Me.lblFormula.BackColor = System.Drawing.Color.Transparent
        Me.lblFormula.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblFormula.Location = New System.Drawing.Point(13, 322)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(451, 38)
        Me.lblFormula.TabIndex = 27
        Me.lblFormula.Text = "Crear formula"
        '
        'DescKpiDataGridViewTextBoxColumn
        '
        Me.DescKpiDataGridViewTextBoxColumn.DataPropertyName = "DescKpi"
        Me.DescKpiDataGridViewTextBoxColumn.HeaderText = "Descripcion"
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
        'PeriodicidadDataGridViewTextBoxColumn
        '
        Me.PeriodicidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PeriodicidadDataGridViewTextBoxColumn.DataPropertyName = "Periodicidad"
        Me.PeriodicidadDataGridViewTextBoxColumn.HeaderText = "Periodicidad"
        Me.PeriodicidadDataGridViewTextBoxColumn.Name = "PeriodicidadDataGridViewTextBoxColumn"
        Me.PeriodicidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KPIBindingSource
        '
        Me.KPIBindingSource.DataSource = GetType(AppProyectoKPI.KPI)
        '
        'CreacionKPIs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 612)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lstPeriodicidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDeshabilitar)
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
        Me.Controls.Add(Me.txtObjetivo)
        Me.Controls.Add(Me.lblCampo)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
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
    Friend WithEvents btnRegistrar As Button
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDeshabilitar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblCampo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstPeriodicidad As System.Windows.Forms.ComboBox
    Friend WithEvents DescKpiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObjetivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodicidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblFormula As System.Windows.Forms.Label
End Class
