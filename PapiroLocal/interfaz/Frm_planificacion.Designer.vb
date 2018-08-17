<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_planificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_planificacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_deuda = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_deuda_sindoc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_mora30 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_mora302 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_mora60 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_mora90 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_cheques = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLANIFICACIÓN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COBRANZA SEMANAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filtros:"
        '
        'btn_deuda
        '
        Me.btn_deuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_deuda.FlatAppearance.BorderSize = 2
        Me.btn_deuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_deuda.Location = New System.Drawing.Point(166, 205)
        Me.btn_deuda.Name = "btn_deuda"
        Me.btn_deuda.Size = New System.Drawing.Size(33, 23)
        Me.btn_deuda.TabIndex = 3
        Me.btn_deuda.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Deudas Históricas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_deuda_sindoc
        '
        Me.btn_deuda_sindoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_deuda_sindoc.FlatAppearance.BorderSize = 2
        Me.btn_deuda_sindoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_deuda_sindoc.Location = New System.Drawing.Point(166, 244)
        Me.btn_deuda_sindoc.Name = "btn_deuda_sindoc"
        Me.btn_deuda_sindoc.Size = New System.Drawing.Size(33, 23)
        Me.btn_deuda_sindoc.TabIndex = 6
        Me.btn_deuda_sindoc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Deuda sin documentar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Vencimientos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(309, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Mora > 30 días"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_mora30
        '
        Me.btn_mora30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_mora30.FlatAppearance.BorderSize = 2
        Me.btn_mora30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_mora30.Location = New System.Drawing.Point(270, 315)
        Me.btn_mora30.Name = "btn_mora30"
        Me.btn_mora30.Size = New System.Drawing.Size(33, 23)
        Me.btn_mora30.TabIndex = 10
        Me.btn_mora30.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(309, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Mora < 30 días"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_mora302
        '
        Me.btn_mora302.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_mora302.FlatAppearance.BorderSize = 2
        Me.btn_mora302.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_mora302.Location = New System.Drawing.Point(270, 351)
        Me.btn_mora302.Name = "btn_mora302"
        Me.btn_mora302.Size = New System.Drawing.Size(33, 23)
        Me.btn_mora302.TabIndex = 12
        Me.btn_mora302.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(309, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Mora < 60 días"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_mora60
        '
        Me.btn_mora60.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_mora60.FlatAppearance.BorderSize = 2
        Me.btn_mora60.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_mora60.Location = New System.Drawing.Point(270, 385)
        Me.btn_mora60.Name = "btn_mora60"
        Me.btn_mora60.Size = New System.Drawing.Size(33, 23)
        Me.btn_mora60.TabIndex = 14
        Me.btn_mora60.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(309, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Mora < 90 días"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_mora90
        '
        Me.btn_mora90.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_mora90.FlatAppearance.BorderSize = 2
        Me.btn_mora90.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_mora90.Location = New System.Drawing.Point(270, 419)
        Me.btn_mora90.Name = "btn_mora90"
        Me.btn_mora90.Size = New System.Drawing.Size(33, 23)
        Me.btn_mora90.TabIndex = 17
        Me.btn_mora90.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(210, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Cheques protestados"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cheques
        '
        Me.btn_cheques.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cheques.FlatAppearance.BorderSize = 2
        Me.btn_cheques.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cheques.Location = New System.Drawing.Point(166, 465)
        Me.btn_cheques.Name = "btn_cheques"
        Me.btn_cheques.Size = New System.Drawing.Size(33, 23)
        Me.btn_cheques.TabIndex = 18
        Me.btn_cheques.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(428, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Frm_planificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(716, 532)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_cheques)
        Me.Controls.Add(Me.btn_mora90)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_mora60)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_mora302)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_mora30)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_deuda_sindoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_deuda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_planificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Planificación Semanal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_deuda As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_deuda_sindoc As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_mora30 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_mora302 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_mora60 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_mora90 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_cheques As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
