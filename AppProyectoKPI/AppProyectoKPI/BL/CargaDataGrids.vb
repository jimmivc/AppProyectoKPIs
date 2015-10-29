Public Class CargaDataGrids
    Shared Sub llenarGrid(ByVal grid As DataGridView, ByVal objeto As Object)
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = objeto
        grid.DataSource = bs
        bs.ResetBindings(False)
    End Sub
End Class
