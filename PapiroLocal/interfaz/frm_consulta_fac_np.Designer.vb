<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta_np
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta_np))
        Me.TabContenedor = New System.Windows.Forms.TabControl()
        Me.tp_notasPedidos = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_suma_pedido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_suma_dia = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbt_pedido = New System.Windows.Forms.RadioButton()
        Me.rbt_factura = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_fechaIn = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_actualizarNotasPedidos = New System.Windows.Forms.Button()
        Me.cmb_fechaOut = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.PictureBox()
        Me.dgv_notasPedidos = New System.Windows.Forms.DataGridView()
        Me.tp_pedidosPendientes = New System.Windows.Forms.TabPage()
        Me.btn_actualizarPendientes = New System.Windows.Forms.Button()
        Me.dgv_pendientes = New System.Windows.Forms.DataGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.dgv_pedidoDetalles = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_totalNeto = New System.Windows.Forms.TextBox()
        Me.TabContenedor.SuspendLayout()
        Me.tp_notasPedidos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_notasPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_pedidosPendientes.SuspendLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pedidoDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabContenedor
        '
        Me.TabContenedor.Controls.Add(Me.tp_notasPedidos)
        Me.TabContenedor.Controls.Add(Me.tp_pedidosPendientes)
        Me.TabContenedor.Location = New System.Drawing.Point(13, 12)
        Me.TabContenedor.Name = "TabContenedor"
        Me.TabContenedor.SelectedIndex = 0
        Me.TabContenedor.Size = New System.Drawing.Size(845, 491)
        Me.TabContenedor.TabIndex = 0
        '
        'tp_notasPedidos
        '
        Me.tp_notasPedidos.Controls.Add(Me.Label7)
        Me.tp_notasPedidos.Controls.Add(Me.txt_suma_pedido)
        Me.tp_notasPedidos.Controls.Add(Me.Label8)
        Me.tp_notasPedidos.Controls.Add(Me.txt_suma_dia)
        Me.tp_notasPedidos.Controls.Add(Me.GroupBox2)
        Me.tp_notasPedidos.Controls.Add(Me.dgv_notasPedidos)
        Me.tp_notasPedidos.Location = New System.Drawing.Point(4, 22)
        Me.tp_notasPedidos.Name = "tp_notasPedidos"
        Me.tp_notasPedidos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_notasPedidos.Size = New System.Drawing.Size(837, 465)
        Me.tp_notasPedidos.TabIndex = 0
        Me.tp_notasPedidos.Text = "Notas de Pedidos"
        Me.tp_notasPedidos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 339)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 1263
        Me.Label7.Text = "TOTAL FACTURADO"
        '
        'txt_suma_pedido
        '
        Me.txt_suma_pedido.Location = New System.Drawing.Point(204, 338)
        Me.txt_suma_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_suma_pedido.Name = "txt_suma_pedido"
        Me.txt_suma_pedido.ReadOnly = True
        Me.txt_suma_pedido.Size = New System.Drawing.Size(80, 20)
        Me.txt_suma_pedido.TabIndex = 1262
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 339)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 17)
        Me.Label8.TabIndex = 1261
        Me.Label8.Text = "TOTAL NOTAS DE PEDIDO"
        '
        'txt_suma_dia
        '
        Me.txt_suma_dia.Location = New System.Drawing.Point(506, 338)
        Me.txt_suma_dia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_suma_dia.Name = "txt_suma_dia"
        Me.txt_suma_dia.ReadOnly = True
        Me.txt_suma_dia.Size = New System.Drawing.Size(80, 20)
        Me.txt_suma_dia.TabIndex = 1260
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt_pedido)
        Me.GroupBox2.Controls.Add(Me.rbt_factura)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmb_fechaIn)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_buscar)
        Me.GroupBox2.Controls.Add(Me.btn_actualizarNotasPedidos)
        Me.GroupBox2.Controls.Add(Me.cmb_fechaOut)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_buscar)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 375)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(707, 81)
        Me.GroupBox2.TabIndex = 1235
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios de Búsqueda"
        '
        'rbt_pedido
        '
        Me.rbt_pedido.AutoSize = True
        Me.rbt_pedido.Location = New System.Drawing.Point(553, 28)
        Me.rbt_pedido.Name = "rbt_pedido"
        Me.rbt_pedido.Size = New System.Drawing.Size(58, 17)
        Me.rbt_pedido.TabIndex = 1237
        Me.rbt_pedido.Text = "Pedido"
        Me.rbt_pedido.UseVisualStyleBackColor = True
        '
        'rbt_factura
        '
        Me.rbt_factura.AutoSize = True
        Me.rbt_factura.Checked = True
        Me.rbt_factura.Location = New System.Drawing.Point(457, 28)
        Me.rbt_factura.Name = "rbt_factura"
        Me.rbt_factura.Size = New System.Drawing.Size(61, 17)
        Me.rbt_factura.TabIndex = 1236
        Me.rbt_factura.TabStop = True
        Me.rbt_factura.Text = "Factura"
        Me.rbt_factura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1235
        Me.Label1.Text = "FECHA FINAL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(225, 28)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 1234
        Me.Label13.Text = "FECHA INICIAL:"
        '
        'cmb_fechaIn
        '
        Me.cmb_fechaIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fechaIn.Location = New System.Drawing.Point(331, 28)
        Me.cmb_fechaIn.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_fechaIn.Name = "cmb_fechaIn"
        Me.cmb_fechaIn.Size = New System.Drawing.Size(82, 20)
        Me.cmb_fechaIn.TabIndex = 1233
        Me.cmb_fechaIn.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(205, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 13)
        Me.Label10.TabIndex = 1232
        Me.Label10.Text = "SELECCIÓN DE FECHA DE PEDIDOS"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(435, 49)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(199, 20)
        Me.txt_buscar.TabIndex = 1226
        '
        'btn_actualizarNotasPedidos
        '
        Me.btn_actualizarNotasPedidos.BackColor = System.Drawing.Color.Blue
        Me.btn_actualizarNotasPedidos.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarNotasPedidos.Location = New System.Drawing.Point(3, 28)
        Me.btn_actualizarNotasPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_actualizarNotasPedidos.Name = "btn_actualizarNotasPedidos"
        Me.btn_actualizarNotasPedidos.Size = New System.Drawing.Size(177, 41)
        Me.btn_actualizarNotasPedidos.TabIndex = 1214
        Me.btn_actualizarNotasPedidos.Text = "Actualizar"
        Me.btn_actualizarNotasPedidos.UseVisualStyleBackColor = False
        '
        'cmb_fechaOut
        '
        Me.cmb_fechaOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fechaOut.Location = New System.Drawing.Point(331, 51)
        Me.cmb_fechaOut.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_fechaOut.Name = "cmb_fechaOut"
        Me.cmb_fechaOut.Size = New System.Drawing.Size(82, 20)
        Me.cmb_fechaOut.TabIndex = 1215
        Me.cmb_fechaOut.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(454, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1217
        Me.Label2.Text = "BUSCAR POR:"
        Me.Label2.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(647, 47)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(29, 24)
        Me.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buscar.TabIndex = 1229
        Me.btn_buscar.TabStop = False
        '
        'dgv_notasPedidos
        '
        Me.dgv_notasPedidos.AllowUserToAddRows = False
        Me.dgv_notasPedidos.AllowUserToDeleteRows = False
        Me.dgv_notasPedidos.AllowUserToResizeRows = False
        Me.dgv_notasPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_notasPedidos.Location = New System.Drawing.Point(3, 6)
        Me.dgv_notasPedidos.MultiSelect = False
        Me.dgv_notasPedidos.Name = "dgv_notasPedidos"
        Me.dgv_notasPedidos.ReadOnly = True
        Me.dgv_notasPedidos.RowHeadersVisible = False
        Me.dgv_notasPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_notasPedidos.Size = New System.Drawing.Size(828, 312)
        Me.dgv_notasPedidos.TabIndex = 0
        '
        'tp_pedidosPendientes
        '
        Me.tp_pedidosPendientes.Controls.Add(Me.btn_actualizarPendientes)
        Me.tp_pedidosPendientes.Controls.Add(Me.dgv_pendientes)
        Me.tp_pedidosPendientes.Location = New System.Drawing.Point(4, 22)
        Me.tp_pedidosPendientes.Name = "tp_pedidosPendientes"
        Me.tp_pedidosPendientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_pedidosPendientes.Size = New System.Drawing.Size(837, 465)
        Me.tp_pedidosPendientes.TabIndex = 1
        Me.tp_pedidosPendientes.Text = "Pedidos Pendientes"
        Me.tp_pedidosPendientes.UseVisualStyleBackColor = True
        '
        'btn_actualizarPendientes
        '
        Me.btn_actualizarPendientes.Location = New System.Drawing.Point(313, 372)
        Me.btn_actualizarPendientes.Name = "btn_actualizarPendientes"
        Me.btn_actualizarPendientes.Size = New System.Drawing.Size(168, 39)
        Me.btn_actualizarPendientes.TabIndex = 1
        Me.btn_actualizarPendientes.Text = "Actualizar"
        Me.btn_actualizarPendientes.UseVisualStyleBackColor = True
        '
        'dgv_pendientes
        '
        Me.dgv_pendientes.AllowUserToAddRows = False
        Me.dgv_pendientes.AllowUserToDeleteRows = False
        Me.dgv_pendientes.AllowUserToResizeColumns = False
        Me.dgv_pendientes.AllowUserToResizeRows = False
        Me.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendientes.Location = New System.Drawing.Point(4, 7)
        Me.dgv_pendientes.Name = "dgv_pendientes"
        Me.dgv_pendientes.ReadOnly = True
        Me.dgv_pendientes.RowHeadersVisible = False
        Me.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pendientes.Size = New System.Drawing.Size(827, 302)
        Me.dgv_pendientes.TabIndex = 0
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(316, 508)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(147, 38)
        Me.btn_salir.TabIndex = 1191
        Me.btn_salir.Text = "Cerrar"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'dgv_pedidoDetalles
        '
        Me.dgv_pedidoDetalles.AllowUserToAddRows = False
        Me.dgv_pedidoDetalles.AllowUserToDeleteRows = False
        Me.dgv_pedidoDetalles.AllowUserToResizeRows = False
        Me.dgv_pedidoDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidoDetalles.Location = New System.Drawing.Point(864, 34)
        Me.dgv_pedidoDetalles.MultiSelect = False
        Me.dgv_pedidoDetalles.Name = "dgv_pedidoDetalles"
        Me.dgv_pedidoDetalles.ReadOnly = True
        Me.dgv_pedidoDetalles.RowHeadersVisible = False
        Me.dgv_pedidoDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pedidoDetalles.Size = New System.Drawing.Size(367, 224)
        Me.dgv_pedidoDetalles.TabIndex = 1265
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(961, 333)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 1271
        Me.Label11.Text = "TOTAL"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(1059, 332)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(96, 20)
        Me.txt_total.TabIndex = 1270
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(1059, 309)
        Me.txt_iva.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.ReadOnly = True
        Me.txt_iva.Size = New System.Drawing.Size(96, 20)
        Me.txt_iva.TabIndex = 1269
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(961, 310)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 17)
        Me.Label12.TabIndex = 1268
        Me.Label12.Text = "IVA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(961, 288)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 17)
        Me.Label14.TabIndex = 1267
        Me.Label14.Text = "MONTO NETO"
        '
        'txt_totalNeto
        '
        Me.txt_totalNeto.Location = New System.Drawing.Point(1059, 287)
        Me.txt_totalNeto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totalNeto.Name = "txt_totalNeto"
        Me.txt_totalNeto.ReadOnly = True
        Me.txt_totalNeto.Size = New System.Drawing.Size(96, 20)
        Me.txt_totalNeto.TabIndex = 1266
        '
        'frm_consulta_np
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 551)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_totalNeto)
        Me.Controls.Add(Me.dgv_pedidoDetalles)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.TabContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_consulta_np"
        Me.Text = "Consultar Notas de Pedido"
        Me.TabContenedor.ResumeLayout(False)
        Me.tp_notasPedidos.ResumeLayout(False)
        Me.tp_notasPedidos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_notasPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_pedidosPendientes.ResumeLayout(False)
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pedidoDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabContenedor As System.Windows.Forms.TabControl
    Friend WithEvents tp_notasPedidos As System.Windows.Forms.TabPage
    Friend WithEvents tp_pedidosPendientes As System.Windows.Forms.TabPage
    Friend WithEvents dgv_notasPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_actualizarPendientes As System.Windows.Forms.Button
    Friend WithEvents dgv_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_fechaIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_actualizarNotasPedidos As System.Windows.Forms.Button
    Friend WithEvents cmb_fechaOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_suma_pedido As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_suma_dia As System.Windows.Forms.TextBox
    Friend WithEvents dgv_pedidoDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents rbt_factura As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_totalNeto As System.Windows.Forms.TextBox
End Class
