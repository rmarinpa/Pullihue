<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_llegada
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_folio = New System.Windows.Forms.ComboBox()
        Me.btn_llegada = New System.Windows.Forms.Button()
        Me.dgv_llegada = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv_llegada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(141, 12)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(121, 22)
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
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(351, 39)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(138, 22)
        Me.txt_hora.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Hora"
        '
        'btn_consulta
        '
        Me.btn_consulta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_consulta.Location = New System.Drawing.Point(6, 80)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 34)
        Me.btn_consulta.TabIndex = 55
        Me.btn_consulta.Text = "CONSULTAR RUTA"
        Me.btn_consulta.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 20)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Folio"
        '
        'cmb_folio
        '
        Me.cmb_folio.FormattingEnabled = True
        Me.cmb_folio.Location = New System.Drawing.Point(141, 40)
        Me.cmb_folio.Name = "cmb_folio"
        Me.cmb_folio.Size = New System.Drawing.Size(121, 24)
        Me.cmb_folio.TabIndex = 53
        '
        'btn_llegada
        '
        Me.btn_llegada.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_llegada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_llegada.Location = New System.Drawing.Point(247, 80)
        Me.btn_llegada.Name = "btn_llegada"
        Me.btn_llegada.Size = New System.Drawing.Size(200, 34)
        Me.btn_llegada.TabIndex = 56
        Me.btn_llegada.Text = "REGISTRAR LLEGADA"
        Me.btn_llegada.UseVisualStyleBackColor = False
        '
        'dgv_llegada
        '
        Me.dgv_llegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_llegada.Location = New System.Drawing.Point(13, 155)
        Me.dgv_llegada.Name = "dgv_llegada"
        Me.dgv_llegada.RowTemplate.Height = 24
        Me.dgv_llegada.Size = New System.Drawing.Size(525, 289)
        Me.dgv_llegada.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Llegadas Registradas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(285, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Fecha"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(352, 12)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(137, 22)
        Me.txt_fecha.TabIndex = 59
        '
        'frm_registro_llegada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(550, 459)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_llegada)
        Me.Controls.Add(Me.btn_llegada)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.cmb_folio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_registro_llegada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otros Registros"
        CType(Me.dgv_llegada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_consulta As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_folio As System.Windows.Forms.ComboBox
    Friend WithEvents btn_llegada As System.Windows.Forms.Button
    Friend WithEvents dgv_llegada As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
End Class
