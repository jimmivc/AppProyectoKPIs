Public Class Paneles
    Shared Sub AgregarFormularioEnPanel(ByVal form As Form, ByVal panel As Panel)
        form.TopLevel = False
        'form.FormBorderStyle = WindowsForm
        form.Dock = DockStyle.Fill
        panel.Controls.Add(form)
        form.Show()
    End Sub

End Class
