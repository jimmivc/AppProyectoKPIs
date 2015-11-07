Public Class KPI
    Private _id As Integer
    Private _descripcion As String
    Private _formato As String
    Private _objetivo As Double

    Private limiteInferior As Double
    Private limiteSuperior As Double

    Private formula() As String

    Public Sub New(pid As Integer, pdesc As String, pformato As String, pobjetivo As Double)
        Id = pid
        Descripcion = pdesc
        Formato = pformato
        Objetivo = pobjetivo
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Formato As String
        Get
            Return _formato
        End Get
        Set(value As String)
            _formato = value
        End Set
    End Property

    Public Property Objetivo As Integer
        Get
            Return _objetivo
        End Get
        Set(value As Integer)
            _objetivo = value
        End Set
    End Property
End Class
