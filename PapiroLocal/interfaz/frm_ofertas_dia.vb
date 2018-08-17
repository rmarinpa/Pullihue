Public Class frm_ofertas_dia

    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""

    Sub actualizar_ofertas()
        dgv_oferta.DataSource = nue_report.listar11()
        dgv_oferta.Columns(0).Visible = False
        dgv_oferta.Columns(1).Visible = False
        dgv_oferta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_oferta.Columns(2).Width = 500
        dgv_oferta.Columns(2).HeaderText = "OFERTA"
        dgv_oferta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub frm_ofertas_dia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_ofertas()
    End Sub
End Class