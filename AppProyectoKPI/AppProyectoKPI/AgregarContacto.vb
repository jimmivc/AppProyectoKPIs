Public Class AgregarContacto

    Private prospecto As Prospecto
    Private formaContacto As FormasContacto
    Private idf As Integer

    Public Sub New(ByRef pprospecto As Prospecto, ByVal id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        prospecto = pprospecto
        If (id > 0) Then

            formaContacto = FormasContactoBL.ObtenerFormasContactoXId(id)
            idf = id
        Else
            idf = id
        End If


    End Sub
    Private Sub AgregarContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararComboBoxTiposFormaContacto()
        PrepararComboBoxGrupoEmpresarial()
        cbxEmpresa.Text = ""
        Me.Text = prospecto.Nombre + " " + prospecto.Apellidos
        If (idf > 0) Then
            CargarPantalla()

        End If

    End Sub


    Private Sub PrepararComboBoxTiposFormaContacto()
        Dim response = TiposFormaContactoBL.ObtenerListaTiposFormaContacto()
        Dim dt As DataTable
        dt = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        For Each item As TiposFormaContacto In response
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("Codigo") = item.TipoFormaContactoID
            dr(1) = item.DescTipoFormaContacto
            dt.Rows.Add(dr)
        Next
        cbxTipo.DataSource = dt
        cbxTipo.ValueMember = "Codigo"
        cbxTipo.DisplayMember = "Descripcion"
    End Sub

    Private Sub PrepararComboBoxGrupoEmpresarial()
        Dim response = GrupoEmpresarialBL.ObtenerListaGrupoEmpresarial()
        Dim dt = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        For Each item As GrupoEmpresarial In response
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("Codigo") = item.GrupoEmpresarialID
            dr(1) = item.DescGrupoEmpresarial
            dt.Rows.Add(dr)
        Next
        cbxEmpresa.DataSource = dt
        cbxEmpresa.ValueMember = "Codigo"
        cbxEmpresa.DisplayMember = "Descripcion"
    End Sub

    Private Sub CargarPantalla()
        txtDescFormaContacto.Text = formaContacto.DescFormaContacto
        ckxIsHabilitado.Checked = formaContacto.IsHabilitado
        cbxTipo.SelectedValue = formaContacto.TipoFormaContacto.TipoFormaContactoID
        If (formaContacto.GrupoEmpresarial Is Nothing) Then
            cbxEmpresa.SelectedValue = ""
        Else
            cbxEmpresa.SelectedValue = formaContacto.GrupoEmpresarial.GrupoEmpresarialID
        End If


    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim descripcionFormaContacto = txtDescFormaContacto.Text
        Dim isHabilitada = ckxIsHabilitado.Checked
        Dim idTipoFormaContacto = cbxTipo.SelectedValue
        Dim idEmpresa = cbxEmpresa.SelectedValue
        Dim empresa As New GrupoEmpresarial()

        If (Validaciones.CadenaNoVacia(descripcionFormaContacto) And idTipoFormaContacto > 0) Then
            If (idEmpresa > 0) Then
                empresa = GrupoEmpresarialBL.ObtenerGrupoEmpresarialXId(idEmpresa)

            Else
                empresa = Nothing
            End If
            Dim tipo = TiposFormaContactoBL.ObtenerTipoFormaContactoXId(idTipoFormaContacto)

            Dim grabado =
        FormasContactoBL.RegistrarFormaContacto(idf, descripcionFormaContacto, tipo, empresa, isHabilitada, prospecto)
            If (grabado = True) Then
                MsgBox("Registro guardado satisfactoriamente")

            Else
                MsgBox("Registro guardado satisfactoriamente")
            End If


        Else
            MsgBox("Se deben llenar los campos: Descripción de contacto y Tipo")
        End If




    End Sub





End Class