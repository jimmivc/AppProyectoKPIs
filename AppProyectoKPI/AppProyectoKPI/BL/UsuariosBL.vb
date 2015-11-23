Imports System.Configuration
Imports RestSharp
Imports Microsoft.Office.Interop
Imports System.Net

Public Class UsuariosBL

    ''' <summary>
    ''' ImportarUsuarios.  
    ''' Importa los datos de los usuarios profesores y estudiantes de un archivo de excel.
    ''' </summary>
    ''' <param name="path">parámetro de tipo String.</param>
    ''' <param name="progressBar">parámetro de tipo ProgressBar.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ImportarUsuarios(ByVal path As String, ByRef progressBar As ProgressBar, ByVal tipoImportacion As Integer) As Boolean
        If (path.Equals("")) Then
            MsgBox("Debe seleccionar un archivo antes de importar los prospectos.")
        Else
            Dim listaRolesI As New List(Of Rol)
            Dim listaUsuariosI As New List(Of Usuario)
            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook
            Dim rango As Excel.Range
            Dim rowNum As Integer
            Dim fieldNum As Integer
            Dim rowCount As Integer
            Dim colCount As Integer

            Dim nombre As String
            Dim apellidos As String
            Dim correo As String
            Dim contrasena As String
            Dim cedula As Integer
            Dim isActivo As Boolean
            Dim graba As Boolean = True
            cedula = 0
            isActivo = True
            nombre = ""
            apellidos = ""
            correo = ""
            contrasena = ""

            workbook = APP.Workbooks.Open(path)
            worksheet = workbook.Worksheets(1)
            rango = worksheet.UsedRange
            rowNum = 1
            rowCount = worksheet.UsedRange.Rows.Count
            colCount = worksheet.UsedRange.Columns.Count
            progressBar.Minimum = 0
            progressBar.Maximum = rowCount
            progressBar.Value = 0

            For i = 1 To rowCount

                Try


                    For j = 1 To colCount
                        fieldNum = j
                        Select Case (fieldNum)
                            Case 1
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    nombre = ""
                                Else
                                    nombre = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 2
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    apellidos = ""
                                Else
                                    apellidos = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 3
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    correo = ""
                                Else
                                    correo = rango.Cells(i, j).Value.ToString()
                                End If
                            Case 4
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    contrasena = ""
                                Else
                                    contrasena = rango.Cells(i, j).Value.ToString()
                                End If
                            Case 5
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    cedula = ""
                                Else
                                    cedula = rango.Cells(i, j).Value.ToString()
                                End If
                            Case 6
                                If (rango.Cells(i, j).Value.ToString().Equals("si")) Then
                                    isActivo = True
                                Else
                                    isActivo = False
                                End If

                            Case Else
                        End Select
                    Next j

                    If (UsuariosBL.ObtenerUsuarioXIdentificacion(cedula) Is Nothing) Then
                        Dim rol = RolesBL.ObtenerRol(tipoImportacion)
                        listaUsuariosI.Add(New Usuario(0, nombre, apellidos, correo, contrasena, cedula, isActivo, rol))
                    End If

                Catch ex As Exception
                    graba = False
                    MsgBox("El archivo de excel que se está importanto presenta una inconsistencia")
                    i = rowCount
                End Try

            Next i
            If (graba) Then
                If Not (listaUsuariosI Is Nothing) Then
                    RegistrarListaUsuarios(listaUsuariosI)
                End If
                MsgBox("El archivo se importó satisfactoriamente")
            Else

                MsgBox("El archivo no se pudo importar")
            End If
            cedula = 0
            isActivo = True
            nombre = ""
            apellidos = ""
            correo = ""
            contrasena = ""
            workbook.Close()
            progressBar.Value = 0
        End If




    End Function
    ''' <summary>
    ''' RegistrarListaProspectos.  
    ''' Registra una lista de prospectos de manera simultanea.
    ''' </summary>
    ''' <param name="listaUsuariosI">parámetro de tipo Lista de Prospecto.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function RegistrarListaUsuarios(ByVal listaUsuariosI As List(Of Usuario)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios/RegistraListaUsuarios", Method.POST)
        request.RequestFormat = DataFormat.Json
        'Cargar url parameters

        request.AddBody(listaUsuariosI)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of Usuario))(request)
            listaUsuariosI = response.Data
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error:" + "  " + ex.Message)
            Return False
        End Try
    End Function
    ''' <summary>
    ''' ObtenerUsuarioXIdentificacion.  
    ''' Obtiene un usuario por Identificación sin cargar objetos internos.
    ''' </summary>
    ''' <param name="identificacion">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto usuario.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerUsuarioXIdentificacion(ByVal identificacion As Integer) As Usuario
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios/identificacion/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", identificacion)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Usuario)(request)
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

    Shared Function consultarUsuarioCorreo(pCorreo As String) As Usuario
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios/correo/{id}/{a}", Method.GET)

        request.AddUrlSegment("id", pCorreo)
        request.AddUrlSegment("a", "a")
        'execute the request
        Dim response = client.Execute(Of Usuario)(request)

        Return response.Data

    End Function

    Shared Function modificarUsuario(pId As Integer, pNombre As String, pApellidos As String, pCorreo As String, pPass As String, pStatus As Boolean, pRol As Integer, pCedula As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Usuarios/{id}", Method.PUT)
        Dim result As String

        Dim user As Usuario = New Usuario(pId, pNombre, pApellidos, pCorreo, pPass, pCedula, pStatus, New Rol(pRol, Nothing, Nothing, Nothing, Nothing))

        request.AddUrlSegment("id", pId)
        request.AddJsonBody(user)
        'execute the request
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            result = "Usuario modificado"
            'Return response.Data
        Else
            result = response.ErrorMessage
            'Return response.Data
        End If
        Return result
    End Function

End Class
