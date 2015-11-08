Public Class Usuarios

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaUsuarios()
        actualizarRoles()

    End Sub

    Private Sub actualizarRoles()
        Dim controller = New RolesBL
        Dim roles As List(Of Rol) = RolesBL.listarRoles

        Dim count As Integer = roles.Count

        For i = 0 To roles.Count - 1
            CombBxRol.Items.Add(roles(i).Nombre.ToString)
        Next

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
        Dim rolID As Integer

        Dim roles As List(Of Rol) = RolesBL.listarRoles

        For i = 0 To roles.Count - 1
            If roles(i).Nombre.ToString.Equals(rol) Then
                rolID = roles(i).RolID
            End If
        Next

        MessageBox.Show(UsuariosBL.registrarUsuario(0, nombre, apellidos, correo, pass, ))

    End Sub
End Class