<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consulta_nc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consulta_nc))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.DataGridView()
        Me.dgv_despachos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CachedCrystalReport11 = New Constructora_FV.CachedCrystalReport1()
        Me.txt_factura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pedido = New System.Windows.Forms.TextBox()
        Me.gp_relacionar = New System.Windows.Forms.GroupBox()
        Me.txt_nc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
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
        Me.gp_anular = New System.Windows.Forms.GroupBox()
        Me.txt_nc2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pedido2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_reemitir = New System.Windows.Forms.Button()
        Me.gp_autorizar = New System.Windows.Forms.GroupBox()
        Me.btn_rechazar = New System.Windows.Forms.Button()
        Me.txt_folio2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_autorizar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_relacionar.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_anular.SuspendLayout()
        Me.gp_autorizar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(516, 529)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(147, 38)
        Me.btn_salir.TabIndex = 1190
        Me.btn_salir.Text = "Cerrar Historico"
        Me.btn_salir.UseVisualStyleBackColor = False
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
        Me.dgv_despachos.Size = New System.Drawing.Size(711, 435)
        Me.dgv_despachos.TabIndex = 1210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(463, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(535, 49)
        Me.Label4.TabIndex = 1212
        Me.Label4.Text = "HISTORICO NOTAS DE CRÉDITO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1213
        Me.PictureBox1.TabStop = False
        '
        'txt_factura
        '
        Me.txt_factura.Location = New System.Drawing.Point(1033, 461)
        Me.txt_factura.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(49, 20)
        Me.txt_factura.TabIndex = 1219
        Me.txt_factura.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 1222
        Me.Label6.Text = "N° de Folio:"
        '
        'txt_pedido
        '
        Me.txt_pedido.Location = New System.Drawing.Point(90, 21)
        Me.txt_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pedido.Name = "txt_pedido"
        Me.txt_pedido.Size = New System.Drawing.Size(133, 20)
        Me.txt_pedido.TabIndex = 1223
        '
        'gp_relacionar
        '
        Me.gp_relacionar.Controls.Add(Me.txt_nc)
        Me.gp_relacionar.Controls.Add(Me.Label1)
        Me.gp_relacionar.Controls.Add(Me.txt_pedido)
        Me.gp_relacionar.Controls.Add(Me.Label6)
        Me.gp_relacionar.Controls.Add(Me.Button5)
        Me.gp_relacionar.Location = New System.Drawing.Point(764, 318)
        Me.gp_relacionar.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_relacionar.Name = "gp_relacionar"
        Me.gp_relacionar.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_relacionar.Size = New System.Drawing.Size(233, 112)
        Me.gp_relacionar.TabIndex = 1224
        Me.gp_relacionar.TabStop = False
        Me.gp_relacionar.Text = "Relacionar"
        '
        'txt_nc
        '
        Me.txt_nc.Location = New System.Drawing.Point(90, 44)
        Me.txt_nc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nc.Name = "txt_nc"
        Me.txt_nc.Size = New System.Drawing.Size(133, 20)
        Me.txt_nc.TabIndex = 1227
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1228
        Me.Label1.Text = "Nota de Crédito:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lime
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(31, 68)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 35)
        Me.Button5.TabIndex = 1226
        Me.Button5.Text = "Emitir N/C"
        Me.Button5.UseVisualStyleBackColor = False
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
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(1033, 484)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(49, 20)
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
        Me.dgv_clientes.Location = New System.Drawing.Point(1019, 28)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.Size = New System.Drawing.Size(8, 8)
        Me.dgv_clientes.TabIndex = 1240
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
        'gp_anular
        '
        Me.gp_anular.Controls.Add(Me.txt_nc2)
        Me.gp_anular.Controls.Add(Me.Label2)
        Me.gp_anular.Controls.Add(Me.txt_pedido2)
        Me.gp_anular.Controls.Add(Me.Label3)
        Me.gp_anular.Controls.Add(Me.Button3)
        Me.gp_anular.Location = New System.Drawing.Point(762, 444)
        Me.gp_anular.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_anular.Name = "gp_anular"
        Me.gp_anular.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_anular.Size = New System.Drawing.Size(205, 112)
        Me.gp_anular.TabIndex = 1251
        Me.gp_anular.TabStop = False
        Me.gp_anular.Text = "Anular o Cambiar Folio"
        '
        'txt_nc2
        '
        Me.txt_nc2.Location = New System.Drawing.Point(90, 44)
        Me.txt_nc2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nc2.Name = "txt_nc2"
        Me.txt_nc2.Size = New System.Drawing.Size(102, 20)
        Me.txt_nc2.TabIndex = 1227
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1228
        Me.Label2.Text = "Nota de Crédito:"
        '
        'txt_pedido2
        '
        Me.txt_pedido2.Location = New System.Drawing.Point(90, 21)
        Me.txt_pedido2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pedido2.Name = "txt_pedido2"
        Me.txt_pedido2.Size = New System.Drawing.Size(102, 20)
        Me.txt_pedido2.TabIndex = 1223
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 1222
        Me.Label3.Text = "N° de Folio:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Turquoise
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(33, 71)
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
        Me.btn_reemitir.Size = New System.Drawing.Size(105, 35)
        Me.btn_reemitir.TabIndex = 1229
        Me.btn_reemitir.Text = "Volver a Emitir N/C"
        Me.btn_reemitir.UseVisualStyleBackColor = False
        '
        'gp_autorizar
        '
        Me.gp_autorizar.Controls.Add(Me.btn_rechazar)
        Me.gp_autorizar.Controls.Add(Me.txt_folio2)
        Me.gp_autorizar.Controls.Add(Me.Label8)
        Me.gp_autorizar.Controls.Add(Me.btn_autorizar)
        Me.gp_autorizar.Location = New System.Drawing.Point(749, 314)
        Me.gp_autorizar.Margin = New System.Windows.Forms.Padding(2)
        Me.gp_autorizar.Name = "gp_autorizar"
        Me.gp_autorizar.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_autorizar.Size = New System.Drawing.Size(267, 116)
        Me.gp_autorizar.TabIndex = 1252
        Me.gp_autorizar.TabStop = False
        Me.gp_autorizar.Text = "Autorizar"
        '
        'btn_rechazar
        '
        Me.btn_rechazar.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_rechazar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_rechazar.Location = New System.Drawing.Point(143, 54)
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
        Me.btn_autorizar.Location = New System.Drawing.Point(13, 54)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(33, 526)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 1255
        Me.Button1.Text = "ACTUALIZAR TABLA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_reemitir)
        Me.GroupBox1.Location = New System.Drawing.Point(1029, 358)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(113, 72)
        Me.GroupBox1.TabIndex = 1256
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Volver a Emitir"
        '
        'Frm_consulta_nc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.gp_anular)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_total2)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_factura)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_despachos)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.gp_autorizar)
        Me.Controls.Add(Me.gp_relacionar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_consulta_nc"
        Me.Text = "Notas de Crédito"
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_relacionar.ResumeLayout(False)
        Me.gp_relacionar.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_anular.ResumeLayout(False)
        Me.gp_anular.PerformLayout()
        Me.gp_autorizar.ResumeLayout(False)
        Me.gp_autorizar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Private WithEvents btn_actualizar As System.Windows.Forms.DataGridView
    Private WithEvents dgv_despachos As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CachedCrystalReport11 As Constructora_FV.CachedCrystalReport1
    Friend WithEvents txt_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pedido As System.Windows.Forms.TextBox
    Friend WithEvents gp_relacionar As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_nc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_total2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents gp_anular As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_pedido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents gp_autorizar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_rechazar As System.Windows.Forms.Button
    Friend WithEvents txt_folio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_autorizar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents btn_reemitir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
