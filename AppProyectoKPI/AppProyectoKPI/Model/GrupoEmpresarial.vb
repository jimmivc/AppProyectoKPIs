Public Class GrupoEmpresarial

    Private _grupoEmpresarialID As Integer
    Private _descGrupoEmpresarial As String

    Public Property GrupoEmpresarialID As Integer
        Get
            Return _grupoEmpresarialID
        End Get
        Set(value As Integer)
            _grupoEmpresarialID = value
        End Set
    End Property

    Public Property DescGrupoEmpresarial As String
        Get
            Return _descGrupoEmpresarial
        End Get
        Set(value As String)
            _descGrupoEmpresarial = value
        End Set
    End Property
End Class
