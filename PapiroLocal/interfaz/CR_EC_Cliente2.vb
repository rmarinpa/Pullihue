Public Class CR_EC_Cliente2


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_clientes_cat3

        Report1.SetParameterValue("RUT", frm_estado_de_cuenta.txt_rut.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class