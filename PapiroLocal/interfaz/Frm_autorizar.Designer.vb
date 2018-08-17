<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_autorizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_autorizar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_autorizacion = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_venta2 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_toma_pedido = New System.Windows.Forms.TextBox()
        Me.txt_autoriza = New System.Windows.Forms.TextBox()
        Me.txt_obs_aut = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha_desp = New System.Windows.Forms.TextBox()
        Me.txt_solicitado = New System.Windows.Forms.TextBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_direccion_desp = New System.Windows.Forms.TextBox()
        Me.txt_comuna_desp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.txt_retira_cliente = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_autorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_venta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTORIZACIÓN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(437, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'dgv_autorizacion
        '
        Me.dgv_autorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_autorizacion.Location = New System.Drawing.Point(16, 154)
        Me.dgv_autorizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_autorizacion.Name = "dgv_autorizacion"
        Me.dgv_autorizacion.RowTemplate.Height = 24
        Me.dgv_autorizacion.Size = New System.Drawing.Size(1063, 140)
        Me.dgv_autorizacion.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 124)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(422, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "PEDIDOS PARA CONSULTAR SU AUTORIZACIÓN"
        '
        'dgv_venta2
        '
        Me.dgv_venta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_venta2.Location = New System.Drawing.Point(-2, -1)
        Me.dgv_venta2.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_venta2.Name = "dgv_venta2"
        Me.dgv_venta2.RowTemplate.Height = 24
        Me.dgv_venta2.Size = New System.Drawing.Size(8, 8)
        Me.dgv_venta2.TabIndex = 49
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(460, 318)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 47)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "AUTORIZAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(460, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 47)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "RECHAZAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(111, 341)
        Me.txt_folio.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(149, 20)
        Me.txt_folio.TabIndex = 52
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(111, 365)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(149, 20)
        Me.txt_fecha.TabIndex = 53
        '
        'txt_toma_pedido
        '
        Me.txt_toma_pedido.Location = New System.Drawing.Point(111, 388)
        Me.txt_toma_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_toma_pedido.Name = "txt_toma_pedido"
        Me.txt_toma_pedido.Size = New System.Drawing.Size(149, 20)
        Me.txt_toma_pedido.TabIndex = 54
        '
        'txt_autoriza
        '
        Me.txt_autoriza.Location = New System.Drawing.Point(111, 412)
        Me.txt_autoriza.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_autoriza.Name = "txt_autoriza"
        Me.txt_autoriza.Size = New System.Drawing.Size(149, 20)
        Me.txt_autoriza.TabIndex = 55
        '
        'txt_obs_aut
        '
        Me.txt_obs_aut.Location = New System.Drawing.Point(111, 435)
        Me.txt_obs_aut.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_obs_aut.Multiline = True
        Me.txt_obs_aut.Name = "txt_obs_aut"
        Me.txt_obs_aut.Size = New System.Drawing.Size(332, 45)
        Me.txt_obs_aut.TabIndex = 56
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(24, 318)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(58, 20)
        Me.txt_codigo.TabIndex = 57
        Me.txt_codigo.Visible = False
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(86, 318)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(58, 20)
        Me.txt_hora.TabIndex = 59
        Me.txt_hora.Visible = False
        '
        'txt_fecha_desp
        '
        Me.txt_fecha_desp.Location = New System.Drawing.Point(147, 318)
        Me.txt_fecha_desp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha_desp.Name = "txt_fecha_desp"
        Me.txt_fecha_desp.Size = New System.Drawing.Size(58, 20)
        Me.txt_fecha_desp.TabIndex = 60
        Me.txt_fecha_desp.Visible = False
        '
        'txt_solicitado
        '
        Me.txt_solicitado.Location = New System.Drawing.Point(208, 318)
        Me.txt_solicitado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_solicitado.Name = "txt_solicitado"
        Me.txt_solicitado.Size = New System.Drawing.Size(58, 20)
        Me.txt_solicitado.TabIndex = 61
        Me.txt_solicitado.Visible = False
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(270, 318)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(58, 20)
        Me.txt_observaciones.TabIndex = 62
        Me.txt_observaciones.Visible = False
        '
        'txt_direccion_desp
        '
        Me.txt_direccion_desp.Location = New System.Drawing.Point(393, 318)
        Me.txt_direccion_desp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccion_desp.Name = "txt_direccion_desp"
        Me.txt_direccion_desp.Size = New System.Drawing.Size(58, 20)
        Me.txt_direccion_desp.TabIndex = 63
        Me.txt_direccion_desp.Visible = False
        '
        'txt_comuna_desp
        '
        Me.txt_comuna_desp.Location = New System.Drawing.Point(332, 318)
        Me.txt_comuna_desp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_comuna_desp.Name = "txt_comuna_desp"
        Me.txt_comuna_desp.Size = New System.Drawing.Size(58, 20)
        Me.txt_comuna_desp.TabIndex = 64
        Me.txt_comuna_desp.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 341)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Folio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 366)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 390)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Toma Pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 414)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Autoriza"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-3, 435)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Observaciones"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(208, 32)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 33)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "Actualizar Registros"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(460, 429)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(172, 27)
        Me.Button9.TabIndex = 1271
        Me.Button9.Text = "Historial de BL-OBS"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(393, 341)
        Me.txt_rut.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(58, 20)
        Me.txt_rut.TabIndex = 1272
        Me.txt_rut.Visible = False
        '
        'txt_retira_cliente
        '
        Me.txt_retira_cliente.Location = New System.Drawing.Point(270, 345)
        Me.txt_retira_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_retira_cliente.Name = "txt_retira_cliente"
        Me.txt_retira_cliente.Size = New System.Drawing.Size(58, 20)
        Me.txt_retira_cliente.TabIndex = 1273
        Me.txt_retira_cliente.Visible = False
        '
        'Frm_autorizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 490)
        Me.Controls.Add(Me.txt_retira_cliente)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_comuna_desp)
        Me.Controls.Add(Me.txt_direccion_desp)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.txt_solicitado)
        Me.Controls.Add(Me.txt_fecha_desp)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_obs_aut)
        Me.Controls.Add(Me.txt_autoriza)
        Me.Controls.Add(Me.txt_toma_pedido)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgv_venta2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_autorizacion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_autorizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pedidos Autorizados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_autorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_venta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_autorizacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv_venta2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents txt_toma_pedido As System.Windows.Forms.TextBox
    Friend WithEvents txt_autoriza As System.Windows.Forms.TextBox
    Friend WithEvents txt_obs_aut As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_desp As System.Windows.Forms.TextBox
    Friend WithEvents txt_solicitado As System.Windows.Forms.TextBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_desp As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna_desp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_retira_cliente As System.Windows.Forms.TextBox
End Class
