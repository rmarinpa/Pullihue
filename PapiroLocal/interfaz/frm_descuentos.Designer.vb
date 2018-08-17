<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_descuentos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_descuentos))
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_representante = New System.Windows.Forms.ComboBox()
        Me.cmb_clasificacion = New System.Windows.Forms.ComboBox()
        Me.cmb_unidad = New System.Windows.Forms.ComboBox()
        Me.txt_precio_unitario = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PlandeCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Plan_de_Cuentas = New Constructora_FV.Plan_de_Cuentas()
        Me.cmb_cuenta_contable2 = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(352, 460)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 1108
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "CLASIFICACIÓN:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(84, 460)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 1105
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
        Me.dgv_curso.Size = New System.Drawing.Size(748, 468)
        Me.dgv_curso.TabIndex = 1104
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(263, 460)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 1117
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 171)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 1119
        Me.Label1.Text = "DESCRIPCIÓN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 1121
        Me.Label3.Text = "UNIDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 235)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 17)
        Me.Label4.TabIndex = 1123
        Me.Label4.Text = "PRECIO UNITARIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 267)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 1125
        Me.Label5.Text = "CANTIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 295)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 1127
        Me.Label6.Text = "TOTAL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 327)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 17)
        Me.Label7.TabIndex = 1129
        Me.Label7.Text = "CUENTA CONTABLE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(345, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(457, 31)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "DESCUENTOS/OTROS COBROS"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(441, 460)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 1132
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
        Me.btn_cancelar.Location = New System.Drawing.Point(173, 460)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 1133
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 363)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 1135
        Me.Label9.Text = "FECHA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 105)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 1139
        Me.Label11.Text = "NOMBRE:"
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
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(296, 356)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(345, 22)
        Me.txt_fecha.TabIndex = 1144
        '
        'cmb_representante
        '
        Me.cmb_representante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_representante.FormattingEnabled = True
        Me.cmb_representante.Location = New System.Drawing.Point(296, 101)
        Me.cmb_representante.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_representante.Name = "cmb_representante"
        Me.cmb_representante.Size = New System.Drawing.Size(345, 24)
        Me.cmb_representante.TabIndex = 1145
        '
        'cmb_clasificacion
        '
        Me.cmb_clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_clasificacion.FormattingEnabled = True
        Me.cmb_clasificacion.Items.AddRange(New Object() {"Descuentos", "Otros Cobros"})
        Me.cmb_clasificacion.Location = New System.Drawing.Point(296, 134)
        Me.cmb_clasificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_clasificacion.Name = "cmb_clasificacion"
        Me.cmb_clasificacion.Size = New System.Drawing.Size(345, 24)
        Me.cmb_clasificacion.TabIndex = 1146
        '
        'cmb_unidad
        '
        Me.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidad.FormattingEnabled = True
        Me.cmb_unidad.Items.AddRange(New Object() {"Gl", "Un.", "Viajes", "Mes"})
        Me.cmb_unidad.Location = New System.Drawing.Point(296, 198)
        Me.cmb_unidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_unidad.Name = "cmb_unidad"
        Me.cmb_unidad.Size = New System.Drawing.Size(345, 24)
        Me.cmb_unidad.TabIndex = 1147
        '
        'txt_precio_unitario
        '
        Me.txt_precio_unitario.Location = New System.Drawing.Point(296, 231)
        Me.txt_precio_unitario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_unitario.Name = "txt_precio_unitario"
        Me.txt_precio_unitario.Size = New System.Drawing.Size(345, 22)
        Me.txt_precio_unitario.TabIndex = 1148
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(296, 263)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(345, 22)
        Me.txt_cantidad.TabIndex = 1149
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(296, 292)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(345, 22)
        Me.txt_total.TabIndex = 1150
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(296, 167)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(345, 22)
        Me.txt_descripcion.TabIndex = 1152
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(296, 400)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(365, 22)
        Me.txt_nombre_obra.TabIndex = 1154
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(168, 404)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 17)
        Me.Label10.TabIndex = 1155
        Me.Label10.Text = "NOMBRE OBRA:"
        '
        'PlandeCuentasBindingSource
        '
        Me.PlandeCuentasBindingSource.DataSource = Me.Plan_de_Cuentas
        Me.PlandeCuentasBindingSource.Position = 0
        '
        'Plan_de_Cuentas
        '
        Me.Plan_de_Cuentas.DataSetName = "Plan_de_Cuentas"
        Me.Plan_de_Cuentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_cuenta_contable2
        '
        Me.cmb_cuenta_contable2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cuenta_contable2.FormattingEnabled = True
        Me.cmb_cuenta_contable2.Location = New System.Drawing.Point(296, 322)
        Me.cmb_cuenta_contable2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_cuenta_contable2.Name = "cmb_cuenta_contable2"
        Me.cmb_cuenta_contable2.Size = New System.Drawing.Size(345, 24)
        Me.cmb_cuenta_contable2.TabIndex = 1156
        '
        'frm_descuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.cmb_cuenta_contable2)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_precio_unitario)
        Me.Controls.Add(Me.cmb_unidad)
        Me.Controls.Add(Me.cmb_clasificacion)
        Me.Controls.Add(Me.cmb_representante)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_descuentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuentos/Otros Cobros"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_representante As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_unidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_precio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlandeCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Plan_de_Cuentas As Constructora_FV.Plan_de_Cuentas
    Friend WithEvents cmb_cuenta_contable2 As System.Windows.Forms.ComboBox
End Class
