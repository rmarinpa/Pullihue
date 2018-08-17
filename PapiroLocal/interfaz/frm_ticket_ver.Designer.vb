<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ticket_ver
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
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_asunto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_mostrando = New System.Windows.Forms.Label()
        Me.dgv_ticket = New System.Windows.Forms.DataGridView()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.lbl_cantidadTotal = New System.Windows.Forms.Label()
        CType(Me.dgv_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(529, 42)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 0
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(28, 42)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(211, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_asunto
        '
        Me.txt_asunto.Location = New System.Drawing.Point(274, 42)
        Me.txt_asunto.Name = "txt_asunto"
        Me.txt_asunto.Size = New System.Drawing.Size(220, 20)
        Me.txt_asunto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'lbl_mostrando
        '
        Me.lbl_mostrando.AutoSize = True
        Me.lbl_mostrando.Location = New System.Drawing.Point(208, 341)
        Me.lbl_mostrando.Name = "lbl_mostrando"
        Me.lbl_mostrando.Size = New System.Drawing.Size(72, 13)
        Me.lbl_mostrando.TabIndex = 4
        Me.lbl_mostrando.Text = "lbl_mostrando"
        Me.lbl_mostrando.Visible = False
        '
        'dgv_ticket
        '
        Me.dgv_ticket.AllowUserToAddRows = False
        Me.dgv_ticket.AllowUserToDeleteRows = False
        Me.dgv_ticket.AllowUserToResizeColumns = False
        Me.dgv_ticket.AllowUserToResizeRows = False
        Me.dgv_ticket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ticket.Location = New System.Drawing.Point(25, 75)
        Me.dgv_ticket.MultiSelect = False
        Me.dgv_ticket.Name = "dgv_ticket"
        Me.dgv_ticket.ReadOnly = True
        Me.dgv_ticket.RowHeadersVisible = False
        Me.dgv_ticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ticket.Size = New System.Drawing.Size(579, 245)
        Me.dgv_ticket.TabIndex = 5
        '
        'btn_anterior
        '
        Me.btn_anterior.Location = New System.Drawing.Point(437, 341)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(75, 23)
        Me.btn_anterior.TabIndex = 6
        Me.btn_anterior.Text = "Anterior"
        Me.btn_anterior.UseVisualStyleBackColor = True
        Me.btn_anterior.Visible = False
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Location = New System.Drawing.Point(529, 341)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(75, 23)
        Me.btn_siguiente.TabIndex = 7
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        Me.btn_siguiente.Visible = False
        '
        'lbl_cantidadTotal
        '
        Me.lbl_cantidadTotal.AutoSize = True
        Me.lbl_cantidadTotal.Location = New System.Drawing.Point(25, 341)
        Me.lbl_cantidadTotal.Name = "lbl_cantidadTotal"
        Me.lbl_cantidadTotal.Size = New System.Drawing.Size(88, 13)
        Me.lbl_cantidadTotal.TabIndex = 8
        Me.lbl_cantidadTotal.Text = "lbl_cantidadTotal"
        Me.lbl_cantidadTotal.Visible = False
        '
        'frm_ticket_ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(635, 378)
        Me.Controls.Add(Me.lbl_cantidadTotal)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.dgv_ticket)
        Me.Controls.Add(Me.lbl_mostrando)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_asunto)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ticket_ver"
        Me.Text = "Ticket's"
        CType(Me.dgv_ticket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_asunto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_mostrando As System.Windows.Forms.Label
    Friend WithEvents dgv_ticket As System.Windows.Forms.DataGridView
    Friend WithEvents btn_anterior As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents lbl_cantidadTotal As System.Windows.Forms.Label
End Class
