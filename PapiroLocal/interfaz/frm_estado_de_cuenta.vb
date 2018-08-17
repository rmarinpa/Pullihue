Public Class frm_estado_de_cuenta
    Dim nue_cur As New clases.Estados_de_pago
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CR_Estado_de_cuenta_todos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Frm_clientes_busqueda_EC.Show()
    End Sub

    Private Sub frm_estado_de_cuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        rdbtn_documentos.Checked = True
        txt_rut.ReadOnly = True
        txt_cliente.ReadOnly = True
    End Sub

    Private Sub btn_vales_petroleo_Click(sender As Object, e As EventArgs) Handles btn_vales_petroleo.Click
        If chk_venta.Checked = True Then
            venta_promedio = 0
        Else
            venta_promedio = 1
        End If
        If rdbtn_documentos.Checked = True Then
            CR_EC_Cliente12.Show()
        ElseIf rdbtn_cartera.Checked = True Then
            CR_EC_Cliente11.Show()
        End If
    End Sub

    Private Sub btn_historial_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        CR_HIST_CLIENTE.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_todos.Click
        frm_filtro_ejecutivo.ShowDialog()
    End Sub
End Class