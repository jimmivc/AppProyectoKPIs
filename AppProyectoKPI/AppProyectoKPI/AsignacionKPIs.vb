Public Class AsignacionKPIs
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaKPIs()
        actualizarListaRoles()
        actualizarIndicadoresAsignados(TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol).RolID)
    End Sub

    Private Sub actualizarListaKPIs()
        CargaDataGrids.llenarGrid(dtgListarKPIs, KPIsController.listarIndicadoresKPI())

    End Sub

    Private Sub actualizarListaRoles()
        Dim listaRoles As List(Of Rol) = RolesBL.listarRoles()

        CargaDataGrids.llenarGrid(dtgRoles, listaRoles)
    End Sub

    Private Sub actualizarIndicadoresAsignados(idRol As Integer)
        CargaDataGrids.llenarGrid(dtgIndicadoresAsignados, KPIsController.listarIndicadoresAsignadosRol(idRol))
    End Sub

    Private Sub dtgRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRoles.CellClick
        For Each row As DataGridViewRow In dtgRoles.SelectedRows

            Dim rol As Rol = TryCast(row.DataBoundItem, Rol)
            If rol IsNot Nothing Then
                actualizarIndicadoresAsignados(rol.RolID)
            End If
        Next
    End Sub

    Private Sub btnAsignarKPI_Click(sender As Object, e As EventArgs) Handles btnAsignarKPI.Click
        Dim rol As Rol = TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol)
        Dim kpi As KPI = TryCast(dtgListarKPIs.SelectedRows(0).DataBoundItem, KPI)
        If rol IsNot Nothing And kpi IsNot Nothing Then
            MessageBox.Show(KPIsController.asignarIndicadorKPI(rol.RolID, kpi.KPIID))
        End If
        actualizarIndicadoresAsignados(TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol).RolID)
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim rol As Rol = TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol)
        Dim kpi As KPI = TryCast(dtgIndicadoresAsignados.SelectedRows(0).DataBoundItem, KPI)
        If rol IsNot Nothing And kpi IsNot Nothing Then
            MessageBox.Show(KPIsController.quitarIndicadorKPI(rol.RolID, kpi.KPIID))
        End If
        actualizarIndicadoresAsignados(TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol).RolID)
    End Sub
End Class
