

Public Class ImportarProspecto
    Private path As String = ""
    Private Sub btnListarProspectos_Click(sender As Object, e As EventArgs) Handles btnListarProspectos.Click
        Dim openFile As OpenFileDialog = New OpenFileDialog
        openFile.Filter = "Excel Worksheets|*.xlsx"
        openFile.ShowDialog()
        txtPath.Text = openFile.FileName
        path = txtPath.Text
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        ProspectoBL.ImportarProspectos(path, ProgressBar1)

    End Sub

    Private Sub ImportarProspecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class