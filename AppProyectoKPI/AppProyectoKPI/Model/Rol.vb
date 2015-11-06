Imports AppProyectoKPI

Public Class Rol

    Private _idRol As Integer
    Private _descripcion As String
    Private _permisos As List(Of Permiso)

    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
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

    Public Property Permisos As List(Of Permiso)
        Get
            Return _permisos
        End Get
        Set(value As List(Of Permiso))
            _permisos = value
        End Set
    End Property
End Class
