<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_visualizar_autorizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_visualizar_autorizar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_autorizacion = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_nc = New System.Windows.Forms.DataGridView()
        Me.txt_nc = New System.Windows.Forms.TextBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_autorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_nc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTORIZACIÓN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(821, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'dgv_autorizacion
        '
        Me.dgv_autorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_autorizacion.Location = New System.Drawing.Point(21, 105)
        Me.dgv_autorizacion.Name = "dgv_autorizacion"
        Me.dgv_autorizacion.RowTemplate.Height = 24
        Me.dgv_autorizacion.Size = New System.Drawing.Size(1372, 335)
        Me.dgv_autorizacion.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "PEDIDOS AUTORIZADOS"
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(1049, 20)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(37, 22)
        Me.txt_folio.TabIndex = 41
        Me.txt_folio.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(304, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 41)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Actualizar Registros"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 25)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "NOTAS DE CRÉDITO"
        '
        'dgv_nc
        '
        Me.dgv_nc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_nc.Location = New System.Drawing.Point(21, 478)
        Me.dgv_nc.Name = "dgv_nc"
        Me.dgv_nc.RowTemplate.Height = 24
        Me.dgv_nc.Size = New System.Drawing.Size(1372, 335)
        Me.dgv_nc.TabIndex = 72
        '
        'txt_nc
        '
        Me.txt_nc.Location = New System.Drawing.Point(1049, 48)
        Me.txt_nc.Name = "txt_nc"
        Me.txt_nc.Size = New System.Drawing.Size(37, 22)
        Me.txt_nc.TabIndex = 74
        Me.txt_nc.Visible = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(663, 18)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(108, 22)
        Me.dtp_fecha.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(578, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Fecha:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(579, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 41)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Generar Informe"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_visualizar_autorizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1407, 821)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.txt_nc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_nc)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_autorizacion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_visualizar_autorizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pedidos Autorizados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_autorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_nc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_autorizacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_nc As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nc As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
