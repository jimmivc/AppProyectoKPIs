Public Class Validaciones

    ''' <summary>
    ''' VerificarNumeros.  
    ''' Valida que los campos solo contengan números.
    ''' </summary>
    ''' <param name="e">parámetro de tipo System.Windows.Forms.KeyPressEventArgs.</param>
    ''' <returns>Booleano acetando o denegando la inclusión</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
    ''' <summary>
    ''' VerificarLetras.  
    ''' Valida que los campos solo contengan letras.
    ''' </summary>
    ''' <param name="e">parámetro de tipo System.Windows.Forms.KeyPressEventArgs.</param>
    ''' <returns>Booleano acetando o denegando la inclusión</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
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
    ''' <summary>
    ''' VerificarLetras.  
    ''' Valida que los campos no esten vacios
    ''' </summary>
    ''' <param name="texto">parámetro de tipo String</param>
    ''' <returns>Booleano acetando o denegando la inclusión</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function CadenaNoVacia(ByVal texto As String)
        Return texto <> ""
    End Function
End Class
