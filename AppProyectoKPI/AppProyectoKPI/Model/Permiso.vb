Public Class Permiso

    Private _IdPermiso As Integer
    Private _Descripcion As String
    Private _Accion As Accion()

    Public Property IdPermiso As Integer
        Get
            Return _IdPermiso
        End Get
        Set(value As Integer)
            _IdPermiso = value
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

    Public Property Accion As Accion()
        Get
            Return _Accion
        End Get
        Set(value As Accion())
            _Accion = value
        End Set
    End Property

End Class
