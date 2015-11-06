Imports AppProyectoKPI

Public Class FormasContacto
    Private _descFormaContacto As String
    Private _descTipoFormaContacto As String
    Private _descGrupoEmpresarial As String
    Private _isHabilitado As Boolean
    Private _formasContactoID As Integer
    Private _item As Integer
    Private _tipoFormaContacto As TiposFormaContacto
    Private _grupoEmpresarial As GrupoEmpresarial
    Private _prospecto As Prospecto

    Public Property DescFormaContacto As String
        Get
            Return _descFormaContacto
        End Get
        Set(value As String)
            _descFormaContacto = value
        End Set
    End Property

    Public Property DescTipoFormaContacto As String
        Get
            Return _descTipoFormaContacto
        End Get
        Set(value As String)
            _descTipoFormaContacto = value
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

    Public Property IsHabilitado As Boolean
        Get
            Return _isHabilitado
        End Get
        Set(value As Boolean)
            _isHabilitado = value
        End Set
    End Property

    Public Property FormasContactoID As Integer
        Get
            Return _formasContactoID
        End Get
        Set(value As Integer)
            _formasContactoID = value
        End Set
    End Property

    Public Property Item As Integer
        Get
            Return _item
        End Get
        Set(value As Integer)
            _item = value
        End Set
    End Property

    Public Property TipoFormaContacto As TiposFormaContacto
        Get
            Return _tipoFormaContacto
        End Get
        Set(value As TiposFormaContacto)
            _tipoFormaContacto = value
            If (IsNothing(_tipoFormaContacto)) Then
                DescTipoFormaContacto = ""
            Else
                DescTipoFormaContacto = _tipoFormaContacto.DescTipoFormaContacto
            End If

        End Set
    End Property

    Public Property GrupoEmpresarial As GrupoEmpresarial
        Get
            Return _grupoEmpresarial
        End Get
        Set(value As GrupoEmpresarial)
            _grupoEmpresarial = value
            If (IsNothing(_grupoEmpresarial)) Then
                DescGrupoEmpresarial = ""
            Else
                DescGrupoEmpresarial = _grupoEmpresarial.DescGrupoEmpresarial
            End If
        End Set
    End Property

    Public Property Prospecto As Prospecto
        Get
            Return _prospecto
        End Get
        Set(value As Prospecto)
            _prospecto = value
        End Set
    End Property
End Class

