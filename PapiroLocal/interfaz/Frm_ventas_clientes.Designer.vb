<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ventas_clientes
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_senal_advertencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_comuna = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_direccion_despacho = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmb_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nombre_comercial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telefonos_comercial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email_comercial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cargo_comercial = New System.Windows.Forms.TextBox()
        Me.gbx_Mov_Tierra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(505, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 34)
        Me.Button1.TabIndex = 1086
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(129, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 34)
        Me.Button2.TabIndex = 1087
        Me.Button2.Text = "INGRESAR PEDIDO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_senal_advertencia
        '
        Me.txt_senal_advertencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_senal_advertencia.Location = New System.Drawing.Point(620, 63)
        Me.txt_senal_advertencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senal_advertencia.MaxLength = 40
        Me.txt_senal_advertencia.Name = "txt_senal_advertencia"
        Me.txt_senal_advertencia.Size = New System.Drawing.Size(251, 22)
        Me.txt_senal_advertencia.TabIndex = 4
        Me.txt_senal_advertencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 1089
        Me.Label5.Text = "RUT:"
        '
        'txt_rut
        '
        Me.txt_rut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_rut.Location = New System.Drawing.Point(184, 64)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rut.MaxLength = 40
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(251, 22)
        Me.txt_rut.TabIndex = 2
        Me.txt_rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 1087
        Me.Label2.Text = "SEÑAL ADVERTENCIA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CLIENTE:"
        '
        'txt_comuna
        '
        Me.txt_comuna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_comuna.Location = New System.Drawing.Point(184, 124)
        Me.txt_comuna.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comuna.MaxLength = 40
        Me.txt_comuna.Name = "txt_comuna"
        Me.txt_comuna.Size = New System.Drawing.Size(250, 22)
        Me.txt_comuna.TabIndex = 1139
        Me.txt_comuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 129)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 17)
        Me.Label17.TabIndex = 1140
        Me.Label17.Text = "COMUNA:"
        '
        'txt_direccion_despacho
        '
        Me.txt_direccion_despacho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_direccion_despacho.Location = New System.Drawing.Point(184, 94)
        Me.txt_direccion_despacho.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion_despacho.MaxLength = 40
        Me.txt_direccion_despacho.Name = "txt_direccion_despacho"
        Me.txt_direccion_despacho.Size = New System.Drawing.Size(597, 22)
        Me.txt_direccion_despacho.TabIndex = 1169
        Me.txt_direccion_despacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 101)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 17)
        Me.Label21.TabIndex = 1170
        Me.Label21.Text = "DIRECCIÓN:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(859, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 26)
        Me.Button3.TabIndex = 1088
        Me.Button3.Text = "Buscar Cliente"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmb_cliente
        '
        Me.cmb_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_cliente.Location = New System.Drawing.Point(184, 38)
        Me.cmb_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_cliente.MaxLength = 40
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(597, 22)
        Me.cmb_cliente.TabIndex = 1171
        Me.cmb_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nombre_comercial
        '
        Me.txt_nombre_comercial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_comercial.Location = New System.Drawing.Point(184, 179)
        Me.txt_nombre_comercial.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_comercial.MaxLength = 40
        Me.txt_nombre_comercial.Name = "txt_nombre_comercial"
        Me.txt_nombre_comercial.Size = New System.Drawing.Size(250, 22)
        Me.txt_nombre_comercial.TabIndex = 1172
        Me.txt_nombre_comercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 1173
        Me.Label3.Text = "NOMBRE:"
        '
        'txt_telefonos_comercial
        '
        Me.txt_telefonos_comercial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_telefonos_comercial.Location = New System.Drawing.Point(618, 179)
        Me.txt_telefonos_comercial.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefonos_comercial.MaxLength = 40
        Me.txt_telefonos_comercial.Name = "txt_telefonos_comercial"
        Me.txt_telefonos_comercial.Size = New System.Drawing.Size(250, 22)
        Me.txt_telefonos_comercial.TabIndex = 1174
        Me.txt_telefonos_comercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 184)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 1175
        Me.Label4.Text = "TELÉFONOS:"
        '
        'txt_email_comercial
        '
        Me.txt_email_comercial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_email_comercial.Location = New System.Drawing.Point(184, 209)
        Me.txt_email_comercial.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email_comercial.MaxLength = 40
        Me.txt_email_comercial.Name = "txt_email_comercial"
        Me.txt_email_comercial.Size = New System.Drawing.Size(250, 22)
        Me.txt_email_comercial.TabIndex = 1176
        Me.txt_email_comercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 1177
        Me.Label6.Text = "E-MAIL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 17)
        Me.Label7.TabIndex = 1178
        Me.Label7.Text = "CONTACTO COMERCIAL"
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label8)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_cargo_comercial)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label7)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label6)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_email_comercial)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label4)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_telefonos_comercial)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_nombre_comercial)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_cliente)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label21)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_direccion_despacho)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label17)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_comuna)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_rut)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label5)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_senal_advertencia)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(16, 14)
        Me.gbx_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(1015, 277)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Búsqueda Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(442, 214)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 1180
        Me.Label8.Text = "CARGO:"
        '
        'txt_cargo_comercial
        '
        Me.txt_cargo_comercial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_cargo_comercial.Location = New System.Drawing.Point(618, 209)
        Me.txt_cargo_comercial.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cargo_comercial.MaxLength = 40
        Me.txt_cargo_comercial.Name = "txt_cargo_comercial"
        Me.txt_cargo_comercial.Size = New System.Drawing.Size(250, 22)
        Me.txt_cargo_comercial.TabIndex = 1179
        Me.txt_cargo_comercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_ventas_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1043, 348)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_ventas_clientes"
        Me.Text = "Venta Cliente"
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_senal_advertencia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_despacho As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmb_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_comercial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_telefonos_comercial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_email_comercial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cargo_comercial As System.Windows.Forms.TextBox
End Class
