<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consulta_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consulta_pedido))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv_despachos2 = New System.Windows.Forms.DataGridView()
        Me.dgv_despachos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CachedCrystalReport11 = New Constructora_FV.CachedCrystalReport1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_factura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pedido = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_informe1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.chk_factura = New System.Windows.Forms.CheckBox()
        Me.chk_pedido = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_suma_dia = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_in = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv_pendientes = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btn_autorizaciones = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_suma_pedido = New System.Windows.Forms.TextBox()
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(508, 785)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 38)
        Me.Button4.TabIndex = 1190
        Me.Button4.Text = "Cerrar Historico"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgv_despachos2
        '
        Me.dgv_despachos2.AllowUserToAddRows = False
        Me.dgv_despachos2.AllowUserToDeleteRows = False
        Me.dgv_despachos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos2.Location = New System.Drawing.Point(721, 130)
        Me.dgv_despachos2.Name = "dgv_despachos2"
        Me.dgv_despachos2.ReadOnly = True
        Me.dgv_despachos2.RowHeadersVisible = False
        Me.dgv_despachos2.Size = New System.Drawing.Size(461, 186)
        Me.dgv_despachos2.TabIndex = 1203
        '
        'dgv_despachos
        '
        Me.dgv_despachos.AllowUserToAddRows = False
        Me.dgv_despachos.AllowUserToDeleteRows = False
        Me.dgv_despachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos.Location = New System.Drawing.Point(11, 130)
        Me.dgv_despachos.Name = "dgv_despachos"
        Me.dgv_despachos.ReadOnly = True
        Me.dgv_despachos.RowHeadersVisible = False
        Me.dgv_despachos.Size = New System.Drawing.Size(707, 522)
        Me.dgv_despachos.TabIndex = 1210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(448, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(518, 49)
        Me.Label4.TabIndex = 1212
        Me.Label4.Text = "HISTORICO NOTAS DE PEDIDO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1213
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 1214
        Me.Button1.Text = "ACTUALIZAR TABLA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(331, 51)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(80, 20)
        Me.txt_fecha.TabIndex = 1215
        Me.txt_fecha.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(454, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1217
        Me.Label2.Text = "BUSCAR POR:"
        Me.Label2.Visible = False
        '
        'txt_factura
        '
        Me.txt_factura.Location = New System.Drawing.Point(91, 67)
        Me.txt_factura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(168, 20)
        Me.txt_factura.TabIndex = 1219
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1220
        Me.Label3.Text = "N° de Factura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 13)
        Me.Label5.TabIndex = 1221
        Me.Label5.Text = "N° de Pedido --> N° de Factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 1222
        Me.Label6.Text = "N° de Pedido:"
        '
        'txt_pedido
        '
        Me.txt_pedido.Location = New System.Drawing.Point(91, 40)
        Me.txt_pedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_pedido.Name = "txt_pedido"
        Me.txt_pedido.Size = New System.Drawing.Size(168, 20)
        Me.txt_pedido.TabIndex = 1223
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_informe1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_pedido)
        Me.GroupBox1.Controls.Add(Me.txt_factura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(724, 349)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(262, 137)
        Me.GroupBox1.TabIndex = 1224
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Relacionar"
        '
        'btn_informe1
        '
        Me.btn_informe1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_informe1.Image = CType(resources.GetObject("btn_informe1.Image"), System.Drawing.Image)
        Me.btn_informe1.Location = New System.Drawing.Point(23, 98)
        Me.btn_informe1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_informe1.Name = "btn_informe1"
        Me.btn_informe1.Size = New System.Drawing.Size(50, 35)
        Me.btn_informe1.TabIndex = 1225
        Me.btn_informe1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(109, 98)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 35)
        Me.Button2.TabIndex = 1224
        Me.Button2.Text = "Agregar N° de Factura"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(1010, 416)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(76, 20)
        Me.txt_id.TabIndex = 1225
        Me.txt_id.Visible = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(456, 50)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(199, 20)
        Me.txt_buscar.TabIndex = 1226
        '
        'chk_factura
        '
        Me.chk_factura.AutoSize = True
        Me.chk_factura.Location = New System.Drawing.Point(456, 28)
        Me.chk_factura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_factura.Name = "chk_factura"
        Me.chk_factura.Size = New System.Drawing.Size(62, 17)
        Me.chk_factura.TabIndex = 1227
        Me.chk_factura.Text = "Factura"
        Me.chk_factura.UseVisualStyleBackColor = True
        '
        'chk_pedido
        '
        Me.chk_pedido.AutoSize = True
        Me.chk_pedido.Location = New System.Drawing.Point(554, 28)
        Me.chk_pedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_pedido.Name = "chk_pedido"
        Me.chk_pedido.Size = New System.Drawing.Size(59, 17)
        Me.chk_pedido.TabIndex = 1228
        Me.chk_pedido.Text = "Pedido"
        Me.chk_pedido.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(422, 44)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1229
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 658)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 17)
        Me.Label8.TabIndex = 1233
        Me.Label8.Text = "TOTAL NOTAS DE PEDIDO"
        '
        'txt_suma_dia
        '
        Me.txt_suma_dia.Location = New System.Drawing.Point(632, 681)
        Me.txt_suma_dia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_suma_dia.Name = "txt_suma_dia"
        Me.txt_suma_dia.ReadOnly = True
        Me.txt_suma_dia.Size = New System.Drawing.Size(80, 20)
        Me.txt_suma_dia.TabIndex = 1232
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dtp_fecha_in)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_buscar)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_fecha)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.chk_factura)
        Me.GroupBox2.Controls.Add(Me.chk_pedido)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 701)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(707, 81)
        Me.GroupBox2.TabIndex = 1234
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios de Búsqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1235
        Me.Label1.Text = "FECHA FINAL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(225, 28)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 1234
        Me.Label13.Text = "FECHA INICIAL:"
        '
        'dtp_fecha_in
        '
        Me.dtp_fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_in.Location = New System.Drawing.Point(331, 28)
        Me.dtp_fecha_in.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_fecha_in.Name = "dtp_fecha_in"
        Me.dtp_fecha_in.Size = New System.Drawing.Size(82, 20)
        Me.dtp_fecha_in.TabIndex = 1233
        Me.dtp_fecha_in.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(205, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 13)
        Me.Label10.TabIndex = 1232
        Me.Label10.Text = "SELECCIÓN DE FECHA DE PEDIDOS"
        '
        'dgv_pendientes
        '
        Me.dgv_pendientes.AllowUserToAddRows = False
        Me.dgv_pendientes.AllowUserToDeleteRows = False
        Me.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendientes.Location = New System.Drawing.Point(724, 492)
        Me.dgv_pendientes.Name = "dgv_pendientes"
        Me.dgv_pendientes.ReadOnly = True
        Me.dgv_pendientes.RowHeadersVisible = False
        Me.dgv_pendientes.Size = New System.Drawing.Size(712, 238)
        Me.dgv_pendientes.TabIndex = 1236
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(991, 453)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 33)
        Me.Label9.TabIndex = 1237
        Me.Label9.Text = "PEDIDOS PENDIENTES"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Blue
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(724, 736)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 41)
        Me.Button5.TabIndex = 1238
        Me.Button5.Text = "ACTUALIZAR TABLA PENDIENTES"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(1187, 403)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(113, 41)
        Me.Button8.TabIndex = 1251
        Me.Button8.Text = "Resumen de Rutas"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btn_autorizaciones
        '
        Me.btn_autorizaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_autorizaciones.Location = New System.Drawing.Point(1187, 357)
        Me.btn_autorizaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_autorizaciones.Name = "btn_autorizaciones"
        Me.btn_autorizaciones.Size = New System.Drawing.Size(113, 41)
        Me.btn_autorizaciones.TabIndex = 1250
        Me.btn_autorizaciones.Text = "Resumen de Autorizaciones"
        Me.btn_autorizaciones.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(1187, 310)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 41)
        Me.Button3.TabIndex = 1249
        Me.Button3.Text = "Toma de Pedidos y R. Doc."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1020, 368)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 1257
        Me.Label11.Text = "TOTAL"
        '
        'txt_total2
        '
        Me.txt_total2.Location = New System.Drawing.Point(1118, 367)
        Me.txt_total2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.Size = New System.Drawing.Size(65, 20)
        Me.txt_total2.TabIndex = 1256
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(1118, 344)
        Me.txt_iva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(65, 20)
        Me.txt_iva.TabIndex = 1255
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1020, 345)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 17)
        Me.Label12.TabIndex = 1254
        Me.Label12.Text = "IVA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1020, 323)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 17)
        Me.Label14.TabIndex = 1253
        Me.Label14.Text = "MONTO NETO"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(1118, 322)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(65, 20)
        Me.txt_total.TabIndex = 1252
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(508, 682)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 1259
        Me.Label7.Text = "TOTAL FACTURADO"
        '
        'txt_suma_pedido
        '
        Me.txt_suma_pedido.Location = New System.Drawing.Point(632, 658)
        Me.txt_suma_pedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_suma_pedido.Name = "txt_suma_pedido"
        Me.txt_suma_pedido.ReadOnly = True
        Me.txt_suma_pedido.Size = New System.Drawing.Size(80, 20)
        Me.txt_suma_pedido.TabIndex = 1258
        '
        'Frm_consulta_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_suma_pedido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_total2)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btn_autorizaciones)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgv_pendientes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_suma_dia)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_despachos)
        Me.Controls.Add(Me.dgv_despachos2)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_consulta_pedido"
        Me.Text = "Notas de Venta"
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents dgv_despachos2 As System.Windows.Forms.DataGridView
    Private WithEvents dgv_despachos As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CachedCrystalReport11 As Constructora_FV.CachedCrystalReport1
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents chk_factura As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pedido As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_suma_dia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_informe1 As System.Windows.Forms.Button
    Private WithEvents dgv_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btn_autorizaciones As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_total2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_suma_pedido As System.Windows.Forms.TextBox
End Class
