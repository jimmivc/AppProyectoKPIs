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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreacionKPIs))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.descKPI = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registrar Indicador KPI"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Objetivo :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripcion : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 128)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(363, 29)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(14, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(469, 10)
        Me.Label4.TabIndex = 6
        '
        'txtObjetivo
        '
        Me.txtObjetivo.BackColor = System.Drawing.SystemColors.Control
        Me.txtObjetivo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObjetivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtObjetivo.Location = New System.Drawing.Point(120, 178)
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.Size = New System.Drawing.Size(121, 29)
        Me.txtObjetivo.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 22)
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
        Me.Button1.Location = New System.Drawing.Point(554, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 26)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descKPI})
        Me.DataGridView1.Location = New System.Drawing.Point(745, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(290, 372)
        Me.DataGridView1.TabIndex = 17
        '
        'descKPI
        '
        Me.descKPI.HeaderText = "Descripcion"
        Me.descKPI.Name = "descKPI"
        Me.descKPI.ReadOnly = True
        '
        'lstCampo
        '
        Me.lstCampo.AutoCompleteCustomSource.AddRange(New String() {"Llamadas", "Llamadas Efectivas"})
        Me.lstCampo.FormattingEnabled = True
        Me.lstCampo.Items.AddRange(New Object() {"", "Llamadas", "Llamadas efectivas"})
        Me.lstCampo.Location = New System.Drawing.Point(19, 298)
        Me.lstCampo.Name = "lstCampo"
        Me.lstCampo.Size = New System.Drawing.Size(121, 26)
        Me.lstCampo.TabIndex = 18
        '
        'btnRestar
        '
        Me.btnRestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRestar.FlatAppearance.BorderSize = 0
        Me.btnRestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnRestar.ForeColor = System.Drawing.Color.Silver
        Me.btnRestar.Location = New System.Drawing.Point(401, 298)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(27, 26)
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
        Me.btnDividir.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnDividir.ForeColor = System.Drawing.Color.Silver
        Me.btnDividir.Location = New System.Drawing.Point(444, 298)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(27, 26)
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
        Me.btnSumar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnSumar.ForeColor = System.Drawing.Color.Silver
        Me.btnSumar.Location = New System.Drawing.Point(357, 298)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(27, 26)
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
        Me.btnAgregarValor.Location = New System.Drawing.Point(260, 295)
        Me.btnAgregarValor.Name = "btnAgregarValor"
        Me.btnAgregarValor.Size = New System.Drawing.Size(81, 29)
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
        Me.btnMultiplicar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnMultiplicar.ForeColor = System.Drawing.Color.Silver
        Me.btnMultiplicar.Location = New System.Drawing.Point(487, 298)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(27, 26)
        Me.btnMultiplicar.TabIndex = 16
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = False
        '
        'txtFormula
        '
        Me.txtFormula.Location = New System.Drawing.Point(19, 357)
        Me.txtFormula.Multiline = True
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(495, 73)
        Me.txtFormula.TabIndex = 20
        '
        'lstFormatoKPI
        '
        Me.lstFormatoKPI.FormattingEnabled = True
        Me.lstFormatoKPI.Location = New System.Drawing.Point(120, 229)
        Me.lstFormatoKPI.Name = "lstFormatoKPI"
        Me.lstFormatoKPI.Size = New System.Drawing.Size(121, 26)
        Me.lstFormatoKPI.TabIndex = 21
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Control
        Me.txtValor.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(158, 295)
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
        Me.btnConfigurar.Location = New System.Drawing.Point(260, 181)
        Me.btnConfigurar.Name = "btnConfigurar"
        Me.btnConfigurar.Size = New System.Drawing.Size(100, 27)
        Me.btnConfigurar.TabIndex = 16
        Me.btnConfigurar.Text = "Configurar"
        Me.btnConfigurar.UseVisualStyleBackColor = False
        '
        'CreacionKPIs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 563)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lstFormatoKPI)
        Me.Controls.Add(Me.txtFormula)
        Me.Controls.Add(Me.lstCampo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnConfigurar)
        Me.Controls.Add(Me.btnAgregarValor)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtObjetivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreacionKPIs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lstCampo As System.Windows.Forms.ComboBox
    Friend WithEvents btnRestar As System.Windows.Forms.Button
    Friend WithEvents btnDividir As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarValor As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
    Friend WithEvents txtFormula As System.Windows.Forms.TextBox
    Friend WithEvents lstFormatoKPI As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents descKPI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnConfigurar As System.Windows.Forms.Button
End Class
