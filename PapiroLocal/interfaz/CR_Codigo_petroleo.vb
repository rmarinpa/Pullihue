Public Class CR_Codigo_petroleo


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Crrevision_petroleo

        Report1.SetParameterValue("Fecha_in", frm_codigo_petroleo.txt_fecha_in.Text)
        Report1.SetParameterValue("Fecha_fin", frm_codigo_petroleo.txt_fecha_fin.Text)
        Report1.SetParameterValue("Obra", frm_codigo_petroleo.txt_nombre_obra.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class