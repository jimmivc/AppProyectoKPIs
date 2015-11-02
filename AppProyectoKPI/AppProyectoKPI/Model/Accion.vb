Public Class Accion

    Private _IdAccion As Integer
    Private _Descripcion As String

    Public Property IdAccion As Integer
        Get
            Return _IdAccion
        End Get
        Set(value As Integer)
            _IdAccion = value
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

End Class
