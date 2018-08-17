<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_subcontratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_subcontratos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtn_ep_maquinaria = New System.Windows.Forms.RadioButton()
        Me.rbtn_ep_subcontrato = New System.Windows.Forms.RadioButton()
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
        Me.Label1.Location = New System.Drawing.Point(121, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DESCUENTOS/OTROS COBROS"
        '
        'rbtn_ep_maquinaria
        '
        Me.rbtn_ep_maquinaria.AutoSize = True
        Me.rbtn_ep_maquinaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_ep_maquinaria.Location = New System.Drawing.Point(77, 139)
        Me.rbtn_ep_maquinaria.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtn_ep_maquinaria.Name = "rbtn_ep_maquinaria"
        Me.rbtn_ep_maquinaria.Size = New System.Drawing.Size(437, 33)
        Me.rbtn_ep_maquinaria.TabIndex = 5
        Me.rbtn_ep_maquinaria.TabStop = True
        Me.rbtn_ep_maquinaria.Text = "Descuentos/Otros Cobros Maquinaria"
        Me.rbtn_ep_maquinaria.UseVisualStyleBackColor = True
        '
        'rbtn_ep_subcontrato
        '
        Me.rbtn_ep_subcontrato.AutoSize = True
        Me.rbtn_ep_subcontrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_ep_subcontrato.Location = New System.Drawing.Point(77, 181)
        Me.rbtn_ep_subcontrato.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtn_ep_subcontrato.Name = "rbtn_ep_subcontrato"
        Me.rbtn_ep_subcontrato.Size = New System.Drawing.Size(308, 33)
        Me.rbtn_ep_subcontrato.TabIndex = 8
        Me.rbtn_ep_subcontrato.TabStop = True
        Me.rbtn_ep_subcontrato.Text = "Descuentos Subcontratos"
        Me.rbtn_ep_subcontrato.UseVisualStyleBackColor = True
        '
        'frm_menu_subcontratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(851, 393)
        Me.Controls.Add(Me.rbtn_ep_subcontrato)
        Me.Controls.Add(Me.rbtn_ep_maquinaria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_menu_subcontratos"
        Me.Text = "MENÚ DESCUENTOS/OTROS COBROS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtn_ep_maquinaria As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_ep_subcontrato As System.Windows.Forms.RadioButton
End Class
