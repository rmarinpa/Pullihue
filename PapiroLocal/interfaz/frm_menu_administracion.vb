Public Class frm_menu_administracion

    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_contratos.Click
        Frm_consulta_pedido.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_usuario_conf.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frm_Clientes_Productos.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_estado_de_pago.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Frm_compras.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_registro_llamadas.Show()
    End Sub

    Private Sub frm_menu_administracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(25, 50)
        If Nombre_Obra = "TBUSTOS" Or Nombre_Obra = "AGODOY" Or Nombre_Obra = "SBUSTOS" Or Nombre_Obra = "RBUSTOS" Or Nombre_Obra = "GSOLIS" Or Nombre_Obra = "JTOBAR" Or Nombre_Obra = "CVALENZUELA" Or Nombre_Obra = "RVALDIVIESO" Then
            pict_aut.Visible = True
            btn_aut.Visible = True
        Else
        End If
    End Sub

    Private Sub btn_aut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aut.Click
        frm_menu_autorizacion.Show()
    End Sub

    Private Sub btn_controlGuiaDespacho_Click(sender As Object, e As EventArgs) Handles btn_controlGuiaDespacho.Click
        frm_menu_guias.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frm_usuarios_adm.Show()
    End Sub

    Private Sub btn_retiroDocumento_Click(sender As Object, e As EventArgs) Handles btn_retiroDocumento.Click
        Frm_consulta_pedido_retiro.Show()
    End Sub

    Private Sub btn_ofertas_Click(sender As Object, e As EventArgs) Handles btn_ofertas.Click
        frm_menu_alertas.Show()
    End Sub
End Class