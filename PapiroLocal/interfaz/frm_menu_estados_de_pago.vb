Public Class frm_menu_estados_de_pago

    Private Sub rbtn_ep_maquinaria_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtn_ep_maquinaria.MouseClick
        If rbtn_ep_maquinaria.Checked = True Then
            frm_estado_de_pago.Show()
        Else

        End If
    End Sub

    Private Sub rbtn_ep_subcontrato_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtn_ep_subcontrato.MouseClick
        If rbtn_ep_subcontrato.Checked = True Then
            frm_estado_de_pago_subcontrato.Show()
        Else

        End If
    End Sub

    Private Sub rbtn_ep_subcontrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_ep_subcontrato.CheckedChanged

    End Sub

    Private Sub rbtn_ep_maquinaria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_ep_maquinaria.CheckedChanged

    End Sub
End Class



