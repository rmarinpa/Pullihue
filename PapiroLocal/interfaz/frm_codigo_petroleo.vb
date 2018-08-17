Public Class frm_codigo_petroleo

    Private Sub btn_vales_petroleo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vales_petroleo.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then
            CR_Codigo_petroleo.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frm_codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        txt_stock_anterior.Text = 0
    End Sub
    Private Sub btn_libro_compras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_libro_compras.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And txt_stock_anterior.Text <> "" Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) Then

        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub
End Class