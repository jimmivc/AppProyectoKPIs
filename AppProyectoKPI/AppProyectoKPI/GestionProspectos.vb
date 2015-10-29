

Public Class GestionProspectos
    Private Sub GestionProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContactoController.CrearContacto()
        CargaDataGrids.llenarGrid(Me.dtg_FormasContacto, ContactoController.getContacto())
    End Sub
End Class