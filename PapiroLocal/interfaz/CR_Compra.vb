Public Class CR_Compra


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Compra

        Report1.SetParameterValue("numero_folio", Frm_compras.txt_folio_compra.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class