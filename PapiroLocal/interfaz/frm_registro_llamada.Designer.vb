<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_llamada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro_llamada))
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_atendio = New System.Windows.Forms.TextBox()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.txt_inicio = New System.Windows.Forms.TextBox()
        Me.txt_final = New System.Windows.Forms.TextBox()
        Me.txt_duracion = New System.Windows.Forms.TextBox()
        Me.cmb_telefono = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_llamada = New System.Windows.Forms.ComboBox()
        Me.txt_informe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_linea = New System.Windows.Forms.ComboBox()
        Me.cmb_importancia = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_cobranza = New System.Windows.Forms.TextBox()
        Me.chk_tel = New System.Windows.Forms.CheckBox()
        Me.chk_what = New System.Windows.Forms.CheckBox()
        Me.chk_email = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_fecha_prog = New System.Windows.Forms.DateTimePicker()
        Me.lbl_programacion = New System.Windows.Forms.Label()
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_telefonos_pago = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_contacto_pago = New System.Windows.Forms.TextBox()
        Me.btn_retiro = New System.Windows.Forms.Button()
        Me.txt_direccion_despacho = New System.Windows.Forms.TextBox()
        Me.txt_comuna_despacho = New System.Windows.Forms.TextBox()
        Me.txt_direccion_facturacion = New System.Windows.Forms.TextBox()
        Me.txt_comuna_facturacion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_email_pago = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cargo_pago = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(29, 80)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(478, 22)
        Me.txt_cliente.TabIndex = 0
        '
        'txt_atendio
        '
        Me.txt_atendio.Location = New System.Drawing.Point(29, 255)
        Me.txt_atendio.Name = "txt_atendio"
        Me.txt_atendio.Size = New System.Drawing.Size(478, 22)
        Me.txt_atendio.TabIndex = 1
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(573, 255)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(469, 22)
        Me.txt_motivo.TabIndex = 2
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(573, 319)
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.Size = New System.Drawing.Size(206, 22)
        Me.txt_inicio.TabIndex = 5
        '
        'txt_final
        '
        Me.txt_final.Location = New System.Drawing.Point(832, 319)
        Me.txt_final.Name = "txt_final"
        Me.txt_final.Size = New System.Drawing.Size(210, 22)
        Me.txt_final.TabIndex = 6
        '
        'txt_duracion
        '
        Me.txt_duracion.Location = New System.Drawing.Point(25, 380)
        Me.txt_duracion.Name = "txt_duracion"
        Me.txt_duracion.Size = New System.Drawing.Size(135, 22)
        Me.txt_duracion.TabIndex = 7
        '
        'cmb_telefono
        '
        Me.cmb_telefono.FormattingEnabled = True
        Me.cmb_telefono.Location = New System.Drawing.Point(25, 319)
        Me.cmb_telefono.Name = "cmb_telefono"
        Me.cmb_telefono.Size = New System.Drawing.Size(209, 24)
        Me.cmb_telefono.TabIndex = 3
        '
        'cmb_tipo_llamada
        '
        Me.cmb_tipo_llamada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_llamada.FormattingEnabled = True
        Me.cmb_tipo_llamada.Items.AddRange(New Object() {"Venta", "Precios", "Post Venta", "Nuevos productos", "Información", "Cotización", "Cobranza", "Otros"})
        Me.cmb_tipo_llamada.Location = New System.Drawing.Point(289, 319)
        Me.cmb_tipo_llamada.Name = "cmb_tipo_llamada"
        Me.cmb_tipo_llamada.Size = New System.Drawing.Size(261, 24)
        Me.cmb_tipo_llamada.TabIndex = 4
        '
        'txt_informe
        '
        Me.txt_informe.Location = New System.Drawing.Point(25, 452)
        Me.txt_informe.Multiline = True
        Me.txt_informe.Name = "txt_informe"
        Me.txt_informe.Size = New System.Drawing.Size(1078, 194)
        Me.txt_informe.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Atendió"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(573, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Motivo de la Llamada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(292, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tipo de Llamada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(573, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Llamada Iniciada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(857, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Llamada Finalizada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Duración"
        '
        'cmb_linea
        '
        Me.cmb_linea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_linea.FormattingEnabled = True
        Me.cmb_linea.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.cmb_linea.Location = New System.Drawing.Point(166, 380)
        Me.cmb_linea.Name = "cmb_linea"
        Me.cmb_linea.Size = New System.Drawing.Size(192, 24)
        Me.cmb_linea.TabIndex = 8
        '
        'cmb_importancia
        '
        Me.cmb_importancia.FormattingEnabled = True
        Me.cmb_importancia.Location = New System.Drawing.Point(364, 380)
        Me.cmb_importancia.Name = "cmb_importancia"
        Me.cmb_importancia.Size = New System.Drawing.Size(186, 24)
        Me.cmb_importancia.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Entrada\Salida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(364, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Seguimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 429)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Informe"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(303, 667)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(130, 32)
        Me.btn_aceptar.TabIndex = 11
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(453, 667)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(130, 32)
        Me.btn_cancelar.TabIndex = 12
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(513, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(237, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 30)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(785, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 30)
        Me.Button3.TabIndex = 26
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1048, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 30)
        Me.Button4.TabIndex = 27
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(374, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Fecha"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(440, 9)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(111, 22)
        Me.txt_fecha.TabIndex = 29
        '
        'Timer2
        '
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Aqua
        Me.Button5.Location = New System.Drawing.Point(618, 654)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 45)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Historial Llamadas"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(95, 9)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 22)
        Me.txt_usuario.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Usuario:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(201, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 20)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Tipo:"
        '
        'txt_cobranza
        '
        Me.txt_cobranza.Location = New System.Drawing.Point(250, 9)
        Me.txt_cobranza.Name = "txt_cobranza"
        Me.txt_cobranza.Size = New System.Drawing.Size(118, 22)
        Me.txt_cobranza.TabIndex = 34
        '
        'chk_tel
        '
        Me.chk_tel.AutoSize = True
        Me.chk_tel.Location = New System.Drawing.Point(573, 365)
        Me.chk_tel.Name = "chk_tel"
        Me.chk_tel.Size = New System.Drawing.Size(18, 17)
        Me.chk_tel.TabIndex = 35
        Me.chk_tel.UseVisualStyleBackColor = True
        '
        'chk_what
        '
        Me.chk_what.AutoSize = True
        Me.chk_what.Location = New System.Drawing.Point(785, 365)
        Me.chk_what.Name = "chk_what"
        Me.chk_what.Size = New System.Drawing.Size(18, 17)
        Me.chk_what.TabIndex = 36
        Me.chk_what.UseVisualStyleBackColor = True
        '
        'chk_email
        '
        Me.chk_email.AutoSize = True
        Me.chk_email.Location = New System.Drawing.Point(679, 365)
        Me.chk_email.Name = "chk_email"
        Me.chk_email.Size = New System.Drawing.Size(18, 17)
        Me.chk_email.TabIndex = 37
        Me.chk_email.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(593, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(703, 365)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(809, 365)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'txt_fecha_prog
        '
        Me.txt_fecha_prog.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_prog.Location = New System.Drawing.Point(894, 386)
        Me.txt_fecha_prog.Name = "txt_fecha_prog"
        Me.txt_fecha_prog.Size = New System.Drawing.Size(108, 22)
        Me.txt_fecha_prog.TabIndex = 41
        '
        'lbl_programacion
        '
        Me.lbl_programacion.AutoSize = True
        Me.lbl_programacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_programacion.Location = New System.Drawing.Point(890, 363)
        Me.lbl_programacion.Name = "lbl_programacion"
        Me.lbl_programacion.Size = New System.Drawing.Size(182, 20)
        Me.lbl_programacion.TabIndex = 42
        Me.lbl_programacion.Text = "Fecha Programación"
        '
        'cmb_dia
        '
        Me.cmb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmb_dia.Location = New System.Drawing.Point(1004, 385)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(72, 24)
        Me.cmb_dia.TabIndex = 43
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(250, 36)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(118, 22)
        Me.txt_folio.TabIndex = 44
        Me.txt_folio.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(573, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 20)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Rut"
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(573, 80)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(469, 22)
        Me.txt_rut.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 175)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(331, 20)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Telefonos Contacto Pago Proveedores"
        '
        'txt_telefonos_pago
        '
        Me.txt_telefonos_pago.Location = New System.Drawing.Point(29, 198)
        Me.txt_telefonos_pago.Name = "txt_telefonos_pago"
        Me.txt_telefonos_pago.Size = New System.Drawing.Size(469, 22)
        Me.txt_telefonos_pago.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(29, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(243, 20)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Contacto Pago Proveedores"
        '
        'txt_contacto_pago
        '
        Me.txt_contacto_pago.Location = New System.Drawing.Point(29, 140)
        Me.txt_contacto_pago.Name = "txt_contacto_pago"
        Me.txt_contacto_pago.Size = New System.Drawing.Size(478, 22)
        Me.txt_contacto_pago.TabIndex = 49
        '
        'btn_retiro
        '
        Me.btn_retiro.BackColor = System.Drawing.Color.Aqua
        Me.btn_retiro.Location = New System.Drawing.Point(29, 654)
        Me.btn_retiro.Name = "btn_retiro"
        Me.btn_retiro.Size = New System.Drawing.Size(134, 45)
        Me.btn_retiro.TabIndex = 51
        Me.btn_retiro.Text = "Retiro Documento"
        Me.btn_retiro.UseVisualStyleBackColor = False
        '
        'txt_direccion_despacho
        '
        Me.txt_direccion_despacho.Location = New System.Drawing.Point(780, 7)
        Me.txt_direccion_despacho.Name = "txt_direccion_despacho"
        Me.txt_direccion_despacho.Size = New System.Drawing.Size(10, 22)
        Me.txt_direccion_despacho.TabIndex = 52
        Me.txt_direccion_despacho.Visible = False
        '
        'txt_comuna_despacho
        '
        Me.txt_comuna_despacho.Location = New System.Drawing.Point(812, 7)
        Me.txt_comuna_despacho.Name = "txt_comuna_despacho"
        Me.txt_comuna_despacho.Size = New System.Drawing.Size(10, 22)
        Me.txt_comuna_despacho.TabIndex = 53
        Me.txt_comuna_despacho.Visible = False
        '
        'txt_direccion_facturacion
        '
        Me.txt_direccion_facturacion.Location = New System.Drawing.Point(764, 7)
        Me.txt_direccion_facturacion.Name = "txt_direccion_facturacion"
        Me.txt_direccion_facturacion.Size = New System.Drawing.Size(10, 22)
        Me.txt_direccion_facturacion.TabIndex = 54
        Me.txt_direccion_facturacion.Visible = False
        '
        'txt_comuna_facturacion
        '
        Me.txt_comuna_facturacion.Location = New System.Drawing.Point(796, 7)
        Me.txt_comuna_facturacion.Name = "txt_comuna_facturacion"
        Me.txt_comuna_facturacion.Size = New System.Drawing.Size(10, 22)
        Me.txt_comuna_facturacion.TabIndex = 55
        Me.txt_comuna_facturacion.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(573, 175)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(296, 20)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Email Contacto Pago Proveedores"
        '
        'txt_email_pago
        '
        Me.txt_email_pago.Location = New System.Drawing.Point(573, 198)
        Me.txt_email_pago.Name = "txt_email_pago"
        Me.txt_email_pago.Size = New System.Drawing.Size(478, 22)
        Me.txt_email_pago.TabIndex = 56
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(569, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(299, 20)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Cargo Contacto Pago Proveedores"
        '
        'txt_cargo_pago
        '
        Me.txt_cargo_pago.Location = New System.Drawing.Point(569, 140)
        Me.txt_cargo_pago.Name = "txt_cargo_pago"
        Me.txt_cargo_pago.Size = New System.Drawing.Size(478, 22)
        Me.txt_cargo_pago.TabIndex = 58
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(894, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(148, 46)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Guardar Modificaciones"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'frm_registro_llamada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1152, 731)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_cargo_pago)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_email_pago)
        Me.Controls.Add(Me.txt_comuna_facturacion)
        Me.Controls.Add(Me.txt_direccion_facturacion)
        Me.Controls.Add(Me.txt_comuna_despacho)
        Me.Controls.Add(Me.txt_direccion_despacho)
        Me.Controls.Add(Me.btn_retiro)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_contacto_pago)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_telefonos_pago)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.cmb_dia)
        Me.Controls.Add(Me.lbl_programacion)
        Me.Controls.Add(Me.txt_fecha_prog)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chk_email)
        Me.Controls.Add(Me.chk_what)
        Me.Controls.Add(Me.chk_tel)
        Me.Controls.Add(Me.txt_cobranza)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_importancia)
        Me.Controls.Add(Me.cmb_linea)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_informe)
        Me.Controls.Add(Me.cmb_tipo_llamada)
        Me.Controls.Add(Me.cmb_telefono)
        Me.Controls.Add(Me.txt_duracion)
        Me.Controls.Add(Me.txt_final)
        Me.Controls.Add(Me.txt_inicio)
        Me.Controls.Add(Me.txt_motivo)
        Me.Controls.Add(Me.txt_atendio)
        Me.Controls.Add(Me.txt_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_registro_llamada"
        Me.Text = "Registrar Nueva Llamada"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_atendio As System.Windows.Forms.TextBox
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_inicio As System.Windows.Forms.TextBox
    Friend WithEvents txt_final As System.Windows.Forms.TextBox
    Friend WithEvents txt_duracion As System.Windows.Forms.TextBox
    Friend WithEvents cmb_telefono As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipo_llamada As System.Windows.Forms.ComboBox
    Friend WithEvents txt_informe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_linea As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_importancia As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_cobranza As System.Windows.Forms.TextBox
    Friend WithEvents chk_tel As System.Windows.Forms.CheckBox
    Friend WithEvents chk_what As System.Windows.Forms.CheckBox
    Friend WithEvents chk_email As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_fecha_prog As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_programacion As System.Windows.Forms.Label
    Friend WithEvents cmb_dia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_telefonos_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_contacto_pago As System.Windows.Forms.TextBox
    Friend WithEvents btn_retiro As System.Windows.Forms.Button
    Friend WithEvents txt_direccion_despacho As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna_despacho As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_facturacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna_facturacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_email_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_cargo_pago As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
