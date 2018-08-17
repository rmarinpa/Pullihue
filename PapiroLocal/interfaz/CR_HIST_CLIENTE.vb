Public Class CR_HIST_CLIENTE


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Registro_cliente

        Report1.SetParameterValue("rut_cliente", frm_estado_de_cuenta.txt_rut.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class