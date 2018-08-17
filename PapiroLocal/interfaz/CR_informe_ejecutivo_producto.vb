Public Class CR_informe_ejeuctivo_producto


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Informe_ejecutivo_productos

        Report1.SetParameterValue("fecha_in", frm_estado_de_pago.txt_fecha_in.Value)
        Report1.SetParameterValue("fecha_fin", frm_estado_de_pago.txt_fecha_fin.Value)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class