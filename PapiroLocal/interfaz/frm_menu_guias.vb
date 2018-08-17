Public Class frm_menu_guias

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_sel_guia.Show()
    End Sub

    Private Sub btn_finaliza_guia_parcial_Click(sender As Object, e As EventArgs) Handles btn_finaliza_guia_parcial.Click
        frm_concluir_guía_despacho_parcial.Show()
    End Sub
End Class