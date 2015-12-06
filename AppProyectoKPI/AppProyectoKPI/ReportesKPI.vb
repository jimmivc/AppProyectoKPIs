Public Class ReportesKPI
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaRoles()
        actualizarRegistrosAsignados(TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol).RolID)
        CargaDataGrids.estilizarDataGrid(dtgResultados)
    End Sub

    Private Sub actualizarListaRoles()
        Dim listaRoles As List(Of Rol) = RolesBL.listarRoles()

        CargaDataGrids.llenarGrid(dtgRoles, listaRoles)
    End Sub

    Private Sub actualizarRegistrosAsignados(idRol As Integer)
        CargaDataGrids.llenarGrid(dtgRegistros, RegistrosBL.listarRegistrosMercadeoUsuarios(idRol))
    End Sub

    Private Sub dtgRegistros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellClick
        For Each row As DataGridViewRow In dtgRegistros.SelectedRows

            Dim registro As RegistroMercadeo = TryCast(row.DataBoundItem, RegistroMercadeo)
            If registro IsNot Nothing Then
                actualizarResultados(registro.RegistroMercadeoID)
            End If
        Next
    End Sub

    Private Sub actualizarResultados(idRegistro As Integer)
        dtgResultados.Rows.Clear()
        Dim rol As Rol = TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol)
        Dim resultados As List(Of List(Of String)) = KPIsController.calcularResultados(rol.RolID, idRegistro)


        Dim colores As Integer = 0

        For i = 0 To resultados.Count - 1
            Dim kpi As Integer = 0
            Dim nombres As Integer = 1
            Dim resul As Integer = 2
            Dim semaforos As Integer = 3

            For j = 0 To (resultados(0).Count / 4) - 1

                dtgResultados.Rows.Add(resultados(i)(kpi), resultados(i)(nombres), resultados(i)(resul), "")

                Select Case resultados(i)(semaforos)
                    Case "verde"
                        dtgResultados.Rows(colores).Cells(3).Style.BackColor = System.Drawing.Color.Green
                    Case "amarillo"
                        dtgResultados.Rows(colores).Cells(3).Style.BackColor = System.Drawing.Color.Yellow
                    Case "rojo"
                        dtgResultados.Rows(colores).Cells(3).Style.BackColor = System.Drawing.Color.Red
                End Select
                kpi += 4
                nombres += 4
                resul += 4
                semaforos += 4
                colores += 1
            Next

        Next



    End Sub

End Class