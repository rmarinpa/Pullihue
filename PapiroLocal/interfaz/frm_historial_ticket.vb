Public Class frm_historial_ticket

    Dim nuevo_historial_solicitud As New clases.historial_solicitud
    Dim nuevo_ticket As New clases.ticket

    Dim id As Integer
    Dim usuario, comentario As String

    'Private Sub txt_id_solicitud_LostFocus(sender As Object, e As EventArgs) Handles txt_id_solicitud.LostFocus
    '    If IsNumeric(txt_id_solicitud.Text.Trim()) Then
    '        id = txt_id_solicitud.Text.Trim()
    '        BuscarTicket(id)
    '    Else
    '        MsgBox("El valor ingresado no es válido, favor corregir.", MsgBoxStyle.Information, "Error")
    '        Exit Sub
    '    End If
    '    BuscarHistorial(id)
    'End Sub

    Private Sub BuscarTicket(id)
        If IsNumeric(id) Then
            dgv_ticket.DataSource = nuevo_ticket.BuscarDatosTicket(id)
            If dgv_ticket.RowCount > 0 Then
                btn_nuevo_registro.Enabled = True
                AsignarTicket()
            Else
                btn_nuevo_registro.Enabled = False
                Limpiar()
            End If
        Else
            MsgBox("El valor ingresado no es válido, favor corregir.", MsgBoxStyle.Information, "Error")
        End If
    End Sub
    Public Sub BuscarHistorial(id)
        If IsNumeric(id) Then
            dgv_historial_ticket.DataSource = nuevo_historial_solicitud.BuscarHistorialTicket(id)
            If dgv_historial_ticket.RowCount > 0 Then
                btn_nuevo_registro.Enabled = True
                AsignarHistorial()
            Else
                btn_nuevo_registro.Enabled = False
            End If
        Else
            MsgBox("El valor ingresado no es válido, favor corregir.", MsgBoxStyle.Information, "Error")
        End If
    End Sub
    Private Sub OrdenarHistorial()
        With dgv_historial_ticket
            .Columns("id").Visible = False
            .Columns("comentario").Visible = False
            .Columns("solicitud_id").Visible = False

            .Columns("ingresado").HeaderText = "Ingresado"
            .Columns("usuario").HeaderText = "Usuario"

            .AutoSizeColumnsMode = .AutoSizeColumnsMode.Fill
        End With

    End Sub

    Private Sub txt_id_solicitud_TextChanged(sender As Object, e As EventArgs) Handles txt_id_solicitud.TextChanged
        If txt_id_solicitud.Text.Trim().Equals("") Then
            Limpiar()
            btn_nuevo_registro.Enabled = False
        End If
        If IsNumeric(txt_id_solicitud.Text.Trim()) Then
            id = txt_id_solicitud.Text.Trim()
            BuscarTicket(id)
            AgregaColorTipoUsuario()
        Else
            Exit Sub
            'MsgBox("El valor ingresado no es válido, favor corregir.", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Limpiar()
        txt_usuario.Text = Nothing
        txt_nombre.Text = Nothing
        txt_estado.Text = Nothing
        txt_prioridad.Text = Nothing
        dtp_ingreso.Text = "1900-01-01"
        dtp_finaliza.Text = "1900-01-01"
        txt_comentario.Text = Nothing
        dgv_historial_ticket.DataSource = Nothing
    End Sub


    Private Sub frm_historial_ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not txt_id_solicitud.Text.Trim().Equals("") Then
            chb_nueva_busqueda.Checked = False
            dgv_ticket.DataSource = nuevo_ticket.BuscarDatosTicket(txt_id_solicitud.Text.Trim())
            If dgv_ticket.RowCount > 0 Then
                AsignarTicket()
            End If
        End If
    End Sub

    Private Sub chb_nueva_busqueda_CheckedChanged(sender As Object, e As System.EventArgs) Handles chb_nueva_busqueda.CheckedChanged
        If chb_nueva_busqueda.Checked Then
            txt_id_solicitud.Enabled = True
        Else
            txt_id_solicitud.Enabled = False
        End If
    End Sub

    Private Sub dgv_historial_ticket_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_historial_ticket.CellClick
        If (dgv_historial_ticket.RowCount > 0) Then
            Dim fila As Integer
            fila = dgv_historial_ticket.CurrentRow.Index
            usuario = dgv_historial_ticket.Rows(fila).Cells(3).Value.ToString()
            comentario = dgv_historial_ticket.Rows(fila).Cells(1).Value.ToString()
        End If
        AsignarHistorial()
    End Sub

    Private Sub AsignarHistorial()
        txt_usuario.Text = usuario
        txt_comentario.Text = comentario
        OrdenarHistorial()
    End Sub

    Private Sub AsignarTicket()
        Select Case dgv_ticket.Rows(0).Cells(1).Value.ToString()
            Case 0
                txt_estado.Text = "Cerrado"
            Case 1
                txt_estado.Text = "Abierto"
        End Select
        dtp_ingreso.Text = dgv_ticket.Rows(0).Cells(2).Value.ToString()
        If Not dgv_ticket.Rows(0).Cells(3).Value.ToString().Equals("") Then
            dtp_finaliza.Text = CDate(dgv_ticket.Rows(0).Cells(3).Value)
        Else
            dtp_finaliza.Text = "1900-01-01"
        End If
        txt_nombre.Text = dgv_ticket.Rows(0).Cells(4).Value.ToString()
        If dgv_ticket.Rows(0).Cells(5).Value.ToString().Equals("Seleccione") Then
            txt_prioridad.Text = "Sin asignar"
        Else
            txt_prioridad.Text = dgv_ticket.Rows(0).Cells(5).Value.ToString()
        End If
        BuscarHistorial(id)
    End Sub

    Private Sub btn_nuevo_registro_Click(sender As Object, e As EventArgs) Handles btn_nuevo_registro.Click
        If txt_estado.Text.Equals("Cerrado") Then
            MsgBox("El ticket esta cerrado. Para abrirlo contactese con el administrador.")
        Else
            frm_nuevo_ticket.txt_solicitud_id.Text = txt_id_solicitud.Text.Trim()
            frm_solicitud_ticket.abrir_en_panel(frm_nuevo_ticket, frm_solicitud_ticket.pnl_body)
            Me.Close()
        End If
    End Sub


    ' Modifica el color dependiendo del tipo de usuario que agrega historial al ticket.
    Private Sub AgregaColorTipoUsuario()

        For Each fila As DataGridViewRow In dgv_historial_ticket.Rows
            If fila.Cells("usuario").Value.Equals("GSOLIS") Or fila.Cells("usuario").Value.Equals("CVALENZUELA") Then
                fila.DefaultCellStyle.BackColor = Color.CadetBlue
            Else
                fila.DefaultCellStyle.BackColor = Color.Gold
            End If
        Next

    End Sub

End Class