<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_solicitud_servicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_solicitud_servicio))
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_programacion = New System.Windows.Forms.Label()
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_comuna = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_solicitante = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(25, 55)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(478, 22)
        Me.txt_cliente.TabIndex = 0
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(219, 280)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(315, 22)
        Me.txt_motivo.TabIndex = 8
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(12, 341)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(525, 143)
        Me.txt_observacion.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Motivo Visita"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Observación"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(104, 574)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(130, 32)
        Me.btn_aceptar.TabIndex = 10
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(254, 574)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(130, 32)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(504, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(374, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Fecha"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(440, 9)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(111, 22)
        Me.txt_fecha.TabIndex = 29
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(95, 9)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 22)
        Me.txt_usuario.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Usuario:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(219, 89)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(108, 22)
        Me.dtp_fecha.TabIndex = 1
        '
        'lbl_programacion
        '
        Me.lbl_programacion.AutoSize = True
        Me.lbl_programacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_programacion.Location = New System.Drawing.Point(26, 89)
        Me.lbl_programacion.Name = "lbl_programacion"
        Me.lbl_programacion.Size = New System.Drawing.Size(151, 20)
        Me.lbl_programacion.TabIndex = 42
        Me.lbl_programacion.Text = "Fecha Propuesta"
        '
        'cmb_dia
        '
        Me.cmb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmb_dia.Location = New System.Drawing.Point(333, 89)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(72, 24)
        Me.cmb_dia.TabIndex = 2
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(250, 9)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(118, 22)
        Me.txt_folio.TabIndex = 44
        Me.txt_folio.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Solicitante Visita"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(219, 147)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(315, 22)
        Me.txt_telefono.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Teléfono Solicitante"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Dirección Visita"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(219, 202)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(315, 44)
        Me.txt_direccion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Comuna Visita"
        '
        'txt_comuna
        '
        Me.txt_comuna.Location = New System.Drawing.Point(219, 252)
        Me.txt_comuna.Name = "txt_comuna"
        Me.txt_comuna.Size = New System.Drawing.Size(315, 22)
        Me.txt_comuna.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 20)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "E-mail Solicitante"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(219, 175)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(315, 22)
        Me.txt_email.TabIndex = 5
        '
        'txt_solicitante
        '
        Me.txt_solicitante.Location = New System.Drawing.Point(219, 119)
        Me.txt_solicitante.Name = "txt_solicitante"
        Me.txt_solicitante.Size = New System.Drawing.Size(315, 22)
        Me.txt_solicitante.TabIndex = 3
        '
        'frm_solicitud_servicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(553, 611)
        Me.Controls.Add(Me.txt_solicitante)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_comuna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.cmb_dia)
        Me.Controls.Add(Me.lbl_programacion)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.txt_motivo)
        Me.Controls.Add(Me.txt_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_solicitud_servicio"
        Me.Text = "Solicitud Visita Técnica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_programacion As System.Windows.Forms.Label
    Friend WithEvents cmb_dia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_solicitante As System.Windows.Forms.TextBox
End Class
