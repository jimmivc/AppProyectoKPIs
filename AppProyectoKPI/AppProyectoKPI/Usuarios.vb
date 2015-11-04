Public Class Usuarios
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtBxNombre Is Nothing Or txtBxApellidos Is Nothing Or txtBxID Is Nothing Or txtBxCorreo Is
            Nothing Or txtBxContrasena Is Nothing Or CombBxRol Is Nothing Then

            MessageBox.Show("Por favor rellene todos los campos requeridos")

        End If
    End Sub
End Class