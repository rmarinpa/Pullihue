<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Compra_Petroleo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Compra_Petroleo))
        Me.dgv_Petroleo = New System.Windows.Forms.DataGridView()
        Me.gbx_Petroleo = New System.Windows.Forms.GroupBox()
        Me.txt_N_factura = New System.Windows.Forms.TextBox()
        Me.txt_litros = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbx_valores_compra = New System.Windows.Forms.GroupBox()
        Me.txt_precio_base = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_ief = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_iev = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbx_total_compra = New System.Windows.Forms.GroupBox()
        Me.txt_total_compra = New System.Windows.Forms.TextBox()
        Me.txt_total_iva = New System.Windows.Forms.TextBox()
        Me.txt_total_ief = New System.Windows.Forms.TextBox()
        Me.txt_total_neto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_total_iev = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgv_Petroleo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Petroleo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_valores_compra.SuspendLayout()
        Me.gbx_total_compra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Petroleo
        '
        Me.dgv_Petroleo.AllowUserToAddRows = False
        Me.dgv_Petroleo.AllowUserToDeleteRows = False
        Me.dgv_Petroleo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Petroleo.Location = New System.Drawing.Point(603, 91)
        Me.dgv_Petroleo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_Petroleo.Name = "dgv_Petroleo"
        Me.dgv_Petroleo.ReadOnly = True
        Me.dgv_Petroleo.RowHeadersVisible = False
        Me.dgv_Petroleo.Size = New System.Drawing.Size(576, 206)
        Me.dgv_Petroleo.TabIndex = 1086
        '
        'gbx_Petroleo
        '
        Me.gbx_Petroleo.Controls.Add(Me.txt_N_factura)
        Me.gbx_Petroleo.Controls.Add(Me.txt_litros)
        Me.gbx_Petroleo.Controls.Add(Me.txt_rut)
        Me.gbx_Petroleo.Controls.Add(Me.Label4)
        Me.gbx_Petroleo.Controls.Add(Me.Label2)
        Me.gbx_Petroleo.Controls.Add(Me.txt_proveedor)
        Me.gbx_Petroleo.Controls.Add(Me.Label9)
        Me.gbx_Petroleo.Controls.Add(Me.label7)
        Me.gbx_Petroleo.Controls.Add(Me.txt_fecha)
        Me.gbx_Petroleo.Controls.Add(Me.Label1)
        Me.gbx_Petroleo.Location = New System.Drawing.Point(7, 15)
        Me.gbx_Petroleo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_Petroleo.Name = "gbx_Petroleo"
        Me.gbx_Petroleo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_Petroleo.Size = New System.Drawing.Size(576, 282)
        Me.gbx_Petroleo.TabIndex = 0
        Me.gbx_Petroleo.TabStop = False
        Me.gbx_Petroleo.Text = "Registro del Petróleo"
        '
        'txt_N_factura
        '
        Me.txt_N_factura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_N_factura.Location = New System.Drawing.Point(200, 37)
        Me.txt_N_factura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_N_factura.MaxLength = 40
        Me.txt_N_factura.Name = "txt_N_factura"
        Me.txt_N_factura.Size = New System.Drawing.Size(351, 22)
        Me.txt_N_factura.TabIndex = 0
        Me.txt_N_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_litros
        '
        Me.txt_litros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_litros.Location = New System.Drawing.Point(200, 170)
        Me.txt_litros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_litros.MaxLength = 40
        Me.txt_litros.Name = "txt_litros"
        Me.txt_litros.Size = New System.Drawing.Size(351, 22)
        Me.txt_litros.TabIndex = 4
        Me.txt_litros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_rut
        '
        Me.txt_rut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_rut.Location = New System.Drawing.Point(200, 137)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_rut.MaxLength = 40
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(351, 22)
        Me.txt_rut.TabIndex = 3
        Me.txt_rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 1106
        Me.Label4.Text = "LITROS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1104
        Me.Label2.Text = "RUT:"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_proveedor.Location = New System.Drawing.Point(200, 103)
        Me.txt_proveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_proveedor.MaxLength = 40
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(351, 22)
        Me.txt_proveedor.TabIndex = 2
        Me.txt_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 107)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 17)
        Me.Label9.TabIndex = 1100
        Me.Label9.Text = "PROVEEDOR:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(20, 76)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 17)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(201, 69)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(349, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "N° DE FACTURA:"
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(352, 518)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(159, 518)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(263, 518)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 3
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
        Me.btn_guardar.Location = New System.Drawing.Point(69, 518)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.PictureBox1.Location = New System.Drawing.Point(731, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 86)
        Me.PictureBox1.TabIndex = 1100
        Me.PictureBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(441, 518)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'gbx_valores_compra
        '
        Me.gbx_valores_compra.Controls.Add(Me.txt_precio_base)
        Me.gbx_valores_compra.Controls.Add(Me.txt_descuento)
        Me.gbx_valores_compra.Controls.Add(Me.txt_ief)
        Me.gbx_valores_compra.Controls.Add(Me.txt_precio)
        Me.gbx_valores_compra.Controls.Add(Me.Label10)
        Me.gbx_valores_compra.Controls.Add(Me.Label5)
        Me.gbx_valores_compra.Controls.Add(Me.Label6)
        Me.gbx_valores_compra.Controls.Add(Me.txt_iev)
        Me.gbx_valores_compra.Controls.Add(Me.Label8)
        Me.gbx_valores_compra.Controls.Add(Me.Label11)
        Me.gbx_valores_compra.Location = New System.Drawing.Point(7, 304)
        Me.gbx_valores_compra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_valores_compra.Name = "gbx_valores_compra"
        Me.gbx_valores_compra.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_valores_compra.Size = New System.Drawing.Size(576, 207)
        Me.gbx_valores_compra.TabIndex = 0
        Me.gbx_valores_compra.TabStop = False
        Me.gbx_valores_compra.Text = "Valores de Compra"
        '
        'txt_precio_base
        '
        Me.txt_precio_base.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_precio_base.Location = New System.Drawing.Point(200, 162)
        Me.txt_precio_base.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precio_base.MaxLength = 40
        Me.txt_precio_base.Name = "txt_precio_base"
        Me.txt_precio_base.Size = New System.Drawing.Size(351, 22)
        Me.txt_precio_base.TabIndex = 4
        Me.txt_precio_base.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_descuento
        '
        Me.txt_descuento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descuento.Location = New System.Drawing.Point(200, 134)
        Me.txt_descuento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_descuento.MaxLength = 40
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(351, 22)
        Me.txt_descuento.TabIndex = 3
        Me.txt_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ief
        '
        Me.txt_ief.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_ief.Location = New System.Drawing.Point(200, 101)
        Me.txt_ief.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ief.MaxLength = 40
        Me.txt_ief.Name = "txt_ief"
        Me.txt_ief.Size = New System.Drawing.Size(351, 22)
        Me.txt_ief.TabIndex = 2
        Me.txt_ief.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_precio
        '
        Me.txt_precio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_precio.Location = New System.Drawing.Point(200, 32)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precio.MaxLength = 40
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(351, 22)
        Me.txt_precio.TabIndex = 0
        Me.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 171)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 17)
        Me.Label10.TabIndex = 1108
        Me.Label10.Text = "PRECIO BASE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 1106
        Me.Label5.Text = "DESCUENTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 1104
        Me.Label6.Text = "IEF:"
        '
        'txt_iev
        '
        Me.txt_iev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_iev.Location = New System.Drawing.Point(200, 68)
        Me.txt_iev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_iev.MaxLength = 40
        Me.txt_iev.Name = "txt_iev"
        Me.txt_iev.Size = New System.Drawing.Size(351, 22)
        Me.txt_iev.TabIndex = 1
        Me.txt_iev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 71)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 17)
        Me.Label8.TabIndex = 1100
        Me.Label8.Text = "IEV:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 17)
        Me.Label11.TabIndex = 1090
        Me.Label11.Text = "PRECIO:"
        '
        'gbx_total_compra
        '
        Me.gbx_total_compra.Controls.Add(Me.txt_total_compra)
        Me.gbx_total_compra.Controls.Add(Me.txt_total_iva)
        Me.gbx_total_compra.Controls.Add(Me.txt_total_ief)
        Me.gbx_total_compra.Controls.Add(Me.txt_total_neto)
        Me.gbx_total_compra.Controls.Add(Me.Label3)
        Me.gbx_total_compra.Controls.Add(Me.Label12)
        Me.gbx_total_compra.Controls.Add(Me.Label13)
        Me.gbx_total_compra.Controls.Add(Me.txt_total_iev)
        Me.gbx_total_compra.Controls.Add(Me.Label14)
        Me.gbx_total_compra.Controls.Add(Me.Label15)
        Me.gbx_total_compra.Location = New System.Drawing.Point(603, 304)
        Me.gbx_total_compra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_total_compra.Name = "gbx_total_compra"
        Me.gbx_total_compra.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_total_compra.Size = New System.Drawing.Size(576, 207)
        Me.gbx_total_compra.TabIndex = 1136
        Me.gbx_total_compra.TabStop = False
        Me.gbx_total_compra.Text = "Total Compra:"
        '
        'txt_total_compra
        '
        Me.txt_total_compra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_compra.Location = New System.Drawing.Point(200, 167)
        Me.txt_total_compra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_compra.MaxLength = 40
        Me.txt_total_compra.Name = "txt_total_compra"
        Me.txt_total_compra.Size = New System.Drawing.Size(351, 22)
        Me.txt_total_compra.TabIndex = 1112
        Me.txt_total_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_total_iva
        '
        Me.txt_total_iva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_iva.Location = New System.Drawing.Point(199, 134)
        Me.txt_total_iva.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_iva.MaxLength = 40
        Me.txt_total_iva.Name = "txt_total_iva"
        Me.txt_total_iva.Size = New System.Drawing.Size(351, 22)
        Me.txt_total_iva.TabIndex = 1111
        Me.txt_total_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_total_ief
        '
        Me.txt_total_ief.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_ief.Location = New System.Drawing.Point(199, 102)
        Me.txt_total_ief.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_ief.MaxLength = 40
        Me.txt_total_ief.Name = "txt_total_ief"
        Me.txt_total_ief.Size = New System.Drawing.Size(351, 22)
        Me.txt_total_ief.TabIndex = 1110
        Me.txt_total_ief.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_total_neto
        '
        Me.txt_total_neto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_neto.Location = New System.Drawing.Point(199, 37)
        Me.txt_total_neto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_neto.MaxLength = 40
        Me.txt_total_neto.Name = "txt_total_neto"
        Me.txt_total_neto.Size = New System.Drawing.Size(351, 22)
        Me.txt_total_neto.TabIndex = 1109
        Me.txt_total_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 1108
        Me.Label3.Text = "TOTAL COMPRA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 138)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 1106
        Me.Label12.Text = "TOTAL IVA:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 105)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 17)
        Me.Label13.TabIndex = 1104
        Me.Label13.Text = "TOTAL IEF:"
        '
        'txt_total_iev
        '
        Me.txt_total_iev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total_iev.Location = New System.Drawing.Point(199, 68)
        Me.txt_total_iev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_iev.MaxLength = 40
        Me.txt_total_iev.Name = "txt_total_iev"
        Me.txt_total_iev.Size = New System.Drawing.Size(351, 22)
        Me.txt_total_iev.TabIndex = 2
        Me.txt_total_iev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 71)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 17)
        Me.Label14.TabIndex = 1100
        Me.Label14.Text = "TOTAL IEV:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 41)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 17)
        Me.Label15.TabIndex = 1090
        Me.Label15.Text = "TOTAL NETO:"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(731, 518)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(365, 22)
        Me.txt_nombre_obra.TabIndex = 1137
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(603, 522)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 17)
        Me.Label16.TabIndex = 1138
        Me.Label16.Text = "NOMBRE OBRA:"
        '
        'Frm_Compra_Petroleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 642)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.gbx_total_compra)
        Me.Controls.Add(Me.gbx_valores_compra)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_Petroleo)
        Me.Controls.Add(Me.gbx_Petroleo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm_Compra_Petroleo"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_Petroleo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Petroleo.ResumeLayout(False)
        Me.gbx_Petroleo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_valores_compra.ResumeLayout(False)
        Me.gbx_valores_compra.PerformLayout()
        Me.gbx_total_compra.ResumeLayout(False)
        Me.gbx_total_compra.PerformLayout()
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
    Friend WithEvents txt_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents gbx_valores_compra As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_iev As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents gbx_total_compra As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_total_iev As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_N_factura As System.Windows.Forms.TextBox
    Friend WithEvents txt_litros As System.Windows.Forms.TextBox
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio_base As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txt_ief As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_compra As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_iva As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_ief As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_neto As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
