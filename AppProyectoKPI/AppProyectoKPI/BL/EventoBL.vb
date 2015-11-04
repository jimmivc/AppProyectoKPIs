Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class EventoBL



    Private Shared listaEventos As List(Of Evento)
    Private Shared evento As Evento
    'Solicitar al backend el las respuestas'
    Shared Function ObtenerListaEventosEnProspectos() As List(Of Evento)
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Eventoes", Method.GET)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of Evento))(request)
            Dim eventos As List(Of Evento) = JsonConvert.DeserializeObject(Of List(Of Evento))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return eventos
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function getEvento() As Evento
        Return evento
    End Function




End Class
