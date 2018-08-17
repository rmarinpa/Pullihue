<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modificar_ticket
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbt_abierto = New System.Windows.Forms.RadioButton()
        Me.rbt_cerrado = New System.Windows.Forms.RadioButton()
        Me.cmb_prioridad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_ticket = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(13, 35)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(461, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 19)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha respueta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Estado"
        '
        'rbt_abierto
        '
        Me.rbt_abierto.AutoSize = True
        Me.rbt_abierto.Location = New System.Drawing.Point(174, 112)
        Me.rbt_abierto.Name = "rbt_abierto"
        Me.rbt_abierto.Size = New System.Drawing.Size(58, 17)
        Me.rbt_abierto.TabIndex = 5
        Me.rbt_abierto.TabStop = True
        Me.rbt_abierto.Text = "Abierto"
        Me.rbt_abierto.UseVisualStyleBackColor = True
        '
        'rbt_cerrado
        '
        Me.rbt_cerrado.AutoSize = True
        Me.rbt_cerrado.Location = New System.Drawing.Point(238, 112)
        Me.rbt_cerrado.Name = "rbt_cerrado"
        Me.rbt_cerrado.Size = New System.Drawing.Size(62, 17)
        Me.rbt_cerrado.TabIndex = 6
        Me.rbt_cerrado.TabStop = True
        Me.rbt_cerrado.Text = "Cerrado"
        Me.rbt_cerrado.UseVisualStyleBackColor = True
        '
        'cmb_prioridad
        '
        Me.cmb_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prioridad.FormattingEnabled = True
        Me.cmb_prioridad.Items.AddRange(New Object() {"Seleccione", "Muy baja", "Baja", "Media baja", "Media", "Media alta", "Alta", "Muy alta"})
        Me.cmb_prioridad.Location = New System.Drawing.Point(353, 106)
        Me.cmb_prioridad.Name = "cmb_prioridad"
        Me.cmb_prioridad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_prioridad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prioridad"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(15, 109)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(90, 20)
        Me.dtp_fecha.TabIndex = 9
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(514, 30)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(96, 29)
        Me.btn_buscar.TabIndex = 11
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(514, 100)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(96, 29)
        Me.btn_guardar.TabIndex = 12
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dgv_ticket
        '
        Me.dgv_ticket.AllowUserToAddRows = False
        Me.dgv_ticket.AllowUserToDeleteRows = False
        Me.dgv_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ticket.Location = New System.Drawing.Point(26, 145)
        Me.dgv_ticket.MultiSelect = False
        Me.dgv_ticket.Name = "dgv_ticket"
        Me.dgv_ticket.ReadOnly = True
        Me.dgv_ticket.RowHeadersVisible = False
        Me.dgv_ticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ticket.Size = New System.Drawing.Size(569, 219)
        Me.dgv_ticket.TabIndex = 13
        '
        'frm_modificar_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(626, 376)
        Me.Controls.Add(Me.dgv_ticket)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_prioridad)
        Me.Controls.Add(Me.rbt_cerrado)
        Me.Controls.Add(Me.rbt_abierto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_modificar_ticket"
        Me.Text = "Actualiar ticket"
        CType(Me.dgv_ticket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbt_abierto As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_cerrado As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents dgv_ticket As System.Windows.Forms.DataGridView
End Class
