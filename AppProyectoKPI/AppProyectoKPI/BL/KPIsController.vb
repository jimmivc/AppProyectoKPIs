Imports RestSharp
Imports System.Configuration

Public Class KPIsController

    Shared Function registrarIndicadorKPI(descripcion As String, formato As String, objetivo As Double, formula As List(Of String), variables As List(Of String), limiteSup As Integer, limiteInf As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis", Method.POST)
        Dim result As String

        Dim formulaCompleta As List(Of DetalleFormula) = New List(Of DetalleFormula)

        For i As Integer = 0 To formula.Count - 1
            formulaCompleta.Add(New DetalleFormula(i, variables(i), formula(i)))
        Next

        Dim kpi = New KPI(0, descripcion, formato, objetivo, New ParametroKPI(limiteSup, limiteInf), formulaCompleta)
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

    Shared Function consultarKPI(idKPI As Integer) As KPI
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/{id}", Method.GET)

        request.AddUrlSegment("id", idKPI)
        'execute the request
        Dim response = client.Execute(Of KPI)(request)

        Return response.Data

    End Function

    Shared Function modificarKPI(modificar As Integer, descripcion As String, formato As Object, objetivo As String, formula As List(Of String), variables As List(Of String), limiteSup As Integer, limiteInf As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/{id}", Method.PUT)
        Dim result As String

        'Dim formulaCompleta As List(Of DetalleFormula) = New List(Of DetalleFormula)

        'For i As Integer = 0 To formula.Count - 1
        '    formulaCompleta.Add(New DetalleFormula(i, variables(i), formula(i)))
        'Next

        Dim kpi = New KPI(modificar, descripcion, formato, objetivo, New ParametroKPI(limiteSup, limiteInf), Nothing)
        kpi.Estado = True
        'cargar url parameters
        request.AddUrlSegment("id", modificar)
        request.AddJsonBody(kpi)
        'execute the request
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            result = "Indicador KPI modificado"
            'Return response.Data
        Else
            result = response.ErrorMessage
            'Return response.Data
        End If
        Return result
    End Function

    Shared Function deshabilitarKPI(id As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/deshabilitar/{id}", Method.PUT)
        Dim result As String

        'Dim kpi = New KPI()
        'kpi.KPIID = id
        'kpi.Estado = False
        'cargar url parameters
        request.AddUrlSegment("id", id)
        'request.AddJsonBody(kpi)
        'execute the request
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            result = "Indicador KPI deshabilitado"
            'Return response.Data
        Else
            result = response.ErrorMessage
            'Return response.Data
        End If
        Return result
    End Function

    Shared Function listarIndicadoresAsignadosRol(idRol As Integer) As List(Of KPI)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/indicadoresAsignados/{idRol}", Method.GET)

        request.AddUrlSegment("idRol", idRol)

        Dim response = client.Execute(Of List(Of KPI))(request)

        Return response.Data

    End Function

    Shared Function asignarIndicadorKPI(idRol As Integer, idKPI As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/asignar/{idKPI}/{idRol}", Method.GET)
        Dim resul As String

        request.AddUrlSegment("idKPI", idKPI)
        request.AddUrlSegment("idRol", idRol)
        'execute the request
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            resul = "Indicador KPI asignado"
        Else
            resul = response.Content
        End If

        Return resul
    End Function

    Shared Function calcularResultados(idRol As Integer, idRegistro As Integer) As List(Of List(Of String))
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/resultados/{idRol}/{idRegistro}", Method.GET)

        request.AddUrlSegment("idRol", idRol)
        request.AddUrlSegment("idRegistro", idRegistro)

        Dim response = client.Execute(Of List(Of List(Of String)))(request)

        Return response.Data

    End Function

End Class
