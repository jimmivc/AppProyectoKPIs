Imports AppProyectoKPI
Imports System.Configuration
Public Class Contacto


    Private _idProspecto As Integer

    Private _item As Integer

    Private _idGrupoEmpresarial As Integer

    Private _idTipoFormaContacto As Integer

    Private _descFormaContacto As String

    Private _estatus As Integer

    Private _tipoFormaContacto As FormasContacto


    Public Sub New()
        IdProspecto = 1
        Item = 1
        IdGrupoEmpresarial = 1
        IdTipoFormaContacto = 1
        DescFormaContacto = "celular"
        Estatus = True
    End Sub



    Public Property IdProspecto As Integer
            Get
                Return _idProspecto
            End Get
            Set(value As Integer)
                _idProspecto = value
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

        Public Property IdGrupoEmpresarial As Integer
            Get
                Return _idGrupoEmpresarial
            End Get
            Set(value As Integer)
                _idGrupoEmpresarial = value
            End Set
        End Property

        Public Property IdTipoFormaContacto As Integer
            Get
                Return _idTipoFormaContacto
            End Get
            Set(value As Integer)
                _idTipoFormaContacto = value
            End Set
        End Property

        Public Property DescFormaContacto As String
            Get
                Return _descFormaContacto
            End Get
            Set(value As String)
                _descFormaContacto = value
            End Set
        End Property

        Public Property Estatus As Integer
            Get
                Return _estatus
            End Get
            Set(value As Integer)
                _estatus = value
            End Set
        End Property

        Public Property TipoFormaContacto As FormasContacto
            Get
                Return _tipoFormaContacto
            End Get
            Set(value As FormasContacto)
                _tipoFormaContacto = value
            End Set
        End Property




End Class
