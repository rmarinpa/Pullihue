<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ventas))
        Me.dgv_Mov_Tierra = New System.Windows.Forms.DataGridView()
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad = New System.Windows.Forms.ComboBox()
        Me.txt_descuento = New System.Windows.Forms.ComboBox()
        Me.txt_medidas = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_tipo1 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_venta_m2 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha_act = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmb_codigo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_numero_pedido = New System.Windows.Forms.TextBox()
        Me.cmb_cliente = New System.Windows.Forms.TextBox()
        Me.txt_area_calc = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_direccion_despacho = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_precio_cliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_precio_lista = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_area_calculada = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_familia3 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_familia2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_familia1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_comuna = New System.Windows.Forms.TextBox()
        Me.txt_nombre_ejecutivo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_area_negocio = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_senal_advertencia = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgv_sustitutos = New System.Windows.Forms.DataGridView()
        Me.dgv_complementarios = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Mov_Tierra.SuspendLayout()
        CType(Me.dgv_sustitutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_complementarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Mov_Tierra
        '
        Me.dgv_Mov_Tierra.AllowUserToAddRows = False
        Me.dgv_Mov_Tierra.AllowUserToDeleteRows = False
        Me.dgv_Mov_Tierra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Mov_Tierra.Location = New System.Drawing.Point(905, 55)
        Me.dgv_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Mov_Tierra.Name = "dgv_Mov_Tierra"
        Me.dgv_Mov_Tierra.ReadOnly = True
        Me.dgv_Mov_Tierra.RowHeadersVisible = False
        Me.dgv_Mov_Tierra.Size = New System.Drawing.Size(1010, 300)
        Me.dgv_Mov_Tierra.TabIndex = 1086
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_cantidad)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_descuento)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_medidas)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label38)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_tipo1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label37)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_venta_m2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label36)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label35)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_hora)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_fecha_act)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label33)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label34)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label32)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label31)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_codigo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label30)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_stock)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label29)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_numero_pedido)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_cliente)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_area_calc)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label22)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label21)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_direccion_despacho)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label14)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_precio_cliente)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label13)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_precio_lista)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label12)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_total)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label10)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_iva)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label9)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_monto)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label8)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label6)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label4)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_proveedor)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label25)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label26)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label27)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_descripcion)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label28)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_area_calculada)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label20)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_familia3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label19)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_familia2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label18)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_familia1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label17)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_comuna)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_nombre_ejecutivo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label16)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label15)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_observaciones)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label7)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_fecha)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_area_negocio)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_rut)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label5)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_senal_advertencia)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(16, 14)
        Me.gbx_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(879, 745)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Registro de Venta"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.txt_cantidad.Location = New System.Drawing.Point(174, 406)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(251, 24)
        Me.txt_cantidad.TabIndex = 1210
        '
        'txt_descuento
        '
        Me.txt_descuento.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.txt_descuento.Location = New System.Drawing.Point(600, 443)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(251, 24)
        Me.txt_descuento.TabIndex = 0
        '
        'txt_medidas
        '
        Me.txt_medidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_medidas.Location = New System.Drawing.Point(183, 347)
        Me.txt_medidas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_medidas.MaxLength = 15
        Me.txt_medidas.Name = "txt_medidas"
        Me.txt_medidas.Size = New System.Drawing.Size(251, 22)
        Me.txt_medidas.TabIndex = 1208
        Me.txt_medidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(11, 352)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(73, 17)
        Me.Label38.TabIndex = 1209
        Me.Label38.Text = "MEDIDAS:"
        '
        'txt_tipo1
        '
        Me.txt_tipo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_tipo1.Location = New System.Drawing.Point(183, 317)
        Me.txt_tipo1.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo1.MaxLength = 15
        Me.txt_tipo1.Name = "txt_tipo1"
        Me.txt_tipo1.Size = New System.Drawing.Size(251, 22)
        Me.txt_tipo1.TabIndex = 1206
        Me.txt_tipo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(11, 322)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 17)
        Me.Label37.TabIndex = 1207
        Me.Label37.Text = "TIPO 1:"
        '
        'txt_venta_m2
        '
        Me.txt_venta_m2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_venta_m2.Location = New System.Drawing.Point(600, 527)
        Me.txt_venta_m2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_venta_m2.MaxLength = 40
        Me.txt_venta_m2.Name = "txt_venta_m2"
        Me.txt_venta_m2.Size = New System.Drawing.Size(251, 22)
        Me.txt_venta_m2.TabIndex = 1205
        Me.txt_venta_m2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(441, 530)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(148, 17)
        Me.Label36.TabIndex = 1204
        Me.Label36.Text = "UNIT. VENTA (M2):"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(42, 616)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(129, 17)
        Me.Label35.TabIndex = 1203
        Me.Label35.Text = "ACTUALIZACIÓN"
        '
        'txt_hora
        '
        Me.txt_hora.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(85, 687)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(136, 32)
        Me.txt_hora.TabIndex = 1202
        '
        'txt_fecha_act
        '
        Me.txt_fecha_act.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_act.Location = New System.Drawing.Point(85, 645)
        Me.txt_fecha_act.Name = "txt_fecha_act"
        Me.txt_fecha_act.Size = New System.Drawing.Size(136, 32)
        Me.txt_fecha_act.TabIndex = 1201
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(15, 696)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 17)
        Me.Label33.TabIndex = 1200
        Me.Label33.Text = "HORA:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(15, 654)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 17)
        Me.Label34.TabIndex = 1199
        Me.Label34.Text = "FECHA:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(441, 470)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(268, 17)
        Me.Label32.TabIndex = 1182
        Me.Label32.Text = "NOTA: DESCUENTO APLICABLE HASTA UN 5%."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(441, 442)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(124, 17)
        Me.Label31.TabIndex = 1180
        Me.Label31.Text = "DESCUENTO (%):"
        '
        'cmb_codigo
        '
        Me.cmb_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_codigo.Location = New System.Drawing.Point(183, 165)
        Me.cmb_codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_codigo.MaxLength = 40
        Me.cmb_codigo.Name = "cmb_codigo"
        Me.cmb_codigo.Size = New System.Drawing.Size(439, 22)
        Me.cmb_codigo.TabIndex = 1179
        Me.cmb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(638, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 23)
        Me.Button2.TabIndex = 1178
        Me.Button2.Text = "BUSCAR PRODUCTO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(442, 322)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 17)
        Me.Label30.TabIndex = 1177
        Me.Label30.Text = "STOCK:"
        '
        'txt_stock
        '
        Me.txt_stock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_stock.Location = New System.Drawing.Point(601, 319)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_stock.MaxLength = 40
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(251, 22)
        Me.txt_stock.TabIndex = 1176
        Me.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(504, 129)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(107, 17)
        Me.Label29.TabIndex = 1175
        Me.Label29.Text = "N° DE PEDIDO:"
        '
        'txt_numero_pedido
        '
        Me.txt_numero_pedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_numero_pedido.Location = New System.Drawing.Point(620, 126)
        Me.txt_numero_pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numero_pedido.MaxLength = 40
        Me.txt_numero_pedido.Name = "txt_numero_pedido"
        Me.txt_numero_pedido.Size = New System.Drawing.Size(251, 22)
        Me.txt_numero_pedido.TabIndex = 1174
        Me.txt_numero_pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_cliente
        '
        Me.cmb_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_cliente.Location = New System.Drawing.Point(184, 34)
        Me.cmb_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_cliente.MaxLength = 40
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(687, 22)
        Me.cmb_cliente.TabIndex = 1173
        Me.cmb_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_area_calc
        '
        Me.txt_area_calc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_area_calc.Location = New System.Drawing.Point(174, 434)
        Me.txt_area_calc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_area_calc.MaxLength = 15
        Me.txt_area_calc.Name = "txt_area_calc"
        Me.txt_area_calc.Size = New System.Drawing.Size(251, 22)
        Me.txt_area_calc.TabIndex = 1171
        Me.txt_area_calc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 439)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 17)
        Me.Label22.TabIndex = 1172
        Me.Label22.Text = "ÁREA TOTAL:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 101)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 17)
        Me.Label21.TabIndex = 1170
        Me.Label21.Text = "DIRECCIÓN:"
        '
        'txt_direccion_despacho
        '
        Me.txt_direccion_despacho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho.Location = New System.Drawing.Point(184, 94)
        Me.txt_direccion_despacho.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion_despacho.MaxLength = 40
        Me.txt_direccion_despacho.Name = "txt_direccion_despacho"
        Me.txt_direccion_despacho.Size = New System.Drawing.Size(377, 22)
        Me.txt_direccion_despacho.TabIndex = 1169
        Me.txt_direccion_despacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(441, 500)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 17)
        Me.Label14.TabIndex = 1168
        Me.Label14.Text = "PRECIO CLIENTE:"
        '
        'txt_precio_cliente
        '
        Me.txt_precio_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_precio_cliente.Location = New System.Drawing.Point(600, 497)
        Me.txt_precio_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_cliente.MaxLength = 40
        Me.txt_precio_cliente.Name = "txt_precio_cliente"
        Me.txt_precio_cliente.Size = New System.Drawing.Size(251, 22)
        Me.txt_precio_cliente.TabIndex = 1167
        Me.txt_precio_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(427, 412)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 17)
        Me.Label13.TabIndex = 1166
        Me.Label13.Text = "PRECIO VENTA ROLLO:"
        '
        'txt_precio_lista
        '
        Me.txt_precio_lista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_precio_lista.Location = New System.Drawing.Point(600, 409)
        Me.txt_precio_lista.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_lista.MaxLength = 40
        Me.txt_precio_lista.Name = "txt_precio_lista"
        Me.txt_precio_lista.Size = New System.Drawing.Size(251, 22)
        Me.txt_precio_lista.TabIndex = 1165
        Me.txt_precio_lista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(441, 620)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 1164
        Me.Label12.Text = "TOTAL:"
        '
        'txt_total
        '
        Me.txt_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total.Location = New System.Drawing.Point(600, 617)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.MaxLength = 40
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(251, 22)
        Me.txt_total.TabIndex = 1163
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(441, 590)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 17)
        Me.Label10.TabIndex = 1162
        Me.Label10.Text = "IVA:"
        '
        'txt_iva
        '
        Me.txt_iva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_iva.Location = New System.Drawing.Point(600, 587)
        Me.txt_iva.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_iva.MaxLength = 40
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(251, 22)
        Me.txt_iva.TabIndex = 1161
        Me.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 560)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 1160
        Me.Label9.Text = "MONTO:"
        '
        'txt_monto
        '
        Me.txt_monto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_monto.Location = New System.Drawing.Point(600, 557)
        Me.txt_monto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_monto.MaxLength = 40
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(251, 22)
        Me.txt_monto.TabIndex = 1159
        Me.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(596, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 24)
        Me.Label8.TabIndex = 1158
        Me.Label8.Text = "MONTO TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 409)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 1157
        Me.Label6.Text = "CANTIDAD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(127, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 1155
        Me.Label4.Text = "VENTA"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_proveedor.Location = New System.Drawing.Point(183, 229)
        Me.txt_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_proveedor.MaxLength = 15
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(251, 22)
        Me.txt_proveedor.TabIndex = 1149
        Me.txt_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(11, 228)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 17)
        Me.Label25.TabIndex = 1154
        Me.Label25.Text = "PROVEEDOR:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 170)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(166, 17)
        Me.Label26.TabIndex = 1153
        Me.Label26.Text = "CÓDIGO PRODUCTO:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(11, 263)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(134, 17)
        Me.Label27.TabIndex = 1151
        Me.Label27.Text = "ÁREA CALCULADA:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion.Location = New System.Drawing.Point(183, 199)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.MaxLength = 40
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(439, 22)
        Me.txt_descripcion.TabIndex = 1148
        Me.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(11, 199)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 17)
        Me.Label28.TabIndex = 1152
        Me.Label28.Text = "DESCRIPCIÓN:"
        '
        'txt_area_calculada
        '
        Me.txt_area_calculada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_area_calculada.Location = New System.Drawing.Point(183, 259)
        Me.txt_area_calculada.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_area_calculada.MaxLength = 40
        Me.txt_area_calculada.Name = "txt_area_calculada"
        Me.txt_area_calculada.Size = New System.Drawing.Size(251, 22)
        Me.txt_area_calculada.TabIndex = 1150
        Me.txt_area_calculada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(442, 292)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 17)
        Me.Label20.TabIndex = 1146
        Me.Label20.Text = "FAMILIA 3:"
        '
        'txt_familia3
        '
        Me.txt_familia3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_familia3.Location = New System.Drawing.Point(601, 289)
        Me.txt_familia3.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_familia3.MaxLength = 40
        Me.txt_familia3.Name = "txt_familia3"
        Me.txt_familia3.Size = New System.Drawing.Size(251, 22)
        Me.txt_familia3.TabIndex = 1145
        Me.txt_familia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(442, 262)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 17)
        Me.Label19.TabIndex = 1144
        Me.Label19.Text = "FAMILIA 2:"
        '
        'txt_familia2
        '
        Me.txt_familia2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_familia2.Location = New System.Drawing.Point(601, 259)
        Me.txt_familia2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_familia2.MaxLength = 40
        Me.txt_familia2.Name = "txt_familia2"
        Me.txt_familia2.Size = New System.Drawing.Size(251, 22)
        Me.txt_familia2.TabIndex = 1143
        Me.txt_familia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(442, 232)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 17)
        Me.Label18.TabIndex = 1142
        Me.Label18.Text = "FAMILIA 1:"
        '
        'txt_familia1
        '
        Me.txt_familia1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_familia1.Location = New System.Drawing.Point(601, 229)
        Me.txt_familia1.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_familia1.MaxLength = 40
        Me.txt_familia1.Name = "txt_familia1"
        Me.txt_familia1.Size = New System.Drawing.Size(251, 22)
        Me.txt_familia1.TabIndex = 1141
        Me.txt_familia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 129)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 17)
        Me.Label17.TabIndex = 1140
        Me.Label17.Text = "COMUNA:"
        '
        'txt_comuna
        '
        Me.txt_comuna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna.Location = New System.Drawing.Point(184, 124)
        Me.txt_comuna.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comuna.MaxLength = 40
        Me.txt_comuna.Name = "txt_comuna"
        Me.txt_comuna.Size = New System.Drawing.Size(250, 22)
        Me.txt_comuna.TabIndex = 1139
        Me.txt_comuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nombre_ejecutivo
        '
        Me.txt_nombre_ejecutivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_ejecutivo.Location = New System.Drawing.Point(174, 494)
        Me.txt_nombre_ejecutivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_ejecutivo.MaxLength = 40
        Me.txt_nombre_ejecutivo.Name = "txt_nombre_ejecutivo"
        Me.txt_nombre_ejecutivo.Size = New System.Drawing.Size(251, 22)
        Me.txt_nombre_ejecutivo.TabIndex = 1137
        Me.txt_nombre_ejecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 497)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 17)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "NOMBRE EJECUTIVO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 538)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 17)
        Me.Label15.TabIndex = 1110
        Me.Label15.Text = "OBSERVACIONES:"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(174, 524)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(251, 75)
        Me.txt_observaciones.TabIndex = 9
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(11, 464)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 17)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(174, 464)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(251, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'txt_area_negocio
        '
        Me.txt_area_negocio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_area_negocio.Location = New System.Drawing.Point(183, 287)
        Me.txt_area_negocio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_area_negocio.MaxLength = 15
        Me.txt_area_negocio.Name = "txt_area_negocio"
        Me.txt_area_negocio.Size = New System.Drawing.Size(251, 22)
        Me.txt_area_negocio.TabIndex = 3
        Me.txt_area_negocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 292)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(140, 17)
        Me.label3.TabIndex = 1093
        Me.label3.Text = "ÁREA DE NEGOCIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 1087
        Me.Label2.Text = "SEÑAL ADVERTENCIA:"
        '
        'txt_rut
        '
        Me.txt_rut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_rut.Location = New System.Drawing.Point(184, 64)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rut.MaxLength = 40
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(251, 22)
        Me.txt_rut.TabIndex = 2
        Me.txt_rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 1089
        Me.Label5.Text = "RUT:"
        '
        'txt_senal_advertencia
        '
        Me.txt_senal_advertencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_senal_advertencia.Location = New System.Drawing.Point(620, 63)
        Me.txt_senal_advertencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senal_advertencia.MaxLength = 40
        Me.txt_senal_advertencia.Name = "txt_senal_advertencia"
        Me.txt_senal_advertencia.Size = New System.Drawing.Size(251, 22)
        Me.txt_senal_advertencia.TabIndex = 4
        Me.txt_senal_advertencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(102, 767)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(370, 767)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(13, 767)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(281, 767)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(192, 767)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1273, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(231, 36)
        Me.Label11.TabIndex = 1134
        Me.Label11.Text = "Tabla de Ventas"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1054, 379)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(147, 36)
        Me.Label23.TabIndex = 1136
        Me.Label23.Text = "Sustitutos"
        '
        'dgv_sustitutos
        '
        Me.dgv_sustitutos.AllowUserToAddRows = False
        Me.dgv_sustitutos.AllowUserToDeleteRows = False
        Me.dgv_sustitutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sustitutos.Location = New System.Drawing.Point(904, 419)
        Me.dgv_sustitutos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_sustitutos.Name = "dgv_sustitutos"
        Me.dgv_sustitutos.ReadOnly = True
        Me.dgv_sustitutos.RowHeadersVisible = False
        Me.dgv_sustitutos.Size = New System.Drawing.Size(500, 263)
        Me.dgv_sustitutos.TabIndex = 1135
        '
        'dgv_complementarios
        '
        Me.dgv_complementarios.AllowUserToAddRows = False
        Me.dgv_complementarios.AllowUserToDeleteRows = False
        Me.dgv_complementarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_complementarios.Location = New System.Drawing.Point(1412, 419)
        Me.dgv_complementarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_complementarios.Name = "dgv_complementarios"
        Me.dgv_complementarios.ReadOnly = True
        Me.dgv_complementarios.RowHeadersVisible = False
        Me.dgv_complementarios.Size = New System.Drawing.Size(500, 263)
        Me.dgv_complementarios.TabIndex = 1137
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1543, 379)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(245, 36)
        Me.Label24.TabIndex = 1138
        Me.Label24.Text = "Complementarios"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(904, 705)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(489, 52)
        Me.Button1.TabIndex = 1142
        Me.Button1.Text = "Emitir Documento"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Frm_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1918, 844)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.dgv_complementarios)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.dgv_sustitutos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_Mov_Tierra)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_ventas"
        Me.Text = "Registro de Venta"
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        CType(Me.dgv_sustitutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_complementarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_Mov_Tierra As System.Windows.Forms.DataGridView
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_area_negocio As System.Windows.Forms.TextBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_senal_advertencia As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_ejecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_area_calculada As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_familia3 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_familia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_familia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_lista As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_despacho As System.Windows.Forms.TextBox
    Friend WithEvents txt_area_calc As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents dgv_sustitutos As System.Windows.Forms.DataGridView
    Private WithEvents dgv_complementarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmb_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_pedido As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_act As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_venta_m2 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_medidas As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txt_descuento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.ComboBox
End Class
