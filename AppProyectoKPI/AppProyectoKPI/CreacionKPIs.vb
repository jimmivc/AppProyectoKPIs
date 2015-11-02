Public Class CreacionKPIs

    Dim formula As List(Of String) = New List(Of String)
    Dim variable As List(Of String) = New List(Of String)
    Dim operador As Boolean = False
    Dim detalle As Boolean = True
    Dim limiteDefinido As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = KPIsController.listarIndicadoresKPI()

        dtgListarKPIs.DataSource = bs
        'dtgListarKPIs.Columns.Remove("Parametro")

        bs.ResetBindings(False)
    End Sub

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

    ''' <summary>
    ''' Metodo que sirve para armar la formula del indicador kpi, recibe un valor y lo agrega al arreglo de la formula
    ''' </summary>
    ''' <param name="dato">tabla,operador o valor</param>
    ''' <remarks></remarks>
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
    ''' <summary>
    ''' metodo que agrega el nombre del campo a la formula
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCampo.SelectedIndexChanged
        If (lstCampo.SelectedIndex <> 0) Then
            armarFormula(lstCampo.SelectedItem)
            variable.Add("campo")
        End If


    End Sub
    ''' <summary>
    ''' Validacion si el dato que llega es un operador matematico o no
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function isOperador(dato As String) As Boolean
        Dim resul As Boolean
        If (dato.Equals("+") Or dato.Equals("-") Or dato.Equals("/") Or dato.Equals("*")) Then
            resul = True
        Else
            resul = False
        End If
        Return resul
    End Function

    ''' <summary>
    ''' Metodo que evita que el usuario ingrese valores que no sean numeros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged, txtObjetivo.TextChanged
        Dim textbox = CType(sender, TextBox)
        Try
            Convert.ToDouble(textbox.Text)
        Catch ex As Exception
            textbox.Text = ""
        End Try
    End Sub

    ''' <summary>
    ''' Validaciones de todos los campos, evento para registrar todos los datos ingresados por el usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not txtFormula.Text.Equals("") And Not lstFormatoKPI.SelectedItem = Nothing And Not txtObjetivo.Text.Equals("")) Then
            If (Not variable(variable.Count - 1).Equals("operador")) Then
                MessageBox.Show(KPIsController.registrarIndicadorKPI(txtDescripcion.Text, lstFormatoKPI.SelectedItem, txtObjetivo.Text, formula, variable, limiteDefinido))
            Else
                MessageBox.Show("Formula incompleta")
            End If
        Else
            MessageBox.Show("Datos incompletos")
        End If
    End Sub

    ''' <summary>
    ''' Evento cuando el usuario configura un rango deseado para el despliegue del resultado kpi 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
