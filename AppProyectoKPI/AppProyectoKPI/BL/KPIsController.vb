Imports RestSharp
Imports System.Configuration

Public Class KPIsController
    ''' <summary>
    ''' registrarIndicadorKPI
    ''' Metodo que recibe los datos necesarios para la creacion de un nuevo indicador KPI
    ''' </summary>
    ''' <param name="descripcion">String</param>
    ''' <param name="formato">String</param>
    ''' <param name="objetivo">Double</param>
    ''' <param name="formula">List(Of String)</param>
    ''' <param name="variables">List(Of String)</param>
    ''' <param name="limiteSup">Integer</param>
    ''' <param name="limiteInf">Integer</param>
    ''' <returns>Mensaje de confirmacion o error</returns>
    ''' <remarks><para>registrar un indicador
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
    ''' <summary>
    ''' listarIndicadoresKPI
    ''' </summary>
    ''' <returns>lista de indicadores registrados</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function listarIndicadoresKPI() As List(Of KPI)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis", Method.GET)
        

        'execute the request
        Dim response = client.Execute(Of List(Of KPI))(request)

        Return response.Data

    End Function
    ''' <summary>
    ''' consultar kpi
    ''' </summary>
    ''' <param name="idKPI"></param>
    ''' <returns>kpi consultado</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function consultarKPI(idKPI As Integer) As KPI
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/{id}", Method.GET)

        request.AddUrlSegment("id", idKPI)
        'execute the request
        Dim response = client.Execute(Of KPI)(request)

        Return response.Data

    End Function
    ''' <summary>
    ''' modificar KPI
    ''' </summary>
    ''' <param name="modificar">Integer</param>
    ''' <param name="descripcion">String</param>
    ''' <param name="formato">Object</param>
    ''' <param name="objetivo">String</param>
    ''' <param name="formula">List(Of String)</param>
    ''' <param name="variables">List(Of String)</param>
    ''' <param name="limiteSup">Integer</param>
    ''' <param name="limiteInf">Integer</param>
    ''' <returns>mensaje de confirmacion o error</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
    ''' <summary>
    ''' deshabilitar KPI
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns>mensaje de confirmacion o error</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
    ''' <summary>
    ''' listarIndicadoresAsignadosRol
    ''' </summary>
    ''' <param name="idRol">Integer</param>
    ''' <returns>lista de los indicadores asignados a un rol</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function listarIndicadoresAsignadosRol(idRol As Integer) As List(Of KPI)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/indicadoresAsignados/{idRol}", Method.GET)

        request.AddUrlSegment("idRol", idRol)

        Dim response = client.Execute(Of List(Of KPI))(request)

        Return response.Data

    End Function
    ''' <summary>
    ''' asignarindicadoresKPI
    ''' </summary>
    ''' <param name="idRol">Integer</param>
    ''' <param name="idKPI">integer</param>
    ''' <returns>mensaje de confirmacion o error</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
    ''' <summary>
    ''' calcularResultados
    ''' </summary>
    ''' <param name="idRol"></param>
    ''' <param name="idRegistro"></param>
    ''' <returns>matriz con los resultados del indicador KPI</returns>
    ''' <remarks><para>
    ''' <list type="bullet">
    ''' <item>Autor.: Jimmi Vila </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function calcularResultados(idRol As Integer, idRegistro As Integer) As List(Of List(Of String))
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/resultados/{idRol}/{idRegistro}", Method.GET)

        request.AddUrlSegment("idRol", idRol)
        request.AddUrlSegment("idRegistro", idRegistro)

        Dim response = client.Execute(Of List(Of List(Of String)))(request)

        Return response.Data

    End Function

End Class
