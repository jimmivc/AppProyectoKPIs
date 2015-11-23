

Imports System.Configuration
Imports RestSharp
Imports System.Net
Imports System.IO
Imports AppProyectoKPI.CargaDataGrids
Imports System.Collections

Imports AppProyectoKPI



Public Class GestionEmpresarial



    'VARIABLES GLOBALES

    Dim Dt As New DataTable
    Private bsEmpresa As New BindingSource()
    Dim listEmpresa As New List(Of GestionEmpresarial)
    'Private empresa As FormGestionEmpresarial

    Private Sub GestionEmpresarial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextId.Enabled = False


    End Sub

    'REGISTRA EMPRESA
    Private Sub btnAgregarEmpresa_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpresa.Click
        Dim empresa As New GrupoEmpresarial
        Dim pasaVerificacion As Boolean = True
        If (TextDescriccion.Text = "") Then
            MsgBox("Debe incluir una descripcion")
        Else
            Dim descripcion = TextDescriccion.Text

            GrupoEmpresarialBL.RegistrarEmpresa(descripcion)
            BtnListar_Click(sender, e)
            MsgBox("Se registro correctamente")
            empresa.DescGrupoEmpresarial = descripcion


            TextDescriccion.Text = ""



        End If

    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click


        If (TextBuscar.Text = "") Then
            TextId.Visible = False

        Else
            BtnCancelar.Visible = True
            btnAgregarEmpresa.Visible = False
            LlenaDrigridEmpresa_Load(TextBuscar.Text)

        End If

    End Sub

    Private Sub LlenaDrigridEmpresa_Load(ByVal id As Integer)
        Dim s As String = Nothing


        Dim empresa As New GrupoEmpresarial
        empresa = GrupoEmpresarialBL.ObtenerEmpresa(id)


        If (IsNothing(empresa)) Then
            MsgBox("valor invalido, no se encontro la empresa que busca")

        Else


            CargaDataGrids.llenarGrid(DataGridViewListaEmpresa,
                                                                      GrupoEmpresarialBL.ObtenerListaEmpresa())

            TextId.Text = empresa.GrupoEmpresarialID

            TextDescriccion.Text = empresa.DescGrupoEmpresarial

            TextId.Visible = True
        End If



    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewListaEmpresa.CellClick


        TextId.Text = DataGridViewListaEmpresa.SelectedCells.Item(0).Value
        TextDescriccion.Text = DataGridViewListaEmpresa.SelectedCells.Item(1).Value


        TextId.Visible = True
        BtnActualizar.Visible = True

        TextId.Enabled = False
        btnAgregarEmpresa.Enabled = False


        configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(DataGridViewListaEmpresa,
                                                                      GrupoEmpresarialBL.ObtenerListaEmpresa()))


    End Sub


    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click

        configurarColumnasListadoProspectos(CargaDataGrids.llenarGrid(DataGridViewListaEmpresa,
                                                                      GrupoEmpresarialBL.ObtenerListaEmpresa()))
        ' cargarBsParaBusquedas()

    End Sub



    Public Sub configurarColumnasListadoProspectos(ByRef dtg As DataGridView)
        bsEmpresa = dtg.DataSource

        Try
            With dtg
                .Columns(0).Visible = False
                .Columns(1).Width = 95
                .Columns(1).HeaderText = "Descripcion"


            End With

        Catch ex As Exception

        End Try

    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        TextId.Text = ""
        TextDescriccion.Text = ""
        BtnCancelar.Visible = True
        btnAgregarEmpresa.Visible = True
        btnAgregarEmpresa.Enabled = True

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim result As DialogResult
        If (TextDescriccion.Text = "") Then

            'BtnActualizar.Visible = False
            MsgBox("Debe seleccionar el evento que quiere modificar")

        Else

            result = MessageBox.Show("Desea actualizar los datos?", "Modificando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (result = DialogResult.OK) Then


                Dim identificacion = TextId.Text
                Dim descripcion = TextDescriccion.Text


                Dim row = DataGridViewListaEmpresa.CurrentRow()


                If (descripcion) = "" Then
                    MsgBox("Llenar campos")

                ElseIf IsNumeric(descripcion) Then
                    MsgBox("solo acepta caracteres")
                Else

                    '  MsgBox("Llenar campos")


                    GrupoEmpresarialBL.actualizarDatos(identificacion, descripcion)

                    BtnListar_Click(sender, e)
                End If
            End If
        End If

    End Sub




    Private Sub TextBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBuscar.KeyPress
        Validaciones.VerificarNumeros(e)

    End Sub

End Class



