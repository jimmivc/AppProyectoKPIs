Imports System.Configuration
Imports RestSharp

Public Class UsuariosBL

    Shared Function listarUsuarios() As List(Of Usuario)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios", Method.GET)

        'execute the request
        Dim response = client.Execute(Of List(Of Usuario))(request)

        Return response.Data

    End Function

    Shared Function registrarUsuario(nombre As String, apellidos As String) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios", Method.POST)
        Dim result As String

        Dim user As Usuario = New Usuario(nombre, apellidos)

        Return result
    End Function

End Class
