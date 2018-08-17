<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_asociar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_asociar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.chk_cor2_no = New System.Windows.Forms.CheckBox()
        Me.chk_cor2_si = New System.Windows.Forms.CheckBox()
        Me.dgv_despachos2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_cor_no = New System.Windows.Forms.CheckBox()
        Me.chk_cor_si = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_n_ped = New System.Windows.Forms.ComboBox()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_corr_cliente = New System.Windows.Forms.TextBox()
        Me.txt_corr_monto = New System.Windows.Forms.TextBox()
        Me.dgv_despachos = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ASOCIACIÓN PEDIDO CON DOCUMENTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(583, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(58, 265)
        Me.txt_cliente.Multiline = True
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(317, 41)
        Me.txt_cliente.TabIndex = 3
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(58, 354)
        Me.txt_monto.Multiline = True
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(188, 41)
        Me.txt_monto.TabIndex = 4
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(393, 185)
        Me.txt_documento.Multiline = True
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(144, 24)
        Me.txt_documento.TabIndex = 1
        '
        'chk_cor2_no
        '
        Me.chk_cor2_no.AutoSize = True
        Me.chk_cor2_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_cor2_no.Location = New System.Drawing.Point(499, 356)
        Me.chk_cor2_no.Name = "chk_cor2_no"
        Me.chk_cor2_no.Size = New System.Drawing.Size(59, 29)
        Me.chk_cor2_no.TabIndex = 29
        Me.chk_cor2_no.Text = "No"
        Me.chk_cor2_no.UseVisualStyleBackColor = True
        '
        'chk_cor2_si
        '
        Me.chk_cor2_si.AutoSize = True
        Me.chk_cor2_si.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_cor2_si.Location = New System.Drawing.Point(393, 356)
        Me.chk_cor2_si.Name = "chk_cor2_si"
        Me.chk_cor2_si.Size = New System.Drawing.Size(52, 29)
        Me.chk_cor2_si.TabIndex = 28
        Me.chk_cor2_si.Text = "Si"
        Me.chk_cor2_si.UseVisualStyleBackColor = True
        '
        'dgv_despachos2
        '
        Me.dgv_despachos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos2.Location = New System.Drawing.Point(69, 462)
        Me.dgv_despachos2.Name = "dgv_despachos2"
        Me.dgv_despachos2.RowTemplate.Height = 24
        Me.dgv_despachos2.Size = New System.Drawing.Size(703, 176)
        Me.dgv_despachos2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "N° PEDIDO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "N° DOCUMENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 25)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "MONTO PEDIDO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Corresponde"
        '
        'chk_cor_no
        '
        Me.chk_cor_no.AutoSize = True
        Me.chk_cor_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_cor_no.Location = New System.Drawing.Point(499, 277)
        Me.chk_cor_no.Name = "chk_cor_no"
        Me.chk_cor_no.Size = New System.Drawing.Size(59, 29)
        Me.chk_cor_no.TabIndex = 37
        Me.chk_cor_no.Text = "No"
        Me.chk_cor_no.UseVisualStyleBackColor = True
        '
        'chk_cor_si
        '
        Me.chk_cor_si.AutoSize = True
        Me.chk_cor_si.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_cor_si.Location = New System.Drawing.Point(393, 277)
        Me.chk_cor_si.Name = "chk_cor_si"
        Me.chk_cor_si.Size = New System.Drawing.Size(52, 29)
        Me.chk_cor_si.TabIndex = 36
        Me.chk_cor_si.Text = "Si"
        Me.chk_cor_si.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 25)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Corresponde"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Factura", "Guía de Despacho", "NULO"})
        Me.cmb_tipo.Location = New System.Drawing.Point(578, 185)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(180, 24)
        Me.cmb_tipo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(230, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "DETALLE DE PEDIDO"
        '
        'cmb_n_ped
        '
        Me.cmb_n_ped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_n_ped.FormattingEnabled = True
        Me.cmb_n_ped.Location = New System.Drawing.Point(56, 185)
        Me.cmb_n_ped.Name = "cmb_n_ped"
        Me.cmb_n_ped.Size = New System.Drawing.Size(319, 24)
        Me.cmb_n_ped.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(243, 93)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(118, 22)
        Me.txt_fecha.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Seleccione Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(578, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 25)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "TIPO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(596, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 41)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Guardar Registro"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(748, 241)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(10, 22)
        Me.txt_id.TabIndex = 46
        Me.txt_id.Visible = False
        '
        'txt_corr_cliente
        '
        Me.txt_corr_cliente.Location = New System.Drawing.Point(696, 249)
        Me.txt_corr_cliente.Name = "txt_corr_cliente"
        Me.txt_corr_cliente.Size = New System.Drawing.Size(34, 22)
        Me.txt_corr_cliente.TabIndex = 47
        Me.txt_corr_cliente.Visible = False
        '
        'txt_corr_monto
        '
        Me.txt_corr_monto.Location = New System.Drawing.Point(696, 277)
        Me.txt_corr_monto.Name = "txt_corr_monto"
        Me.txt_corr_monto.Size = New System.Drawing.Size(34, 22)
        Me.txt_corr_monto.TabIndex = 48
        Me.txt_corr_monto.Visible = False
        '
        'dgv_despachos
        '
        Me.dgv_despachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos.Location = New System.Drawing.Point(2, 3)
        Me.dgv_despachos.Name = "dgv_despachos"
        Me.dgv_despachos.RowTemplate.Height = 24
        Me.dgv_despachos.Size = New System.Drawing.Size(17, 11)
        Me.dgv_despachos.TabIndex = 49
        '
        'Frm_asociar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 696)
        Me.Controls.Add(Me.dgv_despachos)
        Me.Controls.Add(Me.txt_corr_monto)
        Me.Controls.Add(Me.txt_corr_cliente)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.cmb_n_ped)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chk_cor_no)
        Me.Controls.Add(Me.chk_cor_si)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_despachos2)
        Me.Controls.Add(Me.chk_cor2_no)
        Me.Controls.Add(Me.chk_cor2_si)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_asociar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asociación Pedido con Documento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents chk_cor2_no As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cor2_si As System.Windows.Forms.CheckBox
    Friend WithEvents dgv_despachos2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chk_cor_no As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cor_si As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_n_ped As System.Windows.Forms.ComboBox
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_corr_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_corr_monto As System.Windows.Forms.TextBox
    Friend WithEvents dgv_despachos As System.Windows.Forms.DataGridView
End Class
