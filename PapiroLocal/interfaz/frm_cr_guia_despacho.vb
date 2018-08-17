Public Class frm_cr_guia_despacho

    Private Sub frm_cr_guia_despacho_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim reporte As New CR_guias_despachos

        reporte.SetParameterValue("folio_guia", CInt(Folio_ruta))
        cvr_guias_despachos.ReportSource = reporte
    End Sub
End Class