﻿Public Class CR_obs_llegada


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Obs_llegada

        Report1.SetParameterValue("numero_folio", frm_registro_llegada2.cmb_folio.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class