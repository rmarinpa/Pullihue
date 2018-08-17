<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estado_de_cuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estado_de_cuenta))
        Me.btn_vales_petroleo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtn_cartera = New System.Windows.Forms.RadioButton()
        Me.rdbtn_documentos = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_venta = New System.Windows.Forms.CheckBox()
        Me.btn_historial = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_todos = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_vales_petroleo
        '
        Me.btn_vales_petroleo.BackColor = System.Drawing.Color.Blue
        Me.btn_vales_petroleo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vales_petroleo.ForeColor = System.Drawing.Color.White
        Me.btn_vales_petroleo.Location = New System.Drawing.Point(38, 219)
        Me.btn_vales_petroleo.Name = "btn_vales_petroleo"
        Me.btn_vales_petroleo.Size = New System.Drawing.Size(231, 45)
        Me.btn_vales_petroleo.TabIndex = 13
        Me.btn_vales_petroleo.Text = "Por Cliente"
        Me.btn_vales_petroleo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ESTADO DE CUENTA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(428, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1151
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button2.Location = New System.Drawing.Point(301, 92)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 32)
        Me.Button2.TabIndex = 1154
        Me.Button2.Text = "Buscar Cliente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(100, 46)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(311, 20)
        Me.txt_rut.TabIndex = 1155
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(100, 69)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(311, 20)
        Me.txt_cliente.TabIndex = 1156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1157
        Me.Label2.Text = "RUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 1158
        Me.Label3.Text = "CLIENTE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtn_cartera)
        Me.GroupBox1.Controls.Add(Me.rdbtn_documentos)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 134)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(283, 71)
        Me.GroupBox1.TabIndex = 1159
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección"
        '
        'rdbtn_cartera
        '
        Me.rdbtn_cartera.AutoSize = True
        Me.rdbtn_cartera.Location = New System.Drawing.Point(29, 39)
        Me.rdbtn_cartera.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtn_cartera.Name = "rdbtn_cartera"
        Me.rdbtn_cartera.Size = New System.Drawing.Size(250, 17)
        Me.rdbtn_cartera.TabIndex = 1
        Me.rdbtn_cartera.TabStop = True
        Me.rdbtn_cartera.Text = "Facturas por Documentar y Cheques en Cartera"
        Me.rdbtn_cartera.UseVisualStyleBackColor = True
        '
        'rdbtn_documentos
        '
        Me.rdbtn_documentos.AutoSize = True
        Me.rdbtn_documentos.Location = New System.Drawing.Point(29, 17)
        Me.rdbtn_documentos.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtn_documentos.Name = "rdbtn_documentos"
        Me.rdbtn_documentos.Size = New System.Drawing.Size(145, 17)
        Me.rdbtn_documentos.TabIndex = 0
        Me.rdbtn_documentos.TabStop = True
        Me.rdbtn_documentos.Text = "Facturas por Documentar"
        Me.rdbtn_documentos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_venta)
        Me.GroupBox2.Location = New System.Drawing.Point(296, 134)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(242, 71)
        Me.GroupBox2.TabIndex = 1160
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta Mensual"
        '
        'chk_venta
        '
        Me.chk_venta.AutoSize = True
        Me.chk_venta.Location = New System.Drawing.Point(4, 18)
        Me.chk_venta.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_venta.Name = "chk_venta"
        Me.chk_venta.Size = New System.Drawing.Size(145, 17)
        Me.chk_venta.TabIndex = 0
        Me.chk_venta.Text = "Agregar Detalle de Venta"
        Me.chk_venta.UseVisualStyleBackColor = True
        '
        'btn_historial
        '
        Me.btn_historial.BackColor = System.Drawing.Color.Blue
        Me.btn_historial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historial.ForeColor = System.Drawing.Color.White
        Me.btn_historial.Location = New System.Drawing.Point(38, 270)
        Me.btn_historial.Name = "btn_historial"
        Me.btn_historial.Size = New System.Drawing.Size(231, 45)
        Me.btn_historial.TabIndex = 1161
        Me.btn_historial.Text = "Visualizar Historial Doc."
        Me.btn_historial.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(275, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 45)
        Me.Button1.TabIndex = 1141
        Me.Button1.Text = "Todos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_todos
        '
        Me.btn_todos.BackColor = System.Drawing.Color.Blue
        Me.btn_todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_todos.ForeColor = System.Drawing.Color.White
        Me.btn_todos.Location = New System.Drawing.Point(275, 270)
        Me.btn_todos.Name = "btn_todos"
        Me.btn_todos.Size = New System.Drawing.Size(231, 45)
        Me.btn_todos.TabIndex = 1163
        Me.btn_todos.Text = "Todos - Ejec. Cobranza"
        Me.btn_todos.UseVisualStyleBackColor = False
        '
        'frm_estado_de_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 386)
        Me.Controls.Add(Me.btn_todos)
        Me.Controls.Add(Me.btn_historial)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_vales_petroleo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_estado_de_cuenta"
        Me.Text = "Estado de Cuenta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_vales_petroleo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtn_cartera As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_documentos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_venta As System.Windows.Forms.CheckBox
    Friend WithEvents btn_historial As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_todos As System.Windows.Forms.Button
End Class
