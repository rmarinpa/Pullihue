Imports System.Globalization
Public Class frm_retiro_documentos_2

    Dim nue_cur As New clases.Registro_pagos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'actualizar_facturas()
        txt_ejecutivo.Text = Nombre_Obra
        txt_ejecutivo.Enabled = False
        txt_cliente.Enabled = False
        txt_rut.Enabled = False
        txt_fecha.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
        txt_comuna2.ReadOnly = True
        txt_direccion_despacho2.ReadOnly = True
        txt_comuna2.ReadOnly = True
        txt_direccion_despacho3.ReadOnly = True
        txt_comuna3.ReadOnly = True
        If variable_retiro = 1 Then
            txt_fecha.Text = Frm_ventas_mod.txt_fecha_act.Text
            txt_cliente.Text = Frm_ventas_mod.cmb_cliente.Text
            txt_rut.Text = Frm_ventas_mod.txt_rut.Text
            txt_direccion_despacho2.Text = Frm_ventas_mod.txt_direccion_despacho.Text
            txt_comuna2.Text = Frm_ventas_mod.txt_comuna.Text
            txt_direccion_despacho3.Text = Frm_ventas_mod.txt_direccion_1.Text
            txt_comuna3.Text = Frm_ventas_mod.txt_comuna1.Text
        Else
            txt_fecha.Text = frm_registro_llamada.txt_fecha.Text
            txt_cliente.Text = frm_registro_llamada.txt_cliente.Text
            txt_rut.Text = frm_registro_llamada.txt_rut.Text
            txt_direccion_despacho2.Text = frm_registro_llamada.txt_direccion_facturacion.Text
            txt_comuna2.Text = frm_registro_llamada.txt_comuna_facturacion.Text
            txt_direccion_despacho3.Text = frm_registro_llamada.txt_direccion_despacho.Text
            txt_comuna3.Text = frm_registro_llamada.txt_comuna_despacho.Text
        End If
        rbtn_1.Checked = True
        actualizar_dgv()
    End Sub

    Sub actualizar_dgv()
        dgv_facturas.DataSource = nue_cur.listar5(txt_rut.Text)
        dgv_facturas.Columns(0).HeaderText = "Número Factura"
        dgv_facturas.Columns(1).Visible = False
        dgv_facturas.Columns(2).Visible = False
        dgv_facturas.Columns(3).HeaderText = "Fecha"
        dgv_facturas.Columns(4).Visible = False
        dgv_facturas.Columns(5).HeaderText = "Saldo"
        dgv_facturas.Columns(1).Width = 200
        dgv_facturas.Columns(6).Visible = False

        dgv_facturas.Columns(2).DefaultCellStyle.Format = "##,###."
        dgv_facturas.Columns(4).DefaultCellStyle.Format = "##,###."
        dgv_facturas.Columns(5).DefaultCellStyle.Format = "##,###."

        dgv_facturas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_clientes_busqueda_pago.Show()
    End Sub
    Private Sub txt_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cliente.TextChanged
        'actualizar_dgv()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub dgv_facturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas.CellDoubleClick
        Dim lista As ListViewItem = New ListViewItem(dgv_facturas.CurrentRow.Cells(0).Value.ToString())
        lista.SubItems.Add(FormatCurrency(dgv_facturas.CurrentRow.Cells(5).Value, 0))
        lvpago.Items.Add(lista)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim direccion, comuna, cliente, rut, ejecutivo, horario, contacto, factura As String
        Dim fecha As Date
        Dim monto As Double
        Dim folio As Integer

        If (rbtn_1.Checked = True) Then
            direccion = txt_direccion_despacho2.Text
            comuna = txt_comuna2.Text
        ElseIf (rbtn_2.Checked = True) Then
            direccion = txt_direccion_despacho3.Text
            comuna = txt_comuna3.Text
        ElseIf (rbtn_3.Checked = True) Then
            direccion = txt_direccion_despacho4.Text
            comuna = txt_comuna4.Text
        End If
        cliente = txt_cliente.Text
        rut = txt_rut.Text
        ejecutivo = txt_ejecutivo.Text
        contacto = txt_contacto.Text
        horario = txt_horario.Text
        folio = nue_cur.buscar_folio() + 1
        txt_folio2.Text = folio
        If (txt_ejecutivo.Text <> "" And txt_cliente.Text <> "" And txt_rut.Text <> "" And direccion <> "" And comuna <> "" And txt_contacto.Text <> "" And txt_horario.Text <> "") Then
            For Each item As ListViewItem In lvpago.Items
                factura = item.Text
                monto = item.SubItems(1).Text
                nue_cur.insertar2(folio, cliente, rut, CDate(txt_fecha.Text), ejecutivo, factura, monto, contacto, horario, direccion, comuna)
            Next
            CR_orden_retiro.Show()
            Me.Close()

        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If

    End Sub

    Private Sub lvpago_DoubleClick(sender As Object, e As EventArgs) Handles lvpago.DoubleClick
        lvpago.Items.Remove(lvpago.SelectedItems(0))
    End Sub

End Class