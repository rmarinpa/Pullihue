<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consultaCheque
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
        Me.GB_contenedor = New System.Windows.Forms.GroupBox()
        Me.txt_numeroCheque = New System.Windows.Forms.ComboBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nCheque = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpbx_protestado = New System.Windows.Forms.GroupBox()
        Me.btn_cambiar_cheque = New System.Windows.Forms.Button()
        Me.btn_redepositar = New System.Windows.Forms.Button()
        Me.btn_cheque_protestado = New System.Windows.Forms.Button()
        Me.btn_prorroga = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.DGV_resultado = New System.Windows.Forms.DataGridView()
        Me.btn_buscar2 = New System.Windows.Forms.Button()
        Me.GB_contenedor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpbx_protestado.SuspendLayout()
        CType(Me.DGV_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_contenedor
        '
        Me.GB_contenedor.Controls.Add(Me.btn_buscar2)
        Me.GB_contenedor.Controls.Add(Me.txt_numeroCheque)
        Me.GB_contenedor.Controls.Add(Me.txt_rut)
        Me.GB_contenedor.Controls.Add(Me.lbl_rut)
        Me.GB_contenedor.Controls.Add(Me.txt_nombre)
        Me.GB_contenedor.Controls.Add(Me.lbl_nCheque)
        Me.GB_contenedor.Controls.Add(Me.GroupBox1)
        Me.GB_contenedor.Controls.Add(Me.lbl_nombre)
        Me.GB_contenedor.Controls.Add(Me.btn_salir)
        Me.GB_contenedor.Controls.Add(Me.btn_buscar)
        Me.GB_contenedor.Location = New System.Drawing.Point(24, 36)
        Me.GB_contenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.GB_contenedor.Name = "GB_contenedor"
        Me.GB_contenedor.Padding = New System.Windows.Forms.Padding(2)
        Me.GB_contenedor.Size = New System.Drawing.Size(755, 225)
        Me.GB_contenedor.TabIndex = 1168
        Me.GB_contenedor.TabStop = False
        '
        'txt_numeroCheque
        '
        Me.txt_numeroCheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_numeroCheque.FormattingEnabled = True
        Me.txt_numeroCheque.Location = New System.Drawing.Point(112, 64)
        Me.txt_numeroCheque.Name = "txt_numeroCheque"
        Me.txt_numeroCheque.Size = New System.Drawing.Size(245, 21)
        Me.txt_numeroCheque.TabIndex = 1181
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(112, 41)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.ReadOnly = True
        Me.txt_rut.Size = New System.Drawing.Size(136, 20)
        Me.txt_rut.TabIndex = 1178
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut.Location = New System.Drawing.Point(75, 43)
        Me.lbl_rut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(33, 13)
        Me.lbl_rut.TabIndex = 1180
        Me.lbl_rut.Text = "RUT"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(112, 17)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(312, 20)
        Me.txt_nombre.TabIndex = 1177
        '
        'lbl_nCheque
        '
        Me.lbl_nCheque.AutoSize = True
        Me.lbl_nCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nCheque.Location = New System.Drawing.Point(11, 66)
        Me.lbl_nCheque.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nCheque.Name = "lbl_nCheque"
        Me.lbl_nCheque.Size = New System.Drawing.Size(97, 13)
        Me.lbl_nCheque.TabIndex = 1171
        Me.lbl_nCheque.Text = "N° DE CHEQUE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gpbx_protestado)
        Me.GroupBox1.Controls.Add(Me.btn_cheque_protestado)
        Me.GroupBox1.Controls.Add(Me.btn_prorroga)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 97)
        Me.GroupBox1.TabIndex = 1171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'gpbx_protestado
        '
        Me.gpbx_protestado.Controls.Add(Me.btn_cambiar_cheque)
        Me.gpbx_protestado.Controls.Add(Me.btn_redepositar)
        Me.gpbx_protestado.Location = New System.Drawing.Point(458, 11)
        Me.gpbx_protestado.Name = "gpbx_protestado"
        Me.gpbx_protestado.Size = New System.Drawing.Size(275, 80)
        Me.gpbx_protestado.TabIndex = 1178
        Me.gpbx_protestado.TabStop = False
        '
        'btn_cambiar_cheque
        '
        Me.btn_cambiar_cheque.BackColor = System.Drawing.Color.Tomato
        Me.btn_cambiar_cheque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cambiar_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiar_cheque.Location = New System.Drawing.Point(131, 21)
        Me.btn_cambiar_cheque.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cambiar_cheque.Name = "btn_cambiar_cheque"
        Me.btn_cambiar_cheque.Size = New System.Drawing.Size(114, 54)
        Me.btn_cambiar_cheque.TabIndex = 1178
        Me.btn_cambiar_cheque.Text = "Cambiar Cheque"
        Me.btn_cambiar_cheque.UseVisualStyleBackColor = False
        '
        'btn_redepositar
        '
        Me.btn_redepositar.BackColor = System.Drawing.Color.Tomato
        Me.btn_redepositar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_redepositar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_redepositar.Location = New System.Drawing.Point(13, 21)
        Me.btn_redepositar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_redepositar.Name = "btn_redepositar"
        Me.btn_redepositar.Size = New System.Drawing.Size(114, 54)
        Me.btn_redepositar.TabIndex = 1177
        Me.btn_redepositar.Text = "Redepositar Cheque"
        Me.btn_redepositar.UseVisualStyleBackColor = False
        '
        'btn_cheque_protestado
        '
        Me.btn_cheque_protestado.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_cheque_protestado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cheque_protestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cheque_protestado.Location = New System.Drawing.Point(237, 18)
        Me.btn_cheque_protestado.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cheque_protestado.Name = "btn_cheque_protestado"
        Me.btn_cheque_protestado.Size = New System.Drawing.Size(216, 39)
        Me.btn_cheque_protestado.TabIndex = 1177
        Me.btn_cheque_protestado.Text = "Cheque Protestado"
        Me.btn_cheque_protestado.UseVisualStyleBackColor = False
        '
        'btn_prorroga
        '
        Me.btn_prorroga.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_prorroga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_prorroga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prorroga.Location = New System.Drawing.Point(8, 18)
        Me.btn_prorroga.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_prorroga.Name = "btn_prorroga"
        Me.btn_prorroga.Size = New System.Drawing.Size(216, 39)
        Me.btn_prorroga.TabIndex = 1176
        Me.btn_prorroga.Text = "Prorrogar"
        Me.btn_prorroga.UseVisualStyleBackColor = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(48, 19)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(60, 13)
        Me.lbl_nombre.TabIndex = 1179
        Me.lbl_nombre.Text = "NOMBRE"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Location = New System.Drawing.Point(630, 17)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(114, 39)
        Me.btn_salir.TabIndex = 1176
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Location = New System.Drawing.Point(494, 17)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(132, 39)
        Me.btn_buscar.TabIndex = 1175
        Me.btn_buscar.Text = "Buscar Cliente"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(250, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(238, 25)
        Me.lbl_titulo.TabIndex = 1169
        Me.lbl_titulo.Text = "Consulta de Cheques"
        '
        'DGV_resultado
        '
        Me.DGV_resultado.AllowUserToAddRows = False
        Me.DGV_resultado.AllowUserToDeleteRows = False
        Me.DGV_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_resultado.Location = New System.Drawing.Point(24, 303)
        Me.DGV_resultado.Name = "DGV_resultado"
        Me.DGV_resultado.ReadOnly = True
        Me.DGV_resultado.Size = New System.Drawing.Size(755, 171)
        Me.DGV_resultado.TabIndex = 1170
        '
        'btn_buscar2
        '
        Me.btn_buscar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btn_buscar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar2.Location = New System.Drawing.Point(494, 60)
        Me.btn_buscar2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar2.Name = "btn_buscar2"
        Me.btn_buscar2.Size = New System.Drawing.Size(132, 39)
        Me.btn_buscar2.TabIndex = 1182
        Me.btn_buscar2.Text = "Buscar Documento"
        Me.btn_buscar2.UseVisualStyleBackColor = False
        '
        'frm_consultaCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGV_resultado)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.GB_contenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_consultaCheque"
        Me.Text = "Consulta de Cheques"
        Me.GB_contenedor.ResumeLayout(False)
        Me.GB_contenedor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gpbx_protestado.ResumeLayout(False)
        CType(Me.DGV_resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_contenedor As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_nCheque As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents DGV_resultado As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rut As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gpbx_protestado As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cheque_protestado As System.Windows.Forms.Button
    Friend WithEvents btn_prorroga As System.Windows.Forms.Button
    Friend WithEvents btn_cambiar_cheque As System.Windows.Forms.Button
    Friend WithEvents btn_redepositar As System.Windows.Forms.Button
    Friend WithEvents txt_numeroCheque As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar2 As System.Windows.Forms.Button
End Class
