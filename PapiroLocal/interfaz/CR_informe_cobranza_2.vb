﻿Public Class CR_informe_cobranza_2


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Informe_cobranza_2_mod

        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class