<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ventas_clientes_busqueda
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
        Me.GB_contenedor = New System.Windows.Forms.GroupBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_buscar_cliente = New System.Windows.Forms.Button()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.GB_contenedor.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_contenedor
        '
        Me.GB_contenedor.Controls.Add(Me.txt_rut)
        Me.GB_contenedor.Controls.Add(Me.Label2)
        Me.GB_contenedor.Controls.Add(Me.txt_cliente)
        Me.GB_contenedor.Controls.Add(Me.Label1)
        Me.GB_contenedor.Location = New System.Drawing.Point(12, 12)
        Me.GB_contenedor.Name = "GB_contenedor"
        Me.GB_contenedor.Size = New System.Drawing.Size(554, 90)
        Me.GB_contenedor.TabIndex = 1085
        Me.GB_contenedor.TabStop = False
        Me.GB_contenedor.Text = "Búsqueda Cliente"
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(80, 54)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(455, 20)
        Me.txt_rut.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1092
        Me.Label2.Text = "RUT"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(80, 23)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(455, 20)
        Me.txt_cliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CLIENTE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(359, 204)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar Cliente por Rut"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_buscar_cliente
        '
        Me.btn_buscar_cliente.BackColor = System.Drawing.Color.Cyan
        Me.btn_buscar_cliente.Location = New System.Drawing.Point(359, 163)
        Me.btn_buscar_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar_cliente.Name = "btn_buscar_cliente"
        Me.btn_buscar_cliente.Size = New System.Drawing.Size(112, 37)
        Me.btn_buscar_cliente.TabIndex = 1
        Me.btn_buscar_cliente.Text = "Buscar Cliente"
        Me.btn_buscar_cliente.UseVisualStyleBackColor = False
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AllowUserToResizeRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(12, 107)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_clientes.MultiSelect = False
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(687, 160)
        Me.dgv_clientes.TabIndex = 1086
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Cyan
        Me.btn_buscar.Location = New System.Drawing.Point(582, 32)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(117, 50)
        Me.btn_buscar.TabIndex = 1087
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(263, 281)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(177, 13)
        Me.lbl_cantidad.TabIndex = 1091
        Me.lbl_cantidad.Text = "No hay registros encontrados."
        '
        'Frm_ventas_clientes_busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(711, 303)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.GB_contenedor)
        Me.Controls.Add(Me.btn_buscar_cliente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_ventas_clientes_busqueda"
        Me.Text = "Venta Cliente"
        Me.GB_contenedor.ResumeLayout(False)
        Me.GB_contenedor.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents GB_contenedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar_cliente As System.Windows.Forms.Button
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
End Class
