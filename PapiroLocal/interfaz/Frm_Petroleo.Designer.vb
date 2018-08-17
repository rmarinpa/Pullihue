<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Petroleo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Petroleo))
        Me.dgv_Petroleo = New System.Windows.Forms.DataGridView()
        Me.gbx_Petroleo = New System.Windows.Forms.GroupBox()
        Me.txt_n_de_vale = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.ComboBox()
        Me.txt_litros_de_consumo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_vista = New System.Windows.Forms.Button()
        CType(Me.dgv_Petroleo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Petroleo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Petroleo
        '
        Me.dgv_Petroleo.AllowUserToAddRows = False
        Me.dgv_Petroleo.AllowUserToDeleteRows = False
        Me.dgv_Petroleo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Petroleo.Location = New System.Drawing.Point(592, 48)
        Me.dgv_Petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Petroleo.Name = "dgv_Petroleo"
        Me.dgv_Petroleo.ReadOnly = True
        Me.dgv_Petroleo.RowHeadersVisible = False
        Me.dgv_Petroleo.Size = New System.Drawing.Size(468, 279)
        Me.dgv_Petroleo.TabIndex = 1086
        '
        'gbx_Petroleo
        '
        Me.gbx_Petroleo.Controls.Add(Me.txt_n_de_vale)
        Me.gbx_Petroleo.Controls.Add(Me.Label2)
        Me.gbx_Petroleo.Controls.Add(Me.txt_codigo)
        Me.gbx_Petroleo.Controls.Add(Me.txt_litros_de_consumo)
        Me.gbx_Petroleo.Controls.Add(Me.Label9)
        Me.gbx_Petroleo.Controls.Add(Me.Label10)
        Me.gbx_Petroleo.Controls.Add(Me.label7)
        Me.gbx_Petroleo.Controls.Add(Me.txt_descripcion)
        Me.gbx_Petroleo.Controls.Add(Me.txt_fecha)
        Me.gbx_Petroleo.Controls.Add(Me.Label1)
        Me.gbx_Petroleo.Location = New System.Drawing.Point(8, 15)
        Me.gbx_Petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Petroleo.Name = "gbx_Petroleo"
        Me.gbx_Petroleo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Petroleo.Size = New System.Drawing.Size(576, 318)
        Me.gbx_Petroleo.TabIndex = 0
        Me.gbx_Petroleo.TabStop = False
        Me.gbx_Petroleo.Text = "Registro del Petróleo"
        '
        'txt_n_de_vale
        '
        Me.txt_n_de_vale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_n_de_vale.Location = New System.Drawing.Point(200, 38)
        Me.txt_n_de_vale.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_n_de_vale.MaxLength = 40
        Me.txt_n_de_vale.Name = "txt_n_de_vale"
        Me.txt_n_de_vale.Size = New System.Drawing.Size(351, 22)
        Me.txt_n_de_vale.TabIndex = 1105
        Me.txt_n_de_vale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 1104
        Me.Label2.Text = "N° DE VALE:"
        '
        'txt_codigo
        '
        Me.txt_codigo.FormattingEnabled = True
        Me.txt_codigo.Location = New System.Drawing.Point(201, 71)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(349, 24)
        Me.txt_codigo.TabIndex = 0
        '
        'txt_litros_de_consumo
        '
        Me.txt_litros_de_consumo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_litros_de_consumo.Location = New System.Drawing.Point(200, 142)
        Me.txt_litros_de_consumo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_litros_de_consumo.MaxLength = 40
        Me.txt_litros_de_consumo.Name = "txt_litros_de_consumo"
        Me.txt_litros_de_consumo.Size = New System.Drawing.Size(351, 22)
        Me.txt_litros_de_consumo.TabIndex = 2
        Me.txt_litros_de_consumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 145)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 17)
        Me.Label9.TabIndex = 1100
        Me.Label9.Text = "LITROS DE CONSUMO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(119, 238)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 17)
        Me.Label10.TabIndex = 1102
        Me.Label10.Text = "DESCRIPCIÓN MÁQUINA:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(20, 114)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 17)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion.Location = New System.Drawing.Point(24, 257)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.MaxLength = 20
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(376, 22)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(201, 107)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(349, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CÓDIGO MÁQUINA:"
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(355, 393)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 4
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
        Me.btn_cancelar.Location = New System.Drawing.Point(161, 393)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(265, 393)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 2
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
        Me.btn_guardar.Location = New System.Drawing.Point(72, 393)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1095, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 86)
        Me.PictureBox1.TabIndex = 1100
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1095, 94)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(271, 263)
        Me.PictureBox2.TabIndex = 1103
        Me.PictureBox2.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(444, 393)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 1133
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(688, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 31)
        Me.Label3.TabIndex = 1134
        Me.Label3.Text = "TABLA DE DATOS"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(714, 372)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(365, 22)
        Me.txt_nombre_obra.TabIndex = 1135
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 376)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 1136
        Me.Label4.Text = "NOMBRE OBRA:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(592, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(423, 41)
        Me.Button1.TabIndex = 1137
        Me.Button1.Text = "STORAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(609, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 23)
        Me.Button2.TabIndex = 1138
        Me.Button2.Text = "Actualizar Tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_vista
        '
        Me.btn_vista.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_vista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vista.Location = New System.Drawing.Point(900, 334)
        Me.btn_vista.Name = "btn_vista"
        Me.btn_vista.Size = New System.Drawing.Size(160, 31)
        Me.btn_vista.TabIndex = 1139
        Me.btn_vista.Text = "VISTA DE DATOS"
        Me.btn_vista.UseVisualStyleBackColor = False
        '
        'Frm_Petroleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.btn_vista)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_Petroleo)
        Me.Controls.Add(Me.gbx_Petroleo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Petroleo"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_Petroleo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Petroleo.ResumeLayout(False)
        Me.gbx_Petroleo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_Petroleo As System.Windows.Forms.DataGridView
    Private WithEvents gbx_Petroleo As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_litros_de_consumo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_n_de_vale As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_vista As System.Windows.Forms.Button
End Class
