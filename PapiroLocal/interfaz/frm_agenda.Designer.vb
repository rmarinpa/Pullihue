<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agenda
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
        Me.mCal = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnRetornar = New System.Windows.Forms.Button()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mCal
        '
        Me.mCal.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.mCal.Location = New System.Drawing.Point(18, 53)
        Me.mCal.Name = "mCal"
        Me.mCal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(600, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DATOS DEL DÍA"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalvar.Location = New System.Drawing.Point(549, 462)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(144, 38)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Guardar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnRetornar
        '
        Me.btnRetornar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRetornar.Location = New System.Drawing.Point(719, 462)
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(144, 38)
        Me.btnRetornar.TabIndex = 5
        Me.btnRetornar.Text = "Retornar"
        Me.btnRetornar.UseVisualStyleBackColor = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(676, 19)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(45, 25)
        Me.lbl_fecha.TabIndex = 6
        Me.lbl_fecha.Text = "DIA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(505, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(420, 337)
        Me.DataGridView1.TabIndex = 7
        '
        'frm_agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1090, 709)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.btnRetornar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mCal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_agenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mCal As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnRetornar As System.Windows.Forms.Button
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
