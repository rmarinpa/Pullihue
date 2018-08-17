<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_alertas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_alertas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btn_bloquear = New System.Windows.Forms.Button()
        Me.btn_precio_min = New System.Windows.Forms.Button()
        Me.btn_nc_pend = New System.Windows.Forms.Button()
        Me.btn_precio_max = New System.Windows.Forms.Button()
        Me.btn_desbloquear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 59)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ALERTAS"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Lime
        Me.Button6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(230, 311)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 57)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Cerrar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btn_bloquear
        '
        Me.btn_bloquear.BackColor = System.Drawing.Color.Orange
        Me.btn_bloquear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bloquear.ForeColor = System.Drawing.Color.White
        Me.btn_bloquear.Location = New System.Drawing.Point(19, 191)
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(176, 58)
        Me.btn_bloquear.TabIndex = 1
        Me.btn_bloquear.Text = "Bloquear"
        Me.btn_bloquear.UseVisualStyleBackColor = False
        '
        'btn_precio_min
        '
        Me.btn_precio_min.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_precio_min.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_precio_min.ForeColor = System.Drawing.Color.White
        Me.btn_precio_min.Location = New System.Drawing.Point(19, 127)
        Me.btn_precio_min.Name = "btn_precio_min"
        Me.btn_precio_min.Size = New System.Drawing.Size(176, 58)
        Me.btn_precio_min.TabIndex = 30
        Me.btn_precio_min.Text = "Precio Mínimo"
        Me.btn_precio_min.UseVisualStyleBackColor = False
        '
        'btn_nc_pend
        '
        Me.btn_nc_pend.BackColor = System.Drawing.Color.Salmon
        Me.btn_nc_pend.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nc_pend.ForeColor = System.Drawing.Color.White
        Me.btn_nc_pend.Location = New System.Drawing.Point(19, 255)
        Me.btn_nc_pend.Name = "btn_nc_pend"
        Me.btn_nc_pend.Size = New System.Drawing.Size(176, 58)
        Me.btn_nc_pend.TabIndex = 42
        Me.btn_nc_pend.Text = "Notas de Crédito Pendientes"
        Me.btn_nc_pend.UseVisualStyleBackColor = False
        '
        'btn_precio_max
        '
        Me.btn_precio_max.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_precio_max.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_precio_max.ForeColor = System.Drawing.Color.White
        Me.btn_precio_max.Location = New System.Drawing.Point(201, 127)
        Me.btn_precio_max.Name = "btn_precio_max"
        Me.btn_precio_max.Size = New System.Drawing.Size(176, 58)
        Me.btn_precio_max.TabIndex = 33
        Me.btn_precio_max.Text = "Precio Máximo"
        Me.btn_precio_max.UseVisualStyleBackColor = False
        '
        'btn_desbloquear
        '
        Me.btn_desbloquear.BackColor = System.Drawing.Color.Orange
        Me.btn_desbloquear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desbloquear.ForeColor = System.Drawing.Color.White
        Me.btn_desbloquear.Location = New System.Drawing.Point(201, 191)
        Me.btn_desbloquear.Name = "btn_desbloquear"
        Me.btn_desbloquear.Size = New System.Drawing.Size(176, 58)
        Me.btn_desbloquear.TabIndex = 37
        Me.btn_desbloquear.Text = "Desbloquear"
        Me.btn_desbloquear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frm_menu_alertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(387, 380)
        Me.Controls.Add(Me.btn_nc_pend)
        Me.Controls.Add(Me.btn_desbloquear)
        Me.Controls.Add(Me.btn_precio_max)
        Me.Controls.Add(Me.btn_precio_min)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_bloquear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_menu_alertas"
        Me.Text = "MENÚ PRINCIPAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btn_bloquear As System.Windows.Forms.Button
    Friend WithEvents btn_precio_min As System.Windows.Forms.Button
    Friend WithEvents btn_nc_pend As System.Windows.Forms.Button
    Friend WithEvents btn_precio_max As System.Windows.Forms.Button
    Friend WithEvents btn_desbloquear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
