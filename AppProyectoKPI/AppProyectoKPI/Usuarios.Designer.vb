﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.CombBxRol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBxApellidos = New System.Windows.Forms.TextBox()
        Me.txtBxNombre = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.txtBxContrasena = New System.Windows.Forms.TextBox()
        Me.txtBxCorreo = New System.Windows.Forms.TextBox()
        Me.txtBxID = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CombBxRol
        '
        Me.CombBxRol.FormattingEnabled = True
        Me.CombBxRol.Location = New System.Drawing.Point(132, 266)
        Me.CombBxRol.Name = "CombBxRol"
        Me.CombBxRol.Size = New System.Drawing.Size(200, 21)
        Me.CombBxRol.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registrar Usuario"
        '
        'txtBxApellidos
        '
        Me.txtBxApellidos.BackColor = System.Drawing.SystemColors.Control
        Me.txtBxApellidos.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBxApellidos.Location = New System.Drawing.Point(132, 101)
        Me.txtBxApellidos.Name = "txtBxApellidos"
        Me.txtBxApellidos.Size = New System.Drawing.Size(200, 25)
        Me.txtBxApellidos.TabIndex = 11
        '
        'txtBxNombre
        '
        Me.txtBxNombre.BackColor = System.Drawing.SystemColors.Control
        Me.txtBxNombre.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBxNombre.Location = New System.Drawing.Point(132, 61)
        Me.txtBxNombre.Name = "txtBxNombre"
        Me.txtBxNombre.Size = New System.Drawing.Size(200, 25)
        Me.txtBxNombre.TabIndex = 12
        '
        'lblApellidos
        '
        Me.lblApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblApellidos.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblApellidos.Location = New System.Drawing.Point(12, 102)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(103, 24)
        Me.lblApellidos.TabIndex = 13
        Me.lblApellidos.Text = "Apellidos :"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblNombre.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(12, 61)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(103, 24)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre :"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblID.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(12, 142)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(103, 24)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "Identificación :"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblContrasena
        '
        Me.lblContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblContrasena.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblContrasena.Location = New System.Drawing.Point(12, 223)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(103, 24)
        Me.lblContrasena.TabIndex = 16
        Me.lblContrasena.Text = "Contraseña :"
        Me.lblContrasena.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCorreo
        '
        Me.lblCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCorreo.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblCorreo.Location = New System.Drawing.Point(12, 183)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(103, 24)
        Me.lblCorreo.TabIndex = 17
        Me.lblCorreo.Text = "Correo :"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRol
        '
        Me.lblRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblRol.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.lblRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblRol.Location = New System.Drawing.Point(12, 263)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(103, 24)
        Me.lblRol.TabIndex = 18
        Me.lblRol.Text = "Rol :"
        Me.lblRol.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBxContrasena
        '
        Me.txtBxContrasena.BackColor = System.Drawing.SystemColors.Control
        Me.txtBxContrasena.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBxContrasena.Location = New System.Drawing.Point(132, 223)
        Me.txtBxContrasena.Name = "txtBxContrasena"
        Me.txtBxContrasena.Size = New System.Drawing.Size(200, 25)
        Me.txtBxContrasena.TabIndex = 19
        '
        'txtBxCorreo
        '
        Me.txtBxCorreo.BackColor = System.Drawing.SystemColors.Control
        Me.txtBxCorreo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBxCorreo.Location = New System.Drawing.Point(132, 183)
        Me.txtBxCorreo.Name = "txtBxCorreo"
        Me.txtBxCorreo.Size = New System.Drawing.Size(200, 25)
        Me.txtBxCorreo.TabIndex = 20
        '
        'txtBxID
        '
        Me.txtBxID.BackColor = System.Drawing.SystemColors.Control
        Me.txtBxID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBxID.Location = New System.Drawing.Point(132, 141)
        Me.txtBxID.Name = "txtBxID"
        Me.txtBxID.Size = New System.Drawing.Size(200, 25)
        Me.txtBxID.TabIndex = 21
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Silver
        Me.btnRegistrar.Location = New System.Drawing.Point(132, 307)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(200, 26)
        Me.btnRegistrar.TabIndex = 22
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 572)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtBxID)
        Me.Controls.Add(Me.txtBxCorreo)
        Me.Controls.Add(Me.txtBxContrasena)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.txtBxNombre)
        Me.Controls.Add(Me.txtBxApellidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CombBxRol)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CombBxRol As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBxApellidos As TextBox
    Friend WithEvents txtBxNombre As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents txtBxContrasena As TextBox
    Friend WithEvents txtBxCorreo As TextBox
    Friend WithEvents txtBxID As TextBox
    Friend WithEvents btnRegistrar As Button
End Class
