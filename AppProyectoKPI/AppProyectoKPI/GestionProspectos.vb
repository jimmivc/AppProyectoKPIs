Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO

Public Class GestionProspectos
    Private formListarProspectos As New ListarProspectos(Me)
    Private Sub GestionProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContactoController.CrearContacto()
        '
        PrepararComboBoxEvento()
        PrepararComboBoxBooleano(cbxIsTrabajando)
        PrepararComboBoxBooleano(cbxIsPromociones)
        PrepararComboBoxBooleano(cbxEstatus)
    End Sub

    Private Function validarNumeros(ByVal texto As String) As Boolean
        Return IsNumeric(texto)
    End Function
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim pasaVerificacion As Boolean = False

        Dim id = txtId.Text
        If (id = "") Then
            id = 0
        End If
        Dim identificacion
        If (txtIdentificacion.Text = "") Then
            identificacion = 0
        ElseIf (IsNumeric(txtIdentificacion.Text)) Then
            identificacion = CInt(txtIdentificacion.Text)
        Else
            pasaVerificacion = False
            MsgBox("La identificación debe ser en formato numérico")
        End If
        Dim aliass = txtAlias.Text
        Dim nombre = txtNombre.Text
        Dim apellidos = txtApellidos.Text
        Dim edad = txtEdad.Text
        If (edad = "") Then
            edad = 0
        End If
        Dim fechaNac = txtFechaNac.Text
        If (fechaNac = "") Then
            fechaNac = DateTime.Now
        Else
            fechaNac = CDate(txtFechaNac.Text)
        End If
        Dim anioBachillerato = txtAnioBachillerato.Text
        If (anioBachillerato = "") Then
            anioBachillerato = 0
        End If
        Dim isTrabajando = cbxIsTrabajando.SelectedValue
        Dim isPromociones = cbxIsPromociones.SelectedValue
        Dim lugarEstudio = txtLugarEstudio.Text
        Dim lugarTrabajo = txtLugarTrabajo.Text
        Dim isHabilitado = cbxEstatus.SelectedValue
        Dim evento = EventoBL.ObtenerEventoXId(cbxEvento.SelectedValue)
        Dim grabado =
        ProspectoBL.RegistrarProspecto(id, identificacion, aliass, nombre, apellidos, edad, fechaNac, anioBachillerato, evento,
                                        isTrabajando, isPromociones, lugarEstudio, lugarTrabajo, isHabilitado)
        If (grabado = True) Then
            MsgBox("Registro guardado satisfactoriamente")
            btnListarProspectos_Click(sender, e)
        Else
            MsgBox("No se pudo guardar el registro")
        End If
    End Sub

    Private Sub btnListarProspectos_Click(sender As Object, e As EventArgs) Handles btnListarProspectos.Click

        formListarProspectos = Paneles.AgregarFormularioEnPanel(formListarProspectos, pnlGestionProspectos)
            configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(formListarProspectos.dtgListaProspectos,
                                                                                 ProspectoBL.getListaProspecto()))

    End Sub

    Public Sub cargarProspectoPantalla(ByVal id As Integer)
        Dim response = ProspectoBL.ObtenerProspecto(id)
        If (response.ProspectoID = Nothing) Then
            MsgBox("Seleccionó un prospecto vacío")
        Else
            Me.txtId.Text = response.ProspectoID
            Me.txtNombre.Text = response.Nombre
            If (response.Identificacion = 0) Then
                Me.txtIdentificacion.Text = ""
            Else
                Me.txtIdentificacion.Text = response.Identificacion
            End If
            Me.txtAlias.Text = response.Alias
            Me.txtApellidos.Text = response.Apellidos
            If (response.Edad = 0) Then
                Me.txtEdad.Text = ""
            Else
                Me.txtEdad.Text = response.Edad
            End If
            Me.txtFechaNac.Text = response.FechaNac
            If (response.AnioBachillerato = 0) Then
                Me.txtAnioBachillerato.Text = ""
            Else
                Me.txtAnioBachillerato.Text = response.AnioBachillerato
            End If
            Me.cbxIsTrabajando.SelectedValue = response.IsTrabajando
            Me.cbxIsPromociones.SelectedValue = response.IsInscritoPromociones
                Me.txtLugarEstudio.Text = response.LugarEstudioAnterior
                Me.txtLugarTrabajo.Text = response.LugarTrabajo
            Me.cbxEstatus.Text = response.IsHabilitado
            If (response.Evento.EventoID = Nothing) Then
                Me.cbxEvento.SelectedValue = ""
            Else
                Me.cbxEvento.SelectedValue = response.Evento.EventoID
            End If
            CargaDataGrids.llenarGrid(Me.dtg_FormasContacto, response.FormasContacto)
        End If

    End Sub

    Private Sub configurarColumnasListadoProspectos(ByRef dtg As DataGridView)
        Try
            With dtg
                .Columns(0).Visible = False
                .Columns(1).Width = 95
                .Columns(1).HeaderText = "Identificación"
                .Columns(2).Width = 80
                .Columns(2).HeaderText = "Alias"
                .Columns(3).HeaderText = "Nombre"
                .Columns(3).Width = 90
                .Columns(4).HeaderText = "Apellidos"
                .Columns(4).Width = 90
                .Columns(5).HeaderText = "Edad"
                .Columns(5).Width = 40
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "Ingreso en sistema"
                .Columns(8).Width = 85
                .Columns(9).HeaderText = "Trabaja"
                .Columns(9).Width = 60
                .Columns(10).HeaderText = "Recibe Promociones"
                .Columns(10).Width = 85
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub configurarColumnasListadoFormasContacto(ByRef dtg As DataGridView)
        Try
            With dtg
                .Columns(0).Visible = False
                .Columns(1).Width = 95
                .Columns(1).HeaderText = "Identificación"
                .Columns(2).Width = 80
                .Columns(2).HeaderText = "Alias"
                .Columns(3).HeaderText = "Nombre"
                .Columns(3).Width = 90
                .Columns(4).HeaderText = "Apellidos"
                .Columns(4).Width = 90
                .Columns(5).HeaderText = "Edad"
                .Columns(5).Width = 40
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "Ingreso en sistema"
                .Columns(8).Width = 85
                .Columns(9).HeaderText = "Trabaja"
                .Columns(9).Width = 60
                .Columns(10).HeaderText = "Recibe Promociones"
                .Columns(10).Width = 85
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
            End With

        Catch ex As Exception

        End Try

    End Sub



    Private Sub PrepararComboBoxEvento()
        Dim response = EventoBL.ObtenerListaEventosEnProspectos()
        Dim dt As DataTable
        dt = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        For Each item As Evento In response
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("Codigo") = item.EventoID
            dr(1) = item.DescEventoCaptacion
            dt.Rows.Add(dr)
        Next
        cbxEvento.DataSource = dt
        cbxEvento.ValueMember = "Codigo"
        cbxEvento.DisplayMember = "Descripcion"
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

    Private Sub Limpiar_Formulario(ByVal f As Object)
        ' recorrer todos los controles del formulario indicado  

        For Each c As Control In f.Controls

            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then

                c.Text = “” ' eliminar el texto  
            End If
        Next
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar_Formulario(Me.RegistroProspecto)
        txtIdentificacion.Focus()
    End Sub

    Private Sub txtIdentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        Validaciones.VerificarNumeros(e)
    End Sub
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Validaciones.VerificarLetras(e)
    End Sub
    Private Sub txtApellidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidos.KeyPress
        Validaciones.VerificarLetras(e)
    End Sub
    Private Sub txtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        Validaciones.VerificarNumeros(e)
    End Sub
    Private Sub txtAnioBachilleraro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnioBachillerato.KeyPress
        Validaciones.VerificarNumeros(e)
    End Sub



End Class