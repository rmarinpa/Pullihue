Public Class CR_Nota_Credito_aut


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Nota_Credito_con

        Report1.SetParameterValue("folio", Frm_autorizar_nc.txt_folio.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class