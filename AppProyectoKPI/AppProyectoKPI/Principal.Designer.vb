<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnu_Operaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GestionarProspectos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ImportarProspecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GenerarRegistroMercadeo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_AsignarKpis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GestionarVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Configuracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Eventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Entidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Kpis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_IngresosUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Ventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_IndicadoresKpi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_FuentesProspecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Seguridad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Roles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Operaciones, Me.mnu_Configuracion, Me.mnu_Reportes, Me.mnu_Seguridad, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1162, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu_Operaciones
        '
        Me.mnu_Operaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_GestionarProspectos, Me.mnu_ImportarProspecto, Me.mnu_GenerarRegistroMercadeo, Me.mnu_AsignarKpis, Me.mnu_GestionarVentas})
        Me.mnu_Operaciones.ForeColor = System.Drawing.Color.Silver
        Me.mnu_Operaciones.Name = "mnu_Operaciones"
        Me.mnu_Operaciones.Size = New System.Drawing.Size(116, 27)
        Me.mnu_Operaciones.Text = "Operaciones"
        Me.mnu_Operaciones.Visible = False
        '
        'mnu_GestionarProspectos
        '
        Me.mnu_GestionarProspectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mnu_GestionarProspectos.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_GestionarProspectos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_GestionarProspectos.Image = CType(resources.GetObject("mnu_GestionarProspectos.Image"), System.Drawing.Image)
        Me.mnu_GestionarProspectos.Name = "mnu_GestionarProspectos"
        Me.mnu_GestionarProspectos.Size = New System.Drawing.Size(285, 28)
        Me.mnu_GestionarProspectos.Text = "Gestionar prospectos"
        Me.mnu_GestionarProspectos.Visible = False
        '
        'mnu_ImportarProspecto
        '
        Me.mnu_ImportarProspecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_ImportarProspecto.Image = CType(resources.GetObject("mnu_ImportarProspecto.Image"), System.Drawing.Image)
        Me.mnu_ImportarProspecto.Name = "mnu_ImportarProspecto"
        Me.mnu_ImportarProspecto.Size = New System.Drawing.Size(285, 28)
        Me.mnu_ImportarProspecto.Text = "Importar prospectos"
        '
        'mnu_GenerarRegistroMercadeo
        '
        Me.mnu_GenerarRegistroMercadeo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_GenerarRegistroMercadeo.Image = CType(resources.GetObject("mnu_GenerarRegistroMercadeo.Image"), System.Drawing.Image)
        Me.mnu_GenerarRegistroMercadeo.Name = "mnu_GenerarRegistroMercadeo"
        Me.mnu_GenerarRegistroMercadeo.Size = New System.Drawing.Size(285, 28)
        Me.mnu_GenerarRegistroMercadeo.Text = "Generar registro mercadeo"
        Me.mnu_GenerarRegistroMercadeo.Visible = False
        '
        'mnu_AsignarKpis
        '
        Me.mnu_AsignarKpis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_AsignarKpis.Image = CType(resources.GetObject("mnu_AsignarKpis.Image"), System.Drawing.Image)
        Me.mnu_AsignarKpis.Name = "mnu_AsignarKpis"
        Me.mnu_AsignarKpis.Size = New System.Drawing.Size(285, 28)
        Me.mnu_AsignarKpis.Text = "Asignar KPIs"
        Me.mnu_AsignarKpis.Visible = False
        '
        'mnu_GestionarVentas
        '
        Me.mnu_GestionarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_GestionarVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_GestionarVentas.Image = CType(resources.GetObject("mnu_GestionarVentas.Image"), System.Drawing.Image)
        Me.mnu_GestionarVentas.Name = "mnu_GestionarVentas"
        Me.mnu_GestionarVentas.Size = New System.Drawing.Size(285, 28)
        Me.mnu_GestionarVentas.Text = "Gestionar ventas"
        Me.mnu_GestionarVentas.Visible = False
        '
        'mnu_Configuracion
        '
        Me.mnu_Configuracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Eventos, Me.mnu_Entidades, Me.mnu_Kpis})
        Me.mnu_Configuracion.ForeColor = System.Drawing.Color.Silver
        Me.mnu_Configuracion.Name = "mnu_Configuracion"
        Me.mnu_Configuracion.Size = New System.Drawing.Size(123, 27)
        Me.mnu_Configuracion.Text = "Configuración"
        Me.mnu_Configuracion.Visible = False
        '
        'mnu_Eventos
        '
        Me.mnu_Eventos.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_Eventos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_Eventos.Image = CType(resources.GetObject("mnu_Eventos.Image"), System.Drawing.Image)
        Me.mnu_Eventos.Name = "mnu_Eventos"
        Me.mnu_Eventos.Size = New System.Drawing.Size(179, 26)
        Me.mnu_Eventos.Text = "Eventos"
        Me.mnu_Eventos.Visible = False
        '
        'mnu_Entidades
        '
        Me.mnu_Entidades.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_Entidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_Entidades.Image = CType(resources.GetObject("mnu_Entidades.Image"), System.Drawing.Image)
        Me.mnu_Entidades.Name = "mnu_Entidades"
        Me.mnu_Entidades.Size = New System.Drawing.Size(179, 26)
        Me.mnu_Entidades.Text = "Entidades"
        Me.mnu_Entidades.Visible = False
        '
        'mnu_Kpis
        '
        Me.mnu_Kpis.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_Kpis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_Kpis.Image = CType(resources.GetObject("mnu_Kpis.Image"), System.Drawing.Image)
        Me.mnu_Kpis.Name = "mnu_Kpis"
        Me.mnu_Kpis.Size = New System.Drawing.Size(179, 26)
        Me.mnu_Kpis.Text = "Kpis"
        Me.mnu_Kpis.Visible = False
        '
        'mnu_Reportes
        '
        Me.mnu_Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_IngresosUsuario, Me.mnu_Ventas, Me.mnu_IndicadoresKpi, Me.mnu_FuentesProspecto})
        Me.mnu_Reportes.ForeColor = System.Drawing.Color.Silver
        Me.mnu_Reportes.Name = "mnu_Reportes"
        Me.mnu_Reportes.Size = New System.Drawing.Size(90, 27)
        Me.mnu_Reportes.Text = "Reportes"
        Me.mnu_Reportes.Visible = False
        '
        'mnu_IngresosUsuario
        '
        Me.mnu_IngresosUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_IngresosUsuario.Image = CType(resources.GetObject("mnu_IngresosUsuario.Image"), System.Drawing.Image)
        Me.mnu_IngresosUsuario.Name = "mnu_IngresosUsuario"
        Me.mnu_IngresosUsuario.Size = New System.Drawing.Size(255, 28)
        Me.mnu_IngresosUsuario.Text = "Ingresos por usuario"
        Me.mnu_IngresosUsuario.Visible = False
        '
        'mnu_Ventas
        '
        Me.mnu_Ventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_Ventas.Image = CType(resources.GetObject("mnu_Ventas.Image"), System.Drawing.Image)
        Me.mnu_Ventas.Name = "mnu_Ventas"
        Me.mnu_Ventas.Size = New System.Drawing.Size(255, 28)
        Me.mnu_Ventas.Text = "Ventas"
        Me.mnu_Ventas.Visible = False
        '
        'mnu_IndicadoresKpi
        '
        Me.mnu_IndicadoresKpi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_IndicadoresKpi.Image = CType(resources.GetObject("mnu_IndicadoresKpi.Image"), System.Drawing.Image)
        Me.mnu_IndicadoresKpi.Name = "mnu_IndicadoresKpi"
        Me.mnu_IndicadoresKpi.Size = New System.Drawing.Size(255, 28)
        Me.mnu_IndicadoresKpi.Text = "Indicadores KPI"
        Me.mnu_IndicadoresKpi.Visible = False
        '
        'mnu_FuentesProspecto
        '
        Me.mnu_FuentesProspecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_FuentesProspecto.Image = CType(resources.GetObject("mnu_FuentesProspecto.Image"), System.Drawing.Image)
        Me.mnu_FuentesProspecto.Name = "mnu_FuentesProspecto"
        Me.mnu_FuentesProspecto.Size = New System.Drawing.Size(255, 28)
        Me.mnu_FuentesProspecto.Text = "Fuentes de prospectos"
        Me.mnu_FuentesProspecto.Visible = False
        '
        'mnu_Seguridad
        '
        Me.mnu_Seguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Usuarios, Me.mnu_Roles, Me.mnu_Permisos})
        Me.mnu_Seguridad.ForeColor = System.Drawing.Color.Silver
        Me.mnu_Seguridad.Name = "mnu_Seguridad"
        Me.mnu_Seguridad.Size = New System.Drawing.Size(96, 27)
        Me.mnu_Seguridad.Text = "Seguridad"
        Me.mnu_Seguridad.Visible = False
        '
        'mnu_Usuarios
        '
        Me.mnu_Usuarios.Image = CType(resources.GetObject("mnu_Usuarios.Image"), System.Drawing.Image)
        Me.mnu_Usuarios.Name = "mnu_Usuarios"
        Me.mnu_Usuarios.Size = New System.Drawing.Size(179, 28)
        Me.mnu_Usuarios.Text = "Usuarios"
        Me.mnu_Usuarios.Visible = False
        '
        'mnu_Roles
        '
        Me.mnu_Roles.Image = CType(resources.GetObject("mnu_Roles.Image"), System.Drawing.Image)
        Me.mnu_Roles.Name = "mnu_Roles"
        Me.mnu_Roles.Size = New System.Drawing.Size(179, 28)
        Me.mnu_Roles.Text = "Roles"
        Me.mnu_Roles.Visible = False
        '
        'mnu_Permisos
        '
        Me.mnu_Permisos.Image = CType(resources.GetObject("mnu_Permisos.Image"), System.Drawing.Image)
        Me.mnu_Permisos.Name = "mnu_Permisos"
        Me.mnu_Permisos.Size = New System.Drawing.Size(179, 28)
        Me.mnu_Permisos.Text = "Permisos"
        Me.mnu_Permisos.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(54, 27)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1162, 633)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InnovaSoft"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnu_Operaciones As ToolStripMenuItem
    Friend WithEvents mnu_GestionarProspectos As ToolStripMenuItem
    Friend WithEvents mnu_GenerarRegistroMercadeo As ToolStripMenuItem
    Friend WithEvents mnu_AsignarKpis As ToolStripMenuItem
    Friend WithEvents mnu_GestionarVentas As ToolStripMenuItem
    Friend WithEvents mnu_Configuracion As ToolStripMenuItem
    Friend WithEvents mnu_Eventos As ToolStripMenuItem
    Friend WithEvents mnu_Entidades As ToolStripMenuItem
    Friend WithEvents mnu_Kpis As ToolStripMenuItem
    Friend WithEvents mnu_Reportes As ToolStripMenuItem
    Friend WithEvents mnu_Seguridad As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_IngresosUsuario As ToolStripMenuItem
    Friend WithEvents mnu_Ventas As ToolStripMenuItem
    Friend WithEvents mnu_IndicadoresKpi As ToolStripMenuItem
    Friend WithEvents mnu_Usuarios As ToolStripMenuItem
    Friend WithEvents mnu_Roles As ToolStripMenuItem
    Friend WithEvents mnu_Permisos As ToolStripMenuItem
    Friend WithEvents mnu_FuentesProspecto As ToolStripMenuItem
    Friend WithEvents mnu_ImportarProspecto As ToolStripMenuItem
End Class
