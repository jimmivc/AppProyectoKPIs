Imports AppProyectoKPI
Imports Newtonsoft.Json


Public Class Prospecto

    Private _prospectoID As Integer
    Private _identificacion As String
    Private _alias As String
    Private _nombre As String
    Private _apellidos As String
    Private _edad As Integer
    Private _fechaNac As DateTime
    Private _anioBachillerato As Integer
    Private _fechaIngresoBase As DateTime
    Private _isTrabajando As Boolean
    Private _isInscritoPromociones As Boolean
    Private _lugarEstudioAnterior As String
    Private _lugarTrabajo As String
    Private _isHabilitado As String
    Private _usuario As Usuario
    Private _evento As Evento
    Private _formasContacto As List(Of FormasContacto)

    Sub New()

    End Sub
    Sub New(ByVal id As Integer, ByVal identificacion As Integer, ByVal aliass As String, ByVal nombre As String, ByVal apellidos As String,
                                       ByVal edad As Integer, ByVal fechaNac As DateTime, ByVal anioBachillerato As Integer, ByVal evento As Evento,
                                       ByVal isTrabajando As Boolean, ByVal isPromociones As Boolean, ByVal lugarEstudio As String, ByVal lugarTrabajo As String,
                                       ByVal isHabilitado As String)
        Me.ProspectoID = id
        Me.Identificacion = identificacion
        Me.Alias = aliass
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.Edad = edad
        Me.FechaNac = fechaNac
        Me.AnioBachillerato = anioBachillerato
        Me.Evento = evento
        Me.IsTrabajando = isTrabajando
        Me.IsInscritoPromociones = isPromociones
        Me.LugarEstudioAnterior = lugarEstudio
        Me.LugarTrabajo = lugarTrabajo
        Me.IsHabilitado = isHabilitado
        Me.FechaIngresoBase = DateTime.Now


    End Sub
    Public Property ProspectoID As Integer
        Get
            Return _prospectoID
        End Get
        Set(value As Integer)
            _prospectoID = value
        End Set
    End Property

    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
        End Set
    End Property

    Public Property [Alias] As String
        Get
            Return _alias
        End Get
        Set(value As String)
            _alias = value
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

    Public Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property

    Public Property AnioBachillerato As Integer
        Get
            Return _anioBachillerato
        End Get
        Set(value As Integer)
            _anioBachillerato = value
        End Set
    End Property

    Public Property FechaIngresoBase As Date
        Get
            Return _fechaIngresoBase
        End Get
        Set(value As Date)
            _fechaIngresoBase = value
        End Set
    End Property

    Public Property IsTrabajando As Boolean
        Get
            Return _isTrabajando
        End Get
        Set(value As Boolean)
            _isTrabajando = value
        End Set
    End Property

    Public Property IsInscritoPromociones As Boolean
        Get
            Return _isInscritoPromociones
        End Get
        Set(value As Boolean)
            _isInscritoPromociones = value
        End Set
    End Property

    Public Property LugarEstudioAnterior As String
        Get
            Return _lugarEstudioAnterior
        End Get
        Set(value As String)
            _lugarEstudioAnterior = value
        End Set
    End Property

    Public Property LugarTrabajo As String
        Get
            Return _lugarTrabajo
        End Get
        Set(value As String)
            _lugarTrabajo = value
        End Set
    End Property

    Public Property IsHabilitado As String
        Get
            Return _isHabilitado
        End Get
        Set(value As String)
            _isHabilitado = value
        End Set
    End Property

    Public Property Usuario As Usuario
        Get
            Return _usuario
        End Get
        Set(value As Usuario)
            _usuario = value
        End Set
    End Property

    Public Property Evento As Evento
        Get
            Return _evento
        End Get
        Set(value As Evento)
            _evento = value
        End Set
    End Property

    Public Property FormasContacto As List(Of FormasContacto)
        Get
            Return _formasContacto
        End Get
        Set(value As List(Of FormasContacto))
            _formasContacto = value
        End Set
    End Property
End Class
