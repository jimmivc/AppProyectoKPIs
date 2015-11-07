Public Class AsignacionKPIs
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaKPIs()
    End Sub

    Private Sub actualizarListaKPIs()
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = KPIsController.listarIndicadoresKPI()
        dtgListarKPIs.DataSource = bs
        bs.ResetBindings(False)
    End Sub
End Class
