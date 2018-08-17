Public Class CR_Resumen_llamada


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Resumen_llamada

        Report1.SetParameterValue("fecha", frm_registro_llamadas.txt_fecha_in.Text)
        Report1.SetParameterValue("fecha_fin", frm_registro_llamadas.txt_fecha_fin.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class