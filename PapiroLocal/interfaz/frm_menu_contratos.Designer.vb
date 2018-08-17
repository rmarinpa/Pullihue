<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_contratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_contratos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtn_maq_movil = New System.Windows.Forms.RadioButton()
        Me.rbtn_maq_movil_cuentas = New System.Windows.Forms.RadioButton()
        Me.rbtn_tabla_uf = New System.Windows.Forms.RadioButton()
        Me.btn_tipo_subcontrato = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(563, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 97)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MENÚ DE CONTRATOS"
        '
        'rbtn_maq_movil
        '
        Me.rbtn_maq_movil.AutoSize = True
        Me.rbtn_maq_movil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_maq_movil.Location = New System.Drawing.Point(77, 139)
        Me.rbtn_maq_movil.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtn_maq_movil.Name = "rbtn_maq_movil"
        Me.rbtn_maq_movil.Size = New System.Drawing.Size(313, 33)
        Me.rbtn_maq_movil.TabIndex = 5
        Me.rbtn_maq_movil.TabStop = True
        Me.rbtn_maq_movil.Text = "Registro Maquinaria Móvil"
        Me.rbtn_maq_movil.UseVisualStyleBackColor = True
        '
        'rbtn_maq_movil_cuentas
        '
        Me.rbtn_maq_movil_cuentas.AutoSize = True
        Me.rbtn_maq_movil_cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_maq_movil_cuentas.Location = New System.Drawing.Point(77, 222)
        Me.rbtn_maq_movil_cuentas.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtn_maq_movil_cuentas.Name = "rbtn_maq_movil_cuentas"
        Me.rbtn_maq_movil_cuentas.Size = New System.Drawing.Size(338, 33)
        Me.rbtn_maq_movil_cuentas.TabIndex = 6
        Me.rbtn_maq_movil_cuentas.TabStop = True
        Me.rbtn_maq_movil_cuentas.Text = "Relación Cuentas Contables"
        Me.rbtn_maq_movil_cuentas.UseVisualStyleBackColor = True
        '
        'rbtn_tabla_uf
        '
        Me.rbtn_tabla_uf.AutoSize = True
        Me.rbtn_tabla_uf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_tabla_uf.Location = New System.Drawing.Point(77, 264)
        Me.rbtn_tabla_uf.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtn_tabla_uf.Name = "rbtn_tabla_uf"
        Me.rbtn_tabla_uf.Size = New System.Drawing.Size(134, 33)
        Me.rbtn_tabla_uf.TabIndex = 7
        Me.rbtn_tabla_uf.TabStop = True
        Me.rbtn_tabla_uf.Text = "Tabla UF"
        Me.rbtn_tabla_uf.UseVisualStyleBackColor = True
        '
        'btn_tipo_subcontrato
        '
        Me.btn_tipo_subcontrato.AutoSize = True
        Me.btn_tipo_subcontrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tipo_subcontrato.Location = New System.Drawing.Point(77, 181)
        Me.btn_tipo_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_tipo_subcontrato.Name = "btn_tipo_subcontrato"
        Me.btn_tipo_subcontrato.Size = New System.Drawing.Size(272, 33)
        Me.btn_tipo_subcontrato.TabIndex = 8
        Me.btn_tipo_subcontrato.TabStop = True
        Me.btn_tipo_subcontrato.Text = "Registro Subcontratos"
        Me.btn_tipo_subcontrato.UseVisualStyleBackColor = True
        '
        'frm_menu_contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(851, 393)
        Me.Controls.Add(Me.btn_tipo_subcontrato)
        Me.Controls.Add(Me.rbtn_tabla_uf)
        Me.Controls.Add(Me.rbtn_maq_movil_cuentas)
        Me.Controls.Add(Me.rbtn_maq_movil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_menu_contratos"
        Me.Text = "MENÚ CONTRATOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtn_maq_movil As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_maq_movil_cuentas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_tabla_uf As System.Windows.Forms.RadioButton
    Friend WithEvents btn_tipo_subcontrato As System.Windows.Forms.RadioButton
End Class
