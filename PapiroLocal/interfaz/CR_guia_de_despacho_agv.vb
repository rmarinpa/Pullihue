Public Class CR_guia_de_despacho_agv
    Dim nue_report As New clases.Reemprimir
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Guia_de_despacho_agv

        Report1.SetParameterValue("ejec_cobranza", frm_filtro_ejecutivo.cmb_ejecutivo.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub

    Private Sub printButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim fecha, hora As Date
        Dim tipo_doc As Integer
        Dim numero_pedido, cuenta_imp As Double
        fecha = Today
        hora = TimeOfDay
        tipo_doc = 0
        numero_pedido = Frm_consulta_pedido_fact.txt_pedido.Text
        cuenta_imp = 1
        nue_report.insertar(Nombre_Obra, fecha, hora, tipo_doc, numero_pedido, cuenta_imp)
    End Sub
End Class