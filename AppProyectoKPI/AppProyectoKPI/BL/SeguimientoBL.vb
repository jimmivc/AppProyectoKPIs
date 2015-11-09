Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class SeguimientoBL

    Private Shared listaSeguimientos As List(Of Seguimiento)
    Private Shared seguimiento As Seguimiento

    'Solicitar al backend el las respuestas'
    Shared Function ObtenerSeguimiento(ByVal id As Integer) As Seguimiento
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Seguimientoes/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Seguimiento)(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function IsSeguimiento(ByVal id As Integer) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Seguimientoes/is/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Seguimiento)(request)
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


    Shared Function RegistrarSeguimiento(ByVal id As Integer, ByVal fechaHora As DateTime, ByVal fechaSeguimiento As DateTime, ByVal prospecto As Prospecto, ByVal descSeguimiento As String, ByVal numeroLlamadas As Integer,
            ByVal duracion As Integer, ByVal isEfectiva As Boolean, ByVal isContactoValido As Boolean, ByVal usuario As Usuario) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))

        If (IsSeguimiento(id)) Then
            MsgBox("Entro")
            Dim request = New RestRequest("Seguimientoes/{id}", Method.PUT)
            request.RequestFormat = DataFormat.Json
            'Cargar url parameters


            request.AddUrlSegment("id", id)
            request.AddBody(New Seguimiento(id, fechaHora, fechaSeguimiento, prospecto, descSeguimiento, numeroLlamadas,
            duracion, isEfectiva, isContactoValido, usuario))

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
            Dim request = New RestRequest("Seguimientoes", Method.POST)
            request.RequestFormat = DataFormat.Json
            'Cargar url parameters
            request.AddBody(New Seguimiento(id, fechaHora, fechaSeguimiento, prospecto, descSeguimiento, numeroLlamadas,
            duracion, isEfectiva, isContactoValido, usuario))
            Try
                'Execute 
                Dim response = client.Execute(Of Seguimiento)(request)
                If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                    Return True
                Else
                    Return True
                End If
            Catch ex As Exception
                MsgBox("Error:" + "  " + ex.Message)
                Return False
            End Try
        End If
    End Function

    Shared Function getSeguimiento() As Seguimiento
        Return seguimiento
    End Function

    Shared Function getListaSeguimiento() As List(Of Seguimiento)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Seguimientoes", Method.GET)

        Try
            'Execute 

            Dim response = client.Execute(Of List(Of Seguimiento))(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If

        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try

    End Function


End Class

