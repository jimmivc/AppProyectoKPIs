<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElegirRangoKPI
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
        Me.lstLimiteInferior = New System.Windows.Forms.ComboBox()
        Me.lstLimiteSuperior = New System.Windows.Forms.ComboBox()
        Me.rojo = New System.Windows.Forms.Label()
        Me.amarillo = New System.Windows.Forms.Label()
        Me.verde = New System.Windows.Forms.Label()
        Me.lblLimiteSuperior = New System.Windows.Forms.Label()
        Me.lblLimiteInferior = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLimiteInferior
        '
        Me.lstLimiteInferior.FormattingEnabled = True
        Me.lstLimiteInferior.Location = New System.Drawing.Point(152, 124)
        Me.lstLimiteInferior.Name = "lstLimiteInferior"
        Me.lstLimiteInferior.Size = New System.Drawing.Size(121, 24)
        Me.lstLimiteInferior.TabIndex = 0
        '
        'lstLimiteSuperior
        '
        Me.lstLimiteSuperior.FormattingEnabled = True
        Me.lstLimiteSuperior.Location = New System.Drawing.Point(152, 83)
        Me.lstLimiteSuperior.Name = "lstLimiteSuperior"
        Me.lstLimiteSuperior.Size = New System.Drawing.Size(121, 24)
        Me.lstLimiteSuperior.TabIndex = 1
        '
        'rojo
        '
        Me.rojo.BackColor = System.Drawing.Color.Red
        Me.rojo.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rojo.Location = New System.Drawing.Point(12, 40)
        Me.rojo.Name = "rojo"
        Me.rojo.Size = New System.Drawing.Size(100, 23)
        Me.rojo.TabIndex = 3
        Me.rojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'amarillo
        '
        Me.amarillo.BackColor = System.Drawing.Color.Yellow
        Me.amarillo.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amarillo.Location = New System.Drawing.Point(164, 40)
        Me.amarillo.Name = "amarillo"
        Me.amarillo.Size = New System.Drawing.Size(100, 23)
        Me.amarillo.TabIndex = 3
        Me.amarillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'verde
        '
        Me.verde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.verde.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verde.Location = New System.Drawing.Point(307, 40)
        Me.verde.Name = "verde"
        Me.verde.Size = New System.Drawing.Size(100, 23)
        Me.verde.TabIndex = 3
        Me.verde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLimiteSuperior
        '
        Me.lblLimiteSuperior.AutoSize = True
        Me.lblLimiteSuperior.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteSuperior.Location = New System.Drawing.Point(34, 90)
        Me.lblLimiteSuperior.Name = "lblLimiteSuperior"
        Me.lblLimiteSuperior.Size = New System.Drawing.Size(104, 19)
        Me.lblLimiteSuperior.TabIndex = 4
        Me.lblLimiteSuperior.Text = "Limite Superior"
        '
        'lblLimiteInferior
        '
        Me.lblLimiteInferior.AutoSize = True
        Me.lblLimiteInferior.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteInferior.Location = New System.Drawing.Point(34, 131)
        Me.lblLimiteInferior.Name = "lblLimiteInferior"
        Me.lblLimiteInferior.Size = New System.Drawing.Size(94, 19)
        Me.lblLimiteInferior.TabIndex = 5
        Me.lblLimiteInferior.Text = "Limite Inferior"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.Silver
        Me.btnAceptar.Location = New System.Drawing.Point(168, 167)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(81, 26)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'ElegirRangoKPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 205)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblLimiteInferior)
        Me.Controls.Add(Me.lblLimiteSuperior)
        Me.Controls.Add(Me.amarillo)
        Me.Controls.Add(Me.verde)
        Me.Controls.Add(Me.rojo)
        Me.Controls.Add(Me.lstLimiteSuperior)
        Me.Controls.Add(Me.lstLimiteInferior)
        Me.Name = "ElegirRangoKPI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Elegir Rango KPI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLimiteInferior As System.Windows.Forms.ComboBox
    Friend WithEvents lstLimiteSuperior As System.Windows.Forms.ComboBox
    Friend WithEvents rojo As System.Windows.Forms.Label
    Friend WithEvents amarillo As System.Windows.Forms.Label
    Friend WithEvents verde As System.Windows.Forms.Label
    Friend WithEvents lblLimiteSuperior As System.Windows.Forms.Label
    Friend WithEvents lblLimiteInferior As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
