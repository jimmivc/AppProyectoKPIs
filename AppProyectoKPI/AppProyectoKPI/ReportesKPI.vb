Public Class ReportesKPI
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaRoles()
        CargaDataGrids.estilizarDataGrid(dtgResultados)
    End Sub

    Private Sub actualizarListaRoles()
        Dim listaRoles As List(Of Rol) = RolesBL.listarRoles()

        CargaDataGrids.llenarGrid(dtgRoles, listaRoles)
    End Sub

    Private Sub actualizarResultados(idRol As Integer)
        dtgResultados.Rows.Clear()
        Dim rol As Rol = TryCast(dtgRoles.SelectedRows(0).DataBoundItem, Rol)
        Dim resultados As List(Of List(Of String)) = KPIsController.calcularResultados(rol.RolID)


        Dim colores As Integer = 0

        For i = 0 To resultados.Count - 1
            Dim kpi As Integer = 0
            Dim nombres As Integer = 1
            Dim formato As String = 2
            Dim objetivo As String = 3
            Dim resul As Integer = 4
            Dim semaforos As Integer = 5

            For j = 0 To (resultados(0).Count / 6) - 1

                dtgResultados.Rows.Add(resultados(i)(kpi), resultados(i)(nombres), resultados(i)(formato), resultados(i)(objetivo), resultados(i)(resul), "")

                Select Case resultados(i)(semaforos)
                    Case "verde"
                        dtgResultados.Rows(colores).Cells(5).Style.BackColor = System.Drawing.Color.Green
                    Case "amarillo"
                        dtgResultados.Rows(colores).Cells(5).Style.BackColor = System.Drawing.Color.Yellow
                    Case "rojo"
                        dtgResultados.Rows(colores).Cells(5).Style.BackColor = System.Drawing.Color.Red
                End Select
                kpi += 6
                nombres += 6
                resul += 6
                semaforos += 6
                objetivo += 6
                formato += 6
                colores += 1
            Next

        Next
    End Sub

    Private Sub dtgRoles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRoles.CellClick
        For Each row As DataGridViewRow In dtgRoles.SelectedRows

            Dim rol As Rol = TryCast(row.DataBoundItem, Rol)
            If rol IsNot Nothing Then
                actualizarResultados(rol.RolID)
            End If
        Next
    End Sub
End Class
