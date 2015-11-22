Imports System.Configuration
Imports RestSharp

Public Class PermisosBL

    Shared Function listarPermisosRol(pId As Integer) As List(Of Permiso)

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Permisoes/permisosRol{idRol}", Method.GET)

        request.AddUrlSegment("idRol", pId)
        'execute the request
        Dim response = client.Execute(Of List(Of Permiso))(request)

        Return response.Data

    End Function

End Class
