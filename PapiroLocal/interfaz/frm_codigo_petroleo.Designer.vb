<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_codigo_petroleo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha_in = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_fin = New System.Windows.Forms.MaskedTextBox()
        Me.btn_libro_compras = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_stock_anterior = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_vales_petroleo
        '
        Me.btn_vales_petroleo.BackColor = System.Drawing.Color.Tomato
        Me.btn_vales_petroleo.ForeColor = System.Drawing.Color.White
        Me.btn_vales_petroleo.Location = New System.Drawing.Point(363, 169)
        Me.btn_vales_petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vales_petroleo.Name = "btn_vales_petroleo"
        Me.btn_vales_petroleo.Size = New System.Drawing.Size(207, 55)
        Me.btn_vales_petroleo.TabIndex = 13
        Me.btn_vales_petroleo.Text = "Diesel Mensual"
        Me.btn_vales_petroleo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "COMPRAS Y CONSUMOS DE PETRÓLEO"
        '
        'txt_fecha_in
        '
        Me.txt_fecha_in.Location = New System.Drawing.Point(147, 75)
        Me.txt_fecha_in.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_in.Mask = "00/00/0000"
        Me.txt_fecha_in.Name = "txt_fecha_in"
        Me.txt_fecha_in.Size = New System.Drawing.Size(96, 22)
        Me.txt_fecha_in.TabIndex = 16
        Me.txt_fecha_in.ValidatingType = GetType(Date)
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.Location = New System.Drawing.Point(147, 106)
        Me.txt_fecha_fin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_fin.Mask = "00/00/0000"
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(96, 22)
        Me.txt_fecha_fin.TabIndex = 17
        Me.txt_fecha_fin.ValidatingType = GetType(Date)
        '
        'btn_libro_compras
        '
        Me.btn_libro_compras.BackColor = System.Drawing.Color.Blue
        Me.btn_libro_compras.ForeColor = System.Drawing.Color.White
        Me.btn_libro_compras.Location = New System.Drawing.Point(69, 169)
        Me.btn_libro_compras.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_libro_compras.Name = "btn_libro_compras"
        Me.btn_libro_compras.Size = New System.Drawing.Size(207, 55)
        Me.btn_libro_compras.TabIndex = 18
        Me.btn_libro_compras.Text = "Libro de Compras"
        Me.btn_libro_compras.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(69, 231)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 55)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Informe de Compras y Consumo de Petróleo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(363, 231)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 55)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Diesel Completo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(380, 75)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(315, 22)
        Me.txt_nombre_obra.TabIndex = 1137
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 1138
        Me.Label4.Text = "Nombre Obra:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(69, 295)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 55)
        Me.Button3.TabIndex = 1139
        Me.Button3.Text = "Cuentas Contables"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_stock_anterior
        '
        Me.txt_stock_anterior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_stock_anterior.Location = New System.Drawing.Point(380, 110)
        Me.txt_stock_anterior.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_stock_anterior.MaxLength = 40
        Me.txt_stock_anterior.Name = "txt_stock_anterior"
        Me.txt_stock_anterior.Size = New System.Drawing.Size(315, 22)
        Me.txt_stock_anterior.TabIndex = 1140
        Me.txt_stock_anterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 1141
        Me.Label5.Text = "Stock Anterior:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Tomato
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(363, 298)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 55)
        Me.Button4.TabIndex = 1142
        Me.Button4.Text = "Libro Combustible Diesel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Blue
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(69, 358)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(207, 55)
        Me.Button5.TabIndex = 1143
        Me.Button5.Text = "Compras y Storage"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Tomato
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(363, 361)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(207, 55)
        Me.Button6.TabIndex = 1144
        Me.Button6.Text = "Rendimiento Maquinaria"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'frm_codigo_petroleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 423)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txt_stock_anterior)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_libro_compras)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_in)
        Me.Controls.Add(Me.btn_vales_petroleo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_codigo_petroleo"
        Me.Text = "Petróleo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_vales_petroleo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_in As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_fin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_libro_compras As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_stock_anterior As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
