<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_matricula))
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.gbx_info_mat = New System.Windows.Forms.GroupBox()
        Me.cmbx_jornada = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.rbtn_nueva = New System.Windows.Forms.RadioButton()
        Me.rbtn_renovacion = New System.Windows.Forms.RadioButton()
        Me.cmbx_curso = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.dgv_matricula = New System.Windows.Forms.DataGridView()
        Me.gbx_busq_est = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_num_doc = New System.Windows.Forms.TextBox()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.gbx_info_mat.SuspendLayout()
        CType(Me.dgv_matricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_busq_est.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Location = New System.Drawing.Point(455, 140)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(173, 13)
        Me.lbl_usuario.TabIndex = 1111
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(304, 140)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(145, 13)
        Me.label4.TabIndex = 1110
        Me.label4.Text = "MATRÍCULA EMITIDA POR:"
        '
        'gbx_info_mat
        '
        Me.gbx_info_mat.Controls.Add(Me.cmbx_jornada)
        Me.gbx_info_mat.Controls.Add(Me.label3)
        Me.gbx_info_mat.Controls.Add(Me.rbtn_nueva)
        Me.gbx_info_mat.Controls.Add(Me.rbtn_renovacion)
        Me.gbx_info_mat.Controls.Add(Me.cmbx_curso)
        Me.gbx_info_mat.Controls.Add(Me.label8)
        Me.gbx_info_mat.Controls.Add(Me.label7)
        Me.gbx_info_mat.Controls.Add(Me.txt_fecha)
        Me.gbx_info_mat.Controls.Add(Me.txt_monto)
        Me.gbx_info_mat.Controls.Add(Me.label9)
        Me.gbx_info_mat.Controls.Add(Me.label10)
        Me.gbx_info_mat.Location = New System.Drawing.Point(12, 12)
        Me.gbx_info_mat.Name = "gbx_info_mat"
        Me.gbx_info_mat.Size = New System.Drawing.Size(274, 209)
        Me.gbx_info_mat.TabIndex = 1107
        Me.gbx_info_mat.TabStop = False
        Me.gbx_info_mat.Text = "Información de Matrícula"
        '
        'cmbx_jornada
        '
        Me.cmbx_jornada.FormattingEnabled = True
        Me.cmbx_jornada.Location = New System.Drawing.Point(85, 110)
        Me.cmbx_jornada.Name = "cmbx_jornada"
        Me.cmbx_jornada.Size = New System.Drawing.Size(183, 21)
        Me.cmbx_jornada.TabIndex = 1101
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(8, 113)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 1100
        Me.label3.Text = "JORNADA:"
        '
        'rbtn_nueva
        '
        Me.rbtn_nueva.Location = New System.Drawing.Point(159, 77)
        Me.rbtn_nueva.Name = "rbtn_nueva"
        Me.rbtn_nueva.Size = New System.Drawing.Size(71, 24)
        Me.rbtn_nueva.TabIndex = 1099
        Me.rbtn_nueva.TabStop = True
        Me.rbtn_nueva.Text = "NUEVA"
        Me.rbtn_nueva.UseVisualStyleBackColor = True
        '
        'rbtn_renovacion
        '
        Me.rbtn_renovacion.Location = New System.Drawing.Point(49, 77)
        Me.rbtn_renovacion.Name = "rbtn_renovacion"
        Me.rbtn_renovacion.Size = New System.Drawing.Size(104, 24)
        Me.rbtn_renovacion.TabIndex = 1098
        Me.rbtn_renovacion.TabStop = True
        Me.rbtn_renovacion.Text = "RENOVACIÓN"
        Me.rbtn_renovacion.UseVisualStyleBackColor = True
        '
        'cmbx_curso
        '
        Me.cmbx_curso.FormattingEnabled = True
        Me.cmbx_curso.Location = New System.Drawing.Point(85, 23)
        Me.cmbx_curso.Name = "cmbx_curso"
        Me.cmbx_curso.Size = New System.Drawing.Size(183, 21)
        Me.cmbx_curso.TabIndex = 1097
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(8, 26)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 13)
        Me.label8.TabIndex = 1090
        Me.label8.Text = "CURSO:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(11, 150)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(45, 13)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(85, 144)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(183, 20)
        Me.txt_fecha.TabIndex = 1095
        '
        'txt_monto
        '
        Me.txt_monto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_monto.Location = New System.Drawing.Point(85, 177)
        Me.txt_monto.MaxLength = 40
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(183, 20)
        Me.txt_monto.TabIndex = 1085
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(11, 180)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(50, 13)
        Me.label9.TabIndex = 1089
        Me.label9.Text = "MONTO:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(67, 61)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(136, 13)
        Me.label10.TabIndex = 1087
        Me.label10.Text = "TIPO DE MATRÍCULA:"
        '
        'dgv_matricula
        '
        Me.dgv_matricula.AllowUserToAddRows = False
        Me.dgv_matricula.AllowUserToDeleteRows = False
        Me.dgv_matricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_matricula.Location = New System.Drawing.Point(12, 227)
        Me.dgv_matricula.Name = "dgv_matricula"
        Me.dgv_matricula.ReadOnly = True
        Me.dgv_matricula.RowHeadersVisible = False
        Me.dgv_matricula.Size = New System.Drawing.Size(616, 221)
        Me.dgv_matricula.TabIndex = 1112
        '
        'gbx_busq_est
        '
        Me.gbx_busq_est.Controls.Add(Me.btn_buscar)
        Me.gbx_busq_est.Controls.Add(Me.Label1)
        Me.gbx_busq_est.Controls.Add(Me.txt_num_doc)
        Me.gbx_busq_est.Controls.Add(Me.txt_apellido1)
        Me.gbx_busq_est.Controls.Add(Me.Label5)
        Me.gbx_busq_est.Controls.Add(Me.txt_nombre)
        Me.gbx_busq_est.Controls.Add(Me.Label2)
        Me.gbx_busq_est.Location = New System.Drawing.Point(304, 12)
        Me.gbx_busq_est.Name = "gbx_busq_est"
        Me.gbx_busq_est.Size = New System.Drawing.Size(324, 107)
        Me.gbx_busq_est.TabIndex = 1106
        Me.gbx_busq_est.TabStop = False
        Me.gbx_busq_est.Text = "Búsqueda de Estudiantes"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = CType(resources.GetObject("btn_buscar.BackgroundImage"), System.Drawing.Image)
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_buscar.Location = New System.Drawing.Point(290, 23)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(20, 20)
        Me.btn_buscar.TabIndex = 1104
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "Nº DOCUMENTO:"
        '
        'txt_num_doc
        '
        Me.txt_num_doc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_num_doc.Location = New System.Drawing.Point(109, 23)
        Me.txt_num_doc.MaxLength = 20
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(175, 20)
        Me.txt_num_doc.TabIndex = 1083
        '
        'txt_apellido1
        '
        Me.txt_apellido1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_apellido1.Location = New System.Drawing.Point(109, 79)
        Me.txt_apellido1.MaxLength = 40
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(175, 20)
        Me.txt_apellido1.TabIndex = 1085
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 1089
        Me.Label5.Text = "1º APELLIDO:"
        '
        'txt_nombre
        '
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(109, 53)
        Me.txt_nombre.MaxLength = 40
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(175, 20)
        Me.txt_nombre.TabIndex = 1084
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1087
        Me.Label2.Text = "NOMBRES:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(501, 169)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 52)
        Me.btn_cancelar.TabIndex = 1108
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(367, 169)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(61, 52)
        Me.btn_nuevo.TabIndex = 1109
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(434, 169)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 52)
        Me.btn_guardar.TabIndex = 1105
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'frm_matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 460)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.gbx_info_mat)
        Me.Controls.Add(Me.dgv_matricula)
        Me.Controls.Add(Me.gbx_busq_est)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_guardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_matricula"
        Me.Text = "frm_matricula"
        Me.gbx_info_mat.ResumeLayout(False)
        Me.gbx_info_mat.PerformLayout()
        CType(Me.dgv_matricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_busq_est.ResumeLayout(False)
        Me.gbx_busq_est.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents gbx_info_mat As System.Windows.Forms.GroupBox
    Private WithEvents cmbx_jornada As System.Windows.Forms.ComboBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents rbtn_nueva As System.Windows.Forms.RadioButton
    Private WithEvents rbtn_renovacion As System.Windows.Forms.RadioButton
    Private WithEvents cmbx_curso As System.Windows.Forms.ComboBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents dgv_matricula As System.Windows.Forms.DataGridView
    Private WithEvents gbx_busq_est As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
