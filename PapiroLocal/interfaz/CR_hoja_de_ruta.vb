Public Class CR_hoja_de_ruta


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Ruta

        Report1.SetParameterValue("folio_ruta", Folio)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class