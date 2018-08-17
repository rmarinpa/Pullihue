Public Class CR_Estado_de_cuenta_todos


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_clientes_todos

        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class