Public Class CR_guia_de_despacho_aut3
    Dim nue_report As New clases.Reemprimir
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Guia_de_despacho

        For Each Ctrl As Control In Me.CrystalReportViewer1.Controls
            If TypeOf Ctrl Is ToolStrip Then
                For Each Obj As Object In CType(Ctrl, ToolStrip).Items
                    If TypeOf Obj Is ToolStripButton Then
                        'Se agrega el disparador del evento
                        AddHandler CType(Obj, ToolStripButton).Click, AddressOf printButton_Click
                    End If
                Next
            End If
        Next

        Report1.SetParameterValue("numero_folio", Frm_visualizar_autorizar.txt_folio.Text)

        Report1.SetParameterValue("usuario_dup", Nombre_Obra)

        If nue_report.reemprimir(Frm_visualizar_autorizar.txt_folio.Text, 0) >= 1 Then
            Report1.SetParameterValue("ped_dup", 1)
        Else
            Report1.SetParameterValue("ped_dup", 0)
        End If
        CrystalReportViewer1.ReportSource = Report1
    End Sub

    Private Sub printButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim fecha, hora As Date
        Dim tipo_doc As Integer
        Dim numero_pedido, cuenta_imp As Double
        fecha = Today
        hora = TimeOfDay
        tipo_doc = 0
        numero_pedido = Frm_visualizar_autorizar.txt_folio.Text
        cuenta_imp = 1
        nue_report.insertar(Nombre_Obra, fecha, hora, tipo_doc, numero_pedido, cuenta_imp)
    End Sub
End Class