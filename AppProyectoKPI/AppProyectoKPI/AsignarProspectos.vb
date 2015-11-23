

Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports AppProyectoKPI


Public Class AsignarListaProspectos

    Dim Dt As New DataTable
    Public Property BtnActualizar As Object
    Private bsEvento As New BindingSource()





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Dim prospecto As New Prospecto()

        Dim Dt = ProspectoBL.getListaProspecto
        If (Dt.ToString = Nothing) Then
            MsgBox("no hay respuesta")
        Else
            configurarColumnasListadoEventos(CargaDataGrids.llenarGrid(DataGridView1,
                                                                      ProspectoBL.getListaProspecto()))



        End If
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(10).Visible = False
        'DataGridView1.Columns(6).Visible = False
        'DataGridView1.Columns(7).Visible = False
    End Sub

    Public Sub configurarColumnasListadoEventos(ByRef dtg As DataGridView)
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
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
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
            configurarColumnasListadoEventos(CargaDataGrids.llenarGrid(DataGridView2,
                                                                      UsuariosBL.listarUsuarios()))


        End If
    End Sub


    Public Sub cargarProspectoPantalla(ByVal id As Integer)
        ' Dim response = ProspectoBL.ObtenerProspectoXUsuario(id)

        Dim prospecto As New Prospecto()
        prospecto.ProspectoID = id

        prospecto = ProspectoBL.ObtenerProspectoXUsuario(id)


        If (prospecto.Usuario Is Nothing) Then
            Me.ComboBoxEjecutivos.SelectedValue = ""
        Else
            Me.ComboBoxEjecutivos.SelectedValue = prospecto.Usuario.UsuarioID
        End If
        CargaDataGrids.llenarGrid(Me.DataGridView1, prospecto)
        '   configurarColumnasListadoFormasContacto(DataGridView1)
        '  End If

    End Sub

    Private Sub configurarColumnasListadoFormasContacto(ByRef dtg As DataGridView)
        Try
            With dtg
                .Columns(0).HeaderText = "Contacto"
                .Columns(0).Width = 135
                .Columns(1).HeaderText = "Tipo"
                .Columns(1).Width = 130
                .Columns(2).HeaderText = "Empresa"
                .Columns(2).Width = 80
                .Columns(3).HeaderText = "Habilitado"
                .Columns(3).Width = 80
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8.5)
                .DefaultCellStyle.Font = New Font("Century Gothic", 9)
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PrepararComboBoxUsuarios()
        Dim response = UsuariosBL.listarUsuarios()
        Dim dt As DataTable
        dt = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Nombre")
        If (response Is Nothing) Then
        Else
            For Each item As Usuario In response
                Dim dr As DataRow
                dr = dt.NewRow()
                dr("Codigo") = item.UsuarioID
                dr(1) = item.Apellidos


                dt.Rows.Add(dr)
            Next
            ComboBoxEjecutivos.DataSource = dt
            ComboBoxEjecutivos.ValueMember = "Codigo"
            ComboBoxEjecutivos.DisplayMember = "Descripcion"
        End If

    End Sub




    Private Sub AsignarListaProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararComboBoxUsuarios()

        '  Dim usuario = UsuariosBL.consultarUsuario(ComboBoxEjecutivos.SelectedValue)

    End Sub



    Private Sub actualizarIndicadoresAsignados(idRol As Integer)
        CargaDataGrids.llenarGrid(DataGridView1, ProspectoBL.ObtenerProspectoXUsuario(idRol))
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        For Each row As DataGridViewRow In DataGridView1.SelectedRows

            Dim usuario As Usuario = TryCast(row.DataBoundItem, Usuario)
            If usuario IsNot Nothing Then
                actualizarIndicadoresAsignados(usuario.UsuarioID)
            End If
        Next


    End Sub

    Private Sub actualizarListaUsuariosAsignados(idRol As Integer)
        CargaDataGrids.llenarGrid(DataGridView2, UsuariosBL.listaUsuariosXProspectos(idRol))
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click

        Dim user = ComboBoxEjecutivos


        Dim prospecto As Prospecto = TryCast(DataGridView1.SelectedRows(0).DataBoundItem, Prospecto)

        Dim usuario As Usuario



        If prospecto IsNot Nothing And user IsNot Nothing Then
            MessageBox.Show(UsuariosBL.asignarListaProspectos(ComboBoxEjecutivos.SelectedValue, prospecto.ProspectoID))
        End If



        actualizarListaUsuariosAsignados(ComboBoxEjecutivos.SelectedValue)

    End Sub
End Class

