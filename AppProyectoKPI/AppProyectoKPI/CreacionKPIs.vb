Public Class CreacionKPIs

    Dim formula As List(Of String) = New List(Of String)
    Dim variable As List(Of String) = New List(Of String)
    Dim operador As Boolean = False
    Dim detalle As Boolean = True
    Dim limiteDefinido As Boolean = False

    ''' <summary>
    ''' Evento para el boton agregar valor, valida el valor ingresado por el usuario y lo agrega a un arreglo
    ''' para su posterior envio al api
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAgregarValor_Click(sender As Object, e As EventArgs) Handles btnAgregarValor.Click
        If (txtValor.Text <> "") Then
            armarFormula(txtValor.Text)
            variable.Add("valor")
            txtValor.Text = ""
        End If

    End Sub

    ''' <summary>
    ''' Evento para todos los botones operadores, sirven para crear la formula, se agrega al arreglo
    ''' el operador seleccionado 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOperador_Click(sender As Object, e As EventArgs) Handles btnSumar.Click, btnRestar.Click, btnMultiplicar.Click, btnDividir.Click
        Dim operador = CType(sender, Button).Text
        If (Not operador.Equals("")) Then
            armarFormula(operador)
            variable.Add("operador")
            txtValor.Text = ""
        End If
    End Sub

    Private Sub armarFormula(dato As String)

        If (operador = False And Not isOperador(dato)) Then
            formula.Add(dato)
            operador = True
        Else
            If (operador = True And isOperador(dato)) Then
                formula.Add(dato)
                operador = False
                detalle = True
            Else
                MessageBox.Show("orden de parametros incorrectos")
            End If
        End If

        txtFormula.Text = ""

        For Each dat As String In formula
            txtFormula.Text += dat
        Next
    End Sub

    Private Sub lstCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCampo.SelectedIndexChanged
        If (lstCampo.SelectedIndex <> 0) Then
            armarFormula(lstCampo.SelectedItem)
            variable.Add("campo")
        End If


    End Sub

    Private Function isOperador(dato As String) As Boolean
        Dim resul As Boolean
        If (dato.Equals("+") Or dato.Equals("-") Or dato.Equals("/") Or dato.Equals("*")) Then
            resul = True
        Else
            resul = False
        End If
        Return resul
    End Function

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Try
            Convert.ToInt32(txtValor.Text)
        Catch ex As Exception
            txtValor.Text = ""
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not txtFormula.Text.Equals("") And Not lstFormatoKPI.SelectedItem = Nothing And Not txtObjetivo.Text.Equals("")) Then
            If (Not variable(variable.Count - 1).Equals("operador")) Then
                txtFormula.Text = txtFormula.Text + lstFormatoKPI.SelectedItem.ToString + txtObjetivo.Text + txtDescripcion.Text + limiteDefinido.ToString()

                For i As Integer = 0 To variable.Count - 1
                    txtFormula.Text += variable(i).ToString() + ":" + formula(i).ToString()
                Next

            Else
                MessageBox.Show("Formula incompleta")
            End If
        Else
            MessageBox.Show("Datos incompletos")
        End If
    End Sub

    Private Sub btnConfigurar_Click(sender As Object, e As EventArgs) Handles btnConfigurar.Click
        Try
            Dim objetivo As Double = txtObjetivo.Text
            Dim configurarObjetivo As New ElegirRangoKPI(txtObjetivo.Text)

            If (configurarObjetivo.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                Dim limiteSuperior As Double = configurarObjetivo.lstLimiteSuperior.GetItemText(configurarObjetivo.lstLimiteSuperior.SelectedIndex)
                Dim limiteInferior As Double = configurarObjetivo.lstLimiteInferior.GetItemText(configurarObjetivo.lstLimiteInferior.SelectedIndex)
                limiteDefinido = True
                'txtFormula.Text = limiteInferior.ToString + limiteSuperior.ToString + limiteDefinido.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Objetivo no valido")
        End Try

    End Sub
End Class
