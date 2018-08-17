<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nuevo_ticket
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.lbl_comentario = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_solicitud_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(64, 66)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(419, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(64, 47)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(64, 123)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(419, 174)
        Me.txt_comentario.TabIndex = 2
        '
        'lbl_comentario
        '
        Me.lbl_comentario.AutoSize = True
        Me.lbl_comentario.Location = New System.Drawing.Point(64, 107)
        Me.lbl_comentario.Name = "lbl_comentario"
        Me.lbl_comentario.Size = New System.Drawing.Size(60, 13)
        Me.lbl_comentario.TabIndex = 3
        Me.lbl_comentario.Text = "Comentario"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(176, 324)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(170, 55)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_solicitud_id
        '
        Me.txt_solicitud_id.Enabled = False
        Me.txt_solicitud_id.Location = New System.Drawing.Point(383, 22)
        Me.txt_solicitud_id.Name = "txt_solicitud_id"
        Me.txt_solicitud_id.ReadOnly = True
        Me.txt_solicitud_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_solicitud_id.TabIndex = 9
        Me.txt_solicitud_id.Text = "0"
        Me.txt_solicitud_id.Visible = False
        '
        'frm_nuevo_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 391)
        Me.Controls.Add(Me.txt_solicitud_id)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.lbl_comentario)
        Me.Controls.Add(Me.txt_comentario)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_nuevo_ticket"
        Me.Text = "Nuevo Ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_comentario As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_solicitud_id As System.Windows.Forms.TextBox
End Class
