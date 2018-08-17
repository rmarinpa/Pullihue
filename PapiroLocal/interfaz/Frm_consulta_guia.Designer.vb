<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consulta_guia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consulta_guia))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv_despachos2 = New System.Windows.Forms.DataGridView()
        Me.dgv_despachos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CachedCrystalReport11 = New Constructora_FV.CachedCrystalReport1()
        Me.txt_factura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pedido = New System.Windows.Forms.TextBox()
        Me.gp_relacionar = New System.Windows.Forms.GroupBox()
        Me.btn_informe1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gp_autorizar = New System.Windows.Forms.GroupBox()
        Me.btn_rechazar = New System.Windows.Forms.Button()
        Me.txt_folio2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_autorizar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fact_ref = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecha_ref = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gp_anular = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_guia2 = New System.Windows.Forms.TextBox()
        Me.txt_pedido2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_reemitir = New System.Windows.Forms.Button()
        Me.gp_reemitir = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_email2 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dgv_rutas = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_relacionar.SuspendLayout()
        Me.gp_autorizar.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_anular.SuspendLayout()
        Me.gp_reemitir.SuspendLayout()
        CType(Me.dgv_rutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(598, 561)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
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
        Me.dgv_despachos2.Location = New System.Drawing.Point(777, 74)
        Me.dgv_despachos2.Name = "dgv_despachos2"
        Me.dgv_despachos2.ReadOnly = True
        Me.dgv_despachos2.RowHeadersVisible = False
        Me.dgv_despachos2.Size = New System.Drawing.Size(446, 186)
        Me.dgv_despachos2.TabIndex = 1203
        '
        'dgv_despachos
        '
        Me.dgv_despachos.AllowUserToAddRows = False
        Me.dgv_despachos.AllowUserToDeleteRows = False
        Me.dgv_despachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos.Location = New System.Drawing.Point(11, 74)
        Me.dgv_despachos.Name = "dgv_despachos"
        Me.dgv_despachos.RowHeadersVisible = False
        Me.dgv_despachos.Size = New System.Drawing.Size(752, 479)
        Me.dgv_despachos.TabIndex = 1210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(519, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 49)
        Me.Label4.TabIndex = 1212
        Me.Label4.Text = "GUÍAS POR EMITIR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1213
        Me.PictureBox1.TabStop = False
        '
        'txt_factura
        '
        Me.txt_factura.Location = New System.Drawing.Point(91, 67)
        Me.txt_factura.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(150, 20)
        Me.txt_factura.TabIndex = 1219
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 1220
        Me.Label3.Text = "N° de Guía:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 13)
        Me.Label5.TabIndex = 1221
        Me.Label5.Text = "N° de Pedido --> N° Guía de Despacho"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 1222
        Me.Label6.Text = "N° de Folio:"
        '
        'txt_pedido
        '
        Me.txt_pedido.Location = New System.Drawing.Point(91, 40)
        Me.txt_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pedido.Name = "txt_pedido"
        Me.txt_pedido.Size = New System.Drawing.Size(150, 20)
        Me.txt_pedido.TabIndex = 1223
        '
        'gp_relacionar
        '
        Me.gp_relacionar.Controls.Add(Me.btn_informe1)
        Me.gp_relacionar.Controls.Add(Me.Label5)
        Me.gp_relacionar.Controls.Add(Me.txt_pedido)
        Me.gp_relacionar.Controls.Add(Me.txt_factura)
        Me.gp_relacionar.Controls.Add(Me.Label6)
        Me.gp_relacionar.Controls.Add(Me.Button5)
        Me.gp_relacionar.Controls.Add(Me.Label3)
        Me.gp_relacionar.Location = New System.Drawing.Point(777, 356)
        Me.gp_relacionar.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_relacionar.Name = "gp_relacionar"
        Me.gp_relacionar.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_relacionar.Size = New System.Drawing.Size(257, 137)
        Me.gp_relacionar.TabIndex = 1224
        Me.gp_relacionar.TabStop = False
        Me.gp_relacionar.Text = "Relacionar"
        '
        'btn_informe1
        '
        Me.btn_informe1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_informe1.Image = CType(resources.GetObject("btn_informe1.Image"), System.Drawing.Image)
        Me.btn_informe1.Location = New System.Drawing.Point(14, 97)
        Me.btn_informe1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_informe1.Name = "btn_informe1"
        Me.btn_informe1.Size = New System.Drawing.Size(50, 35)
        Me.btn_informe1.TabIndex = 1225
        Me.btn_informe1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lime
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(74, 98)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 35)
        Me.Button5.TabIndex = 1226
        Me.Button5.Text = "Emitir Guía de Despacho"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'gp_autorizar
        '
        Me.gp_autorizar.Controls.Add(Me.btn_rechazar)
        Me.gp_autorizar.Controls.Add(Me.txt_folio2)
        Me.gp_autorizar.Controls.Add(Me.Label8)
        Me.gp_autorizar.Controls.Add(Me.btn_autorizar)
        Me.gp_autorizar.Location = New System.Drawing.Point(1049, 365)
        Me.gp_autorizar.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_autorizar.Name = "gp_autorizar"
        Me.gp_autorizar.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_autorizar.Size = New System.Drawing.Size(189, 128)
        Me.gp_autorizar.TabIndex = 1257
        Me.gp_autorizar.TabStop = False
        Me.gp_autorizar.Text = "Autorizar"
        '
        'btn_rechazar
        '
        Me.btn_rechazar.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_rechazar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_rechazar.Location = New System.Drawing.Point(13, 87)
        Me.btn_rechazar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_rechazar.Name = "btn_rechazar"
        Me.btn_rechazar.Size = New System.Drawing.Size(167, 35)
        Me.btn_rechazar.TabIndex = 1227
        Me.btn_rechazar.Text = "Rechazar Guía de Despacho"
        Me.btn_rechazar.UseVisualStyleBackColor = False
        '
        'txt_folio2
        '
        Me.txt_folio2.Location = New System.Drawing.Point(90, 21)
        Me.txt_folio2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_folio2.Name = "txt_folio2"
        Me.txt_folio2.ReadOnly = True
        Me.txt_folio2.Size = New System.Drawing.Size(76, 20)
        Me.txt_folio2.TabIndex = 1223
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 24)
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
        Me.btn_autorizar.Location = New System.Drawing.Point(13, 48)
        Me.btn_autorizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_autorizar.Name = "btn_autorizar"
        Me.btn_autorizar.Size = New System.Drawing.Size(167, 35)
        Me.btn_autorizar.TabIndex = 1226
        Me.btn_autorizar.Text = "Autorizar Guía de Despacho"
        Me.btn_autorizar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1146, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(10, 10)
        Me.Button2.TabIndex = 1224
        Me.Button2.Text = "Agregar N° de Factura"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(1160, 391)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(66, 20)
        Me.txt_id.TabIndex = 1225
        Me.txt_id.Visible = False
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
        Me.dgv_clientes.Location = New System.Drawing.Point(1175, 15)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.Size = New System.Drawing.Size(10, 8)
        Me.dgv_clientes.TabIndex = 1240
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(1160, 11)
        Me.txt_observacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(10, 20)
        Me.txt_observacion.TabIndex = 1244
        Me.txt_observacion.Visible = False
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(913, 308)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.ReadOnly = True
        Me.txt_hora.Size = New System.Drawing.Size(74, 20)
        Me.txt_hora.TabIndex = 1245
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(815, 308)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 17)
        Me.Label12.TabIndex = 1246
        Me.Label12.Text = "HORA ACTUAL:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1063, 311)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 1252
        Me.Label10.Text = "TOTAL"
        '
        'txt_total2
        '
        Me.txt_total2.Location = New System.Drawing.Point(1161, 310)
        Me.txt_total2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.Size = New System.Drawing.Size(65, 20)
        Me.txt_total2.TabIndex = 1251
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(1161, 287)
        Me.txt_iva.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(65, 20)
        Me.txt_iva.TabIndex = 1250
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1063, 288)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 1249
        Me.Label9.Text = "IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1063, 266)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 1248
        Me.Label7.Text = "MONTO NETO"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(1161, 265)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(65, 20)
        Me.txt_total.TabIndex = 1247
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(774, 263)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 1254
        Me.Label1.Text = "FACTURA REFERENCIA:"
        '
        'txt_fact_ref
        '
        Me.txt_fact_ref.Location = New System.Drawing.Point(913, 263)
        Me.txt_fact_ref.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fact_ref.Name = "txt_fact_ref"
        Me.txt_fact_ref.ReadOnly = True
        Me.txt_fact_ref.Size = New System.Drawing.Size(74, 20)
        Me.txt_fact_ref.TabIndex = 1253
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(799, 285)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 1256
        Me.Label2.Text = "FECHA FACT. REF.:"
        '
        'txt_fecha_ref
        '
        Me.txt_fecha_ref.Location = New System.Drawing.Point(913, 285)
        Me.txt_fecha_ref.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha_ref.Name = "txt_fecha_ref"
        Me.txt_fecha_ref.ReadOnly = True
        Me.txt_fecha_ref.Size = New System.Drawing.Size(74, 20)
        Me.txt_fecha_ref.TabIndex = 1255
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(27, 563)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 1258
        Me.Button1.Text = "ACTUALIZAR TABLA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gp_anular
        '
        Me.gp_anular.Controls.Add(Me.Label11)
        Me.gp_anular.Controls.Add(Me.txt_guia2)
        Me.gp_anular.Controls.Add(Me.txt_pedido2)
        Me.gp_anular.Controls.Add(Me.Label13)
        Me.gp_anular.Controls.Add(Me.Button3)
        Me.gp_anular.Location = New System.Drawing.Point(777, 497)
        Me.gp_anular.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_anular.Name = "gp_anular"
        Me.gp_anular.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_anular.Size = New System.Drawing.Size(170, 109)
        Me.gp_anular.TabIndex = 1259
        Me.gp_anular.TabStop = False
        Me.gp_anular.Text = "Anular o Cambiar Folio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 48)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 1230
        Me.Label11.Text = "N° de Guía:"
        '
        'txt_guia2
        '
        Me.txt_guia2.Location = New System.Drawing.Point(90, 44)
        Me.txt_guia2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_guia2.Name = "txt_guia2"
        Me.txt_guia2.Size = New System.Drawing.Size(66, 20)
        Me.txt_guia2.TabIndex = 1227
        '
        'txt_pedido2
        '
        Me.txt_pedido2.Enabled = False
        Me.txt_pedido2.Location = New System.Drawing.Point(90, 21)
        Me.txt_pedido2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pedido2.Name = "txt_pedido2"
        Me.txt_pedido2.Size = New System.Drawing.Size(66, 20)
        Me.txt_pedido2.TabIndex = 1223
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 24)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 1222
        Me.Label13.Text = "N° de Folio:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Turquoise
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(21, 68)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 35)
        Me.Button3.TabIndex = 1226
        Me.Button3.Text = "Anular o Cambiar Folio"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_reemitir
        '
        Me.btn_reemitir.BackColor = System.Drawing.Color.Tomato
        Me.btn_reemitir.ForeColor = System.Drawing.Color.White
        Me.btn_reemitir.Location = New System.Drawing.Point(4, 17)
        Me.btn_reemitir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reemitir.Name = "btn_reemitir"
        Me.btn_reemitir.Size = New System.Drawing.Size(116, 35)
        Me.btn_reemitir.TabIndex = 1229
        Me.btn_reemitir.Text = "Volver a Emitir G/D"
        Me.btn_reemitir.UseVisualStyleBackColor = False
        '
        'gp_reemitir
        '
        Me.gp_reemitir.Controls.Add(Me.btn_reemitir)
        Me.gp_reemitir.Location = New System.Drawing.Point(966, 497)
        Me.gp_reemitir.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_reemitir.Name = "gp_reemitir"
        Me.gp_reemitir.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_reemitir.Size = New System.Drawing.Size(123, 61)
        Me.gp_reemitir.TabIndex = 1260
        Me.gp_reemitir.TabStop = False
        Me.gp_reemitir.Text = "Volver a Emitir"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(855, 333)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 17)
        Me.Label15.TabIndex = 1262
        Me.Label15.Text = "E-MAIL:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(913, 332)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(181, 20)
        Me.txt_email.TabIndex = 1261
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1022, 560)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 17)
        Me.Label16.TabIndex = 1266
        Me.Label16.Text = "PRUEBA E-MAIL"
        '
        'txt_email2
        '
        Me.txt_email2.Location = New System.Drawing.Point(967, 588)
        Me.txt_email2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email2.Multiline = True
        Me.txt_email2.Name = "txt_email2"
        Me.txt_email2.Size = New System.Drawing.Size(216, 43)
        Me.txt_email2.TabIndex = 1265
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Lime
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(1007, 641)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 35)
        Me.Button6.TabIndex = 1264
        Me.Button6.Text = "Prueba E-mail"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'dgv_rutas
        '
        Me.dgv_rutas.AllowUserToAddRows = False
        Me.dgv_rutas.AllowUserToDeleteRows = False
        Me.dgv_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rutas.Location = New System.Drawing.Point(1131, 15)
        Me.dgv_rutas.Name = "dgv_rutas"
        Me.dgv_rutas.ReadOnly = True
        Me.dgv_rutas.RowHeadersVisible = False
        Me.dgv_rutas.Size = New System.Drawing.Size(10, 10)
        Me.dgv_rutas.TabIndex = 1267
        '
        'Frm_consulta_guia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1247, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_rutas)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_email2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.gp_reemitir)
        Me.Controls.Add(Me.gp_autorizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gp_relacionar)
        Me.Controls.Add(Me.gp_anular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fecha_ref)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fact_ref)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_total2)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_despachos)
        Me.Controls.Add(Me.dgv_despachos2)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_consulta_guia"
        Me.Text = "Guías de Despacho"
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_relacionar.ResumeLayout(False)
        Me.gp_relacionar.PerformLayout()
        Me.gp_autorizar.ResumeLayout(False)
        Me.gp_autorizar.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_anular.ResumeLayout(False)
        Me.gp_anular.PerformLayout()
        Me.gp_reemitir.ResumeLayout(False)
        CType(Me.dgv_rutas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pedido As System.Windows.Forms.TextBox
    Friend WithEvents gp_relacionar As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_informe1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_total2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fact_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_ref As System.Windows.Forms.TextBox
    Friend WithEvents gp_autorizar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_rechazar As System.Windows.Forms.Button
    Friend WithEvents txt_folio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_autorizar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gp_anular As System.Windows.Forms.GroupBox
    Friend WithEvents btn_reemitir As System.Windows.Forms.Button
    Friend WithEvents txt_guia2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pedido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gp_reemitir As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_email2 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Private WithEvents dgv_rutas As System.Windows.Forms.DataGridView
End Class
