﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sel_doc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sel_doc))
        Me.dgv_curso = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_guia_despacho = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.cmb_pedido = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_guia_despacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_curso
        '
        Me.dgv_curso.AllowUserToAddRows = False
        Me.dgv_curso.AllowUserToDeleteRows = False
        Me.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_curso.Location = New System.Drawing.Point(13, 92)
        Me.dgv_curso.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_curso.Name = "dgv_curso"
        Me.dgv_curso.ReadOnly = True
        Me.dgv_curso.RowHeadersVisible = False
        Me.dgv_curso.Size = New System.Drawing.Size(1192, 197)
        Me.dgv_curso.TabIndex = 1104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(409, -7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(289, 40)
        Me.Label8.TabIndex = 1131
        Me.Label8.Text = "GUIA DE DESPACHO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1140
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Word Files|*.docx"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Word Files|*.docx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(356, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 21)
        Me.Label4.TabIndex = 1183
        Me.Label4.Text = "DESPACHOS PENDIENTES"
        '
        'dgv_guia_despacho
        '
        Me.dgv_guia_despacho.AllowUserToAddRows = False
        Me.dgv_guia_despacho.AllowUserToDeleteRows = False
        Me.dgv_guia_despacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_guia_despacho.Location = New System.Drawing.Point(552, 371)
        Me.dgv_guia_despacho.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_guia_despacho.Name = "dgv_guia_despacho"
        Me.dgv_guia_despacho.ReadOnly = True
        Me.dgv_guia_despacho.RowHeadersVisible = False
        Me.dgv_guia_despacho.Size = New System.Drawing.Size(653, 197)
        Me.dgv_guia_despacho.TabIndex = 1184
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(709, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 21)
        Me.Label1.TabIndex = 1185
        Me.Label1.Text = "PEDIDO A GUÍA DE DESPACHO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(48, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 36)
        Me.Button1.TabIndex = 1186
        Me.Button1.Text = "EMITIR GUÍA DE DESPACHO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(48, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(313, 36)
        Me.Button2.TabIndex = 1187
        Me.Button2.Text = "VISUALIZAR DOCUMENTO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1189
        Me.Label2.Text = "FECHA:"
        '
        'cmb_cliente
        '
        Me.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(142, 358)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(380, 24)
        Me.cmb_cliente.TabIndex = 1190
        '
        'cmb_pedido
        '
        Me.cmb_pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pedido.FormattingEnabled = True
        Me.cmb_pedido.Location = New System.Drawing.Point(142, 388)
        Me.cmb_pedido.Name = "cmb_pedido"
        Me.cmb_pedido.Size = New System.Drawing.Size(380, 24)
        Me.cmb_pedido.TabIndex = 1191
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 1192
        Me.Label3.Text = "CLIENTE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 1193
        Me.Label5.Text = "N° DE PEDIDO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 17)
        Me.Label6.TabIndex = 1194
        Me.Label6.Text = "DATOS PARA GUÍA DE DESPACHO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 1196
        Me.Label7.Text = "HORA:"
        '
        'Timer1
        '
        '
        'txt_fecha
        '
        Me.txt_fecha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Location = New System.Drawing.Point(84, 427)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(136, 32)
        Me.txt_fecha.TabIndex = 1197
        '
        'txt_hora
        '
        Me.txt_hora.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(84, 469)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(136, 32)
        Me.txt_hora.TabIndex = 1198
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(552, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(437, 36)
        Me.Button3.TabIndex = 1199
        Me.Button3.Text = "ACTUALIZAR DESPACHOS PENDIENTES"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_guia_despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_pedido)
        Me.Controls.Add(Me.cmb_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_guia_despacho)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_guia_despacho"
        Me.Text = "Representantes"
        CType(Me.dgv_curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_guia_despacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgv_curso As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents dgv_guia_despacho As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
