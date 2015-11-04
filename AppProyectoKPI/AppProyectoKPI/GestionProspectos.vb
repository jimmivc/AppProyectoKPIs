Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO

Public Class GestionProspectos
    Private formListarProspectos As New ListarProspectos(Me)
    Private Sub GestionProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContactoController.CrearContacto()
        'CargaDataGrids.llenarGrid(Me.dtg_FormasContacto, ContactoController.getContacto())
        PrepararComboBoxEvento()
        PrepararComboBoxBooleano(cbxIsTrabajando)
        PrepararComboBoxBooleano(cbxIsPromociones)
        PrepararComboBoxBooleano(cbxEstatus)
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim identificacion = txtIdentificacion.Text
        Dim aliass = txtAlias.Text
        Dim nombre = txtNombre.Text
        Dim apellidos = txtApellidos.Text
        Dim edad = txtEdad.Text
        Dim fechaNac = CDate(txtFechaNac.Text)
        Dim anioBachillerato = CInt(txtAnioBachillerato.Text)
        Dim isTrabajando = cbxIsTrabajando.SelectedValue
        Dim isPromociones = cbxIsPromociones.SelectedValue
        Dim lugarEstudio = txtLugarEstudio.Text
        Dim lugarTrabajo = txtLugarTrabajo.Text
        Dim isHabilitado = cbxEstatus.SelectedValue
        Dim idEvento = cbxEvento.SelectedValue
        Dim idUsuario = 1
        Dim grabado =
        ProspectoBL.RegistrarProspecto(identificacion, aliass, nombre, apellidos, edad, fechaNac, anioBachillerato, idEvento,
                                        isTrabajando, isPromociones, lugarEstudio, lugarTrabajo, isHabilitado, idUsuario)
        If (grabado = True) Then
            MsgBox("Registro guardado satisfactoriamente")
        Else
            MsgBox("No se pudo guardar el registro")
        End If
    End Sub
    Private Sub btnListarProspectos_Click(sender As Object, e As EventArgs) Handles btnListarProspectos.Click
        If (txtId.Text = "") Then
            formListarProspectos = Paneles.AgregarFormularioEnPanel(formListarProspectos, pnlGestionProspectos)
            configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(formListarProspectos.dtgListaProspectos,
                                                                                 ProspectoBL.getListaProspecto()))
        Else
            cargarProspectoPantalla(txtId.Text)
        End If
    End Sub

    Public Sub cargarProspectoPantalla(ByVal id As Integer)
        Dim response = ProspectoBL.ObtenerProspecto(id)
        If (response.ToString = Nothing) Then
            MsgBox("Seleccionó un prospecto vacío")
        Else
            Me.txtId.Text = response.ProspectoID
            Me.txtNombre.Text = response.Nombre
            Me.txtIdentificacion.Text = response.Identificacion
            Me.txtAlias.Text = response.Alias
            Me.txtApellidos.Text = response.Apellidos
            Me.txtEdad.Text = response.Edad
            Me.txtFechaNac.Text = response.FechaNac
            Me.txtAnioBachillerato.Text = response.AnioBachillerato
            Me.cbxIsTrabajando.SelectedValue = response.IsTrabajando
            Me.cbxIsPromociones.SelectedValue = response.IsInscritoPromociones
            Me.txtLugarEstudio.Text = response.LugarEstudioAnterior
            Me.txtLugarTrabajo.Text = response.LugarTrabajo
            Me.cbxEstatus.Text = response.IsHabilitado
            Me.cbxEvento.SelectedValue = response.Evento.EventoID
            'MsgBox(response.FormasContacto(0).DescFormaContacto)
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


End Class