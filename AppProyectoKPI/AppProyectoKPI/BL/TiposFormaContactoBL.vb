Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class TiposFormaContactoBL



    Private Shared listaTiposFormaContacto As List(Of TiposFormaContacto)
    Private Shared tiposFormaContacto As TiposFormaContacto
    'Solicitar al backend el las respuestas'
    ''' <summary>
    ''' ObtenerListaTiposFormaContacto.  
    ''' Obtiene una lista de formas de contacto.
    ''' </summary>
    ''' <returns>Respuesta lista de formas de contacto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerListaTiposFormaContacto() As List(Of TiposFormaContacto)
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("TipoFormaContactoes", Method.GET)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of TiposFormaContacto))(request)
            'Dim tiposFormasContactos As List(Of TiposFormaContacto) = JsonConvert.DeserializeObject(Of List(Of TiposFormaContacto))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' ObtenerTipoFormaContactoXId.
    ''' Obtiene un objeto TiposFormaContacto x ID
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto TiposFormaContacto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerTipoFormaContactoXId(ByVal id As Integer) As TiposFormaContacto
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("TipoFormaContactoes/{id}", Method.GET)

        request.AddUrlSegment("id", id)
        Try
            'Execute 
            Dim response = client.Execute(Of TiposFormaContacto)(request)
            'Dim tiposFormaContacto As TiposFormaContacto = JsonConvert.DeserializeObject(Of TiposFormaContacto)(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    Shared Function getTiposFormaContacto() As TiposFormaContacto
        Return tiposFormaContacto
    End Function




End Class

