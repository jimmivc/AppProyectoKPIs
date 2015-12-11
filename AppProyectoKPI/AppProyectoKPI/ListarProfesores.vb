Imports System.ComponentModel
Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO


Public Class ListarProfesores
    Private Sub ListarProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaDataGrids.llenarGrid(Me.dtgListarProfesores, UsuariosBL.ObtenerUsuarioXRol(4))
    End Sub
End Class