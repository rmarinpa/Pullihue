<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_subcontrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro_subcontrato))
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_codigo_subcontrato = New System.Windows.Forms.ComboBox()
        Me.cmb_forma_de_pago = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_tipo_de_medicion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_representante = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_cuenta_costo = New System.Windows.Forms.ComboBox()
        Me.txt_tipo_subcontrato = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cantidad_modificacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cantidad_contratada = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_registro = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(340, 494)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 13
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'txt_glosa
        '
        Me.txt_glosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_glosa.Location = New System.Drawing.Point(295, 225)
        Me.txt_glosa.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_glosa.MaxLength = 100
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(345, 22)
        Me.txt_glosa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "REPRESENTANTE"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(72, 494)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 10
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dgv_curso
        '
        Me.dgv_curso.AllowUserToAddRows = False
        Me.dgv_curso.AllowUserToDeleteRows = False
        Me.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso.Location = New System.Drawing.Point(671, 57)
        Me.dgv_curso.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(603, 468)
        Me.dgv_curso.TabIndex = 1104
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(251, 494)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 12
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_precio
        '
        Me.txt_precio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_precio.Location = New System.Drawing.Point(295, 346)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio.MaxLength = 100
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(345, 22)
        Me.txt_precio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 17)
        Me.Label1.TabIndex = 1119
        Me.Label1.Text = "TIPO DE SUBCONTRATO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 322)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 17)
        Me.Label4.TabIndex = 1123
        Me.Label4.Text = "FORMA DE PAGO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 351)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 1125
        Me.Label5.Text = "PRECIO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(345, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(632, 31)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "INGRESO DE PARÁMETROS SUBCONTRATO"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(429, 494)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 14
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
        Me.btn_cancelar.Location = New System.Drawing.Point(161, 494)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 101)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 17)
        Me.Label11.TabIndex = 1139
        Me.Label11.Text = "CÓDIGO SUBCONTRATO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 86)
        Me.PictureBox1.TabIndex = 1140
        Me.PictureBox1.TabStop = False
        '
        'cmb_codigo_subcontrato
        '
        Me.cmb_codigo_subcontrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_codigo_subcontrato.FormattingEnabled = True
        Me.cmb_codigo_subcontrato.Location = New System.Drawing.Point(296, 101)
        Me.cmb_codigo_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_codigo_subcontrato.Name = "cmb_codigo_subcontrato"
        Me.cmb_codigo_subcontrato.Size = New System.Drawing.Size(345, 24)
        Me.cmb_codigo_subcontrato.TabIndex = 0
        '
        'cmb_forma_de_pago
        '
        Me.cmb_forma_de_pago.FormattingEnabled = True
        Me.cmb_forma_de_pago.Items.AddRange(New Object() {"Unidad", "GL"})
        Me.cmb_forma_de_pago.Location = New System.Drawing.Point(295, 315)
        Me.cmb_forma_de_pago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_forma_de_pago.Name = "cmb_forma_de_pago"
        Me.cmb_forma_de_pago.Size = New System.Drawing.Size(345, 24)
        Me.cmb_forma_de_pago.TabIndex = 6
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
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(671, 549)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(365, 22)
        Me.txt_nombre_obra.TabIndex = 1151
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(543, 553)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 17)
        Me.Label12.TabIndex = 1152
        Me.Label12.Text = "NOMBRE OBRA:"
        '
        'cmb_tipo_de_medicion
        '
        Me.cmb_tipo_de_medicion.FormattingEnabled = True
        Me.cmb_tipo_de_medicion.Items.AddRange(New Object() {"KG", "M", "M2"})
        Me.cmb_tipo_de_medicion.Location = New System.Drawing.Point(295, 376)
        Me.cmb_tipo_de_medicion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_tipo_de_medicion.Name = "cmb_tipo_de_medicion"
        Me.cmb_tipo_de_medicion.Size = New System.Drawing.Size(345, 24)
        Me.cmb_tipo_de_medicion.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 383)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 17)
        Me.Label14.TabIndex = 1155
        Me.Label14.Text = "TIPO DE MEDICIÓN:"
        '
        'txt_representante
        '
        Me.txt_representante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_representante.Location = New System.Drawing.Point(296, 133)
        Me.txt_representante.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_representante.MaxLength = 100
        Me.txt_representante.Name = "txt_representante"
        Me.txt_representante.Size = New System.Drawing.Size(345, 22)
        Me.txt_representante.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 1158
        Me.Label3.Text = "GLOSA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 415)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 17)
        Me.Label6.TabIndex = 1160
        Me.Label6.Text = "CUENTA DE COSTO:"
        '
        'cmb_cuenta_costo
        '
        Me.cmb_cuenta_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cuenta_costo.FormattingEnabled = True
        Me.cmb_cuenta_costo.Items.AddRange(New Object() {"KG", "M", "M2"})
        Me.cmb_cuenta_costo.Location = New System.Drawing.Point(295, 408)
        Me.cmb_cuenta_costo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_cuenta_costo.Name = "cmb_cuenta_costo"
        Me.cmb_cuenta_costo.Size = New System.Drawing.Size(345, 24)
        Me.cmb_cuenta_costo.TabIndex = 9
        '
        'txt_tipo_subcontrato
        '
        Me.txt_tipo_subcontrato.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_tipo_subcontrato.Location = New System.Drawing.Point(296, 163)
        Me.txt_tipo_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo_subcontrato.MaxLength = 100
        Me.txt_tipo_subcontrato.Name = "txt_tipo_subcontrato"
        Me.txt_tipo_subcontrato.Size = New System.Drawing.Size(345, 22)
        Me.txt_tipo_subcontrato.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 290)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 17)
        Me.Label7.TabIndex = 1164
        Me.Label7.Text = "CANTIDAD MODIFICACIÓN:"
        '
        'txt_cantidad_modificacion
        '
        Me.txt_cantidad_modificacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cantidad_modificacion.Location = New System.Drawing.Point(295, 285)
        Me.txt_cantidad_modificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad_modificacion.MaxLength = 100
        Me.txt_cantidad_modificacion.Name = "txt_cantidad_modificacion"
        Me.txt_cantidad_modificacion.Size = New System.Drawing.Size(345, 22)
        Me.txt_cantidad_modificacion.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 260)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 17)
        Me.Label9.TabIndex = 1166
        Me.Label9.Text = "CANTIDAD CONTRATADA:"
        '
        'txt_cantidad_contratada
        '
        Me.txt_cantidad_contratada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_cantidad_contratada.Location = New System.Drawing.Point(295, 255)
        Me.txt_cantidad_contratada.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad_contratada.MaxLength = 100
        Me.txt_cantidad_contratada.Name = "txt_cantidad_contratada"
        Me.txt_cantidad_contratada.Size = New System.Drawing.Size(345, 22)
        Me.txt_cantidad_contratada.TabIndex = 4
        '
        'cmb_tipo_registro
        '
        Me.cmb_tipo_registro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_registro.FormattingEnabled = True
        Me.cmb_tipo_registro.Items.AddRange(New Object() {"CONTRATO", "OBRAS EXTRAORDINARIAS"})
        Me.cmb_tipo_registro.Location = New System.Drawing.Point(295, 193)
        Me.cmb_tipo_registro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_tipo_registro.Name = "cmb_tipo_registro"
        Me.cmb_tipo_registro.Size = New System.Drawing.Size(345, 24)
        Me.cmb_tipo_registro.TabIndex = 1167
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 200)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 17)
        Me.Label10.TabIndex = 1168
        Me.Label10.Text = "TIPO DE REGISTRO:"
        '
        'frm_registro_subcontrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.cmb_tipo_registro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_cantidad_contratada)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cantidad_modificacion)
        Me.Controls.Add(Me.txt_tipo_subcontrato)
        Me.Controls.Add(Me.cmb_cuenta_costo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_representante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_tipo_de_medicion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmb_forma_de_pago)
        Me.Controls.Add(Me.cmb_codigo_subcontrato)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.txt_glosa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_registro_subcontrato"
        Me.Text = "Representantes"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents txt_glosa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_codigo_subcontrato As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_forma_de_pago As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_de_medicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_representante As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_cuenta_costo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tipo_subcontrato As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_modificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_contratada As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_registro As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
