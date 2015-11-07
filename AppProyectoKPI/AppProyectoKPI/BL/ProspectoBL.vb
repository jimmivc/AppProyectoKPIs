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
            Dim response = client.Execute(Of Prospecto)(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function IsProspecto(ByVal id As Integer) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/is/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Prospecto)(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
            Return False
        End Try
    End Function


    Shared Function RegistrarProspecto(ByVal id As Integer, ByVal identificacion As Integer, ByVal aliass As String, ByVal nombre As String, ByVal apellidos As String,
                                       ByVal edad As Integer, ByVal fechaNac As DateTime, ByVal anioBachillerato As Integer, ByVal evento As Evento,
                                       ByVal isTrabajando As Boolean, ByVal isPromociones As Boolean, ByVal lugarEstudio As String, ByVal lugarTrabajo As String,
                                       ByVal isHabilitado As String) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))

        If (IsProspecto(id)) Then

            Dim request = New RestRequest("Prospectoes/{id}", Method.PUT)
            request.RequestFormat = DataFormat.Json
            'Cargar url parameters


            request.AddUrlSegment("id", id)
            request.AddBody(New Prospecto(id, identificacion, aliass, nombre, apellidos, edad, fechaNac, anioBachillerato, evento, isTrabajando,
                                          isPromociones, lugarEstudio, lugarTrabajo, isHabilitado))

            Try
                'Execute 
                Dim response = client.Execute(request)
                If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                    Return True
                Else
                    Return True
                End If
            Catch ex As Exception
                MsgBox("Error:" + "  " + ex.Message)
                Return False
            End Try
        Else
            Dim request = New RestRequest("Prospectoes", Method.POST)
            request.RequestFormat = DataFormat.Json
            'Cargar url parameters
            request.AddBody(New Prospecto(id, identificacion, aliass, nombre, apellidos, edad, fechaNac, anioBachillerato, evento, isTrabajando,
                                          isPromociones, lugarEstudio, lugarTrabajo, isHabilitado))
            Try
                'Execute 
                Dim response = client.Execute(Of Prospecto)(request)
                If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox("Error:" + "  " + ex.Message)
                Return False
            End Try
        End If
    End Function

    Shared Function getProspecto() As Prospecto
        Return prospecto
    End Function

    Shared Function getListaProspecto() As List(Of Prospecto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes", Method.GET)

        Try
            'Execute 

            Dim response = client.Execute(Of List(Of Prospecto))(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If

        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try

    End Function


End Class
