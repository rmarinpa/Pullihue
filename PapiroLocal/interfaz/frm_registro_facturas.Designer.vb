<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_facturas
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
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PlandeCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Plan_de_Cuentas = New Constructora_FV.Plan_de_Cuentas()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_facturas = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pago = New System.Windows.Forms.TextBox()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.dgv_registro = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(555, 31)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "REGISTRO DE FACTURAS POR PAGAR"
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(142, 248)
        Me.txt_nombre_obra.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(204, 22)
        Me.txt_nombre_obra.TabIndex = 1154
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 253)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 1155
        Me.Label10.Text = "EJECUTIVO:"
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
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(309, 83)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(362, 22)
        Me.txt_cliente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Factura"
        '
        'cmb_facturas
        '
        Me.cmb_facturas.FormattingEnabled = True
        Me.cmb_facturas.Location = New System.Drawing.Point(98, 83)
        Me.cmb_facturas.Name = "cmb_facturas"
        Me.cmb_facturas.Size = New System.Drawing.Size(118, 24)
        Me.cmb_facturas.TabIndex = 0
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar.Location = New System.Drawing.Point(471, 141)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(135, 47)
        Me.btn_agregar.TabIndex = 1161
        Me.btn_agregar.Text = "AGREGAR REGISTRO"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Location = New System.Drawing.Point(471, 194)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(135, 47)
        Me.btn_eliminar.TabIndex = 1162
        Me.btn_eliminar.Text = "FINALIZAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(98, 113)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(118, 22)
        Me.txt_total.TabIndex = 1164
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 1163
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 1165
        Me.Label6.Text = "Monto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 1166
        Me.Label7.Text = "a pagar"
        '
        'txt_pago
        '
        Me.txt_pago.Location = New System.Drawing.Point(76, 37)
        Me.txt_pago.Name = "txt_pago"
        Me.txt_pago.Size = New System.Drawing.Size(118, 22)
        Me.txt_pago.TabIndex = 1167
        '
        'txt_saldo
        '
        Me.txt_saldo.Location = New System.Drawing.Point(76, 65)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(118, 22)
        Me.txt_saldo.TabIndex = 1169
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 1168
        Me.Label9.Text = "Saldo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_saldo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_pago)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox1.TabIndex = 1170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago"
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(353, 248)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(37, 22)
        Me.txt_folio.TabIndex = 1172
        Me.txt_folio.Visible = False
        '
        'dgv_registro
        '
        Me.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registro.Location = New System.Drawing.Point(661, 12)
        Me.dgv_registro.Name = "dgv_registro"
        Me.dgv_registro.RowTemplate.Height = 24
        Me.dgv_registro.Size = New System.Drawing.Size(10, 10)
        Me.dgv_registro.TabIndex = 1173
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(222, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 33)
        Me.Button1.TabIndex = 1174
        Me.Button1.Text = "Tomar Valor"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_registro_facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 284)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_registro)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_facturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_registro_facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Facturas por Pagar"
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlandeCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Plan_de_Cuentas As Constructora_FV.Plan_de_Cuentas
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_facturas As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_pago As System.Windows.Forms.TextBox
    Friend WithEvents txt_saldo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents dgv_registro As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
