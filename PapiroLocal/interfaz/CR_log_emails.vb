Public Class CR_log_emails


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Email_logs

        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class