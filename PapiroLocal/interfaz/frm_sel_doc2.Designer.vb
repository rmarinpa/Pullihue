<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sel_doc2
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
        Me.btn_muestra = New System.Windows.Forms.Button()
        Me.btn_direccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_muestra
        '
        Me.btn_muestra.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_muestra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_muestra.ForeColor = System.Drawing.Color.White
        Me.btn_muestra.Location = New System.Drawing.Point(13, 11)
        Me.btn_muestra.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_muestra.Name = "btn_muestra"
        Me.btn_muestra.Size = New System.Drawing.Size(446, 66)
        Me.btn_muestra.TabIndex = 0
        Me.btn_muestra.Text = "Factura"
        Me.btn_muestra.UseVisualStyleBackColor = False
        '
        'btn_direccion
        '
        Me.btn_direccion.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_direccion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_direccion.ForeColor = System.Drawing.Color.White
        Me.btn_direccion.Location = New System.Drawing.Point(13, 85)
        Me.btn_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_direccion.Name = "btn_direccion"
        Me.btn_direccion.Size = New System.Drawing.Size(446, 66)
        Me.btn_direccion.TabIndex = 1
        Me.btn_direccion.Text = "Guía de Despacho"
        Me.btn_direccion.UseVisualStyleBackColor = False
        '
        'frm_sel_doc2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(472, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_direccion)
        Me.Controls.Add(Me.btn_muestra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_sel_doc2"
        Me.Text = "Seleccionar Documento"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_muestra As System.Windows.Forms.Button
    Friend WithEvents btn_direccion As System.Windows.Forms.Button
End Class
