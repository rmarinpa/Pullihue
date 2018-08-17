<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_avance_subcontratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_avance_subcontratos))
        Me.dgv_Mov_Tierra = New System.Windows.Forms.DataGridView()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tipo_subcontrato = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_representante = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_avance = New System.Windows.Forms.TextBox()
        Me.txt_codigo_subcontrato = New System.Windows.Forms.ComboBox()
        Me.cmb_item = New System.Windows.Forms.ComboBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbx_avance_subcontrato = New System.Windows.Forms.GroupBox()
        Me.txt_tipo_de_medicion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_avance_subcontrato.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Mov_Tierra
        '
        Me.dgv_Mov_Tierra.AllowUserToAddRows = False
        Me.dgv_Mov_Tierra.AllowUserToDeleteRows = False
        Me.dgv_Mov_Tierra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Mov_Tierra.Location = New System.Drawing.Point(597, 61)
        Me.dgv_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Mov_Tierra.Name = "dgv_Mov_Tierra"
        Me.dgv_Mov_Tierra.ReadOnly = True
        Me.dgv_Mov_Tierra.RowHeadersVisible = False
        Me.dgv_Mov_Tierra.Size = New System.Drawing.Size(544, 289)
        Me.dgv_Mov_Tierra.TabIndex = 1086
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
        Me.Label11.Location = New System.Drawing.Point(709, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 36)
        Me.Label11.TabIndex = 1134
        Me.Label11.Text = "Tabla de Datos"
        '
        'txt_tipo_subcontrato
        '
        Me.txt_tipo_subcontrato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_tipo_subcontrato.Location = New System.Drawing.Point(201, 136)
        Me.txt_tipo_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo_subcontrato.MaxLength = 40
        Me.txt_tipo_subcontrato.Name = "txt_tipo_subcontrato"
        Me.txt_tipo_subcontrato.Size = New System.Drawing.Size(350, 22)
        Me.txt_tipo_subcontrato.TabIndex = 4
        Me.txt_tipo_subcontrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 17)
        Me.Label2.TabIndex = 1087
        Me.Label2.Text = "TIPO DE SUBCONTRATO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CÓDIGO SUBCONTRATO:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 106)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(129, 17)
        Me.label3.TabIndex = 1093
        Me.label3.Text = "REPRESENTANTE"
        '
        'txt_representante
        '
        Me.txt_representante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_representante.Location = New System.Drawing.Point(201, 101)
        Me.txt_representante.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_representante.MaxLength = 15
        Me.txt_representante.Name = "txt_representante"
        Me.txt_representante.Size = New System.Drawing.Size(350, 22)
        Me.txt_representante.TabIndex = 3
        Me.txt_representante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(201, 65)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(350, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(20, 70)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 17)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 203)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 1098
        Me.Label8.Text = "AVANCE:"
        '
        'txt_avance
        '
        Me.txt_avance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_avance.Location = New System.Drawing.Point(201, 198)
        Me.txt_avance.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_avance.MaxLength = 40
        Me.txt_avance.Name = "txt_avance"
        Me.txt_avance.Size = New System.Drawing.Size(350, 22)
        Me.txt_avance.TabIndex = 5
        Me.txt_avance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_codigo_subcontrato
        '
        Me.txt_codigo_subcontrato.FormattingEnabled = True
        Me.txt_codigo_subcontrato.Location = New System.Drawing.Point(201, 33)
        Me.txt_codigo_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo_subcontrato.Name = "txt_codigo_subcontrato"
        Me.txt_codigo_subcontrato.Size = New System.Drawing.Size(350, 24)
        Me.txt_codigo_subcontrato.TabIndex = 0
        '
        'cmb_item
        '
        Me.cmb_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_item.FormattingEnabled = True
        Me.cmb_item.Location = New System.Drawing.Point(201, 166)
        Me.cmb_item.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_item.Name = "cmb_item"
        Me.cmb_item.Size = New System.Drawing.Size(350, 24)
        Me.cmb_item.TabIndex = 8
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(201, 265)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(351, 22)
        Me.txt_observaciones.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 173)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 17)
        Me.Label14.TabIndex = 1109
        Me.Label14.Text = "ÍTEM:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 269)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 17)
        Me.Label15.TabIndex = 1110
        Me.Label15.Text = "OBSERVACIONES:"
        '
        'gbx_avance_subcontrato
        '
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_tipo_de_medicion)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label4)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_nombre_obra)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label16)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label15)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label14)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_observaciones)
        Me.gbx_avance_subcontrato.Controls.Add(Me.cmb_item)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_codigo_subcontrato)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_avance)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label8)
        Me.gbx_avance_subcontrato.Controls.Add(Me.label7)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_fecha)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_representante)
        Me.gbx_avance_subcontrato.Controls.Add(Me.label3)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label1)
        Me.gbx_avance_subcontrato.Controls.Add(Me.Label2)
        Me.gbx_avance_subcontrato.Controls.Add(Me.txt_tipo_subcontrato)
        Me.gbx_avance_subcontrato.Location = New System.Drawing.Point(16, 14)
        Me.gbx_avance_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_avance_subcontrato.Name = "gbx_avance_subcontrato"
        Me.gbx_avance_subcontrato.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_avance_subcontrato.Size = New System.Drawing.Size(569, 521)
        Me.gbx_avance_subcontrato.TabIndex = 1085
        Me.gbx_avance_subcontrato.TabStop = False
        Me.gbx_avance_subcontrato.Text = "Registro de avance Subcontrato"
        '
        'txt_tipo_de_medicion
        '
        Me.txt_tipo_de_medicion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_tipo_de_medicion.Location = New System.Drawing.Point(201, 228)
        Me.txt_tipo_de_medicion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipo_de_medicion.MaxLength = 40
        Me.txt_tipo_de_medicion.Name = "txt_tipo_de_medicion"
        Me.txt_tipo_de_medicion.Size = New System.Drawing.Size(350, 22)
        Me.txt_tipo_de_medicion.TabIndex = 1139
        Me.txt_tipo_de_medicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 1140
        Me.Label4.Text = "TIPO DE MEDICIÓN:"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(193, 314)
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
        Me.Label16.Location = New System.Drawing.Point(65, 318)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 17)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "NOMBRE OBRA:"
        '
        'Frm_avance_subcontratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1421, 654)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_Mov_Tierra)
        Me.Controls.Add(Me.gbx_avance_subcontrato)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_avance_subcontratos"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_avance_subcontrato.ResumeLayout(False)
        Me.gbx_avance_subcontrato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_Mov_Tierra As System.Windows.Forms.DataGridView
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_subcontrato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txt_representante As System.Windows.Forms.TextBox
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_avance As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_subcontrato As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_item As System.Windows.Forms.ComboBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents gbx_avance_subcontrato As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_de_medicion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
