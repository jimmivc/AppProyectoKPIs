<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVenta
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
        Me.RegistroProspecto = New System.Windows.Forms.GroupBox()
        Me.TextVendedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BuscarCliente = New System.Windows.Forms.Button()
        Me.textFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextIdMercadeo = New System.Windows.Forms.TextBox()
        Me.ComboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.ComboBoxPeriodo = New System.Windows.Forms.ComboBox()
        Me.TextMonto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistrarVenta = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.RegistroProspecto.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistroProspecto
        '
        Me.RegistroProspecto.Controls.Add(Me.TextVendedor)
        Me.RegistroProspecto.Controls.Add(Me.Label9)
        Me.RegistroProspecto.Controls.Add(Me.Label10)
        Me.RegistroProspecto.Controls.Add(Me.BuscarCliente)
        Me.RegistroProspecto.Controls.Add(Me.textFecha)
        Me.RegistroProspecto.Controls.Add(Me.TextIdMercadeo)
        Me.RegistroProspecto.Controls.Add(Me.ComboCategoria)
        Me.RegistroProspecto.Controls.Add(Me.Label8)
        Me.RegistroProspecto.Controls.Add(Me.TextDescripcion)
        Me.RegistroProspecto.Controls.Add(Me.ComboBoxPeriodo)
        Me.RegistroProspecto.Controls.Add(Me.TextMonto)
        Me.RegistroProspecto.Controls.Add(Me.Label7)
        Me.RegistroProspecto.Controls.Add(Me.TextBuscar)
        Me.RegistroProspecto.Controls.Add(Me.Label6)
        Me.RegistroProspecto.Controls.Add(Me.Label5)
        Me.RegistroProspecto.Controls.Add(Me.Label4)
        Me.RegistroProspecto.Controls.Add(Me.Label3)
        Me.RegistroProspecto.Controls.Add(Me.Label1)
        Me.RegistroProspecto.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroProspecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegistroProspecto.Location = New System.Drawing.Point(116, 72)
        Me.RegistroProspecto.Name = "RegistroProspecto"
        Me.RegistroProspecto.Size = New System.Drawing.Size(405, 309)
        Me.RegistroProspecto.TabIndex = 3
        Me.RegistroProspecto.TabStop = False
        Me.RegistroProspecto.Text = "Registro de Ventas"
        '
        'TextVendedor
        '
        Me.TextVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextVendedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextVendedor.Location = New System.Drawing.Point(164, 253)
        Me.TextVendedor.Name = "TextVendedor"
        Me.TextVendedor.Size = New System.Drawing.Size(183, 23)
        Me.TextVendedor.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 21)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Nombre Vendedor:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 21)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Nombre Cliente:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BuscarCliente
        '
        Me.BuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BuscarCliente.FlatAppearance.BorderSize = 0
        Me.BuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarCliente.Font = New System.Drawing.Font("Arial Unicode MS", 10.5!)
        Me.BuscarCliente.ForeColor = System.Drawing.Color.Silver
        Me.BuscarCliente.Location = New System.Drawing.Point(308, 205)
        Me.BuscarCliente.Name = "BuscarCliente"
        Me.BuscarCliente.Size = New System.Drawing.Size(39, 23)
        Me.BuscarCliente.TabIndex = 39
        Me.BuscarCliente.Text = ". . ."
        Me.BuscarCliente.UseVisualStyleBackColor = False
        '
        'textFecha
        '
        Me.textFecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark
        Me.textFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.textFecha.Location = New System.Drawing.Point(165, 73)
        Me.textFecha.Name = "textFecha"
        Me.textFecha.Size = New System.Drawing.Size(183, 23)
        Me.textFecha.TabIndex = 40
        '
        'TextIdMercadeo
        '
        Me.TextIdMercadeo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextIdMercadeo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextIdMercadeo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextIdMercadeo.Location = New System.Drawing.Point(164, 229)
        Me.TextIdMercadeo.Name = "TextIdMercadeo"
        Me.TextIdMercadeo.Size = New System.Drawing.Size(183, 23)
        Me.TextIdMercadeo.TabIndex = 39
        '
        'ComboCategoria
        '
        Me.ComboCategoria.AutoCompleteCustomSource.AddRange(New String() {"Carrera", "Estudio Continuo"})
        Me.ComboCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ComboCategoria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCategoria.FormattingEnabled = True
        Me.ComboCategoria.Items.AddRange(New Object() {"Carrera", "Educacion Continua"})
        Me.ComboCategoria.Location = New System.Drawing.Point(165, 124)
        Me.ComboCategoria.Name = "ComboCategoria"
        Me.ComboCategoria.Size = New System.Drawing.Size(182, 25)
        Me.ComboCategoria.TabIndex = 33
        Me.ComboCategoria.Text = "Carrera"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 21)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Categorias:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextDescripcion
        '
        Me.TextDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextDescripcion.Location = New System.Drawing.Point(164, 153)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(183, 23)
        Me.TextDescripcion.TabIndex = 19
        '
        'ComboBoxPeriodo
        '
        Me.ComboBoxPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ComboBoxPeriodo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPeriodo.FormattingEnabled = True
        Me.ComboBoxPeriodo.Items.AddRange(New Object() {"Primer Cuatrimeste I ", "Segundo Cuatrimestre II", "Tercer Cuatrimestre III"})
        Me.ComboBoxPeriodo.Location = New System.Drawing.Point(165, 98)
        Me.ComboBoxPeriodo.Name = "ComboBoxPeriodo"
        Me.ComboBoxPeriodo.Size = New System.Drawing.Size(182, 25)
        Me.ComboBoxPeriodo.TabIndex = 29
        Me.ComboBoxPeriodo.Text = "Primer Cuatrimeste I "
        '
        'TextMonto
        '
        Me.TextMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextMonto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextMonto.Location = New System.Drawing.Point(164, 181)
        Me.TextMonto.Name = "TextMonto"
        Me.TextMonto.Size = New System.Drawing.Size(183, 23)
        Me.TextMonto.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Monto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBuscar
        '
        Me.TextBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBuscar.Location = New System.Drawing.Point(164, 205)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(142, 23)
        Me.TextBuscar.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripcion:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Identificacion Cliente:"
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
        Me.Label4.Text = "Periodo Lectivo:"
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
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 5)
        Me.Label1.TabIndex = 0
        '
        'BtnRegistrarVenta
        '
        Me.BtnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRegistrarVenta.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarVenta.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.BtnRegistrarVenta.ForeColor = System.Drawing.Color.Silver
        Me.BtnRegistrarVenta.Location = New System.Drawing.Point(196, 417)
        Me.BtnRegistrarVenta.Name = "BtnRegistrarVenta"
        Me.BtnRegistrarVenta.Size = New System.Drawing.Size(95, 31)
        Me.BtnRegistrarVenta.TabIndex = 19
        Me.BtnRegistrarVenta.Text = "Registrar"
        Me.BtnRegistrarVenta.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Silver
        Me.BtnCancelar.Location = New System.Drawing.Point(328, 417)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 31)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'RegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 516)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrarVenta)
        Me.Controls.Add(Me.RegistroProspecto)
        Me.Name = "RegistrarVenta"
        Me.Text = "Registrar Venta"
        Me.RegistroProspecto.ResumeLayout(False)
        Me.RegistroProspecto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegistroProspecto As GroupBox
    Friend WithEvents TextVendedor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BuscarCliente As Button
    Friend WithEvents textFecha As DateTimePicker
    Friend WithEvents TextIdMercadeo As TextBox
    Friend WithEvents ComboCategoria As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents ComboBoxPeriodo As ComboBox
    Friend WithEvents TextMonto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegistrarVenta As Button
    Friend WithEvents BtnCancelar As Button
End Class
