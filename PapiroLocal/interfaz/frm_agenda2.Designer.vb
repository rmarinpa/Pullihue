<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agenda2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rev2 = New System.Windows.Forms.TextBox()
        Me.txt_rev = New System.Windows.Forms.TextBox()
        Me.btn_hecho = New System.Windows.Forms.Button()
        Me.btn_detalle = New System.Windows.Forms.Button()
        Me.dgv_agenda = New System.Windows.Forms.DataGridView()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_rev2)
        Me.Panel1.Controls.Add(Me.txt_rev)
        Me.Panel1.Controls.Add(Me.btn_hecho)
        Me.Panel1.Controls.Add(Me.btn_detalle)
        Me.Panel1.Controls.Add(Me.dgv_agenda)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Location = New System.Drawing.Point(0, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1930, 514)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(944, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(202, 41)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(656, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(282, 41)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Agendar nueva tarea"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1060, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NO REVISADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1060, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "REVISADO"
        '
        'txt_rev2
        '
        Me.txt_rev2.BackColor = System.Drawing.Color.LightSalmon
        Me.txt_rev2.Location = New System.Drawing.Point(943, 455)
        Me.txt_rev2.Name = "txt_rev2"
        Me.txt_rev2.Size = New System.Drawing.Size(100, 22)
        Me.txt_rev2.TabIndex = 6
        '
        'txt_rev
        '
        Me.txt_rev.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_rev.Location = New System.Drawing.Point(943, 427)
        Me.txt_rev.Name = "txt_rev"
        Me.txt_rev.Size = New System.Drawing.Size(100, 22)
        Me.txt_rev.TabIndex = 5
        '
        'btn_hecho
        '
        Me.btn_hecho.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_hecho.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_hecho.Location = New System.Drawing.Point(605, 417)
        Me.btn_hecho.Name = "btn_hecho"
        Me.btn_hecho.Size = New System.Drawing.Size(156, 37)
        Me.btn_hecho.TabIndex = 4
        Me.btn_hecho.Text = "HECHO"
        Me.btn_hecho.UseVisualStyleBackColor = False
        '
        'btn_detalle
        '
        Me.btn_detalle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detalle.Location = New System.Drawing.Point(605, 474)
        Me.btn_detalle.Name = "btn_detalle"
        Me.btn_detalle.Size = New System.Drawing.Size(156, 37)
        Me.btn_detalle.TabIndex = 3
        Me.btn_detalle.Text = "DETALLE"
        Me.btn_detalle.UseVisualStyleBackColor = False
        Me.btn_detalle.Visible = False
        '
        'dgv_agenda
        '
        Me.dgv_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_agenda.Location = New System.Drawing.Point(605, 77)
        Me.dgv_agenda.Name = "dgv_agenda"
        Me.dgv_agenda.RowTemplate.Height = 24
        Me.dgv_agenda.Size = New System.Drawing.Size(1310, 320)
        Me.dgv_agenda.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 34)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AGENDA COBRANZA"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Magenta
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1152, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Editar Tarea"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_agenda2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1914, 648)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_agenda2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_agenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_agenda As System.Windows.Forms.DataGridView
    Friend WithEvents btn_hecho As System.Windows.Forms.Button
    Friend WithEvents btn_detalle As System.Windows.Forms.Button
    Friend WithEvents txt_rev2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rev As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
