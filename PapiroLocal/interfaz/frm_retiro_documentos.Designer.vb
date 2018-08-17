<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_retiro_documentos
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PlandeCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Plan_de_Cuentas = New Constructora_FV.Plan_de_Cuentas()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_operacion = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvpago = New System.Windows.Forms.ListView()
        Me.Factura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Deuda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Monto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Saldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_pago = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(274, 31)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "REGISTRO PAGOS"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(175, 605)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(204, 22)
        Me.txt_nombre_obra.TabIndex = 1154
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 610)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 1155
        Me.Label10.Text = "EJECUTIVO:"
        '
        'PlandeCuentasBindingSource
        '
        Me.PlandeCuentasBindingSource.DataSource = Me.Plan_de_Cuentas
        Me.PlandeCuentasBindingSource.Position = 0
        '
        'Plan_de_Cuentas
        '
        Me.Plan_de_Cuentas.DataSetName = "Plan_de_Cuentas"
        Me.Plan_de_Cuentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_banco)
        Me.GroupBox1.Controls.Add(Me.txt_serie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.cmb_operacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1256, 141)
        Me.GroupBox1.TabIndex = 1156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información General"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(443, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BANCO"
        '
        'cmb_banco
        '
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Items.AddRange(New Object() {"Banco BCI", "Banco de Chile", "Banco Estado", "Banco Santander", "Banco BBVA", "Banco BCI Nova", "Banco BICE", "Banco Condell", "Banco CrediChile", "Banco Edwards Citi", "Banco Falabella", "Banco Internacional", "Banco Itaú", "Banco Paris", "Banco Penta", "Banco Ripley", "Banco Security", "Banco del Desarrollo", "CorpBanca", "Santander Banefe", "Scotiabank", "TBanc", "Bank of Tokyo-Mitsubishi", "Credit Suisse", "Deutsche Bank", "HSBC", "J.P. Morgan", "Rabobank", "UBS"})
        Me.cmb_banco.Location = New System.Drawing.Point(522, 88)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(204, 24)
        Me.cmb_banco.TabIndex = 6
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(122, 87)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(204, 22)
        Me.txt_serie.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SERIE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FECHA OPERACIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OPERACIÓN"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(522, 43)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(204, 22)
        Me.dtp_fecha.TabIndex = 1158
        '
        'cmb_operacion
        '
        Me.cmb_operacion.FormattingEnabled = True
        Me.cmb_operacion.Items.AddRange(New Object() {"CHEQUE", "DEPOSITO DIRECTO", "EFECTIVO", "TRANSFERENCIA", "OTRO"})
        Me.cmb_operacion.Location = New System.Drawing.Point(122, 45)
        Me.cmb_operacion.Name = "cmb_operacion"
        Me.cmb_operacion.Size = New System.Drawing.Size(204, 24)
        Me.cmb_operacion.TabIndex = 0
        '
        'dtp_fecha_pago
        '
        Me.dtp_fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pago.Location = New System.Drawing.Point(173, 576)
        Me.dtp_fecha_pago.Name = "dtp_fecha_pago"
        Me.dtp_fecha_pago.Size = New System.Drawing.Size(204, 22)
        Me.dtp_fecha_pago.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvpago)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 319)
        Me.GroupBox2.TabIndex = 1157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Pago"
        '
        'lvpago
        '
        Me.lvpago.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Factura, Me.Deuda, Me.Monto, Me.Saldo})
        Me.lvpago.Location = New System.Drawing.Point(9, 21)
        Me.lvpago.Name = "lvpago"
        Me.lvpago.Size = New System.Drawing.Size(569, 292)
        Me.lvpago.TabIndex = 0
        Me.lvpago.UseCompatibleStateImageBehavior = False
        Me.lvpago.View = System.Windows.Forms.View.Details
        '
        'Factura
        '
        Me.Factura.Text = "Factura"
        Me.Factura.Width = 76
        '
        'Deuda
        '
        Me.Deuda.Text = "Deuda"
        Me.Deuda.Width = 73
        '
        'Monto
        '
        Me.Monto.Text = "Monto"
        Me.Monto.Width = 78
        '
        'Saldo
        '
        Me.Saldo.Text = "Saldo"
        Me.Saldo.Width = 77
        '
        'lbl_pago
        '
        Me.lbl_pago.AutoSize = True
        Me.lbl_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pago.Location = New System.Drawing.Point(23, 581)
        Me.lbl_pago.Name = "lbl_pago"
        Me.lbl_pago.Size = New System.Drawing.Size(138, 17)
        Me.lbl_pago.TabIndex = 1159
        Me.lbl_pago.Text = "FECHA DE PAGO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(286, 543)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 1160
        Me.Label6.Text = "TOTAL:"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_agregar.Location = New System.Drawing.Point(26, 674)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(135, 47)
        Me.btn_agregar.TabIndex = 1161
        Me.btn_agregar.Text = "AGREGAR FACTURA"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_eliminar.Location = New System.Drawing.Point(173, 674)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(135, 47)
        Me.btn_eliminar.TabIndex = 1162
        Me.btn_eliminar.Text = "ELIMINAR FACTURA"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_aceptar.Location = New System.Drawing.Point(314, 674)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(135, 47)
        Me.btn_aceptar.TabIndex = 1163
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_cancelar.Location = New System.Drawing.Point(455, 674)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(135, 47)
        Me.btn_cancelar.TabIndex = 1164
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(357, 540)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(216, 22)
        Me.txt_total.TabIndex = 1165
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(618, 674)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 47)
        Me.Button1.TabIndex = 1166
        Me.Button1.Text = "AGREGAR FACTURA POR CLIENTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_retiro_documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 737)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dtp_fecha_pago)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_pago)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_retiro_documentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Pagos"
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlandeCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Plan_de_Cuentas As Constructora_FV.Plan_de_Cuentas
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents txt_serie As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_operacion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_pago As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lvpago As System.Windows.Forms.ListView
    Friend WithEvents Factura As System.Windows.Forms.ColumnHeader
    Friend WithEvents Deuda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Monto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Saldo As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
