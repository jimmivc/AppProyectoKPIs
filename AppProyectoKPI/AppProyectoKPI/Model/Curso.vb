Imports AppProyectoKPI

Public Class Curso

    Private _cursoID As Integer
    Private _codigoCurso As String
    Private _nombreCurso As String
    Private _tipoCurso As TipoCurso
    Private _descTipo As String


    Public Sub New()
    End Sub

    Public Sub New(ByVal cursoId As Integer, ByVal codigoCurso As String, ByVal nombreCurso As String, ByVal tipoCurso As TipoCurso)
        Me.CursoID = cursoId
        Me.CodigoCurso = codigoCurso
        Me.NombreCurso = nombreCurso
        Me.TipoCurso = tipoCurso
    End Sub

    Public Property CursoID As Integer
        Get
            Return _cursoID
        End Get
        Set(value As Integer)
            _cursoID = value
        End Set
    End Property

    Public Property NombreCurso As String
        Get
            Return _nombreCurso
        End Get
        Set(value As String)
            _nombreCurso = value
        End Set
    End Property

    Public Property TipoCurso As TipoCurso
        Get
            Return _tipoCurso
        End Get
        Set(value As TipoCurso)
            _tipoCurso = value
            DescTipo = _tipoCurso.NombreTipoCurso
        End Set
    End Property

    Public Property CodigoCurso As String
        Get
            Return _codigoCurso
        End Get
        Set(value As String)
            _codigoCurso = value
        End Set
    End Property

    Public Property DescTipo As String
        Get
            Return _descTipo
        End Get
        Set(value As String)
            _descTipo = value
        End Set
    End Property
End Class
