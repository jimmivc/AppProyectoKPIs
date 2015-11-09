
Public Class RegistroMercadeo

    Public _registroMercadeoID As Integer
    Public _fechaHora As Date

    Sub New()

    End Sub

    Public Property RegistroMercadeoID As Integer
        Get
            Return _registroMercadeoID
        End Get
        Set(value As Integer)
            _registroMercadeoID = value
        End Set
    End Property

    Public Property fechaHora As Date
        Get
            Return _fechaHora
        End Get
        Set(value As Date)
            _fechaHora = value
        End Set
    End Property
End Class
