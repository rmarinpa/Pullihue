﻿Public Class CR_informe_cobranza_5


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Informe_cobranza_5

        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class