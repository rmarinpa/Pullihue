<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_observacion
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
        Me.dgv_bloqueo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_razon = New System.Windows.Forms.TextBox()
        Me.txt_bloqueo_desbloqueo = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha_act = New System.Windows.Forms.TextBox()
        Me.txt_nombre_ejecutivo = New System.Windows.Forms.TextBox()
        Me.txt_senal_advertencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_bloqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_bloqueo
        '
        Me.dgv_bloqueo.AllowUserToAddRows = False
        Me.dgv_bloqueo.AllowUserToDeleteRows = False
        Me.dgv_bloqueo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bloqueo.Location = New System.Drawing.Point(1, 256)
        Me.dgv_bloqueo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_bloqueo.Name = "dgv_bloqueo"
        Me.dgv_bloqueo.ReadOnly = True
        Me.dgv_bloqueo.RowHeadersVisible = False
        Me.dgv_bloqueo.Size = New System.Drawing.Size(1261, 239)
        Me.dgv_bloqueo.TabIndex = 1104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1112
        Me.Label2.Text = "USUARIO:"
        '
        'txt_rut
        '
        Me.txt_rut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_rut.Location = New System.Drawing.Point(214, 42)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rut.MaxLength = 4000
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(320, 22)
        Me.txt_rut.TabIndex = 1108
        Me.txt_rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 1111
        Me.Label9.Text = "FECHA:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(65, 17)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(69, 17)
        Me.label7.TabIndex = 1110
        Me.label7.Text = "CLIENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 1109
        Me.Label1.Text = "RUT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 1114
        Me.Label3.Text = "HORA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 17)
        Me.Label4.TabIndex = 1115
        Me.Label4.Text = "BLOQUEO/DESBLOQUEO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 1116
        Me.Label5.Text = "RAZÓN:"
        '
        'txt_razon
        '
        Me.txt_razon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_razon.Location = New System.Drawing.Point(214, 143)
        Me.txt_razon.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_razon.MaxLength = 4000
        Me.txt_razon.Multiline = True
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(786, 66)
        Me.txt_razon.TabIndex = 1117
        Me.txt_razon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_bloqueo_desbloqueo
        '
        Me.txt_bloqueo_desbloqueo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_bloqueo_desbloqueo.Location = New System.Drawing.Point(637, 78)
        Me.txt_bloqueo_desbloqueo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bloqueo_desbloqueo.MaxLength = 4000
        Me.txt_bloqueo_desbloqueo.Name = "txt_bloqueo_desbloqueo"
        Me.txt_bloqueo_desbloqueo.Size = New System.Drawing.Size(351, 22)
        Me.txt_bloqueo_desbloqueo.TabIndex = 1118
        Me.txt_bloqueo_desbloqueo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cliente
        '
        Me.txt_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_cliente.Location = New System.Drawing.Point(214, 12)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cliente.MaxLength = 4000
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(774, 22)
        Me.txt_cliente.TabIndex = 1119
        Me.txt_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(495, 502)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(192, 58)
        Me.btn_cancelar.TabIndex = 1122
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Location = New System.Drawing.Point(227, 502)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(192, 58)
        Me.btn_aceptar.TabIndex = 1121
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'txt_hora
        '
        Me.txt_hora.BackColor = System.Drawing.Color.White
        Me.txt_hora.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(215, 109)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(105, 28)
        Me.txt_hora.TabIndex = 1208
        '
        'txt_fecha_act
        '
        Me.txt_fecha_act.BackColor = System.Drawing.Color.White
        Me.txt_fecha_act.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_act.Location = New System.Drawing.Point(214, 75)
        Me.txt_fecha_act.Name = "txt_fecha_act"
        Me.txt_fecha_act.Size = New System.Drawing.Size(106, 28)
        Me.txt_fecha_act.TabIndex = 1207
        '
        'txt_nombre_ejecutivo
        '
        Me.txt_nombre_ejecutivo.BackColor = System.Drawing.Color.White
        Me.txt_nombre_ejecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_ejecutivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_ejecutivo.Location = New System.Drawing.Point(639, 42)
        Me.txt_nombre_ejecutivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_ejecutivo.MaxLength = 4000
        Me.txt_nombre_ejecutivo.Multiline = True
        Me.txt_nombre_ejecutivo.Name = "txt_nombre_ejecutivo"
        Me.txt_nombre_ejecutivo.Size = New System.Drawing.Size(166, 28)
        Me.txt_nombre_ejecutivo.TabIndex = 1203
        Me.txt_nombre_ejecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_senal_advertencia
        '
        Me.txt_senal_advertencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_senal_advertencia.Location = New System.Drawing.Point(637, 108)
        Me.txt_senal_advertencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senal_advertencia.MaxLength = 4000
        Me.txt_senal_advertencia.Name = "txt_senal_advertencia"
        Me.txt_senal_advertencia.Size = New System.Drawing.Size(351, 22)
        Me.txt_senal_advertencia.TabIndex = 1210
        Me.txt_senal_advertencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 110)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 17)
        Me.Label6.TabIndex = 1209
        Me.Label6.Text = "SEÑAL ADVERTENCIA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 235)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 17)
        Me.Label8.TabIndex = 1211
        Me.Label8.Text = "HISTORIAL DE BLOQUEOS Y OBSERVACIONES"
        '
        'frm_observacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1275, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_senal_advertencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_fecha_act)
        Me.Controls.Add(Me.txt_nombre_ejecutivo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.txt_bloqueo_desbloqueo)
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_bloqueo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_observacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Razón de Bloqueo"
        Me.TopMost = True
        CType(Me.dgv_bloqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_bloqueo As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
    Friend WithEvents txt_bloqueo_desbloqueo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_act As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_ejecutivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_senal_advertencia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
