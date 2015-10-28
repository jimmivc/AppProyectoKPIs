Public Class Principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activarColorFondoMDI(sender, e)
        Dim permisos() As Integer = {11, 111, 1111, 1112, 112, 113, 114, 12, 121, 122, 123, 13, 131, 132, 133, 134, 14, 141, 142, 143}
        accederMenuPrincipal(permisos)

    End Sub

    Private Sub activarColorFondoMDI(sender As Object, e As EventArgs)
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
    End Sub

    Private Sub accederMenuPrincipal(ByVal permisos() As Integer)
        Dim i As Integer
        Dim isItem As Boolean
        For q As Integer = 0 To permisos.Length - 1
            i = 0
            isItem = False
            While i < MenuStrip1.Items.Count And isItem = False
                Dim opcion As New ToolStripMenuItem
                opcion.Name = "mnu_" + permisos(q).ToString
                If MenuStrip1.Items.Item(i).Name = opcion.Name Then
                    MenuStrip1.Items.Item(i).Visible = True
                    Dim op As ToolStripMenuItem = MenuStrip1.Items.Item(i)
                    accederSubMenus(permisos, op)
                    isItem = True
                End If
                i = i + 1
            End While
        Next
    End Sub
    Private Sub accederSubMenus(ByVal permisos() As Integer, ByVal op As ToolStripMenuItem)

        Dim opcion As New ToolStripMenuItem

        For Each subMenu As ToolStripMenuItem In op.DropDownItems
            For k As Integer = 0 To permisos.Length - 1
                opcion.Name = "mnu_" + permisos(k).ToString
                If subMenu.Name = opcion.Name Then
                    subMenu.Visible = True
                End If
            Next
        Next

    End Sub
End Class