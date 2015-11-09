Public Class Seguimientos
    Private gestionProspectos As GestionProspectos


    Public Sub New(ByRef gestion As GestionProspectos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gestionProspectos = gestion

    End Sub
    Private Sub Seguimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararComboBoxBooleano(cbxEfectiva)
        PrepararComboBoxBooleano(cbxIsValido)
    End Sub

    Private Sub dtgSeguimientos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSeguimientos.CellClick
        Dim i As Integer
        i = dtgSeguimientos.CurrentRow.Index
        Me.cargarSeguimientoPantalla(dtgSeguimientos.Item(0, i).Value)
        gestionProspectos.LimpiarFormaContacto()
    End Sub

    Public Sub cargarSeguimientoPantalla(ByVal id As Integer)
        PrepararComboBoxBooleano(cbxEfectiva)
        PrepararComboBoxBooleano(cbxIsValido)
        Dim response = SeguimientoBL.ObtenerSeguimiento(id)
        If (response.SeguimientoID = Nothing) Then
            MsgBox("Seleccionó un prospecto vacío")
        Else
            Me.txtId.Text = response.SeguimientoID
            Me.txtFechaSeguimiento.Text = response.FechaSeguimiento
            Me.txtFechaHora.Text = response.FechaHora
            Me.txtNumLlamadas.Text = response.NumeroLlamadas
            Me.txtDescripcion.Text = response.DescSeguimiento
            Me.txtDuracionLlamada.Text = response.DuracionLlamadaMinutos
            Me.cbxEfectiva.SelectedValue = response.IsEfectiva
            Me.cbxIsValido.SelectedValue = response.IsFormaContactoValida

        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim pasaVerificacion As Boolean = False
        If (txtId.Text = "") Then
            If (Me.txtDescripcion.Text = "") Then
                MsgBox("Debe incluir una descripción para grabar")
            Else
                Dim numeroLlamadas As Integer
                If (Me.txtNumLlamadas.Text = "") Then
                    MsgBox("Debe incluir una cantidad de intentos de comunicación en el número de llamadas")
                Else
                    Dim duracion As Integer
                    If (Me.txtDuracionLlamada.Text = "") Then
                        duracion = 0
                    Else
                        duracion = CInt(txtDuracionLlamada.Text)
                    End If

                    numeroLlamadas = txtNumLlamadas.Text
                    Dim id = 0
                    Dim fechaHora = DateTime.Now
                    Dim fechaSeguimiento As DateTime
                    If (txtFechaSeguimiento.Text = "") Then
                        fechaSeguimiento = DateTime.Now
                    Else
                        fechaSeguimiento = CDate(txtFechaSeguimiento.Text)
                    End If
                    Dim descSeguimiento = txtDescripcion.Text
                    Dim isEfectiva As Boolean = False
                    If (cbxEfectiva.SelectedValue = True Or cbxEfectiva.SelectedValue = False) Then
                        isEfectiva = cbxEfectiva.SelectedValue
                    End If
                    Dim isContactoValido = cbxIsValido.SelectedValue
                    Dim usuario As New Usuario()
                    usuario.UsuarioID = 5
                    usuario.Nombre = "Admin"
                    Dim response = ProspectoBL.ObtenerProspecto(gestionProspectos.getProspectoId())
                    If (response Is Nothing) Then
                        MsgBox("Seleccionó un prospecto vacío")
                    Else
                        Dim grabado =
                            SeguimientoBL.RegistrarSeguimiento(id, fechaHora, fechaSeguimiento, response, descSeguimiento, numeroLlamadas,
                            duracion, isEfectiva, isContactoValido, usuario)
                        If (grabado = True) Then
                            MsgBox("Registro guardado satisfactoriamente")
                            gestionProspectos.btnSeguimiento_Click(sender, e)
                            Me.btnNuevo_Click(sender, e)
                        Else
                            MsgBox("No se pudo guardar el registro")
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Los registros de seguimiento no pueden ser modificados")
        End If


    End Sub

    Private Sub Limpiar_Formulario(ByVal f As Object)
        ' recorrer todos los controles del formulario indicado  

        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = “” ' eliminar el texto  
            End If
        Next

    End Sub

    Private Sub PrepararComboBoxBooleano(ByRef cbx As ComboBox)
        Dim dt As DataTable
        dt = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = True
        dr(1) = "SI"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = False
        dr(1) = "No"
        dt.Rows.Add(dr)

        cbx.DataSource = dt
        cbx.ValueMember = "Codigo"
        cbx.DisplayMember = "Descripcion"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar_Formulario(Me.RegistroSeguimiento)
        txtNumLlamadas.Focus()
    End Sub

    Private Sub txtNumLlamadas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumLlamadas.KeyPress
        Validaciones.VerificarNumeros(e)
    End Sub
    Private Sub txtDuracionLlamada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuracionLlamada.KeyPress
        Validaciones.VerificarNumeros(e)
    End Sub
End Class



