Public Class CR_Estado_de_cuenta_todos_ejecutivos


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_clientes_todos_ejecutivo

        Report1.SetParameterValue("ejec_cobranza", frm_filtro_ejecutivo.cmb_ejecutivo.Text)

        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class