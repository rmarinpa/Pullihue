<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estado_de_pago_subcontrato
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
        Me.btn_vales_petroleo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_representante = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_subcontrato = New System.Windows.Forms.ComboBox()
        Me.cmb_fecha_actual = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_fecha_anterior = New System.Windows.Forms.ComboBox()
        Me.txt_numero_ep = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_vales_petroleo
        '
        Me.btn_vales_petroleo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_vales_petroleo.ForeColor = System.Drawing.Color.White
        Me.btn_vales_petroleo.Location = New System.Drawing.Point(48, 235)
        Me.btn_vales_petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vales_petroleo.Name = "btn_vales_petroleo"
        Me.btn_vales_petroleo.Size = New System.Drawing.Size(308, 55)
        Me.btn_vales_petroleo.TabIndex = 13
        Me.btn_vales_petroleo.Text = "Detalle Estado de Pago"
        Me.btn_vales_petroleo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha EP actual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ESTADOS DE PAGO SUBCONTRATO"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(191, 177)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(244, 22)
        Me.txt_nombre_obra.TabIndex = 1137
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 1138
        Me.Label4.Text = "Nombre Obra:"
        '
        'cmb_representante
        '
        Me.cmb_representante.FormattingEnabled = True
        Me.cmb_representante.Location = New System.Drawing.Point(191, 53)
        Me.cmb_representante.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_representante.Name = "cmb_representante"
        Me.cmb_representante.Size = New System.Drawing.Size(439, 24)
        Me.cmb_representante.TabIndex = 1139
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 1140
        Me.Label5.Text = "Representante"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(375, 235)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 55)
        Me.Button1.TabIndex = 1141
        Me.Button1.Text = "Resumen Estado de Pago"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 1143
        Me.Label2.Text = "Subcontrato"
        '
        'cmb_subcontrato
        '
        Me.cmb_subcontrato.FormattingEnabled = True
        Me.cmb_subcontrato.Location = New System.Drawing.Point(191, 85)
        Me.cmb_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_subcontrato.Name = "cmb_subcontrato"
        Me.cmb_subcontrato.Size = New System.Drawing.Size(439, 24)
        Me.cmb_subcontrato.TabIndex = 1142
        '
        'cmb_fecha_actual
        '
        Me.cmb_fecha_actual.FormattingEnabled = True
        Me.cmb_fecha_actual.Location = New System.Drawing.Point(191, 116)
        Me.cmb_fecha_actual.Name = "cmb_fecha_actual"
        Me.cmb_fecha_actual.Size = New System.Drawing.Size(244, 24)
        Me.cmb_fecha_actual.TabIndex = 1144
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 153)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 17)
        Me.Label6.TabIndex = 1145
        Me.Label6.Text = "Fecha EP anterior"
        '
        'cmb_fecha_anterior
        '
        Me.cmb_fecha_anterior.FormattingEnabled = True
        Me.cmb_fecha_anterior.Location = New System.Drawing.Point(191, 146)
        Me.cmb_fecha_anterior.Name = "cmb_fecha_anterior"
        Me.cmb_fecha_anterior.Size = New System.Drawing.Size(244, 24)
        Me.cmb_fecha_anterior.TabIndex = 1146
        '
        'txt_numero_ep
        '
        Me.txt_numero_ep.Location = New System.Drawing.Point(542, 116)
        Me.txt_numero_ep.Name = "txt_numero_ep"
        Me.txt_numero_ep.Size = New System.Drawing.Size(88, 22)
        Me.txt_numero_ep.TabIndex = 1147
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(475, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 1148
        Me.Label7.Text = "N° EP"
        '
        'frm_estado_de_pago_subcontrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 321)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_numero_ep)
        Me.Controls.Add(Me.cmb_fecha_anterior)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_fecha_actual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_subcontrato)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_representante)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_vales_petroleo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_estado_de_pago_subcontrato"
        Me.Text = "+"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_vales_petroleo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_representante As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_subcontrato As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_fecha_actual As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_fecha_anterior As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numero_ep As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
