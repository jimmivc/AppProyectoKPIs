Imports System.Configuration
Imports RestSharp

Public Class PermisosBL

    Shared Function listarPermisos() As List(Of Permiso)

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Permisos", Method.GET)


        'execute the request
        Dim response = client.Execute(Of List(Of Rol))(request)

        Return Nothing

    End Function

End Class
