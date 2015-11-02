Public Class IniciarSesion

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxUser.Text = "" And TextBoxPass.Text = "" Then
            MsgBox("Por favor ingrese usuario y contraseña")
        Else
            If TextBoxUser.Text = "admin@innova.com" And TextBoxPass.Text = "1234" Then
                Principal.Show()
            End If
        End If

    End Sub
End Class
