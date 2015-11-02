Imports RestSharp
Imports System.Configuration

Public Class KPIsController

    Shared Function registrarIndicadorKPI(descripcion As String, formato As String, objetivo As Double, formula As List(Of String), variables As List(Of String), limiteDefinido As Boolean) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis", Method.POST)
        Dim result As String

        Dim formulaCompleta As List(Of DetalleFormula) = New List(Of DetalleFormula)

        For i As Integer = 0 To formula.Count - 1
            formulaCompleta.Add(New DetalleFormula(i, variables(i), formula(i)))
        Next

        Dim kpi = New KPI(0, descripcion, formato, objetivo, New ParametroKPI(30, 10), formulaCompleta)
        'cargar url parameters
        request.AddJsonBody(kpi)
        'execute the request
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            result = "Indicador KPI registrado"
            'Return response.Data
        Else
            result = response.ErrorMessage
            'Return response.Data
        End If
        Return result
    End Function

    Shared Function listarIndicadoresKPI() As List(Of KPI)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis", Method.GET)
        

        'execute the request
        Dim response = client.Execute(Of List(Of KPI))(request)

        Return response.Data

    End Function
End Class
