<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_solicitud_ticket
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
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.pnl_body = New System.Windows.Forms.Panel()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_solicitante = New System.Windows.Forms.Label()
        Me.btn_historial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 94)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 75)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(12, 219)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 75)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'pnl_body
        '
        Me.pnl_body.Location = New System.Drawing.Point(107, 77)
        Me.pnl_body.Name = "pnl_body"
        Me.pnl_body.Size = New System.Drawing.Size(663, 411)
        Me.pnl_body.TabIndex = 2
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(241, 15)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(163, 42)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "lbl_titulo"
        '
        'Timer1
        '
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(565, 28)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(54, 20)
        Me.lbl_fecha.TabIndex = 4
        Me.lbl_fecha.Text = "fecha"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.Location = New System.Drawing.Point(680, 28)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(45, 20)
        Me.lbl_hora.TabIndex = 5
        Me.lbl_hora.Text = "hora"
        '
        'lbl_solicitante
        '
        Me.lbl_solicitante.AutoSize = True
        Me.lbl_solicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_solicitante.Location = New System.Drawing.Point(12, 28)
        Me.lbl_solicitante.Name = "lbl_solicitante"
        Me.lbl_solicitante.Size = New System.Drawing.Size(133, 20)
        Me.lbl_solicitante.TabIndex = 6
        Me.lbl_solicitante.Text = "nombre usuario"
        '
        'btn_historial
        '
        Me.btn_historial.Location = New System.Drawing.Point(12, 340)
        Me.btn_historial.Name = "btn_historial"
        Me.btn_historial.Size = New System.Drawing.Size(75, 75)
        Me.btn_historial.TabIndex = 7
        Me.btn_historial.Text = "Ver Ticket"
        Me.btn_historial.UseVisualStyleBackColor = True
        '
        'frm_solicitud_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 500)
        Me.Controls.Add(Me.btn_historial)
        Me.Controls.Add(Me.lbl_solicitante)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.pnl_body)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_solicitud_ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de ticket's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents pnl_body As System.Windows.Forms.Panel
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents lbl_solicitante As System.Windows.Forms.Label
    Friend WithEvents btn_historial As System.Windows.Forms.Button
End Class
