Public Class KPI
    Private _kpiID As Integer
    Private _descKpi As String
    Private _formato As String
    Private _objetivo As Double
    Private _periodicidad As String

    Private _parametro As ParametroKPI
    Private _formula As List(Of DetalleFormula)
    Private _roles As List(Of Rol)

    Private _estado As Boolean

    Public Sub New()

    End Sub
    Public Sub New(pid As Integer, pdesc As String, pformato As String, pobjetivo As Double, pperiodicidad As String, pparam As ParametroKPI, pformula As List(Of DetalleFormula))
        KPIID = pid
        DescKpi = pdesc
        Formato = pformato
        Objetivo = pobjetivo
        Parametro = pparam
        Formula = pformula
        Periodicidad = pperiodicidad
    End Sub

    Public Property KPIID As Integer
        Get
            Return _kpiID
        End Get
        Set(value As Integer)
            _kpiID = value
        End Set
    End Property

    Public Property DescKpi As String
        Get
            Return _descKpi
        End Get
        Set(value As String)
            _descKpi = value
        End Set
    End Property

    Public Property Formato As String
        Get
            Return _formato
        End Get
        Set(value As String)
            _formato = value
        End Set
    End Property

    Public Property Objetivo As Double
        Get
            Return _objetivo
        End Get
        Set(value As Double)
            _objetivo = value
        End Set
    End Property

    Public Property Parametro As ParametroKPI
        Get
            Return _parametro
        End Get
        Set(value As ParametroKPI)
            _parametro = value
        End Set
    End Property

    Public Property Formula As List(Of DetalleFormula)
        Get
            Return _formula
        End Get
        Set(value As List(Of DetalleFormula))
            _formula = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property RolesAsignados As List(Of Rol)
        Get
            Return _roles
        End Get
        Set(value As List(Of Rol))
            _roles = value
        End Set
    End Property

    Public Property Periodicidad As String
        Get
            Return _periodicidad
        End Get
        Set(value As String)
            _periodicidad = value
        End Set
    End Property

End Class
