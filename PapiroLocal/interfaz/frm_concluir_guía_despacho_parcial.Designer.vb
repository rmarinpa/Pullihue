<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_concluir_guía_despacho_parcial
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
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.dgv_facturas = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(344, 36)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 0
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(90, 36)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(235, 20)
        Me.txt_cliente.TabIndex = 2
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(12, 79)
        Me.dgv_clientes.MultiSelect = False
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(431, 150)
        Me.dgv_clientes.TabIndex = 3
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.ForeColor = System.Drawing.Color.Red
        Me.lbl_mensaje.Location = New System.Drawing.Point(12, 245)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(53, 13)
        Me.lbl_mensaje.TabIndex = 4
        Me.lbl_mensaje.Text = "mesnaje"
        Me.lbl_mensaje.Visible = False
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Location = New System.Drawing.Point(433, 12)
        Me.dgv_facturas.MultiSelect = False
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.RowHeadersVisible = False
        Me.dgv_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas.Size = New System.Drawing.Size(10, 10)
        Me.dgv_facturas.TabIndex = 5
        '
        'frm_concluir_guía_despacho_parcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 276)
        Me.Controls.Add(Me.dgv_facturas)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Name = "frm_concluir_guía_despacho_parcial"
        Me.Text = "Concluir guía con despacho parcial"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
End Class
