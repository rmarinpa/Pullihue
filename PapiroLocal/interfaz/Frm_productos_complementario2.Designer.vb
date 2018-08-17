<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_productos_complementario2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_medidas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.gbx_Mov_Tierra.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_medidas)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label2)
        Me.gbx_Mov_Tierra.Controls.Add(Me.cmb_marca)
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_cliente)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(16, 14)
        Me.gbx_Mov_Tierra.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(1015, 119)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Búsqueda Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 1095
        Me.Label3.Text = "MEDIDAS:"
        '
        'cmb_medidas
        '
        Me.cmb_medidas.FormattingEnabled = True
        Me.cmb_medidas.Location = New System.Drawing.Point(104, 80)
        Me.cmb_medidas.Name = "cmb_medidas"
        Me.cmb_medidas.Size = New System.Drawing.Size(234, 24)
        Me.cmb_medidas.TabIndex = 1094
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 1093
        Me.Label2.Text = "MARCA:"
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(104, 50)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(234, 24)
        Me.cmb_marca.TabIndex = 1092
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(104, 22)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(731, 22)
        Me.txt_cliente.TabIndex = 1091
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(859, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 41)
        Me.Button3.TabIndex = 1088
        Me.Button3.Text = "Buscar Producto"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "PRODUCTO:"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(16, 140)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(1008, 394)
        Me.dgv_clientes.TabIndex = 1086
        '
        'Frm_ventas_productos_busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1043, 546)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_ventas_productos_busqueda"
        Me.Text = "Búsqueda Producto"
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_medidas As System.Windows.Forms.ComboBox
End Class
