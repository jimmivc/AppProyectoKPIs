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
        Me.mnu_11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_111 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_1111 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_1112 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_112 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_113 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_114 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_121 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_122 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_123 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_131 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_132 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_133 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_134 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_141 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_142 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_143 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_11, Me.mnu_12, Me.mnu_13, Me.mnu_14, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1164, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu_11
        '
        Me.mnu_11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_111, Me.mnu_112, Me.mnu_113, Me.mnu_114})
        Me.mnu_11.ForeColor = System.Drawing.Color.Silver
        Me.mnu_11.Name = "mnu_11"
        Me.mnu_11.Size = New System.Drawing.Size(93, 22)
        Me.mnu_11.Text = "Operaciones"
        Me.mnu_11.Visible = False
        '
        'mnu_111
        '
        Me.mnu_111.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mnu_111.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_1111, Me.mnu_1112})
        Me.mnu_111.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_111.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_111.Image = CType(resources.GetObject("mnu_111.Image"), System.Drawing.Image)
        Me.mnu_111.Name = "mnu_111"
        Me.mnu_111.Size = New System.Drawing.Size(194, 26)
        Me.mnu_111.Text = "Prospectos"
        Me.mnu_111.Visible = False
        '
        'mnu_1111
        '
        Me.mnu_1111.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_1111.Image = CType(resources.GetObject("mnu_1111.Image"), System.Drawing.Image)
        Me.mnu_1111.Name = "mnu_1111"
        Me.mnu_1111.Size = New System.Drawing.Size(132, 22)
        Me.mnu_1111.Text = "Importar"
        Me.mnu_1111.Visible = False
        '
        'mnu_1112
        '
        Me.mnu_1112.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_1112.Image = CType(resources.GetObject("mnu_1112.Image"), System.Drawing.Image)
        Me.mnu_1112.Name = "mnu_1112"
        Me.mnu_1112.Size = New System.Drawing.Size(132, 22)
        Me.mnu_1112.Text = "Gestionar"
        Me.mnu_1112.Visible = False
        '
        'mnu_112
        '
        Me.mnu_112.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_112.Image = CType(resources.GetObject("mnu_112.Image"), System.Drawing.Image)
        Me.mnu_112.Name = "mnu_112"
        Me.mnu_112.Size = New System.Drawing.Size(194, 26)
        Me.mnu_112.Text = "Evaluaciones"
        Me.mnu_112.Visible = False
        '
        'mnu_113
        '
        Me.mnu_113.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_113.Image = CType(resources.GetObject("mnu_113.Image"), System.Drawing.Image)
        Me.mnu_113.Name = "mnu_113"
        Me.mnu_113.Size = New System.Drawing.Size(194, 26)
        Me.mnu_113.Text = "Asignación de KPIs"
        Me.mnu_113.Visible = False
        '
        'mnu_114
        '
        Me.mnu_114.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_114.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_114.Image = CType(resources.GetObject("mnu_114.Image"), System.Drawing.Image)
        Me.mnu_114.Name = "mnu_114"
        Me.mnu_114.Size = New System.Drawing.Size(194, 26)
        Me.mnu_114.Text = "Ventas"
        Me.mnu_114.Visible = False
        '
        'mnu_12
        '
        Me.mnu_12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_121, Me.mnu_122, Me.mnu_123})
        Me.mnu_12.ForeColor = System.Drawing.Color.Silver
        Me.mnu_12.Name = "mnu_12"
        Me.mnu_12.Size = New System.Drawing.Size(99, 22)
        Me.mnu_12.Text = "Configuración"
        Me.mnu_12.Visible = False
        '
        'mnu_121
        '
        Me.mnu_121.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_121.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_121.Image = CType(resources.GetObject("mnu_121.Image"), System.Drawing.Image)
        Me.mnu_121.Name = "mnu_121"
        Me.mnu_121.Size = New System.Drawing.Size(181, 26)
        Me.mnu_121.Text = "Eventos"
        Me.mnu_121.Visible = False
        '
        'mnu_122
        '
        Me.mnu_122.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_122.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_122.Image = CType(resources.GetObject("mnu_122.Image"), System.Drawing.Image)
        Me.mnu_122.Name = "mnu_122"
        Me.mnu_122.Size = New System.Drawing.Size(181, 26)
        Me.mnu_122.Text = "Entidades"
        Me.mnu_122.Visible = False
        '
        'mnu_123
        '
        Me.mnu_123.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.mnu_123.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_123.Image = CType(resources.GetObject("mnu_123.Image"), System.Drawing.Image)
        Me.mnu_123.Name = "mnu_123"
        Me.mnu_123.Size = New System.Drawing.Size(181, 26)
        Me.mnu_123.Text = "Creación de KPIs"
        Me.mnu_123.Visible = False
        '
        'mnu_13
        '
        Me.mnu_13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_131, Me.mnu_132, Me.mnu_133, Me.mnu_134})
        Me.mnu_13.ForeColor = System.Drawing.Color.Silver
        Me.mnu_13.Name = "mnu_13"
        Me.mnu_13.Size = New System.Drawing.Size(72, 22)
        Me.mnu_13.Text = "Reportes"
        Me.mnu_13.Visible = False
        '
        'mnu_131
        '
        Me.mnu_131.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_131.Image = CType(resources.GetObject("mnu_131.Image"), System.Drawing.Image)
        Me.mnu_131.Name = "mnu_131"
        Me.mnu_131.Size = New System.Drawing.Size(213, 26)
        Me.mnu_131.Text = "Ingresos por usuario"
        Me.mnu_131.Visible = False
        '
        'mnu_132
        '
        Me.mnu_132.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_132.Image = CType(resources.GetObject("mnu_132.Image"), System.Drawing.Image)
        Me.mnu_132.Name = "mnu_132"
        Me.mnu_132.Size = New System.Drawing.Size(213, 26)
        Me.mnu_132.Text = "Ventas"
        Me.mnu_132.Visible = False
        '
        'mnu_133
        '
        Me.mnu_133.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_133.Image = CType(resources.GetObject("mnu_133.Image"), System.Drawing.Image)
        Me.mnu_133.Name = "mnu_133"
        Me.mnu_133.Size = New System.Drawing.Size(213, 26)
        Me.mnu_133.Text = "Indicadores KPI"
        Me.mnu_133.Visible = False
        '
        'mnu_134
        '
        Me.mnu_134.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnu_134.Image = CType(resources.GetObject("mnu_134.Image"), System.Drawing.Image)
        Me.mnu_134.Name = "mnu_134"
        Me.mnu_134.Size = New System.Drawing.Size(213, 26)
        Me.mnu_134.Text = "Fuentes de prospectos"
        Me.mnu_134.Visible = False
        '
        'mnu_14
        '
        Me.mnu_14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_141, Me.mnu_142, Me.mnu_143})
        Me.mnu_14.ForeColor = System.Drawing.Color.Silver
        Me.mnu_14.Name = "mnu_14"
        Me.mnu_14.Size = New System.Drawing.Size(78, 22)
        Me.mnu_14.Text = "Seguridad"
        Me.mnu_14.Visible = False
        '
        'mnu_141
        '
        Me.mnu_141.Image = CType(resources.GetObject("mnu_141.Image"), System.Drawing.Image)
        Me.mnu_141.Name = "mnu_141"
        Me.mnu_141.Size = New System.Drawing.Size(135, 26)
        Me.mnu_141.Text = "Usuarios"
        Me.mnu_141.Visible = False
        '
        'mnu_142
        '
        Me.mnu_142.Image = CType(resources.GetObject("mnu_142.Image"), System.Drawing.Image)
        Me.mnu_142.Name = "mnu_142"
        Me.mnu_142.Size = New System.Drawing.Size(135, 26)
        Me.mnu_142.Text = "Roles"
        Me.mnu_142.Visible = False
        '
        'mnu_143
        '
        Me.mnu_143.Image = CType(resources.GetObject("mnu_143.Image"), System.Drawing.Image)
        Me.mnu_143.Name = "mnu_143"
        Me.mnu_143.Size = New System.Drawing.Size(135, 26)
        Me.mnu_143.Text = "Permisos"
        Me.mnu_143.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 641)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InnovaSoft"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnu_11 As ToolStripMenuItem
    Friend WithEvents mnu_111 As ToolStripMenuItem
    Friend WithEvents mnu_112 As ToolStripMenuItem
    Friend WithEvents mnu_113 As ToolStripMenuItem
    Friend WithEvents mnu_114 As ToolStripMenuItem
    Friend WithEvents mnu_12 As ToolStripMenuItem
    Friend WithEvents mnu_121 As ToolStripMenuItem
    Friend WithEvents mnu_122 As ToolStripMenuItem
    Friend WithEvents mnu_123 As ToolStripMenuItem
    Friend WithEvents mnu_13 As ToolStripMenuItem
    Friend WithEvents mnu_14 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_131 As ToolStripMenuItem
    Friend WithEvents mnu_132 As ToolStripMenuItem
    Friend WithEvents mnu_133 As ToolStripMenuItem
    Friend WithEvents mnu_141 As ToolStripMenuItem
    Friend WithEvents mnu_142 As ToolStripMenuItem
    Friend WithEvents mnu_143 As ToolStripMenuItem
    Friend WithEvents mnu_134 As ToolStripMenuItem
    Friend WithEvents mnu_1111 As ToolStripMenuItem
    Friend WithEvents mnu_1112 As ToolStripMenuItem
End Class
