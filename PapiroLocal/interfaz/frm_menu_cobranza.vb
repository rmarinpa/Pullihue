Public Class frm_menu_cobranza

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_login.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_registro_llamada.Show()
        frm_registro_llamada.txt_cobranza.Text = "Cobranza"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Frm_planificacion.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_agenda2.Show()
    End Sub

    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_contratos.Click
        frm_menu_pagos.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frm_informes_cobranza.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_estado_de_cuenta.Show()
    End Sub
End Class