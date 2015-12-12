Imports System.Configuration
Imports System.Net
Imports RestSharp

Public Class RolesBL

    Shared Function listarRoles() As List(Of Rol)

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols", Method.GET)


        'execute the request
        Dim response = client.Execute(Of List(Of Rol))(request)

        Return response.Data

    End Function

    Shared Function registrarRol(pNombre As String) As Rol
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols", Method.POST)

        Dim rol As New Rol(0, pNombre, Nothing, Nothing, Nothing)

        request.AddJsonBody(rol)

        'execute the request
        Dim response = client.Execute(Of Rol)(request)

        Return response.Data

    End Function

    Shared Function consultarUsuario(idUser As Integer) As Usuario
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios/{id}", Method.GET)

        request.AddUrlSegment("id", idUser)
        'execute the request
        Dim response = client.Execute(Of Usuario)(request)

        Return response.Data

    End Function

    ''' <summary>
    ''' ObtenerRol.  
    ''' Obtiene un Rol por ID .
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto Rol.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerRol(ByVal id As Integer) As Rol
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Rol)(request)
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
End Class
