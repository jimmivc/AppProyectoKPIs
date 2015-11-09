Imports AppProyectoKPI

Public Class Usuario

    Dim _usuarioID As Integer
    Dim _nombre As String
    Dim _apellidos As String
    Dim _correo As String
    Dim _contrasena As String
    Dim _cedula As Integer
    Dim _isActivo As Boolean
    Dim _rol As Rol

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

    Public Property Cedula As Integer
        Get
            Return _cedula
        End Get
        Set(value As Integer)
            _cedula = value
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

    Public Property Rol As Rol
        Get
            Return _rol
        End Get
        Set(value As Rol)
            _rol = value
        End Set
    End Property
End Class
