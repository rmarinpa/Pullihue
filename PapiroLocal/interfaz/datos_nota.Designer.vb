<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datos_nota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(datos_nota))
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_comuna2 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_solicitado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_direccion_despacho2 = New System.Windows.Forms.TextBox()
        Me.dgv_venta2 = New System.Windows.Forms.DataGridView()
        Me.txt_direccion_despacho3 = New System.Windows.Forms.TextBox()
        Me.txt_comuna3 = New System.Windows.Forms.TextBox()
        Me.txt_direccion_despacho4 = New System.Windows.Forms.TextBox()
        Me.txt_comuna4 = New System.Windows.Forms.TextBox()
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.lbl_despacho = New System.Windows.Forms.Label()
        Me.lbl_otra = New System.Windows.Forms.Label()
        Me.rbtn_factura = New System.Windows.Forms.RadioButton()
        Me.rbtn_despacho = New System.Windows.Forms.RadioButton()
        Me.rbtn_otra = New System.Windows.Forms.RadioButton()
        Me.GB_despacho = New System.Windows.Forms.GroupBox()
        Me.chbRetiraCliente = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_venta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_despacho.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(58, 327)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 52)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_comuna2
        '
        Me.txt_comuna2.BackColor = System.Drawing.Color.White
        Me.txt_comuna2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_comuna2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna2.Location = New System.Drawing.Point(351, 41)
        Me.txt_comuna2.MaxLength = 40
        Me.txt_comuna2.Name = "txt_comuna2"
        Me.txt_comuna2.Size = New System.Drawing.Size(164, 19)
        Me.txt_comuna2.TabIndex = 1
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(26, 252)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(115, 13)
        Me.Label51.TabIndex = 1268
        Me.Label51.Text = "SOLICITADO POR:"
        '
        'txt_fecha
        '
        Me.txt_fecha.BackColor = System.Drawing.Color.White
        Me.txt_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Items.AddRange(New Object() {"Hoy", "Mañana"})
        Me.txt_fecha.Location = New System.Drawing.Point(144, 14)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(132, 21)
        Me.txt_fecha.TabIndex = 1266
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(38, 17)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(82, 13)
        Me.label7.TabIndex = 1265
        Me.label7.Text = "DESPACHAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1274
        Me.Label1.Text = "OBSERVACIONES:"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.Location = New System.Drawing.Point(337, 279)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(224, 63)
        Me.txt_observaciones.TabIndex = 3
        '
        'txt_solicitado
        '
        Me.txt_solicitado.BackColor = System.Drawing.Color.White
        Me.txt_solicitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_solicitado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_solicitado.Location = New System.Drawing.Point(29, 279)
        Me.txt_solicitado.MaxLength = 40
        Me.txt_solicitado.Name = "txt_solicitado"
        Me.txt_solicitado.Size = New System.Drawing.Size(247, 19)
        Me.txt_solicitado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1277
        Me.Label2.Text = "COMUNA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1278
        Me.Label3.Text = "DIRECCIÓN"
        '
        'txt_direccion_despacho2
        '
        Me.txt_direccion_despacho2.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion_despacho2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho2.Location = New System.Drawing.Point(156, 36)
        Me.txt_direccion_despacho2.MaxLength = 40
        Me.txt_direccion_despacho2.Multiline = True
        Me.txt_direccion_despacho2.Name = "txt_direccion_despacho2"
        Me.txt_direccion_despacho2.Size = New System.Drawing.Size(164, 41)
        Me.txt_direccion_despacho2.TabIndex = 0
        '
        'dgv_venta2
        '
        Me.dgv_venta2.AllowDrop = True
        Me.dgv_venta2.AllowUserToAddRows = False
        Me.dgv_venta2.AllowUserToOrderColumns = True
        Me.dgv_venta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_venta2.Location = New System.Drawing.Point(12, 12)
        Me.dgv_venta2.Name = "dgv_venta2"
        Me.dgv_venta2.ReadOnly = True
        Me.dgv_venta2.RowHeadersVisible = False
        Me.dgv_venta2.Size = New System.Drawing.Size(10, 10)
        Me.dgv_venta2.TabIndex = 1279
        Me.dgv_venta2.Visible = False
        '
        'txt_direccion_despacho3
        '
        Me.txt_direccion_despacho3.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion_despacho3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho3.Location = New System.Drawing.Point(156, 80)
        Me.txt_direccion_despacho3.MaxLength = 40
        Me.txt_direccion_despacho3.Multiline = True
        Me.txt_direccion_despacho3.Name = "txt_direccion_despacho3"
        Me.txt_direccion_despacho3.Size = New System.Drawing.Size(164, 41)
        Me.txt_direccion_despacho3.TabIndex = 1280
        '
        'txt_comuna3
        '
        Me.txt_comuna3.BackColor = System.Drawing.Color.White
        Me.txt_comuna3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_comuna3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna3.Location = New System.Drawing.Point(351, 88)
        Me.txt_comuna3.MaxLength = 40
        Me.txt_comuna3.Name = "txt_comuna3"
        Me.txt_comuna3.Size = New System.Drawing.Size(164, 19)
        Me.txt_comuna3.TabIndex = 1281
        '
        'txt_direccion_despacho4
        '
        Me.txt_direccion_despacho4.BackColor = System.Drawing.Color.White
        Me.txt_direccion_despacho4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_direccion_despacho4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho4.Location = New System.Drawing.Point(156, 127)
        Me.txt_direccion_despacho4.MaxLength = 40
        Me.txt_direccion_despacho4.Multiline = True
        Me.txt_direccion_despacho4.Name = "txt_direccion_despacho4"
        Me.txt_direccion_despacho4.Size = New System.Drawing.Size(164, 41)
        Me.txt_direccion_despacho4.TabIndex = 1282
        '
        'txt_comuna4
        '
        Me.txt_comuna4.BackColor = System.Drawing.Color.White
        Me.txt_comuna4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_comuna4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna4.Location = New System.Drawing.Point(351, 134)
        Me.txt_comuna4.MaxLength = 40
        Me.txt_comuna4.Multiline = True
        Me.txt_comuna4.Name = "txt_comuna4"
        Me.txt_comuna4.Size = New System.Drawing.Size(164, 19)
        Me.txt_comuna4.TabIndex = 1283
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_factura.Location = New System.Drawing.Point(38, 47)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(94, 13)
        Me.lbl_factura.TabIndex = 1284
        Me.lbl_factura.Text = "FACTURACIÓN"
        '
        'lbl_despacho
        '
        Me.lbl_despacho.AutoSize = True
        Me.lbl_despacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_despacho.Location = New System.Drawing.Point(38, 94)
        Me.lbl_despacho.Name = "lbl_despacho"
        Me.lbl_despacho.Size = New System.Drawing.Size(74, 13)
        Me.lbl_despacho.TabIndex = 1285
        Me.lbl_despacho.Text = "DESPACHO"
        '
        'lbl_otra
        '
        Me.lbl_otra.AutoSize = True
        Me.lbl_otra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_otra.Location = New System.Drawing.Point(38, 140)
        Me.lbl_otra.Name = "lbl_otra"
        Me.lbl_otra.Size = New System.Drawing.Size(41, 13)
        Me.lbl_otra.TabIndex = 1286
        Me.lbl_otra.Text = "OTRA"
        '
        'rbtn_factura
        '
        Me.rbtn_factura.AutoSize = True
        Me.rbtn_factura.Location = New System.Drawing.Point(17, 47)
        Me.rbtn_factura.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtn_factura.Name = "rbtn_factura"
        Me.rbtn_factura.Size = New System.Drawing.Size(14, 13)
        Me.rbtn_factura.TabIndex = 1287
        Me.rbtn_factura.TabStop = True
        Me.rbtn_factura.UseVisualStyleBackColor = True
        '
        'rbtn_despacho
        '
        Me.rbtn_despacho.AutoSize = True
        Me.rbtn_despacho.Location = New System.Drawing.Point(17, 94)
        Me.rbtn_despacho.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtn_despacho.Name = "rbtn_despacho"
        Me.rbtn_despacho.Size = New System.Drawing.Size(14, 13)
        Me.rbtn_despacho.TabIndex = 1288
        Me.rbtn_despacho.TabStop = True
        Me.rbtn_despacho.UseVisualStyleBackColor = True
        '
        'rbtn_otra
        '
        Me.rbtn_otra.AutoSize = True
        Me.rbtn_otra.Location = New System.Drawing.Point(17, 140)
        Me.rbtn_otra.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtn_otra.Name = "rbtn_otra"
        Me.rbtn_otra.Size = New System.Drawing.Size(14, 13)
        Me.rbtn_otra.TabIndex = 1289
        Me.rbtn_otra.TabStop = True
        Me.rbtn_otra.UseVisualStyleBackColor = True
        '
        'GB_despacho
        '
        Me.GB_despacho.Controls.Add(Me.Label3)
        Me.GB_despacho.Controls.Add(Me.rbtn_otra)
        Me.GB_despacho.Controls.Add(Me.txt_comuna2)
        Me.GB_despacho.Controls.Add(Me.rbtn_despacho)
        Me.GB_despacho.Controls.Add(Me.Label2)
        Me.GB_despacho.Controls.Add(Me.rbtn_factura)
        Me.GB_despacho.Controls.Add(Me.txt_direccion_despacho2)
        Me.GB_despacho.Controls.Add(Me.lbl_otra)
        Me.GB_despacho.Controls.Add(Me.txt_comuna3)
        Me.GB_despacho.Controls.Add(Me.lbl_despacho)
        Me.GB_despacho.Controls.Add(Me.txt_direccion_despacho3)
        Me.GB_despacho.Controls.Add(Me.lbl_factura)
        Me.GB_despacho.Controls.Add(Me.txt_comuna4)
        Me.GB_despacho.Controls.Add(Me.txt_direccion_despacho4)
        Me.GB_despacho.Location = New System.Drawing.Point(12, 41)
        Me.GB_despacho.Name = "GB_despacho"
        Me.GB_despacho.Size = New System.Drawing.Size(549, 186)
        Me.GB_despacho.TabIndex = 1290
        Me.GB_despacho.TabStop = False
        Me.GB_despacho.Text = "Despacho"
        '
        'chbRetiraCliente
        '
        Me.chbRetiraCliente.AutoSize = True
        Me.chbRetiraCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRetiraCliente.Location = New System.Drawing.Point(348, 15)
        Me.chbRetiraCliente.Name = "chbRetiraCliente"
        Me.chbRetiraCliente.Size = New System.Drawing.Size(119, 20)
        Me.chbRetiraCliente.TabIndex = 1291
        Me.chbRetiraCliente.Text = "Retira cliente"
        Me.chbRetiraCliente.UseVisualStyleBackColor = True
        '
        'datos_nota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 402)
        Me.Controls.Add(Me.chbRetiraCliente)
        Me.Controls.Add(Me.GB_despacho)
        Me.Controls.Add(Me.dgv_venta2)
        Me.Controls.Add(Me.txt_solicitado)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.btn_guardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "datos_nota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información Pedido"
        CType(Me.dgv_venta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_despacho.ResumeLayout(False)
        Me.GB_despacho.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_comuna2 As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.ComboBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_solicitado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_despacho2 As System.Windows.Forms.TextBox
    Private WithEvents dgv_venta2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_direccion_despacho3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_despacho4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_despacho As System.Windows.Forms.Label
    Friend WithEvents lbl_otra As System.Windows.Forms.Label
    Friend WithEvents rbtn_factura As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_despacho As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_otra As System.Windows.Forms.RadioButton
    Friend WithEvents GB_despacho As System.Windows.Forms.GroupBox
    Friend WithEvents chbRetiraCliente As System.Windows.Forms.CheckBox
End Class
