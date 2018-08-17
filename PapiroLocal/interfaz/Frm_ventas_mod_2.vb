Imports System.Globalization
Public Class Frm_ventas_mod_2

    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub bloquear()
        btn_guardar.Enabled = False
        btnEliminar.Enabled = True
        txt_rut.ReadOnly = True
        txt_area_negocio.ReadOnly = True
        txt_senal_advertencia.ReadOnly = True
        txt_comuna.ReadOnly = True
        txt_familia1.ReadOnly = True
        txt_familia2.ReadOnly = True
        txt_familia3.ReadOnly = True
        txt_cantidad.Enabled = False
        txt_observaciones.ReadOnly = True
        txt_descripcion.ReadOnly = True
        txt_proveedor.ReadOnly = True
        txt_area_calculada.ReadOnly = True
        txt_precio_lista.ReadOnly = True
        txt_precio_cliente.ReadOnly = True
        txt_monto.ReadOnly = True
        txt_iva.ReadOnly = True
        txt_total.ReadOnly = True
        txt_direccion_despacho.ReadOnly = True
        txt_area_calc.ReadOnly = True
        cmb_cliente.ReadOnly = True
        txt_numero_pedido.ReadOnly = True
        txt_folio.ReadOnly = True
        txt_precio_cliente.ReadOnly = True
        txt_precio_lista.ReadOnly = True
        txt_monto.ReadOnly = True
        txt_iva.ReadOnly = True
        txt_total.ReadOnly = True
        txt_stock.ReadOnly = True
        cmb_codigo.ReadOnly = True
        txt_fecha_act.ReadOnly = True
        txt_hora.ReadOnly = True
        txt_medidas.ReadOnly = True
        txt_nombre_comercial.ReadOnly = True
        txt_email_comercial.ReadOnly = True
        txt_telefonos_comercial.ReadOnly = True
        txt_cargo_comercial.ReadOnly = True
        txt_fecha.Enabled = False
        txt_linea_credito.ReadOnly = True
        gbx_Mov_Tierra.Visible = False
        txt_consulta_iva.ReadOnly = True
        txt_consulta_monto.ReadOnly = True
        txt_consulta_total.ReadOnly = True
        txt_ult_venta.ReadOnly = True
        txt_descuento.ReadOnly = True
        txt_precio_max.ReadOnly = True
        txt_precio_min.ReadOnly = True
    End Sub

    Sub desbloquear()
        gbx_Mov_Tierra.Enabled = True
        btn_guardar.Enabled = True
        btnEliminar.Enabled = False
        txt_observaciones.Enabled = True
        txt_cantidad.Enabled = True
        btn_buscar_producto.Visible = False
        gbx_Mov_Tierra.Visible = True
        txt_venta_m2.Enabled = True
        txt_fecha.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Sub limpiar()
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Text = 0
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()
        txt_ult_venta.Clear()
        txt_descuento.Clear()
        txt_precio_max.Clear()
        txt_precio_min.Clear()

    End Sub

    Sub actualizar_dgv()
        dgv_Mov_Tierra.DataSource = nue_report.listar(cmb_cliente.Text)
        dgv_Mov_Tierra.Columns(0).Visible = False
        dgv_Mov_Tierra.AllowUserToOrderColumns = True
        dgv_Mov_Tierra.Columns(1).Visible = False
        dgv_Mov_Tierra.Columns(1).Width = 200
        dgv_Mov_Tierra.Columns(2).Visible = False
        dgv_Mov_Tierra.Columns(3).Visible = False
        dgv_Mov_Tierra.Columns(4).Visible = False
        dgv_Mov_Tierra.Columns(5).Visible = False
        dgv_Mov_Tierra.Columns(6).Visible = False
        dgv_Mov_Tierra.Columns(7).Visible = False
        dgv_Mov_Tierra.Columns(8).Visible = False
        dgv_Mov_Tierra.Columns(9).Visible = False
        dgv_Mov_Tierra.Columns(10).HeaderText = "Medidas"
        dgv_Mov_Tierra.Columns(11).Visible = False
        dgv_Mov_Tierra.Columns(12).Visible = False
        dgv_Mov_Tierra.Columns(13).HeaderText = "Descripción"
        dgv_Mov_Tierra.Columns(13).Width = 230
        dgv_Mov_Tierra.Columns(14).HeaderText = "Área Un."
        dgv_Mov_Tierra.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(15).HeaderText = "Cantidad"
        dgv_Mov_Tierra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(16).Visible = False
        dgv_Mov_Tierra.Columns(17).Visible = False
        dgv_Mov_Tierra.Columns(18).HeaderText = "Precio M2"
        dgv_Mov_Tierra.Columns(18).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(19).HeaderText = "Venta"
        dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(20).Visible = False
        dgv_Mov_Tierra.Columns(21).Visible = False
        dgv_Mov_Tierra.Columns(22).Visible = False
        dgv_Mov_Tierra.Columns(23).Visible = False
        dgv_Mov_Tierra.Columns(24).Visible = False
        dgv_Mov_Tierra.Columns(25).Visible = False
        dgv_Mov_Tierra.Columns(26).Visible = False
        dgv_Mov_Tierra.Columns(27).Visible = False
        dgv_Mov_Tierra.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(28).HeaderText = "Precio Un."
        dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(29).HeaderText = "Fecha"
        dgv_Mov_Tierra.Columns(30).Visible = False
        dgv_Mov_Tierra.Columns(31).Visible = False
        dgv_Mov_Tierra.Columns(32).Visible = False
        dgv_Mov_Tierra.Columns(33).Visible = False
        dgv_Mov_Tierra.Columns(34).HeaderText = "N° Venta"
        dgv_Mov_Tierra.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(34).DefaultCellStyle.Format = "###,###,###"
        dgv_Mov_Tierra.Columns(34).DisplayIndex = 0
        dgv_Mov_Tierra.Columns(29).DisplayIndex = 1
        dgv_Mov_Tierra.Columns(13).DisplayIndex = 2
        dgv_Mov_Tierra.Columns(10).DisplayIndex = 3
        dgv_Mov_Tierra.Columns(15).DisplayIndex = 4
        dgv_Mov_Tierra.Columns(18).DisplayIndex = 5
        dgv_Mov_Tierra.Columns(14).DisplayIndex = 6
        dgv_Mov_Tierra.Columns(28).DisplayIndex = 7
        dgv_Mov_Tierra.Columns(19).DisplayIndex = 8
        dgv_Mov_Tierra.Columns(30).DisplayIndex = 9
        dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(30).Width = 50
        dgv_Mov_Tierra.Columns(10).Width = 60
        dgv_Mov_Tierra.Columns(15).Width = 50
        dgv_Mov_Tierra.Columns(28).Width = 60
        dgv_Mov_Tierra.Columns(29).Width = 65
        dgv_Mov_Tierra.Columns(18).Width = 60
        dgv_Mov_Tierra.Columns(19).Width = 60
        dgv_Mov_Tierra.Columns(34).Width = 60
        dgv_Mov_Tierra.Columns(14).Width = 40
        dgv_Mov_Tierra.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub actualizar_sustitutos()
        dgv_sustitutos.DataSource = nue_report.listar4(cmb_codigo.Text)
        dgv_sustitutos.Columns(0).Visible = False
        dgv_sustitutos.Columns(1).Visible = False
        dgv_sustitutos.AllowUserToOrderColumns = True
        dgv_sustitutos.Columns(2).Width = 200
        dgv_sustitutos.Columns(7).Width = 70
        dgv_sustitutos.Columns(4).Width = 70
        dgv_sustitutos.Columns(2).HeaderText = "Descripción"
        dgv_sustitutos.Columns(3).Visible = False
        dgv_sustitutos.Columns(4).HeaderText = "Marca"
        dgv_sustitutos.Columns(6).Visible = False
        dgv_sustitutos.Columns(5).Visible = False
        dgv_sustitutos.Columns(7).HeaderText = "Medidas"
        dgv_sustitutos.Columns(8).Visible = False
        dgv_sustitutos.Columns(9).Visible = False
        dgv_sustitutos.Columns(10).Visible = False
        dgv_sustitutos.Columns(11).Visible = False
        dgv_sustitutos.Columns(12).Visible = False
        dgv_sustitutos.Columns(13).Visible = False
        dgv_sustitutos.Columns(14).Visible = False
        dgv_sustitutos.Columns(15).Visible = False
        dgv_sustitutos.Columns(16).Visible = False
        dgv_sustitutos.Columns(17).Visible = False
        dgv_sustitutos.Columns(18).Visible = False
        dgv_sustitutos.Columns(19).Visible = False
        dgv_sustitutos.Columns(20).Visible = False
        dgv_sustitutos.Columns(21).Visible = False
        dgv_sustitutos.Columns(22).Visible = False
        dgv_sustitutos.Columns(23).Visible = False
        dgv_sustitutos.Columns(24).Visible = False

    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear()
        cmb_cliente.Text = cliente
        txt_rut.Text = rut
        txt_senal_advertencia.Text = senal_advertencia
        txt_comuna.Text = comuna
        txt_direccion_despacho.Text = direccion
        Me.WindowState = FormWindowState.Maximized
        txt_nombre_ejecutivo.Text = Nombre_Obra
        txt_nombre_ejecutivo.ReadOnly = True
        txt_cantidad.Text = ""
        btn_buscar_producto.Enabled = True
        Timer1.Enabled = True
        txt_folio.Text = 1
        txt_monto.Text = 0
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, condicion, forma_pago, ejecutivo, observaciones, toma_pedido As String
        Dim area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, dias_pago, precio_lista, precio_cliente, pedido, descuento, folio As Double
        If nue_report.descripcion_numero_folio2(CDbl(txt_folio.Text)) = txt_folio.Text Then
            txt_folio.Visible = True
            lbl_folio.Visible = True
        Else
            txt_folio.Text = nue_report.descripcion_numero_folio() + 1
            txt_numero_pedido.Text = 0
            nue_report.insertar3(CDbl(txt_folio.Text), txt_numero_pedido.Text, cmb_cliente.Text)
            txt_folio.Visible = True
            lbl_folio.Visible = True
        End If

        If (cmb_cliente.Text <> "" And cmb_codigo.Text <> "" And txt_nombre_ejecutivo.Text <> "" And txt_venta_m2.Text <> "" And txt_cantidad.Text <> "" And txt_monto.Text <> 0) Then
            If (CDbl(txt_precio_min.Text) > CDbl(txt_venta_m2.Text) Or CDbl(txt_precio_max.Text) < CDbl(txt_venta_m2.Text)) Then
                MsgBox("SU PRECIO NO ESTA DENTRO DEL RANGO ESTABLECIDO")

            Else

                cliente = cmb_cliente.Text
                rut = txt_rut.Text
                area_negocio = txt_area_negocio.Text
                senal_advertencia = txt_senal_advertencia.Text
                comuna = txt_comuna.Text
                familia_1 = txt_familia1.Text
                familia_2 = txt_familia2.Text
                familia_3 = txt_familia3.Text
                tipo_1 = "0"
                medidas = txt_medidas.Text
                codigo_producto = cmb_codigo.Text
                proveedor = txt_proveedor.Text
                descripcion = txt_descripcion.Text
                area_calc = Convert.ToDouble(txt_area_calculada.Text)
                cantidad = Convert.ToDouble(txt_cantidad.Text)
                area_total = Convert.ToDouble(txt_area_calc.Text)
                venta_rollo = Convert.ToDouble(txt_precio_lista.Text)
                unit_venta_m2 = Convert.ToDouble(txt_venta_m2.Text)
                venta_neta = Convert.ToDouble(txt_monto.Text)
                venta_iva = Convert.ToDouble(txt_iva.Text)
                venta_total = Convert.ToDouble(txt_total.Text)
                condicion = "0"
                forma_pago = "0"
                dias_pago = "0"
                ejecutivo = txt_nombre_ejecutivo.Text
                observaciones = txt_observaciones.Text
                precio_lista = Convert.ToDouble(txt_precio_lista.Text)
                precio_cliente = Convert.ToDouble(txt_precio_cliente.Text)
                pedido = 0
                descuento = 0
                folio = txt_folio.Text

                If sw = 0 Then
                    nue_report.insertar(cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio, toma_pedido, 0, 0, 0)
                    'nue_report.insertar2(pedido, cliente)
                    actualizar_dgv_venta()
                    txt_consulta_total.Text = nue_report.descripcion_total(cmb_cliente.Text, txt_folio.Text)
                    txt_consulta_iva.Text = nue_report.descripcion_iva(cmb_cliente.Text, txt_folio.Text)
                    txt_consulta_monto.Text = nue_report.descripcion_neto(cmb_cliente.Text, txt_folio.Text)
                    limpiar()
                Else
                    nue_report.modificar(CInt(Cod_Mov_Tierra), cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio)
                    actualizar_dgv_venta()
                    txt_consulta_total.Text = nue_report.descripcion_total(cmb_cliente.Text, txt_numero_pedido.Text)
                    txt_consulta_iva.Text = nue_report.descripcion_iva(cmb_cliente.Text, txt_numero_pedido.Text)
                    txt_consulta_monto.Text = nue_report.descripcion_neto(cmb_cliente.Text, txt_numero_pedido.Text)
                End If
                limpiar()
            End If
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_Mov_Tierra_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Mov_Tierra.CellClick
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()
        txt_precio_min.Clear()
        txt_precio_max.Clear()
        txt_area_negocio.Text = dgv_Mov_Tierra.CurrentRow.Cells(3).Value.ToString()
        txt_familia1.Text = dgv_Mov_Tierra.CurrentRow.Cells(6).Value.ToString()
        txt_familia2.Text = dgv_Mov_Tierra.CurrentRow.Cells(7).Value.ToString()
        txt_familia3.Text = dgv_Mov_Tierra.CurrentRow.Cells(8).Value.ToString()
        txt_medidas.Text = dgv_Mov_Tierra.CurrentRow.Cells(10).Value.ToString()
        cmb_codigo.Text = dgv_Mov_Tierra.CurrentRow.Cells(11).Value.ToString()
        txt_proveedor.Text = dgv_Mov_Tierra.CurrentRow.Cells(12).Value.ToString()
        txt_descripcion.Text = dgv_Mov_Tierra.CurrentRow.Cells(13).Value.ToString()
        txt_area_calculada.Text = dgv_Mov_Tierra.CurrentRow.Cells(14).Value.ToString()
        txt_cantidad.Text = dgv_Mov_Tierra.CurrentRow.Cells(15).Value.ToString()
        txt_area_calc.Text = dgv_Mov_Tierra.CurrentRow.Cells(16).Value.ToString()
        txt_monto.Text = dgv_Mov_Tierra.CurrentRow.Cells(19).Value.ToString()
        txt_iva.Text = dgv_Mov_Tierra.CurrentRow.Cells(20).Value.ToString()
        txt_total.Text = dgv_Mov_Tierra.CurrentRow.Cells(21).Value.ToString()
        txt_observaciones.Text = dgv_Mov_Tierra.CurrentRow.Cells(26).Value.ToString()
        txt_precio_lista.Text = dgv_Mov_Tierra.CurrentRow.Cells(27).Value.ToString()
        txt_precio_cliente.Text = dgv_Mov_Tierra.CurrentRow.Cells(28).Value.ToString()
        txt_ult_venta.Text = txt_precio_lista.Text / txt_area_calculada.Text
        txt_venta_m2.Text = dgv_Mov_Tierra.CurrentRow.Cells(18).Value.ToString()
        txt_precio_min.Text = nue_report.precio_min(cmb_codigo.Text)
        txt_precio_max.Text = nue_report.precio_max(cmb_codigo.Text)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Mov_Tierra))
                actualizar_dgv_venta()
                txt_consulta_total.Text = nue_report.descripcion_total(cmb_cliente.Text, txt_folio.Text)
                txt_consulta_iva.Text = nue_report.descripcion_iva(cmb_cliente.Text, txt_folio.Text)
                txt_consulta_monto.Text = nue_report.descripcion_neto(cmb_cliente.Text, txt_folio.Text)
                txt_ult_venta.Clear()
                txt_venta_m2.Clear()
                txt_descuento.Clear()
                cmb_codigo.Clear()
                txt_descripcion.Clear()
                txt_proveedor.Clear()
                txt_area_calculada.Clear()
                txt_area_negocio.Clear()
                txt_medidas.Clear()
                txt_familia1.Clear()
                txt_familia2.Clear()
                txt_familia3.Clear()
                txt_stock.Clear()
                txt_cantidad.Text = ""
                txt_area_calc.Clear()
                txt_precio_lista.Clear()
                txt_monto.Clear()
                txt_total.Clear()
                txt_precio_cliente.Clear()
                txt_iva.Clear()
                txt_precio_max.Clear()
                txt_precio_min.Clear()
            Else
                bloquear()

            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CR_detalle_venta.Show()
    End Sub
    Sub actualizar_complementarios()
        dgv_complementarios.DataSource = nue_report.listar5(cmb_codigo.Text)
        dgv_complementarios.Columns(0).Visible = False
        dgv_complementarios.Columns(1).Visible = False
        dgv_complementarios.AllowUserToOrderColumns = True
        dgv_complementarios.Columns(2).Width = 200
        dgv_complementarios.Columns(3).Width = 70
        dgv_complementarios.Columns(6).Width = 70
        dgv_complementarios.Columns(2).HeaderText = "Descripción"
        dgv_complementarios.Columns(3).HeaderText = "Marca"
        dgv_complementarios.Columns(4).Visible = False
        dgv_complementarios.Columns(6).HeaderText = "Medidas"
        dgv_complementarios.Columns(5).Visible = False
        dgv_complementarios.Columns(7).Visible = False
        dgv_complementarios.Columns(8).Visible = False
        dgv_complementarios.Columns(9).Visible = False
        dgv_complementarios.Columns(10).Visible = False
        dgv_complementarios.Columns(11).Visible = False
        dgv_complementarios.Columns(12).Visible = False
        dgv_complementarios.Columns(13).Visible = False
        dgv_complementarios.Columns(14).Visible = False
        dgv_complementarios.Columns(15).Visible = False
        dgv_complementarios.Columns(16).Visible = False
        dgv_complementarios.Columns(17).Visible = False
        dgv_complementarios.Columns(18).Visible = False
        dgv_complementarios.Columns(19).Visible = False
        dgv_complementarios.Columns(20).Visible = False
        dgv_complementarios.Columns(21).Visible = False
        dgv_complementarios.Columns(22).Visible = False
        dgv_complementarios.Columns(23).Visible = False
    End Sub
    Private Sub cmb_codigo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_codigo.Click

    End Sub

    Private Sub cmb_codigo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_codigo.MouseClick
        txt_ult_venta.Clear()
        txt_venta_m2.Clear()
        txt_descuento.Clear()
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()
        txt_precio_max.Clear()
        txt_precio_min.Clear()
        Frm_ventas_productos_busqueda.Show()
    End Sub

    Private Sub cmb_codigo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codigo.TextChanged
        txt_stock.Text = nue_report.descripcion_stock(cmb_codigo.Text)
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
        Else
            If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Else
                txt_precio_lista.Text = CDbl(txt_venta_m2.Text) * CDbl(txt_area_calculada.Text)
                txt_monto.Text = Math.Round(CDbl(txt_precio_lista.Text) * CDbl(txt_cantidad.Text))
                txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
                txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
                txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
                'txt_venta_m2.Text = Format(CDbl(txt_venta_m2.Text), "###,##0.")
            End If
        End If
        If cmb_codigo.Text <> "" Then
            actualizar_sustitutos()
            actualizar_complementarios()
        Else

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar_producto.Click
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()
        Frm_ventas_productos_busqueda.Show()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txt_fecha_act.Text = Today
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub txt_precio_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_precio_cliente.TextChanged
        If (Not IsNumeric(Me.txt_precio_cliente.Text)) Then
            Me.txt_precio_cliente.Text = 0
        End If
        txt_precio_cliente.Text = Format(CDbl(txt_precio_cliente.Text), "###,##0.")
    End Sub

    Private Sub txt_precio_lista_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_precio_lista.TextChanged
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        txt_precio_lista.Text = Format(CDbl(txt_precio_lista.Text), "###,##0.")
    End Sub

    Private Sub txt_venta_m2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_venta_m2.TextChanged
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
        Else
            If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Else
                txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
                'txt_descuento.Text = -((CDbl(txt_ult_venta.Text) - CDbl(txt_venta_m2.Text)) / CDbl(txt_ult_venta.Text))
                txt_precio_cliente.Text = CDbl(txt_venta_m2.Text) * CDbl(txt_area_calculada.Text)
                txt_precio_lista.Text = CDbl(txt_ult_venta.Text) * CDbl(txt_area_calculada.Text)
                txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
                txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
                txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
                ' txt_venta_m2.Text = Format(CDbl(txt_venta_m2.Text), "##,##.")
            End If
        End If
    End Sub

    Private Sub txt_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_monto.TextChanged
        If (Not IsNumeric(Me.txt_monto.Text)) Then
            Me.txt_monto.Text = 0
        End If
        txt_monto.Text = Format(CDbl(txt_monto.Text), "###,##0.")
    End Sub

    Private Sub txt_iva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_iva.TextChanged
        If (Not IsNumeric(Me.txt_iva.Text)) Then
            Me.txt_iva.Text = 0
        End If
        txt_iva.Text = Format(CDbl(txt_iva.Text), "###,##0.")
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        If (Not IsNumeric(Me.txt_total.Text)) Then
            Me.txt_total.Text = 0
        End If
        txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
    End Sub

    Private Sub txt_cantidad_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cantidad.TextChanged
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
        Else
            If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Else
                txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
                'txt_descuento.Text = -((CDbl(txt_ult_venta.Text) - CDbl(txt_venta_m2.Text)) / CDbl(txt_ult_venta.Text))
                txt_precio_cliente.Text = CDbl(txt_venta_m2.Text) * CDbl(txt_area_calculada.Text)
                txt_precio_lista.Text = CDbl(txt_ult_venta.Text) * CDbl(txt_area_calculada.Text)
                txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
                txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
                txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
                txt_venta_m2.Text = Format(CDbl(txt_venta_m2.Text), "###,###,##0.")
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmb_cliente.Clear()
        txt_rut.Clear()
        txt_direccion_despacho.Clear()
        txt_comuna.Clear()
        txt_senal_advertencia.Clear()
        txt_linea_credito.Clear()
        txt_nombre_comercial.Clear()
        txt_email_comercial.Clear()
        txt_telefonos_comercial.Clear()
        txt_cargo_comercial.Clear()
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_numero_pedido.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()

        Frm_ventas_clientes_busqueda.Show()
        bloquear()
        dgv_sustitutos.DataSource = Nothing
        dgv_Mov_Tierra.DataSource = Nothing
        dgv_complementarios.DataSource = Nothing
    End Sub

    Private Sub cmb_cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_cliente.Click

    End Sub

    Private Sub cmb_cliente_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_cliente.MouseClick
        txt_ult_venta.Clear()
        txt_descuento.Clear()
        txt_venta_m2.Clear()
        cmb_cliente.Clear()
        txt_rut.Clear()
        txt_direccion_despacho.Clear()
        txt_comuna.Clear()
        txt_senal_advertencia.Clear()
        txt_linea_credito.Clear()
        txt_nombre_comercial.Clear()
        txt_email_comercial.Clear()
        txt_telefonos_comercial.Clear()
        txt_cargo_comercial.Clear()
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_numero_pedido.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()

        Frm_ventas_clientes_busqueda.Show()
        bloquear()
        dgv_sustitutos.DataSource = Nothing
        dgv_Mov_Tierra.DataSource = Nothing
        dgv_complementarios.DataSource = Nothing
    End Sub

    Private Sub cmb_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cliente.TextChanged
        txt_folio.Text = 1
        desbloquear()
        limpiar()
        sw = 0
        txt_folio.Visible = False
        lbl_folio.Visible = False
        If (cmb_cliente.Text = "") Then
            dgv_Mov_Tierra.DataSource = Nothing
        Else
            actualizar_dgv()
            actualizar_dgv_venta()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Sub actualizar_dgv_venta()
        dgv_venta.DataSource = nue_report.listar10(txt_folio.Text)
        dgv_venta.Columns(0).Visible = False
        dgv_venta.AllowUserToOrderColumns = True
        dgv_venta.Columns(1).Visible = False
        dgv_venta.Columns(2).Visible = False
        dgv_venta.Columns(3).Visible = False
        dgv_venta.Columns(4).Visible = False
        dgv_venta.Columns(5).Visible = False
        dgv_venta.Columns(6).Visible = False
        dgv_venta.Columns(7).Visible = False
        dgv_venta.Columns(8).Visible = False
        dgv_venta.Columns(9).Visible = False
        dgv_venta.Columns(10).HeaderText = "Medidas"
        dgv_venta.Columns(11).Visible = False
        dgv_venta.Columns(12).Visible = False
        dgv_venta.Columns(13).HeaderText = "Descripción"
        dgv_venta.Columns(13).Width = 210
        dgv_venta.Columns(14).HeaderText = "Área Un."
        dgv_venta.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_venta.Columns(15).HeaderText = "Cantidad"
        dgv_venta.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(16).Visible = False
        dgv_venta.Columns(17).Visible = False
        dgv_venta.Columns(18).HeaderText = "Precio M2"
        dgv_venta.Columns(18).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(19).HeaderText = "Venta"
        dgv_venta.Columns(19).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(20).HeaderText = "IVA"
        dgv_venta.Columns(20).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(21).HeaderText = "Total"
        dgv_venta.Columns(21).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(22).Visible = False
        dgv_venta.Columns(23).Visible = False
        dgv_venta.Columns(24).Visible = False
        dgv_venta.Columns(25).Visible = False
        dgv_venta.Columns(26).Visible = False
        dgv_venta.Columns(27).Visible = False
        dgv_venta.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(28).HeaderText = "Precio Un."
        dgv_venta.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(29).HeaderText = "Fecha"
        dgv_venta.Columns(30).Visible = False
        dgv_venta.Columns(31).Visible = False
        dgv_venta.Columns(32).Visible = False
        dgv_venta.Columns(33).Visible = False
        dgv_venta.Columns(34).Visible = False
        dgv_venta.Columns(29).DisplayIndex = 1
        dgv_venta.Columns(13).DisplayIndex = 2
        dgv_venta.Columns(10).DisplayIndex = 3
        dgv_venta.Columns(15).DisplayIndex = 4
        dgv_venta.Columns(18).DisplayIndex = 5
        dgv_venta.Columns(14).DisplayIndex = 6
        dgv_venta.Columns(28).DisplayIndex = 7
        dgv_venta.Columns(19).DisplayIndex = 8
        dgv_venta.Columns(20).DisplayIndex = 9
        dgv_venta.Columns(21).DisplayIndex = 10
        dgv_venta.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(30).Width = 50
        dgv_venta.Columns(10).Width = 60
        dgv_venta.Columns(15).Width = 50
        dgv_venta.Columns(28).Width = 50
        dgv_venta.Columns(29).Width = 70
        dgv_venta.Columns(18).Width = 50
        dgv_venta.Columns(19).Width = 60
        dgv_venta.Columns(20).Width = 60
        dgv_venta.Columns(21).Width = 60
        dgv_venta.Columns(14).Width = 40
        dgv_venta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub txt_consulta_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_consulta_monto.TextChanged
        If (Not IsNumeric(Me.txt_consulta_monto.Text)) Then
            Me.txt_consulta_monto.Text = 0
        End If
        txt_consulta_monto.Text = Format(CDbl(txt_consulta_monto.Text), "###,##0.")
    End Sub

    Private Sub txt_consulta_iva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_consulta_iva.TextChanged
        If (Not IsNumeric(Me.txt_consulta_iva.Text)) Then
            Me.txt_consulta_iva.Text = 0
        End If
        txt_consulta_iva.Text = Format(CDbl(txt_consulta_iva.Text), "###,##0.")
    End Sub

    Private Sub txt_consulta_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_consulta_total.TextChanged
        If (Not IsNumeric(Me.txt_consulta_total.Text)) Then
            Me.txt_consulta_total.Text = 0
        End If
        txt_consulta_total.Text = Format(CDbl(txt_consulta_total.Text), "###,##0.")
    End Sub

    Private Sub dgv_venta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_venta.CellContentClick

    End Sub

    Private Sub dgv_venta_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_venta.CellDoubleClick
        Cod_Mov_Tierra = dgv_venta.CurrentRow.Cells(0).Value.ToString()
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()
        txt_precio_min.Clear()
        txt_precio_max.Clear()
        txt_area_negocio.Text = dgv_venta.CurrentRow.Cells(3).Value.ToString()
        txt_familia1.Text = dgv_venta.CurrentRow.Cells(6).Value.ToString()
        txt_familia2.Text = dgv_venta.CurrentRow.Cells(7).Value.ToString()
        txt_familia3.Text = dgv_venta.CurrentRow.Cells(8).Value.ToString()
        txt_medidas.Text = dgv_venta.CurrentRow.Cells(10).Value.ToString()
        cmb_codigo.Text = dgv_venta.CurrentRow.Cells(11).Value.ToString()
        txt_proveedor.Text = dgv_venta.CurrentRow.Cells(12).Value.ToString()
        txt_descripcion.Text = dgv_venta.CurrentRow.Cells(13).Value.ToString()
        txt_area_calculada.Text = dgv_venta.CurrentRow.Cells(14).Value.ToString()
        txt_cantidad.Text = dgv_venta.CurrentRow.Cells(15).Value.ToString()
        txt_area_calc.Text = dgv_venta.CurrentRow.Cells(16).Value.ToString()
        txt_monto.Text = dgv_venta.CurrentRow.Cells(19).Value.ToString()
        txt_iva.Text = dgv_venta.CurrentRow.Cells(20).Value.ToString()
        txt_total.Text = dgv_venta.CurrentRow.Cells(21).Value.ToString()
        txt_observaciones.Text = dgv_venta.CurrentRow.Cells(26).Value.ToString()
        txt_precio_lista.Text = dgv_venta.CurrentRow.Cells(27).Value.ToString()
        txt_precio_cliente.Text = dgv_venta.CurrentRow.Cells(28).Value.ToString()
        txt_ult_venta.Text = txt_precio_lista.Text / txt_area_calculada.Text
        txt_venta_m2.Text = dgv_venta.CurrentRow.Cells(18).Value.ToString()
        txt_precio_min.Text = nue_report.precio_min(cmb_codigo.Text)
        txt_precio_max.Text = nue_report.precio_max(cmb_codigo.Text)
    End Sub

    Private Sub dgv_venta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_venta.DoubleClick
        Cod_Mov_Tierra = dgv_venta.CurrentRow.Cells(0).Value.ToString()
        cmb_codigo.Clear()
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()
        txt_area_negocio.Text = dgv_venta.CurrentRow.Cells(3).Value.ToString()
        txt_familia1.Text = dgv_venta.CurrentRow.Cells(6).Value.ToString()
        txt_familia2.Text = dgv_venta.CurrentRow.Cells(7).Value.ToString()
        txt_familia3.Text = dgv_venta.CurrentRow.Cells(8).Value.ToString()
        txt_medidas.Text = dgv_venta.CurrentRow.Cells(10).Value.ToString()
        cmb_codigo.Text = dgv_venta.CurrentRow.Cells(11).Value.ToString()
        txt_proveedor.Text = dgv_venta.CurrentRow.Cells(12).Value.ToString()
        txt_descripcion.Text = dgv_venta.CurrentRow.Cells(13).Value.ToString()
        txt_area_calculada.Text = dgv_venta.CurrentRow.Cells(14).Value.ToString()
        txt_cantidad.Text = dgv_venta.CurrentRow.Cells(15).Value.ToString()
        txt_area_calc.Text = dgv_venta.CurrentRow.Cells(16).Value.ToString()
        txt_monto.Text = dgv_venta.CurrentRow.Cells(19).Value.ToString()
        txt_iva.Text = dgv_venta.CurrentRow.Cells(20).Value.ToString()
        txt_total.Text = dgv_venta.CurrentRow.Cells(21).Value.ToString()
        txt_observaciones.Text = dgv_venta.CurrentRow.Cells(26).Value.ToString()
        txt_precio_lista.Text = dgv_venta.CurrentRow.Cells(27).Value.ToString()
        txt_precio_cliente.Text = dgv_venta.CurrentRow.Cells(28).Value.ToString()
        txt_ult_venta.Text = txt_precio_lista.Text / txt_area_calculada.Text
        txt_venta_m2.Text = dgv_venta.CurrentRow.Cells(18).Value.ToString()
    End Sub

    Sub actualizar_dgv_venta2()
        dgv_venta.DataSource = nue_report.listar10(txt_folio.Text)
        dgv_venta.Columns(0).Visible = False
        dgv_venta.AllowUserToOrderColumns = True
        dgv_venta.Columns(1).Visible = False
        dgv_venta.Columns(2).Visible = False
        dgv_venta.Columns(3).Visible = False
        dgv_venta.Columns(4).Visible = False
        dgv_venta.Columns(5).Visible = False
        dgv_venta.Columns(6).Visible = False
        dgv_venta.Columns(7).Visible = False
        dgv_venta.Columns(8).Visible = False
        dgv_venta.Columns(9).Visible = False
        dgv_venta.Columns(10).HeaderText = "Medidas"
        dgv_venta.Columns(11).Visible = False
        dgv_venta.Columns(12).Visible = False
        dgv_venta.Columns(13).HeaderText = "Descripción"
        dgv_venta.Columns(13).Width = 210
        dgv_venta.Columns(14).HeaderText = "Área Un."
        dgv_venta.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_venta.Columns(15).HeaderText = "Cantidad"
        dgv_venta.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(16).Visible = False
        dgv_venta.Columns(17).Visible = False
        dgv_venta.Columns(18).HeaderText = "Precio M2"
        dgv_venta.Columns(18).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(19).HeaderText = "Venta"
        dgv_venta.Columns(19).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(20).HeaderText = "IVA"
        dgv_venta.Columns(20).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(21).HeaderText = "Total"
        dgv_venta.Columns(21).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(22).Visible = False
        dgv_venta.Columns(23).Visible = False
        dgv_venta.Columns(24).Visible = False
        dgv_venta.Columns(25).Visible = False
        dgv_venta.Columns(26).Visible = False
        dgv_venta.Columns(27).Visible = False
        dgv_venta.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(28).HeaderText = "Precio Un."
        dgv_venta.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_venta.Columns(29).HeaderText = "Fecha"
        dgv_venta.Columns(30).Visible = False
        dgv_venta.Columns(31).Visible = False
        dgv_venta.Columns(32).Visible = False
        dgv_venta.Columns(33).Visible = False
        dgv_venta.Columns(29).DisplayIndex = 1
        dgv_venta.Columns(13).DisplayIndex = 2
        dgv_venta.Columns(10).DisplayIndex = 3
        dgv_venta.Columns(15).DisplayIndex = 4
        dgv_venta.Columns(18).DisplayIndex = 5
        dgv_venta.Columns(14).DisplayIndex = 6
        dgv_venta.Columns(28).DisplayIndex = 7
        dgv_venta.Columns(19).DisplayIndex = 8
        dgv_venta.Columns(20).DisplayIndex = 9
        dgv_venta.Columns(21).DisplayIndex = 10
        dgv_venta.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_venta.Columns(30).Width = 50
        dgv_venta.Columns(10).Width = 60
        dgv_venta.Columns(15).Width = 50
        dgv_venta.Columns(28).Width = 50
        dgv_venta.Columns(29).Width = 70
        dgv_venta.Columns(18).Width = 50
        dgv_venta.Columns(19).Width = 60
        dgv_venta.Columns(20).Width = 60
        dgv_venta.Columns(21).Width = 60
        dgv_venta.Columns(14).Width = 40
        dgv_venta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub cmb_numero_pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_numero_pedido.SelectedIndexChanged

    End Sub

    Private Sub cmb_numero_pedido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_numero_pedido.TextChanged
        actualizar_dgv_venta2()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        frm_ofertas_dia.Close()
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        frm_ofertas_dia.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        frm_facturas.Close()
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        frm_facturas.Show()
    End Sub


    Private Sub dgv_sustitutos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_sustitutos.CellClick
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()

        txt_area_negocio.Text = dgv_sustitutos.CurrentRow.Cells(13).Value.ToString()
        txt_familia1.Text = dgv_sustitutos.CurrentRow.Cells(18).Value.ToString()
        txt_familia2.Text = dgv_sustitutos.CurrentRow.Cells(19).Value.ToString()
        txt_familia3.Text = dgv_sustitutos.CurrentRow.Cells(20).Value.ToString()
        txt_medidas.Text = dgv_sustitutos.CurrentRow.Cells(7).Value.ToString()
        txt_proveedor.Text = dgv_sustitutos.CurrentRow.Cells(14).Value.ToString()
        txt_descripcion.Text = dgv_sustitutos.CurrentRow.Cells(5).Value.ToString()
        txt_area_calculada.Text = dgv_sustitutos.CurrentRow.Cells(11).Value.ToString()
        cmb_codigo.Text = dgv_sustitutos.CurrentRow.Cells(3).Value.ToString()
    End Sub


    Private Sub dgv_complementarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_complementarios.CellClick
        txt_descripcion.Clear()
        txt_proveedor.Clear()
        txt_area_calculada.Clear()
        txt_area_negocio.Clear()
        txt_medidas.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_stock.Clear()
        txt_venta_m2.Clear()
        txt_cantidad.Text = ""
        txt_area_calc.Clear()
        txt_precio_lista.Clear()
        txt_monto.Clear()
        txt_total.Clear()
        txt_precio_cliente.Clear()
        txt_iva.Clear()

        txt_area_negocio.Text = dgv_complementarios.CurrentRow.Cells(12).Value.ToString()
        txt_familia1.Text = dgv_complementarios.CurrentRow.Cells(17).Value.ToString()
        txt_familia2.Text = dgv_complementarios.CurrentRow.Cells(18).Value.ToString()
        txt_familia3.Text = dgv_complementarios.CurrentRow.Cells(19).Value.ToString()
        txt_medidas.Text = dgv_complementarios.CurrentRow.Cells(6).Value.ToString()
        txt_proveedor.Text = dgv_complementarios.CurrentRow.Cells(13).Value.ToString()
        txt_descripcion.Text = dgv_complementarios.CurrentRow.Cells(4).Value.ToString()
        txt_area_calculada.Text = dgv_complementarios.CurrentRow.Cells(10).Value.ToString()
        cmb_codigo.Text = dgv_complementarios.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub dgv_sustitutos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_sustitutos.CellContentClick

    End Sub

    Private Sub dgv_sustitutos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_sustitutos.CellDoubleClick

    End Sub

    Private Sub dgv_Mov_Tierra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Mov_Tierra.CellContentClick

    End Sub

    Private Sub dgv_complementarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_complementarios.CellContentClick

    End Sub

    Private Sub txt_descuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_descuento.TextChanged
        txt_descuento.Text = Format(txt_descuento.Text, "percent")
    End Sub

    Private Sub txt_ult_venta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ult_venta.TextChanged
        If txt_ult_venta.Text <> "" Then
            txt_ult_venta.Text = Format(CDbl(txt_ult_venta.Text), "###,###,##0.")
        Else
        End If
    End Sub

    Private Sub txt_cantidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cantidad.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_folio.Text = 1 Then
            MessageBox.Show("INGRESE DATOS DE PEDIDO")
        Else

            MessageBox.Show("NOTA DE PEDIDO GENERADA")
            CR_guia_de_despacho.Show()
            limpiar()
            dgv_sustitutos.DataSource = Nothing
            dgv_venta.DataSource = Nothing
            dgv_complementarios.DataSource = Nothing
            actualizar_dgv()
            txt_consulta_monto.Text = 0
            txt_consulta_iva.Text = 0
            txt_consulta_total.Text = 0
            txt_folio.Text = 1
        End If

    End Sub
End Class