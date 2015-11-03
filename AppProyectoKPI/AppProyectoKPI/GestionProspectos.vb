Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO

Public Class GestionProspectos
    Private Sub GestionProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContactoController.CrearContacto()
        CargaDataGrids.llenarGrid(Me.dtg_FormasContacto, ContactoController.getContacto())
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim response = ProspectoBL.ObtenerProspecto(txtId.Text)
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