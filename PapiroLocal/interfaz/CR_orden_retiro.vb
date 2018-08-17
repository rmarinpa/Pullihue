Public Class CR_orden_retiro


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New retiro_documentos

        Report1.SetParameterValue("numero_folio", frm_retiro_documentos_2.txt_folio2.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class