Imports System.Globalization

Public Class frm_mod_pagos2

    Dim nuevo_registroPagos As New clases.Registro_pagos

    Dim cheque As Integer = Nothing
    Dim mensaje As String = Nothing

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        If frm_consultaCheque.DGV_resultado.Rows.Count > 0 And cmb_operacion.Text <> "" And txt_serie.Text <> "" And cmb_banco.Text <> "" Then
            If MessageBox.Show("¿Seguro que desea cambiar este Cheque?", "Confirmación de procedimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                nuevo_registroPagos.modificar_cheque(frm_consultaCheque.txt_numeroCheque.Text, frm_consultaCheque.DGV_resultado.Rows(0).Cells(8).Value.ToString(), cmb_operacion.Text, cmb_banco.Text, txt_serie.Text, dtp_fecha_pago.Text, "CARTERA")
                nuevo_registroPagos.insertar_reg_cheque(frm_consultaCheque.txt_rut.Text, frm_consultaCheque.txt_numeroCheque.Text, "1", "SE CAMBIA EL CHEQUE POR " + cmb_operacion.Text + " N°" + txt_serie.Text, Today, Nombre_Obra)

                'nuevo_registroPagos.modificar_cliente(frm_consultaCheque.txt_rut.Text, "OK")
                frm_consultaCheque.actualiza_cheques()

                MsgBox("CHEQUE CAMBIADO")
            End If
        Else
            MsgBox("DEBE INGRESAR UN CHEQUE VÁLIDO")
        End If
    End Sub

    Private Sub frm_mod_pagos2_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmb_operacion.Text = "CHEQUE"
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class