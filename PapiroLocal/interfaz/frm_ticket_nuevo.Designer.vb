<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ticket_nuevo
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
        Me.txt_asunto = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.lbl_comentario = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_solicitud_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_nombre = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_prioridad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_departamento = New System.Windows.Forms.ComboBox()
        Me.lbl_adjuntar = New System.Windows.Forms.Label()
        Me.txt_ruta_archivo = New System.Windows.Forms.TextBox()
        Me.btn_adjuntar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_registro = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_asunto
        '
        Me.txt_asunto.Location = New System.Drawing.Point(59, 86)
        Me.txt_asunto.Name = "txt_asunto"
        Me.txt_asunto.Size = New System.Drawing.Size(419, 20)
        Me.txt_asunto.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(59, 67)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(40, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Asunto"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(59, 194)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(419, 87)
        Me.txt_comentario.TabIndex = 2
        '
        'lbl_comentario
        '
        Me.lbl_comentario.AutoSize = True
        Me.lbl_comentario.Location = New System.Drawing.Point(61, 178)
        Me.lbl_comentario.Name = "lbl_comentario"
        Me.lbl_comentario.Size = New System.Drawing.Size(60, 13)
        Me.lbl_comentario.TabIndex = 3
        Me.lbl_comentario.Text = "Comentario"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(169, 311)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(170, 55)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_solicitud_id
        '
        Me.txt_solicitud_id.Enabled = False
        Me.txt_solicitud_id.Location = New System.Drawing.Point(509, 7)
        Me.txt_solicitud_id.Name = "txt_solicitud_id"
        Me.txt_solicitud_id.ReadOnly = True
        Me.txt_solicitud_id.Size = New System.Drawing.Size(38, 20)
        Me.txt_solicitud_id.TabIndex = 9
        Me.txt_solicitud_id.Text = "0"
        Me.txt_solicitud_id.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'mtxt_nombre
        '
        Me.mtxt_nombre.Enabled = False
        Me.mtxt_nombre.Location = New System.Drawing.Point(59, 31)
        Me.mtxt_nombre.Name = "mtxt_nombre"
        Me.mtxt_nombre.Size = New System.Drawing.Size(129, 20)
        Me.mtxt_nombre.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Prioridad"
        '
        'cmb_prioridad
        '
        Me.cmb_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prioridad.FormattingEnabled = True
        Me.cmb_prioridad.Items.AddRange(New Object() {"Seleccione", "Muy baja", "Baja", "Media baja", "Media", "Media alta", "Alta", "Muy alta"})
        Me.cmb_prioridad.Location = New System.Drawing.Point(215, 30)
        Me.cmb_prioridad.Name = "cmb_prioridad"
        Me.cmb_prioridad.Size = New System.Drawing.Size(103, 21)
        Me.cmb_prioridad.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Departamento"
        '
        'cmb_departamento
        '
        Me.cmb_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(354, 30)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(124, 21)
        Me.cmb_departamento.TabIndex = 16
        '
        'lbl_adjuntar
        '
        Me.lbl_adjuntar.AutoSize = True
        Me.lbl_adjuntar.Location = New System.Drawing.Point(59, 123)
        Me.lbl_adjuntar.Name = "lbl_adjuntar"
        Me.lbl_adjuntar.Size = New System.Drawing.Size(46, 13)
        Me.lbl_adjuntar.TabIndex = 19
        Me.lbl_adjuntar.Text = "Adjuntar"
        '
        'txt_ruta_archivo
        '
        Me.txt_ruta_archivo.Location = New System.Drawing.Point(59, 142)
        Me.txt_ruta_archivo.Name = "txt_ruta_archivo"
        Me.txt_ruta_archivo.ReadOnly = True
        Me.txt_ruta_archivo.Size = New System.Drawing.Size(280, 20)
        Me.txt_ruta_archivo.TabIndex = 18
        '
        'btn_adjuntar
        '
        Me.btn_adjuntar.Location = New System.Drawing.Point(363, 134)
        Me.btn_adjuntar.Name = "btn_adjuntar"
        Me.btn_adjuntar.Size = New System.Drawing.Size(111, 35)
        Me.btn_adjuntar.TabIndex = 20
        Me.btn_adjuntar.Text = "Adjuntar"
        Me.btn_adjuntar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgv_registro
        '
        Me.dgv_registro.AllowUserToAddRows = False
        Me.dgv_registro.AllowUserToDeleteRows = False
        Me.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registro.Location = New System.Drawing.Point(537, 30)
        Me.dgv_registro.Name = "dgv_registro"
        Me.dgv_registro.ReadOnly = True
        Me.dgv_registro.Size = New System.Drawing.Size(10, 10)
        Me.dgv_registro.TabIndex = 31
        Me.dgv_registro.Visible = False
        '
        'frm_ticket_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(559, 404)
        Me.Controls.Add(Me.dgv_registro)
        Me.Controls.Add(Me.btn_adjuntar)
        Me.Controls.Add(Me.lbl_adjuntar)
        Me.Controls.Add(Me.txt_ruta_archivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_departamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_prioridad)
        Me.Controls.Add(Me.mtxt_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_solicitud_id)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.lbl_comentario)
        Me.Controls.Add(Me.txt_comentario)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_asunto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ticket_nuevo"
        Me.Text = "Nuevo Ticket"
        CType(Me.dgv_registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_asunto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_comentario As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_solicitud_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_nombre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_adjuntar As System.Windows.Forms.Label
    Friend WithEvents txt_ruta_archivo As System.Windows.Forms.TextBox
    Friend WithEvents btn_adjuntar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgv_registro As System.Windows.Forms.DataGridView
End Class
