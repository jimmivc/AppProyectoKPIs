Public Class Usuario

    Private _idUsuario As Integer
    Private _cedula As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _correo As String
    Private _contrasena As String
    Private _isActivo As Boolean

    Private Shared InstanciaUsuario As Usuario = Nothing

    Private Sub New()

        IdUsuario = 1
        Cedula = 114680511
        Nombre = "Hernan"
        Apellidos = "Saenz Piedra"
        Correo = "admin@innova.com"
        Contrasena = "1234"
        IsActivo = True

    End Sub

    Public Shared ReadOnly Property Instance()
        Get
            If (InstanciaUsuario Is Nothing) Then
                InstanciaUsuario = New Usuario()
            End If

            Return InstanciaUsuario
        End Get
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
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

    Public Sub CambiarEstado(x As Boolean)
        If x = True Then
            IsActivo = True
        Else
            IsActivo = False
        End If
    End Sub

End Class
