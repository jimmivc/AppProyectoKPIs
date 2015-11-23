

Imports System.Configuration
    Imports System.Net
    Imports Newtonsoft.Json
    Imports RestSharp



    Public Class VentaBL

        Private Shared prospecto As Prospecto
        Private Shared usuario As Usuario


    Shared Function registrarVenta(ByVal fecha As DateTime, ByVal periodo As String, ByVal categoria As String, ByVal descripcion As String, ByVal monto As Double, prospecto As Prospecto) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Ventas", Method.POST)
        request.RequestFormat = DataFormat.Json

        Dim venta As New Venta(0, fecha, periodo, categoria, descripcion, monto, prospecto, Nothing)

        request.AddJsonBody(venta)

        Dim response = client.Execute(request)

        If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
            Return True
        Else
            Return False
        End If

        Return True
    End Function

End Class
