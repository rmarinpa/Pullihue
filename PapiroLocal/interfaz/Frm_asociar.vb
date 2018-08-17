Imports System.Globalization
Public Class Frm_asociar
    Dim nue_report As New clases.Asociar
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double


    Private Sub Frm_planificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(500, 100)
        txt_cliente.ReadOnly = True
        txt_monto.ReadOnly = True

    End Sub

    Public Sub actualizar_pedidos()
        Fecha_inicio = Me.txt_fecha.Value.ToShortDateString
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        cmb_n_ped.DataSource = nue_report.listar8(Fecha_inicio)
        cmb_n_ped.DisplayMember = "folio"
        cmb_n_ped.ValueMember = "folio"
    End Sub

    Private Sub txt_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fecha.ValueChanged
        actualizar_pedidos()
    End Sub
    Public Sub limpiar()
        txt_documento.Clear()
        cmb_tipo.Text = ""
        cmb_n_ped.Text = ""
        chk_cor_no.Checked = False
        chk_cor_si.Checked = False
        chk_cor2_si.Checked = False
        chk_cor2_no.Checked = False

    End Sub

    Private Sub cmb_n_ped_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_n_ped.MouseClick
        actualizar_pedidos()
    End Sub

    Private Sub cmb_n_ped_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_n_ped.SelectedValueChanged

    End Sub

    Private Sub cmb_n_ped_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_n_ped.TextChanged
        dgv_despachos2.DataSource = nue_report.listar7(cmb_n_ped.Text)
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


        txt_id.Text = nue_report.descripcion_id(cmb_n_ped.Text)
        txt_monto.Text = nue_report.descripcion_monto(cmb_n_ped.Text)
        txt_cliente.Text = nue_report.descripcion_cliente(cmb_n_ped.Text)
        If txt_monto.Text <> "" Then
            txt_monto.Text = Format(CDbl(txt_monto.Text), "###,##0.")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_documento.Text <> "" And cmb_tipo.Text <> "" And txt_corr_cliente.Text <> "" And txt_corr_monto.Text <> "" Then
            nue_report.modificar(txt_id.Text, txt_documento.Text)
            nue_report.insertar(CDate(txt_fecha.Text), cmb_n_ped.Text, txt_documento.Text, cmb_tipo.Text, txt_cliente.Text, txt_corr_cliente.Text, txt_monto.Text, txt_corr_monto.Text, Nombre_Obra)
            MessageBox.Show("SE HA ASOCIADO CON EXITO LA NOTA DE PEDIDO N°" & cmb_n_ped.Text)
            limpiar()
            actualizar_pedidos()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub chk_cor_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cor_si.CheckedChanged
        If chk_cor_si.Checked = True Then
            chk_cor_no.Checked = False
            txt_corr_cliente.Text = "SI"
        End If
    End Sub

    Private Sub chk_cor_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cor_no.CheckedChanged
        If chk_cor_no.Checked = True Then
            chk_cor_si.Checked = False
            txt_corr_cliente.Text = "NO"
        End If
    End Sub

    Private Sub chk_cor2_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cor2_si.CheckedChanged
        If chk_cor2_si.Checked = True Then
            chk_cor2_no.Checked = False
            txt_corr_monto.Text = "SI"
        End If
    End Sub

    Private Sub chk_cor2_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cor2_no.CheckedChanged
        If chk_cor2_no.Checked = True Then
            chk_cor2_si.Checked = False
            txt_corr_monto.Text = "NO"
        End If
    End Sub

    Private Sub dgv_despachos2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos2.CellContentClick

    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo.SelectedIndexChanged

    End Sub

    Private Sub cmb_tipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_tipo.TextChanged
        If cmb_tipo.Text = "NULO" Then
            txt_documento.Text = "NULO"
            txt_documento.ReadOnly = True
        Else
            txt_documento.ReadOnly = False
            txt_documento.Clear()
        End If
    End Sub

    Private Sub cmb_n_ped_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_n_ped.SelectedIndexChanged

    End Sub
End Class