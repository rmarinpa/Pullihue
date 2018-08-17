Public Class frm_menu_alertas

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub btn_precio_min_Click(sender As Object, e As EventArgs) Handles btn_precio_min.Click
        tipo_precio = 1
        frm_precios.ShowDialog()
    End Sub

    Private Sub btn_precio_max_Click(sender As Object, e As EventArgs) Handles btn_precio_max.Click
        tipo_precio = 0
        frm_precios.ShowDialog()
    End Sub

    Private Sub btn_bloquear_Click(sender As Object, e As EventArgs) Handles btn_bloquear.Click
        frm_bloqueos_mod.Show()
    End Sub

    Private Sub btn_nc_pend_Click(sender As Object, e As EventArgs) Handles btn_nc_pend.Click
        filtro_nc = 0
        Frm_consulta_nc_pend.ShowDialog()
    End Sub
End Class