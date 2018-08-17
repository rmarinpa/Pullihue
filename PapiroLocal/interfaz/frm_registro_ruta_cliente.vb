Public Class frm_registro_ruta_cliente
    Dim nue_cur As New clases.Ruta
    Dim nueva_venta As New clases.ventas
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim tipo_documento As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.WindowState = FormWindowState.Maximized
        'Me.Location = New Point(200, 10)
        tipo_documento = 0
        Timer1.Enabled = True
        txt_usuario.ReadOnly = True
        txt_usuario.Text = Nombre_Obra
        txt_fecha.ReadOnly = True
        txt_hora.ReadOnly = True
        dtp_fecha.Value = DateTime.Now
        limpiar()
        actualizar_dgv()
        txt_tipo1.Enabled = False
        'GroupBox1.Visible = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txt_fecha.Text = Today
        Me.txt_fecha_ant.Text = Now.AddDays(-1).Date
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub
    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim peoneta, revisa_camioneta, revisa_camioneta2 As String
        If txt_n_ped1.Text <> "" Then
            Folio = nue_cur.descripcion_numero_folio() + 1
            nue_cur.insertar2(Folio)
            If txt_n_ped1.Text <> "" Then
                Dim pedido, folio_ruta As Double
                Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
                usuario = txt_usuario.Text
                chofer = "RETIRA CLIENTE"
                vehiculo = "RETIRA CLIENTE"
                pedido = txt_n_ped1.Text
                ejecutivo = txt_ejecutivo1.Text
                direccion = txt_direccion1.Text
                comuna = txt_comuna1.Text
                folio_ruta = Folio
                tipo = txt_tipo1.Text
                cliente = txt_cliente1.Text
                peoneta = "RETIRA CLIENTE"
                revisa_camioneta = "RETIRA CLIENTE"
                revisa_camioneta2 = "RETIRA CLIENTE"
                nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
                nueva_venta.Despachado(pedido)
            End If
            txt_comuna1.Clear()
            txt_n_ped1.Clear()
            txt_ejecutivo1.Clear()
            txt_direccion1.Clear()
            txt_cliente1.Clear()
            txt_tipo1.Clear()
            MsgBox("El cliente ha retirado el pedido.")
            CR_hoja_de_ruta.Show()
            limpiar()
            actualizar_dgv()
        Else
            MessageBox.Show("FALTAN DATOS POR INGRESAR")
        End If
    End Sub
    Sub limpiar()
        txt_n_ped1.Clear()
        txt_ejecutivo1.Clear()
        txt_direccion1.Clear()
        txt_comuna1.Clear()
        txt_cliente1.Clear()
        txt_tipo1.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CR_Registro_llamada.Show()
    End Sub

    Private Sub btn_borrar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar1.Click
        txt_n_ped1.Clear()
        txt_ejecutivo1.Clear()
        txt_direccion1.Clear()
        txt_comuna1.Clear()
        txt_cliente1.Clear()
        txt_tipo1.Clear()

    End Sub
    Sub actualizar_dgv()
        Dim Fecha_inicio1 As String
        Dim Fecha_anterior As String
        If txt_fecha.Text <> "" Then
            Fecha_inicio1 = Format(CDate(txt_fecha.Text), "yyyy/MM/dd")
            Fecha_anterior = Format(CDate(txt_fecha_ant.Text), "yyyy/MM/dd")
            'dgv_rutas.DataSource = nue_cur.listar() ' GERMAN
            dgv_rutas.DataSource = nue_cur.PedidosRetiraCliente() ' Carlos
            'dgv_rutas.Columns(0).Visible = False
            'dgv_rutas.Columns(1).HeaderText = "N° de Folio"
            'dgv_rutas.Columns(12).HeaderText = "N° de Factura"
            'dgv_rutas.Columns(11).HeaderText = "Cliente"
            'dgv_rutas.Columns(2).HeaderText = "Fecha"
            'dgv_rutas.Columns(5).HeaderText = "Toma Pedido"
            'dgv_rutas.Columns(3).HeaderText = "Hora"
            'dgv_rutas.Columns(8).HeaderText = "Comuna Despacho"
            'dgv_rutas.Columns(9).HeaderText = "Dirección Despacho"

            'dgv_rutas.Columns(4).Visible = False
            'dgv_rutas.Columns(6).Visible = False
            'dgv_rutas.Columns(7).Visible = False
            'dgv_rutas.Columns(10).Visible = False

            'dgv_rutas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            'dgv_rutas.Columns(1).DisplayIndex = 0
            'dgv_rutas.Columns(12).DisplayIndex = 1
            'dgv_rutas.Columns(11).DisplayIndex = 2
            'dgv_rutas.Columns(2).DisplayIndex = 3
            'dgv_rutas.Columns(5).DisplayIndex = 4
            'dgv_rutas.Columns(3).DisplayIndex = 5
            'dgv_rutas.Columns(8).DisplayIndex = 6
            'dgv_rutas.Columns(9).DisplayIndex = 7

            'dgv_rutas.Columns(1).Width = 65
            'dgv_rutas.Columns(2).Width = 65
            'dgv_rutas.Columns(3).Width = 65
            'dgv_rutas.Columns(5).Width = 65
            'dgv_rutas.Columns(8).Width = 100
            'dgv_rutas.Columns(9).Width = 300
            'dgv_rutas.Columns(11).Width = 250
            'dgv_rutas.Columns(12).Width = 65
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tipo_documento = 0
        actualizar_dgv()
    End Sub

    Private Sub dgv_rutas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_rutas.CellDoubleClick
        Dim verificacion As String
        'verificacion = dgv_rutas.CurrentRow.Cells(12).Value.ToString()
        verificacion = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        If verificacion = "0" Then
            MsgBox("ESTE PEDIDO NO ESTA RELACIONADO CON NINGUNA FACTURA")
        Else

            'txt_n_ped1.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
            'txt_ejecutivo1.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
            'txt_direccion1.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
            'txt_comuna1.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
            'txt_cliente1.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()

            ' CARLOS
            txt_n_ped1.Text = dgv_rutas.CurrentRow.Cells(0).Value.ToString()
            txt_ejecutivo1.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
            txt_cliente1.Text = dgv_rutas.CurrentRow.Cells(2).Value.ToString()
            If tipo_documento = 1 Then
                txt_tipo1.Text = "GUIA"
            Else
                txt_tipo1.Text = "PEDIDO"
            End If
        End If
    End Sub
    Private Sub btn_informe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe1.Click
        If txt_n_ped1.Text <> "" And txt_tipo1.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped1.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped1.Text <> "" And txt_tipo1.Text = "COBRO" Then
            folio_retiro = txt_n_ped1.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub
    Sub actualizar_dgv_bus()
        If txt_n_ped.Text <> "" Then
            'dgv_rutas.DataSource = nue_cur.listar3(txt_n_ped.Text) ' GERMAN
            dgv_rutas.DataSource = nue_cur.PedidosRetiraCliente(txt_n_ped.Text)
            'dgv_rutas.Columns(0).Visible = False
            'dgv_rutas.Columns(1).HeaderText = "N° de Folio"
            'dgv_rutas.Columns(12).HeaderText = "N° de Factura"
            'dgv_rutas.Columns(11).HeaderText = "Cliente"
            'dgv_rutas.Columns(2).HeaderText = "Fecha"
            'dgv_rutas.Columns(5).HeaderText = "Toma Pedido"
            'dgv_rutas.Columns(3).HeaderText = "Hora"
            'dgv_rutas.Columns(8).HeaderText = "Comuna Despacho"
            'dgv_rutas.Columns(9).HeaderText = "Dirección Despacho"

            'dgv_rutas.Columns(4).Visible = False
            'dgv_rutas.Columns(6).Visible = False
            'dgv_rutas.Columns(7).Visible = False
            'dgv_rutas.Columns(10).Visible = False

            'dgv_rutas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_rutas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            'dgv_rutas.Columns(1).DisplayIndex = 0
            'dgv_rutas.Columns(12).DisplayIndex = 1
            'dgv_rutas.Columns(11).DisplayIndex = 2
            'dgv_rutas.Columns(2).DisplayIndex = 3
            'dgv_rutas.Columns(5).DisplayIndex = 4
            'dgv_rutas.Columns(3).DisplayIndex = 5
            'dgv_rutas.Columns(8).DisplayIndex = 6
            'dgv_rutas.Columns(9).DisplayIndex = 7

            'dgv_rutas.Columns(1).Width = 65
            'dgv_rutas.Columns(2).Width = 65
            'dgv_rutas.Columns(3).Width = 65
            'dgv_rutas.Columns(5).Width = 65
            'dgv_rutas.Columns(8).Width = 100
            'dgv_rutas.Columns(9).Width = 300
            'dgv_rutas.Columns(11).Width = 250
            'dgv_rutas.Columns(12).Width = 65
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tipo_documento = 0
        actualizar_dgv_bus()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs)
        frm_registro_llegada2.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        tipo_documento = 1
        actualizar_dgv_guias()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        tipo_documento = 1
        actualizar_dgv_guias2()
    End Sub
    Sub actualizar_dgv_guias()
        Dim Fecha_inicio1 As String
        Dim Fecha_anterior As String
        If txt_fecha.Text <> "" Then
            Fecha_inicio1 = Format(CDate(txt_fecha.Text), "yyyy/MM/dd")
            Fecha_anterior = Format(CDate(txt_fecha_ant.Text), "yyyy/MM/dd")
            dgv_rutas.DataSource = nue_cur.listar16(Fecha_inicio1, Fecha_anterior)
            dgv_rutas.Columns(0).Visible = False
            dgv_rutas.Columns(1).HeaderText = "N° de Guía"
            dgv_rutas.Columns(2).HeaderText = "Fecha"
            dgv_rutas.Columns(3).HeaderText = "Hora"
            dgv_rutas.Columns(4).Visible = False
            dgv_rutas.Columns(5).HeaderText = "Ejecutivo"
            dgv_rutas.Columns(6).Visible = False
            dgv_rutas.Columns(7).Visible = False
            dgv_rutas.Columns(8).HeaderText = "Comuna Despacho"
            dgv_rutas.Columns(9).HeaderText = "Dirección Despacho"
            dgv_rutas.Columns(10).Visible = False
            dgv_rutas.Columns(11).HeaderText = "Cliente"
            dgv_rutas.Columns(12).Visible = False
            dgv_rutas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(0).DisplayIndex = 0
            dgv_rutas.Columns(1).DisplayIndex = 1
            dgv_rutas.Columns(2).DisplayIndex = 2
            dgv_rutas.Columns(3).DisplayIndex = 3
            dgv_rutas.Columns(5).DisplayIndex = 4
            dgv_rutas.Columns(11).DisplayIndex = 5
            dgv_rutas.Columns(8).DisplayIndex = 6
            dgv_rutas.Columns(9).DisplayIndex = 7
            dgv_rutas.Columns(1).Width = 65
            dgv_rutas.Columns(2).Width = 65
            dgv_rutas.Columns(3).Width = 65
            dgv_rutas.Columns(4).Width = 65
            dgv_rutas.Columns(8).Width = 100
            dgv_rutas.Columns(9).Width = 300
            dgv_rutas.Columns(11).Width = 250
        Else
        End If
    End Sub
    Sub actualizar_dgv_guias2()
        If txt_n_ped.Text <> "" Then
            dgv_rutas.DataSource = nue_cur.listar17(txt_n_ped.Text)
            dgv_rutas.Columns(0).Visible = False
            dgv_rutas.Columns(1).HeaderText = "N° de Guía"
            dgv_rutas.Columns(2).HeaderText = "Fecha"
            dgv_rutas.Columns(3).HeaderText = "Hora"
            dgv_rutas.Columns(4).Visible = False
            dgv_rutas.Columns(5).HeaderText = "Ejecutivo"
            dgv_rutas.Columns(6).Visible = False
            dgv_rutas.Columns(7).Visible = False
            dgv_rutas.Columns(8).HeaderText = "Comuna Despacho"
            dgv_rutas.Columns(9).HeaderText = "Dirección Despacho"
            dgv_rutas.Columns(10).Visible = False
            dgv_rutas.Columns(11).HeaderText = "Cliente"
            dgv_rutas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_rutas.Columns(0).DisplayIndex = 0
            dgv_rutas.Columns(1).DisplayIndex = 1
            dgv_rutas.Columns(2).DisplayIndex = 2
            dgv_rutas.Columns(3).DisplayIndex = 3
            dgv_rutas.Columns(5).DisplayIndex = 4
            dgv_rutas.Columns(11).DisplayIndex = 5
            dgv_rutas.Columns(8).DisplayIndex = 6
            dgv_rutas.Columns(9).DisplayIndex = 7
            dgv_rutas.Columns(1).Width = 65
            dgv_rutas.Columns(2).Width = 65
            dgv_rutas.Columns(3).Width = 65
            dgv_rutas.Columns(4).Width = 65
            dgv_rutas.Columns(8).Width = 100
            dgv_rutas.Columns(9).Width = 300
            dgv_rutas.Columns(11).Width = 250
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub
End Class