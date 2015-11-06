Public Class Validaciones


    Shared Function VerificarNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Debe incluir números en este campo")
        End If
    End Function

    Shared Function VerificarLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Debe incluir letras en este campo")
        End If
    End Function
End Class
