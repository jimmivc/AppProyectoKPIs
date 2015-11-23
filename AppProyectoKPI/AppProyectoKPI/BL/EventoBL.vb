Imports System.Configuration
Imports System.Net
Imports Newtonsoft.Json
Imports RestSharp

Public Class EventoBL

    Shared Function registrarEvento(ByVal _describcionEvento As String, ByVal fecha As Date, ByVal lugar As String) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Eventoes", Method.POST)
        request.RequestFormat = DataFormat.Json

        request.AddJsonBody(New Evento(0, _describcionEvento, fecha, lugar))

        Try

            Dim response = client.Execute(Of Evento)(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
        Return True
    End Function

    Private Shared listaEventos As List(Of Evento)
    Shared Function ObtenerListaEventos() As List(Of Evento)

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Eventoes", Method.GET)
        Try

            Dim response = client.Execute(Of List(Of Evento))(request)
            Dim eventos As List(Of Evento) = JsonConvert.DeserializeObject(Of List(Of Evento))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return eventos

            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
        Return listaEventos
    End Function


    Shared Function ObtenerEvento(ByVal id As Integer) As Evento

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Eventoes/{id}", Method.GET)

        request.AddUrlSegment("id", id)


        Try

            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(request)
            Dim evento As Evento = JsonConvert.DeserializeObject(Of Evento)(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return evento
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Function


    Friend Shared Function actualizarDatos(ByVal id As Integer, ByVal _describcionEvento As String, ByVal fecha As DateTime, ByVal lugar As String) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Eventoes/{id}", Method.PUT)


        request.AddUrlSegment("id", id)

        request.RequestFormat = DataFormat.Json
        request.AddJsonBody(New Evento(id, _describcionEvento, fecha, lugar))



        Try

            Dim response = client.Execute(Of Evento)(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
        Return True
    End Function


End Class
