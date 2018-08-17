Public Class frm_estado_de_pago
    Dim nue_cur As New clases.Estados_de_pago
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub btn_vales_petroleo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vales_petroleo.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) Then
            CR_informe_ejeuctivo.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) Then
            CR_informe_ejeuctivo_producto.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) Then
            CR_informe_categorias.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub
End Class