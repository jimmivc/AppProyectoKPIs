Public Class TipoCurso

    Private _tipoCursoID As Integer
    Private _nombreTipoCurso As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal idTipoCurso As Integer, ByVal nombreTipoCurso As String)
        TipoCursoID = idTipoCurso
        nombreTipoCurso = nombreTipoCurso
    End Sub

    Public Property TipoCursoID As Integer
        Get
            Return _tipoCursoID
        End Get
        Set(value As Integer)
            _tipoCursoID = value
        End Set
    End Property

    Public Property NombreTipoCurso As String
        Get
            Return _nombreTipoCurso
        End Get
        Set(value As String)
            _nombreTipoCurso = value
        End Set
    End Property





End Class
