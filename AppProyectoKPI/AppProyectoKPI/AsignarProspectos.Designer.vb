<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarProspectos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxEjecutivos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnListarAsignados = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(124, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Ejecutivo:"
        '
        'ComboBoxEjecutivos
        '
        Me.ComboBoxEjecutivos.FormattingEnabled = True
        Me.ComboBoxEjecutivos.Location = New System.Drawing.Point(206, 32)
        Me.ComboBoxEjecutivos.Name = "ComboBoxEjecutivos"
        Me.ComboBoxEjecutivos.Size = New System.Drawing.Size(210, 21)
        Me.ComboBoxEjecutivos.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(53, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 30)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Listar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Lista de Prospectos "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(50, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 11)
        Me.Label4.TabIndex = 44
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(379, 235)
        Me.DataGridView1.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(466, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 30)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Desasignar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnListarAsignados
        '
        Me.BtnListarAsignados.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnListarAsignados.FlatAppearance.BorderSize = 0
        Me.BtnListarAsignados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnListarAsignados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnListarAsignados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListarAsignados.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.BtnListarAsignados.ForeColor = System.Drawing.Color.Silver
        Me.BtnListarAsignados.Location = New System.Drawing.Point(883, 472)
        Me.BtnListarAsignados.Name = "BtnListarAsignados"
        Me.BtnListarAsignados.Size = New System.Drawing.Size(119, 30)
        Me.BtnListarAsignados.TabIndex = 50
        Me.BtnListarAsignados.Text = "Listar"
        Me.BtnListarAsignados.UseVisualStyleBackColor = False
        '
        'btnAsignar
        '
        Me.btnAsignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAsignar.FlatAppearance.BorderSize = 0
        Me.btnAsignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnAsignar.ForeColor = System.Drawing.Color.Silver
        Me.btnAsignar.Location = New System.Drawing.Point(466, 274)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(119, 30)
        Me.btnAsignar.TabIndex = 49
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(608, 222)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(394, 235)
        Me.DataGridView2.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(683, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 26)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Listado de  Asignacion"
        '
        'AsignarProspectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnListarAsignados)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxEjecutivos)
        Me.Name = "AsignarProspectos"
        Me.Text = "AsignarProspectos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxEjecutivos As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnListarAsignados As Button
    Friend WithEvents btnAsignar As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
End Class
