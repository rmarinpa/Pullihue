﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bloquear
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
        Me.components = New System.ComponentModel.Container()
        Me.dgv_alerta = New System.Windows.Forms.DataGridView()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_precios = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_bloqueo1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_bloqueo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_alerta
        '
        Me.dgv_alerta.AllowUserToAddRows = False
        Me.dgv_alerta.AllowUserToDeleteRows = False
        Me.dgv_alerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_alerta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut, Me.cliente, Me.motivo})
        Me.dgv_alerta.Location = New System.Drawing.Point(12, 282)
        Me.dgv_alerta.Name = "dgv_alerta"
        Me.dgv_alerta.ReadOnly = True
        Me.dgv_alerta.RowHeadersVisible = False
        Me.dgv_alerta.Size = New System.Drawing.Size(1094, 99)
        Me.dgv_alerta.TabIndex = 1104
        '
        'rut
        '
        Me.rut.HeaderText = "RUT"
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Width = 150
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 300
        '
        'motivo
        '
        Me.motivo.HeaderText = "Motivo Bloqueo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        Me.motivo.Width = 300
        '
        'lbl_precios
        '
        Me.lbl_precios.AutoSize = True
        Me.lbl_precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precios.Location = New System.Drawing.Point(8, 9)
        Me.lbl_precios.Name = "lbl_precios"
        Me.lbl_precios.Size = New System.Drawing.Size(209, 24)
        Me.lbl_precios.TabIndex = 1211
        Me.lbl_precios.Text = "ALERTA BLOQUEOS"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(905, 392)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(144, 47)
        Me.btn_cancelar.TabIndex = 1122
        Me.btn_cancelar.Text = "CERRAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(238, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 1256
        Me.Button1.Text = "ACTUALIZAR TABLA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 24)
        Me.Label1.TabIndex = 1257
        Me.Label1.Text = "MAYOR A 3 MESES SIN COMPRAR"
        '
        'dgv_bloqueo1
        '
        Me.dgv_bloqueo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bloqueo1.Location = New System.Drawing.Point(16, 103)
        Me.dgv_bloqueo1.Name = "dgv_bloqueo1"
        Me.dgv_bloqueo1.Size = New System.Drawing.Size(547, 150)
        Me.dgv_bloqueo1.TabIndex = 1258
        '
        'frm_bloquear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1118, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_bloqueo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_precios)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgv_alerta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_bloquear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alerta Bloqueos"
        Me.TopMost = True
        CType(Me.dgv_alerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_bloqueo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_alerta As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_precios As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_bloqueo1 As System.Windows.Forms.DataGridView
End Class
