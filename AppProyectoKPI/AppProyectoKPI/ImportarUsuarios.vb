Public Class ImportarUsuarios
    Private path As String = ""
    Private Sub btnCargarArchivo_Click(sender As Object, e As EventArgs) Handles btnCargarArchivo.Click
        Dim openFile As OpenFileDialog = New OpenFileDialog
        openFile.Filter = "Excel Worksheets|*.xlsx"
        openFile.ShowDialog()
        txtPath.Text = openFile.FileName
        path = txtPath.Text
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim tipoImportacion As Integer = 0
        If (cbxImportar.Text = "") Then
            MsgBox("Debe seleccionar un tipo de lista para importar")
        Else
            If (cbxImportar.Text = "Profesores") Then
                tipoImportacion = 4
                UsuariosBL.ImportarUsuarios(path, ProgressBar1, tipoImportacion)
            ElseIf (cbxImportar.Text = "Estudiantes") Then
                tipoImportacion = 5
                UsuariosBL.ImportarUsuarios(path, ProgressBar1, tipoImportacion)
            Else
                MsgBox("Debe seleccionar un tipo válido")
            End If
        End If


    End Sub

    Private Sub ImportarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class