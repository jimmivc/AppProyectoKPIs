Public Class loginController

    Private Shared user As Usuario

    'Shared Function crearUsuario() As Boolean

    '    user = Usuario
    '    Return True

    'End Function

    Shared Function getUser() As Usuario

        Return user

    End Function

    Shared Function iniciarSesion(pCorreo As String, pPass As String) As Usuario

        Dim enc As Encrypt = New Encrypt(pPass)
        Dim pass = enc.EncryptData(pPass)

        Try
            Dim user As Usuario = UsuariosBL.consultarUsuarioCorreo(pCorreo)
            If user.Contrasena.Equals(pass) Then

                Return user

            End If

        Catch ex As Exception
            Throw
        End Try

        Return Nothing

    End Function

End Class
