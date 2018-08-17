<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Complementarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Complementarios))
        Me.dgv_Petroleo = New System.Windows.Forms.DataGridView()
        Me.gbx_Petroleo = New System.Windows.Forms.GroupBox()
        Me.txt_codigo2 = New System.Windows.Forms.TextBox()
        Me.txt_codigo1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_descripcion1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_descripcion2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_Petroleo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Petroleo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Petroleo
        '
        Me.dgv_Petroleo.AllowUserToAddRows = False
        Me.dgv_Petroleo.AllowUserToDeleteRows = False
        Me.dgv_Petroleo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Petroleo.Location = New System.Drawing.Point(613, 35)
        Me.dgv_Petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Petroleo.Name = "dgv_Petroleo"
        Me.dgv_Petroleo.ReadOnly = True
        Me.dgv_Petroleo.RowHeadersVisible = False
        Me.dgv_Petroleo.Size = New System.Drawing.Size(604, 364)
        Me.dgv_Petroleo.TabIndex = 1086
        '
        'gbx_Petroleo
        '
        Me.gbx_Petroleo.Controls.Add(Me.txt_codigo2)
        Me.gbx_Petroleo.Controls.Add(Me.txt_codigo1)
        Me.gbx_Petroleo.Controls.Add(Me.Button2)
        Me.gbx_Petroleo.Controls.Add(Me.Button1)
        Me.gbx_Petroleo.Controls.Add(Me.Label2)
        Me.gbx_Petroleo.Controls.Add(Me.Label4)
        Me.gbx_Petroleo.Controls.Add(Me.PictureBox1)
        Me.gbx_Petroleo.Controls.Add(Me.txt_descripcion1)
        Me.gbx_Petroleo.Controls.Add(Me.Label9)
        Me.gbx_Petroleo.Controls.Add(Me.txt_descripcion2)
        Me.gbx_Petroleo.Controls.Add(Me.Label1)
        Me.gbx_Petroleo.Location = New System.Drawing.Point(8, 15)
        Me.gbx_Petroleo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbx_Petroleo.Name = "gbx_Petroleo"
        Me.gbx_Petroleo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Petroleo.Size = New System.Drawing.Size(597, 318)
        Me.gbx_Petroleo.TabIndex = 0
        Me.gbx_Petroleo.TabStop = False
        Me.gbx_Petroleo.Text = "Registro Productos Complementarios"
        '
        'txt_codigo2
        '
        Me.txt_codigo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_codigo2.Location = New System.Drawing.Point(182, 179)
        Me.txt_codigo2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo2.MaxLength = 40
        Me.txt_codigo2.Name = "txt_codigo2"
        Me.txt_codigo2.Size = New System.Drawing.Size(299, 22)
        Me.txt_codigo2.TabIndex = 1110
        Me.txt_codigo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_codigo1
        '
        Me.txt_codigo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_codigo1.Location = New System.Drawing.Point(181, 57)
        Me.txt_codigo1.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo1.MaxLength = 40
        Me.txt_codigo1.Name = "txt_codigo1"
        Me.txt_codigo1.Size = New System.Drawing.Size(299, 22)
        Me.txt_codigo1.TabIndex = 1109
        Me.txt_codigo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(488, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 54)
        Me.Button2.TabIndex = 1108
        Me.Button2.Text = "Buscar Producto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(488, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 54)
        Me.Button1.TabIndex = 1107
        Me.Button1.Text = "Buscar Producto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 21)
        Me.Label2.TabIndex = 1106
        Me.Label2.Text = "CÓDIGO PRODUCTO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 1105
        Me.Label4.Text = "DESCRIPCIÓN:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(260, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1104
        Me.PictureBox1.TabStop = False
        '
        'txt_descripcion1
        '
        Me.txt_descripcion1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion1.Location = New System.Drawing.Point(181, 90)
        Me.txt_descripcion1.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion1.MaxLength = 40
        Me.txt_descripcion1.Name = "txt_descripcion1"
        Me.txt_descripcion1.Size = New System.Drawing.Size(299, 22)
        Me.txt_descripcion1.TabIndex = 2
        Me.txt_descripcion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 60)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 21)
        Me.Label9.TabIndex = 1100
        Me.Label9.Text = "CÓDIGO PRODUCTO:"
        '
        'txt_descripcion2
        '
        Me.txt_descripcion2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_descripcion2.Location = New System.Drawing.Point(182, 209)
        Me.txt_descripcion2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion2.MaxLength = 20
        Me.txt_descripcion2.Name = "txt_descripcion2"
        Me.txt_descripcion2.Size = New System.Drawing.Size(298, 22)
        Me.txt_descripcion2.TabIndex = 0
        Me.txt_descripcion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "DESCRIPCIÓN:"
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(355, 393)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(81, 64)
        Me.btn_editar.TabIndex = 4
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(161, 393)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 64)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(265, 393)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 64)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(72, 393)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(81, 64)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(444, 393)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 64)
        Me.btnEliminar.TabIndex = 1133
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(752, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 31)
        Me.Label3.TabIndex = 1134
        Me.Label3.Text = "TABLA DE DATOS"
        '
        'Frm_Complementarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_Petroleo)
        Me.Controls.Add(Me.gbx_Petroleo)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Complementarios"
        Me.Text = "frm_estudiante"
        CType(Me.dgv_Petroleo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Petroleo.ResumeLayout(False)
        Me.gbx_Petroleo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_Petroleo As System.Windows.Forms.DataGridView
    Private WithEvents gbx_Petroleo As System.Windows.Forms.GroupBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion2 As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_codigo2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
