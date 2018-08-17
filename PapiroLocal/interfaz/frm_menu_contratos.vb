Public Class frm_menu_contratos


    Private Sub rbtn_maq_movil_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtn_maq_movil.MouseClick
        If rbtn_maq_movil.Checked = True Then

        Else

        End If
    End Sub


    Private Sub rbtn_maq_movil_cuentas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtn_maq_movil_cuentas.MouseClick
        If rbtn_maq_movil_cuentas.Checked = True Then
            frm_cuenta_contable.Show()
        Else

        End If
    End Sub

    Private Sub rbtn_maq_movil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_maq_movil.CheckedChanged

    End Sub

    Private Sub rbtn_maq_movil_cuentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_maq_movil_cuentas.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_tabla_uf.CheckedChanged
        If rbtn_tabla_uf.Checked = True Then
            frm_tabla_uf.Show()
        Else

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tipo_subcontrato.CheckedChanged
        If btn_tipo_subcontrato.Checked = True Then
            frm_Subcontratos.Show()
        Else

        End If
    End Sub
End Class



