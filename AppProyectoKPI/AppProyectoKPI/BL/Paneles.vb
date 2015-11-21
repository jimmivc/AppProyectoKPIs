Public Class Paneles
    Shared Function AgregarFormularioEnPanel(ByRef form As Form, ByRef panel As Panel) As Form
        form.TopLevel = False
        'form.FormBorderStyle = WindowsForm
        form.Dock = DockStyle.Fill
        panel.Controls.Add(form)
        form.Show()
        Return form
    End Function
    Shared Sub EliminarFormularioEnPanel(ByRef form As Form, ByRef panel As Panel)
        'form.Dispose()
        form.TopLevel = False
        panel.Controls.Remove(form)


    End Sub
End Class
