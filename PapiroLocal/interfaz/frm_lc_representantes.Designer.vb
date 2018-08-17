<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lc_representates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lc_representates))
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comuna = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cargo_com = New System.Windows.Forms.TextBox()
        Me.txt_nombre_com = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_telefonos_com = New System.Windows.Forms.TextBox()
        Me.txt_email_com = New System.Windows.Forms.TextBox()
        Me.txt_senal_advertencia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_dicom = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_forma_de_pago = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_linea_credito = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_email_desp = New System.Windows.Forms.TextBox()
        Me.txt_telefonos_desp = New System.Windows.Forms.TextBox()
        Me.txt_nombre_desp = New System.Windows.Forms.TextBox()
        Me.txt_direccion_desp = New System.Windows.Forms.TextBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.txt_email_fact = New System.Windows.Forms.TextBox()
        Me.txt_telefonos_fact = New System.Windows.Forms.TextBox()
        Me.txt_nombre_fact = New System.Windows.Forms.TextBox()
        Me.txt_cargo_fact = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(867, 260)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 1108
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'txt_rut
        '
        Me.txt_rut.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_rut.Location = New System.Drawing.Point(146, 75)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rut.MaxLength = 40
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(295, 22)
        Me.txt_rut.TabIndex = 1106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "RUT EMPRESA:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(956, 261)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 1105
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'dgv_curso
        '
        Me.dgv_curso.AllowUserToAddRows = False
        Me.dgv_curso.AllowUserToDeleteRows = False
        Me.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso.Location = New System.Drawing.Point(-3, 260)
        Me.dgv_curso.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(862, 315)
        Me.dgv_curso.TabIndex = 1104
        '
        'txt_razon_social
        '
        Me.txt_razon_social.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_razon_social.Location = New System.Drawing.Point(146, 104)
        Me.txt_razon_social.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_razon_social.MaxLength = 40
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(295, 22)
        Me.txt_razon_social.TabIndex = 1118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 1119
        Me.Label1.Text = "RAZÓN SOCIAL:"
        '
        'txt_telefono
        '
        Me.txt_telefono.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_telefono.Location = New System.Drawing.Point(146, 214)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefono.MaxLength = 40
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(295, 22)
        Me.txt_telefono.TabIndex = 1120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 1121
        Me.Label3.Text = "COMUNA:"
        '
        'txt_direccion
        '
        Me.txt_direccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_direccion.Location = New System.Drawing.Point(146, 134)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion.MaxLength = 40
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(295, 42)
        Me.txt_direccion.TabIndex = 1122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 1123
        Me.Label4.Text = "DIRECCIÓN:"
        '
        'txt_comuna
        '
        Me.txt_comuna.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_comuna.Location = New System.Drawing.Point(146, 184)
        Me.txt_comuna.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comuna.MaxLength = 40
        Me.txt_comuna.Name = "txt_comuna"
        Me.txt_comuna.Size = New System.Drawing.Size(295, 22)
        Me.txt_comuna.TabIndex = 1124
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 216)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 1125
        Me.Label5.Text = "TELÉFONO:"
        '
        'txt_cargo_com
        '
        Me.txt_cargo_com.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cargo_com.Location = New System.Drawing.Point(1327, 211)
        Me.txt_cargo_com.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cargo_com.MaxLength = 40
        Me.txt_cargo_com.Name = "txt_cargo_com"
        Me.txt_cargo_com.Size = New System.Drawing.Size(10, 22)
        Me.txt_cargo_com.TabIndex = 1126
        Me.txt_cargo_com.Visible = False
        '
        'txt_nombre_com
        '
        Me.txt_nombre_com.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_nombre_com.Location = New System.Drawing.Point(1327, 181)
        Me.txt_nombre_com.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_com.MaxLength = 40
        Me.txt_nombre_com.Name = "txt_nombre_com"
        Me.txt_nombre_com.Size = New System.Drawing.Size(10, 22)
        Me.txt_nombre_com.TabIndex = 1128
        Me.txt_nombre_com.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(329, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(354, 39)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "LÍNEA DE CRÉDITO"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(867, 332)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 1133
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'txt_telefonos_com
        '
        Me.txt_telefonos_com.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_telefonos_com.Location = New System.Drawing.Point(1327, 241)
        Me.txt_telefonos_com.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefonos_com.MaxLength = 40
        Me.txt_telefonos_com.Name = "txt_telefonos_com"
        Me.txt_telefonos_com.Size = New System.Drawing.Size(10, 22)
        Me.txt_telefonos_com.TabIndex = 1136
        Me.txt_telefonos_com.Visible = False
        '
        'txt_email_com
        '
        Me.txt_email_com.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_email_com.Location = New System.Drawing.Point(1327, 271)
        Me.txt_email_com.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email_com.MaxLength = 40
        Me.txt_email_com.Name = "txt_email_com"
        Me.txt_email_com.Size = New System.Drawing.Size(10, 22)
        Me.txt_email_com.TabIndex = 1138
        Me.txt_email_com.Visible = False
        '
        'txt_senal_advertencia
        '
        Me.txt_senal_advertencia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_senal_advertencia.Location = New System.Drawing.Point(656, 178)
        Me.txt_senal_advertencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senal_advertencia.MaxLength = 40
        Me.txt_senal_advertencia.Name = "txt_senal_advertencia"
        Me.txt_senal_advertencia.Size = New System.Drawing.Size(213, 22)
        Me.txt_senal_advertencia.TabIndex = 1147
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(468, 183)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(175, 17)
        Me.Label14.TabIndex = 1148
        Me.Label14.Text = "SEÑAL ADVERTENCIA:"
        '
        'txt_dicom
        '
        Me.txt_dicom.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_dicom.Location = New System.Drawing.Point(656, 148)
        Me.txt_dicom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_dicom.MaxLength = 40
        Me.txt_dicom.Name = "txt_dicom"
        Me.txt_dicom.Size = New System.Drawing.Size(213, 22)
        Me.txt_dicom.TabIndex = 1145
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(469, 153)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 17)
        Me.Label15.TabIndex = 1146
        Me.Label15.Text = "DICOM:"
        '
        'txt_forma_de_pago
        '
        Me.txt_forma_de_pago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_forma_de_pago.Location = New System.Drawing.Point(656, 88)
        Me.txt_forma_de_pago.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_forma_de_pago.MaxLength = 40
        Me.txt_forma_de_pago.Name = "txt_forma_de_pago"
        Me.txt_forma_de_pago.Size = New System.Drawing.Size(213, 22)
        Me.txt_forma_de_pago.TabIndex = 1143
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(468, 93)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(142, 17)
        Me.Label16.TabIndex = 1144
        Me.Label16.Text = "FORMA DE PAGO:"
        '
        'txt_linea_credito
        '
        Me.txt_linea_credito.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_linea_credito.Location = New System.Drawing.Point(656, 118)
        Me.txt_linea_credito.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_linea_credito.MaxLength = 40
        Me.txt_linea_credito.Name = "txt_linea_credito"
        Me.txt_linea_credito.Size = New System.Drawing.Size(213, 22)
        Me.txt_linea_credito.TabIndex = 1141
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(469, 123)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 17)
        Me.Label17.TabIndex = 1142
        Me.Label17.Text = "LÍNEA DE CRÉDITO:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(571, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 17)
        Me.Label18.TabIndex = 1149
        Me.Label18.Text = "CONDICIONES DE PAGO"
        '
        'txt_email_desp
        '
        Me.txt_email_desp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_email_desp.Location = New System.Drawing.Point(1345, 241)
        Me.txt_email_desp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email_desp.MaxLength = 40
        Me.txt_email_desp.Name = "txt_email_desp"
        Me.txt_email_desp.Size = New System.Drawing.Size(10, 22)
        Me.txt_email_desp.TabIndex = 1157
        Me.txt_email_desp.Visible = False
        '
        'txt_telefonos_desp
        '
        Me.txt_telefonos_desp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_telefonos_desp.Location = New System.Drawing.Point(1345, 211)
        Me.txt_telefonos_desp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefonos_desp.MaxLength = 40
        Me.txt_telefonos_desp.Name = "txt_telefonos_desp"
        Me.txt_telefonos_desp.Size = New System.Drawing.Size(10, 22)
        Me.txt_telefonos_desp.TabIndex = 1155
        Me.txt_telefonos_desp.Visible = False
        '
        'txt_nombre_desp
        '
        Me.txt_nombre_desp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_nombre_desp.Location = New System.Drawing.Point(1345, 181)
        Me.txt_nombre_desp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_desp.MaxLength = 40
        Me.txt_nombre_desp.Name = "txt_nombre_desp"
        Me.txt_nombre_desp.Size = New System.Drawing.Size(10, 22)
        Me.txt_nombre_desp.TabIndex = 1153
        Me.txt_nombre_desp.Visible = False
        '
        'txt_direccion_desp
        '
        Me.txt_direccion_desp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_direccion_desp.Location = New System.Drawing.Point(1345, 271)
        Me.txt_direccion_desp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion_desp.MaxLength = 40
        Me.txt_direccion_desp.Multiline = True
        Me.txt_direccion_desp.Name = "txt_direccion_desp"
        Me.txt_direccion_desp.Size = New System.Drawing.Size(10, 25)
        Me.txt_direccion_desp.TabIndex = 1151
        Me.txt_direccion_desp.Visible = False
        '
        'txt_observacion
        '
        Me.txt_observacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_observacion.Location = New System.Drawing.Point(1309, 180)
        Me.txt_observacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_observacion.MaxLength = 40
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(10, 23)
        Me.txt_observacion.TabIndex = 1160
        Me.txt_observacion.Visible = False
        '
        'txt_email_fact
        '
        Me.txt_email_fact.AcceptsReturn = True
        Me.txt_email_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_email_fact.Location = New System.Drawing.Point(1309, 305)
        Me.txt_email_fact.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email_fact.MaxLength = 40
        Me.txt_email_fact.Name = "txt_email_fact"
        Me.txt_email_fact.Size = New System.Drawing.Size(10, 22)
        Me.txt_email_fact.TabIndex = 1167
        Me.txt_email_fact.Visible = False
        '
        'txt_telefonos_fact
        '
        Me.txt_telefonos_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_telefonos_fact.Location = New System.Drawing.Point(1309, 275)
        Me.txt_telefonos_fact.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefonos_fact.MaxLength = 40
        Me.txt_telefonos_fact.Name = "txt_telefonos_fact"
        Me.txt_telefonos_fact.Size = New System.Drawing.Size(10, 22)
        Me.txt_telefonos_fact.TabIndex = 1165
        Me.txt_telefonos_fact.Visible = False
        '
        'txt_nombre_fact
        '
        Me.txt_nombre_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_nombre_fact.Location = New System.Drawing.Point(1309, 215)
        Me.txt_nombre_fact.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_fact.MaxLength = 40
        Me.txt_nombre_fact.Name = "txt_nombre_fact"
        Me.txt_nombre_fact.Size = New System.Drawing.Size(10, 22)
        Me.txt_nombre_fact.TabIndex = 1163
        Me.txt_nombre_fact.Visible = False
        '
        'txt_cargo_fact
        '
        Me.txt_cargo_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cargo_fact.Location = New System.Drawing.Point(1309, 245)
        Me.txt_cargo_fact.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cargo_fact.MaxLength = 40
        Me.txt_cargo_fact.Name = "txt_cargo_fact"
        Me.txt_cargo_fact.Size = New System.Drawing.Size(10, 22)
        Me.txt_cargo_fact.TabIndex = 1161
        Me.txt_cargo_fact.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1169
        Me.PictureBox1.TabStop = False
        '
        'frm_lc_representates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_email_fact)
        Me.Controls.Add(Me.txt_telefonos_fact)
        Me.Controls.Add(Me.txt_nombre_fact)
        Me.Controls.Add(Me.txt_cargo_fact)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.txt_email_desp)
        Me.Controls.Add(Me.txt_telefonos_desp)
        Me.Controls.Add(Me.txt_nombre_desp)
        Me.Controls.Add(Me.txt_direccion_desp)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_senal_advertencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_dicom)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_forma_de_pago)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_linea_credito)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_email_com)
        Me.Controls.Add(Me.txt_telefonos_com)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_nombre_com)
        Me.Controls.Add(Me.txt_cargo_com)
        Me.Controls.Add(Me.txt_comuna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_lc_representates"
        Me.Text = "Representantes"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cargo_com As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_com As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_telefonos_com As System.Windows.Forms.TextBox
    Friend WithEvents txt_email_com As System.Windows.Forms.TextBox
    Friend WithEvents txt_senal_advertencia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_dicom As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_forma_de_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_linea_credito As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_email_desp As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefonos_desp As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_desp As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_desp As System.Windows.Forms.TextBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_email_fact As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefonos_fact As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_fact As System.Windows.Forms.TextBox
    Friend WithEvents txt_cargo_fact As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
