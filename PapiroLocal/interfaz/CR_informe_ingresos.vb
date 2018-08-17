Public Class CR_informe_ingresos


    Private Sub CR_Codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New Informe_ingresos
        Dim oper1, oper2, oper3, oper4, oper5 As String

        If frm_menu_inf_pagos.chk_pago1.Checked = True Then
            oper1 = "CHEQUE"
        Else
            oper1 = ""
        End If

        If frm_menu_inf_pagos.chk_pago2.Checked = True Then
            oper2 = "DEPOSITO DIRECTO"
        Else
            oper2 = ""
        End If

        If frm_menu_inf_pagos.chk_pago3.Checked = True Then
            oper3 = "EFECTIVO"
        Else
            oper3 = ""
        End If

        If frm_menu_inf_pagos.chk_pago4.Checked = True Then
            oper4 = "TRANSFERENCIA"
        Else
            oper4 = ""
        End If

        If frm_menu_inf_pagos.chk_pago5.Checked = True Then
            oper5 = "OTROS"
        Else
            oper5 = ""
        End If

        Report1.SetParameterValue("fecha_in", frm_menu_inf_pagos.txt_fecha_in.Text)
        Report1.SetParameterValue("fecha_fin", frm_menu_inf_pagos.txt_fecha_fin.Text)
        Report1.SetParameterValue("oper1", oper1)
        Report1.SetParameterValue("oper2", oper2)
        Report1.SetParameterValue("oper3", oper3)
        Report1.SetParameterValue("oper4", oper4)
        Report1.SetParameterValue("oper5", oper5)
        CrystalReportViewer1.ReportSource = Report1


    End Sub
End Class