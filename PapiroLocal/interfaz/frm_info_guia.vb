Public Class frm_info_guia
    Dim nue_report As New clases.guias_despacho

    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(100, 100)
        actualizar_guia()

    End Sub

    Private Sub btn_direccion_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Me.Close()
    End Sub

    Sub actualizar_guia()
        'dgv_nota_credito.DataSource = nueva_notaCredito.buscaNotasCredito(txt_factura_ref.Text) ' busca si la factura tiene alguna nota de credito asociada.
        dgv_Mov_Tierra.DataSource = nue_report.listar27(Frm_ventas_mod.txt_rut.Text)

        dgv_Mov_Tierra.Columns(0).Visible = True
        dgv_Mov_Tierra.Columns(1).Visible = True
        dgv_Mov_Tierra.Columns(3).Visible = True
        dgv_Mov_Tierra.Columns(0).HeaderText = "N° Factura"
        dgv_Mov_Tierra.Columns(1).HeaderText = "Fecha Factura"
        dgv_Mov_Tierra.Columns(2).Visible = False
        dgv_Mov_Tierra.Columns(3).HeaderText = "Descripción"
        dgv_Mov_Tierra.Columns(4).HeaderText = "Medidas"
        dgv_Mov_Tierra.Columns(5).HeaderText = "Q"
        dgv_Mov_Tierra.Columns(6).HeaderText = "Entreg."
        dgv_Mov_Tierra.Columns(7).HeaderText = "Saldo"
        dgv_Mov_Tierra.Columns(8).Visible = False

        dgv_Mov_Tierra.Columns(0).Width = 70
        dgv_Mov_Tierra.Columns(1).Width = 70
        dgv_Mov_Tierra.Columns(3).Width = 200
        dgv_Mov_Tierra.Columns(4).Width = 80
        dgv_Mov_Tierra.Columns(5).Width = 80
        dgv_Mov_Tierra.Columns(6).Width = 80
        dgv_Mov_Tierra.Columns(7).Width = 80
        'dgv_Mov_Tierra.Columns(5).DefaultCellStyle.Format = "##,###.##"
        'dgv_Mov_Tierra.Columns(7).DefaultCellStyle.Format = "##,###.##"
        dgv_Mov_Tierra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Mov_Tierra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_Mov_Tierra.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'If (dgv_nota_credito.RowCount > 0) Then
        '    QuitarPedidosNotaCredito(dgv_nota_credito.RowCount, dgv_Mov_Tierra.RowCount)
        'End If
    End Sub
End Class