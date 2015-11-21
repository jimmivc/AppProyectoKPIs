Public Class Paneles
    ''' <summary>
    ''' AgregarFormularioEnPanel.  
    ''' Agrega un formulario específico a un panel.
    ''' </summary>
    ''' <param name="form">id - parámetro de tipo Form.</param>
    ''' <param name="panel">id - parámetro de tipo Panel.</param>
    ''' <returns>Retorna el form</returns>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Function AgregarFormularioEnPanel(ByRef form As Form, ByRef panel As Panel) As Form
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        panel.Controls.Add(form)
        form.Show()
        Return form
    End Function
    ''' <summary>
    ''' EliminarFormularioEnPanel.  
    ''' Elimina un formulario específico a un panel.
    ''' </summary>
    ''' <param name="form">id - parámetro de tipo Form.</param>
    ''' <param name="panel">id - parámetro de tipo Panel.</param>
    ''' <remarks><para>Historia de Creación y modificaciones:
    ''' <list type="bullet">
    ''' <item>Autor.: Christian Ulloa Tosso </item>
    ''' <item>07/11/2015 - Creación</item>
    ''' </list></para></remarks>
    Shared Sub EliminarFormularioEnPanel(ByRef form As Form, ByRef panel As Panel)
        'form.Dispose()
        form.TopLevel = False
        panel.Controls.Remove(form)
    End Sub
End Class
