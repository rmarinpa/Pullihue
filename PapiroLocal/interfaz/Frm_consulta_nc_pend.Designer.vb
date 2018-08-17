<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consulta_nc_pend
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_actualizar = New System.Windows.Forms.DataGridView()
        Me.dgv_despachos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CachedCrystalReport11 = New Constructora_FV.CachedCrystalReport1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.gp_autorizar = New System.Windows.Forms.GroupBox()
        Me.btn_rechazar = New System.Windows.Forms.Button()
        Me.txt_folio2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_autorizar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_autorizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btn_actualizar
        '
        Me.btn_actualizar.AllowUserToAddRows = False
        Me.btn_actualizar.AllowUserToDeleteRows = False
        Me.btn_actualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.btn_actualizar.Location = New System.Drawing.Point(745, 74)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.ReadOnly = True
        Me.btn_actualizar.RowHeadersVisible = False
        Me.btn_actualizar.Size = New System.Drawing.Size(446, 186)
        Me.btn_actualizar.TabIndex = 1203
        '
        'dgv_despachos
        '
        Me.dgv_despachos.AllowUserToAddRows = False
        Me.dgv_despachos.AllowUserToDeleteRows = False
        Me.dgv_despachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos.Location = New System.Drawing.Point(13, 74)
        Me.dgv_despachos.Name = "dgv_despachos"
        Me.dgv_despachos.ReadOnly = True
        Me.dgv_despachos.RowHeadersVisible = False
        Me.dgv_despachos.Size = New System.Drawing.Size(711, 186)
        Me.dgv_despachos.TabIndex = 1210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(201, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 49)
        Me.Label4.TabIndex = 1212
        Me.Label4.Text = "ALERTA NOTAS DE CRÉDITO"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1032, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 10)
        Me.Button2.TabIndex = 1224
        Me.Button2.Text = "Agregar N° de Factura"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(1019, 28)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.Size = New System.Drawing.Size(8, 8)
        Me.dgv_clientes.TabIndex = 1240
        Me.dgv_clientes.Visible = False
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(1044, 28)
        Me.txt_observacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(20, 20)
        Me.txt_observacion.TabIndex = 1244
        Me.txt_observacion.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1026, 319)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 1250
        Me.Label10.Text = "TOTAL"
        '
        'txt_total2
        '
        Me.txt_total2.Location = New System.Drawing.Point(1121, 308)
        Me.txt_total2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.Size = New System.Drawing.Size(65, 20)
        Me.txt_total2.TabIndex = 1249
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(1121, 285)
        Me.txt_iva.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(65, 20)
        Me.txt_iva.TabIndex = 1248
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1026, 296)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 1247
        Me.Label9.Text = "IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1026, 273)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 1246
        Me.Label7.Text = "MONTO NETO"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(1121, 262)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(65, 20)
        Me.txt_total.TabIndex = 1245
        '
        'gp_autorizar
        '
        Me.gp_autorizar.Controls.Add(Me.btn_rechazar)
        Me.gp_autorizar.Controls.Add(Me.txt_folio2)
        Me.gp_autorizar.Controls.Add(Me.Label8)
        Me.gp_autorizar.Controls.Add(Me.btn_autorizar)
        Me.gp_autorizar.Location = New System.Drawing.Point(487, 273)
        Me.gp_autorizar.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_autorizar.Name = "gp_autorizar"
        Me.gp_autorizar.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_autorizar.Size = New System.Drawing.Size(237, 93)
        Me.gp_autorizar.TabIndex = 1252
        Me.gp_autorizar.TabStop = False
        Me.gp_autorizar.Text = "Autorizar"
        '
        'btn_rechazar
        '
        Me.btn_rechazar.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_rechazar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_rechazar.Location = New System.Drawing.Point(123, 44)
        Me.btn_rechazar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_rechazar.Name = "btn_rechazar"
        Me.btn_rechazar.Size = New System.Drawing.Size(105, 35)
        Me.btn_rechazar.TabIndex = 1227
        Me.btn_rechazar.Text = "Rechazar N/C"
        Me.btn_rechazar.UseVisualStyleBackColor = False
        '
        'txt_folio2
        '
        Me.txt_folio2.Location = New System.Drawing.Point(105, 20)
        Me.txt_folio2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_folio2.Name = "txt_folio2"
        Me.txt_folio2.ReadOnly = True
        Me.txt_folio2.Size = New System.Drawing.Size(123, 20)
        Me.txt_folio2.TabIndex = 1223
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 1222
        Me.Label8.Text = "N° de Folio:"
        '
        'btn_autorizar
        '
        Me.btn_autorizar.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_autorizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_autorizar.Location = New System.Drawing.Point(13, 44)
        Me.btn_autorizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_autorizar.Name = "btn_autorizar"
        Me.btn_autorizar.Size = New System.Drawing.Size(106, 35)
        Me.btn_autorizar.TabIndex = 1226
        Me.btn_autorizar.Text = "Autorizar N/C"
        Me.btn_autorizar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(774, 275)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 17)
        Me.Label12.TabIndex = 1254
        Me.Label12.Text = "HORA ACTUAL:"
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(888, 274)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.ReadOnly = True
        Me.txt_hora.Size = New System.Drawing.Size(74, 20)
        Me.txt_hora.TabIndex = 1253
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(1042, 338)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(144, 47)
        Me.btn_cancelar.TabIndex = 1255
        Me.btn_cancelar.Text = "CERRAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Frm_consulta_nc_pend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1211, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_total2)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_despachos)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.gp_autorizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_consulta_nc_pend"
        Me.Text = "Notas de Crédito"
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_autorizar.ResumeLayout(False)
        Me.gp_autorizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents btn_actualizar As System.Windows.Forms.DataGridView
    Private WithEvents dgv_despachos As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CachedCrystalReport11 As Constructora_FV.CachedCrystalReport1
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_total2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents gp_autorizar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_rechazar As System.Windows.Forms.Button
    Friend WithEvents txt_folio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_autorizar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
