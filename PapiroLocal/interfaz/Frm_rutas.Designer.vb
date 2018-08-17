<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_rutas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_rutas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_autorizacion = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_pedido = New System.Windows.Forms.TextBox()
        Me.txt_factura = New System.Windows.Forms.TextBox()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.btn_pedido = New System.Windows.Forms.Button()
        Me.btn_factura = New System.Windows.Forms.Button()
        Me.btn_ruta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.btn_fecha = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_retiros = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_retiro = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.chb_fecha = New System.Windows.Forms.CheckBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_autorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_retiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONSULTAR DESPACHO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(563, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'dgv_autorizacion
        '
        Me.dgv_autorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_autorizacion.Location = New System.Drawing.Point(6, 30)
        Me.dgv_autorizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_autorizacion.Name = "dgv_autorizacion"
        Me.dgv_autorizacion.RowTemplate.Height = 24
        Me.dgv_autorizacion.Size = New System.Drawing.Size(1120, 212)
        Me.dgv_autorizacion.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 8)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "CONSULTA DESPACHOS"
        '
        'txt_pedido
        '
        Me.txt_pedido.Location = New System.Drawing.Point(114, 95)
        Me.txt_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pedido.Name = "txt_pedido"
        Me.txt_pedido.Size = New System.Drawing.Size(138, 20)
        Me.txt_pedido.TabIndex = 72
        '
        'txt_factura
        '
        Me.txt_factura.Location = New System.Drawing.Point(114, 121)
        Me.txt_factura.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(138, 20)
        Me.txt_factura.TabIndex = 73
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(443, 106)
        Me.txt_ruta.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(93, 20)
        Me.txt_ruta.TabIndex = 74
        '
        'btn_pedido
        '
        Me.btn_pedido.BackColor = System.Drawing.Color.LightYellow
        Me.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_pedido.Location = New System.Drawing.Point(256, 95)
        Me.btn_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedido.Name = "btn_pedido"
        Me.btn_pedido.Size = New System.Drawing.Size(74, 19)
        Me.btn_pedido.TabIndex = 75
        Me.btn_pedido.Text = "Consultar"
        Me.btn_pedido.UseVisualStyleBackColor = False
        '
        'btn_factura
        '
        Me.btn_factura.BackColor = System.Drawing.Color.LightYellow
        Me.btn_factura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_factura.Location = New System.Drawing.Point(256, 121)
        Me.btn_factura.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_factura.Name = "btn_factura"
        Me.btn_factura.Size = New System.Drawing.Size(74, 19)
        Me.btn_factura.TabIndex = 76
        Me.btn_factura.Text = "Consultar"
        Me.btn_factura.UseVisualStyleBackColor = False
        '
        'btn_ruta
        '
        Me.btn_ruta.BackColor = System.Drawing.Color.LightYellow
        Me.btn_ruta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ruta.Location = New System.Drawing.Point(540, 106)
        Me.btn_ruta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ruta.Name = "btn_ruta"
        Me.btn_ruta.Size = New System.Drawing.Size(74, 19)
        Me.btn_ruta.TabIndex = 77
        Me.btn_ruta.Text = "Consultar"
        Me.btn_ruta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "N° PEDIDO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "N° FACTURA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "N° RUTA:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CustomFormat = " "
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(441, 136)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha.TabIndex = 81
        '
        'btn_fecha
        '
        Me.btn_fecha.BackColor = System.Drawing.Color.LightYellow
        Me.btn_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_fecha.Location = New System.Drawing.Point(540, 135)
        Me.btn_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_fecha.Name = "btn_fecha"
        Me.btn_fecha.Size = New System.Drawing.Size(74, 19)
        Me.btn_fecha.TabIndex = 82
        Me.btn_fecha.Text = "Consultar"
        Me.btn_fecha.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "CLIENTE:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(782, 58)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 19)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(111, 55)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(539, 20)
        Me.txt_cliente.TabIndex = 84
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Turquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(668, 47)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 34)
        Me.Button2.TabIndex = 87
        Me.Button2.Text = "Buscar Cliente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 20)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "CONSULTA RETIROS"
        '
        'dgv_retiros
        '
        Me.dgv_retiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_retiros.Location = New System.Drawing.Point(5, 30)
        Me.dgv_retiros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_retiros.Name = "dgv_retiros"
        Me.dgv_retiros.RowTemplate.Height = 24
        Me.dgv_retiros.Size = New System.Drawing.Size(1124, 212)
        Me.dgv_retiros.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "N° RET.DOC.:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightYellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(256, 147)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 19)
        Me.Button3.TabIndex = 91
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_retiro
        '
        Me.txt_retiro.Location = New System.Drawing.Point(114, 147)
        Me.txt_retiro.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_retiro.Name = "txt_retiro"
        Me.txt_retiro.Size = New System.Drawing.Size(138, 20)
        Me.txt_retiro.TabIndex = 90
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1144, 273)
        Me.TabControl1.TabIndex = 93
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_autorizacion)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1136, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consulta despachos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_retiros)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1136, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta retiros"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.AllowUserToDeleteRows = False
        Me.dgv_datos.AllowUserToResizeRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Location = New System.Drawing.Point(3, 7)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.ReadOnly = True
        Me.dgv_datos.RowHeadersVisible = False
        Me.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_datos.Size = New System.Drawing.Size(10, 10)
        Me.dgv_datos.TabIndex = 94
        Me.dgv_datos.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(946, 116)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(120, 40)
        Me.btn_buscar.TabIndex = 95
        Me.btn_buscar.Text = "Buscar Despacho"
        Me.btn_buscar.UseVisualStyleBackColor = True
        Me.btn_buscar.Visible = False
        '
        'chb_fecha
        '
        Me.chb_fecha.AutoSize = True
        Me.chb_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_fecha.Location = New System.Drawing.Point(768, 130)
        Me.chb_fecha.Name = "chb_fecha"
        Me.chb_fecha.Size = New System.Drawing.Size(66, 17)
        Me.chb_fecha.TabIndex = 96
        Me.chb_fecha.Text = "FECHA"
        Me.chb_fecha.UseVisualStyleBackColor = True
        Me.chb_fecha.Visible = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(946, 45)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(120, 38)
        Me.btn_limpiar.TabIndex = 97
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "FECHA:"
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(840, 127)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(100, 20)
        Me.txt_documento.TabIndex = 101
        Me.txt_documento.Visible = False
        '
        'Frm_rutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1164, 450)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.chb_fecha)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.dgv_datos)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_retiro)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.btn_fecha)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_ruta)
        Me.Controls.Add(Me.btn_factura)
        Me.Controls.Add(Me.btn_pedido)
        Me.Controls.Add(Me.txt_ruta)
        Me.Controls.Add(Me.txt_factura)
        Me.Controls.Add(Me.txt_pedido)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_rutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Despacho"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_autorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_retiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_autorizacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_pedido As System.Windows.Forms.TextBox
    Friend WithEvents txt_factura As System.Windows.Forms.TextBox
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents btn_pedido As System.Windows.Forms.Button
    Friend WithEvents btn_factura As System.Windows.Forms.Button
    Friend WithEvents btn_ruta As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_fecha As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_retiros As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_retiro As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_datos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents chb_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
End Class
