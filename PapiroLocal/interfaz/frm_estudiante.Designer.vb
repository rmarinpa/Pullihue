<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estudiante))
        Me.dgv_estudiante = New System.Windows.Forms.DataGridView()
        Me.gbx_estudiante = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_num_doc = New System.Windows.Forms.TextBox()
        Me.txt_apellido2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        CType(Me.dgv_estudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_estudiante.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_estudiante
        '
        Me.dgv_estudiante.AllowUserToAddRows = False
        Me.dgv_estudiante.AllowUserToDeleteRows = False
        Me.dgv_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estudiante.Location = New System.Drawing.Point(12, 229)
        Me.dgv_estudiante.Name = "dgv_estudiante"
        Me.dgv_estudiante.ReadOnly = True
        Me.dgv_estudiante.RowHeadersVisible = False
        Me.dgv_estudiante.Size = New System.Drawing.Size(616, 221)
        Me.dgv_estudiante.TabIndex = 1086
        '
        'gbx_estudiante
        '
        Me.gbx_estudiante.Controls.Add(Me.label7)
        Me.gbx_estudiante.Controls.Add(Me.txt_fecha)
        Me.gbx_estudiante.Controls.Add(Me.txt_telefono)
        Me.gbx_estudiante.Controls.Add(Me.label3)
        Me.gbx_estudiante.Controls.Add(Me.txt_direccion)
        Me.gbx_estudiante.Controls.Add(Me.label6)
        Me.gbx_estudiante.Controls.Add(Me.Label1)
        Me.gbx_estudiante.Controls.Add(Me.txt_num_doc)
        Me.gbx_estudiante.Controls.Add(Me.txt_apellido2)
        Me.gbx_estudiante.Controls.Add(Me.Label2)
        Me.gbx_estudiante.Controls.Add(Me.Label4)
        Me.gbx_estudiante.Controls.Add(Me.txt_apellido1)
        Me.gbx_estudiante.Controls.Add(Me.Label5)
        Me.gbx_estudiante.Controls.Add(Me.txt_nombre)
        Me.gbx_estudiante.Location = New System.Drawing.Point(12, 11)
        Me.gbx_estudiante.Name = "gbx_estudiante"
        Me.gbx_estudiante.Size = New System.Drawing.Size(616, 150)
        Me.gbx_estudiante.TabIndex = 1085
        Me.gbx_estudiante.TabStop = False
        Me.gbx_estudiante.Text = "Información del Estudiante"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(8, 90)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(115, 13)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA NACIMIENTO:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(129, 84)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(177, 20)
        Me.txt_fecha.TabIndex = 1095
        '
        'txt_telefono
        '
        Me.txt_telefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_telefono.Location = New System.Drawing.Point(109, 118)
        Me.txt_telefono.MaxLength = 15
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(197, 20)
        Me.txt_telefono.TabIndex = 1092
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(8, 121)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 13)
        Me.label3.TabIndex = 1093
        Me.label3.Text = "TELEFONO:"
        '
        'txt_direccion
        '
        Me.txt_direccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion.Location = New System.Drawing.Point(403, 84)
        Me.txt_direccion.MaxLength = 40
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(197, 20)
        Me.txt_direccion.TabIndex = 1091
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(322, 90)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(69, 13)
        Me.label6.TabIndex = 1094
        Me.label6.Text = "DIRECCION:"
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
        Me.txt_num_doc.Size = New System.Drawing.Size(197, 20)
        Me.txt_num_doc.TabIndex = 1083
        '
        'txt_apellido2
        '
        Me.txt_apellido2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_apellido2.Location = New System.Drawing.Point(403, 54)
        Me.txt_apellido2.MaxLength = 15
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(197, 20)
        Me.txt_apellido2.TabIndex = 1086
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1087
        Me.Label2.Text = "NOMBRES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 1088
        Me.Label4.Text = "2º APELLIDO:"
        '
        'txt_apellido1
        '
        Me.txt_apellido1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_apellido1.Location = New System.Drawing.Point(109, 54)
        Me.txt_apellido1.MaxLength = 40
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(197, 20)
        Me.txt_apellido1.TabIndex = 1085
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 1089
        Me.Label5.Text = "1º APELLIDO:"
        '
        'txt_nombre
        '
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(403, 23)
        Me.txt_nombre.MaxLength = 40
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(197, 20)
        Me.txt_nombre.TabIndex = 1084
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(396, 168)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(61, 52)
        Me.btn_editar.TabIndex = 1099
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
        Me.btn_cancelar.Location = New System.Drawing.Point(329, 168)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 52)
        Me.btn_cancelar.TabIndex = 1097
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(195, 168)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(61, 52)
        Me.btn_nuevo.TabIndex = 1098
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
        Me.btn_guardar.Location = New System.Drawing.Point(262, 168)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 52)
        Me.btn_guardar.TabIndex = 1084
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'frm_estudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 460)
        Me.Controls.Add(Me.dgv_estudiante)
        Me.Controls.Add(Me.gbx_estudiante)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_estudiante"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_estudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_estudiante.ResumeLayout(False)
        Me.gbx_estudiante.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgv_estudiante As System.Windows.Forms.DataGridView
    Private WithEvents gbx_estudiante As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
End Class
