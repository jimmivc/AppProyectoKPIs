Imports System.Configuration
Imports RestSharp

Public Class RolesBL

    Sub New()

        listarRoles()

    End Sub

    Shared Function listarRoles() As List(Of Rol)

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols", Method.GET)


        'execute the request
        Dim response = client.Execute(Of List(Of Rol))(request)

        Return response.Data

    End Function

End Class
