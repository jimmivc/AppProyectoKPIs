Public Class Usuario

    Private _IdUsuario As Integer
    Private _Cedula As Integer
    Private _Nombre As String
    Private _Apellidos As String
    Private _Correo As String
    Private _Contrasena As String
    Private _IsActivo As Boolean

    Private Shared InstanciaUsuario As Usuario = Nothing

    Private Sub New()

        _IdUsuario = 1
        _Cedula = 114680511
        _Nombre = "Hernan"
        _Apellidos = "Saenz Piedra"
        _Correo = "admin@innova.com"
        _Contrasena = "1234"
        _IsActivo = True

    End Sub

    Public Shared ReadOnly Property Instance()
        Get
            If (InstanciaUsuario Is Nothing) Then
                InstanciaUsuario = New Usuario()
            End If

            Return InstanciaUsuario
        End Get
    End Property

    Public Property Cedula As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property Nombre As Integer
        Get
            Return _Nombre
        End Get
        Set(value As Integer)
            _Nombre = value
        End Set
    End Property

    Public Property Apellidos As Integer
        Get
            Return _Apellidos
        End Get
        Set(value As Integer)
            _Apellidos = value
        End Set
    End Property

    Public Property Correo As Integer
        Get
            Return _Correo
        End Get
        Set(value As Integer)
            _Correo = value
        End Set
    End Property

    Public Property Contrasena As Integer
        Get
            Return _Contrasena
        End Get
        Set(value As Integer)
            _Contrasena = value
        End Set
    End Property

    Public Property IsActivo As Integer
        Get
            Return _IsActivo
        End Get
        Set(value As Integer)
            _IsActivo = value
        End Set
    End Property

    Public Sub CambiarEstado(x As Boolean)
        If x = True Then
            _IsActivo = True
        Else
            IsActivo = False
        End If
    End Sub

End Class
