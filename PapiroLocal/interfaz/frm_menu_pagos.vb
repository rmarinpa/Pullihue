Imports System.Globalization
Public Class frm_menu_pagos

    Dim nue_cur As New clases.Registro_pagos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub


    Private Sub btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar.Click
        frm_registro_pagos.Show()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingreso.Click
        frm_menu_inf_pagos.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_mod_pagos.Show()
    End Sub

    Private Sub btn_consultaCheue_Click(sender As Object, e As EventArgs) Handles btn_consultaCheue.Click
        frm_consultaCheque.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cobranza.Click
        CR_Estado_de_cuenta_ejecutivos.Show()
    End Sub
End Class