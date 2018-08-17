Public Class CR_detalle_venta


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Ventas

        Report1.SetParameterValue("cliente", Frm_ventas.cmb_cliente.Text)
        Report1.SetParameterValue("numero_pedido", Frm_ventas.txt_numero_pedido.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class