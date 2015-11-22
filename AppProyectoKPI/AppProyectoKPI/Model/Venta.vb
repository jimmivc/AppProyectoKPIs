

Imports AppProyectoKPI

    Public Class Venta



        Private _codigoID As Integer
        Private _fecha As DateTime
        Private _periodo As String
        Private _categoria As String
        Private _descripcion As String
        Private _monto As Double
        Private _Prospecto As Prospecto
        Private _usuario As Usuario


        Public Sub New()

        End Sub

        Public Sub New(ByVal _codigoID As Integer, ByVal _fecha As DateTime, ByVal _periodo As String, ByVal _categoria As String, ByVal _descripcion As String, ByVal _monto As Double, ByVal _prospecto As Prospecto, ByVal _usuario As Usuario)
            CodigoID = _codigoID
            Fecha = _fecha
            Periodo = _periodo
            Categoria = _categoria
            Descripcion = _descripcion
            Monto = _monto
            Prospecto = _prospecto
            Usuario = _usuario

        End Sub



        Public Property CodigoID As Integer
            Get
                Return _codigoID
            End Get
            Set(value As Integer)
                _codigoID = value
            End Set
        End Property

        Public Property Fecha As DateTime
            Get
                Return _fecha
            End Get
            Set(value As DateTime)
                _fecha = value
            End Set
        End Property

        Public Property Periodo As String
            Get
                Return _periodo
            End Get
            Set(value As String)
                _periodo = value
            End Set
        End Property

        Public Property Categoria As String
            Get
                Return _categoria
            End Get
            Set(value As String)
                _categoria = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property

        Public Property Monto As Double
            Get
                Return _monto
            End Get
            Set(value As Double)
                _monto = value
            End Set
        End Property

        Public Property Prospecto As Prospecto
            Get
                Return _Prospecto
            End Get
            Set(value As Prospecto)
                _Prospecto = value
            End Set
        End Property

        Public Property Usuario As Usuario
            Get
                Return _usuario
            End Get
            Set(value As Usuario)
                _usuario = value
            End Set
        End Property




    End Class

