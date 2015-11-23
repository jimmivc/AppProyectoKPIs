Public Class Evento

    Private _eventoID As Integer
    Private _descEventoCaptacion As String
    Private _fechaEvento As DateTime
    Private _lugarEvento As String


    Public Sub New()
    End Sub

    Public Sub New(ByVal _eventoID As Integer, ByVal _descEventoCaptacion As String, ByVal _fechaEvento As Date, ByVal lugar As String)

        EventoID = _eventoID
        DescEventoCaptacion = _descEventoCaptacion
        FechaEvento = _fechaEvento
        LugarEvento = lugar
    End Sub
    Public Property EventoID As Integer
        Get
            Return _eventoID
        End Get
        Set(value As Integer)
            _eventoID = value
        End Set
    End Property

    Public Property DescEventoCaptacion As String
        Get
            Return _descEventoCaptacion
        End Get
        Set(value As String)
            _descEventoCaptacion = value
        End Set
    End Property

    Public Property FechaEvento As Date
        Get
            Return _fechaEvento
        End Get
        Set(value As Date)
            _fechaEvento = value
        End Set
    End Property

    Public Property LugarEvento As String
        Get
            Return _lugarEvento
        End Get
        Set(value As String)
            _lugarEvento = value
        End Set
    End Property
End Class
