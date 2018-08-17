Imports System.Globalization
Public Class Frm_autorizar_gd
    Dim nue_report As New clases.Autorizacion
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub actualizar_dgv()
        dgv_autorizacion.DataSource = nue_report.listar()
        dgv_autorizacion.Columns(0).Visible = False
        dgv_autorizacion.Columns(1).HeaderText = "Folio"
        dgv_autorizacion.Columns(2).HeaderText = "Fecha"
        dgv_autorizacion.Columns(3).HeaderText = "Hora"
        dgv_autorizacion.Columns(3).DefaultCellStyle.Format = "t"
        dgv_autorizacion.Columns(4).HeaderText = "Día Despacho"
        dgv_autorizacion.Columns(5).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(6).HeaderText = "Solicitado"
        dgv_autorizacion.Columns(7).HeaderText = "Observaciones"
        dgv_autorizacion.Columns(8).HeaderText = "Comuna"
        dgv_autorizacion.Columns(9).HeaderText = "Dirección"
        dgv_autorizacion.Columns(10).HeaderText = "Cliente"
        dgv_autorizacion.Columns(1).DefaultCellStyle.Format = "#,#"
        dgv_autorizacion.AllowUserToOrderColumns = True
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 80
        dgv_autorizacion.Columns(3).Width = 60
        dgv_autorizacion.Columns(4).Width = 60
        dgv_autorizacion.Columns(5).Width = 60
        dgv_autorizacion.Columns(6).Width = 60
        dgv_autorizacion.Columns(7).Width = 200
        dgv_autorizacion.Columns(8).Visible = False
        dgv_autorizacion.Columns(9).Visible = False
        dgv_autorizacion.Columns(10).Width = 200
        dgv_autorizacion.Columns(11).Visible = False
        dgv_autorizacion.Columns(12).Visible = False
        dgv_autorizacion.Columns(13).Visible = False
        dgv_autorizacion.Columns(14).Visible = False

        dgv_autorizacion.Columns(1).DisplayIndex = 1
        dgv_autorizacion.Columns(10).DisplayIndex = 2
        dgv_autorizacion.Columns(2).DisplayIndex = 3
        dgv_autorizacion.Columns(3).DisplayIndex = 4
        dgv_autorizacion.Columns(4).DisplayIndex = 5
        dgv_autorizacion.Columns(5).DisplayIndex = 6
        dgv_autorizacion.Columns(6).DisplayIndex = 7
        dgv_autorizacion.Columns(7).DisplayIndex = 8
        dgv_autorizacion.Columns(8).DisplayIndex = 9
        dgv_autorizacion.Columns(9).DisplayIndex = 10
        dgv_autorizacion.Columns(9).DisplayIndex = 11


    End Sub

    Private Sub Frm_autorizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_dgv()
        txt_codigo.ReadOnly = True
        txt_folio.ReadOnly = True
        txt_fecha.ReadOnly = True
        txt_hora.ReadOnly = True
        txt_fecha_desp.ReadOnly = True
        txt_toma_pedido.ReadOnly = True
        txt_solicitado.ReadOnly = True
        txt_observaciones.ReadOnly = True
        txt_comuna_desp.ReadOnly = True
        txt_direccion_desp.ReadOnly = True
        txt_autoriza.ReadOnly = True
        txt_autoriza.Text = Nombre_Obra
        Me.Location = New Point(200, 10)
    End Sub

    Private Sub dgv_autorizacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_autorizacion.CellClick
        txt_codigo.Text = dgv_autorizacion.CurrentRow.Cells(0).Value.ToString()
        txt_folio.Text = dgv_autorizacion.CurrentRow.Cells(1).Value.ToString()
        txt_fecha.Text = dgv_autorizacion.CurrentRow.Cells(2).Value.ToString()
        txt_hora.Text = dgv_autorizacion.CurrentRow.Cells(3).Value.ToString()
        txt_fecha_desp.Text = dgv_autorizacion.CurrentRow.Cells(4).Value.ToString()
        txt_toma_pedido.Text = dgv_autorizacion.CurrentRow.Cells(5).Value.ToString()
        txt_solicitado.Text = dgv_autorizacion.CurrentRow.Cells(6).Value.ToString()
        txt_observaciones.Text = dgv_autorizacion.CurrentRow.Cells(7).Value.ToString()
        txt_comuna_desp.Text = dgv_autorizacion.CurrentRow.Cells(8).Value.ToString()
        txt_direccion_desp.Text = dgv_autorizacion.CurrentRow.Cells(9).Value.ToString()
        txt_rut.Text = dgv_autorizacion.CurrentRow.Cells(11).Value.ToString()
        txt_tipo.Text = dgv_autorizacion.CurrentRow.Cells(12).Value.ToString()
        txt_fact_ref.Text = dgv_autorizacion.CurrentRow.Cells(13).Value.ToString()
        txt_fecha_ref.Text = dgv_autorizacion.CurrentRow.Cells(14).Value.ToString()
    End Sub

    Sub actualizar_dgv_venta2()
        dgv_venta2.DataSource = nue_report.listar18(dgv_autorizacion.CurrentRow.Cells(1).Value.ToString())
        dgv_venta2.AllowUserToOrderColumns = True
        dgv_venta2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub limpiar()
        txt_codigo.Clear()
        txt_folio.Clear()
        txt_fecha.Clear()
        txt_hora.Clear()
        txt_fecha_desp.Clear()
        txt_toma_pedido.Clear()
        txt_solicitado.Clear()
        txt_observaciones.Clear()
        txt_comuna_desp.Clear()
        txt_direccion_desp.Clear()
        txt_obs_aut.Clear()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizar_dgv()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tipo, observaciones As String
        tipo = "AUTORIZA"
        observaciones = txt_obs_aut.Text
        If txt_codigo.Text <> "" Then
            If txt_obs_aut.Text <> "" Then
                nue_report.insertar8(txt_folio.Text, CDate(txt_fecha.Text), CDate(txt_hora.Text), txt_fecha_desp.Text, txt_toma_pedido.Text, txt_solicitado.Text, txt_observaciones.Text, txt_comuna_desp.Text, txt_direccion_desp.Text, txt_tipo.Text, txt_fact_ref.Text, CDate(txt_fecha_ref.Text))
                nue_report.eliminar3(txt_codigo.Text)
                nue_report.insertar6(txt_folio.Text, CDate(txt_fecha.Text), CDate(txt_hora.Text), txt_fecha_desp.Text, txt_toma_pedido.Text, txt_solicitado.Text, txt_observaciones.Text, txt_comuna_desp.Text, txt_direccion_desp.Text, txt_autoriza.Text, tipo, observaciones)
                MessageBox.Show("NOTA DE PEDIDO AUTORIZADA")
                CR_guia_aut.Show()
                actualizar_dgv()
                limpiar()
            Else
                MessageBox.Show("FALTA INDICAR MOTIVO AUTORIZACIÓN")
            End If
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tipo, observaciones As String
        tipo = "RECHAZA"
        observaciones = txt_obs_aut.Text
        If txt_codigo.Text <> "" Then
            If txt_obs_aut.Text <> "" Then
                nue_report.insertar6(txt_folio.Text, CDate(txt_fecha.Text), CDate(txt_hora.Text), txt_fecha_desp.Text, txt_toma_pedido.Text, txt_solicitado.Text, txt_observaciones.Text, txt_comuna_desp.Text, txt_direccion_desp.Text, txt_autoriza.Text, tipo, observaciones)
                nue_report.eliminar3(txt_codigo.Text)
                MessageBox.Show("NOTA DE PEDIDO RECHAZADA")
                actualizar_dgv()
                limpiar()
            Else
                MessageBox.Show("FALTA INDICAR MOTIVO RECHAZO")
            End If
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        bloqueo_inf = 3
        frm_bloqueo_inf.Show()
    End Sub

    Private Sub dgv_autorizacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_autorizacion.CellContentClick

    End Sub
End Class