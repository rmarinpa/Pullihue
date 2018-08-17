<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bloqueos_mod
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_precios = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_bloqueos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_alerta2 = New System.Windows.Forms.DataGridView()
        Me.btn_bloqueos2 = New System.Windows.Forms.Button()
        CType(Me.dgv_alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_alerta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_alerta
        '
        Me.dgv_alerta.AllowUserToAddRows = False
        Me.dgv_alerta.AllowUserToDeleteRows = False
        Me.dgv_alerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_alerta.Location = New System.Drawing.Point(12, 78)
        Me.dgv_alerta.Name = "dgv_alerta"
        Me.dgv_alerta.ReadOnly = True
        Me.dgv_alerta.RowHeadersVisible = False
        Me.dgv_alerta.Size = New System.Drawing.Size(618, 303)
        Me.dgv_alerta.TabIndex = 1104
        '
        'lbl_precios
        '
        Me.lbl_precios.AutoSize = True
        Me.lbl_precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precios.Location = New System.Drawing.Point(12, 9)
        Me.lbl_precios.Name = "lbl_precios"
        Me.lbl_precios.Size = New System.Drawing.Size(209, 24)
        Me.lbl_precios.TabIndex = 1211
        Me.lbl_precios.Text = "ALERTA BLOQUEOS"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(1258, 11)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(101, 47)
        Me.btn_cancelar.TabIndex = 1122
        Me.btn_cancelar.Text = "CERRAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_bloqueos
        '
        Me.btn_bloqueos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_bloqueos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bloqueos.Location = New System.Drawing.Point(497, 31)
        Me.btn_bloqueos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_bloqueos.Name = "btn_bloqueos"
        Me.btn_bloqueos.Size = New System.Drawing.Size(133, 42)
        Me.btn_bloqueos.TabIndex = 1212
        Me.btn_bloqueos.Text = "Actualizar"
        Me.btn_bloqueos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 24)
        Me.Label1.TabIndex = 1213
        Me.Label1.Text = "TIEMPO SIN COMPRA MAYOR A 3 MESES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(636, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 1215
        Me.Label2.Text = "PRORROGA"
        '
        'dgv_alerta2
        '
        Me.dgv_alerta2.AllowUserToAddRows = False
        Me.dgv_alerta2.AllowUserToDeleteRows = False
        Me.dgv_alerta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_alerta2.Location = New System.Drawing.Point(636, 78)
        Me.dgv_alerta2.Name = "dgv_alerta2"
        Me.dgv_alerta2.ReadOnly = True
        Me.dgv_alerta2.RowHeadersVisible = False
        Me.dgv_alerta2.Size = New System.Drawing.Size(618, 303)
        Me.dgv_alerta2.TabIndex = 1214
        '
        'btn_bloqueos2
        '
        Me.btn_bloqueos2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_bloqueos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bloqueos2.Location = New System.Drawing.Point(1121, 31)
        Me.btn_bloqueos2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_bloqueos2.Name = "btn_bloqueos2"
        Me.btn_bloqueos2.Size = New System.Drawing.Size(133, 42)
        Me.btn_bloqueos2.TabIndex = 1216
        Me.btn_bloqueos2.Text = "Actualizar"
        Me.btn_bloqueos2.UseVisualStyleBackColor = True
        '
        'frm_bloqueos_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_bloqueos2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_alerta2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_bloqueos)
        Me.Controls.Add(Me.lbl_precios)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgv_alerta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_bloqueos_mod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alerta Precios"
        Me.TopMost = True
        CType(Me.dgv_alerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_alerta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_alerta As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_precios As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_bloqueos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents dgv_alerta2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_bloqueos2 As System.Windows.Forms.Button
End Class
