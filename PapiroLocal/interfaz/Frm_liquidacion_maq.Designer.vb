<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_liquidacion_maq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_liquidacion_maq))
        Me.dgv_Mov_Tierra = New System.Windows.Forms.DataGridView()
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_mes = New System.Windows.Forms.TextBox()
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Mov_Tierra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Mov_Tierra
        '
        Me.dgv_Mov_Tierra.AllowUserToAddRows = False
        Me.dgv_Mov_Tierra.AllowUserToDeleteRows = False
        Me.dgv_Mov_Tierra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Mov_Tierra.Location = New System.Drawing.Point(471, 50)
        Me.dgv_Mov_Tierra.Name = "dgv_Mov_Tierra"
        Me.dgv_Mov_Tierra.ReadOnly = True
        Me.dgv_Mov_Tierra.RowHeadersVisible = False
        Me.dgv_Mov_Tierra.Size = New System.Drawing.Size(363, 235)
        Me.dgv_Mov_Tierra.TabIndex = 1086
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_nombre_obra)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label16)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_codigo)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_mes)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label4)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label10)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_descripcion)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label7)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_fecha)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(12, 11)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(453, 288)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Liquidación de Maquinaria"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(165, 231)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(275, 20)
        Me.txt_nombre_obra.TabIndex = 1137
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(69, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "NOMBRE OBRA:"
        '
        'txt_codigo
        '
        Me.txt_codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_codigo.FormattingEnabled = True
        Me.txt_codigo.Location = New System.Drawing.Point(159, 39)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(254, 21)
        Me.txt_codigo.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 1102
        Me.Label10.Text = "DESCRIPCIÓN MÁQUINA:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion.Location = New System.Drawing.Point(165, 205)
        Me.txt_descripcion.MaxLength = 20
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(275, 20)
        Me.txt_descripcion.TabIndex = 9
        Me.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(83, 72)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(45, 13)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(159, 65)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(254, 20)
        Me.txt_fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CÓDIGO MÁQUINA:"
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(79, 305)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(61, 52)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(280, 305)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 52)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 305)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(61, 52)
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
        Me.btn_guardar.Location = New System.Drawing.Point(213, 305)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 52)
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
        Me.btnEliminar.Location = New System.Drawing.Point(146, 305)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 52)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(558, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 29)
        Me.Label11.TabIndex = 1134
        Me.Label11.Text = "Tabla de Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 1088
        Me.Label4.Text = "MES:"
        '
        'txt_mes
        '
        Me.txt_mes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_mes.Location = New System.Drawing.Point(159, 91)
        Me.txt_mes.MaxLength = 15
        Me.txt_mes.Name = "txt_mes"
        Me.txt_mes.Size = New System.Drawing.Size(254, 20)
        Me.txt_mes.TabIndex = 6
        Me.txt_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_liquidacion_maq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 531)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_Mov_Tierra)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_liquidacion_maq"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_Mov_Tierra As System.Windows.Forms.DataGridView
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_mes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
