<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_inf_pagos
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
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha_in = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_pago1 = New System.Windows.Forms.CheckBox()
        Me.chk_pago2 = New System.Windows.Forms.CheckBox()
        Me.chk_pago3 = New System.Windows.Forms.CheckBox()
        Me.chk_pago4 = New System.Windows.Forms.CheckBox()
        Me.chk_pago5 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_generar
        '
        Me.btn_generar.BackColor = System.Drawing.Color.Blue
        Me.btn_generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar.ForeColor = System.Drawing.Color.White
        Me.btn_generar.Location = New System.Drawing.Point(22, 339)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(469, 45)
        Me.btn_generar.TabIndex = 13
        Me.btn_generar.Text = "GENERAR INFORME REPORTE INGRESOS"
        Me.btn_generar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "INFORME REPORTE INGRESOS DE PAGO"
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_fin.Location = New System.Drawing.Point(202, 75)
        Me.txt_fecha_fin.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(151, 26)
        Me.txt_fecha_fin.TabIndex = 1154
        '
        'txt_fecha_in
        '
        Me.txt_fecha_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_in.Location = New System.Drawing.Point(202, 45)
        Me.txt_fecha_in.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha_in.Name = "txt_fecha_in"
        Me.txt_fecha_in.Size = New System.Drawing.Size(151, 26)
        Me.txt_fecha_in.TabIndex = 1153
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 1152
        Me.Label3.Text = "FECHA FINAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 1151
        Me.Label2.Text = "FECHA INICIAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 1155
        Me.Label4.Text = "SELECCIÓN"
        '
        'chk_pago1
        '
        Me.chk_pago1.AutoSize = True
        Me.chk_pago1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pago1.Location = New System.Drawing.Point(76, 162)
        Me.chk_pago1.Name = "chk_pago1"
        Me.chk_pago1.Size = New System.Drawing.Size(103, 24)
        Me.chk_pago1.TabIndex = 1156
        Me.chk_pago1.Text = "CHEQUE"
        Me.chk_pago1.UseVisualStyleBackColor = True
        '
        'chk_pago2
        '
        Me.chk_pago2.AutoSize = True
        Me.chk_pago2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pago2.Location = New System.Drawing.Point(76, 192)
        Me.chk_pago2.Name = "chk_pago2"
        Me.chk_pago2.Size = New System.Drawing.Size(202, 24)
        Me.chk_pago2.TabIndex = 1157
        Me.chk_pago2.Text = "DEPOSITO DIRECTO"
        Me.chk_pago2.UseVisualStyleBackColor = True
        '
        'chk_pago3
        '
        Me.chk_pago3.AutoSize = True
        Me.chk_pago3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pago3.Location = New System.Drawing.Point(76, 222)
        Me.chk_pago3.Name = "chk_pago3"
        Me.chk_pago3.Size = New System.Drawing.Size(116, 24)
        Me.chk_pago3.TabIndex = 1158
        Me.chk_pago3.Text = "EFECTIVO"
        Me.chk_pago3.UseVisualStyleBackColor = True
        '
        'chk_pago4
        '
        Me.chk_pago4.AutoSize = True
        Me.chk_pago4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pago4.Location = New System.Drawing.Point(76, 252)
        Me.chk_pago4.Name = "chk_pago4"
        Me.chk_pago4.Size = New System.Drawing.Size(177, 24)
        Me.chk_pago4.TabIndex = 1159
        Me.chk_pago4.Text = "TRANSFERENCIA"
        Me.chk_pago4.UseVisualStyleBackColor = True
        '
        'chk_pago5
        '
        Me.chk_pago5.AutoSize = True
        Me.chk_pago5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pago5.Location = New System.Drawing.Point(76, 282)
        Me.chk_pago5.Name = "chk_pago5"
        Me.chk_pago5.Size = New System.Drawing.Size(77, 24)
        Me.chk_pago5.TabIndex = 1160
        Me.chk_pago5.Text = "OTRO"
        Me.chk_pago5.UseVisualStyleBackColor = True
        '
        'frm_menu_inf_pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 396)
        Me.Controls.Add(Me.chk_pago5)
        Me.Controls.Add(Me.chk_pago4)
        Me.Controls.Add(Me.chk_pago3)
        Me.Controls.Add(Me.chk_pago2)
        Me.Controls.Add(Me.chk_pago1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_in)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_menu_inf_pagos"
        Me.Text = "Reporte Ingresos de Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_pago1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pago2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pago3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pago4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pago5 As System.Windows.Forms.CheckBox
End Class
