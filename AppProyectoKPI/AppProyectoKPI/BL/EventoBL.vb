Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Public Class EventoBL



    Private Shared listaEventos As List(Of Evento)
    Private Shared evento As Evento
    'Solicitar al backend el las respuestas'
    Shared Function ObtenerListaEventosEnProspectos() As List(Of Evento)
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Eventoes", Method.GET)

        'Cargar url parameters
        'request.AddUrlSegment("id", id)

        Try
            'Execute 
            Dim response = client.Execute(Of List(Of Evento))(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function getEvento() As Evento
        Return evento
    End Function




End Class
