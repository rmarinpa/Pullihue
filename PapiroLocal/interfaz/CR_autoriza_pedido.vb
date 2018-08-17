Public Class CR_autoriza_pedido
    Dim nue_report As New clases.Reemprimir
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Guia_de_despacho

        Report1.SetParameterValue("numero_folio", Folio_ruta)
        Report1.SetParameterValue("usuario_dup", Nombre_Obra)

        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class