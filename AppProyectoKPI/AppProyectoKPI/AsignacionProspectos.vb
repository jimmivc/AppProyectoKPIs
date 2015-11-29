

Imports System.Configuration
    Imports RestSharp
    Imports System.Net
    Imports System.IO
    Imports AppProyectoKPI


    Public Class AsignacionProspectos

        Dim Dt As New DataTable
        Public Property BtnActualizar As Object
        Private bsEvento As New BindingSource()
        Private chk As CheckBox = New CheckBox()
        Dim listaProspectos As New List(Of Prospecto)
        Dim bs As New BindingSource()




        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

            ' Dim prospecto As New Prospecto()

            Dim Dt = ProspectoBL.getListaProspecto
            If (Dt.ToString = Nothing) Then
                MsgBox("no hay respuesta")
            Else



                configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(DataGridView1,
                                                                      ProspectoBL.getListaProspecto()))




            End If


        End Sub



        Public Sub configurarColumnasListadoProspectos(ByRef dtg As DataGridView)
            bsEvento = dtg.DataSource

            Try
                With dtg


                    .Columns(0).Visible = False
                    .Columns(1).Width = 95
                    .Columns(1).HeaderText = "Identificación"
                    .Columns(2).Width = 80
                    .Columns(2).HeaderText = "Alias"
                    .Columns(3).HeaderText = "Nombre"
                    .Columns(3).Width = 90
                    .Columns(4).HeaderText = "Apellidos"
                    .Columns(4).Width = 90
                    .Columns(5).HeaderText = "Edad"
                    .Columns(5).Width = 40
                    .Columns(6).Visible = False
                    .Columns(7).Visible = False
                    .Columns(8).HeaderText = "Ingreso en sistema"
                    .Columns(8).Width = 85
                    .Columns(9).HeaderText = "Trabaja"
                    .Columns(9).Width = 60
                    .Columns(10).HeaderText = "Recibe Promociones"
                    .Columns(10).Width = 85

                    .Columns(11).Visible = True
                    .Columns(12).Visible = True
                    .Columns(13).Visible = True
                    .Columns(14).Visible = False
                    .Columns(15).Visible = False
                    .Columns(16).Visible = False





                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub BtnListarAsignados_Click(sender As Object, e As EventArgs) Handles BtnListarAsignados.Click


            Dim Dt = UsuariosBL.listarUsuarios
            If (Dt.ToString = Nothing) Then
                MsgBox("no hay respuesta")
            Else
                configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(DataGridView2,
                                                                      UsuariosBL.listarUsuarios()))


            End If
        End Sub


        Public Sub cargarProspectoPantalla(ByVal id As Integer)


            Dim prospecto As New Prospecto()
            prospecto.ProspectoID = id

            prospecto = ProspectoBL.ObtenerProspectoXIdentificacion(id)


            If (prospecto.Usuario Is Nothing) Then
                Me.ComboBoxEjecutivos.SelectedValue = ""
            Else
                Me.ComboBoxEjecutivos.SelectedValue = prospecto.Usuario.UsuarioID
            End If
            CargaDataGrids.llenarGrid(Me.DataGridView1, prospecto)


        End Sub

        Private Sub configurarColumnasListadoUsuariosAsignados(ByRef dtg As DataGridView)
            Try
                With dtg



                    .Columns(0).Visible = False
                    .Columns(1).Width = 95
                    .Columns(1).HeaderText = "Identificación"
                    .Columns(2).Width = 80
                    .Columns(2).HeaderText = "Alias"
                    .Columns(3).HeaderText = "Nombre"
                    .Columns(3).Width = 90
                    .Columns(4).HeaderText = "Apellidos"
                    .Columns(4).Width = 90
                    .Columns(5).Visible = False
                    .Columns(6).Visible = False
                    .Columns(7).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                    .Columns(13).Visible = False
                    .Columns(14).Visible = True
                    .Columns(15).Visible = True
                    .Columns(16).Visible = True

                End With

            Catch ex As Exception

            End Try

        End Sub

        Private Sub PrepararComboBoxUsuarios()
            Dim response = UsuariosBL.listarUsuariosMercadeo()
            Dim dt As DataTable
            dt = New DataTable("Tabla")

            dt.Columns.Add("Codigo")
            dt.Columns.Add("Descripcion")
            If (response Is Nothing) Then
            Else
                For Each item As Usuario In response
                    Dim dr As DataRow
                    dr = dt.NewRow()
                    dr("Codigo") = item.UsuarioID
                    dr(1) = item.Nombre
                    dt.Rows.Add(dr)
                Next
                ComboBoxEjecutivos.DataSource = dt
                ComboBoxEjecutivos.ValueMember = "Codigo"
                ComboBoxEjecutivos.DisplayMember = "Descripcion"
            End If
        End Sub




        Private Sub AsignarListaProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            PrepararComboBoxUsuarios()


        End Sub




        Private Sub actualizarIndicadoresAsignados(idRol As Integer)
            CargaDataGrids.llenarGrid(DataGridView1, ProspectoBL.ObtenerProspectoXIdentificacion(idRol))
        End Sub


        Private Sub actualizarListaUsuariosAsignados(iduser As Integer)
            'CargaDataGrids.llenarGrid(DataGridView2, ProspectoBL.getListaProspectoUsuario)

            Dim usuario As Usuario



            Dim Dt = ProspectoBL.getListaProspectoUsuario
            If (Dt.ToString = Nothing) Then
                MsgBox("no hay respuesta")
            Else


                configurarColumnasListadoUsuariosAsignados(CargaDataGrids.llenarGrid(DataGridView2,
                                                                     ProspectoBL.getListaProspectoUsuario()))


            End If

        End Sub




    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim result As DialogResult
        Dim user = ComboBoxEjecutivos



        Dim total As Integer

        Dim selectedCellCount As Integer = DataGridView1.GetCellCount(DataGridViewElementStates.Selected)



        Dim prospecto As Prospecto = TryCast(DataGridView1.SelectedRows(0).DataBoundItem, Prospecto)

        result = MessageBox.Show("Desea asignar los prospectos al usuario:" + ComboBoxEjecutivos.Text, "Modificando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)



        If (result = DialogResult.OK) Then
            If prospecto IsNot Nothing And user IsNot Nothing Then

                For Each row As DataGridViewRow In DataGridView1.SelectedRows

                    If (DataGridView1.SelectedRows.Count > 0) Then
                        row.Selected.ToString()
                        '  total += row.Index
                        prospecto.ProspectoID = row.Index
                        ProspectoBL.asignarListaProspectos(ComboBoxEjecutivos.SelectedValue, prospecto.ProspectoID)


                    Else

                        MessageBox.Show("no selecciono prospectos")
                        result = DialogResult.Cancel
                        actualizarListaUsuariosAsignados(ComboBoxEjecutivos.SelectedValue)
                    End If
                Next
            End If



        End If


        actualizarListaUsuariosAsignados(ComboBoxEjecutivos.SelectedValue)
    End Sub

End Class

