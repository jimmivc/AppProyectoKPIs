Public Class loginController

    Private Shared user As Usuario

    Shared Function crearUsuario() As Boolean

        user = New Usuario()
        Return True

    End Function

    Shared Function getUser() As Usuario

        Return user

    End Function

End Class
