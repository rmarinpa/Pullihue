﻿Public Class frm_menu_facturacion

    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Clientes_Productos.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_login.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_despacho2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frm_usuario_conf2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_consulta_pedido_fact.Show()
    End Sub

    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(50, 50)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_registro_llamada.Show()
        frm_registro_llamada.txt_cobranza.Text = "Venta"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_asociar.Show()
    End Sub

    Private Sub btn_aut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aut.Click
        motivo = "LOGISTICA"
        Frm_autorizar_nc.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_folio.Click
        Frm_folios.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        filtro_nc = 1
        Frm_consulta_nc.Show()
    End Sub

    Private Sub btn_guia_Click(sender As Object, e As EventArgs) Handles btn_guia.Click
        filtro_guia = 1
        Frm_consulta_guia.Show()
    End Sub
End Class