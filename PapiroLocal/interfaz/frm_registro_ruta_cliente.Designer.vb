<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_ruta_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro_ruta_cliente))
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_tipo1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cliente1 = New System.Windows.Forms.TextBox()
        Me.btn_informe1 = New System.Windows.Forms.Button()
        Me.btn_borrar1 = New System.Windows.Forms.Button()
        Me.txt_comuna1 = New System.Windows.Forms.TextBox()
        Me.txt_direccion1 = New System.Windows.Forms.TextBox()
        Me.txt_ejecutivo1 = New System.Windows.Forms.TextBox()
        Me.txt_n_ped1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_rutas = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txt_n_ped = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha_ant = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_rutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(9, 397)
        Me.btn_aceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(98, 26)
        Me.btn_aceptar.TabIndex = 11
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(111, 397)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 26)
        Me.btn_cancelar.TabIndex = 12
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(266, 6)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Fecha"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(315, 6)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(74, 20)
        Me.txt_fecha.TabIndex = 29
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(80, 7)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(92, 20)
        Me.txt_usuario.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_tipo1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_cliente1)
        Me.GroupBox1.Controls.Add(Me.btn_informe1)
        Me.GroupBox1.Controls.Add(Me.btn_borrar1)
        Me.GroupBox1.Controls.Add(Me.txt_comuna1)
        Me.GroupBox1.Controls.Add(Me.txt_direccion1)
        Me.GroupBox1.Controls.Add(Me.txt_ejecutivo1)
        Me.GroupBox1.Controls.Add(Me.txt_n_ped1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(998, 76)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DESIGNAR RUTA"
        '
        'txt_tipo1
        '
        Me.txt_tipo1.Location = New System.Drawing.Point(23, 34)
        Me.txt_tipo1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tipo1.Name = "txt_tipo1"
        Me.txt_tipo1.Size = New System.Drawing.Size(76, 19)
        Me.txt_tipo1.TabIndex = 198
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 18)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 197
        Me.Label16.Text = "TIPO MOV."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "CLIENTE"
        '
        'txt_cliente1
        '
        Me.txt_cliente1.Location = New System.Drawing.Point(274, 34)
        Me.txt_cliente1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cliente1.Name = "txt_cliente1"
        Me.txt_cliente1.Size = New System.Drawing.Size(277, 19)
        Me.txt_cliente1.TabIndex = 78
        '
        'btn_informe1
        '
        Me.btn_informe1.Image = CType(resources.GetObject("btn_informe1.Image"), System.Drawing.Image)
        Me.btn_informe1.Location = New System.Drawing.Point(962, 32)
        Me.btn_informe1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_informe1.Name = "btn_informe1"
        Me.btn_informe1.Size = New System.Drawing.Size(26, 19)
        Me.btn_informe1.TabIndex = 68
        Me.btn_informe1.UseVisualStyleBackColor = True
        '
        'btn_borrar1
        '
        Me.btn_borrar1.Image = CType(resources.GetObject("btn_borrar1.Image"), System.Drawing.Image)
        Me.btn_borrar1.Location = New System.Drawing.Point(932, 32)
        Me.btn_borrar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_borrar1.Name = "btn_borrar1"
        Me.btn_borrar1.Size = New System.Drawing.Size(26, 19)
        Me.btn_borrar1.TabIndex = 67
        Me.btn_borrar1.UseVisualStyleBackColor = True
        '
        'txt_comuna1
        '
        Me.txt_comuna1.Location = New System.Drawing.Point(807, 33)
        Me.txt_comuna1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_comuna1.Name = "txt_comuna1"
        Me.txt_comuna1.Size = New System.Drawing.Size(122, 19)
        Me.txt_comuna1.TabIndex = 61
        '
        'txt_direccion1
        '
        Me.txt_direccion1.Location = New System.Drawing.Point(554, 33)
        Me.txt_direccion1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccion1.Name = "txt_direccion1"
        Me.txt_direccion1.Size = New System.Drawing.Size(249, 19)
        Me.txt_direccion1.TabIndex = 55
        '
        'txt_ejecutivo1
        '
        Me.txt_ejecutivo1.Location = New System.Drawing.Point(182, 34)
        Me.txt_ejecutivo1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ejecutivo1.Name = "txt_ejecutivo1"
        Me.txt_ejecutivo1.Size = New System.Drawing.Size(88, 19)
        Me.txt_ejecutivo1.TabIndex = 49
        '
        'txt_n_ped1
        '
        Me.txt_n_ped1.Location = New System.Drawing.Point(103, 34)
        Me.txt_n_ped1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_n_ped1.Name = "txt_n_ped1"
        Me.txt_n_ped1.Size = New System.Drawing.Size(76, 19)
        Me.txt_n_ped1.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(828, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "COMUNA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "DIRECCIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "EJECUTIVO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "N° DOC."
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(447, 6)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(74, 20)
        Me.txt_hora.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(398, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Hora"
        '
        'dgv_rutas
        '
        Me.dgv_rutas.AllowUserToAddRows = False
        Me.dgv_rutas.AllowUserToDeleteRows = False
        Me.dgv_rutas.AllowUserToResizeColumns = False
        Me.dgv_rutas.AllowUserToResizeRows = False
        Me.dgv_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rutas.Location = New System.Drawing.Point(4, 146)
        Me.dgv_rutas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_rutas.Name = "dgv_rutas"
        Me.dgv_rutas.RowHeadersVisible = False
        Me.dgv_rutas.RowTemplate.Height = 24
        Me.dgv_rutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_rutas.Size = New System.Drawing.Size(1003, 239)
        Me.dgv_rutas.TabIndex = 43
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(268, 28)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 32)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "ACTUALIZAR. FACTURAS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(240, 424)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(170, 30)
        Me.Button7.TabIndex = 48
        Me.Button7.Text = "BUSCAR PEDIDO"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'txt_n_ped
        '
        Me.txt_n_ped.Location = New System.Drawing.Point(324, 401)
        Me.txt_n_ped.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_n_ped.Name = "txt_n_ped"
        Me.txt_n_ped.Size = New System.Drawing.Size(87, 20)
        Me.txt_n_ped.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(237, 403)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "N° DE PEDIDO"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(443, 28)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(170, 32)
        Me.Button10.TabIndex = 63
        Me.Button10.Text = "ACTUALIZAR GUIAS"
        Me.Button10.UseVisualStyleBackColor = False
        Me.Button10.Visible = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Location = New System.Drawing.Point(415, 424)
        Me.Button15.Margin = New System.Windows.Forms.Padding(2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(170, 30)
        Me.Button15.TabIndex = 64
        Me.Button15.Text = "BUSCAR GUÍA"
        Me.Button15.UseVisualStyleBackColor = False
        Me.Button15.Visible = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(585, 6)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(91, 20)
        Me.dtp_fecha.TabIndex = 65
        Me.dtp_fecha.Visible = False
        '
        'txt_fecha_ant
        '
        Me.txt_fecha_ant.Location = New System.Drawing.Point(708, 7)
        Me.txt_fecha_ant.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha_ant.Name = "txt_fecha_ant"
        Me.txt_fecha_ant.Size = New System.Drawing.Size(74, 20)
        Me.txt_fecha_ant.TabIndex = 66
        Me.txt_fecha_ant.Visible = False
        '
        'frm_registro_ruta_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1022, 468)
        Me.Controls.Add(Me.txt_fecha_ant)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_n_ped)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.dgv_rutas)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_registro_ruta_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro de Documentos"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgv_rutas,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_comuna1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ejecutivo1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_ped1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_borrar1 As System.Windows.Forms.Button
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_rutas As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btn_informe1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente1 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txt_n_ped As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha_ant As System.Windows.Forms.TextBox
End Class
