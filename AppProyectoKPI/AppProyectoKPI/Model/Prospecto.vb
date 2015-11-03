Imports AppProyectoKPI


Public Class Prospecto

    Private _prospectoID As Integer
    Private _identificacion As String
    Private _apellidos As String
    Private _alias As String
    Private _edad As Integer
    Private _nombre As String
    Private _fechaNac As DateTime
    Private _anioBachillerato As Integer
    Private _isTrabajando As Boolean
    Private _isInscritoPromociones As Boolean
    Private _lugarEstudioAnterior As String
    Private _lugarTrabajo As String
    Private _isHabilitado As String
    Private _evento As Evento



    Public Property ProspectoID As Integer
        Get
            Return _prospectoID
        End Get
        Set(value As Integer)
            _prospectoID = value
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

    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
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



    Public Property LugarTrabajo As String
        Get
            Return _lugarTrabajo
        End Get
        Set(value As String)
            _lugarTrabajo = value
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

    Public Property LugarEstudioAnterior As String
        Get
            Return _lugarEstudioAnterior
        End Get
        Set(value As String)
            _lugarEstudioAnterior = value
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

    Public Property IsHabilitado As String
        Get
            Return _isHabilitado
        End Get
        Set(value As String)
            _isHabilitado = value
        End Set
    End Property
End Class
