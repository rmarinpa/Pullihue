Public Class CR_informe_ejeuctivo


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Informe_ejecutivo

        Report1.SetParameterValue("fecha_in", frm_estado_de_pago.txt_fecha_in.Value)
        Report1.SetParameterValue("fecha_fin", frm_estado_de_pago.txt_fecha_fin.Value)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class