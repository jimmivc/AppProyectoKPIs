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

End Class