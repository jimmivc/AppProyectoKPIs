

Imports System.Configuration
    Imports RestSharp
    Imports System.Net
    Imports System.IO




Public Class RegistrarVenta



    Private Sub BtnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles BtnRegistrarVenta.Click

        Dim fecha = textFecha.Text
        Dim periodo = ComboBoxPeriodo
        Dim categoria = ComboCategoria
        Dim descripcion = TextDescripcion.Text
        Dim monto = TextMonto.Text




        If (textFecha.Text = "" And TextDescripcion.Text = "" And TextMonto.Text = "" And TextBuscar.Text = "" And TextIdMercadeo.Text = "") Then
            MsgBox("Debe llegar el registro")

        Else

            'VALIDACION DE CAMPOS 

            If (descripcion) = "" Then
                MsgBox("Llenar campos")

            ElseIf IsNumeric(descripcion) Then
                MsgBox("solo acepta caracteres")
            Else

                If (monto) = "" Then

                    MsgBox("ingrese datos validos, numericos")

                Else

                    Dim cliente As New Prospecto()



                    cliente.Identificacion = TextBuscar.Text


                    VentaBL.registrarVenta(textFecha.Text, ComboBoxPeriodo.Text, ComboCategoria.Text, descripcion, monto, cliente)
                    MsgBox("Se registro correctamente")

                    Dim venta As New Venta
                    venta.Fecha = textFecha.Text
                    venta.Periodo = periodo.Text
                    venta.Categoria = categoria.Text
                    venta.Descripcion = descripcion
                    venta.Monto = monto


                End If
            End If
        End If


    End Sub


    Private Sub BuscarCliente_Click(sender As Object, e As EventArgs) Handles BuscarCliente.Click



        If (TextBuscar.Text = "") Then

            MsgBox("Ingrese el numero de identificacion")
        Else

            CargaBusquedaProspecto_Load(TextBuscar.Text)

        End If


    End Sub
    Private Sub CargaBusquedaProspecto_Load(ByVal identificacion As String)




        Dim response = ProspectoBL.ObtenerProspectoXIdentificacion(identificacion)

        If (response Is Nothing) Then
            MsgBox("no se encontro prospecto")
        Else

            Dim usuario As New Usuario()



            'Me.TextDescripcion.Text = response.Identificacion
            Me.TextIdMercadeo.Text = response.Nombre
            Me.TextVendedor.Text = response.Usuario.Nombre



        End If

    End Sub


    Private Sub TextMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextMonto.KeyPress
        Validaciones.VerificarNumeros(e)

    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click


        TextDescripcion.Text = ""
        TextMonto.Text = ""
        TextBuscar.Text = ""
        TextIdMercadeo.Text = ""
        TextVendedor.Text = ""



    End Sub


End Class

