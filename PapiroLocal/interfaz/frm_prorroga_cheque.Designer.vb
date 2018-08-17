<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_prorroga_cheque
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar_cambios = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.dtp_prorroga = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "FECHA PRORROGA"
        '
        'btn_guardar_cambios
        '
        Me.btn_guardar_cambios.BackColor = System.Drawing.Color.LightGray
        Me.btn_guardar_cambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_cambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_cambios.Location = New System.Drawing.Point(190, 9)
        Me.btn_guardar_cambios.Name = "btn_guardar_cambios"
        Me.btn_guardar_cambios.Size = New System.Drawing.Size(162, 35)
        Me.btn_guardar_cambios.TabIndex = 1109
        Me.btn_guardar_cambios.Text = "Guardar Cambios"
        Me.btn_guardar_cambios.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.LightGray
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.Location = New System.Drawing.Point(190, 50)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(162, 35)
        Me.btn_cerrar.TabIndex = 1110
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'dtp_prorroga
        '
        Me.dtp_prorroga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_prorroga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_prorroga.Location = New System.Drawing.Point(40, 38)
        Me.dtp_prorroga.Name = "dtp_prorroga"
        Me.dtp_prorroga.Size = New System.Drawing.Size(118, 22)
        Me.dtp_prorroga.TabIndex = 1111
        '
        'frm_prorroga_cheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(364, 97)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtp_prorroga)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_guardar_cambios)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_prorroga_cheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prorroga"
        Me.TransparencyKey = System.Drawing.Color.Tomato
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar_cambios As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents dtp_prorroga As System.Windows.Forms.DateTimePicker
End Class
