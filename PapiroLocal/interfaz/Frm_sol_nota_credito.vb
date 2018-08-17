Imports System.Globalization
Public Class Frm_sol_nota_credito

    Dim nue_report As New clases.Nota_credito
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub bloquear()
        txt_razon_social.ReadOnly = True
        txt_rut.ReadOnly = True
        txt_descripcion.ReadOnly = True
        txt_precio_venta.ReadOnly = True
        txt_cant_vendida.ReadOnly = True
        txt_area.ReadOnly = True
        txt_medidas.ReadOnly = True
        txt_usuario.ReadOnly = True
        txt_fecha_act.ReadOnly = True
        txt_hora.ReadOnly = True
        txt_codigo.ReadOnly = True
        txt_total.ReadOnly = True
        txt_nota.ReadOnly = True
    End Sub
    Sub limpiar()
        lv_nc.Items.Clear()
        txt_razon_social.Clear()
        txt_rut.Clear()
        txt_descripcion.Clear()
        txt_precio_venta.Clear()
        txt_cant_vendida.Clear()
        txt_area.Clear()
        txt_medidas.Clear()
        'txt_factura.Clear()
        txt_folio_nc.Clear()
        txt_observaciones.Clear()
        txt_precio_rollo.Clear()
        txt_cant_rollo.Clear()
        txt_total.Clear()
        txt_codigo.Clear()
        txt_ac.Text = 0
        rdbtn_accion1.Checked = False
        rdbtn_accion2.Checked = False
        rdbtn_accion3.Checked = False
        rdbtn_accion4.Checked = False
        rdbtn_error1.Checked = False
        rdbtn_error2.Checked = False
        rdbtn_error3.Checked = False
        rdbtn_error4.Checked = False
        rdbtn_1.Checked = False
        rdbtn_2.Checked = False
        rdbtn_3.Checked = False
        rdbtn_4.Checked = False
        rdbtn_5.Checked = False

    End Sub
    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_corrige1.Visible = False
        lbl_corrige2.Visible = False
        lbl_corrige3.Visible = False
        lbl_corrige4.Visible = False
        lbl_corrige5.Visible = False
        txt_observaciones.Visible = True
        txt_corrige.Visible = False
        txt_corrige2.Visible = False
        txt_corrige3.Visible = False
        txt_texto.Visible = False
        txt_texto.Enabled = False
        txt_ac.ReadOnly = True
        txt_iva.ReadOnly = True
        txt_cn_iva.ReadOnly = True
        bloquear()
        limpiar()
        Me.WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        txt_usuario.Text = Nombre_Obra
        txt_folio_nc.ReadOnly = True
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '   Me.txt_fecha_act.Text = Today
    '  Me.txt_hora.Text = TimeOfDay
    'End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If txt_factura.Text <> "" And IsNumeric(txt_factura.Text) Then
            limpiar()
            txt_rut.Text = nue_report.descripcion_rut(txt_factura.Text)
            txt_razon_social.Text = nue_report.descripcion_razon(txt_factura.Text)
            actualizar_dgv()
            txt_folio_nc.Text = nue_report.descripcion_numero_folio() + 1
            ' acción para buscar las notas de creditos en caso de que la factura tenga
            dgv_notas_creditos.DataSource = nue_report.buscaNotasCredito(txt_factura.Text)
            If (dgv_notas_creditos.RowCount > 0) Then
                dgv_notas_creditos.Columns(0).Visible = False
                dgv_notas_creditos.Columns(2).Visible = False
                dgv_notas_creditos.Columns(3).Visible = False
                dgv_notas_creditos.Columns(4).Visible = False
                dgv_notas_creditos.Columns(9).Visible = False
                dgv_notas_creditos.Columns(10).Visible = False
                dgv_notas_creditos.Columns(11).Visible = False
                dgv_notas_creditos.Columns(13).Visible = False
                dgv_notas_creditos.Columns(14).Visible = False
                dgv_notas_creditos.Columns(16).Visible = False
                dgv_notas_creditos.Columns(19).Visible = False
                dgv_notas_creditos.Columns(20).Visible = False
                dgv_notas_creditos.Columns(21).Visible = False
                dgv_notas_creditos.Columns(22).Visible = False
                dgv_notas_creditos.Columns(23).Visible = False
                dgv_notas_creditos.Columns(24).Visible = False
                dgv_notas_creditos.Columns(25).Visible = False
                dgv_notas_creditos.Columns(26).Visible = False
                dgv_notas_creditos.Columns(27).Visible = False
                dgv_notas_creditos.Columns(28).Visible = False
                dgv_notas_creditos.Columns(29).Visible = False
                dgv_notas_creditos.Columns(30).Visible = False
                dgv_notas_creditos.Columns(31).Visible = False
                dgv_notas_creditos.Columns(32).Visible = False
                dgv_notas_creditos.Columns(33).Visible = False
                dgv_notas_creditos.Columns(34).Visible = False

                dgv_notas_creditos.Columns(1).HeaderText = "Nota de credito"
                dgv_notas_creditos.Columns(5).HeaderText = "Accion"
                dgv_notas_creditos.Columns(6).HeaderText = "Error"
                dgv_notas_creditos.Columns(7).HeaderText = "Observacion"
                dgv_notas_creditos.Columns(8).HeaderText = "Motivo"
                dgv_notas_creditos.Columns(12).HeaderText = "Usuario"
                dgv_notas_creditos.Columns(15).HeaderText = "Codigo"
                dgv_notas_creditos.Columns(17).HeaderText = "Canitdad"
                dgv_notas_creditos.Columns(18).HeaderText = "Monto"
                dgv_notas_creditos.Columns(35).HeaderText = "Descripcion"
                dgv_notas_creditos.Columns(36).HeaderText = "Medidas"

                dgv_notas_creditos.Columns(1).DisplayIndex = 0
                dgv_notas_creditos.Columns(5).DisplayIndex = 5
                dgv_notas_creditos.Columns(6).DisplayIndex = 6
                dgv_notas_creditos.Columns(7).DisplayIndex = 10
                dgv_notas_creditos.Columns(8).DisplayIndex = 7
                dgv_notas_creditos.Columns(12).DisplayIndex = 8
                dgv_notas_creditos.Columns(15).DisplayIndex = 1
                dgv_notas_creditos.Columns(17).DisplayIndex = 4
                dgv_notas_creditos.Columns(18).DisplayIndex = 9
                dgv_notas_creditos.Columns(35).DisplayIndex = 2
                dgv_notas_creditos.Columns(36).DisplayIndex = 3

                dgv_notas_creditos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv_notas_creditos.AllowUserToOrderColumns = True

                MsgBox("Esta factura tiene notas de créditos relacionadas." + vbLf + "Dirijase a la sección correspondiente para ver el detalle.", MsgBoxStyle.Information, "Importante")
            Else
                dgv_notas_creditos.DataSource = Nothing
            End If
        End If
    End Sub
    Sub actualizar_dgv()
        dgv_productos.DataSource = nue_report.listar(txt_factura.Text)
        dgv_productos.Columns(0).HeaderText = "N° Factura"
        dgv_productos.AllowUserToOrderColumns = True
        dgv_productos.Columns(1).Visible = False
        dgv_productos.Columns(1).Width = 200
        dgv_productos.Columns(2).Visible = False
        dgv_productos.Columns(3).Visible = False
        dgv_productos.Columns(4).Visible = False
        dgv_productos.Columns(5).Visible = False
        dgv_productos.Columns(6).Visible = False
        dgv_productos.Columns(7).Visible = False
        dgv_productos.Columns(8).Visible = False
        dgv_productos.Columns(9).Visible = False
        dgv_productos.Columns(10).HeaderText = "Medidas"
        dgv_productos.Columns(11).Visible = False
        dgv_productos.Columns(12).Visible = False
        dgv_productos.Columns(13).HeaderText = "Descripción"
        dgv_productos.Columns(13).Width = 200
        dgv_productos.Columns(14).HeaderText = "Área Un."
        dgv_productos.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_productos.Columns(15).HeaderText = "Cantidad"
        dgv_productos.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(16).Visible = False
        dgv_productos.Columns(17).Visible = False
        dgv_productos.Columns(18).HeaderText = "Precio M2"
        dgv_productos.Columns(18).DefaultCellStyle.Format = "##,###.##"
        dgv_productos.Columns(19).HeaderText = "Venta"
        dgv_productos.Columns(19).DefaultCellStyle.Format = "##,###.##"
        dgv_productos.Columns(20).Visible = False
        dgv_productos.Columns(21).Visible = False
        dgv_productos.Columns(22).Visible = False
        dgv_productos.Columns(23).Visible = False
        dgv_productos.Columns(24).Visible = False
        dgv_productos.Columns(25).Visible = False
        dgv_productos.Columns(26).Visible = False
        dgv_productos.Columns(27).Visible = False
        dgv_productos.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_productos.Columns(28).HeaderText = "Precio Un."
        dgv_productos.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_productos.Columns(29).Visible = False
        dgv_productos.Columns(30).HeaderText = "Fecha"
        dgv_productos.Columns(31).Visible = False
        dgv_productos.Columns(32).Visible = False
        dgv_productos.Columns(33).Visible = False
        dgv_productos.Columns(34).Visible = False
        dgv_productos.Columns(35).Visible = False
        dgv_productos.Columns(36).Visible = False
        dgv_productos.Columns(37).Visible = False

        dgv_productos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(0).DefaultCellStyle.Format = "###,###,###"
        dgv_productos.Columns(0).DisplayIndex = 0
        dgv_productos.Columns(29).DisplayIndex = 1
        dgv_productos.Columns(13).DisplayIndex = 2
        dgv_productos.Columns(10).DisplayIndex = 3
        dgv_productos.Columns(15).DisplayIndex = 4
        dgv_productos.Columns(18).DisplayIndex = 5
        dgv_productos.Columns(14).DisplayIndex = 6
        dgv_productos.Columns(28).DisplayIndex = 7
        dgv_productos.Columns(19).DisplayIndex = 8
        dgv_productos.Columns(30).DisplayIndex = 9
        dgv_productos.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_productos.Columns(30).Width = 70
        dgv_productos.Columns(10).Width = 60
        dgv_productos.Columns(15).Width = 50
        dgv_productos.Columns(28).Width = 60
        dgv_productos.Columns(29).Width = 65
        dgv_productos.Columns(18).Width = 60
        dgv_productos.Columns(19).Width = 60
        dgv_productos.Columns(0).Width = 50
        dgv_productos.Columns(14).Width = 40
        dgv_productos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Private Sub dgv_productos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_productos.DoubleClick
        txt_descripcion.Text = dgv_productos.CurrentRow.Cells(13).Value.ToString()
        txt_area.Text = dgv_productos.CurrentRow.Cells(14).Value.ToString()
        txt_precio_venta.Text = dgv_productos.CurrentRow.Cells(28).Value.ToString()
        txt_cant_vendida.Text = dgv_productos.CurrentRow.Cells(15).Value.ToString()
        txt_medidas.Text = dgv_productos.CurrentRow.Cells(10).Value.ToString()
        txt_precio_rollo.Text = dgv_productos.CurrentRow.Cells(28).Value.ToString()
        txt_cant_rollo.Text = dgv_productos.CurrentRow.Cells(15).Value.ToString()
        txt_codigo.Text = dgv_productos.CurrentRow.Cells(11).Value.ToString()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_total.Text = "" Then
            MsgBox("Necesita ingresar un valor distinto de 0")
        ElseIf txt_total.Text = 0 Or txt_total.Text = "0" Then
            MsgBox("Necesita ingresar un valor distinto de 0")
        ElseIf (txt_cant_rollo.Text > txt_cant_vendida.Text Or txt_cant_rollo.Text = "0" Or txt_cant_rollo.Text = 0) And (rdbtn_3.Checked = True Or rdbtn_4.Checked = True And rdbtn_5.Checked = True) Then
            txt_cant_rollo.Text = Nothing
            MsgBox("La cantidad no puede ser supedior a la vendida ni cero.")
        ElseIf (txt_precio_rollo.Text > txt_precio_venta.Text Or txt_precio_rollo.Text = "0" Or txt_cant_rollo.Text = 0) And (rdbtn_3.Checked = True Or rdbtn_4.Checked = True And rdbtn_5.Checked = True) Then
            txt_precio_rollo.Text = Nothing
            MsgBox("El precio de unidad o de rollo no puede ser superior a la vendida ni cero.")
        Else
            If (txt_precio_rollo.Text <> "" And txt_cant_rollo.Text <> "" And txt_razon_social.Text <> "") Then
                Dim lista As ListViewItem = New ListViewItem(txt_codigo.Text)
                lista.SubItems.Add(txt_cant_rollo.Text)
                lista.SubItems.Add(FormatCurrency(txt_precio_rollo.Text))
                lista.SubItems.Add(FormatCurrency(txt_total.Text))
                lv_nc.Items.Add(lista)
                'frm_registro_pagos.suma_listview()
                suma_listview()
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            End If
        End If
    End Sub

    Private Sub txt_precio_rollo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_precio_rollo.TextChanged
        If txt_precio_rollo.Text <> "" And IsNumeric(txt_precio_rollo.Text) And txt_cant_rollo.Text <> "" And IsNumeric(txt_cant_rollo.Text) Then
            txt_total.Text = -txt_precio_rollo.Text * txt_cant_rollo.Text
        End If
    End Sub

    Private Sub txt_cant_rollo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cant_rollo.TextChanged
        If IsNumeric(txt_cant_rollo.Text) And IsNumeric(txt_cant_vendida.Text) Then
            If (Convert.ToDouble(txt_cant_rollo.Text) <= txt_cant_vendida.Text) Then
                txt_total.Text = -1 * Convert.ToDouble(txt_precio_rollo.Text) * Convert.ToDouble(txt_cant_rollo.Text)
            Else
                txt_cant_rollo.Clear()
            End If
        Else
            txt_total.Text = 0
            txt_cant_rollo.Text = 1
            txt_precio_rollo.Text = 0
        End If
    End Sub

    Private Sub rdbtn_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_1.CheckedChanged
        If rdbtn_1.Checked = True Then
            txt_nota.Clear()
            txt_nota.Text = "Va a necesitar V°B de Venta"
            dgv_productos.Enabled = True
            txt_precio_rollo.ReadOnly = False
        Else
        End If
        If txt_codigo.Text = "DESCTOCOMEDIG" Then
            txt_codigo.Clear()
            txt_descripcion.Clear()
            txt_cant_rollo.Clear()
            txt_area.Clear()
        End If

    End Sub

    Private Sub rdbtn_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_2.CheckedChanged
        If rdbtn_2.Checked = True Then
            txt_codigo.Clear()
            txt_descripcion.Clear()
            txt_area.Clear()
            txt_area.Text = 1
            txt_precio_venta.Clear()
            txt_cant_vendida.Clear()
            txt_medidas.Clear()
            txt_cant_rollo.Clear()
            txt_cant_rollo.Text = 1
            txt_precio_rollo.Clear()
            txt_codigo.Text = "DESCTOCOMEDIG"
            txt_descripcion.Text = "DESCUENTO COMERCIAL DIGITAL"
            txt_nota.Clear()
            txt_total.Clear()
            txt_nota.Text = "Va a necesitar V°B de Venta"
            lv_nc.Items.Clear()
            suma_listview()
            dgv_productos.Enabled = False
            txt_precio_rollo.ReadOnly = False
        Else
            lv_nc.Items.Clear()
            txt_precio_rollo.Clear()
            txt_cant_rollo.Clear()
            txt_total.Clear()
            suma_listview()
        End If

    End Sub

    Private Sub rdbtn_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_3.CheckedChanged
        If rdbtn_3.Checked = True Then
            txt_nota.Clear()
            txt_nota.Text = "Va a necesitar V°B de Logística y Servicio Técnico"
            dgv_productos.Enabled = True
            txt_precio_rollo.ReadOnly = False
        Else
        End If
        If txt_codigo.Text = "DESCTOCOMEDIG" Then
            txt_codigo.Clear()
            txt_descripcion.Clear()
            txt_cant_rollo.Clear()
            txt_area.Clear()
        End If
    End Sub

    Private Sub rdbtn_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_4.CheckedChanged
        If rdbtn_4.Checked = True Then
            txt_nota.Clear()
            txt_nota.Text = "Va a necesitar V°B de Logística"
            dgv_productos.Enabled = True
        Else
        End If
        If txt_codigo.Text = "DESCTOCOMEDIG" Then
            txt_codigo.Clear()
            txt_descripcion.Clear()
            txt_cant_rollo.Clear()
            txt_area.Clear()
        End If
    End Sub

    Private Sub rdbtn_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_5.CheckedChanged
        If rdbtn_5.Checked = True Then
            txt_nota.Clear()
            txt_nota.Text = "Va a necesitar V°B de Logística"
            dgv_productos.Enabled = True
        Else
        End If
        If txt_codigo.Text = "DESCTOCOMEDIG" Then
            txt_codigo.Clear()
            txt_descripcion.Clear()
            txt_cant_rollo.Clear()
            txt_area.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            lv_nc.Items.Remove(lv_nc.SelectedItems(0))
            suma_listview()
        Catch
            MsgBox("SELECCIONE UNA FACTURA VALIDA")
        End Try
    End Sub
    Public Sub suma_listview()
        Dim Total As Double, i As Integer
        Total = 0
        For Each item As ListViewItem In lv_nc.Items
            Total = Total + item.SubItems(3).Text
        Next
        txt_ac.Text = Total.ToString("C")
    End Sub

    Private Sub txt_ac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ac.TextChanged
        Dim iva, cn_iva As Double
        iva = txt_ac.Text * 0.19
        cn_iva = (txt_ac.Text * 1.19)
        txt_iva.Text = iva.ToString("C")
        txt_cn_iva.Text = cn_iva.ToString("C")
    End Sub

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim n_factura, nota_credito, razon_social, rut, accion, error1, observaciones, motivo, codigo, usuario, repetido, status As String
        Dim venta_neta, iva, total, precio_rollo, cantidad_detalle, total_detalle As Double

        If rdbtn_accion1.Checked = True Then
            accion = "Con Monto Pesos"
        ElseIf rdbtn_accion2.Checked = True Then
            accion = "Con Monto Cantidad"
        ElseIf rdbtn_accion3.Checked = True Then
            accion = "Anular"
        ElseIf rdbtn_accion4.Checked = True Then
            accion = "Con Texto"
        Else
            accion = ""
        End If
        If rdbtn_error1.Checked = True Then
            error1 = "Ventas"
        ElseIf rdbtn_error2.Checked = True Then
            error1 = "Cliente"
        ElseIf rdbtn_error3.Checked = True Then
            error1 = "Facturación"
        ElseIf rdbtn_error4.Checked = True Then
            error1 = "Logistica"
        Else
            error1 = ""
        End If
        If rdbtn_1.Checked = True Then
            motivo = "Motivo_1"
        ElseIf rdbtn_2.Checked = True Then
            motivo = "Motivo_2"
        ElseIf rdbtn_3.Checked = True Then
            motivo = "Motivo_3"
        ElseIf rdbtn_4.Checked = True Then
            motivo = "Motivo_4"
        ElseIf rdbtn_5.Checked = True Then
            motivo = "Motivo_5"
        Else
            motivo = ""
        End If
        status = "PENDIENTE"
        If (rdbtn_accion4.Checked = True And txt_corrige.Text <> "" And txt_corrige2.Text <> "" And txt_corrige3.Text <> "") Or (txt_factura.Text <> "" And IsNumeric(txt_ac.Text) And accion <> "" And motivo <> "" And error1 <> "" And txt_iva.Text <> "" And IsNumeric(txt_iva.Text)) Then

            ' Ingresa datos en la tabla folio_nc
            nue_report.insertar3(txt_folio_nc.Text, "0", txt_factura.Text, txt_razon_social.Text, motivo, status, 0)

            n_factura = txt_factura.Text
            nota_credito = txt_folio_nc.Text
            razon_social = txt_razon_social.Text
            rut = txt_rut.Text
            venta_neta = txt_ac.Text
            iva = txt_iva.Text
            total = txt_cn_iva.Text
            observaciones = txt_observaciones.Text
            usuario = txt_usuario.Text

            ' Ingresa datos en la tabla nota_credito
            nue_report.insertar(n_factura, nota_credito, razon_social, rut, accion, error1, observaciones, motivo, venta_neta, iva, total, usuario, CDate(txt_fecha_act.Text), CDate(txt_hora.Text))
            For Each item As ListViewItem In lv_nc.Items
                codigo = item.SubItems(0).Text
                cantidad_detalle = item.SubItems(1).Text
                precio_rollo = item.SubItems(2).Text
                total_detalle = item.SubItems(3).Text
                ' Ingresa datos en la tabla nota_credito_detalle
                nue_report.insertar2(n_factura, nota_credito, codigo, precio_rollo, cantidad_detalle, total_detalle)
            Next
            MessageBox.Show("HA INGRESADO LA NOTA DE CRÉDITO EXITOSAMENTE, SE PROCEDERÁ A CONSULTAR SU VALIDACIÓN")
            limpiar()
            txt_factura.Clear()

            dgv_productos.DataSource = Nothing
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub rdbtn_accion4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn_accion4.CheckedChanged
        If rdbtn_accion4.Checked = True Then
            txt_observaciones.Visible = False
            txt_corrige.Visible = True
            txt_corrige2.Visible = True
            txt_corrige3.Visible = True
            txt_texto.Visible = True
            lbl_corrige1.Visible = True
            lbl_corrige2.Visible = True
            lbl_corrige3.Visible = True
            lbl_corrige4.Visible = True
            lbl_corrige5.Visible = True
        ElseIf rdbtn_accion4.Checked = False Then
            txt_observaciones.Visible = True
            txt_corrige.Visible = False
            txt_corrige2.Visible = False
            txt_corrige3.Visible = False
            txt_texto.Visible = False
            lbl_corrige1.Visible = False
            lbl_corrige2.Visible = False
            lbl_corrige3.Visible = False
            lbl_corrige4.Visible = False
            lbl_corrige5.Visible = False

        End If
    End Sub

    Private Sub txt_corrige_TextChanged(sender As Object, e As EventArgs) Handles txt_corrige.TextChanged
        txt_observaciones.Text = "CORRIGE " + txt_corrige.Text + " |DONDE DICE: " + txt_corrige2.Text + " DEBE DECIR: " + txt_corrige3.Text + ""
        txt_texto.Text = "CORRIGE " + txt_corrige.Text + " DONDE DICE: " + txt_corrige2.Text + " DEBE DECIR: " + txt_corrige3.Text + ""
    End Sub

    Private Sub txt_corrige2_TextChanged(sender As Object, e As EventArgs) Handles txt_corrige2.TextChanged
        txt_observaciones.Text = "CORRIGE " + txt_corrige.Text + " |DONDE DICE: " + txt_corrige2.Text + " DEBE DECIR: " + txt_corrige3.Text + ""
        txt_texto.Text = "CORRIGE " + txt_corrige.Text + " DONDE DICE: " + txt_corrige2.Text + " DEBE DECIR: " + txt_corrige3.Text + ""
    End Sub

    Private Sub txt_corrige3_TextChanged(sender As Object, e As EventArgs) Handles txt_corrige3.TextChanged
        txt_observaciones.Text = "CORRIGE " + txt_corrige.Text + " |DONDE DICE: " + txt_corrige2.Text + " DEBE DECIR: " + txt_corrige3.Text + ""
        txt_texto.Text = "CORRIGE " + txt_corrige.Text + " DONDE DICE: " + txt_corrige2.Text + " DEBE DECIR: " + txt_corrige3.Text + ""
    End Sub

End Class