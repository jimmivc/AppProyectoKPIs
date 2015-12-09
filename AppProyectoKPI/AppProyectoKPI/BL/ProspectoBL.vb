Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports Microsoft.Office.Interop

Public Class ProspectoBL

    Private Shared listaProspectos As New List(Of Prospecto)
    Private Shared prospecto As Prospecto

    ''' <summary>
    ''' ImportarProspectos.  
    ''' Importa los datos de Prospectos y formas de contacto de un archivo de excel.
    ''' </summary>
    ''' <param name="path">parámetro de tipo String.</param>
    ''' <param name="progressBar">parámetro de tipo ProgressBar.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ImportarProspectos(ByVal path As String, ByRef progressBar As ProgressBar) As Boolean
        If (path.Equals("")) Then
            MsgBox("Debe seleccionar un archivo antes de importar los prospectos.")
        Else
            Dim listaFormasContactosI As New List(Of FormaContactoFake)
            Dim listaFormasContacto As New List(Of FormasContacto)
            Dim listaProspectosI As New List(Of Prospecto)
            '  Dim APP As New Excel.Application
            ' Dim worksheet As Excel.Worksheet
            'Dim workbook As Excel.Workbook
            'Dim rango As Excel.Range
            Dim rowNum As Integer
            Dim fieldNum As Integer
            Dim rowCount As Integer
            Dim colCount As Integer

            Dim identificacion As Integer
            Dim aliass As String
            Dim nombre As String
            Dim apellidos As String
            Dim edad As Integer
            Dim fechaNac As New DateTime?()
            Dim anioBachillerato As Integer
            Dim trabaja As Boolean
            Dim ofertas As Boolean
            Dim lugarEstudio As String
            Dim lugarTrabajo As String
            Dim telefono As String
            Dim correo As String
            Dim graba As Boolean = True
            identificacion = 0
            edad = 0
            trabaja = True
            ofertas = True
            aliass = ""
            nombre = ""
            apellidos = ""
            lugarEstudio = ""
            lugarTrabajo = ""
            telefono = ""
            correo = ""
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
                                    identificacion = 0
                                Else
                                    identificacion = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If

                            Case 2
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    aliass = ""
                                Else
                                    aliass = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 3
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    nombre = ""
                                Else
                                    nombre = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 4
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    apellidos = ""
                                Else
                                    apellidos = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 5

                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    edad = 0
                                Else
                                    edad = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If
                            Case 6
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    fechaNac = Nothing
                                Else
                                    fechaNac = DateTime.Parse(rango.Cells(i, j).Value.ToString())
                                End If

                            Case 7
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    anioBachillerato = 0
                                Else
                                    anioBachillerato = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If

                            Case 8
                                If (rango.Cells(i, j).Value.ToString().Equals("si")) Then
                                    trabaja = True
                                Else
                                    trabaja = False
                                End If
                            Case 9
                                If (rango.Cells(i, j).Value.ToString().Equals("si")) Then
                                    ofertas = True
                                Else
                                    ofertas = False
                                End If
                            Case 10
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    lugarEstudio = ""
                                Else
                                    lugarEstudio = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 11
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    lugarTrabajo = ""
                                Else
                                    lugarTrabajo = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 12
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    telefono = ""
                                Else
                                    telefono = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 13
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    correo = ""
                                Else
                                    correo = rango.Cells(i, j).Value.ToString()
                                End If

                            Case Else
                        End Select
                    Next j

                    If (ProspectoBL.ObtenerProspectoXIdentificacion(identificacion) Is Nothing) Then
                        Dim evento = EventoBL.ObtenerEventoXId(1)
                        listaProspectosI.Add(New Prospecto(0, identificacion, aliass, nombre, apellidos, edad, fechaNac, anioBachillerato, evento,
                                                           trabaja, ofertas, lugarEstudio, lugarTrabajo, True))
                        If Not (telefono.Equals("")) Then
                            listaFormasContactosI.Add(New FormaContactoFake(identificacion, telefono, 1))
                        End If
                        If Not (correo.Equals("")) Then
                            listaFormasContactosI.Add(New FormaContactoFake(identificacion, correo, 2))
                        End If

                    End If




                Catch ex As Exception
                    graba = False
                    MsgBox("El archivo de excel que se está importanto presenta una inconsistencia")
                    i = rowCount
                End Try

            Next i
            If (graba) Then
                If Not (listaProspectosI Is Nothing) Then
                    RegistrarListaProspectos(listaProspectosI)
                End If
                If Not (listaFormasContactosI Is Nothing) Then
                    For Each f As FormaContactoFake In listaFormasContactosI
                        Dim tipo As Integer = 1
                        If (f.Tipo = 2) Then
                            tipo = 4
                        End If
                        listaFormasContacto.Add(New FormasContacto(0, f.DescFormaContacto, TiposFormaContactoBL.ObtenerTipoFormaContactoXId(tipo),
                                                                       Nothing, True, ObtenerProspectoXIdentificacion(f.IdentificacionProspecto)))
                        If progressBar.Value < progressBar.Maximum Then
                            progressBar.Value += 1
                        End If
                    Next
                    RegistrarListaFormasContacto(listaFormasContacto)
                End If

                MsgBox("El archivo se importó satisfactoriamente")
            Else

                MsgBox("El archivo no se pudo importar")
            End If


            identificacion = 0
            edad = 0
            trabaja = True
            ofertas = True
            aliass = ""
            nombre = ""
            apellidos = ""
            lugarEstudio = ""
            lugarTrabajo = ""
            workbook.Close()
            progressBar.Value = 0
        End If




    End Function
    ''' <summary>
    ''' RegistrarListaProspectos.  
    ''' Registra una lista de prospectos de manera simultanea.
    ''' </summary>
    ''' <param name="listaProspectosI">parámetro de tipo Lista de Prospecto.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function RegistrarListaProspectos(ByVal listaProspectosI As List(Of Prospecto)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/RegistraListaProspectos", Method.POST)
        request.RequestFormat = DataFormat.Json
        'Cargar url parameters

        request.AddBody(listaProspectosI)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of Prospecto))(request)
            listaProspectosI = response.Data
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
    ''' RegistrarListaFormasContacto.  
    ''' Registra una lista de formas de contacto de manera simultanea.
    ''' </summary>
    ''' <param name="listaFormasContactoI">parámetro de tipo Lista de FormasContacto.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function RegistrarListaFormasContacto(ByVal listaFormasContactoI As List(Of FormasContacto)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("FormasContactoes/RegistraListaFormasContacto", Method.POST)
        request.RequestFormat = DataFormat.Json
        'Cargar url parameters

        request.AddBody(listaFormasContactoI)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of FormasContacto))(request)
            listaFormasContactoI = response.Data
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

    'Solicitar al backend el las respuestas'
    ''' <summary>
    ''' ObtenerProspecto.  
    ''' Obtiene un prospecto por ID y lo devuelve con todos sus objetos internos menos la lista de seguimiento.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto Prospecto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
            Return Nothing
        End Try
    End Function




    Shared Function asignarListaProspectos(idUsuario As Integer, idProspeto As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/asignar/{idUsuario}/{idProspecto}", Method.GET)
        Dim resul As String


        request.AddUrlSegment("idUsuario", idUsuario)
        request.AddUrlSegment("idProspecto", idProspeto)

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            resul = "prospecto asignado"
        Else
            resul = response.Content
        End If

        Return resul
    End Function





    Shared Function getListaProspectoUsuario() As List(Of Prospecto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/Usuarios", Method.GET)

        Try
            'Execute 

            Dim response = client.Execute(Of List(Of Prospecto))(request)
            Dim eventos As List(Of Prospecto) = JsonConvert.DeserializeObject(Of List(Of Prospecto))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If

        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try

    End Function



    ''' <summary>
    ''' ObtenerSeguimientoProspecto.  
    ''' Obtiene un prospecto por ID y lo devuelve con sus registros de seguimiento.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto Prospecto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    ''' 
    Shared Function ObtenerSeguimientoProspecto(ByVal id As Integer) As Prospecto
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/Seguimiento/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", id)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Prospecto)(request)
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
    ''' ObtenerProspectoXIdentificacion.  
    ''' Obtiene un prospecto por Identificación sin cargar objetos internos.
    ''' </summary>
    ''' <param name="identificacion">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto Prospecto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerProspectoXIdentificacion(ByVal identificacion As Integer) As Prospecto
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/identificacion/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", identificacion)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Prospecto)(request)
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

    Shared Function ObtenerProspectoXIdentificacionConUsuario(ByVal identificacion As Integer) As Prospecto
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/usuario/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", identificacion)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Prospecto)(request)
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
    ''' IsProspecto.  
    ''' Obtiene un valor Booleano ante la existencia de un objeto.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto Prospecto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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

    ''' <summary>
    ''' RegistrarProspecto.  
    ''' Registra o modifica un prospecto.
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <param name="identificacion">id - parámetro de tipo Integer.</param>
    ''' <param name="aliass">id - parámetro de tipo String.</param>
    ''' <param name="nombre">id - parámetro de tipo String.</param>
    ''' <param name="apellidos">id - parámetro de tipo String.</param>
    ''' <param name="edad">id - parámetro de tipo Integer.</param>
    ''' <param name="fechaNac">id - parámetro de tipo DateTime.</param>
    ''' <param name="anioBachillerato">id - parámetro de tipo Integer.</param>
    ''' <param name="evento">id - parámetro de tipo Evento.</param>
    ''' <param name="isTrabajando">id - parámetro de tipo Booleano.</param>
    ''' <param name="isPromociones">id - parámetro de tipo Booleano.</param>
    ''' <param name="lugarEstudio">id - parámetro de tipo String.</param>
    ''' <param name="lugarTrabajo">id - parámetro de tipo String.</param>
    ''' <param name="isHabilitado">id - parámetro de tipo Booleano.</param>
    ''' <returns>Booleano en respuesta del registro o modificación realizada.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function RegistrarProspecto(ByVal id As Integer, ByVal identificacion As Integer, ByVal aliass As String, ByVal nombre As String, ByVal apellidos As String,
                                       ByVal edad As Integer, ByVal fechaNac As DateTime?, ByVal anioBachillerato As Integer, ByVal evento As Evento,
                                       ByVal isTrabajando As Boolean, ByVal isPromociones As Boolean, ByVal lugarEstudio As String, ByVal lugarTrabajo As String,
                                       ByVal isHabilitado As Boolean) As Boolean

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
                prospecto = response.Data
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
    Shared Function asignarListaProspectos(idUsuario As Integer, idProspeto As Integer) As String
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/asignar/{idUsuario}/{idProspecto}", Method.GET)
        Dim resul As String


        request.AddUrlSegment("idUsuario", idUsuario)
        request.AddUrlSegment("idProspecto", idProspeto)

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            resul = "prospecto asignado"
        Else
            resul = response.Content
        End If

        Return resul
    End Function
    Shared Function getListaProspectoUsuario() As List(Of Prospecto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectoes/Usuarios", Method.GET)

        Try
            'Execute 

            Dim response = client.Execute(Of List(Of Prospecto))(request)
            Dim eventos As List(Of Prospecto) = JsonConvert.DeserializeObject(Of List(Of Prospecto))(response.Content)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If

        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try

    End Function

End Class
