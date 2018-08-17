<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_programar_agenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_programar_agenda))
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_informe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.txt_fecha_prog = New System.Windows.Forms.DateTimePicker()
        Me.lbl_programacion = New System.Windows.Forms.Label()
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(25, 55)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(478, 22)
        Me.txt_cliente.TabIndex = 0
        '
        'txt_informe
        '
        Me.txt_informe.Location = New System.Drawing.Point(25, 221)
        Me.txt_informe.Multiline = True
        Me.txt_informe.Name = "txt_informe"
        Me.txt_informe.Size = New System.Drawing.Size(525, 99)
        Me.txt_informe.TabIndex = 4
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Observación:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(100, 342)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(130, 32)
        Me.btn_aceptar.TabIndex = 5
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(250, 342)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(130, 32)
        Me.btn_cancelar.TabIndex = 6
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
        'txt_fecha_prog
        '
        Me.txt_fecha_prog.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_prog.Location = New System.Drawing.Point(29, 113)
        Me.txt_fecha_prog.Name = "txt_fecha_prog"
        Me.txt_fecha_prog.Size = New System.Drawing.Size(108, 22)
        Me.txt_fecha_prog.TabIndex = 1
        '
        'lbl_programacion
        '
        Me.lbl_programacion.AutoSize = True
        Me.lbl_programacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_programacion.Location = New System.Drawing.Point(25, 91)
        Me.lbl_programacion.Name = "lbl_programacion"
        Me.lbl_programacion.Size = New System.Drawing.Size(182, 20)
        Me.lbl_programacion.TabIndex = 42
        Me.lbl_programacion.Text = "Fecha Programación"
        '
        'cmb_dia
        '
        Me.cmb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmb_dia.Location = New System.Drawing.Point(143, 113)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(72, 24)
        Me.cmb_dia.TabIndex = 2
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(25, 173)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(525, 22)
        Me.txt_motivo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Motivo:"
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(250, 7)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(100, 22)
        Me.txt_folio.TabIndex = 46
        Me.txt_folio.Visible = False
        '
        'frm_programar_agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(553, 386)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_motivo)
        Me.Controls.Add(Me.cmb_dia)
        Me.Controls.Add(Me.lbl_programacion)
        Me.Controls.Add(Me.txt_fecha_prog)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_informe)
        Me.Controls.Add(Me.txt_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_programar_agenda"
        Me.Text = "Programar Tarea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_informe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents txt_fecha_prog As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_programacion As System.Windows.Forms.Label
    Friend WithEvents cmb_dia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
End Class
