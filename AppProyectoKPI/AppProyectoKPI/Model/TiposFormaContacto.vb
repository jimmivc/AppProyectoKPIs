Public Class TiposFormaContacto

    Private _tipoFormaContactoID As Integer
    Private _descTipoFormaContacto As String

    Public Property TipoFormaContactoID As Integer
        Get
            Return _tipoFormaContactoID
        End Get
        Set(value As Integer)
            _tipoFormaContactoID = value
        End Set
    End Property

    Public Property DescTipoFormaContacto As String
        Get
            Return _descTipoFormaContacto
        End Get
        Set(value As String)
            _descTipoFormaContacto = value
        End Set
    End Property
End Class
