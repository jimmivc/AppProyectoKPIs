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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim nombre = txtBxNombre.Text
        Dim apellidos = txtBxApellidos.Text
        Dim cedula = txtBxID.Text
        Dim correo = txtBxCorreo.Text
        Dim pass = txtBxContrasena.Text
        Dim enc = New Encrypt(pass)
        pass = enc.EncryptData(pass)
        Dim rol = CombBxRol.Text
    End Sub
End Class