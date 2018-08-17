Public Class CR_Registro_llamada


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Registro_llamada

        Report1.SetParameterValue("fecha", frm_registro_llamada.txt_fecha.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class