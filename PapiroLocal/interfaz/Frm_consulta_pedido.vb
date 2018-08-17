Imports System.Globalization
Public Class Frm_consulta_pedido

    Dim nue_cur As New clases.guia_despacho
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim buscar As Integer

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        dtp_fecha_in.Text = Today
        txt_fecha.Text = Today
        txt_pedido.ReadOnly = True
        txt_total.ReadOnly = True
        txt_iva.ReadOnly = True
        txt_total2.ReadOnly = True
        txt_fecha.Text = DateTime.Now
        actualizar_dgv_fecha()
        'actualizar_dgv_fecha_ejecutivos()
        '   System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        '   System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        '    System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        '   System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        '   System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        '   System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Sub actualizar_dgv()
        dgv_despachos.DataSource = nue_cur.listar6()
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(2).Visible = False
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(4).Width = 50
        dgv_despachos.Columns(4).HeaderText = "Hora"
        dgv_despachos.Columns(4).DefaultCellStyle.Format = "hh:mm"
        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        Dim numero_folio As Double
        buscar = 0
        numero_folio = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        dgv_despachos2.DataSource = nue_cur.listar7(numero_folio)
        dgv_despachos2.Columns(0).Visible = False
        dgv_despachos2.AllowUserToOrderColumns = True
        dgv_despachos2.Columns(1).Visible = False
        dgv_despachos2.Columns(1).Width = 200
        dgv_despachos2.Columns(2).Visible = False
        dgv_despachos2.Columns(3).Visible = False
        dgv_despachos2.Columns(4).Visible = False
        dgv_despachos2.Columns(5).Visible = False
        dgv_despachos2.Columns(6).Visible = False
        dgv_despachos2.Columns(7).Visible = False
        dgv_despachos2.Columns(8).Visible = False
        dgv_despachos2.Columns(9).Visible = False
        dgv_despachos2.Columns(10).HeaderText = "Medidas"
        dgv_despachos2.Columns(11).Visible = False
        dgv_despachos2.Columns(12).Visible = False
        dgv_despachos2.Columns(13).HeaderText = "Descripción"
        dgv_despachos2.Columns(13).Width = 210
        dgv_despachos2.Columns(14).Visible = False
        dgv_despachos2.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_despachos2.Columns(15).HeaderText = "Cantidad"
        dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(16).Visible = False
        dgv_despachos2.Columns(17).Visible = False
        dgv_despachos2.Columns(18).Visible = False
        dgv_despachos2.Columns(18).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(19).HeaderText = "Venta"
        dgv_despachos2.Columns(19).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(20).Visible = False
        dgv_despachos2.Columns(21).Visible = False
        dgv_despachos2.Columns(22).Visible = False
        dgv_despachos2.Columns(23).Visible = False
        dgv_despachos2.Columns(24).Visible = False
        dgv_despachos2.Columns(25).Visible = False
        dgv_despachos2.Columns(26).Visible = False
        dgv_despachos2.Columns(27).Visible = False
        dgv_despachos2.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(28).HeaderText = "Precio Un."
        dgv_despachos2.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(31).Visible = False
        dgv_despachos2.Columns(30).Visible = False
        dgv_despachos2.Columns(29).Visible = False
        dgv_despachos2.Columns(32).Visible = False
        dgv_despachos2.Columns(33).Visible = False
        dgv_despachos2.Columns(34).Visible = False
        dgv_despachos2.Columns(35).Visible = False
        dgv_despachos2.Columns(36).Visible = False
        dgv_despachos2.Columns(37).Visible = False
        dgv_despachos2.Columns(38).Visible = False
        dgv_despachos2.Columns(39).Visible = False
        dgv_despachos2.Columns(34).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos2.Columns(31).DisplayIndex = 1
        dgv_despachos2.Columns(13).DisplayIndex = 2
        dgv_despachos2.Columns(10).DisplayIndex = 3
        dgv_despachos2.Columns(15).DisplayIndex = 4
        dgv_despachos2.Columns(18).DisplayIndex = 5
        dgv_despachos2.Columns(14).DisplayIndex = 6
        dgv_despachos2.Columns(28).DisplayIndex = 7
        dgv_despachos2.Columns(19).DisplayIndex = 8
        dgv_despachos2.Columns(30).DisplayIndex = 9
        dgv_despachos2.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(30).Width = 50
        dgv_despachos2.Columns(34).Width = 50
        dgv_despachos2.Columns(10).Width = 60
        dgv_despachos2.Columns(15).Width = 50
        dgv_despachos2.Columns(28).Width = 60
        dgv_despachos2.Columns(31).Width = 65
        dgv_despachos2.Columns(18).Width = 60
        dgv_despachos2.Columns(19).Width = 60
        dgv_despachos2.Columns(14).Width = 40
        dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        txt_pedido.Clear()
        txt_factura.Clear()
        txt_pedido.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        If dgv_despachos.CurrentRow.Cells(2).Value.ToString() <> "" Then
            txt_factura.Text = dgv_despachos.CurrentRow.Cells(2).Value.ToString()
        Else
        End If
        txt_id.Text = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
        txt_total.Text = dgv_despachos.CurrentRow.Cells(9).Value.ToString()
        txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")

    End Sub


    Private Sub dgv_despachos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellContentDoubleClick

    End Sub

    Private Sub dgv_despachos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellContentClick

    End Sub

    Private Sub dgv_despachos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellDoubleClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv_fecha()

        'actualizar_dgv_fecha_ejecutivos()
    End Sub
    Sub actualizar_dgv_fecha()
        Dim fecha As String
        Dim fecha2 As String
        fecha = Me.txt_fecha.Value.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")
        fecha2 = Me.dtp_fecha_in.Value.ToShortDateString
        fecha2 = Format(CDate(fecha2), "yyyy/MM/dd")
        dgv_despachos.DataSource = nue_cur.listar8(fecha, fecha2)
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(2).HeaderText = "N° de Factura"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(1).Width = 55
        dgv_despachos.Columns(2).Width = 50
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(4).HeaderText = "Fecha"
        dgv_despachos.Columns(4).Width = 70
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"
        dgv_despachos.Columns(10).Visible = False
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).Width = 60
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        If nue_cur.descripcion_total(txt_fecha.Text, dtp_fecha_in.Text) <> "" Then
            txt_suma_dia.Text = nue_cur.descripcion_total(txt_fecha.Text, dtp_fecha_in.Text)
            txt_suma_dia.Text = Format(CDbl(txt_suma_dia.Text), "###,##0.")

            txt_suma_pedido.Text = nue_cur.descripcion_pedido(txt_fecha.Text, dtp_fecha_in.Text)
            txt_suma_pedido.Text = Format(CDbl(txt_suma_pedido.Text), "###,##0.")
        Else
            txt_suma_dia.Text = 0
            txt_suma_pedido.Text = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_factura.Text <> "" Then
            nue_cur.modificar(txt_id.Text, txt_factura.Text)
            actualizar_dgv_fecha()
            If buscar = 1 Then
                actualizar_pendientes()
            End If
        Else
            MessageBox.Show("FALTA LLENAR EL CAMPO DEL N° DE FACTURA")
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If chk_pedido.Checked = True Then
            actualizar_dgv_fecha_pedido()
        ElseIf chk_factura.Checked = True Then
            actualizar_dgv_fecha_factura()
        End If
    End Sub

    Private Sub chk_factura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_factura.CheckedChanged
        If chk_factura.Checked = True Then
            chk_pedido.Checked = False
        Else
            chk_pedido.Checked = True
        End If
    End Sub

    Private Sub chk_pedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pedido.CheckedChanged
        If chk_pedido.Checked = True Then
            chk_factura.Checked = False
        Else
            chk_factura.Checked = True
        End If
    End Sub
    Sub actualizar_dgv_fecha_pedido()
        dgv_despachos.DataSource = nue_cur.listar9(txt_buscar.Text)
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(2).HeaderText = "N° de Factura"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        'dgv_despachos.Columns(4).HeaderText = "Fecha"
        'dgv_despachos.Columns(4).Width = 50
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"
        dgv_despachos.Columns(10).Visible = False
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).Width = 60
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Sub actualizar_dgv_fecha_factura()
        dgv_despachos.DataSource = nue_cur.listar10(txt_buscar.Text)
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(2).HeaderText = "N° de Factura"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        ' dgv_despachos.Columns(4).HeaderText = "Fecha"
        ' dgv_despachos.Columns(4).Width = 50
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).Width = 60
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CR_Resumen_ejecutivos.Show()
    End Sub

    Private Sub btn_informe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe1.Click
        If txt_pedido.Text <> "" Then
            CR_guia_de_despacho3.Show()
        Else
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
    Sub actualizar_pendientes()
        dgv_pendientes.DataSource = nue_cur.listar13()
        dgv_pendientes.Columns(0).Visible = False
        dgv_pendientes.Columns(1).HeaderText = "N° de Folio"
        dgv_pendientes.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_pendientes.Columns(2).HeaderText = "N° de Factura"
        dgv_pendientes.Columns(3).HeaderText = "Cliente"
        dgv_pendientes.Columns(1).Width = 55
        dgv_pendientes.Columns(2).Width = 50
        dgv_pendientes.Columns(3).Width = 300
        dgv_pendientes.Columns(4).HeaderText = "Fecha"
        dgv_pendientes.Columns(4).Width = 70
        dgv_pendientes.Columns(5).HeaderText = "Toma Pedido"
        dgv_pendientes.Columns(6).HeaderText = "Comuna"
        dgv_pendientes.Columns(7).HeaderText = "Dirección"
        dgv_pendientes.Columns(5).Width = 90
        dgv_pendientes.Columns(6).Visible = False
        dgv_pendientes.Columns(7).Visible = False
        dgv_pendientes.Columns(8).Width = 50
        dgv_pendientes.Columns(8).HeaderText = "Hora"
        dgv_pendientes.Columns(9).HeaderText = "Venta Neta"
        dgv_pendientes.Columns(9).DefaultCellStyle.Format = "###,###,###"
        dgv_pendientes.Columns(9).Width = 60
        dgv_pendientes.Columns(10).Visible = False
        dgv_pendientes.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        actualizar_pendientes()
    End Sub

    Private Sub dgv_pendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellClick
        Dim numero_folio As Double
        buscar = 1
        numero_folio = dgv_pendientes.CurrentRow.Cells(1).Value.ToString()
        dgv_despachos2.DataSource = nue_cur.listar7(numero_folio)
        dgv_despachos2.Columns(0).Visible = False
        dgv_despachos2.AllowUserToOrderColumns = True
        dgv_despachos2.Columns(1).Visible = False
        dgv_despachos2.Columns(1).Width = 200
        dgv_despachos2.Columns(2).Visible = False
        dgv_despachos2.Columns(3).Visible = False
        dgv_despachos2.Columns(4).Visible = False
        dgv_despachos2.Columns(5).Visible = False
        dgv_despachos2.Columns(6).Visible = False
        dgv_despachos2.Columns(7).Visible = False
        dgv_despachos2.Columns(8).Visible = False
        dgv_despachos2.Columns(9).Visible = False
        dgv_despachos2.Columns(10).HeaderText = "Medidas"
        dgv_despachos2.Columns(11).Visible = False
        dgv_despachos2.Columns(12).Visible = False
        dgv_despachos2.Columns(13).HeaderText = "Descripción"
        dgv_despachos2.Columns(13).Width = 210
        dgv_despachos2.Columns(14).Visible = False
        dgv_despachos2.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_despachos2.Columns(15).HeaderText = "Cantidad"
        dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(16).Visible = False
        dgv_despachos2.Columns(17).Visible = False
        dgv_despachos2.Columns(18).Visible = False
        dgv_despachos2.Columns(18).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(19).HeaderText = "Venta"
        dgv_despachos2.Columns(19).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(20).Visible = False
        dgv_despachos2.Columns(21).Visible = False
        dgv_despachos2.Columns(22).Visible = False
        dgv_despachos2.Columns(23).Visible = False
        dgv_despachos2.Columns(24).Visible = False
        dgv_despachos2.Columns(25).Visible = False
        dgv_despachos2.Columns(26).Visible = False
        dgv_despachos2.Columns(27).Visible = False
        dgv_despachos2.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(28).HeaderText = "Precio Un."
        dgv_despachos2.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(31).Visible = False
        dgv_despachos2.Columns(30).Visible = False
        dgv_despachos2.Columns(29).Visible = False
        dgv_despachos2.Columns(32).Visible = False
        dgv_despachos2.Columns(33).Visible = False
        dgv_despachos2.Columns(34).Visible = False
        dgv_despachos2.Columns(35).Visible = False
        dgv_despachos2.Columns(36).Visible = False
        dgv_despachos2.Columns(37).Visible = False
        dgv_despachos2.Columns(38).Visible = False
        dgv_despachos2.Columns(39).Visible = False
        dgv_despachos2.Columns(34).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos2.Columns(31).DisplayIndex = 1
        dgv_despachos2.Columns(13).DisplayIndex = 2
        dgv_despachos2.Columns(10).DisplayIndex = 3
        dgv_despachos2.Columns(15).DisplayIndex = 4
        dgv_despachos2.Columns(18).DisplayIndex = 5
        dgv_despachos2.Columns(14).DisplayIndex = 6
        dgv_despachos2.Columns(28).DisplayIndex = 7
        dgv_despachos2.Columns(19).DisplayIndex = 8
        dgv_despachos2.Columns(30).DisplayIndex = 9
        dgv_despachos2.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(30).Width = 50
        dgv_despachos2.Columns(34).Width = 50
        dgv_despachos2.Columns(10).Width = 60
        dgv_despachos2.Columns(15).Width = 50
        dgv_despachos2.Columns(28).Width = 60
        dgv_despachos2.Columns(31).Width = 65
        dgv_despachos2.Columns(18).Width = 60
        dgv_despachos2.Columns(19).Width = 60
        dgv_despachos2.Columns(14).Width = 40
        dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        txt_pedido.Clear()
        txt_factura.Clear()
        txt_pedido.Text = dgv_pendientes.CurrentRow.Cells(1).Value.ToString()
        If dgv_pendientes.CurrentRow.Cells(2).Value.ToString() <> "" Then
            txt_factura.Text = dgv_pendientes.CurrentRow.Cells(2).Value.ToString()
        Else
        End If
        txt_id.Text = dgv_pendientes.CurrentRow.Cells(0).Value.ToString()
        txt_total.Text = dgv_pendientes.CurrentRow.Cells(9).Value.ToString()
        txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
        'actualizar_dgv_cliente()

        'If dgv_clientes.Rows(0).Cells(3).Value.ToString() = dgv_pendientes.CurrentRow.Cells(7).Value.ToString() Then
        '    txt_observacion.Text = dgv_pendientes.CurrentRow.Cells(10).Value.ToString()
        'Else
        '    If dgv_pendientes.CurrentRow.Cells(10).Value.ToString() <> "" Then
        '        txt_observacion.Text = "DIRECCIÓN DE DESPACHO: " & dgv_pendientes.CurrentRow.Cells(7).Value.ToString() & " COMUNA: " & dgv_pendientes.CurrentRow.Cells(6).Value.ToString() & " / " & dgv_pendientes.CurrentRow.Cells(10).Value.ToString()
        '    Else
        '        txt_observacion.Text = "DIRECCIÓN DE DESPACHO: " & dgv_pendientes.CurrentRow.Cells(7).Value.ToString() & " COMUNA: " & dgv_pendientes.CurrentRow.Cells(6).Value.ToString()
        '    End If
        'End If
    End Sub

    Private Sub dgv_pendientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pendientes.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_autorizaciones_Click(sender As Object, e As EventArgs) Handles btn_autorizaciones.Click
        CR_resumen_autorizaciones.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CR_Resumen_ejecutivos2.Show()
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        txt_iva.Text = FormatNumber(txt_total.Text * 0.19, 0)
        txt_total2.Text = FormatNumber(CInt(txt_total.Text) + CInt(txt_iva.Text), 0)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CR_Rutas.Show()
    End Sub
End Class

