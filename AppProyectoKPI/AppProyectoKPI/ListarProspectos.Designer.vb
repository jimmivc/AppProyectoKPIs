﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarProspectos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgListaProspectos = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbxBuscar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgListaProspectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgListaProspectos
        '
        Me.dtgListaProspectos.AllowUserToAddRows = False
        Me.dtgListaProspectos.AllowUserToDeleteRows = False
        Me.dtgListaProspectos.AllowUserToOrderColumns = True
        Me.dtgListaProspectos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dtgListaProspectos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgListaProspectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgListaProspectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgListaProspectos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgListaProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaProspectos.Location = New System.Drawing.Point(2, 44)
        Me.dtgListaProspectos.MultiSelect = False
        Me.dtgListaProspectos.Name = "dtgListaProspectos"
        Me.dtgListaProspectos.ReadOnly = True
        Me.dtgListaProspectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgListaProspectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListaProspectos.ShowEditingIcon = False
        Me.dtgListaProspectos.Size = New System.Drawing.Size(586, 382)
        Me.dtgListaProspectos.TabIndex = 0
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(66, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(152, 21)
        Me.txtBuscar.TabIndex = 1
        '
        'cbxBuscar
        '
        Me.cbxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cbxBuscar.FormattingEnabled = True
        Me.cbxBuscar.Items.AddRange(New Object() {"Nombre", "Apellidos", "Alias", "Identificación", "Edad"})
        Me.cbxBuscar.Location = New System.Drawing.Point(223, 14)
        Me.cbxBuscar.Name = "cbxBuscar"
        Me.cbxBuscar.Size = New System.Drawing.Size(152, 21)
        Me.cbxBuscar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListarProspectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(591, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dtgListaProspectos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarProspectos"
        Me.Text = "Form1"
        CType(Me.dtgListaProspectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgListaProspectos As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbxBuscar As ComboBox
    Friend WithEvents Label2 As Label
End Class
