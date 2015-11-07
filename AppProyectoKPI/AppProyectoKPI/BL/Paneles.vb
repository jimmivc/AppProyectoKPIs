Public Class Paneles
    Shared Function AgregarFormularioEnPanel(ByVal form As Form, ByVal panel As Panel) As Form
        form.TopLevel = False
        'form.FormBorderStyle = WindowsForm
        form.Dock = DockStyle.Fill
        panel.Controls.Add(form)
        form.Show()
        Return form
    End Function

End Class
