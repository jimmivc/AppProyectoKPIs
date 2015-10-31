Public Class ElegirRangoKPI

    Dim objetivo As Double

    Sub New(pobjetivo As Double)
        InitializeComponent()
        objetivo = pobjetivo

        For i = 0 To objetivo
            lstLimiteSuperior.Items.Add(i)
        Next

    End Sub

    Private Sub lstLimiteSuperior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLimiteSuperior.SelectedIndexChanged
        lstLimiteInferior.Items.Clear()
        Dim dato As Double = lstLimiteSuperior.GetItemText(lstLimiteSuperior.SelectedIndex)
        For i = 1 To dato
            lstLimiteInferior.Items.Add(i - 1)
        Next
        verde.Text = "KPI>=" + dato.ToString

    End Sub

    Private Sub lstLimiteInferior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLimiteInferior.SelectedIndexChanged
        Dim datoInferior As Double = lstLimiteInferior.GetItemText(lstLimiteInferior.SelectedIndex)
        Dim datoSuperior As Double = lstLimiteSuperior.GetItemText(lstLimiteSuperior.SelectedIndex)
        amarillo.Text = datoInferior.ToString + "-" + datoSuperior.ToString
        rojo.Text = "KPI <" + datoInferior.ToString
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (Not lstLimiteInferior.SelectedItem.Equals("") And Not lstLimiteSuperior.SelectedItem.Equals("")) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Seleccione los limites requeridos")
        End If
    End Sub
End Class