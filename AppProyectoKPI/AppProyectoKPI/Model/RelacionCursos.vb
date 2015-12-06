Imports AppProyectoKPI

Public Class RelacionCursos


    Private _relacionCursosID As Integer
    Private _curso As Curso
    Private _estudiante As Usuario
    Private _profesor As Usuario
    Private _horario As String
    Private _cuatrimestre As Integer
    Private _anio As Integer

    Public Sub New()
    End Sub

    Public Sub New(ByVal relacionCursosId As Integer, ByVal curso As Curso, ByVal estudiante As Usuario, ByVal profesor As Usuario, ByVal horario As String,
                   ByVal cuatrimestre As Integer, ByVal anio As Integer)
        Me.RelacionCursosID = relacionCursosId
        Me.Curso = curso
        Me.Estudiante = estudiante
        Me.Profesor = profesor
        Me.Horario = horario
        Me.Cuatrimestre = cuatrimestre
        Me.Anio = anio

    End Sub


    Public Property RelacionCursosID As Integer
        Get
            Return _relacionCursosID
        End Get
        Set(value As Integer)
            _relacionCursosID = value
        End Set
    End Property

    Public Property Curso As Curso
        Get
            Return _curso
        End Get
        Set(value As Curso)
            _curso = value
        End Set
    End Property

    Public Property Estudiante As Usuario
        Get
            Return _estudiante
        End Get
        Set(value As Usuario)
            _estudiante = value
        End Set
    End Property

    Public Property Profesor As Usuario
        Get
            Return _profesor
        End Get
        Set(value As Usuario)
            _profesor = value
        End Set
    End Property

    Public Property Horario As String
        Get
            Return _horario
        End Get
        Set(value As String)
            _horario = value
        End Set
    End Property

    Public Property Cuatrimestre As Integer
        Get
            Return _cuatrimestre
        End Get
        Set(value As Integer)
            _cuatrimestre = value
        End Set
    End Property

    Public Property Anio As Integer
        Get
            Return _anio
        End Get
        Set(value As Integer)
            _anio = value
        End Set
    End Property

End Class
