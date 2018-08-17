<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ticket_historial
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
        Me.dgv_historial_ticket = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_solicitud = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.dtp_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.dtp_finaliza = New System.Windows.Forms.DateTimePicker()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.chb_nueva_busqueda = New System.Windows.Forms.CheckBox()
        Me.txt_prioridad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_nuevo_registro = New System.Windows.Forms.Button()
        Me.dgv_ticket = New System.Windows.Forms.DataGridView()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_asunto = New System.Windows.Forms.TextBox()
        CType(Me.dgv_historial_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_historial_ticket
        '
        Me.dgv_historial_ticket.AllowUserToAddRows = False
        Me.dgv_historial_ticket.AllowUserToDeleteRows = False
        Me.dgv_historial_ticket.BackgroundColor = System.Drawing.Color.White
        Me.dgv_historial_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historial_ticket.Location = New System.Drawing.Point(14, 263)
        Me.dgv_historial_ticket.MultiSelect = False
        Me.dgv_historial_ticket.Name = "dgv_historial_ticket"
        Me.dgv_historial_ticket.ReadOnly = True
        Me.dgv_historial_ticket.RowHeadersVisible = False
        Me.dgv_historial_ticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_historial_ticket.Size = New System.Drawing.Size(412, 122)
        Me.dgv_historial_ticket.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Identificador de solicitud"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Usuario"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Comentario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Ingresado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(509, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Finaliza"
        '
        'txt_id_solicitud
        '
        Me.txt_id_solicitud.Location = New System.Drawing.Point(232, 343)
        Me.txt_id_solicitud.Name = "txt_id_solicitud"
        Me.txt_id_solicitud.Size = New System.Drawing.Size(25, 20)
        Me.txt_id_solicitud.TabIndex = 18
        Me.txt_id_solicitud.Visible = False
        '
        'txt_usuario
        '
        Me.txt_usuario.Enabled = False
        Me.txt_usuario.Location = New System.Drawing.Point(231, 295)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 19
        Me.txt_usuario.Visible = False
        '
        'txt_estado
        '
        Me.txt_estado.Enabled = False
        Me.txt_estado.Location = New System.Drawing.Point(15, 93)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.ReadOnly = True
        Me.txt_estado.Size = New System.Drawing.Size(100, 20)
        Me.txt_estado.TabIndex = 22
        '
        'dtp_ingreso
        '
        Me.dtp_ingreso.Enabled = False
        Me.dtp_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ingreso.Location = New System.Drawing.Point(333, 93)
        Me.dtp_ingreso.Name = "dtp_ingreso"
        Me.dtp_ingreso.Size = New System.Drawing.Size(114, 20)
        Me.dtp_ingreso.TabIndex = 23
        '
        'dtp_finaliza
        '
        Me.dtp_finaliza.Enabled = False
        Me.dtp_finaliza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_finaliza.Location = New System.Drawing.Point(512, 93)
        Me.dtp_finaliza.Name = "dtp_finaliza"
        Me.dtp_finaliza.Size = New System.Drawing.Size(105, 20)
        Me.dtp_finaliza.TabIndex = 24
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(15, 154)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.ReadOnly = True
        Me.txt_comentario.Size = New System.Drawing.Size(411, 94)
        Me.txt_comentario.TabIndex = 25
        '
        'chb_nueva_busqueda
        '
        Me.chb_nueva_busqueda.AutoSize = True
        Me.chb_nueva_busqueda.Checked = True
        Me.chb_nueva_busqueda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_nueva_busqueda.Location = New System.Drawing.Point(273, 343)
        Me.chb_nueva_busqueda.Name = "chb_nueva_busqueda"
        Me.chb_nueva_busqueda.Size = New System.Drawing.Size(108, 17)
        Me.chb_nueva_busqueda.TabIndex = 26
        Me.chb_nueva_busqueda.Text = "Nueva busqueda"
        Me.chb_nueva_busqueda.UseVisualStyleBackColor = True
        Me.chb_nueva_busqueda.Visible = False
        '
        'txt_prioridad
        '
        Me.txt_prioridad.Enabled = False
        Me.txt_prioridad.Location = New System.Drawing.Point(182, 93)
        Me.txt_prioridad.Name = "txt_prioridad"
        Me.txt_prioridad.ReadOnly = True
        Me.txt_prioridad.Size = New System.Drawing.Size(100, 20)
        Me.txt_prioridad.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Prioridad"
        '
        'btn_nuevo_registro
        '
        Me.btn_nuevo_registro.Location = New System.Drawing.Point(502, 311)
        Me.btn_nuevo_registro.Name = "btn_nuevo_registro"
        Me.btn_nuevo_registro.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo_registro.TabIndex = 29
        Me.btn_nuevo_registro.Text = "Agregar"
        Me.btn_nuevo_registro.UseVisualStyleBackColor = True
        '
        'dgv_ticket
        '
        Me.dgv_ticket.AllowUserToAddRows = False
        Me.dgv_ticket.AllowUserToDeleteRows = False
        Me.dgv_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ticket.Location = New System.Drawing.Point(639, 12)
        Me.dgv_ticket.Name = "dgv_ticket"
        Me.dgv_ticket.ReadOnly = True
        Me.dgv_ticket.Size = New System.Drawing.Size(10, 10)
        Me.dgv_ticket.TabIndex = 30
        Me.dgv_ticket.Visible = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(15, 35)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(267, 20)
        Me.txt_nombre.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Nombre de Ticket"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(330, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Asunto"
        '
        'txt_asunto
        '
        Me.txt_asunto.Enabled = False
        Me.txt_asunto.Location = New System.Drawing.Point(322, 35)
        Me.txt_asunto.Name = "txt_asunto"
        Me.txt_asunto.Size = New System.Drawing.Size(295, 20)
        Me.txt_asunto.TabIndex = 34
        '
        'frm_ticket_historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 397)
        Me.Controls.Add(Me.dgv_historial_ticket)
        Me.Controls.Add(Me.txt_asunto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_ticket)
        Me.Controls.Add(Me.btn_nuevo_registro)
        Me.Controls.Add(Me.txt_prioridad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chb_nueva_busqueda)
        Me.Controls.Add(Me.txt_comentario)
        Me.Controls.Add(Me.dtp_finaliza)
        Me.Controls.Add(Me.dtp_ingreso)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_id_solicitud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ticket_historial"
        Me.Text = "Historial Ticket"
        CType(Me.dgv_historial_ticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ticket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_historial_ticket As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id_solicitud As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents dtp_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_finaliza As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents chb_nueva_busqueda As System.Windows.Forms.CheckBox
    Friend WithEvents txt_prioridad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo_registro As System.Windows.Forms.Button
    Friend WithEvents dgv_ticket As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_asunto As System.Windows.Forms.TextBox
End Class
