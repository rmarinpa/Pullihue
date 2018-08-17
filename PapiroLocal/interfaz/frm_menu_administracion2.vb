Public Class frm_menu_administracion2

    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_contratos.Click
        Frm_consulta_pedido.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub btn_controlGuiaDespacho_Click(sender As Object, e As EventArgs) Handles btn_controlGuiaDespacho.Click
        frm_menu_guias.Show()
    End Sub
End Class