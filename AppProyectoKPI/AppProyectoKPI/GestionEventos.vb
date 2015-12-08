
Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports AppProyectoKPI

Public Class GestionEventos

    Dim Dt As New DataTable
    Public Property BtnActualizar As Object
    Private bsEvento As New BindingSource()

    Private Sub ConsulEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextId.Enabled = False


    End Sub

    Private Sub hideColums()

        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False

    End Sub




    Private Sub btnAgregarEvento_Click(sender As Object, e As EventArgs) Handles btnAgregarValor.Click
        Dim identificacion = TextId.Text
        Dim descripcion = TextDescripcion.Text
        Dim fecha = TextFecha.Text
        Dim lugar = TextLugar.Text

        Dim row = DataGridView1.CurrentRow()


        If (TextDescripcion.Text = "" And TextFecha.Text = "" And TextLugar.Text = "") Then
            MsgBox("Debe llegar el registro")

        Else

            'VALIDACION DE CAMPOS 

            If (descripcion) = "" Then
                MsgBox("Llenar campos")

            ElseIf IsNumeric(descripcion) Then
                MsgBox("solo acepta caracteres")
            Else

                If IsDate(fecha) = False And Not (fecha = "") Then

                    MsgBox("llenar fecha formato mes/dia/año", MsgBoxStyle.Critical, "Formato de fecha no valido")
                Else

                    If (fecha = "") Then

                    Else
                        fecha = CDate(TextFecha.Text)

                        MsgBox("correcto")
                    End If

                    If (lugar) = "" Then
                        lugar = 0
                        MsgBox("llenar campos")
                    Else
                        MsgBox("correcto")
                        EventoBL.registrarEvento(descripcion, fecha, lugar)
                        Button3_Click(sender, e)

                        Dim evento As New Evento
                        evento.DescEventoCaptacion = descripcion
                        evento.FechaEvento = fecha
                        evento.LugarEvento = lugar

                        TextDescripcion.Text = ""
                        TextFecha.Text = ""
                        TextLugar.Text = ""

                    End If
                End If
            End If

        End If


    End Sub



    Private Sub listaEvento_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (TextBuscar.Text = "") Then
            TextId.Visible = False

        Else
            BtnCancelar.Visible = True
            btnAgregarValor.Visible = False
            LlenaDrigridEvento_Load(TextBuscar.Text)

        End If
        ' actualizarListaEventos()

        '  End If

    End Sub


    Private Sub LlenaDrigridEvento_Load(ByVal id As Integer)


        Dim row = DataGridView1.CurrentRow()
        Dim evento As New Evento()
        evento.EventoID = id

        evento = EventoBL.ObtenerEvento(evento.EventoID)

        If (IsNothing(evento)) Then
            MsgBox("valor invalido, no se encontro el evento que busca")

        Else

            TextId.Text = evento.EventoID

            TextDescripcion.Text = evento.DescEventoCaptacion

            TextFecha.Text = evento.FechaEvento

            TextLugar.Text = evento.LugarEvento

            TextId.Visible = True
            Me.DataGridView1.DataSource = Dt

            CargaDataGrids.llenarGrid(DataGridView1, EventoBL.ObtenerListaEventos())

            TextId.Text = evento.EventoID

            TextDescripcion.Text = evento.DescEventoCaptacion
            TextFecha.Text = evento.FechaEvento
            TextLugar.Text = evento.LugarEvento

            TextId.Visible = True
        End If

        hideColums()
    End Sub


    Private Sub ClickBtnActualizar(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        TextId.Text = DataGridView1.SelectedCells.Item(0).Value
        TextDescripcion.Text = DataGridView1.SelectedCells.Item(1).Value
        TextFecha.Text = DataGridView1.SelectedCells.Item(2).Value
        TextLugar.Text = DataGridView1.SelectedCells.Item(3).Value

        TextId.Enabled = False
        TextDescripcion.Text = (TextDescripcion.Text)
        TextFecha.Text = (TextFecha.Text)
        TextLugar.Text = (TextLugar.Text)

        Button1.Visible = True

        BtnCancelar.Visible = True
        TextId.Enabled = False
        btnAgregarValor.Enabled = False

        CargaDataGrids.llenarGrid(DataGridView1,
                                                                      EventoBL.ObtenerListaEventos())
        'Me.DataGridView1.DataSource = Dt

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim Dt = EventoBL.ObtenerListaEventos
        If (Dt.ToString = Nothing) Then
            MsgBox("no hay respuesta")
        Else
            configurarColumnasListadoEventos(CargaDataGrids.llenarGrid(DataGridView1,
                                                                      EventoBL.ObtenerListaEventos()))


        End If
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
    End Sub

    Public Sub configurarColumnasListadoEventos(ByRef dtg As DataGridView)
        bsEvento = dtg.DataSource

        Try
            With dtg
                .Columns(0).Visible = False
                .Columns(1).Width = 95
                .Columns(1).HeaderText = "Descripcion"
                .Columns(2).Width = 80
                .Columns(2).HeaderText = "Fecha"
                .Columns(3).HeaderText = "Lugar"
                .Columns(3).Width = 90
                .Columns(4).HeaderText = ""
                .Columns(4).Width = 90


            End With

        Catch ex As Exception

        End Try

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        If (TextDescripcion.Text = "" And (TextFecha.Text = "" And TextLugar.Text = "")) Then

            Button1.Visible = True
            MsgBox("Debe seleccionar el evento que quiere modificar")

        Else

            result = MessageBox.Show("Desea actualizar los datos?", "Modificando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (result = DialogResult.OK) Then


                Dim identificacion = TextId.Text
                Dim descripcion = TextDescripcion.Text
                Dim fecha = TextFecha.Text
                Dim lugar = TextLugar.Text

                Dim row = DataGridView1.CurrentRow()



                fecha = CDate(TextFecha.Text)


                If (descripcion) = "" Then
                    MsgBox("Llenar campos")

                ElseIf IsNumeric(descripcion) Then
                    MsgBox("solo acepta caracteres")
                Else

                    If IsDate(fecha) = False And Not (fecha = "") Then

                        MsgBox("llenar fecha formato mes/dia/año", MsgBoxStyle.Critical, "Formato de fecha no valido")
                    Else

                        If (fecha = "") Then

                        Else
                            fecha = CDate(TextFecha.Text)

                            MsgBox("correcto")
                        End If

                        If (lugar) = "" Then
                            lugar = 0
                            MsgBox("llenar campos")
                        Else
                            MsgBox("correcto")


                            EventoBL.actualizarDatos(identificacion, descripcion, fecha, lugar)

                            Button3_Click(sender, e)
                        End If
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        TextId.Text = ""
        TextDescripcion.Text = ""
        TextFecha.Text = ""
        TextLugar.Text = ""
        btnAgregarValor.Visible = True
        BtnCancelar.Visible = False
        btnAgregarValor.Enabled = True

    End Sub



    Private Sub TextBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBuscar.KeyPress
        Validaciones.VerificarNumeros(e)

    End Sub



End Class


