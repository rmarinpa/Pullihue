<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_clientes_busqueda_mapa
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
        Me.gbx_Mov_Tierra = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_in = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_rut2 = New System.Windows.Forms.TextBox()
        Me.gbx_Mov_Tierra.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button1)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_rut)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_cliente)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(12, 11)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(761, 93)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Búsqueda Cliente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(644, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar Cliente por Rut"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(72, 59)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(549, 20)
        Me.txt_rut.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1092
        Me.Label2.Text = "RUT:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(72, 28)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(549, 20)
        Me.txt_cliente.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(644, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 36)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Buscar Cliente"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CLIENTE:"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(11, 182)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(756, 267)
        Me.dgv_clientes.TabIndex = 1086
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dtp_fecha_in)
        Me.GroupBox2.Controls.Add(Me.dtp_fecha_fin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(437, 69)
        Me.GroupBox2.TabIndex = 1236
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios de Búsqueda"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(238, 34)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 1232
        Me.Label14.Text = "FECHA FINAL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 34)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 1231
        Me.Label13.Text = "FECHA INICIAL:"
        '
        'dtp_fecha_in
        '
        Me.dtp_fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_in.Location = New System.Drawing.Point(133, 34)
        Me.dtp_fecha_in.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_fecha_in.Name = "dtp_fecha_in"
        Me.dtp_fecha_in.Size = New System.Drawing.Size(82, 20)
        Me.dtp_fecha_in.TabIndex = 1230
        Me.dtp_fecha_in.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'dtp_fecha_fin
        '
        Me.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fin.Location = New System.Drawing.Point(332, 34)
        Me.dtp_fecha_fin.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_fecha_fin.Name = "dtp_fecha_fin"
        Me.dtp_fecha_fin.Size = New System.Drawing.Size(82, 20)
        Me.dtp_fecha_fin.TabIndex = 1215
        Me.dtp_fecha_fin.Value = New Date(2016, 7, 18, 16, 9, 7, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 13)
        Me.Label3.TabIndex = 1216
        Me.Label3.Text = "SELECCIÓN DE FECHA DE PEDIDOS"
        '
        'txt_rut2
        '
        Me.txt_rut2.Location = New System.Drawing.Point(469, 121)
        Me.txt_rut2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rut2.Name = "txt_rut2"
        Me.txt_rut2.Size = New System.Drawing.Size(39, 20)
        Me.txt_rut2.TabIndex = 1237
        Me.txt_rut2.Visible = False
        '
        'Frm_clientes_busqueda_mapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 460)
        Me.Controls.Add(Me.txt_rut2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "Frm_clientes_busqueda_mapa"
        Me.Text = "Búsqueda Cliente"
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_rut2 As System.Windows.Forms.TextBox
End Class
