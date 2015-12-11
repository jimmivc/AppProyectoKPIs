Imports System.Configuration
Imports System.Net
Imports Microsoft.Office.Interop
Imports RestSharp

Public Class CursosBL

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
    Shared Function ImportarCursos(ByVal path As String, ByRef progressBar As ProgressBar) As Boolean
        If (path.Equals("")) Then
            MsgBox("Debe seleccionar un archivo antes de importar los cursos.")
        Else
            Dim listaRelacionCursosI As New List(Of RelacionCursos)
            Dim listaCursosI As New List(Of Curso)
            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook
            Dim rango As Excel.Range
            Dim rowNum As Integer
            Dim fieldNum As Integer
            Dim rowCount As Integer
            Dim colCount As Integer

            Dim identificacionEstudiante As Integer
            Dim codigoCurso As String
            Dim nombreCurso As String
            Dim tipoCurso As String
            Dim idTipoCurso As Integer
            Dim identificacionProfesor As Integer
            Dim cuatrimestre As Integer
            Dim horario As String
            Dim anio As Integer
            Dim tipoCursoO As TipoCurso
            tipoCursoO = Nothing
            Dim cursoO As Curso
            cursoO = Nothing
            Dim graba As Boolean = True
            identificacionEstudiante = 0
            codigoCurso = ""
            nombreCurso = ""
            tipoCurso = ""
            idTipoCurso = 0
            identificacionProfesor = 0
            cuatrimestre = 0
            horario = ""
            anio = 0

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
                                    identificacionEstudiante = 0
                                Else
                                    identificacionEstudiante = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If

                            Case 2
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    codigoCurso = ""
                                Else
                                    codigoCurso = rango.Cells(i, j).Value.ToString()
                                End If

                            Case 3
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    nombreCurso = ""
                                Else
                                    nombreCurso = rango.Cells(i, j).Value.ToString()
                                End If
                            Case 4
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    tipoCurso = ""
                                Else
                                    tipoCurso = rango.Cells(i, j).Value.ToString()
                                End If
                            Case 5
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    identificacionProfesor = 0
                                Else
                                    identificacionProfesor = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If
                            Case 6
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    cuatrimestre = 0
                                Else
                                    cuatrimestre = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If
                            Case 7
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    horario = ""
                                Else
                                    horario = rango.Cells(i, j).Value.ToString()
                                End If
                            Case 8
                                If (rango.Cells(i, j).Value.ToString().Equals("-")) Then
                                    anio = 0
                                Else
                                    anio = Integer.Parse(rango.Cells(i, j).Value.ToString())
                                End If

                            Case Else
                        End Select
                    Next j
                    If (CursosBL.ObtenerCursoXCodigo(codigoCurso) Is Nothing) Then
                        If (tipoCurso = "Libre") Then
                            idTipoCurso = 1
                        ElseIf (tipoCurso = "Acti") Then
                            idTipoCurso = 2
                        ElseIf (tipoCurso = "Carrera") Then
                            idTipoCurso = 3
                        Else
                            graba = False
                            MsgBox("Existe un tipo de curso no válido.")
                        End If
                        If (idTipoCurso > 0) Then
                            tipoCursoO = ObtenerTipoCursoXId(idTipoCurso)
                            If Not (ConsultarListaCursos(listaCursosI, codigoCurso)) Then
                                cursoO = New Curso(0, codigoCurso, nombreCurso, tipoCursoO)
                                listaCursosI.Add(cursoO)
                            End If
                        End If
                    End If

                    If (identificacionEstudiante > 0 And identificacionProfesor > 0) Then
                        listaRelacionCursosI.Add(New RelacionCursos(0, cursoO, UsuariosBL.ObtenerUsuarioXIdentificacion(identificacionEstudiante),
                                                      UsuariosBL.ObtenerUsuarioXIdentificacion(identificacionProfesor), horario, cuatrimestre, anio))
                    Else
                        graba = False
                        MsgBox("Existe una inconsistencia en las identificaciones de estudiantes o profesores")
                    End If


                Catch ex As Exception
                    graba = False
                    MsgBox("El archivo de excel que se está importanto presenta una inconsistencia")
                    i = rowCount
                End Try

            Next i
            If (graba) Then
                If Not (listaCursosI Is Nothing) Then
                    RegistrarListaCursos(listaCursosI)
                End If
                If Not (listaRelacionCursosI Is Nothing) Then
                    For Each r As RelacionCursos In listaRelacionCursosI
                        Dim codigo = r.Curso.CodigoCurso
                        r.Curso = ObtenerCursoXCodigo(codigo)

                        If progressBar.Value < progressBar.Maximum Then
                            progressBar.Value += 1
                        End If
                    Next
                    RegistrarListaRelacionCursos(listaRelacionCursosI)
                End If
                MsgBox("El archivo se importó satisfactoriamente")
            Else

                MsgBox("El archivo no se pudo importar")
            End If
            identificacionEstudiante = 0
            codigoCurso = ""
            nombreCurso = ""
            tipoCurso = ""
            idTipoCurso = 0
            identificacionProfesor = 0
            cuatrimestre = 0
            horario = ""
            anio = 0
            workbook.Close()
            progressBar.Value = 0
        End If




    End Function
    ''' <summary>
    ''' RegistrarListaCursos.  
    ''' Registra una lista de Cursos de manera simultanea.
    ''' </summary>
    ''' <param name="listaCursosI">parámetro de tipo Lista de Cursos.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>21/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function RegistrarListaCursos(ByVal listaCursosI As List(Of Curso)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Cursoes/RegistraListaCursos", Method.POST)
        request.RequestFormat = DataFormat.Json
        'Cargar url parameters

        request.AddBody(listaCursosI)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of Curso))(request)
            listaCursosI = response.Data
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
    ''' ObtenerCursoXCodigo.  
    ''' Obtiene un Curso por su codigo.
    ''' </summary>
    ''' <param name="codigo">id - parámetro de tipo String.</param>
    ''' <returns>Respuesta con el objeto Curso.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerCursoXCodigo(ByVal codigo As String) As Curso
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Cursoes/Codigo/{id}", Method.GET)
        'Cargar url parameters
        request.AddUrlSegment("id", codigo)
        Try
            'Execute 
            request.RequestFormat = DataFormat.Json
            Dim response = client.Execute(Of Curso)(request)
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
    ''' ObtenerTipoCursoXId.
    ''' Obtiene un objeto Tipo de Curso x ID
    ''' </summary>
    ''' <param name="Id">id - parámetro de tipo Integer.</param>
    ''' <returns>Respuesta con el objeto TiposFormaContacto.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>21/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function ObtenerTipoCursoXId(ByVal id As Integer) As TipoCurso
        ' MsgBox("entro a obtener")
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("TipoCursoes/{id}", Method.GET)

        request.AddUrlSegment("id", id)
        Try
            'Execute 
            Dim response = client.Execute(Of TipoCurso)(request)
            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data
                'MsgBox(response.Data.ToString)
            End If
        Catch ex As Exception
            MsgBox("Error" + "  " + ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' RegistrarListaRelacionCursos.  
    ''' Registra una lista de Cursos de manera simultanea.
    ''' </summary>
    ''' <param name="listaRelacionCursosI">parámetro de tipo Lista de Relación de Cursos.</param>
    ''' <returns>Respuesta con un booleano.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>21/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function RegistrarListaRelacionCursos(ByVal listaRelacionCursosI As List(Of RelacionCursos)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("RelacionCursos/RegistraListaCursos", Method.POST)
        request.RequestFormat = DataFormat.Json
        'Cargar url parameters

        request.AddBody(listaRelacionCursosI)
        Try
            'Execute 
            Dim response = client.Execute(Of List(Of RelacionCursos))(request)
            listaRelacionCursosI = response.Data
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

    Shared Function ConsultarListaCursos(ByRef listaCursos As List(Of Curso), ByVal codigo As String) As Boolean
        Dim existe = False
        For Each c As Curso In listaCursos
            If (c.CodigoCurso.Equals(codigo)) Then
                existe = True
            End If
        Next
        Return existe
    End Function

    Shared Function ListarCursos() As List(Of Curso)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Cursoes", Method.GET)
        request.RequestFormat = DataFormat.Json
        'Cargar url parameters


        Try
            'Execute 
            Dim response = client.Execute(Of List(Of Curso))(request)

            If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
                Return response.Data

            End If
        Catch ex As Exception
            MsgBox("Error:" + "  " + ex.Message)

        End Try
    End Function

End Class
