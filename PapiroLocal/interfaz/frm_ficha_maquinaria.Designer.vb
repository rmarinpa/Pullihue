<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ficha_maquinaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ficha_maquinaria))
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_tipo_maq = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_sigla = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ano = New System.Windows.Forms.TextBox()
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
        Me.txt_maquinaria = New System.Windows.Forms.TextBox()
        Me.txt_patente = New System.Windows.Forms.TextBox()
        Me.txt_hor_final = New System.Windows.Forms.TextBox()
        Me.txt_motor = New System.Windows.Forms.TextBox()
        Me.txt_chassis = New System.Windows.Forms.TextBox()
        Me.txt_fecha_adquision = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha_actualizacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_lubricante = New System.Windows.Forms.TextBox()
        Me.txt_go = New System.Windows.Forms.TextBox()
        Me.txt_material_desgaste = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_petroleo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_operador = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cuenta_repuesto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cuenta_ingreso = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_maq_relacionada = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_obra = New System.Windows.Forms.ComboBox()
        Me.cmb_codigo_relacionado = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txt_tipo_maq
        '
        Me.txt_tipo_maq.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_tipo_maq.Location = New System.Drawing.Point(296, 106)
        Me.txt_tipo_maq.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo_maq.MaxLength = 40
        Me.txt_tipo_maq.Name = "txt_tipo_maq"
        Me.txt_tipo_maq.Size = New System.Drawing.Size(264, 22)
        Me.txt_tipo_maq.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "Tipo de máquina:"
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
        Me.dgv_curso.Location = New System.Drawing.Point(595, 106)
        Me.dgv_curso.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(468, 594)
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
        'txt_sigla
        '
        Me.txt_sigla.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_sigla.Location = New System.Drawing.Point(296, 135)
        Me.txt_sigla.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sigla.MaxLength = 40
        Me.txt_sigla.Name = "txt_sigla"
        Me.txt_sigla.Size = New System.Drawing.Size(264, 22)
        Me.txt_sigla.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1119
        Me.Label1.Text = "Sigla:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 1121
        Me.Label3.Text = "Maquinaria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 394)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 1123
        Me.Label4.Text = "Fecha de Adquisión:"
        '
        'txt_ano
        '
        Me.txt_ano.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_ano.Location = New System.Drawing.Point(296, 239)
        Me.txt_ano.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ano.MaxLength = 40
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(264, 22)
        Me.txt_ano.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 1125
        Me.Label5.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 17)
        Me.Label6.TabIndex = 1127
        Me.Label6.Text = "Horómetro Final 2015:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 334)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 1129
        Me.Label7.Text = "Motor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(345, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(293, 31)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "FICHA MAQUINARIA"
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
        Me.Label9.Location = New System.Drawing.Point(27, 366)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 1135
        Me.Label9.Text = "Chassis:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(26, 74)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 17)
        Me.Label11.TabIndex = 1139
        Me.Label11.Text = "INFORMACIÓN GENERAL:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        Me.Label14.Location = New System.Drawing.Point(27, 274)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 1155
        Me.Label14.Text = "Patente:"
        '
        'txt_maquinaria
        '
        Me.txt_maquinaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_maquinaria.Location = New System.Drawing.Point(296, 167)
        Me.txt_maquinaria.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_maquinaria.MaxLength = 40
        Me.txt_maquinaria.Name = "txt_maquinaria"
        Me.txt_maquinaria.Size = New System.Drawing.Size(264, 22)
        Me.txt_maquinaria.TabIndex = 2
        '
        'txt_patente
        '
        Me.txt_patente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_patente.Location = New System.Drawing.Point(295, 269)
        Me.txt_patente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_patente.MaxLength = 40
        Me.txt_patente.Name = "txt_patente"
        Me.txt_patente.Size = New System.Drawing.Size(264, 22)
        Me.txt_patente.TabIndex = 5
        '
        'txt_hor_final
        '
        Me.txt_hor_final.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_hor_final.Location = New System.Drawing.Point(294, 300)
        Me.txt_hor_final.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hor_final.MaxLength = 40
        Me.txt_hor_final.Name = "txt_hor_final"
        Me.txt_hor_final.Size = New System.Drawing.Size(264, 22)
        Me.txt_hor_final.TabIndex = 6
        '
        'txt_motor
        '
        Me.txt_motor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_motor.Location = New System.Drawing.Point(295, 329)
        Me.txt_motor.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_motor.MaxLength = 40
        Me.txt_motor.Name = "txt_motor"
        Me.txt_motor.Size = New System.Drawing.Size(264, 22)
        Me.txt_motor.TabIndex = 7
        '
        'txt_chassis
        '
        Me.txt_chassis.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_chassis.Location = New System.Drawing.Point(294, 359)
        Me.txt_chassis.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_chassis.MaxLength = 40
        Me.txt_chassis.Name = "txt_chassis"
        Me.txt_chassis.Size = New System.Drawing.Size(264, 22)
        Me.txt_chassis.TabIndex = 8
        '
        'txt_fecha_adquision
        '
        Me.txt_fecha_adquision.Location = New System.Drawing.Point(295, 389)
        Me.txt_fecha_adquision.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_adquision.Name = "txt_fecha_adquision"
        Me.txt_fecha_adquision.Size = New System.Drawing.Size(264, 22)
        Me.txt_fecha_adquision.TabIndex = 3
        '
        'txt_fecha_actualizacion
        '
        Me.txt_fecha_actualizacion.Location = New System.Drawing.Point(298, 793)
        Me.txt_fecha_actualizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_actualizacion.Name = "txt_fecha_actualizacion"
        Me.txt_fecha_actualizacion.Size = New System.Drawing.Size(264, 22)
        Me.txt_fecha_actualizacion.TabIndex = 15
        '
        'txt_lubricante
        '
        Me.txt_lubricante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_lubricante.Location = New System.Drawing.Point(295, 574)
        Me.txt_lubricante.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_lubricante.MaxLength = 40
        Me.txt_lubricante.Name = "txt_lubricante"
        Me.txt_lubricante.Size = New System.Drawing.Size(264, 22)
        Me.txt_lubricante.TabIndex = 12
        '
        'txt_go
        '
        Me.txt_go.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_go.Location = New System.Drawing.Point(295, 637)
        Me.txt_go.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_go.MaxLength = 40
        Me.txt_go.Name = "txt_go"
        Me.txt_go.Size = New System.Drawing.Size(264, 22)
        Me.txt_go.TabIndex = 14
        '
        'txt_material_desgaste
        '
        Me.txt_material_desgaste.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_material_desgaste.Location = New System.Drawing.Point(295, 542)
        Me.txt_material_desgaste.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_material_desgaste.MaxLength = 40
        Me.txt_material_desgaste.Name = "txt_material_desgaste"
        Me.txt_material_desgaste.Size = New System.Drawing.Size(264, 22)
        Me.txt_material_desgaste.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 642)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 1174
        Me.Label10.Text = "Cuenta G-O:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(29, 209)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 17)
        Me.Label12.TabIndex = 1173
        Me.Label12.Text = "INFORMACIÓN MÁQUINA:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 797)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 17)
        Me.Label16.TabIndex = 1170
        Me.Label16.Text = "Fecha actualización:"
        '
        'txt_petroleo
        '
        Me.txt_petroleo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_petroleo.Location = New System.Drawing.Point(295, 606)
        Me.txt_petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_petroleo.MaxLength = 40
        Me.txt_petroleo.Name = "txt_petroleo"
        Me.txt_petroleo.Size = New System.Drawing.Size(264, 22)
        Me.txt_petroleo.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 606)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 17)
        Me.Label17.TabIndex = 1169
        Me.Label17.Text = "Cuenta Petróleo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 572)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 17)
        Me.Label18.TabIndex = 1167
        Me.Label18.Text = "Cuenta Lubricante:"
        '
        'txt_operador
        '
        Me.txt_operador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_operador.Location = New System.Drawing.Point(295, 510)
        Me.txt_operador.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_operador.MaxLength = 40
        Me.txt_operador.Name = "txt_operador"
        Me.txt_operador.Size = New System.Drawing.Size(264, 22)
        Me.txt_operador.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(28, 510)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 17)
        Me.Label19.TabIndex = 1166
        Me.Label19.Text = "Cuenta Operador:"
        '
        'txt_cuenta_repuesto
        '
        Me.txt_cuenta_repuesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cuenta_repuesto.Location = New System.Drawing.Point(295, 481)
        Me.txt_cuenta_repuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cuenta_repuesto.MaxLength = 40
        Me.txt_cuenta_repuesto.Name = "txt_cuenta_repuesto"
        Me.txt_cuenta_repuesto.Size = New System.Drawing.Size(264, 22)
        Me.txt_cuenta_repuesto.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 481)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(138, 17)
        Me.Label20.TabIndex = 1164
        Me.Label20.Text = "Cuenta Repuesto:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 542)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(223, 17)
        Me.Label21.TabIndex = 1181
        Me.Label21.Text = "Cuenta Material de Desgaste:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(27, 710)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 1185
        Me.Label15.Text = "Obra:"
        '
        'txt_cuenta_ingreso
        '
        Me.txt_cuenta_ingreso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cuenta_ingreso.Location = New System.Drawing.Point(294, 451)
        Me.txt_cuenta_ingreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cuenta_ingreso.MaxLength = 40
        Me.txt_cuenta_ingreso.Name = "txt_cuenta_ingreso"
        Me.txt_cuenta_ingreso.Size = New System.Drawing.Size(264, 22)
        Me.txt_cuenta_ingreso.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(29, 456)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(123, 17)
        Me.Label22.TabIndex = 1183
        Me.Label22.Text = "Cuenta Ingreso:"
        '
        'txt_maq_relacionada
        '
        Me.txt_maq_relacionada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_maq_relacionada.Location = New System.Drawing.Point(296, 763)
        Me.txt_maq_relacionada.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_maq_relacionada.MaxLength = 40
        Me.txt_maq_relacionada.Name = "txt_maq_relacionada"
        Me.txt_maq_relacionada.Size = New System.Drawing.Size(264, 22)
        Me.txt_maq_relacionada.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(29, 768)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(164, 17)
        Me.Label23.TabIndex = 1190
        Me.Label23.Text = "Máquina relacionada:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(27, 739)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(153, 17)
        Me.Label24.TabIndex = 1188
        Me.Label24.Text = "Codigo relacionado:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(28, 434)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(206, 17)
        Me.Label25.TabIndex = 1191
        Me.Label25.Text = "INFORMACIÓN CONTABLE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(29, 683)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(249, 17)
        Me.Label13.TabIndex = 1192
        Me.Label13.Text = "INFORMACIÓN RELACIÓN OBRA:"
        '
        'cmb_obra
        '
        Me.cmb_obra.FormattingEnabled = True
        Me.cmb_obra.Location = New System.Drawing.Point(296, 701)
        Me.cmb_obra.Name = "cmb_obra"
        Me.cmb_obra.Size = New System.Drawing.Size(266, 24)
        Me.cmb_obra.TabIndex = 1193
        '
        'cmb_codigo_relacionado
        '
        Me.cmb_codigo_relacionado.FormattingEnabled = True
        Me.cmb_codigo_relacionado.Location = New System.Drawing.Point(296, 732)
        Me.cmb_codigo_relacionado.Name = "cmb_codigo_relacionado"
        Me.cmb_codigo_relacionado.Size = New System.Drawing.Size(266, 24)
        Me.cmb_codigo_relacionado.TabIndex = 1194
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(657, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(406, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1195
        Me.PictureBox2.TabStop = False
        '
        'frm_ficha_maquinaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1182, 903)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmb_codigo_relacionado)
        Me.Controls.Add(Me.cmb_obra)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_maq_relacionada)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_cuenta_ingreso)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_fecha_actualizacion)
        Me.Controls.Add(Me.txt_lubricante)
        Me.Controls.Add(Me.txt_go)
        Me.Controls.Add(Me.txt_material_desgaste)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_petroleo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_operador)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_cuenta_repuesto)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_fecha_adquision)
        Me.Controls.Add(Me.txt_chassis)
        Me.Controls.Add(Me.txt_motor)
        Me.Controls.Add(Me.txt_hor_final)
        Me.Controls.Add(Me.txt_patente)
        Me.Controls.Add(Me.txt_maquinaria)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_ano)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_sigla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.txt_tipo_maq)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_ficha_maquinaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ficha Maquinaria"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents txt_tipo_maq As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_sigla As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ano As System.Windows.Forms.TextBox
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
    Friend WithEvents txt_maquinaria As System.Windows.Forms.TextBox
    Friend WithEvents txt_patente As System.Windows.Forms.TextBox
    Friend WithEvents txt_hor_final As System.Windows.Forms.TextBox
    Friend WithEvents txt_motor As System.Windows.Forms.TextBox
    Friend WithEvents txt_chassis As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_adquision As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha_actualizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_lubricante As System.Windows.Forms.TextBox
    Friend WithEvents txt_go As System.Windows.Forms.TextBox
    Friend WithEvents txt_material_desgaste As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_petroleo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_operador As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_cuenta_repuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_cuenta_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_maq_relacionada As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_obra As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_codigo_relacionado As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
