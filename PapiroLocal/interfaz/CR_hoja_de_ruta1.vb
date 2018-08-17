Public Class CR_hoja_de_ruta1


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Ruta

        Report1.SetParameterValue("folio_ruta", frm_registro_ruta.cmb_folio.Text)
        Report1.SetParameterValue("revisa", frm_registro_ruta.txt_revisa.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class