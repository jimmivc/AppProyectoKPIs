Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class FormasContactoBL



    Private Shared listaFormasContacto As List(Of FormasContacto)
    Private Shared formasContacto As FormasContacto
    'Solicitar al backend el las respuestas'
    Shared Function ObtenerListaFormasContacto() As List(Of FormasContacto)
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("FormasContactors", Method.GET)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of FormasContacto))(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function ObtenerFormasContactoXId(ByVal id As Integer) As FormasContacto

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("FormasContactoes/{id}", Method.GET)

        request.AddUrlSegment("id", id)
        Try
            'Execute 
            Dim response = client.Execute(Of FormasContacto)(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function getFormasContacto() As FormasContacto
        Return formasContacto
    End Function


    Shared Function IsFormasContacto(ByVal id As Integer) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("FormasContactoes/is/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)

        'Execute 
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of FormasContacto)(request)

        If (response.StatusCode.Equals(HttpStatusCode.OK)) Then

                Return True
            Else
                Return False
            End If

        Return False

    End Function


    Shared Function RegistrarFormaContacto(ByVal id As Integer, ByVal descripcionFormaContacto As String, ByVal tipoFormaContacto As TiposFormaContacto,
                                           ByVal grupoEmpresarial As GrupoEmpresarial, ByVal isHabilitado As Boolean, ByVal prospecto As Prospecto) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))

        If (IsFormasContacto(id)) Then

            Dim request = New RestRequest("FormasContactoes/{id}", Method.PUT)
            request.RequestFormat = DataFormat.Json
            'Cargar url parameters

            request.AddUrlSegment("id", id)
            request.AddBody(New FormasContacto(id, descripcionFormaContacto, tipoFormaContacto, grupoEmpresarial, isHabilitado, prospecto))

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
            '***
        Else
            '***
            Dim request = New RestRequest("FormasContactoes", Method.POST)
            request.RequestFormat = DataFormat.Json
            'Cargar url parameters


            request.AddBody(New FormasContacto(id, descripcionFormaContacto, tipoFormaContacto, grupoEmpresarial, isHabilitado, prospecto))

            Try
                'Execute 
                Dim response = client.Execute(Of FormasContacto)(request)
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

End Class

