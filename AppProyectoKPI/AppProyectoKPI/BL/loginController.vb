Public Class loginController

    Private Shared user As Usuario

    Shared Function crearUsuario() As Boolean

        user = Usuario.Instance()
        Return True

    End Function

    Shared Function getUser() As Usuario

        Return user

    End Function

End Class
