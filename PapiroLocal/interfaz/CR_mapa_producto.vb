Public Class CR_mapa_producto


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New mapa_productos

        Report1.SetParameterValue("fecha_in", Frm_clientes_busqueda_mapa.dtp_fecha_in.Value)
        Report1.SetParameterValue("fecha_fin", Frm_clientes_busqueda_mapa.dtp_fecha_fin.Value)
        Report1.SetParameterValue("rut", Frm_clientes_busqueda_mapa.txt_rut2.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class