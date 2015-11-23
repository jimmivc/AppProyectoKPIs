Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class FormasContactoBL



    Private Shared listaFormasContacto As List(Of FormasContacto)
    Private Shared formasContacto As FormasContacto
    'Solicitar al backend el las respuestas'

    ''' <summary>
    ''' ObtenerListaFormasContacto.  
    ''' Método que obtiene una lista de formasde contacto.
    ''' </summary>
    ''' <returns>Respuesta con la lista de formas de contacto</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerListaFormasContacto() As List(Of FormasContacto)
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("FormasContactors", Method.GET)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of FormasContacto))(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' ObtenerFormasContactoXId.  
    ''' Obtiene la forma de contacto por Id.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto FormasContacto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
            Return Nothing
        End Try
    End Function

    Shared Function getFormasContacto() As FormasContacto
        Return formasContacto
    End Function

    ''' <summary>
    ''' IsFormasContacto.  
    ''' Verifica la existencia de un objeto FormasContacto por Id.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta de tipo boleana.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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

    ''' <summary>
    ''' RegistrarFormaContacto.  
    ''' Registra o modifica una forma de contacto.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <param name="descripcionFormaContacto">parámetro de tipo Integer.</param>
    ''' <param name="tipoFormaContacto">parámetro de tipo TipoFormaContacto.</param>
    ''' <param name="grupoEmpresarial">parámetro de tipo GrupoEmpresarial.</param>
    ''' <param name="isHabilitado">parámetro de tipo Boolean.</param>
    ''' <param name="prospecto">parámetro de tipo Prospecto.</param>
    ''' <returns>Respuesta con el objeto FormasContacto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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

