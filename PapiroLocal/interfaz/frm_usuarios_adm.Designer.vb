<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuarios_adm))
        Me.btn_logistica = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_adm = New System.Windows.Forms.Button()
        Me.btn_cobranza = New System.Windows.Forms.Button()
        Me.btn_ventas = New System.Windows.Forms.Button()
        Me.btn_servicio = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_logistica
        '
        Me.btn_logistica.BackColor = System.Drawing.Color.Red
        Me.btn_logistica.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logistica.ForeColor = System.Drawing.Color.White
        Me.btn_logistica.Location = New System.Drawing.Point(13, 67)
        Me.btn_logistica.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_logistica.Name = "btn_logistica"
        Me.btn_logistica.Size = New System.Drawing.Size(301, 66)
        Me.btn_logistica.TabIndex = 1
        Me.btn_logistica.Text = "LOGISTICA"
        Me.btn_logistica.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btn_adm
        '
        Me.btn_adm.BackColor = System.Drawing.Color.Blue
        Me.btn_adm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adm.ForeColor = System.Drawing.Color.White
        Me.btn_adm.Location = New System.Drawing.Point(13, 363)
        Me.btn_adm.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_adm.Name = "btn_adm"
        Me.btn_adm.Size = New System.Drawing.Size(301, 66)
        Me.btn_adm.TabIndex = 32
        Me.btn_adm.Text = "ADMINISTRACIÓN"
        Me.btn_adm.UseVisualStyleBackColor = False
        '
        'btn_cobranza
        '
        Me.btn_cobranza.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_cobranza.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobranza.ForeColor = System.Drawing.Color.White
        Me.btn_cobranza.Location = New System.Drawing.Point(13, 141)
        Me.btn_cobranza.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cobranza.Name = "btn_cobranza"
        Me.btn_cobranza.Size = New System.Drawing.Size(301, 66)
        Me.btn_cobranza.TabIndex = 37
        Me.btn_cobranza.Text = "COBRANZA"
        Me.btn_cobranza.UseVisualStyleBackColor = False
        '
        'btn_ventas
        '
        Me.btn_ventas.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_ventas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ventas.ForeColor = System.Drawing.Color.White
        Me.btn_ventas.Location = New System.Drawing.Point(13, 215)
        Me.btn_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(301, 66)
        Me.btn_ventas.TabIndex = 39
        Me.btn_ventas.Text = "VENTAS"
        Me.btn_ventas.UseVisualStyleBackColor = False
        '
        'btn_servicio
        '
        Me.btn_servicio.BackColor = System.Drawing.Color.Fuchsia
        Me.btn_servicio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_servicio.ForeColor = System.Drawing.Color.White
        Me.btn_servicio.Location = New System.Drawing.Point(13, 289)
        Me.btn_servicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_servicio.Name = "btn_servicio"
        Me.btn_servicio.Size = New System.Drawing.Size(301, 66)
        Me.btn_servicio.TabIndex = 41
        Me.btn_servicio.Text = "SERVICIO TÉCNICO"
        Me.btn_servicio.UseVisualStyleBackColor = False
        '
        'frm_usuarios_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(320, 446)
        Me.Controls.Add(Me.btn_servicio)
        Me.Controls.Add(Me.btn_ventas)
        Me.Controls.Add(Me.btn_cobranza)
        Me.Controls.Add(Me.btn_adm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_logistica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_usuarios_adm"
        Me.Text = "ADMINISTRACIÓN USUARIOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_logistica As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_adm As System.Windows.Forms.Button
    Friend WithEvents btn_cobranza As System.Windows.Forms.Button
    Friend WithEvents btn_ventas As System.Windows.Forms.Button
    Friend WithEvents btn_servicio As System.Windows.Forms.Button
End Class
