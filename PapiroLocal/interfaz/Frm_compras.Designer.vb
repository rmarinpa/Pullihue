<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_compras))
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_items = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_cantidad = New System.Windows.Forms.ComboBox()
        Me.txt_largo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_ancho = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv_compra = New System.Windows.Forms.DataGridView()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha_act = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_nombre_ejecutivo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_cliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_direccion_despacho = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_comuna = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_categoria2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.ComboBox()
        Me.cmb_medidas2 = New System.Windows.Forms.ComboBox()
        Me.cmb_medidas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_PAI = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_folio_compra = New System.Windows.Forms.TextBox()
        Me.lbl_folio_compra = New System.Windows.Forms.Label()
        Me.lbl_pai = New System.Windows.Forms.Label()
        Me.txt_pai = New System.Windows.Forms.TextBox()
        Me.lbl_cn = New System.Windows.Forms.Label()
        Me.gbx_Mov_Tierra.SuspendLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_stock)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label19)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label15)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_items)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label14)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_codigo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label13)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label12)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_cantidad)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_largo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label9)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label10)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_descripcion)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_ancho)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label11)
        Me.gbx_Mov_Tierra.Controls.Add(Me.dgv_compra)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_hora)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_fecha_act)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label33)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label34)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_nombre_ejecutivo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label16)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(635, 12)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(587, 461)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Registro de Compra"
        '
        'txt_stock
        '
        Me.txt_stock.BackColor = System.Drawing.Color.White
        Me.txt_stock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_stock.Location = New System.Drawing.Point(266, 129)
        Me.txt_stock.MaxLength = 40
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(69, 20)
        Me.txt_stock.TabIndex = 1299
        Me.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(215, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 1298
        Me.Label19.Text = "STOCK:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button2.Location = New System.Drawing.Point(340, 390)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 37)
        Me.Button2.TabIndex = 1282
        Me.Button2.Text = "Generar Compra"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(466, 384)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 17)
        Me.Label15.TabIndex = 1281
        Me.Label15.Text = "N° de ITEMS"
        '
        'txt_items
        '
        Me.txt_items.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_items.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_items.Location = New System.Drawing.Point(466, 403)
        Me.txt_items.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_items.Multiline = True
        Me.txt_items.Name = "txt_items"
        Me.txt_items.Size = New System.Drawing.Size(80, 24)
        Me.txt_items.TabIndex = 1280
        Me.txt_items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(385, 101)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 48)
        Me.Button1.TabIndex = 1279
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(83, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 1278
        Me.Label14.Text = "CÓDIGO:"
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.White
        Me.txt_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_codigo.Location = New System.Drawing.Point(140, 57)
        Me.txt_codigo.MaxLength = 40
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(333, 20)
        Me.txt_codigo.TabIndex = 1277
        Me.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(167, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(269, 33)
        Me.Label13.TabIndex = 1275
        Me.Label13.Text = "REGISTRO DE COMPRA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 1274
        Me.Label12.Text = "CANTIDAD:"
        '
        'cmb_cantidad
        '
        Me.cmb_cantidad.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_cantidad.FormattingEnabled = True
        Me.cmb_cantidad.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmb_cantidad.Location = New System.Drawing.Point(140, 131)
        Me.cmb_cantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_cantidad.Name = "cmb_cantidad"
        Me.cmb_cantidad.Size = New System.Drawing.Size(69, 21)
        Me.cmb_cantidad.TabIndex = 1273
        '
        'txt_largo
        '
        Me.txt_largo.BackColor = System.Drawing.Color.White
        Me.txt_largo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_largo.Location = New System.Drawing.Point(266, 101)
        Me.txt_largo.MaxLength = 40
        Me.txt_largo.Name = "txt_largo"
        Me.txt_largo.Size = New System.Drawing.Size(69, 20)
        Me.txt_largo.TabIndex = 1272
        Me.txt_largo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(214, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 1271
        Me.Label9.Text = "LARGO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 1270
        Me.Label10.Text = "DESCRIPCIÓN:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BackColor = System.Drawing.Color.White
        Me.txt_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion.Location = New System.Drawing.Point(140, 79)
        Me.txt_descripcion.MaxLength = 40
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(333, 20)
        Me.txt_descripcion.TabIndex = 1269
        Me.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ancho
        '
        Me.txt_ancho.BackColor = System.Drawing.Color.White
        Me.txt_ancho.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ancho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_ancho.Location = New System.Drawing.Point(140, 103)
        Me.txt_ancho.MaxLength = 40
        Me.txt_ancho.Name = "txt_ancho"
        Me.txt_ancho.Size = New System.Drawing.Size(69, 19)
        Me.txt_ancho.TabIndex = 1267
        Me.txt_ancho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 1268
        Me.Label11.Text = "ANCHO:"
        '
        'dgv_compra
        '
        Me.dgv_compra.AllowUserToAddRows = False
        Me.dgv_compra.AllowUserToDeleteRows = False
        Me.dgv_compra.AllowUserToOrderColumns = True
        Me.dgv_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compra.Location = New System.Drawing.Point(13, 163)
        Me.dgv_compra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_compra.Name = "dgv_compra"
        Me.dgv_compra.RowTemplate.Height = 24
        Me.dgv_compra.Size = New System.Drawing.Size(558, 204)
        Me.dgv_compra.TabIndex = 1266
        '
        'txt_hora
        '
        Me.txt_hora.BackColor = System.Drawing.Color.White
        Me.txt_hora.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(245, 406)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(80, 24)
        Me.txt_hora.TabIndex = 1202
        '
        'txt_fecha_act
        '
        Me.txt_fecha_act.BackColor = System.Drawing.Color.White
        Me.txt_fecha_act.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_act.Location = New System.Drawing.Point(157, 406)
        Me.txt_fecha_act.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_fecha_act.Name = "txt_fecha_act"
        Me.txt_fecha_act.Size = New System.Drawing.Size(80, 24)
        Me.txt_fecha_act.TabIndex = 1201
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(262, 390)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(46, 13)
        Me.Label33.TabIndex = 1200
        Me.Label33.Text = "HORA:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(169, 390)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(51, 13)
        Me.Label34.TabIndex = 1199
        Me.Label34.Text = "FECHA:"
        '
        'txt_nombre_ejecutivo
        '
        Me.txt_nombre_ejecutivo.BackColor = System.Drawing.Color.White
        Me.txt_nombre_ejecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_ejecutivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_ejecutivo.Location = New System.Drawing.Point(25, 406)
        Me.txt_nombre_ejecutivo.MaxLength = 40
        Me.txt_nombre_ejecutivo.Multiline = True
        Me.txt_nombre_ejecutivo.Name = "txt_nombre_ejecutivo"
        Me.txt_nombre_ejecutivo.Size = New System.Drawing.Size(126, 24)
        Me.txt_nombre_ejecutivo.TabIndex = 1137
        Me.txt_nombre_ejecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(40, 391)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "TOMA COMPRA:"
        '
        'cmb_cliente
        '
        Me.cmb_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_cliente.Location = New System.Drawing.Point(111, 25)
        Me.cmb_cliente.MaxLength = 40
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(250, 19)
        Me.cmb_cliente.TabIndex = 0
        Me.cmb_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmb_cliente.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 1170
        Me.Label21.Text = "DIRECCIÓN:"
        Me.Label21.Visible = False
        '
        'txt_direccion_despacho
        '
        Me.txt_direccion_despacho.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_despacho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho.Location = New System.Drawing.Point(111, 74)
        Me.txt_direccion_despacho.MaxLength = 40
        Me.txt_direccion_despacho.Name = "txt_direccion_despacho"
        Me.txt_direccion_despacho.Size = New System.Drawing.Size(250, 19)
        Me.txt_direccion_despacho.TabIndex = 2
        Me.txt_direccion_despacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_direccion_despacho.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 1140
        Me.Label17.Text = "COMUNA:"
        Me.Label17.Visible = False
        '
        'txt_comuna
        '
        Me.txt_comuna.BackColor = System.Drawing.Color.White
        Me.txt_comuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comuna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna.Location = New System.Drawing.Point(111, 98)
        Me.txt_comuna.MaxLength = 40
        Me.txt_comuna.Name = "txt_comuna"
        Me.txt_comuna.Size = New System.Drawing.Size(250, 19)
        Me.txt_comuna.TabIndex = 3
        Me.txt_comuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_comuna.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "PROVEEDOR:"
        Me.Label1.Visible = False
        '
        'txt_rut
        '
        Me.txt_rut.BackColor = System.Drawing.Color.White
        Me.txt_rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_rut.Location = New System.Drawing.Point(111, 50)
        Me.txt_rut.MaxLength = 40
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(250, 19)
        Me.txt_rut.TabIndex = 1
        Me.txt_rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_rut.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 1089
        Me.Label5.Text = "RUT:"
        Me.Label5.Visible = False
        '
        'Timer1
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Blue
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(452, 421)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 55)
        Me.Button4.TabIndex = 1190
        Me.Button4.Text = "Cerrar Programa Compras"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 55)
        Me.GroupBox1.TabIndex = 1257
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda por Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(5, 23)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nombre.Multiline = True
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(260, 18)
        Me.txt_nombre.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(465, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1097
        Me.Label6.Text = "LARGO:"
        Me.Label6.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(539, 47)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox3.TabIndex = 1
        Me.ComboBox3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(467, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 1095
        Me.Label7.Text = "ANCHO:"
        Me.Label7.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(539, 72)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox4.TabIndex = 1094
        Me.ComboBox4.Visible = False
        '
        'dgv_clientes
        '
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(11, 240)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(614, 173)
        Me.dgv_clientes.TabIndex = 1256
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_categoria2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_cliente)
        Me.GroupBox2.Controls.Add(Me.cmb_medidas2)
        Me.GroupBox2.Controls.Add(Me.cmb_medidas)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 97)
        Me.GroupBox2.TabIndex = 1255
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsqueda por Categoría"
        '
        'txt_categoria2
        '
        Me.txt_categoria2.FormattingEnabled = True
        Me.txt_categoria2.Items.AddRange(New Object() {"VINILOS TRANSPARENTES Y LAMINADOS ", "VINILOS REVERSO NEGRO Y BLANCO", "VINILOS DE COLOR Y ESPECIALES", "VINILOS BLANCOS", "TINTAS ROLAND Y CHALLENGER", "TELAS FRONTLITE, BACKLIGHT y Otros", "ROLLERs", "PVC ESPUMADO tipo SINTRA / TROVICEL", "PAPEL SINTÉTICO CAVASER", "PAPEL LÁTEX", "FOME COR AMERICANO", "CINTAS DOBLE CONTACTO", "CAVASER PAPER FOAM", "CARTULINAS", "ALVEOLAR CAVASER", "OTROS"})
        Me.txt_categoria2.Location = New System.Drawing.Point(103, 55)
        Me.txt_categoria2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_categoria2.Name = "txt_categoria2"
        Me.txt_categoria2.Size = New System.Drawing.Size(216, 21)
        Me.txt_categoria2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 1099
        Me.Label3.Text = "CATEGORÍA II:"
        '
        'txt_cliente
        '
        Me.txt_cliente.FormattingEnabled = True
        Me.txt_cliente.Items.AddRange(New Object() {"VINILOS TRANSPARENTES Y LAMINADOS ", "VINILOS REVERSO NEGRO Y BLANCO", "VINILOS DE COLOR Y ESPECIALES", "VINILOS BLANCOS", "TINTAS ROLAND Y CHALLENGER", "TELAS FRONTLITE, BACKLIGHT y Otros", "ROLLERs", "PVC ESPUMADO tipo SINTRA / TROVICEL", "PAPEL SINTÉTICO CAVASER", "PAPEL LÁTEX", "FOME COR AMERICANO", "CINTAS DOBLE CONTACTO", "CAVASER PAPER FOAM", "CARTULINAS", "ALVEOLAR CAVASER", "OTROS"})
        Me.txt_cliente.Location = New System.Drawing.Point(103, 20)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(216, 21)
        Me.txt_cliente.TabIndex = 0
        '
        'cmb_medidas2
        '
        Me.cmb_medidas2.FormattingEnabled = True
        Me.cmb_medidas2.Location = New System.Drawing.Point(539, 47)
        Me.cmb_medidas2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_medidas2.Name = "cmb_medidas2"
        Me.cmb_medidas2.Size = New System.Drawing.Size(75, 21)
        Me.cmb_medidas2.TabIndex = 1096
        Me.cmb_medidas2.Visible = False
        '
        'cmb_medidas
        '
        Me.cmb_medidas.FormattingEnabled = True
        Me.cmb_medidas.Location = New System.Drawing.Point(539, 72)
        Me.cmb_medidas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_medidas.Name = "cmb_medidas"
        Me.cmb_medidas.Size = New System.Drawing.Size(75, 21)
        Me.cmb_medidas.TabIndex = 1094
        Me.cmb_medidas.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 1090
        Me.Label4.Text = "CATEGORÍA I:"
        '
        'cmb_PAI
        '
        Me.cmb_PAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PAI.FormattingEnabled = True
        Me.cmb_PAI.Items.AddRange(New Object() {"Compra Nacional", "Importación", "Ajuste"})
        Me.cmb_PAI.Location = New System.Drawing.Point(15, 140)
        Me.cmb_PAI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_PAI.Name = "cmb_PAI"
        Me.cmb_PAI.Size = New System.Drawing.Size(153, 21)
        Me.cmb_PAI.TabIndex = 1258
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 1259
        Me.Label8.Text = "IMPORTACIÓN:"
        '
        'txt_folio_compra
        '
        Me.txt_folio_compra.BackColor = System.Drawing.Color.White
        Me.txt_folio_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_folio_compra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_folio_compra.Location = New System.Drawing.Point(478, 26)
        Me.txt_folio_compra.MaxLength = 40
        Me.txt_folio_compra.Name = "txt_folio_compra"
        Me.txt_folio_compra.Size = New System.Drawing.Size(146, 19)
        Me.txt_folio_compra.TabIndex = 1260
        Me.txt_folio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_folio_compra.Visible = False
        '
        'lbl_folio_compra
        '
        Me.lbl_folio_compra.AutoSize = True
        Me.lbl_folio_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_folio_compra.Location = New System.Drawing.Point(376, 28)
        Me.lbl_folio_compra.Name = "lbl_folio_compra"
        Me.lbl_folio_compra.Size = New System.Drawing.Size(103, 13)
        Me.lbl_folio_compra.TabIndex = 1261
        Me.lbl_folio_compra.Text = "FOLIO COMPRA:"
        Me.lbl_folio_compra.Visible = False
        '
        'lbl_pai
        '
        Me.lbl_pai.AutoSize = True
        Me.lbl_pai.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pai.Location = New System.Drawing.Point(170, 126)
        Me.lbl_pai.Name = "lbl_pai"
        Me.lbl_pai.Size = New System.Drawing.Size(31, 13)
        Me.lbl_pai.TabIndex = 1263
        Me.lbl_pai.Text = "PAI:"
        Me.lbl_pai.Visible = False
        '
        'txt_pai
        '
        Me.txt_pai.BackColor = System.Drawing.Color.White
        Me.txt_pai.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_pai.Location = New System.Drawing.Point(173, 142)
        Me.txt_pai.MaxLength = 40
        Me.txt_pai.Name = "txt_pai"
        Me.txt_pai.Size = New System.Drawing.Size(120, 19)
        Me.txt_pai.TabIndex = 1264
        Me.txt_pai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_pai.Visible = False
        '
        'lbl_cn
        '
        Me.lbl_cn.AutoSize = True
        Me.lbl_cn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cn.Location = New System.Drawing.Point(170, 126)
        Me.lbl_cn.Name = "lbl_cn"
        Me.lbl_cn.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cn.TabIndex = 1265
        Me.lbl_cn.Text = "CN:"
        Me.lbl_cn.Visible = False
        '
        'Frm_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_pai)
        Me.Controls.Add(Me.lbl_pai)
        Me.Controls.Add(Me.lbl_cn)
        Me.Controls.Add(Me.txt_folio_compra)
        Me.Controls.Add(Me.lbl_folio_compra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_PAI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_comuna)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_direccion_despacho)
        Me.Controls.Add(Me.cmb_cliente)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_compras"
        Me.Text = "Modulo de Compras"
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_ejecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_despacho As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_act As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_categoria2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_medidas2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_medidas As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_PAI As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_folio_compra As System.Windows.Forms.TextBox
    Friend WithEvents lbl_folio_compra As System.Windows.Forms.Label
    Friend WithEvents dgv_compra As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_cantidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_largo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_ancho As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_items As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pai As System.Windows.Forms.Label
    Friend WithEvents txt_pai As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cn As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
