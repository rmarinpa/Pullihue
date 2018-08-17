Public Class frm_registro_ruta
    Dim nue_cur As New clases.Ruta
    Dim nueva_venta As New clases.ventas
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim tipo_documento As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GroupBox1.Visible = False
        Me.WindowState = FormWindowState.Maximized
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
        actualizar_folio()
        txt_tipo1.Enabled = False
        txt_tipo2.Enabled = False
        txt_tipo3.Enabled = False
        txt_tipo4.Enabled = False
        txt_tipo5.Enabled = False
        txt_tipo6.Enabled = False
        txt_tipo7.Enabled = False
        txt_tipo8.Enabled = False
        txt_tipo9.Enabled = False
        txt_tipo10.Enabled = False
        txt_tipo11.Enabled = False
        txt_tipo12.Enabled = False
        txt_tipo13.Enabled = False
        txt_tipo14.Enabled = False
        txt_tipo15.Enabled = False
        txt_tipo16.Enabled = False
        txt_tipo17.Enabled = False
        txt_tipo18.Enabled = False
        txt_tipo19.Enabled = False
        txt_tipo20.Enabled = False

        GroupBox1.Visible = False

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
        actualizar_chofer()
        actualizar_peoneta()
        actualizar_revision1()
        actualizar_revision2()
        actualizar_revision3()
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
        Dim usuario, chofer, vehiculo, peoneta, revisa_camioneta, revisa_camioneta2 As String
        'If cmb_chofer.Text <> "" And cmb_vehiculo.Text <> "" And txt_n_ped1.Text <> "" And cmb_peoneta.Text <> "" And txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then
        If cmb_chofer.Text <> "" And cmb_vehiculo.Text <> "" And cmb_peoneta.Text <> "" And txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then

            Folio = nue_cur.descripcion_numero_folio() + 1  ' busca el ultimo "folio" de la tabla -> folio_ruta y le suma uno, el resultado lo asigna a la variable Folio.
            nue_cur.insertar2(Folio) ' Inserta en la tabla -> folio_ruta el valor de la variable Folio.

            Dim pedido, folio_ruta As Double
            Dim tipo, ejecutivo, cliente, direccion, comuna As String

            usuario = txt_usuario.Text
            chofer = cmb_chofer.Text
            vehiculo = cmb_vehiculo.Text
            peoneta = cmb_peoneta.Text
            revisa_camioneta = txt_revisa.Text
            revisa_camioneta2 = txt_revisa2.Text

            folio_ruta = Folio

            For index As Integer = 0 To dgv_datosAgregados.RowCount - 1
                tipo = dgv_datosAgregados.Rows(index).Cells(0).Value.ToString()
                pedido = dgv_datosAgregados.Rows(index).Cells(1).Value.ToString()
                ejecutivo = dgv_datosAgregados.Rows(index).Cells(2).Value.ToString()
                cliente = dgv_datosAgregados.Rows(index).Cells(3).Value.ToString()
                direccion = dgv_datosAgregados.Rows(index).Cells(4).Value.ToString()
                comuna = dgv_datosAgregados.Rows(index).Cells(5).Value.ToString()
                nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
                nueva_venta.Despachado(pedido)
            Next
            dgv_datosAgregados.Rows.Clear()





            'If txt_n_ped1.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '   usuario = txt_usuario.Text
            '   chofer = cmb_chofer.Text
            '   vehiculo = cmb_vehiculo.Text
            '   peoneta = cmb_peoneta.Text

            '   revisa_camioneta = txt_revisa.Text
            '   revisa_camioneta2 = txt_revisa2.Text

            '   folio_ruta = Folio

            '   tipo = txt_tipo1.Text
            '   pedido = txt_n_ped1.Text
            '   ejecutivo = txt_ejecutivo1.Text
            '   cliente = txt_cliente1.Text
            '   direccion = txt_direccion1.Text
            '   comuna = txt_comuna1.Text
            '   nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped2.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped2.Text
            '    ejecutivo = txt_ejecutivo2.Text
            '    direccion = txt_direccion2.Text
            '    comuna = txt_comuna2.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo2.Text
            '    cliente = txt_cliente2.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped3.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped3.Text
            '    ejecutivo = txt_ejecutivo3.Text
            '    direccion = txt_direccion3.Text
            '    comuna = txt_comuna3.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo3.Text
            '    cliente = txt_cliente3.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped4.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped4.Text
            '    ejecutivo = txt_ejecutivo4.Text
            '    direccion = txt_direccion4.Text
            '    comuna = txt_comuna4.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo4.Text
            '    cliente = txt_cliente4.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped5.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped5.Text
            '    ejecutivo = txt_ejecutivo5.Text
            '    direccion = txt_direccion5.Text
            '    comuna = txt_comuna5.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo5.Text
            '    cliente = txt_cliente5.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped6.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped6.Text
            '    ejecutivo = txt_ejecutivo6.Text
            '    direccion = txt_direccion6.Text
            '    comuna = txt_comuna6.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo6.Text
            '    cliente = txt_cliente6.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped7.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped7.Text
            '    ejecutivo = txt_ejecutivo7.Text
            '    direccion = txt_direccion7.Text
            '    comuna = txt_comuna7.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo7.Text
            '    cliente = txt_cliente7.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped8.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped8.Text
            '    ejecutivo = txt_ejecutivo8.Text
            '    direccion = txt_direccion8.Text
            '    comuna = txt_comuna8.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo8.Text
            '    cliente = txt_cliente8.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped9.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped9.Text
            '    ejecutivo = txt_ejecutivo9.Text
            '    direccion = txt_direccion9.Text
            '    comuna = txt_comuna9.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo9.Text
            '    cliente = txt_cliente9.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped10.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped10.Text
            '    ejecutivo = txt_ejecutivo10.Text
            '    direccion = txt_direccion10.Text
            '    comuna = txt_comuna10.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo10.Text
            '    cliente = txt_cliente10.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped11.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped11.Text
            '    ejecutivo = txt_ejecutivo11.Text
            '    direccion = txt_direccion11.Text
            '    comuna = txt_comuna11.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo11.Text
            '    cliente = txt_cliente11.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped12.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped12.Text
            '    ejecutivo = txt_ejecutivo12.Text
            '    direccion = txt_direccion12.Text
            '    comuna = txt_comuna12.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo12.Text
            '    cliente = txt_cliente12.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped13.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped13.Text
            '    ejecutivo = txt_ejecutivo13.Text
            '    direccion = txt_direccion13.Text
            '    comuna = txt_comuna13.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo13.Text
            '    cliente = txt_cliente13.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped14.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped14.Text
            '    ejecutivo = txt_ejecutivo14.Text
            '    direccion = txt_direccion14.Text
            '    comuna = txt_comuna14.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo14.Text
            '    cliente = txt_cliente14.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped15.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped15.Text
            '    ejecutivo = txt_ejecutivo15.Text
            '    direccion = txt_direccion15.Text
            '    comuna = txt_comuna15.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo15.Text
            '    cliente = txt_cliente15.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped16.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped16.Text
            '    ejecutivo = txt_ejecutivo16.Text
            '    direccion = txt_direccion16.Text
            '    comuna = txt_comuna16.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo16.Text
            '    cliente = txt_cliente16.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped17.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped17.Text
            '    ejecutivo = txt_ejecutivo17.Text
            '    direccion = txt_direccion17.Text
            '    comuna = txt_comuna17.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo17.Text
            '    cliente = txt_cliente17.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped18.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped18.Text
            '    ejecutivo = txt_ejecutivo18.Text
            '    direccion = txt_direccion18.Text
            '    comuna = txt_comuna18.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo18.Text
            '    cliente = txt_cliente18.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped19.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped19.Text
            '    ejecutivo = txt_ejecutivo19.Text
            '    direccion = txt_direccion19.Text
            '    comuna = txt_comuna19.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo19.Text
            '    cliente = txt_cliente19.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'If txt_n_ped20.Text <> "" Then
            '    Dim pedido, folio_ruta As Double
            '    Dim ejecutivo, direccion, comuna, usuario, chofer, vehiculo, tipo, cliente As String
            '    usuario = txt_usuario.Text
            '    chofer = cmb_chofer.Text
            '    vehiculo = cmb_vehiculo.Text
            '    pedido = txt_n_ped20.Text
            '    ejecutivo = txt_ejecutivo20.Text
            '    direccion = txt_direccion20.Text
            '    comuna = txt_comuna20.Text
            '    folio_ruta = Folio
            '    tipo = txt_tipo20.Text
            '    cliente = txt_cliente20.Text
            '    peoneta = cmb_peoneta.Text
            '    revisa_camioneta = txt_revisa.Text
            '    revisa_camioneta2 = txt_revisa2.Text
            '    nue_cur.insertar(usuario, chofer, vehiculo, CDate(txt_fecha.Text), CDate(txt_hora.Text), pedido, ejecutivo, direccion, comuna, folio_ruta, tipo, cliente, peoneta, revisa_camioneta, revisa_camioneta2)
            'Else
            'End If
            'txt_comuna1.Clear()
            'txt_n_ped1.Clear()
            'txt_ejecutivo1.Clear()
            'txt_direccion1.Clear()
            'txt_cliente1.Clear()

            'txt_comuna2.Clear()
            'txt_n_ped2.Clear()
            'txt_ejecutivo2.Clear()
            'txt_direccion2.Clear()
            'txt_cliente2.Clear()

            'txt_comuna3.Clear()
            'txt_n_ped3.Clear()
            'txt_ejecutivo3.Clear()
            'txt_direccion3.Clear()
            'txt_cliente3.Clear()

            'txt_comuna4.Clear()
            'txt_n_ped4.Clear()
            'txt_ejecutivo4.Clear()
            'txt_direccion4.Clear()
            'txt_cliente4.Clear()

            'txt_comuna5.Clear()
            'txt_n_ped5.Clear()
            'txt_ejecutivo5.Clear()
            'txt_direccion5.Clear()
            'txt_cliente5.Clear()

            'txt_comuna6.Clear()
            'txt_n_ped6.Clear()
            'txt_ejecutivo6.Clear()
            'txt_direccion6.Clear()
            'txt_cliente6.Clear()

            'txt_comuna7.Clear()
            'txt_n_ped7.Clear()
            'txt_ejecutivo7.Clear()
            'txt_direccion7.Clear()
            'txt_cliente7.Clear()

            'txt_comuna8.Clear()
            'txt_n_ped8.Clear()
            'txt_ejecutivo8.Clear()
            'txt_direccion8.Clear()
            'txt_cliente8.Clear()

            'txt_comuna9.Clear()
            'txt_n_ped9.Clear()
            'txt_ejecutivo9.Clear()
            'txt_direccion9.Clear()
            'txt_cliente9.Clear()

            'txt_comuna10.Clear()
            'txt_n_ped10.Clear()
            'txt_ejecutivo10.Clear()
            'txt_direccion10.Clear()
            'txt_cliente10.Clear()

            'txt_comuna11.Clear()
            'txt_n_ped11.Clear()
            'txt_ejecutivo11.Clear()
            'txt_direccion11.Clear()
            'txt_cliente11.Clear()

            'txt_comuna12.Clear()
            'txt_n_ped12.Clear()
            'txt_ejecutivo12.Clear()
            'txt_direccion12.Clear()
            'txt_cliente12.Clear()

            'txt_comuna13.Clear()
            'txt_n_ped13.Clear()
            'txt_ejecutivo13.Clear()
            'txt_direccion13.Clear()
            'txt_cliente13.Clear()

            'txt_comuna14.Clear()
            'txt_n_ped14.Clear()
            'txt_ejecutivo14.Clear()
            'txt_direccion14.Clear()
            'txt_cliente14.Clear()

            'txt_comuna15.Clear()
            'txt_n_ped15.Clear()
            'txt_ejecutivo15.Clear()
            'txt_direccion15.Clear()
            'txt_cliente15.Clear()

            'txt_comuna16.Clear()
            'txt_n_ped16.Clear()
            'txt_ejecutivo16.Clear()
            'txt_direccion16.Clear()
            'txt_cliente16.Clear()

            'txt_comuna17.Clear()
            'txt_n_ped17.Clear()
            'txt_ejecutivo17.Clear()
            'txt_direccion17.Clear()
            'txt_cliente17.Clear()

            'txt_comuna18.Clear()
            'txt_n_ped18.Clear()
            'txt_ejecutivo18.Clear()
            'txt_direccion18.Clear()
            'txt_cliente18.Clear()

            'txt_comuna19.Clear()
            'txt_n_ped19.Clear()
            'txt_ejecutivo19.Clear()
            'txt_direccion19.Clear()
            'txt_cliente19.Clear()

            'txt_comuna20.Clear()
            'txt_n_ped20.Clear()
            'txt_ejecutivo20.Clear()
            'txt_direccion20.Clear()
            'txt_cliente20.Clear()

            'txt_tipo1.Clear()
            'txt_tipo2.Clear()
            'txt_tipo3.Clear()
            'txt_tipo4.Clear()
            'txt_tipo5.Clear()
            'txt_tipo6.Clear()
            'txt_tipo7.Clear()
            'txt_tipo8.Clear()
            'txt_tipo9.Clear()
            'txt_tipo10.Clear()
            'txt_tipo11.Clear()
            'txt_tipo12.Clear()
            'txt_tipo13.Clear()
            'txt_tipo14.Clear()
            'txt_tipo15.Clear()
            'txt_tipo16.Clear()
            'txt_tipo17.Clear()
            'txt_tipo18.Clear()
            'txt_tipo19.Clear()
            'txt_tipo20.Clear()

            CR_hoja_de_ruta.Show()
            actualizar_dgv()
            actualizar_folio()
            'actualizar_dgv_retiros()
            If txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then
                GroupBox1.Visible = True
            Else
                GroupBox1.Visible = False
            End If
        Else
            MessageBox.Show("FALTAN DATOS POR INGRESAR")
        End If
    End Sub
    Sub limpiar()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_n_ped2.Clear()
        txt_ejecutivo2.Clear()
        txt_direccion2.Clear()
        txt_comuna2.Clear()
        txt_cliente2.Clear()
        txt_tipo2.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txt_n_ped3.Clear()
        txt_ejecutivo3.Clear()
        txt_direccion3.Clear()
        txt_comuna3.Clear()
        txt_cliente3.Clear()
        txt_tipo3.Clear()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt_n_ped4.Clear()
        txt_ejecutivo4.Clear()
        txt_direccion4.Clear()
        txt_comuna4.Clear()
        txt_cliente4.Clear()
        txt_tipo4.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_n_ped5.Clear()
        txt_ejecutivo5.Clear()
        txt_direccion5.Clear()
        txt_comuna5.Clear()
        txt_cliente5.Clear()
        txt_tipo5.Clear()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txt_n_ped6.Clear()
        txt_ejecutivo6.Clear()
        txt_direccion6.Clear()
        txt_comuna6.Clear()
        txt_cliente6.Clear()
        txt_tipo6.Clear()
    End Sub
    Sub actualizar_dgv()
        Dim Fecha_inicio1 As String
        Dim Fecha_anterior As String
        If txt_fecha.Text <> "" Then
            Fecha_inicio1 = Format(CDate(txt_fecha.Text), "yyyy/MM/dd")
            Fecha_anterior = Format(CDate(txt_fecha_ant.Text), "yyyy/MM/dd")
            dgv_rutas.DataSource = nue_cur.Registrar_rutas_pendientes()

            dgv_rutas.Columns(0).HeaderText = "Tipo"
            dgv_rutas.Columns(1).HeaderText = "N° de pedido"
            dgv_rutas.Columns(2).HeaderText = "Fecha"
            dgv_rutas.Columns(3).HeaderText = "Hora"
            dgv_rutas.Columns(4).HeaderText = "Toma Pedido"
            dgv_rutas.Columns(5).HeaderText = "Comuna"
            dgv_rutas.Columns(6).HeaderText = "Dirección"
            dgv_rutas.Columns(7).HeaderText = "Cliente"
            dgv_rutas.Columns(8).HeaderText = "Factura"

            dgv_rutas.Columns(0).DisplayIndex = 0
            dgv_rutas.Columns(1).DisplayIndex = 1
            dgv_rutas.Columns(8).DisplayIndex = 2
            dgv_rutas.Columns(7).DisplayIndex = 3
            dgv_rutas.Columns(4).DisplayIndex = 4
            dgv_rutas.Columns(2).DisplayIndex = 5
            dgv_rutas.Columns(3).DisplayIndex = 6
            dgv_rutas.Columns(6).DisplayIndex = 7
            dgv_rutas.Columns(5).DisplayIndex = 8

            dgv_rutas.Columns(0).Width = 60
            dgv_rutas.Columns(1).Width = 63
            dgv_rutas.Columns(2).Width = 63
            dgv_rutas.Columns(3).Width = 63
            dgv_rutas.Columns(4).Width = 75
            dgv_rutas.Columns(5).Width = 100
            dgv_rutas.Columns(6).Width = 300
            dgv_rutas.Columns(7).Width = 250
            dgv_rutas.Columns(8).Width = 63
        End If
    End Sub

    Private Sub btn_actulizarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actulizarDatos.Click
        tipo_documento = 0
        dgv_rutas.DataSource = Nothing
        actualizar_dgv()
        If (dgv_datosAgregados.RowCount >= 1) Then
            Dim tipo As String
            Dim numero As Integer
            For indexAgrega As Integer = 0 To dgv_datosAgregados.RowCount - 1
                tipo = dgv_datosAgregados.Rows(indexAgrega).Cells(0).Value.ToString()
                numero = dgv_datosAgregados.Rows(indexAgrega).Cells(1).Value
                For indexContenido As Integer = 0 To dgv_rutas.RowCount - 1
                    If (tipo.Equals(dgv_rutas.Rows(indexContenido).Cells(0).Value.ToString()) And numero = dgv_rutas.Rows(indexContenido).Cells(1).Value) Then
                        Dim fila As Integer = dgv_rutas.CurrentRow.Index
                        dgv_rutas.Rows(indexContenido).DefaultCellStyle.BackColor = Color.Red
                    End If
                Next
            Next
        End If
        'actualizar_dgv_retiros()
    End Sub

    Private Sub dgv_rutas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_rutas.CellDoubleClick
        'Dim verificacion As String
        'verificacion = dgv_rutas.CurrentRow.Cells(12).Value.ToString()
        'If dgv_rutas.CurrentRow.Cells(12).Value.ToString() = "0" Then
        '    MsgBox("ESTE PEDIDO NO ESTA RELACIONADO CON NINGUNA FACTURA")
        'Else
        ' inicio Codigo a utilizar para sacer los textos
        If dgv_rutas.RowCount >= 1 Then
            Dim verificacion As String = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
            If verificacion = "0" Then
                MsgBox("ESTE PEDIDO NO ESTA RELACIONADO CON NINGUNA FACTURA")
            Else

                Dim numeroPedido As Integer = dgv_rutas.CurrentRow.Cells(1).Value.ToString()

                For index As Integer = 0 To dgv_datosAgregados.RowCount - 1
                    If (numeroPedido = CInt(dgv_datosAgregados.Rows(index).Cells(1).Value)) Then
                        MsgBox("Este pedido ha sido seleccionado anteriormente.", MsgBoxStyle.Information, "Información")
                        Exit Sub
                    End If
                Next

                dgv_datosAgregados.Rows.Add()
                Dim cantDatosAgregados As Integer = dgv_datosAgregados.RowCount - 1
                'If tipo_documento = 1 Then
                '    dgv_datosAgregados.Rows(cantDatosAgregados).Cells(0).Value = "GUIA"
                'Else
                '    dgv_datosAgregados.Rows(cantDatosAgregados).Cells(0).Value = "PEDIDO"
                'End If
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(0).Value = dgv_rutas.CurrentRow.Cells(0).Value.ToString()
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(1).Value = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(2).Value = dgv_rutas.CurrentRow.Cells(4).Value.ToString()
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(3).Value = dgv_rutas.CurrentRow.Cells(7).Value.ToString()
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(4).Value = dgv_rutas.CurrentRow.Cells(6).Value.ToString()
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(5).Value = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(6).Value = "Quitar"
                dgv_datosAgregados.Rows(cantDatosAgregados).Cells(7).Value = "Ver"
                Dim fila As Integer = dgv_rutas.CurrentRow.Index
                dgv_rutas.Rows(fila).DefaultCellStyle.BackColor = Color.Red
            End If

        End If
        ' Termino Codigo a utilizar para sacer los textos

        'If rbtn_ruta1.Checked = True Then
        '    txt_n_ped1.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo1.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion1.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna1.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente1.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo1.Text = "GUIA"
        '    Else
        '        txt_tipo1.Text = "PEDIDO"
        '    End If
        'ElseIf rbtn_ruta2.Checked = True Then
        '    txt_n_ped2.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo2.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion2.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna2.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente2.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo2.Text = "GUIA"
        '    Else
        '        txt_tipo2.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta3.Checked = True Then
        '    txt_n_ped3.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo3.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion3.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna3.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente3.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo3.Text = "GUIA"
        '    Else
        '        txt_tipo3.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta4.Checked = True Then
        '    txt_n_ped4.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo4.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion4.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna4.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente4.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo4.Text = "GUIA"
        '    Else
        '        txt_tipo4.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta5.Checked = True Then
        '    txt_n_ped5.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo5.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion5.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna5.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente5.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo5.Text = "GUIA"
        '    Else
        '        txt_tipo5.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta6.Checked = True Then
        '    txt_n_ped6.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo6.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion6.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna6.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente6.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo6.Text = "GUIA"
        '    Else
        '        txt_tipo6.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta7.Checked = True Then
        '    txt_n_ped7.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo7.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion7.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna7.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente7.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo7.Text = "GUIA"
        '    Else
        '        txt_tipo7.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta8.Checked = True Then
        '    txt_n_ped8.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo8.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion8.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna8.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente8.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo8.Text = "GUIA"
        '    Else
        '        txt_tipo8.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta9.Checked = True Then
        '    txt_n_ped9.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo9.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion9.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna9.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente9.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo9.Text = "GUIA"
        '    Else
        '        txt_tipo9.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta10.Checked = True Then
        '    txt_n_ped10.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo10.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion10.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna10.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente10.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo10.Text = "GUIA"
        '    Else
        '        txt_tipo10.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta11.Checked = True Then
        '    txt_n_ped11.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo11.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion11.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna11.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente11.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo11.Text = "GUIA"
        '    Else
        '        txt_tipo11.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta12.Checked = True Then
        '    txt_n_ped12.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo12.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion12.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna12.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente12.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo12.Text = "GUIA"
        '    Else
        '        txt_tipo12.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta13.Checked = True Then
        '    txt_n_ped13.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo13.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion13.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna13.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente13.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo13.Text = "GUIA"
        '    Else
        '        txt_tipo13.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta14.Checked = True Then
        '    txt_n_ped14.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo14.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion14.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna14.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente14.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo14.Text = "GUIA"
        '    Else
        '        txt_tipo14.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta15.Checked = True Then
        '    txt_n_ped15.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo15.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion15.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna15.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente15.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo15.Text = "GUIA"
        '    Else
        '        txt_tipo15.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta16.Checked = True Then
        '    txt_n_ped16.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo16.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion16.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna16.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente16.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo16.Text = "GUIA"
        '    Else
        '        txt_tipo16.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta17.Checked = True Then
        '    txt_n_ped17.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo17.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion17.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna17.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente17.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo17.Text = "GUIA"
        '    Else
        '        txt_tipo17.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta18.Checked = True Then
        '    txt_n_ped18.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo18.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion18.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna18.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente18.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo18.Text = "GUIA"
        '    Else
        '        txt_tipo18.Text = "PEDIDO"
        '    End If

        'ElseIf rbtn_ruta19.Checked = True Then
        '    txt_n_ped19.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo19.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion19.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna19.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente19.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo19.Text = "GUIA"
        '    Else
        '        txt_tipo19.Text = "PEDIDO"
        '    End If


        'ElseIf rbtn_ruta20.Checked = True Then
        '    txt_n_ped20.Text = dgv_rutas.CurrentRow.Cells(1).Value.ToString()
        '    txt_ejecutivo20.Text = dgv_rutas.CurrentRow.Cells(5).Value.ToString()
        '    txt_direccion20.Text = dgv_rutas.CurrentRow.Cells(9).Value.ToString()
        '    txt_comuna20.Text = dgv_rutas.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente20.Text = dgv_rutas.CurrentRow.Cells(11).Value.ToString()
        '    If tipo_documento = 1 Then
        '        txt_tipo20.Text = "GUIA"
        '    Else
        '        txt_tipo20.Text = "PEDIDO"
        '    End If

        'Else
        'End If
        'End If
    End Sub
    Private Sub cmb_chofer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_chofer.TextChanged
        Dim chofer As String
        chofer = cmb_chofer.Text
        Select Case chofer
            Case "MIGUEL AHUMADA"
                cmb_vehiculo.Text = "Kia  HY CS 38"
            Case "CLIENTE"
                cmb_vehiculo.Text = "RETIRO"
            Case "LEANDRO MAUREIRA"
                cmb_vehiculo.Text = "Hyundai FD JT 41"
            Case "JOSE VALENZUELA"
                cmb_vehiculo.Text = "Hyundai DK HF 99"
            Case "CESAR CELEDÓN"
                cmb_vehiculo.Text = "Fiat HH DJ 65"
            Case "EDUARDO SAAVEDRA"
                cmb_vehiculo.Text = "Mahindra HF ST 90"
            Case "NO SALE DE BODEGA"
                cmb_vehiculo.Text = "OTRO"
        End Select
    End Sub


    Private Sub txt_usuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_usuario.TextChanged
        If txt_usuario.Text = "AZAMORANO" Then
            txt_revisa.Text = "ADRIAN ZAMORANO"
        ElseIf txt_usuario.Text = "CCELEDON" Then
            txt_revisa.Text = "CESAR CELEDÓN"
        ElseIf txt_usuario.Text = "GSOLIS" Then
            txt_revisa.Text = "GERMÁN SOLÍS"
        ElseIf txt_usuario.Text = "TBUSTOS" Then
            txt_revisa.Text = "TERESITA BUSTOS"
        Else
            txt_revisa.Text = txt_usuario.Text
        End If
    End Sub

    Private Sub btn_informe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe1.Click
        If txt_n_ped1.Text <> "" And txt_tipo1.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped1.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped1.Text <> "" And txt_tipo1.Text = "COBRO" Then
            folio_retiro = txt_n_ped1.Text
            CR_orden_retiro2.Show()
        ElseIf txt_n_ped1.Text <> "" And txt_tipo1.Text = "GUIA" Then
            Folio_ruta = txt_n_ped1.Text
            CR_guia_de_despacho_ruta.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe2.Click
        If txt_n_ped2.Text <> "" And txt_tipo2.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped2.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped2.Text <> "" And txt_tipo2.Text = "COBRO" Then
            folio_retiro = txt_n_ped2.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe3.Click
        If txt_n_ped3.Text <> "" And txt_tipo3.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped3.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped3.Text <> "" And txt_tipo3.Text = "COBRO" Then
            folio_retiro = txt_n_ped3.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe4.Click
        If txt_n_ped4.Text <> "" And txt_tipo4.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped4.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped4.Text <> "" And txt_tipo4.Text = "COBRO" Then
            folio_retiro = txt_n_ped4.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe5.Click
        If txt_n_ped5.Text <> "" And txt_tipo5.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped5.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped5.Text <> "" And txt_tipo5.Text = "COBRO" Then
            folio_retiro = txt_n_ped5.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe6.Click
        If txt_n_ped6.Text <> "" And txt_tipo6.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped6.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped6.Text <> "" And txt_tipo6.Text = "COBRO" Then
            folio_retiro = txt_n_ped6.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        txt_n_ped7.Clear()
        txt_ejecutivo7.Clear()
        txt_direccion7.Clear()
        txt_comuna7.Clear()
        txt_cliente7.Clear()
        txt_tipo7.Clear()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        txt_n_ped8.Clear()
        txt_ejecutivo8.Clear()
        txt_direccion8.Clear()
        txt_comuna8.Clear()
        txt_cliente8.Clear()
        txt_tipo8.Clear()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        txt_n_ped9.Clear()
        txt_ejecutivo9.Clear()
        txt_direccion9.Clear()
        txt_comuna9.Clear()
        txt_cliente9.Clear()
        txt_tipo9.Clear()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        txt_n_ped10.Clear()
        txt_ejecutivo10.Clear()
        txt_direccion10.Clear()
        txt_comuna10.Clear()
        txt_cliente10.Clear()
        txt_tipo10.Clear()
    End Sub

    Private Sub btn_informe7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe7.Click
        If txt_n_ped7.Text <> "" And txt_tipo7.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped7.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped7.Text <> "" And txt_tipo7.Text = "COBRO" Then
            folio_retiro = txt_n_ped7.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe8.Click
        If txt_n_ped8.Text <> "" And txt_tipo8.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped8.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped8.Text <> "" And txt_tipo8.Text = "COBRO" Then
            folio_retiro = txt_n_ped8.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe9.Click
        If txt_n_ped9.Text <> "" And txt_tipo9.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped9.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped9.Text <> "" And txt_tipo9.Text = "COBRO" Then
            folio_retiro = txt_n_ped9.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe10.Click
        If txt_n_ped10.Text <> "" And txt_tipo10.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped10.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped10.Text <> "" And txt_tipo10.Text = "COBRO" Then
            folio_retiro = txt_n_ped10.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub
    Sub actualizar_dgv_bus()
        Dim tipo As String
        If (rbtn_factura.Checked) Then
            tipo = "PEDIDO"
        ElseIf (rbtn_guia.Checked) Then
            tipo = "GUIA"
        Else
            tipo = "RETIRO"
        End If
        If txt_n_ped.Text <> "" Then
            dgv_rutas.DataSource = nue_cur.listar3(tipo, txt_n_ped.Text)
            If (dgv_rutas.RowCount = 0) Then
                MsgBox("No hay documento asociado al número de pedido.", MsgBoxStyle.Information, "Información.")
                Exit Sub
            End If
            dgv_rutas.Columns(0).HeaderText = "Tipo"
            dgv_rutas.Columns(1).HeaderText = "N° de pedido"
            dgv_rutas.Columns(2).HeaderText = "Fecha"
            dgv_rutas.Columns(3).HeaderText = "Hora"
            dgv_rutas.Columns(4).HeaderText = "Toma Pedido"
            dgv_rutas.Columns(5).HeaderText = "Comuna"
            dgv_rutas.Columns(6).HeaderText = "Dirección"
            dgv_rutas.Columns(7).HeaderText = "Cliente"
            dgv_rutas.Columns(8).HeaderText = "Factura"

            dgv_rutas.Columns(0).DisplayIndex = 0
            dgv_rutas.Columns(1).DisplayIndex = 1
            dgv_rutas.Columns(8).DisplayIndex = 2
            dgv_rutas.Columns(7).DisplayIndex = 3
            dgv_rutas.Columns(4).DisplayIndex = 4
            dgv_rutas.Columns(2).DisplayIndex = 5
            dgv_rutas.Columns(3).DisplayIndex = 6
            dgv_rutas.Columns(6).DisplayIndex = 7
            dgv_rutas.Columns(5).DisplayIndex = 8

            dgv_rutas.Columns(0).Width = 60
            dgv_rutas.Columns(1).Width = 63
            dgv_rutas.Columns(2).Width = 63
            dgv_rutas.Columns(3).Width = 63
            dgv_rutas.Columns(4).Width = 75
            dgv_rutas.Columns(5).Width = 100
            dgv_rutas.Columns(6).Width = 300
            dgv_rutas.Columns(7).Width = 250
            dgv_rutas.Columns(8).Width = 63

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

    Private Sub btn_buscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarPedido.Click
        tipo_documento = 0
        actualizar_dgv_bus()
    End Sub

    Private Sub dtp_fecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_fecha.TextChanged
        actualizar_folio()
    End Sub
    Public Sub actualizar_folio()
        Fecha_inicio = Me.dtp_fecha.Value.ToShortDateString
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        cmb_folio.DataSource = nue_cur.listar4(Fecha_inicio)
        cmb_folio.DisplayMember = "folio_ruta"
        cmb_folio.ValueMember = "folio_ruta"
    End Sub

    Private Sub dtp_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha.ValueChanged

    End Sub

    Private Sub btn_consultaRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultaRuta.Click
        If cmb_folio.Text <> "" Then
            CR_hoja_de_ruta1.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_otros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_registro_llegada.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        nue_cur.eliminar2(cmb_folio.Text)
        nue_cur.eliminar(cmb_folio.Text)
        MessageBox.Show("SE HA ELIMINADO LA RUTA SELECCIONADA")
        actualizar_dgv()
        actualizar_folio()
        actualizar_dgv_retiros()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        txt_n_ped11.Clear()
        txt_ejecutivo11.Clear()
        txt_direccion11.Clear()
        txt_comuna11.Clear()
        txt_cliente11.Clear()
        txt_tipo11.Clear()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        txt_n_ped12.Clear()
        txt_ejecutivo12.Clear()
        txt_direccion12.Clear()
        txt_comuna12.Clear()
        txt_cliente12.Clear()
        txt_tipo12.Clear()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        txt_n_ped13.Clear()
        txt_ejecutivo13.Clear()
        txt_direccion13.Clear()
        txt_comuna13.Clear()
        txt_cliente13.Clear()
        txt_tipo13.Clear()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        txt_n_ped14.Clear()
        txt_ejecutivo14.Clear()
        txt_direccion14.Clear()
        txt_comuna14.Clear()
        txt_cliente14.Clear()
        txt_tipo14.Clear()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        txt_n_ped15.Clear()
        txt_ejecutivo15.Clear()
        txt_direccion15.Clear()
        txt_comuna15.Clear()
        txt_cliente15.Clear()
        txt_tipo15.Clear()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        txt_n_ped16.Clear()
        txt_ejecutivo16.Clear()
        txt_direccion16.Clear()
        txt_comuna16.Clear()
        txt_cliente16.Clear()
        txt_tipo16.Clear()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        txt_n_ped17.Clear()
        txt_ejecutivo17.Clear()
        txt_direccion17.Clear()
        txt_comuna17.Clear()
        txt_cliente17.Clear()
        txt_tipo17.Clear()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txt_n_ped18.Clear()
        txt_ejecutivo18.Clear()
        txt_direccion18.Clear()
        txt_comuna18.Clear()
        txt_cliente18.Clear()
        txt_tipo18.Clear()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txt_n_ped19.Clear()
        txt_ejecutivo19.Clear()
        txt_direccion19.Clear()
        txt_comuna19.Clear()
        txt_cliente19.Clear()
        txt_tipo19.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txt_n_ped20.Clear()
        txt_ejecutivo20.Clear()
        txt_direccion20.Clear()
        txt_comuna20.Clear()
        txt_cliente20.Clear()
        txt_tipo20.Clear()
    End Sub

    Private Sub btn_informe11_Click(sender As Object, e As EventArgs) Handles btn_informe11.Click
        If txt_n_ped11.Text <> "" And txt_tipo11.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped11.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped11.Text <> "" And txt_tipo11.Text = "RETIRO" Then
            folio_retiro = txt_n_ped11.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe12_Click(sender As Object, e As EventArgs) Handles btn_informe12.Click
        If txt_n_ped12.Text <> "" And txt_tipo12.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped12.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped12.Text <> "" And txt_tipo12.Text = "RETIRO" Then
            folio_retiro = txt_n_ped12.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe13_Click(sender As Object, e As EventArgs) Handles btn_informe13.Click
        If txt_n_ped13.Text <> "" And txt_tipo13.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped13.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped13.Text <> "" And txt_tipo13.Text = "RETIRO" Then
            folio_retiro = txt_n_ped13.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe14_Click(sender As Object, e As EventArgs) Handles btn_informe14.Click
        If txt_n_ped14.Text <> "" And txt_tipo14.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped14.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped14.Text <> "" And txt_tipo14.Text = "RETIRO" Then
            folio_retiro = txt_n_ped14.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe15_Click(sender As Object, e As EventArgs) Handles btn_informe15.Click
        If txt_n_ped15.Text <> "" And txt_tipo15.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped15.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped15.Text <> "" And txt_tipo15.Text = "RETIRO" Then
            folio_retiro = txt_n_ped15.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe16_Click(sender As Object, e As EventArgs) Handles btn_informe16.Click
        If txt_n_ped16.Text <> "" And txt_tipo16.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped16.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped16.Text <> "" And txt_tipo16.Text = "RETIRO" Then
            folio_retiro = txt_n_ped16.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe17_Click(sender As Object, e As EventArgs) Handles btn_informe17.Click
        If txt_n_ped17.Text <> "" And txt_tipo17.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped17.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped17.Text <> "" And txt_tipo17.Text = "RETIRO" Then
            folio_retiro = txt_n_ped17.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe18_Click(sender As Object, e As EventArgs) Handles btn_informe18.Click
        If txt_n_ped18.Text <> "" And txt_tipo18.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped18.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped18.Text <> "" And txt_tipo18.Text = "RETIRO" Then
            folio_retiro = txt_n_ped18.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe19_Click(sender As Object, e As EventArgs) Handles btn_informe19.Click
        If txt_n_ped19.Text <> "" And txt_tipo19.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped19.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped19.Text <> "" And txt_tipo19.Text = "RETIRO" Then
            folio_retiro = txt_n_ped19.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_informe20_Click(sender As Object, e As EventArgs) Handles btn_informe20.Click
        If txt_n_ped20.Text <> "" And txt_tipo20.Text = "PEDIDO" Then
            Folio_ruta = txt_n_ped20.Text
            CR_guia_de_despacho_ruta.Show()
        ElseIf txt_n_ped20.Text <> "" And txt_tipo20.Text = "RETIRO" Then
            folio_retiro = txt_n_ped20.Text
            CR_orden_retiro2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub
    Sub actualizar_dgv_retiros()
        dgv_retiro.DataSource = nue_cur.listar13()
        dgv_retiro.Columns(0).HeaderText = "Folio"
        dgv_retiro.Columns(1).HeaderText = "Cliente"
        dgv_retiro.Columns(2).Visible = False
        dgv_retiro.Columns(3).HeaderText = "Fecha"
        dgv_retiro.Columns(4).HeaderText = "Usuario"
        dgv_retiro.Columns(5).Visible = False
        dgv_retiro.Columns(6).Visible = False
        dgv_retiro.Columns(7).HeaderText = "Dirección Despacho"
        dgv_retiro.Columns(8).HeaderText = "Comuna Despacho"
        dgv_retiro.Columns(9).Visible = False

        dgv_retiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_retiro.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_retiro.Columns(0).DisplayIndex = 0
        dgv_retiro.Columns(1).DisplayIndex = 1
        dgv_retiro.Columns(2).DisplayIndex = 2
        dgv_retiro.Columns(3).DisplayIndex = 3
        dgv_retiro.Columns(5).DisplayIndex = 4
        dgv_retiro.Columns(6).DisplayIndex = 5
        dgv_retiro.Columns(7).DisplayIndex = 6
        dgv_retiro.Columns(8).DisplayIndex = 7
        dgv_retiro.Columns(9).DisplayIndex = 8
        dgv_retiro.Columns(4).DisplayIndex = 9


        dgv_retiro.Columns(0).Width = 50
        dgv_retiro.Columns(1).Width = 250
        dgv_retiro.Columns(7).Width = 250
        dgv_retiro.Columns(8).Width = 100
        dgv_retiro.Columns(3).Width = 70
        dgv_retiro.Columns(4).Width = 70


    End Sub

    Private Sub dgv_retiro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_retiro.CellDoubleClick

        ' INICIO DE INGRESO DE DATOS AL DGV_DATOS_AGREGADOS

        If dgv_retiro.RowCount >= 1 Then

            Dim numeroPedido As Integer = dgv_retiro.CurrentRow.Cells(0).Value.ToString()

            For index As Integer = 0 To dgv_datosAgregados.RowCount - 1
                If (numeroPedido = CInt(dgv_datosAgregados.Rows(index).Cells(1).Value)) Then
                    MsgBox("Este retiro ha sido seleccionado anteriormente.", MsgBoxStyle.Information, "Información")
                    Exit Sub
                End If
            Next

            dgv_datosAgregados.Rows.Add()
            Dim cantDatosAgregados As Integer = dgv_datosAgregados.RowCount - 1
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(0).Value = "COBRO"
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(1).Value = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(2).Value = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(3).Value = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(4).Value = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(5).Value = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(6).Value = "Quitar"
            dgv_datosAgregados.Rows(cantDatosAgregados).Cells(7).Value = "Ver"
            Dim fila As Integer = dgv_retiro.CurrentRow.Index
            dgv_retiro.Rows(fila).DefaultCellStyle.BackColor = Color.Red

        End If
        ' Termino Codigo a utilizar para sacer los textos

        ' TERMINO DE INGRESO DE DATOS AL DGV_DATOS_AGREGADOS

        'If rbtn_ruta1.Checked = True Then
        '    txt_n_ped1.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo1.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion1.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna1.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente1.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo1.Text = "COBRO"

        'ElseIf rbtn_ruta2.Checked = True Then
        '    txt_n_ped2.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo2.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion2.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna2.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente2.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo2.Text = "COBRO"

        'ElseIf rbtn_ruta3.Checked = True Then
        '    txt_n_ped3.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo3.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion3.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna3.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente3.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo3.Text = "COBRO"

        'ElseIf rbtn_ruta4.Checked = True Then
        '    txt_n_ped4.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo4.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion4.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna4.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente4.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo4.Text = "COBRO"

        'ElseIf rbtn_ruta5.Checked = True Then
        '    txt_n_ped5.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo5.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion5.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna5.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente5.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo5.Text = "COBRO"

        'ElseIf rbtn_ruta6.Checked = True Then
        '    txt_n_ped6.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo6.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion6.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna6.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente6.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo6.Text = "COBRO"

        'ElseIf rbtn_ruta7.Checked = True Then
        '    txt_n_ped7.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo7.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion7.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna7.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente7.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo7.Text = "COBRO"

        'ElseIf rbtn_ruta8.Checked = True Then
        '    txt_n_ped8.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo8.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion8.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna8.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente8.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo8.Text = "COBRO"

        'ElseIf rbtn_ruta9.Checked = True Then
        '    txt_n_ped9.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo9.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion9.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna9.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente9.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo9.Text = "COBRO"

        'ElseIf rbtn_ruta10.Checked = True Then
        '    txt_n_ped10.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo10.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion10.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna10.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente10.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo10.Text = "COBRO"

        'ElseIf rbtn_ruta11.Checked = True Then
        '    txt_n_ped11.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo11.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion11.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna11.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente11.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo11.Text = "COBRO"

        'ElseIf rbtn_ruta12.Checked = True Then
        '    txt_n_ped12.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo12.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion12.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna12.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente12.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo12.Text = "COBRO"

        'ElseIf rbtn_ruta13.Checked = True Then
        '    txt_n_ped13.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo13.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion13.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna13.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente13.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo13.Text = "COBRO"

        'ElseIf rbtn_ruta14.Checked = True Then
        '    txt_n_ped14.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo14.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion14.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna14.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente14.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo14.Text = "COBRO"

        'ElseIf rbtn_ruta15.Checked = True Then
        '    txt_n_ped15.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo15.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion15.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna15.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente15.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo15.Text = "COBRO"

        'ElseIf rbtn_ruta16.Checked = True Then
        '    txt_n_ped16.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo16.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion16.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna16.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente16.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo16.Text = "COBRO"

        'ElseIf rbtn_ruta17.Checked = True Then
        '    txt_n_ped17.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo17.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion17.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna17.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente17.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo17.Text = "COBRO"

        'ElseIf rbtn_ruta18.Checked = True Then
        '    txt_n_ped18.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo18.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion18.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna18.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente18.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo18.Text = "COBRO"

        'ElseIf rbtn_ruta19.Checked = True Then
        '    txt_n_ped19.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo19.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion19.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna19.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente19.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo19.Text = "COBRO"

        'ElseIf rbtn_ruta20.Checked = True Then
        '    txt_n_ped20.Text = dgv_retiro.CurrentRow.Cells(0).Value.ToString()
        '    txt_ejecutivo20.Text = dgv_retiro.CurrentRow.Cells(4).Value.ToString()
        '    txt_direccion20.Text = dgv_retiro.CurrentRow.Cells(7).Value.ToString()
        '    txt_comuna20.Text = dgv_retiro.CurrentRow.Cells(8).Value.ToString()
        '    txt_cliente20.Text = dgv_retiro.CurrentRow.Cells(1).Value.ToString()
        '    txt_tipo20.Text = "COBRO"
        'End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
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


    Private Sub txt_revisa_TextChanged(sender As Object, e As EventArgs)
        If txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub txt_revisa2_TextChanged(sender As Object, e As EventArgs)
        If txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Public Sub actualizar_chofer()
        cmb_chofer.DataSource = nue_cur.listar22("CHOFER")
        cmb_chofer.DisplayMember = "usuario"
        cmb_chofer.ValueMember = "usuario"
    End Sub
    Public Sub actualizar_peoneta()
        cmb_peoneta.DataSource = nue_cur.listar22("PEONETA")
        cmb_peoneta.DisplayMember = "usuario"
        cmb_peoneta.ValueMember = "usuario"
    End Sub
    Public Sub actualizar_revision1()
        txt_revisa.DataSource = nue_cur.listar22("REVISIÓN I")
        txt_revisa.DisplayMember = "usuario"
        txt_revisa.ValueMember = "usuario"
    End Sub
    Public Sub actualizar_revision2()
        txt_revisa2.DataSource = nue_cur.listar22("REVISIÓN II")
        txt_revisa2.DisplayMember = "usuario"
        txt_revisa2.ValueMember = "usuario"
    End Sub
    Public Sub actualizar_revision3()
        cmb_vehiculo.DataSource = nue_cur.listar22("CAMIONETA")
        cmb_vehiculo.DisplayMember = "usuario"
        cmb_vehiculo.ValueMember = "usuario"
    End Sub

    Private Sub txt_revisa2_TextChanged1(sender As Object, e As EventArgs) Handles txt_revisa2.TextChanged
        If txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub txt_revisa_TextChanged1(sender As Object, e As EventArgs) Handles txt_revisa.TextChanged
        If txt_revisa.Text <> "" And txt_revisa2.Text <> "" Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub dgv_datosAgregados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellContentClick
        If (dgv_datosAgregados.RowCount = 0) Or (e.RowIndex < 0) Then
            Exit Sub
        End If
        Dim filaTipo As String = dgv_datosAgregados.Rows(e.RowIndex).Cells(0).Value
        Dim filaNumero As Integer = dgv_datosAgregados.Rows(e.RowIndex).Cells(1).Value
        'MsgBox(filaNumero)
        If e.ColumnIndex = 6 Then
            Select Case filaTipo
                Case "PEDIDO"
                    TipoPedido(filaNumero)
                Case "COBRO"
                    TipoRetiro(filaNumero)
                Case "GUIA"
                    TipoRetiro(filaNumero)
            End Select
            dgv_datosAgregados.Rows.RemoveAt(e.RowIndex)

        ElseIf e.ColumnIndex = 7 Then
            Select Case filaTipo
                Case "PEDIDO"
                    Folio_ruta = filaNumero
                    CR_guia_de_despacho_ruta.Show()
                Case "COBRO"
                    folio_retiro = filaNumero
                    CR_orden_retiro2.Show()
                Case "GUIA"
                    Folio_ruta = filaNumero
                    frm_cr_guia_despacho.Show()
            End Select
        End If

    End Sub

    Private Sub TipoPedido(ByVal fila As Integer)
        For index As Integer = 0 To dgv_rutas.RowCount - 1
            If (fila = dgv_rutas.Rows(index).Cells(1).Value) Then
                dgv_rutas.Rows(index).DefaultCellStyle.BackColor = Color.White
                Exit For
            End If
        Next
    End Sub
    Private Sub TipoRetiro(ByVal fila As Integer)
        For index As Integer = 0 To dgv_retiro.RowCount - 1
            If (fila = dgv_retiro.Rows(index).Cells(0).Value) Then
                dgv_retiro.Rows(index).DefaultCellStyle.BackColor = Color.White
                Exit For
            End If
        Next
    End Sub

End Class