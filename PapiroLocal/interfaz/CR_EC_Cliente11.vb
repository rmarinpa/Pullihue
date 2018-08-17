Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class CR_EC_Cliente11

    Private Sub CR_EC_Cliente11_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_clientes_cat

        Report1.SetParameterValue("RUT", frm_estado_de_cuenta.txt_rut.Text)
        Report1.SetParameterValue("cliente_nom", frm_estado_de_cuenta.txt_cliente.Text)
        Report1.SetParameterValue("venta_promedio", venta_promedio)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class