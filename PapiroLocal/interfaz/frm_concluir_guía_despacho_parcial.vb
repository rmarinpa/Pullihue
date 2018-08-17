Public Class frm_concluir_guía_despacho_parcial

    Dim nueva_venta As New clases.ventas
    Dim nueva_guia_depacho_parcial As New clases.guia_desp_parcial

    Dim mensaje As String = Nothing

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            If (Not txt_cliente.Text.Trim().Equals("")) Then
                dgv_clientes.DataSource = nueva_guia_depacho_parcial.busca_clientes_despacho_parcial(txt_cliente.Text.Trim())
                If (dgv_clientes.RowCount = 0) Then
                    dgv_clientes.DataSource = Nothing
                    lbl_mensaje.ForeColor = Color.Red
                    mensaje = "El cliente no tienes no tiene despachos parciales actualmente."
                Else
                    txt_cliente.Clear()
                    ajusta_dgvClientes()
                    Dim cantidad As Integer = dgv_clientes.RowCount
                    lbl_mensaje.ForeColor = Color.Green
                    mensaje = "Se han encontrado " & cantidad & " factura(s)."
                End If
            Else
                lbl_mensaje.ForeColor = Color.Red
                mensaje = "Debe ingresar nombre del cliente, favor intente nuevamente."
            End If
        Catch ex As Exception
            lbl_mensaje.Visible = False
            MsgBox("Error inesperado, favor intenete mas tarde." & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        lbl_mensaje.Visible = True
        lbl_mensaje.Text = mensaje
    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        Dim identificador As String = dgv_clientes.Item(0, dgv_clientes.CurrentRow.Index).Value
        If MsgBox("¿Estas seguro de concluido el despacho parcial?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            nueva_guia_depacho_parcial.concluir_despacho_parcial(identificador)
            MsgBox("Se ha concluido el despacho parcial para el cliente.", MsgBoxStyle.Information, "Información")
            txt_cliente.Clear()
            dgv_clientes.DataSource = Nothing
            mensaje = Nothing
        Else
            lbl_mensaje.ForeColor = Color.Red
            mensaje = "No se ha podido concluir el despacho parcial para el cliente."
        End If
        lbl_mensaje.Visible = True
        lbl_mensaje.Text = mensaje
    End Sub

    Public Sub ajusta_dgvClientes()
        With dgv_clientes
            .Columns(0).Visible = False
            .Columns(2).Visible = False
            .Columns(4).Visible = False

            .Columns(1).HeaderText = "Cliente"
            .Columns(3).HeaderText = "Factura"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

    End Sub

End Class