Public Class CargaDataGrids
    Shared Function llenarGrid(ByVal grid As DataGridView, ByVal objetos As IEnumerable(Of Object)) As DataGridView
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = objetos
        grid.DataSource = bs
        bs.ResetBindings(False)
        estilizarDataGrid(grid)
        Return grid
    End Function

    Shared Sub estilizarDataGrid(ByRef dtg As DataGridView)
        Try
            With dtg
                .BorderStyle = BorderStyle.Fixed3D
                .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
                .RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(215, 215, 215)
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 210, 245)
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
                .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Font = New Font("Century Gothic", 9)
            End With
        Catch ex As Exception

        End Try
    End Sub


End Class
