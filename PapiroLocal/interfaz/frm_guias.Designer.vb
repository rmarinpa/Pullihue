<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_guias
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
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpb_guia = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_factura = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.gpb_guia2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_factura2 = New System.Windows.Forms.ComboBox()
        Me.gpb_guia.SuspendLayout()
        Me.gpb_guia2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Por Muestra", "Por Dirección", "Cambio de Material", "Por Facturar", "Despacho Parcial"})
        Me.cmb_tipo.Location = New System.Drawing.Point(243, 50)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(193, 24)
        Me.cmb_tipo.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Tipo de Guía de Despacho:"
        '
        'gpb_guia
        '
        Me.gpb_guia.Controls.Add(Me.Label3)
        Me.gpb_guia.Controls.Add(Me.cmb_factura)
        Me.gpb_guia.Location = New System.Drawing.Point(58, 96)
        Me.gpb_guia.Name = "gpb_guia"
        Me.gpb_guia.Size = New System.Drawing.Size(473, 66)
        Me.gpb_guia.TabIndex = 43
        Me.gpb_guia.TabStop = False
        Me.gpb_guia.Text = "Tratamiento Guía de Despacho"
        Me.gpb_guia.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FACTURA DE REF.:"
        '
        'cmb_factura
        '
        Me.cmb_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_factura.FormattingEnabled = True
        Me.cmb_factura.Location = New System.Drawing.Point(175, 27)
        Me.cmb_factura.Name = "cmb_factura"
        Me.cmb_factura.Size = New System.Drawing.Size(276, 24)
        Me.cmb_factura.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "TRATAMIENTO GUÍA DE DESPACHO"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.Chartreuse
        Me.btn_ingresar.Location = New System.Drawing.Point(126, 168)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(166, 45)
        Me.btn_ingresar.TabIndex = 46
        Me.btn_ingresar.Text = "INGRESAR"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'btn_inicio
        '
        Me.btn_inicio.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_inicio.Location = New System.Drawing.Point(326, 168)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(166, 45)
        Me.btn_inicio.TabIndex = 47
        Me.btn_inicio.Text = "VOLVER AL INICIO"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'gpb_guia2
        '
        Me.gpb_guia2.Controls.Add(Me.Label4)
        Me.gpb_guia2.Controls.Add(Me.cmb_factura2)
        Me.gpb_guia2.Location = New System.Drawing.Point(58, 96)
        Me.gpb_guia2.Name = "gpb_guia2"
        Me.gpb_guia2.Size = New System.Drawing.Size(473, 66)
        Me.gpb_guia2.TabIndex = 48
        Me.gpb_guia2.TabStop = False
        Me.gpb_guia2.Text = "Tratamiento Guía de Despacho"
        Me.gpb_guia2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "FACTURA DE REF.:"
        '
        'cmb_factura2
        '
        Me.cmb_factura2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_factura2.FormattingEnabled = True
        Me.cmb_factura2.Location = New System.Drawing.Point(175, 27)
        Me.cmb_factura2.Name = "cmb_factura2"
        Me.cmb_factura2.Size = New System.Drawing.Size(276, 24)
        Me.cmb_factura2.TabIndex = 0
        '
        'frm_guias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(559, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.gpb_guia2)
        Me.Controls.Add(Me.btn_inicio)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gpb_guia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_tipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_guias"
        Me.Text = "Tipo de Guía de Despacho"
        Me.TopMost = True
        Me.gpb_guia.ResumeLayout(False)
        Me.gpb_guia.PerformLayout()
        Me.gpb_guia2.ResumeLayout(False)
        Me.gpb_guia2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpb_guia As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_factura As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents btn_inicio As System.Windows.Forms.Button
    Friend WithEvents gpb_guia2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_factura2 As System.Windows.Forms.ComboBox
End Class
