<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuenta_contable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cuenta_contable))
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_codigo = New System.Windows.Forms.ComboBox()
        Me.txt_nombre_obra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_cuenta_petroleo = New System.Windows.Forms.ComboBox()
        Me.cmb_cuenta_maquinaria = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(264, 374)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(61, 52)
        Me.btn_editar.TabIndex = 1108
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 1107
        Me.Label2.Text = "CÓDIGO MÁQUINA:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(63, 374)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 52)
        Me.btn_guardar.TabIndex = 1105
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dgv_curso
        '
        Me.dgv_curso.AllowUserToAddRows = False
        Me.dgv_curso.AllowUserToDeleteRows = False
        Me.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso.Location = New System.Drawing.Point(503, 46)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(561, 380)
        Me.dgv_curso.TabIndex = 1104
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(197, 374)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(61, 52)
        Me.btn_nuevo.TabIndex = 1117
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 1119
        Me.Label1.Text = "CUENTA CONTABLE PETRÓLEO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 13)
        Me.Label5.TabIndex = 1125
        Me.Label5.Text = "CUENTA CONTABLE MAQUINARIA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(259, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(275, 25)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "REGISTRO CONTRATOS"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(331, 374)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 52)
        Me.btnEliminar.TabIndex = 1132
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(130, 374)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 52)
        Me.btn_cancelar.TabIndex = 1133
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 70)
        Me.PictureBox1.TabIndex = 1140
        Me.PictureBox1.TabStop = False
        '
        'txt_codigo
        '
        Me.txt_codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_codigo.FormattingEnabled = True
        Me.txt_codigo.Location = New System.Drawing.Point(240, 105)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(242, 21)
        Me.txt_codigo.TabIndex = 1141
        '
        'txt_nombre_obra
        '
        Me.txt_nombre_obra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_nombre_obra.Location = New System.Drawing.Point(240, 184)
        Me.txt_nombre_obra.MaxLength = 40
        Me.txt_nombre_obra.Name = "txt_nombre_obra"
        Me.txt_nombre_obra.Size = New System.Drawing.Size(242, 20)
        Me.txt_nombre_obra.TabIndex = 1142
        Me.txt_nombre_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 1143
        Me.Label4.Text = "NOMBRE OBRA:"
        '
        'cmb_cuenta_petroleo
        '
        Me.cmb_cuenta_petroleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cuenta_petroleo.FormattingEnabled = True
        Me.cmb_cuenta_petroleo.Location = New System.Drawing.Point(240, 132)
        Me.cmb_cuenta_petroleo.Name = "cmb_cuenta_petroleo"
        Me.cmb_cuenta_petroleo.Size = New System.Drawing.Size(242, 21)
        Me.cmb_cuenta_petroleo.TabIndex = 1144
        '
        'cmb_cuenta_maquinaria
        '
        Me.cmb_cuenta_maquinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cuenta_maquinaria.FormattingEnabled = True
        Me.cmb_cuenta_maquinaria.Location = New System.Drawing.Point(240, 157)
        Me.cmb_cuenta_maquinaria.Name = "cmb_cuenta_maquinaria"
        Me.cmb_cuenta_maquinaria.Size = New System.Drawing.Size(242, 21)
        Me.cmb_cuenta_maquinaria.TabIndex = 1145
        '
        'frm_cuenta_contable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 522)
        Me.Controls.Add(Me.cmb_cuenta_maquinaria)
        Me.Controls.Add(Me.cmb_cuenta_petroleo)
        Me.Controls.Add(Me.txt_nombre_obra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cuenta_contable"
        Me.Text = "Relación Cuentas Contables"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_codigo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre_obra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_cuenta_petroleo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cuenta_maquinaria As System.Windows.Forms.ComboBox
End Class
