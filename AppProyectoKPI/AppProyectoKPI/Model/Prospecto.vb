Imports AppProyectoKPI

Public Class Prospecto

    Public Class Prospecto

        Private _id As Integer

        Private _identificacion As String

        Private _alias As Integer

        Private _nombre As String

        Private _apellidos As Integer

        Private _edad As Integer

        Private _fechaNac As Date

        Private _anioBachillerato As Integer

        Private _estatusLaboral As Boolean

        Private _estatusRecepcionOfertas As Boolean

        Private _lugarEstudioAnterior As String

        Private _lugarTrabajo As String

        Private _direccion As String

        Private _estatus As Boolean

        Private _formasContacto As List(Of Contacto)

        Private _areasInteres As List(Of AreaInteres)

        Private _seguimientos As List(Of Seguimiento)

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Identificacion As String
            Get
                Return _identificacion
            End Get
            Set(value As String)
                _identificacion = value
            End Set
        End Property

        Public Property [Alias] As Integer
            Get
                Return _alias
            End Get
            Set(value As Integer)
                _alias = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Apellidos As Integer
            Get
                Return _apellidos
            End Get
            Set(value As Integer)
                _apellidos = value
            End Set
        End Property

        Public Property Edad As Integer
            Get
                Return _edad
            End Get
            Set(value As Integer)
                _edad = value
            End Set
        End Property

        Public Property FechaNac As Date
            Get
                Return _fechaNac
            End Get
            Set(value As Date)
                _fechaNac = value
            End Set
        End Property

        Public Property AnioBachillerato As Integer
            Get
                Return _anioBachillerato
            End Get
            Set(value As Integer)
                _anioBachillerato = value
            End Set
        End Property

        Public Property EstatusLaboral As Boolean
            Get
                Return _estatusLaboral
            End Get
            Set(value As Boolean)
                _estatusLaboral = value
            End Set
        End Property

        Public Property EstatusRecepcionOfertas As Boolean
            Get
                Return _estatusRecepcionOfertas
            End Get
            Set(value As Boolean)
                _estatusRecepcionOfertas = value
            End Set
        End Property

        Public Property LugarEstudioAnterior As String
            Get
                Return _lugarEstudioAnterior
            End Get
            Set(value As String)
                _lugarEstudioAnterior = value
            End Set
        End Property

        Public Property LugarTrabajo As String
            Get
                Return _lugarTrabajo
            End Get
            Set(value As String)
                _lugarTrabajo = value
            End Set
        End Property

        Public Property Direccion As String
            Get
                Return _direccion
            End Get
            Set(value As String)
                _direccion = value
            End Set
        End Property

        Public Property Estatus As Boolean
            Get
                Return _estatus
            End Get
            Set(value As Boolean)
                _estatus = value
            End Set
        End Property

        Public Property FormasContacto As List(Of Contacto)
            Get
                Return _formasContacto
            End Get
            Set(value As List(Of Contacto))
                _formasContacto = value
            End Set
        End Property

        Public Property AreasInteres As List(Of AreaInteres)
            Get
                Return _areasInteres
            End Get
            Set(value As List(Of AreaInteres))
                _areasInteres = value
            End Set
        End Property

        Public Property Seguimientos As List(Of Seguimiento)
            Get
                Return _seguimientos
            End Get
            Set(value As List(Of Seguimiento))
                _seguimientos = value
            End Set
        End Property
    End Class

End Class
