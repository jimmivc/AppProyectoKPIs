Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class ProspectoBL

    Private Shared listaProspectos As List(Of Prospecto)
    Private Shared prospecto As Prospecto

    'Solicitar al backend el las respuestas'
    Shared Function ObtenerProspecto(ByVal id As Integer) As Prospecto
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(request)
            Dim prospecto As Prospecto = JsonConvert.DeserializeObject(Of Prospecto)(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return prospecto
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function RegistrarProspecto(ByVal identificacion As Integer, ByVal aliass As String, ByVal nombre As String, ByVal apellidos As String,
                                       ByVal edad As Integer, ByVal fechaNac As DateTime, ByVal anioBachillerato As Integer, ByVal evento As Integer,
                                       ByVal isTrabajando As Boolean, ByVal isPromociones As Boolean, ByVal lugarEstudio As String, ByVal lugarTrabajo As String,
                                       ByVal isHabilitado As Boolean, ByVal usuario As Integer) As Boolean
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes", Method.POST)

        'Cargar url parameters
        request.AddUrlSegment("ProspectoId", 1)
        request.AddUrlSegment("Identificacion", identificacion)
        request.AddUrlSegment("Alias", aliass)
        request.AddUrlSegment("Nombre", nombre)
        request.AddUrlSegment("Apellidos", apellidos)
        request.AddUrlSegment("Edad", edad)
        request.AddUrlSegment("FechaNac", fechaNac)
        request.AddUrlSegment("AnioBachillerato", anioBachillerato)
        request.AddUrlSegment("FechaIngresoBase", DateTime.Now)
        request.AddUrlSegment("IsTrabajando", isTrabajando)
        request.AddUrlSegment("IsInscritoPromociones", isPromociones)
        request.AddUrlSegment("LugarEstudioAnterior", lugarEstudio)
        request.AddUrlSegment("LugarTrabajo", lugarTrabajo)
        request.AddUrlSegment("IsHabilitado", isHabilitado)


        Try
            'Execute 
            Dim response = client.Execute(Of Prospecto)(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ErrorRaro" + "  " + ex.Message)
        End Try
    End Function

    Shared Function getProspecto() As Prospecto
        Return prospecto
    End Function

    Shared Function getListaProspecto() As List(Of Prospecto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes", Method.GET)

        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(request)
            Dim prospectos As List(Of Prospecto) = JsonConvert.DeserializeObject(Of List(Of Prospecto))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return prospectos

            End If

        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try

    End Function


End Class
