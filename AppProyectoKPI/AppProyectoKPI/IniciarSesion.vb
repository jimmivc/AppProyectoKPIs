Public Class IniciarSesion

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim valid = False

        Dim pass As String = TextBoxPass.Text
        Dim correo As String = TextBoxUser.Text

        Try
            Dim usuario As Usuario = loginController.iniciarSesion(correo, pass)
            valid = True
        Catch ex As Exception
            MessageBox.Show("Correo o aqui")
        End Try

        If valid = True Then
            Principal.Show()
            Me.Hide()
        End If

    End Sub

End Class
