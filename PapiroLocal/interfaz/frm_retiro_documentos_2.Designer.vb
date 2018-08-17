<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_retiro_documentos_2
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
        Me.txt_ejecutivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PlandeCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Plan_de_Cuentas = New Constructora_FV.Plan_de_Cuentas()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.dgv_registro = New System.Windows.Forms.DataGridView()
        Me.dgv_facturas = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvpago = New System.Windows.Forms.ListView()
        Me.Factura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Deuda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rbtn_3 = New System.Windows.Forms.RadioButton()
        Me.rbtn_2 = New System.Windows.Forms.RadioButton()
        Me.rbtn_1 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_direccion_despacho4 = New System.Windows.Forms.TextBox()
        Me.txt_comuna4 = New System.Windows.Forms.TextBox()
        Me.txt_direccion_despacho3 = New System.Windows.Forms.TextBox()
        Me.txt_comuna3 = New System.Windows.Forms.TextBox()
        Me.txt_direccion_despacho2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_comuna2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_horario = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_contacto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_folio2 = New System.Windows.Forms.TextBox()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(299, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 25)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "RETIRO DOCUMENTOS"
        '
        'txt_ejecutivo
        '
        Me.txt_ejecutivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_ejecutivo.Location = New System.Drawing.Point(90, 92)
        Me.txt_ejecutivo.MaxLength = 40
        Me.txt_ejecutivo.Name = "txt_ejecutivo"
        Me.txt_ejecutivo.Size = New System.Drawing.Size(154, 20)
        Me.txt_ejecutivo.TabIndex = 2
        Me.txt_ejecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 1155
        Me.Label10.Text = "Ejecutivo"
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
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(90, 46)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(350, 20)
        Me.txt_cliente.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Location = New System.Drawing.Point(32, 607)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(134, 38)
        Me.btn_eliminar.TabIndex = 6
        Me.btn_eliminar.Text = "REGISTRAR RETIRO DE DOCUMENTOS"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(875, 0)
        Me.txt_folio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(10, 20)
        Me.txt_folio.TabIndex = 1172
        Me.txt_folio.Visible = False
        '
        'dgv_registro
        '
        Me.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registro.Location = New System.Drawing.Point(889, 0)
        Me.dgv_registro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_registro.Name = "dgv_registro"
        Me.dgv_registro.RowTemplate.Height = 24
        Me.dgv_registro.Size = New System.Drawing.Size(10, 10)
        Me.dgv_registro.TabIndex = 1173
        Me.dgv_registro.Visible = False
        '
        'dgv_facturas
        '
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Location = New System.Drawing.Point(456, 291)
        Me.dgv_facturas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.RowTemplate.Height = 24
        Me.dgv_facturas.Size = New System.Drawing.Size(552, 304)
        Me.dgv_facturas.TabIndex = 1175
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(849, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(10, 10)
        Me.Button2.TabIndex = 1176
        Me.Button2.Text = "BUSCAR CLIENTE"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(90, 68)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(350, 20)
        Me.txt_rut.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1177
        Me.Label2.Text = "Rut"
        '
        'lvpago
        '
        Me.lvpago.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Factura, Me.Deuda})
        Me.lvpago.Location = New System.Drawing.Point(32, 291)
        Me.lvpago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvpago.Name = "lvpago"
        Me.lvpago.Size = New System.Drawing.Size(410, 305)
        Me.lvpago.TabIndex = 5
        Me.lvpago.UseCompatibleStateImageBehavior = False
        Me.lvpago.View = System.Windows.Forms.View.Details
        '
        'Factura
        '
        Me.Factura.Text = "Factura"
        Me.Factura.Width = 150
        '
        'Deuda
        '
        Me.Deuda.Text = "Monto Factura"
        Me.Deuda.Width = 150
        '
        'rbtn_3
        '
        Me.rbtn_3.AutoSize = True
        Me.rbtn_3.Location = New System.Drawing.Point(76, 141)
        Me.rbtn_3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtn_3.Name = "rbtn_3"
        Me.rbtn_3.Size = New System.Drawing.Size(14, 13)
        Me.rbtn_3.TabIndex = 1303
        Me.rbtn_3.TabStop = True
        Me.rbtn_3.UseVisualStyleBackColor = True
        '
        'rbtn_2
        '
        Me.rbtn_2.AutoSize = True
        Me.rbtn_2.Location = New System.Drawing.Point(76, 94)
        Me.rbtn_2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtn_2.Name = "rbtn_2"
        Me.rbtn_2.Size = New System.Drawing.Size(14, 13)
        Me.rbtn_2.TabIndex = 1302
        Me.rbtn_2.TabStop = True
        Me.rbtn_2.UseVisualStyleBackColor = True
        '
        'rbtn_1
        '
        Me.rbtn_1.AutoSize = True
        Me.rbtn_1.Location = New System.Drawing.Point(76, 50)
        Me.rbtn_1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtn_1.Name = "rbtn_1"
        Me.rbtn_1.Size = New System.Drawing.Size(14, 13)
        Me.rbtn_1.TabIndex = 1301
        Me.rbtn_1.TabStop = True
        Me.rbtn_1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 1300
        Me.Label14.Text = "OTRA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 1299
        Me.Label15.Text = "DESPACHO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 1298
        Me.Label16.Text = "FACTURACIÓN"
        '
        'txt_direccion_despacho4
        '
        Me.txt_direccion_despacho4.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion_despacho4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho4.Location = New System.Drawing.Point(134, 124)
        Me.txt_direccion_despacho4.MaxLength = 40
        Me.txt_direccion_despacho4.Multiline = True
        Me.txt_direccion_despacho4.Name = "txt_direccion_despacho4"
        Me.txt_direccion_despacho4.Size = New System.Drawing.Size(164, 41)
        Me.txt_direccion_despacho4.TabIndex = 4
        '
        'txt_comuna4
        '
        Me.txt_comuna4.BackColor = System.Drawing.Color.White
        Me.txt_comuna4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_comuna4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna4.Location = New System.Drawing.Point(303, 124)
        Me.txt_comuna4.MaxLength = 40
        Me.txt_comuna4.Multiline = True
        Me.txt_comuna4.Name = "txt_comuna4"
        Me.txt_comuna4.Size = New System.Drawing.Size(164, 19)
        Me.txt_comuna4.TabIndex = 5
        '
        'txt_direccion_despacho3
        '
        Me.txt_direccion_despacho3.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion_despacho3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho3.Location = New System.Drawing.Point(134, 78)
        Me.txt_direccion_despacho3.MaxLength = 40
        Me.txt_direccion_despacho3.Multiline = True
        Me.txt_direccion_despacho3.Name = "txt_direccion_despacho3"
        Me.txt_direccion_despacho3.Size = New System.Drawing.Size(164, 41)
        Me.txt_direccion_despacho3.TabIndex = 2
        '
        'txt_comuna3
        '
        Me.txt_comuna3.BackColor = System.Drawing.Color.White
        Me.txt_comuna3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_comuna3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna3.Location = New System.Drawing.Point(303, 78)
        Me.txt_comuna3.MaxLength = 40
        Me.txt_comuna3.Name = "txt_comuna3"
        Me.txt_comuna3.Size = New System.Drawing.Size(164, 19)
        Me.txt_comuna3.TabIndex = 3
        '
        'txt_direccion_despacho2
        '
        Me.txt_direccion_despacho2.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion_despacho2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho2.Location = New System.Drawing.Point(134, 32)
        Me.txt_direccion_despacho2.MaxLength = 40
        Me.txt_direccion_despacho2.Multiline = True
        Me.txt_direccion_despacho2.Name = "txt_direccion_despacho2"
        Me.txt_direccion_despacho2.Size = New System.Drawing.Size(164, 41)
        Me.txt_direccion_despacho2.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(169, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 1293
        Me.Label17.Text = "DIRECCIÓN:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(355, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 1292
        Me.Label18.Text = "COMUNA:"
        '
        'txt_comuna2
        '
        Me.txt_comuna2.BackColor = System.Drawing.Color.White
        Me.txt_comuna2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_comuna2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna2.Location = New System.Drawing.Point(303, 32)
        Me.txt_comuna2.MaxLength = 40
        Me.txt_comuna2.Name = "txt_comuna2"
        Me.txt_comuna2.Size = New System.Drawing.Size(164, 19)
        Me.txt_comuna2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_comuna3)
        Me.GroupBox3.Controls.Add(Me.txt_comuna2)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.rbtn_3)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.rbtn_2)
        Me.GroupBox3.Controls.Add(Me.txt_direccion_despacho2)
        Me.GroupBox3.Controls.Add(Me.rbtn_1)
        Me.GroupBox3.Controls.Add(Me.txt_direccion_despacho3)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_comuna4)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_direccion_despacho4)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(456, 110)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(482, 176)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dirección"
        '
        'txt_horario
        '
        Me.txt_horario.Location = New System.Drawing.Point(32, 158)
        Me.txt_horario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_horario.Multiline = True
        Me.txt_horario.Name = "txt_horario"
        Me.txt_horario.Size = New System.Drawing.Size(408, 81)
        Me.txt_horario.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(30, 141)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 1308
        Me.Label20.Text = "Horario"
        '
        'txt_contacto
        '
        Me.txt_contacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_contacto.Location = New System.Drawing.Point(90, 116)
        Me.txt_contacto.MaxLength = 40
        Me.txt_contacto.Name = "txt_contacto"
        Me.txt_contacto.Size = New System.Drawing.Size(350, 20)
        Me.txt_contacto.TabIndex = 3
        Me.txt_contacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(30, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 1310
        Me.Label21.Text = "Contacto"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(170, 607)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 38)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(637, 15)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(84, 20)
        Me.txt_fecha.TabIndex = 1312
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(587, 15)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 1311
        Me.Label12.Text = "Fecha"
        '
        'txt_folio2
        '
        Me.txt_folio2.Location = New System.Drawing.Point(861, 0)
        Me.txt_folio2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_folio2.Name = "txt_folio2"
        Me.txt_folio2.Size = New System.Drawing.Size(10, 20)
        Me.txt_folio2.TabIndex = 1313
        Me.txt_folio2.Visible = False
        '
        'frm_retiro_documentos_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 709)
        Me.Controls.Add(Me.txt_folio2)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_contacto)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_horario)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lvpago)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgv_facturas)
        Me.Controls.Add(Me.dgv_registro)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ejecutivo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_retiro_documentos_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro Documentos"
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_registro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ejecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlandeCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Plan_de_Cuentas As Constructora_FV.Plan_de_Cuentas
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents dgv_registro As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvpago As System.Windows.Forms.ListView
    Friend WithEvents Factura As System.Windows.Forms.ColumnHeader
    Friend WithEvents Deuda As System.Windows.Forms.ColumnHeader
    Friend WithEvents rbtn_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_despacho4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_despacho3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_despacho2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_comuna2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_horario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_contacto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_folio2 As System.Windows.Forms.TextBox
End Class
