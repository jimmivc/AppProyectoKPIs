Public Class IniciarSesion

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim valid = False

        If TextBoxUser.Text = "" Or TextBoxPass.Text = "" Then
            MsgBox("Por favor ingrese usuario y contraseña")
        ElseIf TextBoxUser.Text = "admin@innova.com" And TextBoxPass.Text = "1234" Then
            valid = True
        Else
            MsgBox("Usuario o contraseña incorrecto")
        End If

        If valid = True Then
            Principal.Show()
        End If

        Dim enc As New Encrypt(TextBoxPass.Text)
        Dim StringEnc As String = enc.EncryptData(TextBoxPass.Text)
        Dim StrNoEnc As String = enc.DecryptData(StringEnc)
        MsgBox(StringEnc)
        MsgBox(StrNoEnc)

    End Sub

End Class
