Imports System.Globalization
Public Class Frm_ventas_mod

    Dim nue_report As New clases.ventas
    Dim nueva_notaCredito As New clases.Nota_credito
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double
    Dim pendiente As Double
    Dim suma_total As Double

    Sub bloquear()
        txt_condicion.ReadOnly = True
        btn_guardar.Enabled = False
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
        txt_linea_credito.ReadOnly = True
        gbx_Mov_Tierra.Visible = False
        txt_consulta_iva.ReadOnly = True
        txt_consulta_monto.ReadOnly = True
        txt_consulta_total.ReadOnly = True
        txt_ult_venta.ReadOnly = True
        txt_descuento.ReadOnly = True
        txt_precio_max.ReadOnly = True
        txt_precio_min.ReadOnly = True
        txt_ejecutivo.ReadOnly = True
        txt_ancho.ReadOnly = True
        txt_largo.ReadOnly = True
        forma_de_pago.ReadOnly = True
        cmb_pedidos_ant.Visible = False
    End Sub

    Sub desbloquear()
        gbx_Mov_Tierra.Enabled = True
        btn_guardar.Enabled = True
        txt_observaciones.Enabled = True
        txt_cantidad.Enabled = True
        btn_buscar_producto.Visible = False
        gbx_Mov_Tierra.Visible = True
        txt_venta_m2.Enabled = True
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
        txt_ancho.Clear()
        txt_largo.Clear()
        txt_tipo1.Clear()
    End Sub

    Sub borrar_grid()
        dgv_sustitutos.DataSource = Nothing
        dgv_venta.DataSource = Nothing
        dgv_complementarios.DataSource = Nothing
    End Sub
    Sub actualizar_dgv()
        dgv_Mov_Tierra.DataSource = nue_report.listar(txt_rut.Text)
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
        dgv_Mov_Tierra.Columns(35).Visible = False
        dgv_Mov_Tierra.Columns(36).Visible = False

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
        folio_condicion = 0
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
        txt_tipo.Enabled = False
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Public Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, dias_pago, codigo_producto, proveedor, descripcion, condicion, forma_pago, ejecutivo, observaciones, toma_pedido, fecha, solicitado As String
        Dim area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, precio_lista, precio_cliente, pedido, descuento, folio, ancho, largo As Double
        Dim fecha_suma As Date
        Dim precio_minimo, precio_maximo, precio As Double

        cerrar_nota = 0
        If txt_cantidad.Text > pendiente And documento = 1 And tipo_guia = 5 Then
            MsgBox("LA CANTIDAD EXCEDE LO SOLICITADO EN LA FACTURA")
        Else


            If folio_condicion = 0 And documento = 0 Then
                actualizar_folio()
                txt_folio.Text = CDbl(dgv_folio.Rows(0).Cells(1).Value.ToString()) + 1
                nue_report.insertar3(CDbl(txt_folio.Text), "0", cmb_cliente.Text)
                txt_folio.Visible = True
                folio_condicion = 1
            ElseIf folio_condicion = 0 And documento = 1 Then
                actualizar_folio()
                txt_folio.Text = CDbl(dgv_folio.Rows(0).Cells(1).Value.ToString()) + 1
                nue_report.insertar9(CDbl(txt_folio.Text), "0", cmb_cliente.Text, 0)
                txt_folio.Visible = True
                folio_condicion = 1
            End If


            'MsgBox("Precio minimo" + txt_precio_min.Text)
            'MsgBox("Precio máximo" + txt_precio_max.Text)
            'MsgBox("Precio" + txt_venta_m2.Text)

            Try
                precio_minimo = Convert.ToDouble(txt_precio_min.Text)
            Catch
                precio_minimo = 0
            End Try

            Try
                precio_maximo = Convert.ToDouble(txt_precio_max.Text)
            Catch
                precio_maximo = 0
            End Try

            precio = Convert.ToDouble(txt_venta_m2.Text)

            'MsgBox(precio_minimo)
            'MsgBox(precio_maximo)
            'MsgBox(precio)

            If IsNumeric(precio_maximo) Then

                If precio_maximo > 0 And precio > precio_maximo Then

                    If MessageBox.Show("¿Está seguro que desea vender a un precio mayor al máximo?", "Confirmación de procedimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                        Exit Sub
                    Else
                        nue_report.insertar_alerta_precio(Nombre_Obra, txt_rut.Text, cmb_cliente.Text, Today, txt_folio.Text, cmb_codigo.Text, txt_descripcion.Text, txt_cantidad.Text, txt_venta_m2.Text, txt_precio_min.Text, txt_precio_max.Text, 0)

                    End If
                End If
            End If

            If IsNumeric(precio_minimo) Then

                If precio_minimo > 0 And precio < precio_minimo Then

                    If MessageBox.Show("¿Está seguro que desea vender a un precio menor al mínimo?", "Confirmación de procedimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                        Exit Sub
                    Else
                        nue_report.insertar_alerta_precio(Nombre_Obra, txt_rut.Text, cmb_cliente.Text, Today, txt_folio.Text, cmb_codigo.Text, txt_descripcion.Text, txt_cantidad.Text, txt_venta_m2.Text, txt_precio_min.Text, txt_precio_max.Text, 1)

                    End If
                End If
            End If

            If (cmb_cliente.Text <> "" And cmb_codigo.Text <> "" And txt_nombre_ejecutivo.Text <> "" And txt_venta_m2.Text <> "" And txt_cantidad.Text <> "" And txt_monto.Text <> 0) Then

                cliente = cmb_cliente.Text
                rut = txt_rut.Text
                area_negocio = txt_area_negocio.Text
                senal_advertencia = txt_senal_advertencia.Text
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

                'venta_neta = Convert.ToDouble(txt_monto.Text)
                'venta_iva = Convert.ToDouble(txt_iva.Text)
                'venta_total = Convert.ToDouble(txt_total.Text)

                condicion = txt_condicion.Text
                forma_pago = forma_de_pago.Text
                ejecutivo = txt_ejecutivo.Text
                observaciones = txt_observaciones.Text
                precio_lista = Convert.ToDouble(txt_precio_lista.Text)
                precio_cliente = Convert.ToDouble(txt_precio_cliente.Text)
                pedido = 0
                descuento = 0
                folio = txt_folio.Text
                toma_pedido = txt_nombre_ejecutivo.Text
                comuna = txt_comuna.Text
                dias_pago = 1
                fecha_suma = CDate(txt_fecha_act.Text)

                venta_neta = Math.Round(cantidad * precio_cliente)
                venta_iva = Math.Round(venta_neta * 0.19)
                venta_total = Math.Round(venta_neta * 1.19)

                If condicion <> "" Then
                    fecha = fecha_suma.AddDays(condicion)
                    solicitado = ""
                    If txt_ancho.Text = "" Then
                    Else
                        ancho = Convert.ToDouble(txt_ancho.Text)
                    End If
                    If txt_largo.Text = "" Then
                    Else
                        largo = Convert.ToDouble(txt_largo.Text)
                    End If
                    If sw = 0 Then
                        If documento = 0 Then ' FACTURA
                            ' Actualizar base dato venta 4 
                            For cant As Integer = 0 To dgv_venta.RowCount
                                If (cant = dgv_venta.RowCount) Then
                                    nue_report.insertar(cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha_act.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio, toma_pedido, ancho, largo, solicitado)
                                    Exit For
                                ElseIf (cmb_codigo.Text.Equals(dgv_venta.Rows(cant).Cells(11).Value).ToString()) Then
                                    Dim id_venta As Integer = CInt(dgv_venta.Rows(cant).Cells(0).Value)
                                    'cantidad = CInt(dgv_venta.Rows(cant).Cells(15).Value)
                                    'area_total = CDbl(dgv_venta.Rows(cant).Cells(16).Value)
                                    'venta_neta = CInt(dgv_venta.Rows(cant).Cells(19).Value)
                                    'venta_iva = CInt(dgv_venta.Rows(cant).Cells(20).Value)
                                    'venta_total = CInt(dgv_venta.Rows(cant).Cells(21).Value)
                                    nue_report.actualizar_articulo(cantidad, area_total, unit_venta_m2, venta_neta, venta_iva, venta_total, precio_cliente, id_venta)
                                    Exit For
                                End If
                            Next
                            ' Inserta en la data el articulo, luego actualiza la data para mostrar los datos relacionados.
                            'nue_report.insertar(cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha_act.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio, toma_pedido, ancho, largo, solicitado)
                        ElseIf documento = 1 Then ' GUIA
                            For cant As Integer = 0 To dgv_venta.RowCount
                                If (cant = dgv_venta.RowCount) Then
                                    nue_report.insertar10(cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha_act.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio, toma_pedido, ancho, largo, solicitado)
                                    Exit For
                                ElseIf (cmb_codigo.Text.Equals(dgv_venta.Rows(cant).Cells(11).Value).ToString()) Then
                                    Dim id_venta As Integer = CInt(dgv_venta.Rows(cant).Cells(0).Value)
                                    'cantidad = CInt(dgv_venta.Rows(cant).Cells(15).Value)
                                    'area_total = CDbl(dgv_venta.Rows(cant).Cells(16).Value)
                                    'venta_neta = CInt(dgv_venta.Rows(cant).Cells(19).Value)
                                    'venta_iva = CInt(dgv_venta.Rows(cant).Cells(20).Value)
                                    'venta_total = CInt(dgv_venta.Rows(cant).Cells(21).Value)
                                    nue_report.actualizar_articulo_guia(cantidad, area_total, unit_venta_m2, venta_neta, venta_iva, venta_total, precio_cliente, id_venta)
                                    Exit For
                                End If
                            Next
                            'nue_report.insertar10(cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha_act.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio, toma_pedido, ancho, largo, solicitado)
                        End If
                        actualizar_dgv_venta()
                        suma_total_procedimiento()
                        limpiar()
                    Else
                        ' Modifica la la fila de la tabla venta4 por el Id_venta
                        nue_report.modificar(CInt(Cod_Mov_Tierra), cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, CDate(txt_fecha_act.Text), pedido, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), descuento, folio)
                        actualizar_dgv_venta()
                        suma_total_procedimiento()
                        txt_consulta_total.Text = nue_report.descripcion_total(cmb_cliente.Text, txt_numero_pedido.Text)
                        txt_consulta_iva.Text = nue_report.descripcion_iva(cmb_cliente.Text, txt_numero_pedido.Text)
                        txt_consulta_monto.Text = nue_report.descripcion_neto(cmb_cliente.Text, txt_numero_pedido.Text)
                    End If
                    limpiar()
                Else
                    MessageBox.Show("FALTA CONDICIÓN DE CLIENTE")
                End If
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            End If
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

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar2(CInt(Cod_Mov_Tierra))
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
        dgv_complementarios.DataSource = nue_report.listar5(txt_complementarios.Text)
        dgv_complementarios.Columns(0).Visible = False
        dgv_complementarios.Columns(1).Visible = False
        dgv_complementarios.Columns(2).Visible = False
        dgv_complementarios.AllowUserToOrderColumns = True
        dgv_complementarios.Columns(3).Width = 200
        dgv_complementarios.ColumnHeadersVisible = False
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
        txt_ancho.Clear()
        txt_largo.Clear()
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
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Me.txt_fecha_act.Text = Today
    '    Me.txt_hora.Text = TimeOfDay
    'End Sub

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
        If documento = 1 Then
            txt_venta_m2.Text = 1
        End If
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
                If (Not IsNumeric(txt_ult_venta.Text) Or (Not IsNumeric(txt_area_calculada.Text))) Then
                Else
                    txt_area_calc.Text = CDbl(txt_area_calculada.Text) * CDbl(txt_cantidad.Text)
                    If documento = 0 Then
                        txt_descuento.Text = -((CDbl(txt_ult_venta.Text) - CDbl(txt_venta_m2.Text)) / CDbl(txt_ult_venta.Text))
                    End If
                    txt_precio_cliente.Text = CDbl(txt_venta_m2.Text) * CDbl(txt_area_calculada.Text)
                    txt_precio_lista.Text = CDbl(txt_ult_venta.Text) * CDbl(txt_area_calculada.Text)
                    txt_monto.Text = Math.Round(CDbl(txt_precio_cliente.Text) * CDbl(txt_cantidad.Text))
                    txt_iva.Text = Math.Round(CDbl(txt_monto.Text) * 0.19)
                    txt_total.Text = Math.Round(CDbl(txt_monto.Text) + CDbl(txt_iva.Text))
                End If
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
        If (Not IsNumeric(Me.txt_ult_venta.Text)) Then
            Me.txt_ult_venta.Text = 0
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
                'txt_venta_m2.Text = Format(CDbl(txt_venta_m2.Text), "###,###,##0.")
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
        txt_tipo1.Clear()

        Frm_ventas_clientes_busqueda.Show()
        bloquear()
        dgv_sustitutos.DataSource = Nothing
        dgv_Mov_Tierra.DataSource = Nothing
        dgv_complementarios.DataSource = Nothing
    End Sub


    Public Sub cmb_cliente_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_cliente.MouseClick
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
        cmb_pedidos_ant.Text = ""

        Frm_ventas_clientes_busqueda.Show()
        bloquear()
        dgv_sustitutos.DataSource = Nothing
        dgv_Mov_Tierra.DataSource = Nothing
        dgv_complementarios.DataSource = Nothing
        folio_condicion = 0
        txt_factura_ref.Visible = False
        lbl_fact_rel.Visible = False
    End Sub

    Private Sub cmb_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cliente.TextChanged
        'folio_condicion = 0
        'txt_folio.Text = 1
        'desbloquear()
        'limpiar()
        'sw = 0
        'txt_folio.Visible = False
        'lbl_folio.Visible = False

        'dgv_sustitutos.DataSource = Nothing
        'dgv_venta.DataSource = Nothing
        'dgv_complementarios.DataSource = Nothing
        'txt_consulta_monto.Text = 0
        'txt_consulta_iva.Text = 0
        'txt_consulta_total.Text = 0


        'If (cmb_cliente.Text = "") Then
        '    dgv_Mov_Tierra.DataSource = Nothing
        'Else
        '    actualizar_dgv()
        '    actualizar_dgv_venta()
        'End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Sub actualizar_dgv_venta()
        If documento = 0 Then
            dgv_venta.DataSource = nue_report.listar10(txt_folio.Text)
        ElseIf documento = 1 Then
            dgv_venta.DataSource = nue_report.listar26(txt_folio.Text)
        End If
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
        dgv_venta.Columns(29).Visible = False
        dgv_venta.Columns(30).Visible = False
        dgv_venta.Columns(31).HeaderText = "Fecha"
        dgv_venta.Columns(32).Visible = False
        dgv_venta.Columns(33).Visible = False
        dgv_venta.Columns(34).Visible = False
        dgv_venta.Columns(35).Visible = False
        dgv_venta.Columns(36).Visible = False
        dgv_venta.Columns(37).Visible = False
        dgv_venta.Columns(38).Visible = False

        dgv_venta.Columns(31).DisplayIndex = 1
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
        dgv_venta.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
        dgv_venta.Columns(31).Width = 70
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

    Private Sub dgv_venta_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_venta.CellClick
        On Error GoTo 0
    End Sub

    Private Sub dgv_venta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_venta.CellContentClick, dgv_Mov_Tierra.CellClick
        Dim codigo As String
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
        txt_tipo1.Clear()
        If documento = 1 And tipo_guia = 5 Then
            codigo = dgv_Mov_Tierra.CurrentRow.Cells(2).Value.ToString()
        Else
            codigo = dgv_Mov_Tierra.CurrentRow.Cells(11).Value.ToString()
        End If
        dgv_codigo.DataSource = nue_report.listar24(codigo)

        cmb_codigo.Text = dgv_codigo.CurrentRow.Cells(1).Value.ToString()
        txt_descripcion.Text = dgv_codigo.CurrentRow.Cells(3).Value.ToString()
        txt_area_calculada.Text = dgv_codigo.CurrentRow.Cells(9).Value.ToString()
        txt_area_negocio.Text = dgv_codigo.CurrentRow.Cells(11).Value.ToString()
        txt_familia1.Text = dgv_codigo.CurrentRow.Cells(16).Value.ToString()
        txt_familia2.Text = dgv_codigo.CurrentRow.Cells(17).Value.ToString()
        txt_familia3.Text = dgv_codigo.CurrentRow.Cells(18).Value.ToString()
        txt_proveedor.Text = dgv_codigo.CurrentRow.Cells(2).Value.ToString()
        txt_medidas.Text = dgv_codigo.CurrentRow.Cells(5).Value.ToString()
        txt_precio_min.Text = dgv_codigo.CurrentRow.Cells(24).Value.ToString()
        txt_precio_max.Text = dgv_codigo.CurrentRow.Cells(23).Value.ToString()
        txt_ancho.Text = dgv_codigo.CurrentRow.Cells(7).Value.ToString()
        txt_largo.Text = dgv_codigo.CurrentRow.Cells(8).Value.ToString()
        txt_tipo1.Text = dgv_codigo.CurrentRow.Cells(4).Value.ToString()

        If documento = 1 And tipo_guia = 5 Then
            pendiente = dgv_Mov_Tierra.CurrentRow.Cells(7).Value.ToString()

        Else
            txt_iva.Text = dgv_Mov_Tierra.CurrentRow.Cells(20).Value.ToString()
            txt_total.Text = dgv_Mov_Tierra.CurrentRow.Cells(21).Value.ToString()
            txt_precio_lista.Text = dgv_Mov_Tierra.CurrentRow.Cells(27).Value.ToString()
            txt_ult_venta.Text = txt_precio_lista.Text / txt_area_calculada.Text
            txt_venta_m2.Text = dgv_Mov_Tierra.CurrentRow.Cells(18).Value.ToString()
        End If
    End Sub


    Private Sub dgv_venta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_venta.DoubleClick
        Cod_Mov_Tierra = dgv_venta.CurrentRow.Cells(0).Value.ToString()
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok And documento = 0 Then
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
            ElseIf eliminar = MsgBoxResult.Ok And documento = 1 Then
                nue_report.eliminar4(CInt(Cod_Mov_Tierra))
                actualizar_dgv_venta()
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

            End If
        End If
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
        dgv_venta.Columns(34).Visible = False
        dgv_venta.Columns(35).Visible = False
        dgv_venta.Columns(36).Visible = False
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

    Private Sub cmb_numero_pedido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_numero_pedido.TextChanged
        actualizar_dgv_venta2()
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        frm_ofertas_dia.Close()
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        frm_ofertas_dia.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
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
        On Error GoTo 0
    End Sub

    Private Sub dgv_complementarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_complementarios.CellContentClick
        On Error GoTo 0
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_folio.Text = 1 Then
            MessageBox.Show("INGRESE DATOS DE PEDIDO")
        ElseIf txt_folio.Text = cmb_pedidos_ant.Text Then
            CR_guia_de_despacho.Show()
            actualizar_dgv()
        Else
            If rdbtn_entrante.Checked = True Or rdbtn_saliente.Checked = True Then
                If rdbtn_email.Checked = True Or rdbtn_llamada.Checked = True Or rdbtn_personal.Checked = True Or rdbtn_what.Checked = True Then
                    datos_nota.Show()
                Else
                    MsgBox("FALTA INGRESAR EL MEDIO DE CONTACTO")
                End If
            Else
                MsgBox("FALTA INGRESAR SI ES UN CONTACTO SALIENTE O ENTRANTE")
            End If
        End If

    End Sub

    Sub actualizar_dgv2()
        dgv_Mov_Tierra.DataSource = nue_report.listar15(cmb_cliente.Text, txt_producto.Text)
        dgv_Mov_Tierra.Columns(0).Visible = False
        dgv_Mov_Tierra.Columns(1).Visible = False
        dgv_Mov_Tierra.Columns(2).Visible = False
        dgv_Mov_Tierra.Columns(3).Visible = False
        dgv_Mov_Tierra.Columns(4).Visible = False
        dgv_Mov_Tierra.Columns(5).Visible = False
        dgv_Mov_Tierra.Columns(6).Visible = False
        dgv_Mov_Tierra.Columns(7).Visible = False
        dgv_Mov_Tierra.Columns(8).Visible = False
        dgv_Mov_Tierra.Columns(9).Visible = False
        dgv_Mov_Tierra.Columns(11).Visible = False
        dgv_Mov_Tierra.Columns(12).Visible = False
        dgv_Mov_Tierra.Columns(16).Visible = False
        dgv_Mov_Tierra.Columns(17).Visible = False
        dgv_Mov_Tierra.Columns(20).Visible = False
        dgv_Mov_Tierra.Columns(21).Visible = False
        dgv_Mov_Tierra.Columns(22).Visible = False
        dgv_Mov_Tierra.Columns(23).Visible = False
        dgv_Mov_Tierra.Columns(24).Visible = False
        dgv_Mov_Tierra.Columns(25).Visible = False
        dgv_Mov_Tierra.Columns(26).Visible = False
        dgv_Mov_Tierra.Columns(27).Visible = False
        dgv_Mov_Tierra.Columns(30).Visible = False
        dgv_Mov_Tierra.Columns(31).Visible = False
        dgv_Mov_Tierra.Columns(32).Visible = False
        dgv_Mov_Tierra.Columns(33).Visible = False
        dgv_Mov_Tierra.Columns(35).Visible = False
        dgv_Mov_Tierra.Columns(36).Visible = False

        dgv_Mov_Tierra.Columns(10).HeaderText = "Medidas"
        dgv_Mov_Tierra.Columns(13).HeaderText = "Descripción"
        dgv_Mov_Tierra.Columns(14).HeaderText = "Área Un."
        dgv_Mov_Tierra.Columns(15).HeaderText = "Cantidad"
        dgv_Mov_Tierra.Columns(18).HeaderText = "Precio M2"
        dgv_Mov_Tierra.Columns(19).HeaderText = "Venta"
        dgv_Mov_Tierra.Columns(28).HeaderText = "Precio Un."
        dgv_Mov_Tierra.Columns(29).HeaderText = "Fecha"
        dgv_Mov_Tierra.Columns(34).HeaderText = "N° Venta"

        dgv_Mov_Tierra.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(18).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_Mov_Tierra.Columns(34).DefaultCellStyle.Format = "###,###,###"

        dgv_Mov_Tierra.Columns(1).Width = 200
        dgv_Mov_Tierra.Columns(10).Width = 60
        dgv_Mov_Tierra.Columns(13).Width = 200
        dgv_Mov_Tierra.Columns(14).Width = 40
        dgv_Mov_Tierra.Columns(15).Width = 50
        dgv_Mov_Tierra.Columns(18).Width = 60
        dgv_Mov_Tierra.Columns(19).Width = 60
        dgv_Mov_Tierra.Columns(28).Width = 60
        dgv_Mov_Tierra.Columns(29).Width = 65
        dgv_Mov_Tierra.Columns(30).Width = 50
        dgv_Mov_Tierra.Columns(34).Width = 60


        dgv_Mov_Tierra.AllowUserToOrderColumns = True

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

        dgv_Mov_Tierra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_Mov_Tierra.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub txt_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_producto.TextChanged
        If Len(txt_producto.Text) = 0 Or Len(txt_producto.Text) > 2 Then
            actualizar_dgv2()
        End If
    End Sub
    Public Sub actualizar_pedidos()
        cmb_pedidos_ant.DataSource = nue_report.listar16(cmb_cliente.Text)
        cmb_pedidos_ant.DisplayMember = "numero_folio"
        cmb_pedidos_ant.ValueMember = "numero_folio"
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        actualizar_pedidos()
        cmb_pedidos_ant.Visible = True
    End Sub

    Private Sub cmb_pedidos_ant_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_pedidos_ant.MouseClick
        txt_folio.Text = cmb_pedidos_ant.Text
        actualizar_dgv_venta()
    End Sub

    Private Sub txt_familia1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_familia1.TextChanged
        If txt_familia1.Text <> "" Then
            txt_complementarios.Text = txt_familia1.Text
            actualizar_complementarios()
        End If
    End Sub

    Private Sub dgv_venta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_venta.MouseClick
        If dgv_venta.CurrentRow.Cells(6).Value.ToString() <> "" Then
            txt_complementarios.Text = dgv_venta.CurrentRow.Cells(6).Value.ToString()
            actualizar_complementarios()
        Else
            On Error GoTo 0
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txt_consulta_total.Text = nue_report.descripcion_total(cmb_cliente.Text, txt_folio.Text)
        txt_consulta_iva.Text = nue_report.descripcion_iva(cmb_cliente.Text, txt_folio.Text)
        txt_consulta_monto.Text = nue_report.descripcion_neto(cmb_cliente.Text, txt_folio.Text)
    End Sub
    Sub suma_total_procedimiento()
        suma_total = 0
        For Each r As DataGridViewRow In dgv_venta.Rows
            If IsNumeric(r.Cells(19).Value) Then
                suma_total = r.Cells(19).Value + suma_total
            End If
        Next

        txt_consulta_monto.Text = FormatNumber(suma_total, 0)
        txt_consulta_monto.Text = Format(CDbl(txt_consulta_monto.Text), "###,##0.")

        txt_consulta_iva.Text = FormatNumber(suma_total * 0.19, 0)
        txt_consulta_iva.Text = Format(CDbl(txt_consulta_iva.Text), "###,##0.")

        txt_consulta_total.Text = FormatNumber(suma_total * 1.19, 0)
        txt_consulta_total.Text = Format(CDbl(txt_consulta_total.Text), "###,##0.")
    End Sub
    Private Sub Frm_ventas_mod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'MessageBox.Show("enter")
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Sub actualizar_folio()
        If documento = 0 Then
            dgv_folio.DataSource = nue_report.listar6()
        ElseIf documento = 1 Then
            dgv_folio.DataSource = nue_report.listar25()
        End If

    End Sub
    Public Sub actualizar_folios()
        cmb_volver.DataSource = nue_report.listar23(cmb_cliente.Text)
        cmb_volver.DisplayMember = "numero_folio"
        cmb_volver.ValueMember = "numero_folio"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        actualizar_folios()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If cmb_volver.Text <> "" Then
            txt_folio.Text = cmb_volver.Text
            txt_folio.Visible = True
            actualizar_dgv_venta()
            folio_condicion = 1
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If chk_venta.Checked = True Then
            venta_promedio = 0
        Else
            venta_promedio = 1
        End If
        CR_EC_Cliente13.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        variable_retiro = 1
        frm_retiro_documentos_2.Show()
    End Sub

    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged
        folio_condicion = 0
        txt_folio.Text = 1
        desbloquear()
        limpiar()
        sw = 0
        'txt_folio.Visible = False
        lbl_folio.Visible = False

        dgv_sustitutos.DataSource = Nothing
        dgv_venta.DataSource = Nothing
        dgv_complementarios.DataSource = Nothing
        txt_consulta_monto.Text = 0
        txt_consulta_iva.Text = 0
        txt_consulta_total.Text = 0


        If (cmb_cliente.Text = "") Then
            dgv_Mov_Tierra.DataSource = Nothing
        Else
            actualizar_dgv()
            actualizar_dgv_venta()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        bloqueo_inf = 1
        frm_bloqueo_inf.Show()
    End Sub

    Private Sub btn_guias_Click(sender As Object, e As EventArgs)
        frm_guias.Show()
    End Sub
    Sub actualizar_guia()
        dgv_nota_credito.DataSource = nueva_notaCredito.buscaNotasCredito(txt_factura_ref.Text) ' busca si la factura tiene alguna nota de credito asociada.
        dgv_Mov_Tierra.DataSource = nue_report.listar27(txt_factura_ref.Text)

        dgv_Mov_Tierra.Columns(0).Visible = True
        dgv_Mov_Tierra.Columns(1).Visible = True
        dgv_Mov_Tierra.Columns(3).Visible = True
        dgv_Mov_Tierra.Columns(0).HeaderText = "N° Factura"
        dgv_Mov_Tierra.Columns(1).HeaderText = "Fecha Factura"
        dgv_Mov_Tierra.Columns(2).Visible = False
        dgv_Mov_Tierra.Columns(3).HeaderText = "Descripción"
        dgv_Mov_Tierra.Columns(4).HeaderText = "Medidas"
        dgv_Mov_Tierra.Columns(5).HeaderText = "Q"
        dgv_Mov_Tierra.Columns(6).HeaderText = "Entreg."
        dgv_Mov_Tierra.Columns(7).HeaderText = "Saldo"
        dgv_Mov_Tierra.Columns(8).Visible = False

        dgv_Mov_Tierra.Columns(0).Width = 70
        dgv_Mov_Tierra.Columns(1).Width = 70
        dgv_Mov_Tierra.Columns(3).Width = 200
        dgv_Mov_Tierra.Columns(4).Width = 80
        dgv_Mov_Tierra.Columns(5).Width = 80
        dgv_Mov_Tierra.Columns(6).Width = 80
        dgv_Mov_Tierra.Columns(7).Width = 80
        'dgv_Mov_Tierra.Columns(5).DefaultCellStyle.Format = "##,###.##"
        'dgv_Mov_Tierra.Columns(7).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_Mov_Tierra.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        If (dgv_nota_credito.RowCount > 0) Then
            QuitarPedidosNotaCredito(dgv_nota_credito.RowCount, dgv_Mov_Tierra.RowCount)
        End If
    End Sub
    Private Sub QuitarPedidosNotaCredito(cantidadNotasCredito As Integer, cantidadProductos As Integer)
        Dim codigoNotaCredito, codigoProductos As String ' Variables para almacenar el código de los items
        ' Se inicia con el for de las notas de creditos inicializado en 0, maximo la cantidad de items del data.
        For conteoNotasCredito As Integer = 0 To cantidadNotasCredito

            If (conteoNotasCredito = cantidadNotasCredito) Then
                Exit For
            End If
            codigoNotaCredito = dgv_nota_credito.Rows(conteoNotasCredito).Cells(3).Value.ToString()
            For conteoProductos As Integer = 0 To cantidadProductos
                If (conteoProductos = cantidadProductos) Then
                    Exit For
                End If
                codigoProductos = dgv_Mov_Tierra.Rows(conteoProductos).Cells(2).Value.ToString()
                If (codigoNotaCredito.Equals(codigoProductos)) Then
                    dgv_Mov_Tierra.Rows.RemoveAt(conteoProductos) ' Remueve el items en caso de haya coincidencia.
                    Exit For
                End If
            Next
        Next
    End Sub

End Class