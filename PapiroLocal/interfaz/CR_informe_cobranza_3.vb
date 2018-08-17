Public Class CR_informe_cobranza_3


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Informe_cobranza_3

        Report1.SetParameterValue("fecha_ven_in", frm_informes_cobranza.dtp_fecha_in.Text)
        Report1.SetParameterValue("fecha_ven_fin", frm_informes_cobranza.dtp_fecha_fin.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class