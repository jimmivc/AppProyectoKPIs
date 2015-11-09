Public Class ReportesKPI
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaRoles()
    End Sub

    Private Sub actualizarListaRoles()
        Dim listaRoles As List(Of Rol) = RolesBL.listarRoles()

        CargaDataGrids.llenarGrid(dtgRoles, listaRoles)
    End Sub
End Class