Public Class Rol

    Private _IdRol As Integer
    Private _Descripcion As String
    Private _Permisos As List(Of Permiso)

    Public Property IdRol As Integer
        Get
            Return _IdRol
        End Get
        Set(value As Integer)
            _IdRol = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Permisos As List(Of Permiso)
        Get
            Return _Permisos
        End Get
        Set(value As List(Of Permiso))
            _Permisos = value
        End Set
    End Property

End Class
