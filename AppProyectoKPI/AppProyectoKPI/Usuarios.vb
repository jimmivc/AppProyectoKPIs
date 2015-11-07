Public Class Usuarios

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaUsuarios()

    End Sub

    Private Sub actualizarListaUsuarios()
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = UsuariosBL.listarUsuarios()
        dtgUsuarios.DataSource = bs
        bs.ResetBindings(False)
    End Sub

End Class