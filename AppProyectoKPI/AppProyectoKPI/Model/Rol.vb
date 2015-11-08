Imports AppProyectoKPI

Public Class Rol

    Private _rolID As Integer
    Private _nombre As String
    Private _permisos As List(Of Permiso)
    Private _usuarios As List(Of Usuario)
    Private _listaIndicadores As List(Of KPI)

    Public Sub New()

    End Sub

    Public Sub New(pRolId As Integer, pNombre As String, pPermisos As List(Of Permiso), pUsuarios As List(Of Usuario), pListaIndicadores As List(Of KPI))
        RolID = pRolId
        Nombre = pNombre
        Permisos = pPermisos
        Usuarios = pUsuarios
        IndicadoresKPI = pListaIndicadores
    End Sub

    Public Property RolID As Integer
        Get
            Return _rolID
        End Get
        Set(value As Integer)
            _rolID = value
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

    Public Property Permisos As List(Of Permiso)
        Get
            Return _permisos
        End Get
        Set(value As List(Of Permiso))
            _permisos = value
        End Set
    End Property

    Public Property IndicadoresKPI As List(Of KPI)
        Get
            Return _listaIndicadores
        End Get
        Set(value As List(Of KPI))
            _listaIndicadores = value
        End Set
    End Property

    Public Property Usuarios As List(Of Usuario)
        Get
            Return _usuarios
        End Get
        Set(value As List(Of Usuario))
            _usuarios = value
        End Set
    End Property
End Class
