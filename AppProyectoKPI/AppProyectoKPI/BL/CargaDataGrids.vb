Public Class CargaDataGrids
    Shared Sub llenarGrid(ByVal grid As DataGridView, ByVal objetos As List(Of Object))
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = objetos
        grid.DataSource = bs
        bs.ResetBindings(False)
    End Sub
End Class
