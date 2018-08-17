Public Class frm_nuevo_ticket

    Dim nombre, comentario, fecha, hora, usuario As String
    Dim solicitud_id As Integer

    Dim nuevo_ticket As New clases.ticket
    Dim nuevo_historial As New clases.historial_solicitud
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim tipo_documento As Integer

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Valida_ingreso()
        If (Not nombre.Equals("") And Not comentario.Equals("")) Then
            If txt_solicitud_id.Text.Trim().Equals("0") Then
                nuevo_ticket.NuevoTicket(nombre, fecha)
                nuevo_historial.NuevaObservacion(comentario, fecha, usuario)
            Else
                nuevo_historial.NuevaObservacion(comentario, fecha, usuario, CInt(txt_solicitud_id.Text.Trim()))
            End If
            MsgBox("Ticket generado.", MsgBoxStyle.Information, "Bien hecho.")
            Limpiar()
            'frm_solicitud_ticket.abrir_en_panel(frm_modificar, pnl_body)
        Else
            MsgBox("Hay campos que debe completar. Favor llenar campos necesarios.", MsgBoxStyle.Information, "Información.")
        End If
    End Sub

    Private Sub Valida_ingreso()
        nombre = txt_nombre.Text.Trim()
        comentario = txt_comentario.Text.Trim()
        fecha = frm_solicitud_ticket.lbl_fecha.Text
        hora = frm_solicitud_ticket.lbl_hora.Text
        fecha = fecha + " " + hora
        usuario = frm_solicitud_ticket.lbl_solicitante.Text
    End Sub

    Private Sub Limpiar()
        txt_nombre.Text = Nothing
        txt_comentario.Text = Nothing
    End Sub

    Private Sub frm_nuevo_ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        If txt_solicitud_id.Text.Trim().Equals("") Then
            txt_solicitud_id.Text = "0"
        End If
        solicitud_id = txt_solicitud_id.Text.Trim()
        If Not solicitud_id.Equals("0") Then
            txt_nombre.Text = nuevo_ticket.BuscarTicket(solicitud_id)
        End If
    End Sub
End Class