Public Class AreaInteres
    Public Class AreaInteres

        Private _idAreaInteres As Integer

        Private _descripcionAreaInteres As String

        Public Property IdAreaInteres As Integer
            Get
                Return _idAreaInteres
            End Get
            Set(value As Integer)
                _idAreaInteres = value
            End Set
        End Property

        Public Property DescripcionAreaInteres As String
            Get
                Return _descripcionAreaInteres
            End Get
            Set(value As String)
                _descripcionAreaInteres = value
            End Set
        End Property
    End Class
End Class
