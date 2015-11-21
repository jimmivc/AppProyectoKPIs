Public Class Roles

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaRoles()

    End Sub

    Private Sub actualizarListaRoles()
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = RolesBL.listarRoles()
        dtgRoles.DataSource = bs
        bs.ResetBindings(False)
    End Sub

    Private Sub dtgRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRoles.CellContentClick
        For Each row As DataGridViewRow In dtgRoles.SelectedRows

            Dim rol As Rol = TryCast(row.DataBoundItem, Rol)
            If rol IsNot Nothing Then
                actualizarPermisosAsignados(rol.RolID)
            End If
        Next
    End Sub

    Private Sub actualizarPermisosAsignados(id As Integer)
        CargaDataGrids.llenarGrid(dtgPermisos, PermisosBL.listarPermisos(id))
    End Sub
End Class