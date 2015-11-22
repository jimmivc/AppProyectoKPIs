Imports AppProyectoKPI

Public Class Permiso

    Private _idPermiso As Integer
    Private _descripcion As String
    Private _accion As String
    Private _roles As List(Of Rol)

    Private Sub New()

    End Sub

    Public Sub New(pId As Integer, pDesc As String, pAccion As String, pRoles As List(Of Rol))
        PermisoID = pId
        Descripcion = pDesc
        Accion = pAccion
        Roles = pRoles
    End Sub

    Public Property PermisoID As Integer
        Get
            Return _idPermiso
        End Get
        Set(value As Integer)
            _idPermiso = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Accion As String
        Get
            Return _accion
        End Get
        Set(value As String)
            _accion = value
        End Set
    End Property

    Public Property Roles As List(Of Rol)
        Get
            Return _roles
        End Get
        Set(value As List(Of Rol))
            _roles = value
        End Set
    End Property
End Class
