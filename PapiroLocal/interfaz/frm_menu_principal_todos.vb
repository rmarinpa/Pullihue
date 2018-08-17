Public Class frm_menu_principal_todos
    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_contratos.Click
        frm_ficha_trabajador.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_registro_reports.Show()

    End Sub

    Private Sub btn_configuracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_menu_petroleo.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_plan_de_cuentas.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_estado_de_pago.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_codigo_petroleo.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_descuentos.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        descargar_datos.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_ficha_maquinaria.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_estado_de_pago_maquinaria.Show()
    End Sub
End Class