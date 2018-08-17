<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_reports))
        Me.dgv_Mov_Tierra = New System.Windows.Forms.DataGridView()
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_de_trabajo = New System.Windows.Forms.ComboBox()
        Me.cmb_operador = New System.Windows.Forms.ComboBox()
        Me.cmb_dia_noche = New System.Windows.Forms.ComboBox()
        Me.txt_codigo = New System.Windows.Forms.ComboBox()
        Me.txt_dias_trabajados = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_total_horas_con_desc = New System.Windows.Forms.TextBox()
        Me.txt_panne_descuentos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_total_horas = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txt_hor_inicial = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_n_report = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_hor_final = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Mov_Tierra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Mov_Tierra
        '
        Me.dgv_Mov_Tierra.AllowUserToAddRows = False
        Me.dgv_Mov_Tierra.AllowUserToDeleteRows = False
        Me.dgv_Mov_Tierra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Mov_Tierra.Location = New System.Drawing.Point(762, 323)
        Me.dgv_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Mov_Tierra.Name = "dgv_Mov_Tierra"
        Me.dgv_Mov_Tierra.ReadOnly = True
        Me.dgv_Mov_Tierra.RowHeadersVisible = False
        Me.dgv_Mov_Tierra.Size = New System.Drawing.Size(544, 289)
        Me.dgv_Mov_Tierra.TabIndex = 1086
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_nombre_obra)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label16)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label15)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label14)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label13)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label12)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_observaciones)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_tipo_de_trabajo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_operador)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_dia_noche)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_codigo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_dias_trabajados)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label4)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_total_horas_con_desc)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_panne_descuentos)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label9)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label8)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label10)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_descripcion)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label7)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_total_horas)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_fecha)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label6)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_hor_inicial)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_n_report)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label5)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_hor_final)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(16, 14)
        Me.gbx_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(738, 521)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Registro de Reports Movimiento de Tierra"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(365, 450)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(359, 22)
        Me.txt_nombre_obra.TabIndex = 1137
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(237, 454)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 17)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "NOMBRE OBRA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 357)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 17)
        Me.Label15.TabIndex = 1110
        Me.Label15.Text = "OBSERVACIONES:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 316)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 17)
        Me.Label14.TabIndex = 1109
        Me.Label14.Text = "TIPO DE TRABAJO:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 283)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 1108
        Me.Label13.Text = "OPERADOR:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 250)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 1107
        Me.Label12.Text = "DÍA/NOCHE"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(201, 353)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(523, 22)
        Me.txt_observaciones.TabIndex = 9
        '
        'cmb_tipo_de_trabajo
        '
        Me.cmb_tipo_de_trabajo.FormattingEnabled = True
        Me.cmb_tipo_de_trabajo.Location = New System.Drawing.Point(201, 306)
        Me.cmb_tipo_de_trabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_tipo_de_trabajo.Name = "cmb_tipo_de_trabajo"
        Me.cmb_tipo_de_trabajo.Size = New System.Drawing.Size(251, 24)
        Me.cmb_tipo_de_trabajo.TabIndex = 8
        '
        'cmb_operador
        '
        Me.cmb_operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_operador.FormattingEnabled = True
        Me.cmb_operador.Location = New System.Drawing.Point(201, 273)
        Me.cmb_operador.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_operador.Name = "cmb_operador"
        Me.cmb_operador.Size = New System.Drawing.Size(251, 24)
        Me.cmb_operador.TabIndex = 7
        '
        'cmb_dia_noche
        '
        Me.cmb_dia_noche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia_noche.FormattingEnabled = True
        Me.cmb_dia_noche.Items.AddRange(New Object() {"Dia", "Noche"})
        Me.cmb_dia_noche.Location = New System.Drawing.Point(201, 240)
        Me.cmb_dia_noche.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_dia_noche.Name = "cmb_dia_noche"
        Me.cmb_dia_noche.Size = New System.Drawing.Size(251, 24)
        Me.cmb_dia_noche.TabIndex = 6
        '
        'txt_codigo
        '
        Me.txt_codigo.FormattingEnabled = True
        Me.txt_codigo.Location = New System.Drawing.Point(201, 33)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(251, 24)
        Me.txt_codigo.TabIndex = 0
        '
        'txt_dias_trabajados
        '
        Me.txt_dias_trabajados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_dias_trabajados.Location = New System.Drawing.Point(649, 39)
        Me.txt_dias_trabajados.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_dias_trabajados.MaxLength = 15
        Me.txt_dias_trabajados.Name = "txt_dias_trabajados"
        Me.txt_dias_trabajados.Size = New System.Drawing.Size(75, 22)
        Me.txt_dias_trabajados.TabIndex = 6
        Me.txt_dias_trabajados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 1088
        Me.Label4.Text = "DÍAS TRABAJADOS:"
        '
        'txt_total_horas_con_desc
        '
        Me.txt_total_horas_con_desc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_horas_con_desc.Location = New System.Drawing.Point(649, 199)
        Me.txt_total_horas_con_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_horas_con_desc.MaxLength = 40
        Me.txt_total_horas_con_desc.Name = "txt_total_horas_con_desc"
        Me.txt_total_horas_con_desc.Size = New System.Drawing.Size(75, 22)
        Me.txt_total_horas_con_desc.TabIndex = 8
        Me.txt_total_horas_con_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_panne_descuentos
        '
        Me.txt_panne_descuentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_panne_descuentos.Location = New System.Drawing.Point(201, 204)
        Me.txt_panne_descuentos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_panne_descuentos.MaxLength = 40
        Me.txt_panne_descuentos.Name = "txt_panne_descuentos"
        Me.txt_panne_descuentos.Size = New System.Drawing.Size(251, 22)
        Me.txt_panne_descuentos.TabIndex = 5
        Me.txt_panne_descuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(474, 201)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 17)
        Me.Label9.TabIndex = 1100
        Me.Label9.Text = "TOTAL HRS. CON DESC.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 213)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 17)
        Me.Label8.TabIndex = 1098
        Me.Label8.Text = "PANNE/DESCUENTOS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 418)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 17)
        Me.Label10.TabIndex = 1102
        Me.Label10.Text = "DESCRIPCIÓN MÁQUINA:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion.Location = New System.Drawing.Point(365, 418)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.MaxLength = 20
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(359, 22)
        Me.txt_descripcion.TabIndex = 9
        Me.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(20, 73)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 17)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_total_horas
        '
        Me.txt_total_horas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_horas.Location = New System.Drawing.Point(649, 159)
        Me.txt_total_horas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_horas.MaxLength = 40
        Me.txt_total_horas.Name = "txt_total_horas"
        Me.txt_total_horas.Size = New System.Drawing.Size(75, 22)
        Me.txt_total_horas.TabIndex = 7
        Me.txt_total_horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(201, 65)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(251, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(474, 162)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(111, 17)
        Me.label6.TabIndex = 1094
        Me.label6.Text = "TOTAL HORAS:"
        '
        'txt_hor_inicial
        '
        Me.txt_hor_inicial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_hor_inicial.Location = New System.Drawing.Point(201, 132)
        Me.txt_hor_inicial.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hor_inicial.MaxLength = 15
        Me.txt_hor_inicial.Name = "txt_hor_inicial"
        Me.txt_hor_inicial.Size = New System.Drawing.Size(251, 22)
        Me.txt_hor_inicial.TabIndex = 3
        Me.txt_hor_inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 135)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(149, 17)
        Me.label3.TabIndex = 1093
        Me.label3.Text = "HORÓMETRO INICIAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CÓDIGO MÁQUINA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 17)
        Me.Label2.TabIndex = 1087
        Me.Label2.Text = "HORÓMETRO FINAL:"
        '
        'txt_n_report
        '
        Me.txt_n_report.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_n_report.Location = New System.Drawing.Point(201, 97)
        Me.txt_n_report.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_n_report.MaxLength = 40
        Me.txt_n_report.Name = "txt_n_report"
        Me.txt_n_report.Size = New System.Drawing.Size(251, 22)
        Me.txt_n_report.TabIndex = 2
        Me.txt_n_report.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 1089
        Me.Label5.Text = "N° DE REPORT:"
        '
        'txt_hor_final
        '
        Me.txt_hor_final.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_hor_final.Location = New System.Drawing.Point(201, 169)
        Me.txt_hor_final.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hor_final.MaxLength = 40
        Me.txt_hor_final.Name = "txt_hor_final"
        Me.txt_hor_final.Size = New System.Drawing.Size(251, 22)
        Me.txt_hor_final.TabIndex = 4
        Me.txt_hor_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(105, 548)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(373, 548)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(16, 548)
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
        Me.btn_guardar.Location = New System.Drawing.Point(284, 548)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(762, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 272)
        Me.PictureBox1.TabIndex = 1103
        Me.PictureBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(195, 548)
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
        Me.Label11.Location = New System.Drawing.Point(859, 283)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 36)
        Me.Label11.TabIndex = 1134
        Me.Label11.Text = "Tabla de Datos"
        '
        'Frm_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1421, 654)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_Mov_Tierra)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_reports"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_Mov_Tierra As System.Windows.Forms.DataGridView
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_hor_inicial As System.Windows.Forms.TextBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_total_horas As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_dias_trabajados As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_n_report As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_hor_final As System.Windows.Forms.TextBox
    Friend WithEvents txt_panne_descuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_total_horas_con_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_de_trabajo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_operador As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_dia_noche As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
