Public Class DetalleFormula
    Private _consecutivo As Integer
    Private _tipoDato As String
    Private _tabla As String
    Private _descCampoOperador As String
    Private _valor As Double

    Public Property Consecutivo As Integer
        Get
            Return _consecutivo
        End Get
        Set(value As Integer)
            _consecutivo = value
        End Set
    End Property

    Public Property TipoDato As String
        Get
            Return _tipoDato
        End Get
        Set(value As String)
            _tipoDato = value
        End Set
    End Property

    Public Property Tabla As String
        Get
            Return _tabla
        End Get
        Set(value As String)
            _tabla = value
        End Set
    End Property

    Public Property DescCampoOperador As String
        Get
            Return _descCampoOperador
        End Get
        Set(value As String)
            _descCampoOperador = value
        End Set

    End Property

    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Sub New(pconsecutivo As Integer, ptipoDato As String, pdato As String)
        If (ptipoDato.Equals("tabla")) Then
            Tabla = pdato
        ElseIf (ptipoDato.Equals("operador")) Then
            DescCampoOperador = pdato
        ElseIf (ptipoDato.Equals("valor")) Then
            Valor = pdato
        End If
        TipoDato = ptipoDato
        Consecutivo = pconsecutivo
    End Sub
End Class
