﻿Public Class ListarProspectos

    Private gestionProspectos As GestionProspectos

    Public Sub New(ByRef gestion As GestionProspectos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gestionProspectos = gestion

    End Sub

    Private Sub dtgListaProspectos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaProspectos.CellClick
        Dim i As Integer
        i = dtgListaProspectos.CurrentRow.Index

        gestionProspectos.cargarProspectoPantalla(dtgListaProspectos.Item(0, i).Value)

    End Sub


End Class