Public Class ParametroKPI
    Private _limiteInferior As Double
    Private _limiteSuperior As Double

    Public Property LimiteSuperior As Integer
        Get
            Return _limiteSuperior
        End Get
        Set(value As Integer)
            _limiteSuperior = value
        End Set
    End Property

    Public Property LimiteInferior As Integer
        Get
            Return _limiteInferior
        End Get
        Set(value As Integer)
            _limiteInferior = value
        End Set
    End Property

    Sub New(limitSup As Integer, limitInf As Integer)
        LimiteSuperior = limitSup
        LimiteInferior = limitInf
    End Sub

    Sub New()

    End Sub

End Class
