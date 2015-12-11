Imports System.ComponentModel
Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO


Public Class ListarCursos
    Private Sub ListarProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaDataGrids.llenarGrid(Me.dtgListarCursos, CursosBL.ListarCursos())
    End Sub
End Class