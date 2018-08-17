Imports System.Globalization
Public Class Frm_rutas
    Dim nue_report As New clases.Ruta
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double
    Dim retiros As Integer

    Sub actualizar_dgv_pedido()
        dgv_autorizacion.DataSource = nue_report.listar8(txt_pedido.Text)
        dgv_autorizacion.Columns(0).HeaderText = "N° Ruta"
        dgv_autorizacion.Columns(1).HeaderText = "N° Pedido"
        dgv_autorizacion.Columns(2).HeaderText = "N° Factura"
        dgv_autorizacion.Columns(3).HeaderText = "Cliente"
        dgv_autorizacion.Columns(4).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(5).HeaderText = "Chofer"
        dgv_autorizacion.Columns(6).HeaderText = "Camioneta"
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).HeaderText = "Fecha Pedido"
        dgv_autorizacion.Columns(9).HeaderText = "Hora de Pedido"
        dgv_autorizacion.Columns(10).HeaderText = "Hora de Salida"
        dgv_autorizacion.Columns(11).HeaderText = "Hora Llegada Ruta"
        dgv_autorizacion.Columns(12).Visible = False

        dgv_autorizacion.Columns(0).Width = 60
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 60
        dgv_autorizacion.Columns(3).Width = 280
        dgv_autorizacion.Columns(4).Width = 90
        dgv_autorizacion.Columns(5).Width = 130
        dgv_autorizacion.Columns(6).Width = 130
        dgv_autorizacion.Columns(8).Width = 70
        dgv_autorizacion.Columns(9).Width = 60
        dgv_autorizacion.Columns(10).Width = 60
        dgv_autorizacion.Columns(11).Width = 60

    End Sub
    Sub actualizar_dgv_factura()
        dgv_autorizacion.DataSource = nue_report.listar9(txt_factura.Text)
        dgv_autorizacion.Columns(0).HeaderText = "N° Ruta"
        dgv_autorizacion.Columns(1).HeaderText = "N° Pedido"
        dgv_autorizacion.Columns(2).HeaderText = "N° Factura"
        dgv_autorizacion.Columns(3).HeaderText = "Cliente"
        dgv_autorizacion.Columns(4).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(5).HeaderText = "Chofer"
        dgv_autorizacion.Columns(6).HeaderText = "Camioneta"
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).HeaderText = "Fecha Pedido"
        dgv_autorizacion.Columns(9).HeaderText = "Hora de Pedido"
        dgv_autorizacion.Columns(10).HeaderText = "Hora de Salida"
        dgv_autorizacion.Columns(11).HeaderText = "Hora Llegada Ruta"
        dgv_autorizacion.Columns(12).Visible = False

        dgv_autorizacion.Columns(0).Width = 60
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 60
        dgv_autorizacion.Columns(3).Width = 280
        dgv_autorizacion.Columns(4).Width = 90
        dgv_autorizacion.Columns(5).Width = 130
        dgv_autorizacion.Columns(6).Width = 130
        dgv_autorizacion.Columns(8).Width = 70
        dgv_autorizacion.Columns(9).Width = 60
        dgv_autorizacion.Columns(10).Width = 60
        dgv_autorizacion.Columns(11).Width = 60
    End Sub
    Sub actualizar_dgv_ruta()
        dgv_autorizacion.DataSource = nue_report.listar10(txt_ruta.Text)
        dgv_autorizacion.Columns(0).HeaderText = "N° Ruta"
        dgv_autorizacion.Columns(1).HeaderText = "N° Pedido"
        dgv_autorizacion.Columns(2).HeaderText = "N° Factura"
        dgv_autorizacion.Columns(3).HeaderText = "Cliente"
        dgv_autorizacion.Columns(4).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(5).HeaderText = "Chofer"
        dgv_autorizacion.Columns(6).HeaderText = "Camioneta"
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).HeaderText = "Fecha Pedido"
        dgv_autorizacion.Columns(9).HeaderText = "Hora de Pedido"
        dgv_autorizacion.Columns(10).HeaderText = "Hora de Salida"
        dgv_autorizacion.Columns(11).HeaderText = "Hora Llegada Ruta"
        dgv_autorizacion.Columns(12).Visible = False

        dgv_autorizacion.Columns(0).Width = 60
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 60
        dgv_autorizacion.Columns(3).Width = 280
        dgv_autorizacion.Columns(4).Width = 90
        dgv_autorizacion.Columns(5).Width = 130
        dgv_autorizacion.Columns(6).Width = 130
        dgv_autorizacion.Columns(8).Width = 70
        dgv_autorizacion.Columns(9).Width = 60
        dgv_autorizacion.Columns(10).Width = 60
        dgv_autorizacion.Columns(11).Width = 60
    End Sub
    Sub actualizar_dgv_fecha()
        Dim fecha As String
        fecha = Me.dtp_fecha.Value.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")
        dgv_autorizacion.DataSource = nue_report.listar11(fecha)
        dgv_autorizacion.Columns(0).HeaderText = "N° Ruta"
        dgv_autorizacion.Columns(1).HeaderText = "N° Pedido"
        dgv_autorizacion.Columns(2).HeaderText = "N° Factura"
        dgv_autorizacion.Columns(3).HeaderText = "Cliente"
        dgv_autorizacion.Columns(4).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(5).HeaderText = "Chofer"
        dgv_autorizacion.Columns(6).HeaderText = "Camioneta"
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).HeaderText = "Fecha Pedido"
        dgv_autorizacion.Columns(9).HeaderText = "Hora de Pedido"
        dgv_autorizacion.Columns(10).HeaderText = "Hora de Salida"
        dgv_autorizacion.Columns(11).HeaderText = "Hora Llegada Ruta"
        dgv_autorizacion.Columns(12).Visible = False

        dgv_autorizacion.Columns(0).Width = 60
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 60
        dgv_autorizacion.Columns(3).Width = 280
        dgv_autorizacion.Columns(4).Width = 90
        dgv_autorizacion.Columns(5).Width = 130
        dgv_autorizacion.Columns(6).Width = 130
        dgv_autorizacion.Columns(8).Width = 70
        dgv_autorizacion.Columns(9).Width = 60
        dgv_autorizacion.Columns(10).Width = 60
        dgv_autorizacion.Columns(11).Width = 60

    End Sub
    Private Sub Frm_visualizar_autorizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(200, 10)
        'With dtp_fecha
        '    .Format = DateTimePickerFormat.Custom
        '    .CustomFormat = " "
        'End With
        'dtp_fecha.Format = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar_dgv_pedido()
    End Sub

    Private Sub btn_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pedido.Click
        If txt_pedido.Text <> "" And IsNumeric(txt_pedido.Text) Then
            actualizar_dgv_pedido()
        Else
            MessageBox.Show("ESCRIBE UN REGISTRO VALIDO")
        End If
    End Sub

    Private Sub btn_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_factura.Click
        If txt_factura.Text <> "" And IsNumeric(txt_factura.Text) Then
            actualizar_dgv_factura()
            retiros = 4
            actualizar_retiros()
        Else
            MessageBox.Show("ESCRIBE UN REGISTRO VALIDO")
        End If
    End Sub

    Private Sub btn_ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ruta.Click
        If txt_ruta.Text <> "" And IsNumeric(txt_ruta.Text) Then
            actualizar_dgv_ruta()
            retiros = 1
            actualizar_retiros()
        Else
            MessageBox.Show("ESCRIBE UN REGISTRO VALIDO")
        End If
    End Sub

    Private Sub btn_fecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fecha.Click
        If dtp_fecha.Text <> "" Then
            actualizar_dgv_fecha()
            retiros = 2
            actualizar_retiros()
        Else
            MessageBox.Show("ESCRIBE UN REGISTRO VALIDO")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_cliente.Text <> "" Then
            actualizar_dgv_cliente()
            retiros = 5
            actualizar_retiros()
        Else
            MessageBox.Show("ESCRIBE UN REGISTRO VALIDO")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_ruta_clientes_busqueda.Show()
    End Sub
    Sub actualizar_dgv_cliente()
        dgv_autorizacion.DataSource = nue_report.listar12(txt_cliente.Text)
        dgv_autorizacion.Columns(0).HeaderText = "N° Ruta"
        dgv_autorizacion.Columns(1).HeaderText = "N° Pedido"
        dgv_autorizacion.Columns(2).HeaderText = "N° Factura"
        dgv_autorizacion.Columns(3).HeaderText = "Cliente"
        dgv_autorizacion.Columns(4).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(5).HeaderText = "Chofer"
        dgv_autorizacion.Columns(6).HeaderText = "Camioneta"
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).HeaderText = "Fecha Pedido"
        dgv_autorizacion.Columns(9).HeaderText = "Hora de Pedido"
        dgv_autorizacion.Columns(10).HeaderText = "Hora de Salida"
        dgv_autorizacion.Columns(11).HeaderText = "Hora Llegada Ruta"
        dgv_autorizacion.Columns(12).Visible = False

        dgv_autorizacion.Columns(0).Width = 60
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 60
        dgv_autorizacion.Columns(3).Width = 280
        dgv_autorizacion.Columns(4).Width = 90
        dgv_autorizacion.Columns(5).Width = 130
        dgv_autorizacion.Columns(6).Width = 130
        dgv_autorizacion.Columns(8).Width = 70
        dgv_autorizacion.Columns(9).Width = 60
        dgv_autorizacion.Columns(10).Width = 60
        dgv_autorizacion.Columns(11).Width = 60

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If dtp_fecha.Text <> "" And txt_retiro.Text <> "" Then
            retiros = 6
            actualizar_retiros()
        Else
            MessageBox.Show("ESCRIBE UN REGISTRO VALIDO")
        End If
    End Sub

    Sub actualizar_retiros()
        If retiros = 1 Then
            dgv_retiros.DataSource = nue_report.listar18(txt_ruta.Text)
        ElseIf retiros = 2 Then
            Dim fecha2 As String
            fecha2 = Me.dtp_fecha.Value.ToShortDateString
            fecha2 = Format(CDate(fecha2), "yyyy/MM/dd")
            dgv_retiros.DataSource = nue_report.listar19(fecha2)
        ElseIf retiros = 4 Then
            dgv_retiros.DataSource = nue_report.listar20(txt_factura.Text)
        ElseIf retiros = 5 Then
            dgv_retiros.DataSource = nue_report.listar21(txt_cliente.Text)
        ElseIf retiros = 6 Then
            dgv_retiros.DataSource = nue_report.listar15(txt_retiro.Text)
        End If
        dgv_retiros.Columns(0).HeaderText = "N° Ruta"
        dgv_retiros.Columns(1).HeaderText = "N° Retiro"
        dgv_retiros.Columns(2).HeaderText = "N° Factura"
        dgv_retiros.Columns(3).HeaderText = "Cliente"
        dgv_retiros.Columns(4).HeaderText = "Toma Retiro"
        dgv_retiros.Columns(5).HeaderText = "Chofer"
        dgv_retiros.Columns(6).HeaderText = "Camioneta"
        dgv_retiros.Columns(7).HeaderText = "Fecha Retiro"
        dgv_retiros.Columns(8).HeaderText = "Fecha Ruta"
        dgv_retiros.Columns(9).HeaderText = "Hora Ruta"
        dgv_retiros.Columns(10).Visible = False

        dgv_retiros.Columns(0).Width = 60
        dgv_retiros.Columns(1).Width = 60
        dgv_retiros.Columns(2).Width = 60
        dgv_retiros.Columns(3).Width = 280
        dgv_retiros.Columns(4).Width = 90
        dgv_retiros.Columns(5).Width = 130
        dgv_retiros.Columns(6).Width = 130
        dgv_retiros.Columns(8).Width = 70
        dgv_retiros.Columns(7).Width = 70
        dgv_retiros.Columns(9).Width = 60
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If (txt_cliente.Text.Trim <> Nothing Or txt_pedido.Text.Trim <> Nothing Or txt_ruta.Text.Trim <> Nothing Or chb_fecha.Checked Or txt_documento.Text.Trim <> Nothing) Then
                Dim cliente As String = txt_cliente.Text.Trim
                Dim pedido As Integer
                If (txt_pedido.Text.Trim <> "") Then
                    pedido = CInt(txt_pedido.Text.Trim)
                End If
                'Dim pedido As Integer = CInt(txt_pedido.Text.Trim)
                'Dim factura As Integer = CInt(txt_factura.Text.Trim)
                'Dim retiro As Integer = CInt(txt_retiro.Text.Trim)
                Dim ruta As Integer
                If (txt_ruta.Text.Trim <> "") Then
                    ruta = CInt(txt_ruta.Text.Trim)
                End If
                Dim fecha As String = Nothing
                If (chb_fecha.Checked) Then
                    fecha = dtp_fecha.Value.ToShortDateString
                    fecha = Format(CDate(dtp_fecha.Text), "yyyy/MM/dd")
                End If
                Dim documento As Integer
                If (txt_documento.Text.Trim <> "") Then
                    documento = CInt(txt_documento.Text.Trim)
                End If
                dgv_datos.DataSource = nue_report.ConsultaDespacho(cliente, pedido, ruta, fecha, documento)
                FormatoGrillaDatos()
            Else
                MsgBox("Debe ingresar datos para realizar busqueda. ", MsgBoxStyle.Information, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Debe ingresar datos para realizar busqueda. " & ex.Message, MsgBoxStyle.Information, "Advertencia")
        End Try
    End Sub
    Private Sub FormatoGrillaDatos()
        If (dgv_datos.RowCount >= 1) Then

            dgv_datos.Columns(0).Visible = False ' Columna ID 
            dgv_datos.Columns(3).HeaderText = "N° Pedido"
            dgv_datos.Columns(4).HeaderText = "N° Documento"
            'dgv_datos.Columns("comuna").HeaderText = "Comuna"
            'dgv_datos.Columns("folio_ruta").HeaderText = "N° Ruta"
            'dgv_datos.Columns("tipo").HeaderText = "Tipo"
            'dgv_datos.Columns("cliente").HeaderText = "Cliente"
        Else
            MsgBox("No hay datos relacionados.", MsgBoxStyle.Information, "Información.")
        End If
    End Sub

    Private Sub chb_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles chb_fecha.CheckedChanged
        'If (chb_fecha.Checked) Then
        '    dtp_fecha.Enabled = True
        'Else
        '    dtp_fecha.Enabled = False
        'End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_cliente.Text = Nothing
        txt_pedido.Text = Nothing
        txt_ruta.Text = Nothing
        txt_factura.Text = Nothing
        txt_retiro.Text = Nothing
        'chb_fecha.Checked = False
        dgv_datos.DataSource = Nothing
        dgv_autorizacion.DataSource = Nothing
        dgv_retiros.DataSource = Nothing
    End Sub
End Class