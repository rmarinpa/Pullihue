<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_autorizar_nc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_venta2 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Venta = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbtn_cliente3 = New System.Windows.Forms.RadioButton()
        Me.rdbtn_cliente2 = New System.Windows.Forms.RadioButton()
        Me.rdbtn_cliente1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_obs_venta = New System.Windows.Forms.TextBox()
        Me.Logistica = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.material_no = New System.Windows.Forms.RadioButton()
        Me.material_si = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bodega_no = New System.Windows.Forms.RadioButton()
        Me.bodega_si = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_obs_log = New System.Windows.Forms.TextBox()
        Me.Servicio_Tecnico = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_contacto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inventario_no = New System.Windows.Forms.RadioButton()
        Me.inventario_si = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_obs_serv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.txt_usuario2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_usuario1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv_venta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Venta.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Logistica.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Servicio_Tecnico.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTORIZA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_venta2
        '
        Me.dgv_venta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_venta2.Location = New System.Drawing.Point(33, 41)
        Me.dgv_venta2.Name = "dgv_venta2"
        Me.dgv_venta2.RowTemplate.Height = 24
        Me.dgv_venta2.Size = New System.Drawing.Size(1147, 343)
        Me.dgv_venta2.TabIndex = 49
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Venta)
        Me.TabControl1.Controls.Add(Me.Logistica)
        Me.TabControl1.Controls.Add(Me.Servicio_Tecnico)
        Me.TabControl1.Location = New System.Drawing.Point(33, 414)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1087, 351)
        Me.TabControl1.TabIndex = 72
        '
        'Venta
        '
        Me.Venta.Controls.Add(Me.Label10)
        Me.Venta.Controls.Add(Me.txt_usuario)
        Me.Venta.Controls.Add(Me.GroupBox4)
        Me.Venta.Controls.Add(Me.Label3)
        Me.Venta.Controls.Add(Me.txt_obs_venta)
        Me.Venta.Location = New System.Drawing.Point(4, 25)
        Me.Venta.Name = "Venta"
        Me.Venta.Padding = New System.Windows.Forms.Padding(3)
        Me.Venta.Size = New System.Drawing.Size(1079, 322)
        Me.Venta.TabIndex = 0
        Me.Venta.Text = "Venta"
        Me.Venta.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdbtn_cliente3)
        Me.GroupBox4.Controls.Add(Me.rdbtn_cliente2)
        Me.GroupBox4.Controls.Add(Me.rdbtn_cliente1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(287, 31)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 144)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consulta Venta"
        '
        'rdbtn_cliente3
        '
        Me.rdbtn_cliente3.AutoSize = True
        Me.rdbtn_cliente3.Location = New System.Drawing.Point(10, 85)
        Me.rdbtn_cliente3.Name = "rdbtn_cliente3"
        Me.rdbtn_cliente3.Size = New System.Drawing.Size(163, 21)
        Me.rdbtn_cliente3.TabIndex = 2
        Me.rdbtn_cliente3.TabStop = True
        Me.rdbtn_cliente3.Text = "Descuento Comercial"
        Me.rdbtn_cliente3.UseVisualStyleBackColor = True
        '
        'rdbtn_cliente2
        '
        Me.rdbtn_cliente2.AutoSize = True
        Me.rdbtn_cliente2.Location = New System.Drawing.Point(10, 58)
        Me.rdbtn_cliente2.Name = "rdbtn_cliente2"
        Me.rdbtn_cliente2.Size = New System.Drawing.Size(231, 21)
        Me.rdbtn_cliente2.TabIndex = 1
        Me.rdbtn_cliente2.TabStop = True
        Me.rdbtn_cliente2.Text = "Se generó mal la Nota de Venta"
        Me.rdbtn_cliente2.UseVisualStyleBackColor = True
        '
        'rdbtn_cliente1
        '
        Me.rdbtn_cliente1.AutoSize = True
        Me.rdbtn_cliente1.Location = New System.Drawing.Point(10, 31)
        Me.rdbtn_cliente1.Name = "rdbtn_cliente1"
        Me.rdbtn_cliente1.Size = New System.Drawing.Size(234, 21)
        Me.rdbtn_cliente1.TabIndex = 0
        Me.rdbtn_cliente1.TabStop = True
        Me.rdbtn_cliente1.Text = "Cliente se equivocó en el pedido"
        Me.rdbtn_cliente1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observación"
        '
        'txt_obs_venta
        '
        Me.txt_obs_venta.Location = New System.Drawing.Point(39, 178)
        Me.txt_obs_venta.Multiline = True
        Me.txt_obs_venta.Name = "txt_obs_venta"
        Me.txt_obs_venta.Size = New System.Drawing.Size(737, 138)
        Me.txt_obs_venta.TabIndex = 0
        '
        'Logistica
        '
        Me.Logistica.Controls.Add(Me.Label9)
        Me.Logistica.Controls.Add(Me.txt_usuario1)
        Me.Logistica.Controls.Add(Me.GroupBox3)
        Me.Logistica.Controls.Add(Me.GroupBox2)
        Me.Logistica.Controls.Add(Me.Label4)
        Me.Logistica.Controls.Add(Me.txt_obs_log)
        Me.Logistica.Location = New System.Drawing.Point(4, 25)
        Me.Logistica.Name = "Logistica"
        Me.Logistica.Padding = New System.Windows.Forms.Padding(3)
        Me.Logistica.Size = New System.Drawing.Size(1079, 322)
        Me.Logistica.TabIndex = 1
        Me.Logistica.Text = "Logística"
        Me.Logistica.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.material_no)
        Me.GroupBox3.Controls.Add(Me.material_si)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(468, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 126)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Material fue mal despachado"
        '
        'material_no
        '
        Me.material_no.AutoSize = True
        Me.material_no.Location = New System.Drawing.Point(21, 64)
        Me.material_no.Name = "material_no"
        Me.material_no.Size = New System.Drawing.Size(47, 21)
        Me.material_no.TabIndex = 1
        Me.material_no.TabStop = True
        Me.material_no.Text = "No"
        Me.material_no.UseVisualStyleBackColor = True
        '
        'material_si
        '
        Me.material_si.AutoSize = True
        Me.material_si.Location = New System.Drawing.Point(21, 36)
        Me.material_si.Name = "material_si"
        Me.material_si.Size = New System.Drawing.Size(41, 21)
        Me.material_si.TabIndex = 0
        Me.material_si.TabStop = True
        Me.material_si.Text = "Si"
        Me.material_si.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bodega_no)
        Me.GroupBox2.Controls.Add(Me.bodega_si)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(271, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 126)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material volvío a Bodega"
        '
        'bodega_no
        '
        Me.bodega_no.AutoSize = True
        Me.bodega_no.Location = New System.Drawing.Point(21, 64)
        Me.bodega_no.Name = "bodega_no"
        Me.bodega_no.Size = New System.Drawing.Size(47, 21)
        Me.bodega_no.TabIndex = 1
        Me.bodega_no.TabStop = True
        Me.bodega_no.Text = "No"
        Me.bodega_no.UseVisualStyleBackColor = True
        '
        'bodega_si
        '
        Me.bodega_si.AutoSize = True
        Me.bodega_si.Location = New System.Drawing.Point(21, 36)
        Me.bodega_si.Name = "bodega_si"
        Me.bodega_si.Size = New System.Drawing.Size(41, 21)
        Me.bodega_si.TabIndex = 0
        Me.bodega_si.TabStop = True
        Me.bodega_si.Text = "Si"
        Me.bodega_si.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Observación"
        '
        'txt_obs_log
        '
        Me.txt_obs_log.Location = New System.Drawing.Point(39, 166)
        Me.txt_obs_log.Multiline = True
        Me.txt_obs_log.Name = "txt_obs_log"
        Me.txt_obs_log.Size = New System.Drawing.Size(737, 149)
        Me.txt_obs_log.TabIndex = 3
        '
        'Servicio_Tecnico
        '
        Me.Servicio_Tecnico.Controls.Add(Me.Label8)
        Me.Servicio_Tecnico.Controls.Add(Me.GroupBox6)
        Me.Servicio_Tecnico.Controls.Add(Me.txt_usuario2)
        Me.Servicio_Tecnico.Controls.Add(Me.GroupBox1)
        Me.Servicio_Tecnico.Controls.Add(Me.Label2)
        Me.Servicio_Tecnico.Controls.Add(Me.txt_obs_serv)
        Me.Servicio_Tecnico.Location = New System.Drawing.Point(4, 25)
        Me.Servicio_Tecnico.Name = "Servicio_Tecnico"
        Me.Servicio_Tecnico.Padding = New System.Windows.Forms.Padding(3)
        Me.Servicio_Tecnico.Size = New System.Drawing.Size(1079, 322)
        Me.Servicio_Tecnico.TabIndex = 2
        Me.Servicio_Tecnico.Text = "Servicio Técnico"
        Me.Servicio_Tecnico.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txt_respuesta)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txt_contacto)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.dtp_fecha)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(236, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(540, 178)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Reclamo Proveedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 34)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Respuesta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(138, 79)
        Me.txt_respuesta.Multiline = True
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(396, 93)
        Me.txt_respuesta.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Contacto"
        '
        'txt_contacto
        '
        Me.txt_contacto.Location = New System.Drawing.Point(138, 51)
        Me.txt_contacto.Name = "txt_contacto"
        Me.txt_contacto.Size = New System.Drawing.Size(185, 22)
        Me.txt_contacto.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha Reclamo"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(138, 23)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(101, 22)
        Me.dtp_fecha.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inventario_no)
        Me.GroupBox1.Controls.Add(Me.inventario_si)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 81)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reingresa al Inventario"
        '
        'inventario_no
        '
        Me.inventario_no.AutoSize = True
        Me.inventario_no.Location = New System.Drawing.Point(16, 49)
        Me.inventario_no.Name = "inventario_no"
        Me.inventario_no.Size = New System.Drawing.Size(47, 21)
        Me.inventario_no.TabIndex = 1
        Me.inventario_no.TabStop = True
        Me.inventario_no.Text = "No"
        Me.inventario_no.UseVisualStyleBackColor = True
        '
        'inventario_si
        '
        Me.inventario_si.AutoSize = True
        Me.inventario_si.Location = New System.Drawing.Point(16, 21)
        Me.inventario_si.Name = "inventario_si"
        Me.inventario_si.Size = New System.Drawing.Size(41, 21)
        Me.inventario_si.TabIndex = 0
        Me.inventario_si.TabStop = True
        Me.inventario_si.Text = "Si"
        Me.inventario_si.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Observación"
        '
        'txt_obs_serv
        '
        Me.txt_obs_serv.Location = New System.Drawing.Point(39, 191)
        Me.txt_obs_serv.Multiline = True
        Me.txt_obs_serv.Name = "txt_obs_serv"
        Me.txt_obs_serv.Size = New System.Drawing.Size(737, 125)
        Me.txt_obs_serv.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(33, 767)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 55)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "GUARDAR AUTORIZACIÓN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(205, 13)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(138, 22)
        Me.txt_folio.TabIndex = 74
        Me.txt_folio.Visible = False
        '
        'txt_usuario2
        '
        Me.txt_usuario2.Location = New System.Drawing.Point(39, 29)
        Me.txt_usuario2.Name = "txt_usuario2"
        Me.txt_usuario2.Size = New System.Drawing.Size(153, 22)
        Me.txt_usuario2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "USUARIO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "USUARIO"
        '
        'txt_usuario1
        '
        Me.txt_usuario1.Location = New System.Drawing.Point(112, 15)
        Me.txt_usuario1.Name = "txt_usuario1"
        Me.txt_usuario1.Size = New System.Drawing.Size(153, 22)
        Me.txt_usuario1.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "USUARIO"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(113, 12)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(153, 22)
        Me.txt_usuario.TabIndex = 10
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(282, 390)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(482, 22)
        Me.txt_motivo.TabIndex = 75
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"PENDIENTE", "COMPLETADO"})
        Me.cmb_status.Location = New System.Drawing.Point(861, 390)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(180, 24)
        Me.cmb_status.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(786, 393)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "STATUS"
        '
        'Frm_autorizar_nc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 822)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.txt_motivo)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.dgv_venta2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_autorizar_nc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notas de Crédito Autorizadas"
        CType(Me.dgv_venta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Venta.ResumeLayout(False)
        Me.Venta.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Logistica.ResumeLayout(False)
        Me.Logistica.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Servicio_Tecnico.ResumeLayout(False)
        Me.Servicio_Tecnico.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_venta2 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Venta As System.Windows.Forms.TabPage
    Friend WithEvents Logistica As System.Windows.Forms.TabPage
    Friend WithEvents Servicio_Tecnico As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents inventario_no As System.Windows.Forms.RadioButton
    Friend WithEvents inventario_si As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_obs_serv As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_obs_venta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents material_no As System.Windows.Forms.RadioButton
    Friend WithEvents material_si As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bodega_no As System.Windows.Forms.RadioButton
    Friend WithEvents bodega_si As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_obs_log As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtn_cliente3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_cliente2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_cliente1 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_respuesta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_contacto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
