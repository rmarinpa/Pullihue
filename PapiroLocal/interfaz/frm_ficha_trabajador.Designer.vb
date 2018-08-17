<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ficha_trabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ficha_trabajador))
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_lugar_nacimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.txt_estado_civil = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_telefonos = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.txt_cargo = New System.Windows.Forms.TextBox()
        Me.txt_salud = New System.Windows.Forms.TextBox()
        Me.txt_profesion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_afp = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_faena_actual = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_tipo_contrato = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_situacion_habitacional = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_nivel_escolaridad = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_cargas = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_integrantes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(323, 833)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 23
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'txt_nombres
        '
        Me.txt_nombres.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_nombres.Location = New System.Drawing.Point(296, 116)
        Me.txt_nombres.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombres.MaxLength = 100
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(417, 22)
        Me.txt_nombres.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "Nombres:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(55, 833)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 20
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dgv_curso
        '
        Me.dgv_curso.AllowUserToAddRows = False
        Me.dgv_curso.AllowUserToDeleteRows = False
        Me.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso.Location = New System.Drawing.Point(733, 116)
        Me.dgv_curso.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(468, 537)
        Me.dgv_curso.TabIndex = 1104
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(234, 833)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 22
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_apellidos
        '
        Me.txt_apellidos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_apellidos.Location = New System.Drawing.Point(296, 145)
        Me.txt_apellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_apellidos.MaxLength = 100
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(417, 22)
        Me.txt_apellidos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1119
        Me.Label1.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 1121
        Me.Label3.Text = "Rut:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 17)
        Me.Label4.TabIndex = 1123
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'txt_lugar_nacimiento
        '
        Me.txt_lugar_nacimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_lugar_nacimiento.Location = New System.Drawing.Point(296, 241)
        Me.txt_lugar_nacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_lugar_nacimiento.MaxLength = 100
        Me.txt_lugar_nacimiento.Name = "txt_lugar_nacimiento"
        Me.txt_lugar_nacimiento.Size = New System.Drawing.Size(417, 22)
        Me.txt_lugar_nacimiento.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 241)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 17)
        Me.Label5.TabIndex = 1125
        Me.Label5.Text = "Lugar de Nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 304)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 1127
        Me.Label6.Text = "Domicilio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 336)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 1129
        Me.Label7.Text = "Teléfonos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(345, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(368, 31)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "FICHA DEL TRABAJADOR"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(412, 833)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(144, 833)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 21
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 368)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 1135
        Me.Label9.Text = "E-mail:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 84)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 17)
        Me.Label11.TabIndex = 1139
        Me.Label11.Text = "INFORMACIÓN GENERAL:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(721, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 92)
        Me.PictureBox1.TabIndex = 1140
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Word Files|*.docx"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Word Files|*.docx"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 277)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 17)
        Me.Label14.TabIndex = 1155
        Me.Label14.Text = "Estado Civil:"
        '
        'txt_rut
        '
        Me.txt_rut.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_rut.Location = New System.Drawing.Point(296, 177)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rut.MaxLength = 100
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(417, 22)
        Me.txt_rut.TabIndex = 2
        '
        'txt_estado_civil
        '
        Me.txt_estado_civil.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_estado_civil.Location = New System.Drawing.Point(296, 272)
        Me.txt_estado_civil.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_estado_civil.MaxLength = 100
        Me.txt_estado_civil.Name = "txt_estado_civil"
        Me.txt_estado_civil.Size = New System.Drawing.Size(417, 22)
        Me.txt_estado_civil.TabIndex = 5
        '
        'txt_domicilio
        '
        Me.txt_domicilio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_domicilio.Location = New System.Drawing.Point(296, 304)
        Me.txt_domicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_domicilio.MaxLength = 100
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(417, 22)
        Me.txt_domicilio.TabIndex = 6
        '
        'txt_telefonos
        '
        Me.txt_telefonos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_telefonos.Location = New System.Drawing.Point(296, 331)
        Me.txt_telefonos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefonos.MaxLength = 100
        Me.txt_telefonos.Name = "txt_telefonos"
        Me.txt_telefonos.Size = New System.Drawing.Size(417, 22)
        Me.txt_telefonos.TabIndex = 7
        '
        'txt_email
        '
        Me.txt_email.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_email.Location = New System.Drawing.Point(296, 361)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.MaxLength = 100
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(417, 22)
        Me.txt_email.TabIndex = 8
        '
        'txt_fecha_nacimiento
        '
        Me.txt_fecha_nacimiento.Location = New System.Drawing.Point(296, 211)
        Me.txt_fecha_nacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento"
        Me.txt_fecha_nacimiento.Size = New System.Drawing.Size(417, 22)
        Me.txt_fecha_nacimiento.TabIndex = 3
        '
        'txt_fecha_ingreso
        '
        Me.txt_fecha_ingreso.Location = New System.Drawing.Point(296, 622)
        Me.txt_fecha_ingreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        Me.txt_fecha_ingreso.Size = New System.Drawing.Size(417, 22)
        Me.txt_fecha_ingreso.TabIndex = 15
        '
        'txt_cargo
        '
        Me.txt_cargo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cargo.Location = New System.Drawing.Point(296, 534)
        Me.txt_cargo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cargo.MaxLength = 100
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(417, 22)
        Me.txt_cargo.TabIndex = 12
        '
        'txt_salud
        '
        Me.txt_salud.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_salud.Location = New System.Drawing.Point(296, 595)
        Me.txt_salud.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_salud.MaxLength = 100
        Me.txt_salud.Name = "txt_salud"
        Me.txt_salud.Size = New System.Drawing.Size(417, 22)
        Me.txt_salud.TabIndex = 14
        '
        'txt_profesion
        '
        Me.txt_profesion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_profesion.Location = New System.Drawing.Point(296, 500)
        Me.txt_profesion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_profesion.MaxLength = 100
        Me.txt_profesion.Name = "txt_profesion"
        Me.txt_profesion.Size = New System.Drawing.Size(417, 22)
        Me.txt_profesion.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 600)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 1174
        Me.Label10.Text = "Salud:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 407)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 17)
        Me.Label12.TabIndex = 1173
        Me.Label12.Text = "INFORMACIÓN LABORAL:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 627)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(207, 17)
        Me.Label16.TabIndex = 1170
        Me.Label16.Text = "Fecha de Ingreso Empresa:"
        '
        'txt_afp
        '
        Me.txt_afp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_afp.Location = New System.Drawing.Point(296, 564)
        Me.txt_afp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_afp.MaxLength = 100
        Me.txt_afp.Name = "txt_afp"
        Me.txt_afp.Size = New System.Drawing.Size(417, 22)
        Me.txt_afp.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(29, 564)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 17)
        Me.Label17.TabIndex = 1169
        Me.Label17.Text = "AFP:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(29, 532)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 17)
        Me.Label18.TabIndex = 1167
        Me.Label18.Text = "Cargo/Labor:"
        '
        'txt_faena_actual
        '
        Me.txt_faena_actual.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_faena_actual.Location = New System.Drawing.Point(296, 468)
        Me.txt_faena_actual.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_faena_actual.MaxLength = 100
        Me.txt_faena_actual.Name = "txt_faena_actual"
        Me.txt_faena_actual.Size = New System.Drawing.Size(417, 22)
        Me.txt_faena_actual.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(29, 468)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 17)
        Me.Label19.TabIndex = 1166
        Me.Label19.Text = "Faena actual:"
        '
        'txt_tipo_contrato
        '
        Me.txt_tipo_contrato.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_tipo_contrato.Location = New System.Drawing.Point(296, 439)
        Me.txt_tipo_contrato.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo_contrato.MaxLength = 100
        Me.txt_tipo_contrato.Name = "txt_tipo_contrato"
        Me.txt_tipo_contrato.Size = New System.Drawing.Size(417, 22)
        Me.txt_tipo_contrato.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(29, 439)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(133, 17)
        Me.Label20.TabIndex = 1164
        Me.Label20.Text = "Tipo de contrato:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(29, 500)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(129, 17)
        Me.Label21.TabIndex = 1181
        Me.Label21.Text = "Profesión/Oficio:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 672)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(198, 17)
        Me.Label13.TabIndex = 1186
        Me.Label13.Text = "SITUACIÓN TRABAJADOR"
        '
        'txt_situacion_habitacional
        '
        Me.txt_situacion_habitacional.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_situacion_habitacional.Location = New System.Drawing.Point(295, 733)
        Me.txt_situacion_habitacional.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_situacion_habitacional.MaxLength = 100
        Me.txt_situacion_habitacional.Name = "txt_situacion_habitacional"
        Me.txt_situacion_habitacional.Size = New System.Drawing.Size(417, 22)
        Me.txt_situacion_habitacional.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 733)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(173, 17)
        Me.Label15.TabIndex = 1185
        Me.Label15.Text = "Situación habitacional:"
        '
        'txt_nivel_escolaridad
        '
        Me.txt_nivel_escolaridad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_nivel_escolaridad.Location = New System.Drawing.Point(295, 704)
        Me.txt_nivel_escolaridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nivel_escolaridad.MaxLength = 100
        Me.txt_nivel_escolaridad.Name = "txt_nivel_escolaridad"
        Me.txt_nivel_escolaridad.Size = New System.Drawing.Size(417, 22)
        Me.txt_nivel_escolaridad.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(28, 704)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(161, 17)
        Me.Label22.TabIndex = 1183
        Me.Label22.Text = "Nivel de escolaridad:"
        '
        'txt_cargas
        '
        Me.txt_cargas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cargas.Location = New System.Drawing.Point(296, 794)
        Me.txt_cargas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cargas.MaxLength = 100
        Me.txt_cargas.Name = "txt_cargas"
        Me.txt_cargas.Size = New System.Drawing.Size(417, 22)
        Me.txt_cargas.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(29, 794)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 17)
        Me.Label23.TabIndex = 1190
        Me.Label23.Text = "Cargas familiares:"
        '
        'txt_integrantes
        '
        Me.txt_integrantes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_integrantes.Location = New System.Drawing.Point(296, 765)
        Me.txt_integrantes.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_integrantes.MaxLength = 100
        Me.txt_integrantes.Name = "txt_integrantes"
        Me.txt_integrantes.Size = New System.Drawing.Size(417, 22)
        Me.txt_integrantes.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(29, 765)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(142, 17)
        Me.Label24.TabIndex = 1188
        Me.Label24.Text = "Integrantes hogar:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(730, 672)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(138, 17)
        Me.Label25.TabIndex = 1193
        Me.Label25.Text = "OBSERVACIONES"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(733, 692)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(468, 124)
        Me.txt_observaciones.TabIndex = 1194
        '
        'frm_ficha_trabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_cargas)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_integrantes)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_situacion_habitacional)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_nivel_escolaridad)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_fecha_ingreso)
        Me.Controls.Add(Me.txt_cargo)
        Me.Controls.Add(Me.txt_salud)
        Me.Controls.Add(Me.txt_profesion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_afp)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_faena_actual)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_tipo_contrato)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_fecha_nacimiento)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_telefonos)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_estado_civil)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_lugar_nacimiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_ficha_trabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ficha del Trabajador"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_lugar_nacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_estado_civil As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefonos As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_cargo As System.Windows.Forms.TextBox
    Friend WithEvents txt_salud As System.Windows.Forms.TextBox
    Friend WithEvents txt_profesion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_afp As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_faena_actual As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_contrato As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_situacion_habitacional As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_nivel_escolaridad As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_cargas As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_integrantes As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
End Class
