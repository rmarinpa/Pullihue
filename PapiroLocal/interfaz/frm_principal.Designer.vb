<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_body = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_contratos = New System.Windows.Forms.Button()
        Me.btn_representantes = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1210, 100)
        Me.panel1.TabIndex = 11
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(186, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(215, 41)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Versión: 1.0.0 " & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(181, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(512, 41)
        Me.label1.TabIndex = 1
        Me.label1.Text = "CONSTRUCTORA FV "
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(24, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(111, 85)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'pnl_body
        '
        Me.pnl_body.BackColor = System.Drawing.Color.Transparent
        Me.pnl_body.Location = New System.Drawing.Point(146, 108)
        Me.pnl_body.Name = "pnl_body"
        Me.pnl_body.Size = New System.Drawing.Size(1064, 522)
        Me.pnl_body.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 536)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(79, 536)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 520)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sitio Web"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(70, 520)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Información"
        '
        'btn_reports
        '
        Me.btn_reports.BackColor = System.Drawing.Color.Transparent
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reports.Image = CType(resources.GetObject("btn_reports.Image"), System.Drawing.Image)
        Me.btn_reports.Location = New System.Drawing.Point(12, 260)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(120, 70)
        Me.btn_reports.TabIndex = 16
        Me.btn_reports.Text = "Registro Reports"
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_reports.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(13, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 70)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Petróleo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(13, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 70)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Compra de Petróleo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_contratos
        '
        Me.btn_contratos.BackColor = System.Drawing.Color.Transparent
        Me.btn_contratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_contratos.Image = CType(resources.GetObject("btn_contratos.Image"), System.Drawing.Image)
        Me.btn_contratos.Location = New System.Drawing.Point(12, 184)
        Me.btn_contratos.Name = "btn_contratos"
        Me.btn_contratos.Size = New System.Drawing.Size(120, 70)
        Me.btn_contratos.TabIndex = 19
        Me.btn_contratos.Text = "Contratos"
        Me.btn_contratos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_contratos.UseVisualStyleBackColor = False
        '
        'btn_representantes
        '
        Me.btn_representantes.BackColor = System.Drawing.Color.Transparent
        Me.btn_representantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_representantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_representantes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_representantes.Image = CType(resources.GetObject("btn_representantes.Image"), System.Drawing.Image)
        Me.btn_representantes.Location = New System.Drawing.Point(12, 108)
        Me.btn_representantes.Name = "btn_representantes"
        Me.btn_representantes.Size = New System.Drawing.Size(120, 70)
        Me.btn_representantes.TabIndex = 20
        Me.btn_representantes.Text = "Representantes"
        Me.btn_representantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_representantes.UseVisualStyleBackColor = False
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1222, 609)
        Me.Controls.Add(Me.btn_representantes)
        Me.Controls.Add(Me.btn_contratos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_reports)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pnl_body)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software de gestión para Constructora FV S.A."
        Me.panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents pnl_body As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btn_reports As System.Windows.Forms.Button
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents btn_contratos As System.Windows.Forms.Button
    Private WithEvents btn_representantes As System.Windows.Forms.Button

End Class
