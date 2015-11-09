Public Class CargaDataGrids
    Shared bs As New BindingSource()

    ''' <summary>
    ''' llenarGrid.  
    ''' Utilitario general para llenar un grid con una lista de objetos.
    ''' </summary>
    ''' <param name="Grid">grid - objeto de tipo DataGridView.</param>
    ''' <param name="Objetos">objetos - lista de objetos para poblar el data grid view.</param>
    ''' <returns>El método retorna un grid.</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function llenarGrid(ByVal grid As DataGridView, ByVal objetos As IEnumerable(Of Object)) As DataGridView
        bs = New BindingSource()
        bs.DataSource = objetos
        grid.DataSource = bs
        bs.ResetBindings(False)
        estilizarDataGrid(grid)
        Return grid
    End Function

    ''' <summary>
    ''' estilizarDataGrid.  
    ''' Utilitario general para estilizar un grid.
    ''' </summary>
    ''' <param name="dtg">grid - objeto de tipo DataGridView.</param>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Sub estilizarDataGrid(ByRef dtg As DataGridView)
        Try
            With dtg
                .BorderStyle = BorderStyle.Fixed3D
                .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
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
    Shared Function getBs()
        Return bs
    End Function

End Class
