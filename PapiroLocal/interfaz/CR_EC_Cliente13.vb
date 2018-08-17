Public Class CR_EC_Cliente13

    Private Sub CR_EC_Cliente11_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_clientes_cat3

        Report1.SetParameterValue("RUT", Frm_ventas_mod.txt_rut.Text)
        Report1.SetParameterValue("cliente_nom", Frm_ventas_mod.cmb_cliente.Text)
        Report1.SetParameterValue("venta_promedio", venta_promedio)
        Report1.SetParameterValue("ver_senal", 1)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class