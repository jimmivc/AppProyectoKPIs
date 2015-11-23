Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json


Public Class GrupoEmpresarialBL



    Shared Function RegistrarEmpresa(ByVal _describcionEvento As String) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("GrupoEmpresarials", Method.POST)
        request.RequestFormat = DataFormat.Json

        request.AddJsonBody(New GrupoEmpresarial(0, _describcionEvento))

        Try

            Dim response = client.Execute(Of GrupoEmpresarial)(request)

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




    Private Shared listaEmpresa As List(Of GrupoEmpresarial)
    Shared Function ObtenerListaEmpresa() As List(Of GrupoEmpresarial)

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("GrupoEmpresarials", Method.GET)


        Try

            Dim response = client.Execute(Of List(Of GrupoEmpresarial))(request)
            Dim empresa As List(Of GrupoEmpresarial) = JsonConvert.DeserializeObject(Of List(Of GrupoEmpresarial))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
        Return listaEmpresa
    End Function

    Shared Function ObtenerEmpresa(ByVal id As Integer) As GrupoEmpresarial

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("GrupoEmpresarials/{id}", Method.GET)
        request.AddUrlSegment("id", id)


        Try

            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(request)
            Dim empresa As GrupoEmpresarial = JsonConvert.DeserializeObject(Of GrupoEmpresarial)(response.Content)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return empresa
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Function



    Friend Shared Function actualizarDatos(ByVal id As Integer, ByVal _descGrupoEmpresarial As String) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("GrupoEmpresarials/{id}", Method.PUT)
        request.RequestFormat = DataFormat.Json

        request.AddUrlSegment("id", id)
        request.AddJsonBody(New GrupoEmpresarial(id, _descGrupoEmpresarial))



        Try

            Dim response = client.Execute(Of GrupoEmpresarial)(request)
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

