Public Class loginController

    Public Shared user As Usuario

    Shared Function getUser() As Usuario

        Return user

    End Function

    Shared Function iniciarSesion(pCorreo As String, pPass As String) As Usuario

        Dim enc As Encrypt = New Encrypt(pPass)
        Dim pass = enc.EncryptData(pPass)

        Try
            user = UsuariosBL.consultarUsuarioCorreo(pCorreo)
            If user.Contrasena.Equals(pass) Then

                Return user

            End If

        Catch ex As Exception
            Throw
        End Try

        user = UsuariosBL.consultarUsuarioCorreo(pCorreo)
        user = UsuariosBL.rolPorIdUser(user.UsuarioID)
        user.Rol.Permisos = PermisosBL.listarPermisosRol(user.Rol.RolID)
        globalUser = user

        Return Nothing

    End Function

End Class
