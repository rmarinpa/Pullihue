<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sel_guia
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
        Me.gpb_guia = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_factura = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.gpb_guia.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpb_guia
        '
        Me.gpb_guia.Controls.Add(Me.Label3)
        Me.gpb_guia.Controls.Add(Me.cmb_factura)
        Me.gpb_guia.Location = New System.Drawing.Point(33, 109)
        Me.gpb_guia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpb_guia.Name = "gpb_guia"
        Me.gpb_guia.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpb_guia.Size = New System.Drawing.Size(411, 72)
        Me.gpb_guia.TabIndex = 43
        Me.gpb_guia.TabStop = False
        Me.gpb_guia.Text = "Tratamiento Guía de Despacho"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SELECCIONAR FACTURA:"
        '
        'cmb_factura
        '
        Me.cmb_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_factura.FormattingEnabled = True
        Me.cmb_factura.Location = New System.Drawing.Point(175, 25)
        Me.cmb_factura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_factura.Name = "cmb_factura"
        Me.cmb_factura.Size = New System.Drawing.Size(208, 21)
        Me.cmb_factura.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(465, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "SELECCIONAR FACTURA  PARA DESPACHO PARCIAL"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_ingresar.Location = New System.Drawing.Point(82, 185)
        Me.btn_ingresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(124, 37)
        Me.btn_ingresar.TabIndex = 46
        Me.btn_ingresar.Text = "INGRESAR"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'btn_inicio
        '
        Me.btn_inicio.BackColor = System.Drawing.Color.SlateGray
        Me.btn_inicio.Location = New System.Drawing.Point(232, 185)
        Me.btn_inicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(124, 37)
        Me.btn_inicio.TabIndex = 47
        Me.btn_inicio.Text = "VOLVER"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button1.Location = New System.Drawing.Point(427, 39)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 37)
        Me.Button1.TabIndex = 48
        Me.Button1.TabStop = False
        Me.Button1.Text = "BUSCAR CLIENTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(82, 67)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(334, 20)
        Me.txt_rut.TabIndex = 1179
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(19, 70)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 13)
        Me.Label30.TabIndex = 1178
        Me.Label30.Text = "RUT:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Enabled = False
        Me.txt_cliente.Location = New System.Drawing.Point(82, 39)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(334, 20)
        Me.txt_cliente.TabIndex = 1177
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(19, 41)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 13)
        Me.Label31.TabIndex = 1176
        Me.Label31.Text = "CLIENTE:"
        '
        'frm_sel_guia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(598, 242)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_inicio)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gpb_guia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_sel_guia"
        Me.Text = "Despacho Parcial"
        Me.gpb_guia.ResumeLayout(False)
        Me.gpb_guia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpb_guia As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_factura As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents btn_inicio As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
End Class
