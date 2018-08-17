<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_registro_subcontratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_registro_subcontratos))
        Me.dgv_Mov_Tierra = New System.Windows.Forms.DataGridView()
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_glosa = New System.Windows.Forms.ComboBox()
        Me.cmb_codigo_subcontrato = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv_Mov_Tierra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Mov_Tierra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Mov_Tierra
        '
        Me.dgv_Mov_Tierra.AllowUserToAddRows = False
        Me.dgv_Mov_Tierra.AllowUserToDeleteRows = False
        Me.dgv_Mov_Tierra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Mov_Tierra.Location = New System.Drawing.Point(580, 35)
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
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label12)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_glosa)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_codigo_subcontrato)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label7)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_fecha)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_cantidad)
        Me.gbx_Mov_Tierra.Controls.Add(Me.label3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(16, 14)
        Me.gbx_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(556, 238)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Registro de Avance Subcontrato"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(201, 199)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(337, 22)
        Me.txt_nombre_obra.TabIndex = 1137
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 204)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 17)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "NOMBRE OBRA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 68)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 1107
        Me.Label12.Text = "GLOSA:"
        '
        'cmb_glosa
        '
        Me.cmb_glosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_glosa.FormattingEnabled = True
        Me.cmb_glosa.Items.AddRange(New Object() {"Dia", "Noche"})
        Me.cmb_glosa.Location = New System.Drawing.Point(201, 65)
        Me.cmb_glosa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_glosa.Name = "cmb_glosa"
        Me.cmb_glosa.Size = New System.Drawing.Size(337, 24)
        Me.cmb_glosa.TabIndex = 6
        '
        'cmb_codigo_subcontrato
        '
        Me.cmb_codigo_subcontrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_codigo_subcontrato.FormattingEnabled = True
        Me.cmb_codigo_subcontrato.Location = New System.Drawing.Point(201, 33)
        Me.cmb_codigo_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_codigo_subcontrato.Name = "cmb_codigo_subcontrato"
        Me.cmb_codigo_subcontrato.Size = New System.Drawing.Size(337, 24)
        Me.cmb_codigo_subcontrato.TabIndex = 0
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(21, 133)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 17)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(201, 128)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(337, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'txt_cantidad
        '
        Me.txt_cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_cantidad.Location = New System.Drawing.Point(202, 98)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad.MaxLength = 15
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(337, 22)
        Me.txt_cantidad.TabIndex = 3
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(21, 101)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(81, 17)
        Me.label3.TabIndex = 1093
        Me.label3.Text = "CANTIDAD:"
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
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(112, 283)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(380, 283)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(23, 283)
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
        Me.btn_guardar.Location = New System.Drawing.Point(291, 283)
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
        Me.btnEliminar.Location = New System.Drawing.Point(202, 283)
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
        Me.Label11.Location = New System.Drawing.Point(721, -5)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 36)
        Me.Label11.TabIndex = 1134
        Me.Label11.Text = "Tabla de Datos"
        '
        'Frm_registro_subcontratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1421, 654)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_Mov_Tierra)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_registro_subcontratos"
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
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_codigo_subcontrato As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_glosa As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
