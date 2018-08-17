Public Class CR_autorizacion


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Libro_autorizacion2

        Report1.SetParameterValue("Fecha", Frm_visualizar_autorizar.dtp_fecha.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class