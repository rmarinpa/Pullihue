Public Class CR_Registro_llamada5


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Registro_llamada3

        Report1.SetParameterValue("fecha", frm_registro_llamadas.txt_fecha_in.Text)
        Report1.SetParameterValue("fecha_fin", frm_registro_llamadas.txt_fecha_fin.Text)
        Report1.SetParameterValue("Cliente", frm_registro_llamadas.cmb_cliente.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class