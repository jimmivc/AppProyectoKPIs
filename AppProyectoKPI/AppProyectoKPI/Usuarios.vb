Public Class Usuarios

    Dim globalID As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaUsuarios()
        actualizarRoles()
        ComboBoxEstado.Items.Add("Si")
        ComboBoxEstado.Items.Add("No")

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

        MessageBox.Show(UsuariosBL.registrarUsuario(nombre, apellidos, correo, pass, cedula, rolID))

        actualizarListaUsuarios()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        btnSalvar.Visible = True
        btnRegistrar.Visible = False
        btnEditar.Visible = False
        lblEstado.Visible = True
        btnCancelar.Visible = True
        ComboBoxEstado.Visible = True


        For Each row As DataGridViewRow In dtgUsuarios.SelectedRows

            Dim user As Usuario = TryCast(row.DataBoundItem, Usuario)
            If user IsNot Nothing Then
                Dim usuarioConsultado = UsuariosBL.consultarUsuario(user.UsuarioID)
                txtBxNombre.Text = usuarioConsultado.Nombre
                txtBxApellidos.Text = usuarioConsultado.Apellidos

                'Dim enc = New Encrypt(usuarioConsultado.Contrasena.ToString)
                'txtBxContrasena.Text = enc.DecryptData(usuarioConsultado.Contrasena.ToString)
                txtBxContrasena.Text = "1234"
                txtBxCorreo.Text = usuarioConsultado.Correo
                txtBxID.Text = usuarioConsultado.Cedula
                CombBxRol.SelectedIndex = CombBxRol.FindString(usuarioConsultado.Rol.Nombre)
                globalID = usuarioConsultado.UsuarioID

                If usuarioConsultado.IsActivo.Equals(True) Then
                    ComboBoxEstado.SelectedIndex = ComboBoxEstado.FindString("Si")
                Else
                    ComboBoxEstado.SelectedIndex = ComboBoxEstado.FindString("No")
                End If

            End If

        Next

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim estado As String = ComboBoxEstado.SelectedItem.ToString
        MessageBox.Show(estado)
        Dim status As Boolean

        Dim rolID As Integer
        Dim rol As String = CombBxRol.SelectedItem.ToString
        Dim roles As List(Of Rol) = RolesBL.listarRoles

        For i = 0 To roles.Count - 1
            If roles(i).Nombre.ToString.Equals(rol) Then
                rolID = roles(i).RolID
            End If
        Next

        Dim pass As String = txtBxContrasena.Text
        Dim enc = New Encrypt(pass)
        pass = enc.EncryptData(pass)

        If estado.CompareTo("Si") Then
            status = False
        Else
            status = True
        End If

        MessageBox.Show(UsuariosBL.modificarUsuario(globalID, txtBxNombre.Text, txtBxApellidos.Text, txtBxCorreo.Text, txtBxContrasena.Text, status, rolID, txtBxID.Text))
        actualizarListaUsuarios()
        btnCancelar.PerformClick()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnSalvar.Visible = False
        btnRegistrar.Visible = True
        btnEditar.Visible = True
        lblEstado.Visible = False
        btnCancelar.Visible = False
        ComboBoxEstado.Visible = False

        txtBxApellidos.Clear()
        txtBxContrasena.Clear()
        txtBxCorreo.Clear()
        txtBxID.Clear()
        txtBxNombre.Clear()
        CombBxRol.SelectedItem = ""

    End Sub
End Class