Imports RestSharp
Imports System.Configuration

Public Class RegistrosBL

    Shared Function listarRegistrosMercadeoUsuarios(idRol As Integer) As List(Of RegistroMercadeo)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("RegistroMercadeos/registrosRol/{idRol}", Method.GET)

        request.AddUrlSegment("idRol", idRol)
        'execute the request
        Dim response = client.Execute(Of List(Of RegistroMercadeo))(request)
        Dim fechas As New List(Of RegistroMercadeo)
        fechas.Add(response.Data(0))

        For Each registro As RegistroMercadeo In response.Data
            For i = 0 To fechas.Count - 1
                If (fechas(i).fechaHora <> registro.fechaHora) Then

                End If
            Next
            fechas.Add(registro)
        Next

        Return fechas
    End Function
End Class
