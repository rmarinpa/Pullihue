<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mod_pagos2
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PlandeCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Plan_de_Cuentas = New Constructora_FV.Plan_de_Cuentas()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.dtp_fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.lbl_pago = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_operacion = New System.Windows.Forms.ComboBox()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(196, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 25)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "CAMBIAR CHEQUE"
        '
        'PlandeCuentasBindingSource
        '
        Me.PlandeCuentasBindingSource.DataSource = Me.Plan_de_Cuentas
        Me.PlandeCuentasBindingSource.Position = 0
        '
        'Plan_de_Cuentas
        '
        Me.Plan_de_Cuentas.DataSetName = "Plan_de_Cuentas"
        Me.Plan_de_Cuentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.Blue
        Me.btn_modificar.ForeColor = System.Drawing.Color.White
        Me.btn_modificar.Location = New System.Drawing.Point(566, 20)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 50)
        Me.btn_modificar.TabIndex = 1161
        Me.btn_modificar.Text = "CAMBIAR CHEQUE"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cerrar)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_pago)
        Me.GroupBox1.Controls.Add(Me.lbl_pago)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_banco)
        Me.GroupBox1.Controls.Add(Me.txt_serie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_operacion)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(680, 128)
        Me.GroupBox1.TabIndex = 1167
        Me.GroupBox1.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Red
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(566, 74)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(101, 50)
        Me.btn_cerrar.TabIndex = 1183
        Me.btn_cerrar.Text = "CERRAR"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'dtp_fecha_pago
        '
        Me.dtp_fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pago.Location = New System.Drawing.Point(394, 46)
        Me.dtp_fecha_pago.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_fecha_pago.Name = "dtp_fecha_pago"
        Me.dtp_fecha_pago.Size = New System.Drawing.Size(154, 20)
        Me.dtp_fecha_pago.TabIndex = 1166
        '
        'lbl_pago
        '
        Me.lbl_pago.AutoSize = True
        Me.lbl_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pago.Location = New System.Drawing.Point(272, 52)
        Me.lbl_pago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_pago.Name = "lbl_pago"
        Me.lbl_pago.Size = New System.Drawing.Size(110, 13)
        Me.lbl_pago.TabIndex = 1167
        Me.lbl_pago.Text = "FECHA DE PAGO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(333, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1165
        Me.Label4.Text = "BANCO"
        '
        'cmb_banco
        '
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Items.AddRange(New Object() {"Banco BCI", "Banco de Chile", "Banco Estado", "Banco Santander", "Banco BBVA", "Banco BCI Nova", "Banco BICE", "Banco Condell", "Banco CrediChile", "Banco Edwards Citi", "Banco Falabella", "Banco Internacional", "Banco Itaú", "Banco Paris", "Banco Penta", "Banco Ripley", "Banco Security", "Banco del Desarrollo", "CorpBanca", "Santander Banefe", "Scotiabank", "TBanc", "Bank of Tokyo-Mitsubishi", "Credit Suisse", "Deutsche Bank", "HSBC", "J.P. Morgan", "Rabobank", "UBS"})
        Me.cmb_banco.Location = New System.Drawing.Point(394, 20)
        Me.cmb_banco.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(154, 21)
        Me.cmb_banco.TabIndex = 1164
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(95, 49)
        Me.txt_serie.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(154, 20)
        Me.txt_serie.TabIndex = 1163
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1162
        Me.Label3.Text = "SERIE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1160
        Me.Label1.Text = "OPERACIÓN"
        '
        'cmb_operacion
        '
        Me.cmb_operacion.FormattingEnabled = True
        Me.cmb_operacion.Items.AddRange(New Object() {"CHEQUE", "DEPOSITO DIRECTO", "EFECTIVO", "TRANSFERENCIA", "OTRO"})
        Me.cmb_operacion.Location = New System.Drawing.Point(95, 17)
        Me.cmb_operacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_operacion.Name = "cmb_operacion"
        Me.cmb_operacion.Size = New System.Drawing.Size(154, 21)
        Me.cmb_operacion.TabIndex = 1159
        '
        'frm_mod_pagos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_mod_pagos2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIAR CHEQUE"
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PlandeCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Plan_de_Cuentas As Constructora_FV.Plan_de_Cuentas
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents txt_serie As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_operacion As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_pago As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
End Class
