Public Class CR_guia_aut


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Guia_nota

        Report1.SetParameterValue("numero_folio", Frm_autorizar_gd.txt_folio.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class