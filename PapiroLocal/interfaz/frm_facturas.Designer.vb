<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_facturas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_facturas = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_lc_disponible = New System.Windows.Forms.TextBox()
        Me.txt_lc_utilizada = New System.Windows.Forms.TextBox()
        Me.txt_suma_lc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_deuda_por_documentar = New System.Windows.Forms.TextBox()
        Me.txt_deuda_documentada = New System.Windows.Forms.TextBox()
        Me.txt_suma_deuda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_deuda2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(600, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Location = New System.Drawing.Point(6, 221)
        Me.dgv_facturas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.RowHeadersVisible = False
        Me.dgv_facturas.Size = New System.Drawing.Size(874, 272)
        Me.dgv_facturas.TabIndex = 1178
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(333, 49)
        Me.Label9.TabIndex = 1179
        Me.Label9.Text = "HISTORICO DEUDA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dgv_facturas)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 512)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_lc_disponible)
        Me.GroupBox2.Controls.Add(Me.txt_lc_utilizada)
        Me.GroupBox2.Controls.Add(Me.txt_suma_lc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 100)
        Me.GroupBox2.TabIndex = 1187
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Línea de Crédito"
        '
        'txt_lc_disponible
        '
        Me.txt_lc_disponible.Location = New System.Drawing.Point(229, 71)
        Me.txt_lc_disponible.Name = "txt_lc_disponible"
        Me.txt_lc_disponible.Size = New System.Drawing.Size(207, 22)
        Me.txt_lc_disponible.TabIndex = 1190
        '
        'txt_lc_utilizada
        '
        Me.txt_lc_utilizada.Location = New System.Drawing.Point(229, 44)
        Me.txt_lc_utilizada.Name = "txt_lc_utilizada"
        Me.txt_lc_utilizada.Size = New System.Drawing.Size(207, 22)
        Me.txt_lc_utilizada.TabIndex = 1189
        '
        'txt_suma_lc
        '
        Me.txt_suma_lc.Location = New System.Drawing.Point(229, 17)
        Me.txt_suma_lc.Name = "txt_suma_lc"
        Me.txt_suma_lc.Size = New System.Drawing.Size(207, 22)
        Me.txt_suma_lc.TabIndex = 1188
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 21)
        Me.Label6.TabIndex = 1183
        Me.Label6.Text = "Línea de Crédito:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 21)
        Me.Label5.TabIndex = 1184
        Me.Label5.Text = "Línea de Crédito Utilizada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 21)
        Me.Label4.TabIndex = 1185
        Me.Label4.Text = "Línea de Crédito Disponible:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_deuda2)
        Me.GroupBox1.Controls.Add(Me.txt_deuda_por_documentar)
        Me.GroupBox1.Controls.Add(Me.txt_deuda_documentada)
        Me.GroupBox1.Controls.Add(Me.txt_suma_deuda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 129)
        Me.GroupBox1.TabIndex = 1186
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deuda Total"
        '
        'txt_deuda_por_documentar
        '
        Me.txt_deuda_por_documentar.Location = New System.Drawing.Point(195, 74)
        Me.txt_deuda_por_documentar.Name = "txt_deuda_por_documentar"
        Me.txt_deuda_por_documentar.Size = New System.Drawing.Size(230, 22)
        Me.txt_deuda_por_documentar.TabIndex = 1185
        '
        'txt_deuda_documentada
        '
        Me.txt_deuda_documentada.Location = New System.Drawing.Point(195, 46)
        Me.txt_deuda_documentada.Name = "txt_deuda_documentada"
        Me.txt_deuda_documentada.Size = New System.Drawing.Size(230, 22)
        Me.txt_deuda_documentada.TabIndex = 1184
        '
        'txt_suma_deuda
        '
        Me.txt_suma_deuda.Location = New System.Drawing.Point(195, 18)
        Me.txt_suma_deuda.Name = "txt_suma_deuda"
        Me.txt_suma_deuda.Size = New System.Drawing.Size(230, 22)
        Me.txt_suma_deuda.TabIndex = 1183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 21)
        Me.Label1.TabIndex = 1180
        Me.Label1.Text = "Deuda Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 21)
        Me.Label2.TabIndex = 1181
        Me.Label2.Text = "Deuda Documentada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 21)
        Me.Label3.TabIndex = 1182
        Me.Label3.Text = "Deuda Por Documentar:"
        '
        'txt_deuda2
        '
        Me.txt_deuda2.Location = New System.Drawing.Point(195, 102)
        Me.txt_deuda2.Name = "txt_deuda2"
        Me.txt_deuda2.Size = New System.Drawing.Size(230, 22)
        Me.txt_deuda2.TabIndex = 1186
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 21)
        Me.Label7.TabIndex = 1187
        Me.Label7.Text = "Deuda Por Doc. Venc."
        '
        'frm_facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(900, 514)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_facturas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORICO DE CHEQUES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lc_disponible As System.Windows.Forms.TextBox
    Friend WithEvents txt_lc_utilizada As System.Windows.Forms.TextBox
    Friend WithEvents txt_suma_lc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_deuda_por_documentar As System.Windows.Forms.TextBox
    Friend WithEvents txt_deuda_documentada As System.Windows.Forms.TextBox
    Friend WithEvents txt_suma_deuda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_deuda2 As System.Windows.Forms.TextBox
End Class
