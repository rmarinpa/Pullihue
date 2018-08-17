<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_pagos
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
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_ingreso = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_consultaCheue = New System.Windows.Forms.Button()
        Me.btn_cobranza = New System.Windows.Forms.Button()
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 25)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "MENÚ REGISTRO PAGOS"
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
        'btn_registrar
        '
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_registrar.Location = New System.Drawing.Point(33, 56)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(116, 41)
        Me.btn_registrar.TabIndex = 1132
        Me.btn_registrar.Text = "Registrar Pago"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_ingreso
        '
        Me.btn_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ingreso.Location = New System.Drawing.Point(153, 56)
        Me.btn_ingreso.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ingreso.Name = "btn_ingreso"
        Me.btn_ingreso.Size = New System.Drawing.Size(116, 41)
        Me.btn_ingreso.TabIndex = 1133
        Me.btn_ingreso.Text = "Reporte de Ingresos"
        Me.btn_ingreso.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Red
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(273, 101)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(116, 41)
        Me.btn_salir.TabIndex = 1134
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(33, 101)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 41)
        Me.Button1.TabIndex = 1135
        Me.Button1.Text = "Modificar Pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_consultaCheue
        '
        Me.btn_consultaCheue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_consultaCheue.Location = New System.Drawing.Point(153, 101)
        Me.btn_consultaCheue.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consultaCheue.Name = "btn_consultaCheue"
        Me.btn_consultaCheue.Size = New System.Drawing.Size(116, 41)
        Me.btn_consultaCheue.TabIndex = 1136
        Me.btn_consultaCheue.Text = "Gestión Cheques"
        Me.btn_consultaCheue.UseVisualStyleBackColor = True
        '
        'btn_cobranza
        '
        Me.btn_cobranza.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cobranza.Location = New System.Drawing.Point(273, 56)
        Me.btn_cobranza.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cobranza.Name = "btn_cobranza"
        Me.btn_cobranza.Size = New System.Drawing.Size(116, 41)
        Me.btn_cobranza.TabIndex = 1137
        Me.btn_cobranza.Text = "Informe de Cobranza"
        Me.btn_cobranza.UseVisualStyleBackColor = True
        '
        'frm_menu_pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(410, 160)
        Me.Controls.Add(Me.btn_cobranza)
        Me.Controls.Add(Me.btn_consultaCheue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ingreso)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_menu_pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio Registro Pagos"
        CType(Me.PlandeCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plan_de_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PlandeCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Plan_de_Cuentas As Constructora_FV.Plan_de_Cuentas
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents btn_ingreso As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_consultaCheue As System.Windows.Forms.Button
    Friend WithEvents btn_cobranza As System.Windows.Forms.Button
End Class
