Imports System.Configuration
Imports RestSharp

Public Class UsuariosBL

    Shared Function listarUsuarios() As List(Of Usuario)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios", Method.GET)

        'execute the request
        Dim response = client.Execute(Of List(Of Usuario))(request)

        Return response.Data

    End Function

    Shared Function registrarUsuario(pNombre As String, pApellidos As String, pCorreo As String, pPass As String, pCedula As Integer, pRolId As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios", Method.POST)
        Dim result As String

        Dim user As Usuario = New Usuario(0, pNombre, pApellidos, pCorreo, pPass, pCedula, True, New Rol(pRolId, Nothing, Nothing, Nothing, Nothing))

        request.AddJsonBody(user)

        Dim response = client.Execute(request)

        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            result = "Usuario registrado"
        Else
            result = response.ErrorMessage
        End If

        Return result
    End Function

    Shared Function consultarUsuario(idUser As Integer) As Usuario
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios/{id}", Method.GET)

        request.AddUrlSegment("id", idUser)
        'execute the request
        Dim response = client.Execute(Of Usuario)(request)

        Return response.Data

    End Function

    Shared Function modificarUsuario(modificar As Integer, descripcion As String, formato As Object, objetivo As String, formula As List(Of String), variables As List(Of String), limiteSup As Integer, limiteInf As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("kpis/{id}", Method.PUT)
        Dim result As String

        'Dim formulaCompleta As List(Of DetalleFormula) = New List(Of DetalleFormula)

        'For i As Integer = 0 To formula.Count - 1
        '    formulaCompleta.Add(New DetalleFormula(i, variables(i), formula(i)))
        'Next

        Dim kpi = New KPI(modificar, descripcion, formato, objetivo, New ParametroKPI(limiteSup, limiteInf), Nothing)
        kpi.Estado = True
        'cargar url parameters
        request.AddUrlSegment("id", modificar)
        request.AddJsonBody(kpi)
        'execute the request
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            result = "Indicador KPI modificado"
            'Return response.Data
        Else
            result = response.ErrorMessage
            'Return response.Data
        End If
        Return result
    End Function

End Class
