Public Class frm_facturas

    Dim nue_report As New clases.facturas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""

    Sub actualizar_ofertas()
        dgv_facturas.DataSource = nue_report.listar12(Frm_ventas_mod.txt_rut.Text)
        dgv_facturas.Columns(0).Visible = False
        dgv_facturas.Columns(1).Visible = False
        dgv_facturas.Columns(2).Visible = False
        dgv_facturas.Columns(3).HeaderText = "FACTURA"
        dgv_facturas.Columns(4).Visible = False
        dgv_facturas.Columns(5).Visible = False
        dgv_facturas.Columns(6).HeaderText = "FECHA"
        dgv_facturas.Columns(7).HeaderText = "VENCIMIENTO"
        dgv_facturas.Columns(8).Visible = False
        dgv_facturas.Columns(9).Visible = False
        dgv_facturas.Columns(10).Visible = False
        dgv_facturas.Columns(11).HeaderText = "CHEQUE EN CARTERA"
        dgv_facturas.Columns(11).DefaultCellStyle.Format = "##,###.##"
        dgv_facturas.Columns(12).Visible = False
        dgv_facturas.Columns(13).HeaderText = "SALDO POR VENCER"
        dgv_facturas.Columns(13).DefaultCellStyle.Format = "##,###.##"
        dgv_facturas.Columns(14).HeaderText = "SALDO VENCIDO"
        dgv_facturas.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_facturas.Columns(15).HeaderText = "DIAS"
        dgv_facturas.Columns(16).HeaderText = "DEUDA TOTAL"
        dgv_facturas.Columns(16).DefaultCellStyle.Format = "##,###.##"
        dgv_facturas.Columns(17).HeaderText = "FECHA CHEQUE"
        dgv_facturas.Columns(18).Visible = False
        dgv_facturas.Columns(19).Visible = False
        dgv_facturas.Columns(20).Visible = False
        dgv_facturas.Columns(21).Visible = False
        dgv_facturas.Columns(22).Visible = False
        dgv_facturas.Columns(23).Visible = False
        dgv_facturas.Columns(24).Visible = False
        dgv_facturas.Columns(25).Visible = False
        dgv_facturas.Columns(26).Visible = False
        dgv_facturas.Columns(27).Visible = False
        dgv_facturas.Columns(28).Visible = False
        dgv_facturas.Columns(29).Visible = False
        dgv_facturas.Columns(30).Visible = False
        dgv_facturas.Columns(31).Visible = False
        dgv_facturas.Columns(32).Visible = False
        dgv_facturas.Columns(33).Visible = False
        dgv_facturas.Columns(34).Visible = False
        dgv_facturas.Columns(3).DisplayIndex = 1
        dgv_facturas.Columns(6).DisplayIndex = 2
        dgv_facturas.Columns(7).DisplayIndex = 3
        dgv_facturas.Columns(17).DisplayIndex = 4
        dgv_facturas.Columns(11).DisplayIndex = 5
        dgv_facturas.Columns(13).DisplayIndex = 6
        dgv_facturas.Columns(14).DisplayIndex = 7
        dgv_facturas.Columns(15).DisplayIndex = 8
        dgv_facturas.Columns(16).DisplayIndex = 9
        dgv_facturas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(3).Width = 60
        dgv_facturas.Columns(6).Width = 70
        dgv_facturas.Columns(7).Width = 80
        dgv_facturas.Columns(17).Width = 70
        dgv_facturas.Columns(11).Width = 60
        dgv_facturas.Columns(13).Width = 60
        dgv_facturas.Columns(14).Width = 60
        dgv_facturas.Columns(15).Width = 60
        dgv_facturas.Columns(16).Width = 60

    End Sub

    Private Sub frm_ofertas_dia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Frm_ventas_mod.cmb_cliente.Text = "" Then
        Else
            actualizar_ofertas()
            txt_deuda_documentada.Text = nue_report.deuda_con_doc(Frm_ventas_mod.txt_rut.Text)
            txt_deuda_por_documentar.Text = nue_report.deuda_sin_doc(Frm_ventas_mod.txt_rut.Text)
            txt_deuda2.Text = nue_report.deuda_sin_doc2(Frm_ventas_mod.txt_rut.Text)
            txt_suma_deuda.Text = CDbl(txt_deuda_documentada.Text) + CDbl(txt_deuda_por_documentar.Text) + CDbl(txt_deuda2.Text)
            txt_lc_utilizada.Text = CDbl(txt_suma_deuda.Text)
            txt_lc_disponible.Text = nue_report.descripcion_cupo(Frm_ventas_mod.txt_rut.Text)
            txt_suma_lc.Text = CDbl(txt_lc_disponible.Text) - CDbl(txt_lc_utilizada.Text)
            txt_deuda_documentada.Text = Format(CDbl(txt_deuda_documentada.Text), "###,###,##0.")
            txt_deuda_por_documentar.Text = Format(CDbl(txt_deuda_por_documentar.Text), "###,###,##0.")
            txt_suma_deuda.Text = Format(CDbl(txt_suma_deuda.Text), "###,###,##0.")
            txt_lc_utilizada.Text = Format(CDbl(txt_lc_utilizada.Text), "###,###,##0.")
            txt_lc_disponible.Text = Format(CDbl(txt_lc_disponible.Text), "###,###,##0.")
            txt_suma_lc.Text = Format(CDbl(txt_suma_lc.Text), "###,###,##0.")
            txt_deuda2.Text = Format(CDbl(txt_deuda2.Text), "###,###,##0.")
        End If
        txt_deuda_documentada.ReadOnly = True
        txt_deuda_por_documentar.ReadOnly = True
        txt_lc_disponible.ReadOnly = True
        txt_lc_utilizada.ReadOnly = True
        txt_suma_deuda.ReadOnly = True
        txt_suma_lc.ReadOnly = True
        txt_deuda2.ReadOnly = True
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class