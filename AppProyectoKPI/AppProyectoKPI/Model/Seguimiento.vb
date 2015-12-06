Imports AppProyectoKPI

Public Class Seguimiento


    Dim _seguimientoID As Integer
    Dim _fechaHora As DateTime
    Dim _fechaSeguimiento As DateTime
    Dim _prospecto As Prospecto
    Dim _descSeguimiento As String
    Dim _numeroLlamadas As Integer
    Dim _duracionLlamadaMinutos As Integer
    Dim _isEfectiva As Boolean
    Dim _isFormaContactoValida As Boolean
    Dim _usuario As Usuario
    Dim _descUsuario As String

    Sub New()

    End Sub
    Sub New(ByVal id As Integer, ByVal fechaHora As DateTime, ByVal fechaSeguimiento As DateTime, ByVal prospecto As Prospecto, ByVal descSeguimiento As String, ByVal numeroLlamadas As Integer,
            ByVal duracion As Integer, ByVal isEfectiva As Boolean, ByVal isContactoValido As Boolean, ByVal usuario As Usuario)

        Me.SeguimientoID = id
        Me.FechaHora = fechaHora
        Me.FechaSeguimiento = fechaSeguimiento
        Me.Prospecto = prospecto
        Me.DescSeguimiento = descSeguimiento
        Me.NumeroLlamadas = numeroLlamadas
        Me.DuracionLlamadaMinutos = duracion
        Me.IsEfectiva = isEfectiva
        Me.IsFormaContactoValida = isContactoValido
        Me.Usuario = usuario

    End Sub

    Public Property SeguimientoID As Integer
        Get
            Return _seguimientoID
        End Get
        Set(value As Integer)
            _seguimientoID = value
        End Set
    End Property

    Public Property FechaHora As Date
        Get
            Return _fechaHora
        End Get
        Set(value As Date)
            _fechaHora = value
        End Set
    End Property
    Public Property FechaSeguimiento As Date
        Get
            Return _fechaSeguimiento
        End Get
        Set(value As Date)
            _fechaSeguimiento = value
        End Set
    End Property
    Public Property Prospecto As Prospecto
        Get
            Return _prospecto
        End Get
        Set(value As Prospecto)
            _prospecto = value
        End Set
    End Property

    Public Property DescSeguimiento As String
        Get
            Return _descSeguimiento
        End Get
        Set(value As String)
            _descSeguimiento = value
        End Set
    End Property

    Public Property NumeroLlamadas As Integer
        Get
            Return _numeroLlamadas
        End Get
        Set(value As Integer)
            _numeroLlamadas = value
        End Set
    End Property

    Public Property DuracionLlamadaMinutos As Integer
        Get
            Return _duracionLlamadaMinutos
        End Get
        Set(value As Integer)
            _duracionLlamadaMinutos = value
        End Set
    End Property

    Public Property IsEfectiva As Boolean
        Get
            Return _isEfectiva
        End Get
        Set(value As Boolean)
            _isEfectiva = value
        End Set
    End Property

    Public Property IsFormaContactoValida As Boolean
        Get
            Return _isFormaContactoValida
        End Get
        Set(value As Boolean)
            _isFormaContactoValida = value
        End Set
    End Property

    Public Property Usuario As Usuario
        Get
            Return _usuario
        End Get
        Set(value As Usuario)
            _usuario = value
            DescUsuario = _usuario.Nombre
        End Set
    End Property

    Public Property DescUsuario As String
        Get
            Return _descUsuario
        End Get
        Set(value As String)
            _descUsuario = value
        End Set
    End Property
End Class
