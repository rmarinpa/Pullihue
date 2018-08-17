Public Class CR_Rutas


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New resumen_rutas
        Dim fecha As String
        Dim fecha2 As String
        fecha = Frm_consulta_pedido.txt_fecha.Value.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")
        fecha2 = Frm_consulta_pedido.dtp_fecha_in.Value.ToShortDateString
        fecha2 = Format(CDate(fecha2), "yyyy/MM/dd")
        Report1.SetParameterValue("fecha_fin", fecha)
        Report1.SetParameterValue("fecha_in", fecha2)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class