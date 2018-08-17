Public Class CR_guia_de_despacho5


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Guia_nota

        Report1.SetParameterValue("numero_folio", Frm_consulta_guia.txt_pedido.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class