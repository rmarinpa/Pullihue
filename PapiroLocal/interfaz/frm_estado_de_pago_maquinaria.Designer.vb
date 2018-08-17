<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estado_de_pago_maquinaria
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_vales_petroleo
        '
        Me.btn_vales_petroleo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_vales_petroleo.ForeColor = System.Drawing.Color.White
        Me.btn_vales_petroleo.Location = New System.Drawing.Point(53, 167)
        Me.btn_vales_petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vales_petroleo.Name = "btn_vales_petroleo"
        Me.btn_vales_petroleo.Size = New System.Drawing.Size(308, 55)
        Me.btn_vales_petroleo.TabIndex = 13
        Me.btn_vales_petroleo.Text = "Detalle Reports Maquinaria FV por Obra"
        Me.btn_vales_petroleo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DETALLE REPORTS MAQUINARIA CONSTRUCTORA FV"
        '
        'txt_fecha_in
        '
        Me.txt_fecha_in.Location = New System.Drawing.Point(173, 71)
        Me.txt_fecha_in.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_in.Mask = "00/00/0000"
        Me.txt_fecha_in.Name = "txt_fecha_in"
        Me.txt_fecha_in.Size = New System.Drawing.Size(96, 22)
        Me.txt_fecha_in.TabIndex = 16
        Me.txt_fecha_in.ValidatingType = GetType(Date)
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.Location = New System.Drawing.Point(173, 102)
        Me.txt_fecha_fin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fecha_fin.Mask = "00/00/0000"
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(96, 22)
        Me.txt_fecha_fin.TabIndex = 17
        Me.txt_fecha_fin.ValidatingType = GetType(Date)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(369, 167)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 55)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Detalle Reports Maquinaria FV por Máquina"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_estado_de_pago_maquinaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 321)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_in)
        Me.Controls.Add(Me.btn_vales_petroleo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_estado_de_pago_maquinaria"
        Me.Text = "Detalle reports maquinaria Constructora FV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_vales_petroleo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_in As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_fin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
