Public Class ConsultarKPI
    Sub New(kpi As KPI)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblDescripcion.Text = kpi.DescKpi
        lblFormato.Text = kpi.Formato
        lblObjetivo.Text = kpi.Objetivo

        Dim formula As String = ""
        For Each param As DetalleFormula In kpi.Formula
            If (param.TipoDato.Equals("campo")) Then
                formula += param.Tabla
            ElseIf (param.TipoDato.Equals("operador")) Then
                formula += param.DescCampoOperador
            ElseIf (param.TipoDato.Equals("valor")) Then
                formula += param.Valor.ToString
            End If
        Next
        lblFormula.Text = formula

        verde.Text = "KPI>=" + kpi.Parametro.LimiteSuperior.ToString
        amarillo.Text = kpi.Parametro.LimiteInferior.ToString + "-" + kpi.Parametro.LimiteSuperior.ToString
        rojo.Text = "KPI <" + kpi.Parametro.LimiteInferior.ToString
    End Sub
End Class