<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_clientes_busqueda_cobranza_doc
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
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.gbx_Mov_Tierra.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Mov_Tierra
        '
        Me.gbx_Mov_Tierra.Controls.Add(Me.txt_documento)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Button3)
        Me.gbx_Mov_Tierra.Controls.Add(Me.Label1)
        Me.gbx_Mov_Tierra.Location = New System.Drawing.Point(12, 11)
        Me.gbx_Mov_Tierra.Name = "gbx_Mov_Tierra"
        Me.gbx_Mov_Tierra.Size = New System.Drawing.Size(761, 63)
        Me.gbx_Mov_Tierra.TabIndex = 1085
        Me.gbx_Mov_Tierra.TabStop = False
        Me.gbx_Mov_Tierra.Text = "Búsqueda Documento"
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(121, 28)
        Me.txt_documento.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(209, 20)
        Me.txt_documento.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(349, 12)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 36)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Buscar Documento"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "N° DOCUMENTO:"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(12, 79)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(756, 354)
        Me.dgv_clientes.TabIndex = 1086
        '
        'Frm_clientes_busqueda_cobranza_doc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 444)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.gbx_Mov_Tierra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_clientes_busqueda_cobranza_doc"
        Me.Text = "Búsqueda Cobranza"
        Me.gbx_Mov_Tierra.ResumeLayout(False)
        Me.gbx_Mov_Tierra.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbx_Mov_Tierra As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
End Class
