Imports System.Globalization
Public Class Frm_ventas

    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub bloquear()
        gbx_Mov_Tierra.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
        txt_rut.Enabled = False
        txt_area_negocio.Enabled = False
        txt_senal_advertencia.Enabled = False
        txt_comuna.Enabled = False
        txt_familia1.Enabled = False
        txt_familia2.Enabled = False
        txt_familia3.Enabled = False
        txt_cantidad.Enabled = False
        txt_observaciones.Enabled = False
        txt_descripcion.Enabled = False
        txt_proveedor.Enabled = False
        txt_area_calculada.Enabled = False
        txt_precio_lista.Enabled = False
        txt_precio_cliente.Enabled = False
        txt_monto.Enabled = False
        txt_iva.Enabled = False
        txt_total.Enabled = False
        txt_direccion_despacho.Enabled = False
        txt_area_calc.Enabled = False
        cmb_cliente.Enabled = False
        txt_numero_pedido.Enabled = False
        txt_precio_cliente.Enabled = False
        txt_precio_lista.Enabled = False
        txt_monto.Enabled = False
        txt_iva.Enabled = False
        txt_total.Enabled = False
        txt_stock.Enabled = False
        cmb_codigo.Enabled = False
        txt_fecha_act.Enabled = False
        txt_hora.Enabled = False
        txt_tipo1.Enabled = False
        txt_medidas.Enabled = False
        txt_venta_m2.Enabled = False
    End Sub

    Sub desbloquear()
        gbx_Mov_Tierra.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
        txt_observaciones.Enabled = True
        txt_cantidad.Enabled = True
    End Sub
    Sub limpiar()
        txt_cantidad.Text = 0
        txt_observaciones.Clear()
        txt_descuento.Text = 0
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
        dgv_Mov_Tierra.Columns(11).HeaderText = "Código Producto"
        dgv_Mov_Tierra.Columns(12).Visible = False
        dgv_Mov_Tierra.Columns(13).HeaderText = "Descripción"
        dgv_Mov_Tierra.Columns(13).Width = 200
        dgv_Mov_Tierra.Columns(14).Visible = False
        dgv_Mov_Tierra.Columns(15).HeaderText = "Cantidad"
        dgv_Mov_Tierra.Columns(16).Visible = False
        dgv_Mov_Tierra.Columns(17).Visible = False
        dgv_Mov_Tierra.Columns(18).Visible = False
        dgv_Mov_Tierra.Columns(19).HeaderText = "Venta Neta"
        dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(20).Visible = False
        dgv_Mov_Tierra.Columns(21).Visible = False
        dgv_Mov_Tierra.Columns(22).Visible = False
        dgv_Mov_Tierra.Columns(23).Visible = False
        dgv_Mov_Tierra.Columns(24).Visible = False
        dgv_Mov_Tierra.Columns(25).HeaderText = "Ejecutivo"
        dgv_Mov_Tierra.Columns(26).Visible = False
        dgv_Mov_Tierra.Columns(27).HeaderText = "Precio Lista"
        dgv_Mov_Tierra.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(28).HeaderText = "Precio Cliente"
        dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(29).HeaderText = "Fecha Venta"
        dgv_Mov_Tierra.Columns(30).HeaderText = "Número Pedido"
        dgv_Mov_Tierra.Columns(31).HeaderText = "Fecha Pedido"
        dgv_Mov_Tierra.Columns(32).HeaderText = "Hora Pedido"
        dgv_Mov_Tierra.Columns(33).HeaderText = "Descuento (%)"
        dgv_Mov_Tierra.Columns(29).DisplayIndex = 1
        dgv_Mov_Tierra.Columns(30).DisplayIndex = 2
        dgv_Mov_Tierra.Columns(11).DisplayIndex = 3
        dgv_Mov_Tierra.Columns(13).DisplayIndex = 4
        dgv_Mov_Tierra.Columns(10).DisplayIndex = 5
        dgv_Mov_Tierra.Columns(27).DisplayIndex = 6
        dgv_Mov_Tierra.Columns(33).DisplayIndex = 7
        dgv_Mov_Tierra.Columns(28).DisplayIndex = 8
        dgv_Mov_Tierra.Columns(15).DisplayIndex = 9
        dgv_Mov_Tierra.Columns(19).DisplayIndex = 10
        dgv_Mov_Tierra.Columns(25).DisplayIndex = 11
        dgv_Mov_Tierra.Columns(31).DisplayIndex = 12
        dgv_Mov_Tierra.Columns(32).DisplayIndex = 13
    End Sub
    Sub actualizar_sustitutos()
        dgv_sustitutos.DataSource = nue_report.listar4(cmb_codigo.Text)
        dgv_sustitutos.Columns(0).Visible = False
        dgv_sustitutos.Columns(1).HeaderText = "Código Producto Sustituto8"
        dgv_sustitutos.AllowUserToOrderColumns = True
        dgv_sustitutos.Columns(2).Width = 300
        dgv_sustitutos.Columns(2).HeaderText = "Descripción Producto Sustituto"
        dgv_sustitutos.Columns(3).HeaderText = "Stock"
        dgv_sustitutos.Columns(4).HeaderText = "Precio Cliente"

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
        txt_nombre_ejecutivo.Enabled = False
        txt_numero_pedido.Text = nue_report.descripcion_numero_pedido(cliente) + 1
        txt_cantidad.Text = 0
        Button2.Enabled = True
        txt_descuento.Text = 0
        actualizar_dgv()
        Timer1.Enabled = True
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, condicion, forma_pago, ejecutivo, observaciones, toma_pedido As String
        Dim area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, dias_pago, precio_lista, precio_cliente, pedido, descuento, folio As Double


        If (cmb_cliente.Text <> "" And cmb_codigo.Text <> "" And txt_cantidad.Text <> 0 And txt_nombre_ejecutivo.Text <> "") Then

            cliente = cmb_cliente.Text
            rut = txt_rut.Text
            area_negocio = txt_area_negocio.Text
            senal_advertencia = txt_senal_advertencia.Text
            comuna = txt_comuna.Text
            familia_1 = txt_familia1.Text
            familia_2 = txt_familia2.Text
            familia_3 = txt_familia3.Text
            tipo_1 = txt_tipo1.Text
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
            pedido = txt_numero_pedido.Text
            descuento = Convert.ToDouble(txt_descuento.Text)

            If sw = 0 Then
                nue_report.insertar(cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio, toma_pedido, 0, 0, 0)
                nue_report.insertar2(pedido, cliente)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Mov_Tierra), cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()

        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_estudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Mov_Tierra.CellDoubleClick
        If dgv_Mov_Tierra.CurrentRow.Cells(25).Value.ToString() <> txt_nombre_ejecutivo.Text Then
            MsgBox("No se puede modificar venta de otro ejecutivo")
        Else
            Cod_Mov_Tierra = dgv_Mov_Tierra.CurrentRow.Cells(0).Value.ToString()
            cmb_cliente.Text = dgv_Mov_Tierra.CurrentRow.Cells(1).Value.ToString()
            txt_rut.Text = dgv_Mov_Tierra.CurrentRow.Cells(2).Value.ToString()
            txt_area_negocio.Text = dgv_Mov_Tierra.CurrentRow.Cells(3).Value.ToString()
            txt_senal_advertencia.Text = dgv_Mov_Tierra.CurrentRow.Cells(4).Value.ToString()
            txt_comuna.Text = dgv_Mov_Tierra.CurrentRow.Cells(5).Value.ToString()
            txt_familia1.Text = dgv_Mov_Tierra.CurrentRow.Cells(6).Value.ToString()
            txt_familia2.Text = dgv_Mov_Tierra.CurrentRow.Cells(7).Value.ToString()
            txt_familia3.Text = dgv_Mov_Tierra.CurrentRow.Cells(8).Value.ToString()
            txt_tipo1.Text = dgv_Mov_Tierra.CurrentRow.Cells(9).Value.ToString()
            txt_medidas.Text = dgv_Mov_Tierra.CurrentRow.Cells(10).Value.ToString()
            cmb_codigo.Text = dgv_Mov_Tierra.CurrentRow.Cells(11).Value.ToString()
            txt_proveedor.Text = dgv_Mov_Tierra.CurrentRow.Cells(12).Value.ToString()
            txt_descripcion.Text = dgv_Mov_Tierra.CurrentRow.Cells(13).Value.ToString()
            txt_area_calculada.Text = dgv_Mov_Tierra.CurrentRow.Cells(14).Value.ToString()
            txt_cantidad.Text = dgv_Mov_Tierra.CurrentRow.Cells(15).Value.ToString()
            txt_area_calc.Text = dgv_Mov_Tierra.CurrentRow.Cells(16).Value.ToString()
            txt_venta_m2.Text = dgv_Mov_Tierra.CurrentRow.Cells(18).Value.ToString()
            txt_monto.Text = dgv_Mov_Tierra.CurrentRow.Cells(19).Value.ToString()
            txt_iva.Text = dgv_Mov_Tierra.CurrentRow.Cells(20).Value.ToString()
            txt_total.Text = dgv_Mov_Tierra.CurrentRow.Cells(21).Value.ToString()
            txt_observaciones.Text = dgv_Mov_Tierra.CurrentRow.Cells(26).Value.ToString()
            txt_precio_lista.Text = dgv_Mov_Tierra.CurrentRow.Cells(27).Value.ToString()
            txt_precio_cliente.Text = dgv_Mov_Tierra.CurrentRow.Cells(28).Value.ToString()
            txt_fecha.Text = dgv_Mov_Tierra.CurrentRow.Cells(29).Value.ToString()
            txt_numero_pedido.Text = dgv_Mov_Tierra.CurrentRow.Cells(30).Value.ToString()
            txt_descuento.Text = dgv_Mov_Tierra.CurrentRow.Cells(33).Value.ToString()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Mov_Tierra))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub


    Private Sub txt_cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
            Me.txt_venta_m2.Text = 0
        End If

        txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
        txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
        txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
        txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
        txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
        If (Me.txt_area_calculada.Text = 0) Then
            txt_venta_m2.Text = 0
        Else
            txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
        End If

    End Sub

    Private Sub cmb_codigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CR_detalle_venta.Show()
    End Sub
    Sub actualizar_complementarios()
        dgv_complementarios.DataSource = nue_report.listar5(cmb_codigo.Text)
        dgv_complementarios.Columns(0).Visible = False
        dgv_complementarios.Columns(1).HeaderText = "Código Producto Complementario "
        dgv_complementarios.AllowUserToOrderColumns = True
        dgv_complementarios.Columns(2).Width = 300
        dgv_complementarios.Columns(2).HeaderText = "Descripción Producto Complementario"
        dgv_complementarios.Columns(3).HeaderText = "Stock"
        dgv_complementarios.Columns(4).HeaderText = "Precio Cliente"

    End Sub

    Private Sub cmb_codigo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codigo.TextChanged
        'txt_descripcion.Text = nue_report.descripcion_descripcion(cmb_codigo.Text)
        'txt_proveedor.Text = nue_report.descripcion_proveedor(cmb_codigo.Text)
        'txt_area_calculada.Text = nue_report.descripcion_area(cmb_codigo.Text)
        'txt_area_negocio.Text = nue_report.descripcion_area_negocio(cmb_codigo.Text)
        'txt_familia1.Text = nue_report.descripcion_familia(cmb_codigo.Text)
        ' txt_familia2.Text = nue_report.descripcion_familia_2(cmb_codigo.Text)
        'txt_familia3.Text = nue_report.descripcion_familia_3(cmb_codigo.Text)
        txt_stock.Text = nue_report.descripcion_stock(cmb_codigo.Text)
        ' txt_precio_lista.Text = nue_report.descripcion_precio(cmb_codigo.Text)
        ' txt_precio_cliente.Text = txt_precio_lista.Text
        txt_descuento.Text = 0
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
            Me.txt_venta_m2.Text = 0
        End If
        txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
        txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
        txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
        txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
        txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
        If (Me.txt_area_calculada.Text = 0) Then
            txt_venta_m2.Text = 0
        Else
            txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
        End If
        actualizar_sustitutos()
        actualizar_complementarios()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_ventas_productos_busqueda.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If

        If (txt_descuento.Text > 5 Or txt_descuento.Text < 0) Then
            Me.txt_descuento.Text = 0
            MessageBox.Show("DESCUENTO MÁXIMO DE UN 5%")
            txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
            txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
            txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
            txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
            txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
            If (Me.txt_area_calculada.Text = 0) Then
                txt_venta_m2.Text = 0
            Else
                txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
            End If
        Else
            txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
            txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
            txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
            txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
            txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
            txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
            If (Me.txt_area_calculada.Text = 0) Then
                txt_venta_m2.Text = 0
            Else
                txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
            End If
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        txt_descuento.Text = Format(CDbl(txt_descuento.Text), "###,##0.00")
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
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
            Me.txt_venta_m2.Text = 0
        End If
        txt_venta_m2.Text = Format(CDbl(txt_venta_m2.Text), "###,##0.")

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

    Private Sub txt_descuento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_descuento.SelectedIndexChanged

    End Sub

    Private Sub txt_descuento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_descuento.TextChanged
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If

        If (txt_descuento.Text > 5 Or txt_descuento.Text < 0) Then
            Me.txt_descuento.Text = 0
            MessageBox.Show("DESCUENTO MÁXIMO DE UN 5%")
            txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
            txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
            txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
            txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
            txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
            If (Me.txt_area_calculada.Text = 0) Then
                txt_venta_m2.Text = 0
            Else
                txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
            End If
        Else
            txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
            txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
            txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
            txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
            txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
            txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
            If (Me.txt_area_calculada.Text = 0) Then
                txt_venta_m2.Text = 0
            Else
                txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
            End If
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        txt_descuento.Text = Format(CDbl(txt_descuento.Text), "###,##0.00")
    End Sub

    Private Sub txt_cantidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cantidad.SelectedIndexChanged

    End Sub

    Private Sub txt_cantidad_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cantidad.TextChanged
        If (Not IsNumeric(Me.txt_precio_lista.Text)) Then
            Me.txt_precio_lista.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_area_calculada.Text)) Then
            Me.txt_area_calculada.Text = 0
        End If
        If (Not IsNumeric(Me.txt_venta_m2.Text)) Then
            Me.txt_venta_m2.Text = 0
        End If

        txt_precio_cliente.Text = CDbl(txt_precio_lista.Text) * (1 - CDbl(txt_descuento.Text) / 100)
        txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
        txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
        txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
        txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
        If (Me.txt_area_calculada.Text = 0) Then
            txt_venta_m2.Text = 0
        Else
            txt_venta_m2.Text = CDbl(txt_precio_cliente.Text) / CDbl(txt_area_calculada.Text)
        End If
    End Sub
End Class