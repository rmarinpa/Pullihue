<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_despacho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_despacho))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.cmb_pedido = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_guia_despacho = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_curso1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_guia_despacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_curso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(677, 966)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(196, 47)
        Me.Button4.TabIndex = 1190
        Me.Button4.Text = "Cerrar Despachos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgv_curso
        '
        Me.dgv_curso.AllowUserToAddRows = False
        Me.dgv_curso.AllowUserToDeleteRows = False
        Me.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso.Location = New System.Drawing.Point(13, 107)
        Me.dgv_curso.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(950, 393)
        Me.dgv_curso.TabIndex = 1191
        '
        'txt_hora
        '
        Me.txt_hora.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(706, 547)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(136, 32)
        Me.txt_hora.TabIndex = 1202
        '
        'txt_fecha
        '
        Me.txt_fecha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Location = New System.Drawing.Point(706, 511)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(136, 32)
        Me.txt_fecha.TabIndex = 1201
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(636, 556)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 1200
        Me.Label7.Text = "HORA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(636, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1199
        Me.Label2.Text = "FECHA:"
        '
        'cmb_cliente
        '
        Me.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(155, 523)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(380, 24)
        Me.cmb_cliente.TabIndex = 1204
        '
        'cmb_pedido
        '
        Me.cmb_pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pedido.FormattingEnabled = True
        Me.cmb_pedido.Location = New System.Drawing.Point(155, 553)
        Me.cmb_pedido.Name = "cmb_pedido"
        Me.cmb_pedido.Size = New System.Drawing.Size(380, 24)
        Me.cmb_pedido.TabIndex = 1205
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 1206
        Me.Label3.Text = "CLIENTE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 556)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 1207
        Me.Label5.Text = "N° DE PEDIDO:"
        '
        'dgv_guia_despacho
        '
        Me.dgv_guia_despacho.AllowUserToAddRows = False
        Me.dgv_guia_despacho.AllowUserToDeleteRows = False
        Me.dgv_guia_despacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_guia_despacho.Location = New System.Drawing.Point(13, 605)
        Me.dgv_guia_despacho.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_guia_despacho.Name = "dgv_guia_despacho"
        Me.dgv_guia_despacho.ReadOnly = True
        Me.dgv_guia_despacho.RowHeadersVisible = False
        Me.dgv_guia_despacho.Size = New System.Drawing.Size(950, 197)
        Me.dgv_guia_despacho.TabIndex = 1203
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(650, 822)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(313, 36)
        Me.Button2.TabIndex = 1209
        Me.Button2.Text = "PREVISUALIZACIÓN DE DOCUMENTO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(650, 864)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 36)
        Me.Button1.TabIndex = 1208
        Me.Button1.Text = "EMITIR DESPACHO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgv_curso1
        '
        Me.dgv_curso1.AllowUserToAddRows = False
        Me.dgv_curso1.AllowUserToDeleteRows = False
        Me.dgv_curso1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso1.Location = New System.Drawing.Point(969, 107)
        Me.dgv_curso1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso1.Name = "dgv_curso1"
        Me.dgv_curso1.ReadOnly = True
        Me.dgv_curso1.RowHeadersVisible = False
        Me.dgv_curso1.Size = New System.Drawing.Size(955, 393)
        Me.dgv_curso1.TabIndex = 1210
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 29)
        Me.Label1.TabIndex = 1211
        Me.Label1.Text = "PRODUCTOS PARA DESPACHAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1256, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 29)
        Me.Label4.TabIndex = 1212
        Me.Label4.Text = "PRODUCTOS DESPACHADOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(847, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1213
        Me.PictureBox1.TabStop = False
        '
        'Frm_despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1926, 1023)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_curso1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_pedido)
        Me.Controls.Add(Me.cmb_cliente)
        Me.Controls.Add(Me.dgv_guia_despacho)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_curso)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_despacho"
        Me.Text = "Despachos"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_guia_despacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_curso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents dgv_guia_despacho As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents dgv_curso1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
