Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class CR_EC_Cliente12

    Private Sub CR_EC_Cliente11_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_clientes_cat3

        Report1.SetParameterValue("RUT", frm_estado_de_cuenta.txt_rut.Text)
        Report1.SetParameterValue("cliente_nom", frm_estado_de_cuenta.txt_cliente.Text)
        Report1.SetParameterValue("venta_promedio", venta_promedio)
        Report1.SetParameterValue("ver_senal", 0)
        CrystalReportViewer1.ReportSource = Report1
    End Sub

    Private Sub Estado_de_pago_clientes_cat1_InitReport(sender As Object, e As EventArgs) Handles Estado_de_pago_clientes_cat1.InitReport

    End Sub
End Class