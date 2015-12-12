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

    Private Sub actualizarPermisosAsignados(id As Integer)
        CargaDataGrids.llenarGrid(dtgPermisos, PermisosBL.listarPermisosRol(id))
    End Sub

    Private Sub dtgRoles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRoles.CellClick
        For Each row As DataGridViewRow In dtgRoles.SelectedRows

            Dim rol As Rol = TryCast(row.DataBoundItem, Rol)
            If rol IsNot Nothing Then
                actualizarPermisosAsignados(rol.RolID)
            End If

        Next
        'For index = 0 To dtgPermisos.RowCount
        '    dtgPermisos.Rows(index).Cells(3).Value = True
        'Next
    End Sub

    Private Sub btnEditarRol_Click(sender As Object, e As EventArgs) Handles btnEditarRol.Click
        btnEditarRol.Visible = False
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim pNombre As String = txtBoxNombre.Text
        If pNombre = Nothing Then
            MessageBox.Show("Por favor ingrese un nombre válido.")
            txtBoxNombre.Clear()
        Else
            RolesBL.registrarRol(pNombre)
            actualizarListaRoles()
            txtBoxNombre.Clear()
        End If

    End Sub

End Class