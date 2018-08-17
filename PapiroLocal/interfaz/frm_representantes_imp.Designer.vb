<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_representates_imp
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_imp = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv_items = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_imp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(577, 17)
        Me.Label5.TabIndex = 1221
        Me.Label5.Text = "Nota: Para eliminar un ítem se tiene que hacer doble click en la tabla de ítems r" & _
            "egistrados."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(586, 90)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(179, 32)
        Me.ProgressBar1.TabIndex = 1220
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(642, 36)
        Me.Label4.TabIndex = 1219
        Me.Label4.Text = "REGISTRO DE CLIENTES - IMPORTACIÓN"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Location = New System.Drawing.Point(299, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 49)
        Me.Button2.TabIndex = 1218
        Me.Button2.Text = "IMPORTAR DATOS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 29)
        Me.Label2.TabIndex = 1217
        Me.Label2.Text = "TABLA DE ÍTEMS REGISTRADOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(771, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 29)
        Me.Label1.TabIndex = 1216
        Me.Label1.Text = "TABLA DE IMPORTACIÓN"
        '
        'dgv_imp
        '
        Me.dgv_imp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_imp.Location = New System.Drawing.Point(12, 139)
        Me.dgv_imp.Name = "dgv_imp"
        Me.dgv_imp.RowTemplate.Height = 24
        Me.dgv_imp.Size = New System.Drawing.Size(1132, 232)
        Me.dgv_imp.TabIndex = 1214
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LawnGreen
        Me.Button4.Location = New System.Drawing.Point(12, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(281, 49)
        Me.Button4.TabIndex = 1213
        Me.Button4.Text = "CARGAR EXCEL"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgv_items
        '
        Me.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_items.Location = New System.Drawing.Point(12, 443)
        Me.dgv_items.Name = "dgv_items"
        Me.dgv_items.RowTemplate.Height = 24
        Me.dgv_items.Size = New System.Drawing.Size(1132, 272)
        Me.dgv_items.TabIndex = 1212
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.Location = New System.Drawing.Point(656, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 49)
        Me.Button1.TabIndex = 1223
        Me.Button1.Text = "ELIMINAR DATOS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_representates_imp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1165, 795)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_imp)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dgv_items)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_representates_imp"
        Me.Text = "Representantes"
        CType(Me.dgv_imp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_imp As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dgv_items As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
