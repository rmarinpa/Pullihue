Public Class frm_prorroga_cheque

    Dim nuevo_registroPagos As New clases.Registro_pagos

    Dim cheque As Integer = Nothing
    Dim mensaje As String = Nothing

    Private Sub btn_guardar_cambios_Click(sender As Object, e As EventArgs) Handles btn_guardar_cambios.Click
        If frm_consultaCheque.DGV_resultado.Rows.Count > 0 Then
            If MessageBox.Show("¿Seguro que desea prorrogar este Cheque?", "Confirmación de procedimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                nuevo_registroPagos.modificar_fecha(frm_consultaCheque.txt_numeroCheque.Text, frm_consultaCheque.DGV_resultado.Rows(0).Cells(8).Value.ToString(), dtp_prorroga.Text)
                nuevo_registroPagos.insertar_reg_cheque(frm_consultaCheque.txt_rut.Text, frm_consultaCheque.txt_numeroCheque.Text, "0", "SE REGISTRA PRORROGA DEL CHEQUE N°" + frm_consultaCheque.txt_numeroCheque.Text + " DE " + frm_consultaCheque.DGV_resultado.Rows(0).Cells(6).Value.ToString() + " AL " + dtp_prorroga.Text, Today, Nombre_Obra)
                nuevo_registroPagos.modificar_estado(frm_consultaCheque.txt_numeroCheque.Text, frm_consultaCheque.DGV_resultado.Rows(0).Cells(8).Value.ToString(), "CARTERA")

                cheque = CInt(frm_consultaCheque.txt_numeroCheque.Text.Trim())
                frm_consultaCheque.DGV_resultado.DataSource = nuevo_registroPagos.RescataCheque(cheque, frm_consultaCheque.txt_rut.Text)
                frm_consultaCheque.EncuentraDatos()
                MsgBox("CHEQUE PRORROGADO")
            End If
        Else
            MsgBox("DEBE INGRESAR UN CHEQUE VÁLIDO")
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class