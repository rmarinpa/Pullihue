Imports System.Globalization
Public Class frm_consulta_np

    ' VARIABLES CLASES
    Dim nueva_guiaDespacho As New clases.guia_despacho

    ' VARIABLES A UTILIZAR
    Dim fechaIn As String
    Dim fechaOut As String


    Private Sub frm_consulta_fac_np_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmb_fechaIn.Text = Today
        cmb_fechaOut.Text = Today
        ActualizarNotasPedidos()
    End Sub


    Private Sub frm_consulta_np_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu_principal.Show()
        'Me.Close()
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        frm_menu_principal.Show()
        Me.Close()
    End Sub


    Private Sub ActualizarNotasPedidos()
        fechaIn = Me.cmb_fechaOut.Value.ToShortDateString
        fechaIn = Format(CDate(fechaIn), "yyyy/MM/dd")
        fechaOut = Me.cmb_fechaIn.Value.ToShortDateString
        fechaOut = Format(CDate(fechaOut), "yyyy/MM/dd")
        Dim col As New DataGridViewButtonColumn
        col.Name = "Visualizar"
        With dgv_notasPedidos
            .DataSource = nueva_guiaDespacho.listar8(fechaIn, fechaOut)
            .Columns.Add(col)

            ' COLUMNAS VISIBLES 
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(10).Visible = False

            ' TITULO DE COMUNAS
            .Columns(1).HeaderText = "N° de Folio"
            .Columns(2).HeaderText = "N° de Factura"
            .Columns(3).HeaderText = "Cliente"
            .Columns(4).HeaderText = "Fecha"
            .Columns(5).HeaderText = "Toma Pedido"
            .Columns(6).HeaderText = "Comuna"
            .Columns(7).HeaderText = "Dirección"
            .Columns(8).HeaderText = "Hora"
            .Columns(9).HeaderText = "Venta Neta"
            .Columns(11).HeaderText = "Visualizar"
            'Exit Sub
            ' FROMATO DE COLUMNAS
            .Columns(1).DefaultCellStyle.Format = "###,###,###"
            .Columns(9).DefaultCellStyle.Format = "###,###,###"

            ' ESPACIO EN DATA CONTENIDO
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(1).Width = 55
            .Columns(2).Width = 50
            .Columns(3).Width = 300
            .Columns(4).Width = 70
            .Columns(5).Width = 90
            .Columns(8).Width = 50
            .Columns(9).Width = 60
            .Columns(11).Width = 40

            ' ALINEACIÓN DATOS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' CABECERAS
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For a As Integer = 0 To .RowCount - 1

                .Rows(a).Cells(11).Value = "Ver"
            Next
        End With

        If nueva_guiaDespacho.descripcion_total(cmb_fechaOut.Text, cmb_fechaIn.Text) <> "" Then
            txt_suma_dia.Text = nueva_guiaDespacho.descripcion_total(cmb_fechaOut.Text, cmb_fechaIn.Text)
            txt_suma_dia.Text = Format(CDbl(txt_suma_dia.Text), "###,##0.")

            txt_suma_pedido.Text = nueva_guiaDespacho.descripcion_pedido(cmb_fechaOut.Text, cmb_fechaIn.Text)
            txt_suma_pedido.Text = Format(CDbl(txt_suma_pedido.Text), "###,##0.")
        Else
            txt_suma_dia.Text = 0
            txt_suma_pedido.Text = 0
        End If

    End Sub


    Private Sub btn_actualizarNotasPedidos_Click(sender As Object, e As EventArgs) Handles btn_actualizarNotasPedidos.Click
        dgv_notasPedidos.Columns.RemoveAt(11)
        ActualizarNotasPedidos()
        If (dgv_notasPedidos.RowCount > 0) Then
            MsgBox("Los datos han sido actualizados.", MsgBoxStyle.Information, "Información.")
        End If
    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        dgv_notasPedidos.Columns.RemoveAt(11)
        If rbt_pedido.Checked Then
            actualizar_dgv_fecha_pedido()
        ElseIf rbt_factura.Checked Then
            actualizar_dgv_fecha_factura()
        End If
        txt_buscar.Text = Nothing
        If (dgv_notasPedidos.RowCount > 0) Then
            MsgBox("Los datos han sido actualizados.", MsgBoxStyle.Information, "Información.")
        End If
    End Sub


    Private Sub dgv_notasPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_notasPedidos.CellClick
        If (dgv_notasPedidos.RowCount = 0) Or (e.RowIndex < 0) Then
            Exit Sub
        End If
        Dim filaNumero As Integer = dgv_notasPedidos.Rows(e.RowIndex).Cells(1).Value
        If e.ColumnIndex = 11 Then
            Folio_ruta = filaNumero
            CR_guia_de_despacho_ruta.Show()
        End If
        Dim numero_folio As Integer = dgv_notasPedidos.CurrentRow.Cells(1).Value.ToString()

        '.AllowUserToOrderColumns = True
        With dgv_pedidoDetalles

            .DataSource = nueva_guiaDespacho.listar7(numero_folio)

            ' COLUMNAS VISIBLES 
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(14).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(31).Visible = False
            .Columns(30).Visible = False
            .Columns(29).Visible = False
            .Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            .Columns(36).Visible = False
            .Columns(37).Visible = False
            .Columns(38).Visible = False
            .Columns(39).Visible = False

            ' TITULOS DE COLUMNAS
            .Columns(10).HeaderText = "Medidas"
            .Columns(13).HeaderText = "Descripción"
            .Columns(15).HeaderText = "Cantidad"
            .Columns(19).HeaderText = "Venta"
            .Columns(28).HeaderText = "Precio Un."

            ' FORMATO DATOS COLUMNAS
            .Columns(14).DefaultCellStyle.Format = "##,###.##"
            .Columns(18).DefaultCellStyle.Format = "##,###."
            .Columns(19).DefaultCellStyle.Format = "##,###."
            .Columns(27).DefaultCellStyle.Format = "##,###."
            .Columns(28).DefaultCellStyle.Format = "##,###."
            .Columns(34).DefaultCellStyle.Format = "###,###,###"


            ' ESPACIO EN DATA CONTENIDO
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.Columns(10).Width = 60
            '.Columns(13).Width = 210
            '.Columns(15).Width = 50
            '.Columns(19).Width = 60
            '.Columns(28).Width = 60

            ' ALINEACIÓN DATOS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' CABECERAS
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' ORDEN DE COLUMNAS (POSICIÓN)
            .Columns(10).DisplayIndex = 3
            .Columns(13).DisplayIndex = 2
            .Columns(15).DisplayIndex = 4
            .Columns(19).DisplayIndex = 8
            .Columns(28).DisplayIndex = 7
            '.Columns(31).DisplayIndex = 1
            '.Columns(18).DisplayIndex = 5
            '.Columns(14).DisplayIndex = 6
            '.Columns(30).DisplayIndex = 9

        End With
        txt_totalNeto.Text = dgv_notasPedidos.CurrentRow.Cells(9).Value.ToString()
        txt_totalNeto.Text = Format(CDbl(txt_totalNeto.Text), "###,##0.")
    End Sub


    Private Sub actualizar_dgv_fecha_pedido()
        Dim col As New DataGridViewButtonColumn
        col.Name = "Visualizar"
        With dgv_notasPedidos
            .DataSource = nueva_guiaDespacho.listar9(txt_buscar.Text)
            .Columns.Add(col)

            ' COLUMNAS VISIBLES 
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(10).Visible = False

            ' TITULOS DE COLUMNAS
            .Columns(1).HeaderText = "N° de Folio"
            .Columns(2).HeaderText = "N° de Factura"
            .Columns(3).HeaderText = "Cliente"
            .Columns(5).HeaderText = "Toma Pedido"
            .Columns(6).HeaderText = "Comuna"
            .Columns(7).HeaderText = "Dirección"
            .Columns(8).HeaderText = "Hora"
            .Columns(9).HeaderText = "Venta Neta"
            .Columns(11).HeaderText = "Visualización"


            ' FORMATO DATOS COLUMNAS
            .Columns(1).DefaultCellStyle.Format = "###,###,###"
            .Columns(9).DefaultCellStyle.Format = "###,###,###"

            ' ESPACIO EN DATA CONTENIDO
            '.AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(1).Width = 70
            .Columns(2).Width = 70
            .Columns(3).Width = 300
            .Columns(5).Width = 90
            .Columns(8).Width = 50
            .Columns(9).Width = 60

            ' ALINEACIÓN DATOS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For a As Integer = 0 To .RowCount - 1
                .Rows(a).Cells(11).Value = "Ver"
            Next
        End With

    End Sub

    Private Sub actualizar_dgv_fecha_factura()
        Dim col As New DataGridViewButtonColumn
        col.Name = "Visualizar"
        With dgv_notasPedidos
            .DataSource = nueva_guiaDespacho.listar10(txt_buscar.Text)
            .Columns.Add(col)

            ' COLUMNAS VISIBLES 
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False

            ' TITULOS DE COLUMNAS
            .Columns(1).HeaderText = "N° de Folio"
            .Columns(2).HeaderText = "N° de Factura"
            .Columns(3).HeaderText = "Cliente"
            .Columns(5).HeaderText = "Toma Pedido"
            .Columns(6).HeaderText = "Comuna"
            .Columns(7).HeaderText = "Dirección"
            .Columns(8).HeaderText = "Hora"
            .Columns(9).HeaderText = "Venta Neta"
            .Columns(11).HeaderText = "Visualización"


            ' FORMATO DATOS COLUMNAS
            .Columns(1).DefaultCellStyle.Format = "###,###,###"
            .Columns(9).DefaultCellStyle.Format = "###,###,###"

            ' ESPACIO EN DATA CONTENIDO
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(1).Width = 70
            .Columns(2).Width = 70
            .Columns(3).Width = 300
            .Columns(5).Width = 90
            .Columns(8).Width = 50
            .Columns(9).Width = 60

            ' ALINEACIÓN DATOS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For a As Integer = 0 To .RowCount - 1
                .Rows(a).Cells(11).Value = "Ver"
            Next
        End With
    End Sub


    Private Sub actualizar_pendientes()
        Dim col As New DataGridViewButtonColumn
        col.Name = "Visualizar"
        With dgv_pendientes
            .DataSource = nueva_guiaDespacho.listar13()
            .Columns.Add(col)

            ' COLUMNAS VISIBLES 
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(10).Visible = False

            ' TITULOS DE COLUMNAS
            .Columns(1).HeaderText = "N° de Folio"
            .Columns(2).HeaderText = "N° de Factura"
            .Columns(3).HeaderText = "Cliente"
            .Columns(4).HeaderText = "Fecha"
            .Columns(5).HeaderText = "Toma Pedido"
            .Columns(6).HeaderText = "Comuna"
            .Columns(7).HeaderText = "Dirección"
            .Columns(8).HeaderText = "Hora"
            .Columns(9).HeaderText = "Venta Neta"

            ' FORMATO DATOS COLUMNAS
            .Columns(1).DefaultCellStyle.Format = "###,###,###"
            .Columns(9).DefaultCellStyle.Format = "###,###,###"

            ' ESPACIO EN DATA CONTENIDO
            .AutoResizeColumns()
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(1).Width = 55
            .Columns(2).Width = 50
            .Columns(3).Width = 300
            .Columns(4).Width = 70
            .Columns(5).Width = 90
            .Columns(8).Width = 50
            .Columns(9).Width = 60

            ' ALINEACIÓN DATOS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For a As Integer = 0 To .RowCount - 1
                .Rows(a).Cells(11).Value = "Ver"
            Next
        End With
    End Sub


    Private Sub btn_actualizarPendientes_Click(sender As Object, e As EventArgs) Handles btn_actualizarPendientes.Click
        If (dgv_pendientes.RowCount - 1 > 0) Then
            dgv_pendientes.Columns.RemoveAt(11)
        End If
        actualizar_pendientes()
        If (dgv_pendientes.RowCount > 0) Then
            MsgBox("Los datos han sido actualizados.", MsgBoxStyle.Information, "Información.")
        End If
    End Sub


    Private Sub txt_totalNeto_TextChanged(sender As Object, e As System.EventArgs) Handles txt_totalNeto.TextChanged
        txt_iva.Text = FormatNumber(CInt(txt_totalNeto.Text) * 0.19, 0)
        txt_total.Text = FormatNumber(CInt(txt_totalNeto.Text) + CInt(txt_iva.Text), 0)
    End Sub

    Private Sub dgv_pendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellClick
        If (dgv_pendientes.RowCount = 0) Or (e.RowIndex < 0) Then
            Exit Sub
        End If
        Dim filaNumero As Integer = dgv_pendientes.Rows(e.RowIndex).Cells(1).Value
        If e.ColumnIndex = 11 Then
            Folio_ruta = filaNumero
            CR_guia_de_despacho_ruta.Show()
        End If
        Dim numero_folio As Integer = dgv_pendientes.CurrentRow.Cells(1).Value.ToString()
        'buscar = 1
        With dgv_pedidoDetalles
            .DataSource = nueva_guiaDespacho.listar7(numero_folio)
            '.AllowUserToOrderColumns = True

            ' COLUMNAS VISIBLES 
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(14).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(31).Visible = False
            .Columns(30).Visible = False
            .Columns(29).Visible = False
            .Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            .Columns(36).Visible = False
            .Columns(37).Visible = False
            .Columns(38).Visible = False
            .Columns(39).Visible = False

            ' TITULOS DE COLUMNAS
            .Columns(10).HeaderText = "Medidas"
            .Columns(13).HeaderText = "Descripción"
            .Columns(15).HeaderText = "Cantidad"
            .Columns(19).HeaderText = "Venta"
            .Columns(28).HeaderText = "Precio Un."

            ' FORMATO DATOS COLUMNAS
            .Columns(14).DefaultCellStyle.Format = "##,###.##"
            .Columns(18).DefaultCellStyle.Format = "##,###."
            .Columns(19).DefaultCellStyle.Format = "##,###."
            .Columns(27).DefaultCellStyle.Format = "##,###."
            .Columns(28).DefaultCellStyle.Format = "##,###."
            .Columns(34).DefaultCellStyle.Format = "###,###,###"

            ' ESPACIO EN DATA CONTENIDO
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(1).Width = 200
            .Columns(10).Width = 60
            .Columns(13).Width = 210
            .Columns(14).Width = 40
            .Columns(15).Width = 50
            .Columns(18).Width = 60
            .Columns(19).Width = 60
            .Columns(28).Width = 60
            .Columns(31).Width = 65
            .Columns(30).Width = 50
            .Columns(34).Width = 50

            ' ALINEACIÓN DATOS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' ORDEN DE COLUMNAS (POSICIÓN)
            .Columns(10).DisplayIndex = 3
            .Columns(13).DisplayIndex = 2
            .Columns(14).DisplayIndex = 6
            .Columns(15).DisplayIndex = 4
            .Columns(18).DisplayIndex = 5
            .Columns(19).DisplayIndex = 8
            .Columns(28).DisplayIndex = 7
            .Columns(30).DisplayIndex = 9
            .Columns(31).DisplayIndex = 1
        End With

        txt_totalNeto.Text = dgv_pendientes.CurrentRow.Cells(9).Value.ToString()
        txt_totalNeto.Text = Format(CDbl(txt_totalNeto.Text), "###,##0.")
    End Sub
End Class