Imports RestSharp

Public Class KPIsController

    Shared Function registrarIndicadorKPI(descripcion As String, formato As String, objetivo As Double, formula As List(Of String), variables As List(Of String), limiteDefinido As Boolean) As String
        'Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis", Method.POST)

        'cargar url parameters
        'request.AddUrlSegment()

        'execute the request
        'Dim response = client.Execute(Of Ubicacion)(request)
        'If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
        'Return response.Data
        'Else
        'Return response.Data
        'End If
        Return "respuesta servidor"
    End Function
End Class
