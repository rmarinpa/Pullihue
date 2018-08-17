Public Class frm_sel_doc2
    Dim nue_report As New clases.guias_despacho

    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(100, 100)
    End Sub

    Private Sub btn_direccion_Click(sender As Object, e As EventArgs) Handles btn_direccion.Click
        documento = 1
        Frm_ventas_mod.txt_venta_m2.Text = 1
        Frm_ventas_mod.txt_venta_m2.Enabled = False
        Frm_ventas_mod.txt_tipo.Text = "Guía De Despacho"
        frm_guias.ShowDialog()
        Frm_ventas_mod.txt_factura_ref.Visible = True
        Frm_ventas_mod.lbl_fact_rel.Visible = True
        Frm_ventas_mod.txt_fecha_ref.Visible = True
        Frm_ventas_mod.lbl_fact_rel.Visible = True
        Me.Close()
    End Sub

    Private Sub btn_muestra_Click(sender As Object, e As EventArgs) Handles btn_muestra.Click
        documento = 0
        Frm_ventas_mod.txt_venta_m2.Enabled = True
        Frm_ventas_mod.txt_venta_m2.Clear()
        Frm_ventas_mod.txt_tipo.Text = "Factura de Venta"
        Frm_ventas_mod.txt_factura_ref.Visible = False
        Frm_ventas_mod.lbl_fact_rel.Visible = False
        Frm_ventas_mod.txt_fecha_ref.Visible = False
        Frm_ventas_mod.lbl_fact_rel.Visible = False
        Frm_ventas_mod.BringToFront()

        If nue_report.consultar_cliente(Frm_ventas_mod.txt_rut.Text) = 0 Then
            MsgBox("CLIENTE CON PRODUCTOS PENDIENTES DE ACUERDO A GUÍAS DE DESPACHO PARCIAL.")
            frm_info_guia.ShowDialog()
        End If

        Me.Close()
    End Sub
End Class