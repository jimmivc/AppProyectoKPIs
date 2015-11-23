Imports System.ComponentModel

Public Class ListarProspectos
    Dim listaProspectos As New List(Of Prospecto)
    Private gestionProspectos As GestionProspectos
    Dim bs As New BindingSource()
    Public Sub New(ByRef gestion As GestionProspectos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gestionProspectos = gestion

    End Sub
    Public Sub cargarBsParaBusquedas()

        bs = gestionProspectos.getBsProspectos()
        listaProspectos = bs.DataSource
    End Sub
    Private Sub dtgListaProspectos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaProspectos.CellClick
        Dim i As Integer
        If (dtgListaProspectos.CurrentRow Is Nothing) Then
            MsgBox("No existen prospectos para seleccionar")
        Else
            i = dtgListaProspectos.CurrentRow.Index
            gestionProspectos.cargarProspectoPantalla(dtgListaProspectos.Item(0, i).Value)
            gestionProspectos.LimpiarFormaContacto()
        End If


    End Sub

    Private Sub ListarProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxBuscar.SelectedItem = "Nombre"
    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim prospectos
        prospectos = Nothing
        Select Case cbxBuscar.SelectedItem
            Case "Nombre"
                prospectos = listaProspectos.Where(Function(a) a.Nombre.ToUpper.Contains(txtBuscar.Text.ToUpper))
            Case "Apellidos"
                prospectos = listaProspectos.Where(Function(a) a.Apellidos.ToUpper.Contains(txtBuscar.Text.ToUpper))
            Case "Alias"
                prospectos = listaProspectos.Where(Function(a) a.Alias.ToUpper.Contains(txtBuscar.Text.ToUpper))
            Case "Identificación"
                prospectos = listaProspectos.Where(Function(a) a.Identificacion.Contains(txtBuscar.Text))
            Case "Edad"
                prospectos = listaProspectos.Where(Function(a) a.Edad.ToString.Contains(txtBuscar.Text))

            Case Else
                MsgBox("Debe elegir una columna de busqueda")
        End Select
        '= listaProspectos.Where(Function(a) a.Nombre.ToUpper.Contains(txtBuscar.Text.ToUpper))
        bs.DataSource = prospectos
        dtgListaProspectos.DataSource = bs
        gestionProspectos.configurarColumnasListadoProspectos(dtgListaProspectos)
    End Sub


End Class