Imports AppProyectoKPI
Public Class FormaContactoFake

    Private _descFormaContacto As String
    Private _identificacionProspecto As Integer
    Private _tipo As Integer

    Sub New()

        End Sub
    Sub New(ByVal iden As Integer, ByVal descripcionFormaContacto As String, ByVal tipo As Integer)

        Me.DescFormaContacto = descripcionFormaContacto
        Me.IdentificacionProspecto = iden
        Me.Tipo = tipo
    End Sub

    Public Property DescFormaContacto As String
        Get
            Return _descFormaContacto
        End Get
        Set(value As String)
            _descFormaContacto = value
        End Set
    End Property

    Public Property IdentificacionProspecto As Integer
        Get
            Return _identificacionProspecto
        End Get
        Set(value As Integer)
            _identificacionProspecto = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property
End Class
