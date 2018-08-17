Public Class frm_menu_inf_pagos
    Dim nue_cur As New clases.Estados_de_pago
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        CR_informe_ingresos.Show()
    End Sub
End Class