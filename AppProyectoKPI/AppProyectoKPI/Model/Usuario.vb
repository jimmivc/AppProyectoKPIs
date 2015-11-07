Public Class Usuario

    Private _usuarioID As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _correo As String
    Private _contrasena As String
    Private _isActivo As Boolean

    Public Property UsuarioID As Integer
        Get
            Return _usuarioID
        End Get
        Set(value As Integer)
            _usuarioID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property

    Public Property IsActivo As Boolean
        Get
            Return _isActivo
        End Get
        Set(value As Boolean)
            _isActivo = value
        End Set
    End Property
End Class
