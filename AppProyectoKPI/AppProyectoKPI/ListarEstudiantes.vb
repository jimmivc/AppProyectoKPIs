Imports System.ComponentModel
Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO


Public Class ListarEstudiantes
    Private Sub ListarEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaDataGrids.llenarGrid(Me.dtgListarEstudiantes, UsuariosBL.ObtenerUsuarioXRol(5))
    End Sub
End Class