Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO

Public Class GestionProspectos
    Private formListarProspectos As New ListarProspectos(Me)
    Private formListarSeguimientos As New Seguimientos(Me)
    Private idFormaContacto As Integer
    Private bsProspecto As New BindingSource()
    Private prospectoId As Integer

    Private Sub GestionProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContactoController.CrearContacto()
        '
        PrepararComboBoxEvento()
        PrepararComboBoxBooleano(cbxIsTrabajando)
        PrepararComboBoxBooleano(cbxIsPromociones)
        PrepararComboBoxBooleano(cbxIsHabilitado)
    End Sub


    Private Function validarNumeros(ByVal texto As String) As Boolean
        Return IsNumeric(texto)
    End Function
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim pasaVerificacion As Boolean = False
        If (txtIdentificacion.Text = "" And txtNombre.Text = "" And txtAlias.Text = "") Then
            MsgBox("Debe incluir una identificación, un alias o un nombre para realizar el registro")
        Else
            Dim id = txtId.Text
            If (id = "") Then
                id = 0
            End If
            Dim identificacion = 0
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
            If (IsDate(fechaNac)) = False And Not (fechaNac = "") Then
                MsgBox("Formato de fecha no válido")

            Else

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
                    Dim isHabilitado = cbxIsHabilitado.SelectedValue
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
                End If
            End If


    End Sub

    Private Sub btnListarProspectos_Click(sender As Object, e As EventArgs) Handles btnListarProspectos.Click
        Paneles.EliminarFormularioEnPanel(formListarSeguimientos, pnlGestionProspectos)
        formListarProspectos = Paneles.AgregarFormularioEnPanel(formListarProspectos, pnlGestionProspectos)
        configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(formListarProspectos.dtgListaProspectos,
                                                                      ProspectoBL.getListaProspecto()))
        formListarProspectos.cargarBsParaBusquedas()

    End Sub

    Public Sub cargarProspectoPantalla(ByVal id As Integer)
        Dim response = ProspectoBL.ObtenerProspecto(id)
        If (response Is Nothing) Then
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
            ' Me.txtFechaNac.Text = Format(txtFechaNac, "yyyy/MM/dd")
            If (response.AnioBachillerato = 0) Then
                Me.txtAnioBachillerato.Text = ""
            Else
                Me.txtAnioBachillerato.Text = response.AnioBachillerato
            End If
            Me.cbxIsTrabajando.SelectedValue = response.IsTrabajando
            Me.cbxIsPromociones.SelectedValue = response.IsInscritoPromociones
            Me.txtLugarEstudio.Text = response.LugarEstudioAnterior
            Me.txtLugarTrabajo.Text = response.LugarTrabajo
            Me.cbxIsHabilitado.SelectedValue = response.IsHabilitado
            If (response.Evento Is Nothing) Then
                Me.cbxEvento.SelectedValue = ""
            Else
                Me.cbxEvento.SelectedValue = response.Evento.EventoID
            End If
            CargaDataGrids.llenarGrid(Me.dtg_FormasContacto, response.FormasContacto)
            configurarColumnasListadoFormasContacto(dtg_FormasContacto)
        End If

    End Sub

    Public Sub configurarColumnasListadoProspectos(ByRef dtg As DataGridView)
        bsProspecto = dtg.DataSource

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
                .Columns(0).HeaderText = "Contacto"
                .Columns(0).Width = 135
                .Columns(1).HeaderText = "Tipo"
                .Columns(1).Width = 130
                .Columns(2).HeaderText = "Empresa"
                .Columns(2).Width = 80
                .Columns(3).HeaderText = "Habilitado"
                .Columns(3).Width = 80
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8.5)
                .DefaultCellStyle.Font = New Font("Century Gothic", 9)
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
        If (response Is Nothing) Then
        Else
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
        End If

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
        Me.dtg_FormasContacto.Rows.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnListarProspectos_Click(sender, e)
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

    Private Sub btnAgregarContacto_Click(sender As Object, e As EventArgs) Handles btnAgregarContacto.Click
        Dim id = txtId.Text
        If (id = "") Then
            MsgBox("Debe seleccionar un prospecto o registrar uno nuevo para agregar una forma de contacto")
        Else
            Dim response = ProspectoBL.ObtenerProspecto(id)
            If (response.ProspectoID = Nothing) Then
                MsgBox("Seleccionó un prospecto vacío")
            Else
                Dim agregarFormaContacto As New AgregarContacto(response, 0, Me)
                agregarFormaContacto.ShowDialog()
            End If
        End If
    End Sub


    Private Sub dtg_FormasContacto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_FormasContacto.CellClick
        Dim i As Integer
        i = dtg_FormasContacto.CurrentRow.Index
        idFormaContacto = dtg_FormasContacto.Item(4, i).Value


    End Sub

    Private Sub btnModificarContacto_Click(sender As Object, e As EventArgs) Handles btnModificarContacto.Click
        Dim id = txtId.Text
        If (id = "") Then
            MsgBox("Debe seleccionar un prospecto o registrar uno nuevo para agregar una forma de contacto")
        Else
            If (idFormaContacto > 0) Then
                Dim response = ProspectoBL.ObtenerProspecto(id)
                If (response.ProspectoID = Nothing) Then
                    MsgBox("Seleccionó un prospecto vacío")
                Else
                    Dim agregarFormaContacto As New AgregarContacto(response, idFormaContacto, Me)
                    agregarFormaContacto.ShowDialog()
                End If
            Else
                MsgBox("Debe seleccionar un contacto para modificarlo")
            End If


        End If
    End Sub
    Public Sub LimpiarFormaContacto()
        idFormaContacto = 0
    End Sub
    Public Function getBsProspectos()
        Return bsProspecto
    End Function
    Public Function getProspectoId()
        Return prospectoId
    End Function
    Public Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        If (txtId.Text = "") Then
            MsgBox("Se debe seleccionar un prospecto para solicitar su historial de seguimiento")
        Else
            prospectoId = txtId.Text


            Paneles.EliminarFormularioEnPanel(formListarProspectos, pnlGestionProspectos)
            formListarSeguimientos = Paneles.AgregarFormularioEnPanel(formListarSeguimientos, pnlGestionProspectos)

            configurarColumnasListadoSeguimientos(CargaDataGrids.llenarGrid(formListarSeguimientos.dtgSeguimientos,
                                                  ProspectoBL.ObtenerSeguimientoProspecto(prospectoId).Seguimientos))
            formListarSeguimientos.btnNuevo_Click(sender, e)
        End If
    End Sub
    Private Sub configurarColumnasListadoSeguimientos(ByRef dtg As DataGridView)
        Try
            With dtg
                .Columns(0).HeaderText = "Item"
                .Columns(0).Width = 100
                .Columns(1).HeaderText = "Fecha"
                .Columns(1).Width = 170
                .Columns(2).Width = 170
                .Columns(2).HeaderText = "Fecha Seguimiento"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(2).Width = 230
                .Columns(9).HeaderText = "Usuario"

                .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8.5)
                .DefaultCellStyle.Font = New Font("Century Gothic", 9)
            End With

        Catch ex As Exception

        End Try

    End Sub
End Class