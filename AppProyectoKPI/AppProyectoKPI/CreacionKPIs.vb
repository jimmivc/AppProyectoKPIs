Public Class CreacionKPIs

    Dim formula As List(Of String) = New List(Of String)
    Dim variable As List(Of String) = New List(Of String)
    Dim operador As Boolean = False
    Dim detalle As Boolean = True
    Dim limiteDefinido As Boolean = False
    Dim limiteSuperior As Integer
    Dim limiteInferior As Integer

    Dim modificar As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        actualizarListaKPIs()

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If (validarCampos()) Then
            MessageBox.Show(KPIsController.registrarIndicadorKPI(txtDescripcion.Text, lstFormatoKPI.SelectedItem, txtObjetivo.Text, formula, variable, limiteSuperior, limiteInferior))
            actualizarListaKPIs()
            btnCancelar.PerformClick()
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
                limiteSuperior = configurarObjetivo.lstLimiteSuperior.GetItemText(configurarObjetivo.lstLimiteSuperior.SelectedIndex)
                limiteInferior = configurarObjetivo.lstLimiteInferior.GetItemText(configurarObjetivo.lstLimiteInferior.SelectedIndex)
                limiteDefinido = True
                'txtFormula.Text = limiteInferior.ToString + limiteSuperior.ToString + limiteDefinido.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Objetivo no valido")
        End Try

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        formula = New List(Of String)
        variable = New List(Of String)
        txtFormula.Text = ""
        operador = False
        detalle = True
    End Sub

    Private Sub calcularLimite()
        Dim objetivo As Integer = txtObjetivo.Text
        limiteSuperior = objetivo
        limiteInferior = objetivo / 2

    End Sub

    Private Sub actualizarListaKPIs()
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = KPIsController.listarIndicadoresKPI()
        dtgListarKPIs.DataSource = bs
        bs.ResetBindings(False)
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        For Each row As DataGridViewRow In dtgListarKPIs.SelectedRows

            Dim kpi As KPI = TryCast(row.DataBoundItem, KPI)
            If kpi IsNot Nothing Then
                Dim kpiConsultado = KPIsController.consultarKPI(kpi.KPIID)
                Dim consulta As New ConsultarKPI(kpiConsultado)
                consulta.ShowDialog()
            End If
        Next

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnGuardar.Visible = True
        btnCancelar.Visible = True
        btnBorrar.PerformClick()

        btnSumar.Visible = False
        btnRestar.Visible = False
        btnMultiplicar.Visible = False
        btnDividir.Visible = False

        txtValor.Visible = False
        btnAgregarValor.Visible = False

        lstCampo.Visible = False
        txtObjetivo.Enabled = False
        btnBorrar.Visible = False

        btnConfigurar.Enabled = False

        For Each row As DataGridViewRow In dtgListarKPIs.SelectedRows

            Dim kpi As KPI = TryCast(row.DataBoundItem, KPI)
            If kpi IsNot Nothing Then
                Dim kpiConsultado = KPIsController.consultarKPI(kpi.KPIID)
                txtDescripcion.Text = kpiConsultado.DescKpi
                txtObjetivo.Text = kpiConsultado.Objetivo
                lstFormatoKPI.SelectedIndex = lstFormatoKPI.FindString(kpiConsultado.Formato)

                For Each param As DetalleFormula In kpiConsultado.Formula
                    If (param.TipoDato.Equals("campo")) Then
                        txtFormula.Text += param.Tabla
                        formula.Add(param.Tabla)
                        variable.Add("campo")
                    ElseIf (param.TipoDato.Equals("operador")) Then
                        txtFormula.Text += param.DescCampoOperador
                        formula.Add(param.DescCampoOperador)
                        variable.Add("operador")
                    ElseIf (param.TipoDato.Equals("valor")) Then
                        txtFormula.Text += param.Valor.ToString
                        formula.Add(param.Valor)
                        variable.Add("valor")
                    End If
                    modificar = kpiConsultado.KPIID
                Next

                limiteSuperior = kpiConsultado.Parametro.LimiteSuperior
                limiteInferior = kpiConsultado.Parametro.LimiteInferior
                limiteDefinido = True

            End If

        Next

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (validarCampos()) Then
            MessageBox.Show(KPIsController.modificarKPI(modificar, txtDescripcion.Text, lstFormatoKPI.SelectedItem, txtObjetivo.Text, formula, variable, limiteSuperior, limiteInferior))
            actualizarListaKPIs()
            btnCancelar.PerformClick()
        End If
    End Sub

    Private Function validarCampos() As Boolean
        Dim result = False

        If (Not txtDescripcion.Text.Equals("") And Not txtFormula.Text.Equals("") And Not lstFormatoKPI.SelectedItem = Nothing And Not txtObjetivo.Text.Equals("")) Then
            If (Not variable(variable.Count - 1).Equals("operador")) Then
                If (Not limiteDefinido) Then
                    calcularLimite()
                End If
                result = True
            Else
                MessageBox.Show("Formula incompleta")
            End If
        Else
            MessageBox.Show("Datos incompletos")
        End If

        Return result
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        btnModificar.Visible = True
        btnRegistrar.Visible = True

        txtDescripcion.Clear()
        txtValor.Clear()
        txtFormula.Clear()
        txtObjetivo.Clear()
        limiteDefinido = False

        btnSumar.Visible = True
        btnRestar.Visible = True
        btnMultiplicar.Visible = True
        btnDividir.Visible = True
        btnBorrar.Visible = True
        btnConfigurar.Enabled = True

        txtValor.Visible = True
        btnAgregarValor.Visible = True

        lstCampo.Visible = True

        txtObjetivo.Enabled = True
    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        For Each row As DataGridViewRow In dtgListarKPIs.SelectedRows

            Dim kpi As KPI = TryCast(row.DataBoundItem, KPI)
            If kpi IsNot Nothing Then
                MessageBox.Show(KPIsController.deshabilitarKPI(kpi.KPIID))
                actualizarListaKPIs()
            End If
        Next
        btnCancelar.PerformClick()
    End Sub
End Class
