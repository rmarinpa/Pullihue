Public Class CR_orden_retiro2


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New retiro_documentos

        Report1.SetParameterValue("numero_folio", folio_retiro)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class