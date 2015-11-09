Imports RestSharp
Imports System.Configuration

Public Class RegistrosBL

    Shared Function listarRegistrosMercadeoUsuarios(idRol As Integer) As List(Of RegistroMercadeo)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("api/RegistroMercadeos/registrosRol/{idRol}", Method.GET)

        request.AddUrlSegment("idRol", idRol)
        'execute the request
        Dim response = client.Execute(Of List(Of RegistroMercadeo))(request)

        Return response.Data
    End Function
End Class
