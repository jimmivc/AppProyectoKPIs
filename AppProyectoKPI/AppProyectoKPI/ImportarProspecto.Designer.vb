﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarProspecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarProspecto))
        Me.btnListarProspectos = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnListarProspectos
        '
        Me.btnListarProspectos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnListarProspectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnListarProspectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnListarProspectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarProspectos.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnListarProspectos.ForeColor = System.Drawing.Color.Silver
        Me.btnListarProspectos.Location = New System.Drawing.Point(12, 167)
        Me.btnListarProspectos.Name = "btnListarProspectos"
        Me.btnListarProspectos.Size = New System.Drawing.Size(195, 27)
        Me.btnListarProspectos.TabIndex = 3
        Me.btnListarProspectos.Text = "Cargar archivo excel"
        Me.btnListarProspectos.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPath.Location = New System.Drawing.Point(211, 169)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(400, 23)
        Me.txtPath.TabIndex = 4
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Font = New System.Drawing.Font("Arial Unicode MS", 9.5!)
        Me.btnImportar.ForeColor = System.Drawing.Color.Silver
        Me.btnImportar.Location = New System.Drawing.Point(416, 211)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(195, 27)
        Me.btnImportar.TabIndex = 5
        Me.btnImportar.Text = "Importar datos"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(416, 244)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(195, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'ImportarProspecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 384)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnListarProspectos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportarProspecto"
        Me.Text = "ImportarProspecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListarProspectos As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnImportar As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
