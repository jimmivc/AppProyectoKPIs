Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class GrupoEmpresarialBL



    Private Shared listaGrupoEmpresarial As List(Of GrupoEmpresarial)
    Private Shared grupoEmpresarial As GrupoEmpresarial
    'Solicitar al backend el las respuestas'
    Shared Function ObtenerListaGrupoEmpresarial() As List(Of GrupoEmpresarial)
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("GrupoEmpresarials", Method.GET)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of GrupoEmpresarial))(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function ObtenerGrupoEmpresarialXId(ByVal id As Integer) As GrupoEmpresarial
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("TipoFormaContactoes/{id}", Method.GET)

        request.AddUrlSegment("id", id)
        Try
            'Execute 
            Dim response = client.Execute(Of GrupoEmpresarial)(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function getGrupoEmpresarial() As GrupoEmpresarial
        Return grupoEmpresarial
    End Function




End Class

