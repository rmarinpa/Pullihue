<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consulta_pedido_retiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consulta_pedido_retiro))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv_despachos2 = New System.Windows.Forms.DataGridView()
        Me.dgv_despachos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CachedCrystalReport11 = New Constructora_FV.CachedCrystalReport1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_retiro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_anular = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_in = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv_pendientes = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(598, 685)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 38)
        Me.Button4.TabIndex = 1190
        Me.Button4.Text = "Cerrar Historico"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgv_despachos2
        '
        Me.dgv_despachos2.AllowUserToAddRows = False
        Me.dgv_despachos2.AllowUserToDeleteRows = False
        Me.dgv_despachos2.AllowUserToResizeColumns = False
        Me.dgv_despachos2.AllowUserToResizeRows = False
        Me.dgv_despachos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos2.Location = New System.Drawing.Point(770, 123)
        Me.dgv_despachos2.MultiSelect = False
        Me.dgv_despachos2.Name = "dgv_despachos2"
        Me.dgv_despachos2.ReadOnly = True
        Me.dgv_despachos2.RowHeadersVisible = False
        Me.dgv_despachos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_despachos2.Size = New System.Drawing.Size(165, 250)
        Me.dgv_despachos2.TabIndex = 1203
        '
        'dgv_despachos
        '
        Me.dgv_despachos.AllowUserToAddRows = False
        Me.dgv_despachos.AllowUserToDeleteRows = False
        Me.dgv_despachos.AllowUserToResizeColumns = False
        Me.dgv_despachos.AllowUserToResizeRows = False
        Me.dgv_despachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_despachos.Location = New System.Drawing.Point(11, 123)
        Me.dgv_despachos.MultiSelect = False
        Me.dgv_despachos.Name = "dgv_despachos"
        Me.dgv_despachos.ReadOnly = True
        Me.dgv_despachos.RowHeadersVisible = False
        Me.dgv_despachos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_despachos.Size = New System.Drawing.Size(740, 442)
        Me.dgv_despachos.TabIndex = 1210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(433, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(646, 49)
        Me.Label4.TabIndex = 1212
        Me.Label4.Text = "HISTÓRICO RETIRO DE DOCUMENTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1213
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 1214
        Me.Button1.Text = "ACTUALIZAR TABLA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(316, 50)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(82, 20)
        Me.txt_fecha.TabIndex = 1215
        Me.txt_fecha.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 1216
        Me.Label1.Text = "SELECCIÓN DE FECHA DE RETIROS"
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(91, 44)
        Me.txt_ruta.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(168, 20)
        Me.txt_ruta.TabIndex = 1219
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 1220
        Me.Label3.Text = "N° Ruta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 1222
        Me.Label6.Text = "N° Retiro Doc.:"
        '
        'txt_retiro
        '
        Me.txt_retiro.Location = New System.Drawing.Point(91, 17)
        Me.txt_retiro.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_retiro.Name = "txt_retiro"
        Me.txt_retiro.Size = New System.Drawing.Size(168, 20)
        Me.txt_retiro.TabIndex = 1223
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_retiro)
        Me.GroupBox1.Controls.Add(Me.txt_ruta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_anular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(756, 449)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(272, 116)
        Me.GroupBox1.TabIndex = 1224
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anular"
        '
        'btn_anular
        '
        Me.btn_anular.BackColor = System.Drawing.Color.Lime
        Me.btn_anular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_anular.Location = New System.Drawing.Point(91, 75)
        Me.btn_anular.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(167, 35)
        Me.btn_anular.TabIndex = 1226
        Me.btn_anular.Text = "Anular"
        Me.btn_anular.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(865, 375)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(65, 20)
        Me.txt_total.TabIndex = 1230
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(767, 376)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 1231
        Me.Label7.Text = "MONTO NETO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dtp_fecha_in)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_fecha)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 594)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(707, 87)
        Me.GroupBox2.TabIndex = 1234
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios de Búsqueda"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(212, 52)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 1232
        Me.Label14.Text = "FECHA FINAL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(212, 32)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 1231
        Me.Label13.Text = "FECHA INICIAL:"
        '
        'dtp_fecha_in
        '
        Me.dtp_fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_in.Location = New System.Drawing.Point(316, 28)
        Me.dtp_fecha_in.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_fecha_in.Name = "dtp_fecha_in"
        Me.dtp_fecha_in.Size = New System.Drawing.Size(82, 20)
        Me.dtp_fecha_in.TabIndex = 1230
        Me.dtp_fecha_in.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(767, 398)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 1236
        Me.Label9.Text = "IVA"
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(865, 398)
        Me.txt_iva.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(65, 20)
        Me.txt_iva.TabIndex = 1237
        '
        'txt_total2
        '
        Me.txt_total2.Location = New System.Drawing.Point(865, 420)
        Me.txt_total2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.Size = New System.Drawing.Size(65, 20)
        Me.txt_total2.TabIndex = 1238
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(767, 421)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 1239
        Me.Label10.Text = "TOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(1032, 532)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(254, 33)
        Me.Label11.TabIndex = 1244
        Me.Label11.Text = "RETIROS PENDIENTES"
        '
        'dgv_pendientes
        '
        Me.dgv_pendientes.AllowUserToAddRows = False
        Me.dgv_pendientes.AllowUserToDeleteRows = False
        Me.dgv_pendientes.AllowUserToResizeColumns = False
        Me.dgv_pendientes.AllowUserToResizeRows = False
        Me.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendientes.Location = New System.Drawing.Point(760, 570)
        Me.dgv_pendientes.MultiSelect = False
        Me.dgv_pendientes.Name = "dgv_pendientes"
        Me.dgv_pendientes.ReadOnly = True
        Me.dgv_pendientes.RowHeadersVisible = False
        Me.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pendientes.Size = New System.Drawing.Size(824, 264)
        Me.dgv_pendientes.TabIndex = 1243
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Blue
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1032, 455)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 41)
        Me.Button6.TabIndex = 1245
        Me.Button6.Text = "ACTUALIZAR TABLA PENDIENTES"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Frm_consulta_pedido_retiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1596, 846)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgv_pendientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_total2)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_despachos)
        Me.Controls.Add(Me.dgv_despachos2)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_consulta_pedido_retiro"
        Me.Text = "Histórico Retiro de Documentos"
        CType(Me.dgv_despachos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_despachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents dgv_despachos2 As System.Windows.Forms.DataGridView
    Private WithEvents dgv_despachos As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CachedCrystalReport11 As Constructora_FV.CachedCrystalReport1
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_retiro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents txt_total2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents dgv_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
