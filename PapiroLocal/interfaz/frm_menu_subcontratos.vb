Public Class frm_menu_subcontratos

    Private Sub rbtn_ep_maquinaria_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtn_ep_maquinaria.MouseClick
        If rbtn_ep_maquinaria.Checked = True Then
            frm_descuentos.Show()
        Else

        End If
    End Sub

    Private Sub rbtn_ep_subcontrato_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtn_ep_subcontrato.MouseClick
        If rbtn_ep_subcontrato.Checked = True Then
            frm_descuentos_subcontratos.Show()
        Else

        End If
    End Sub

End Class



