Public Class frm_menu_principal


    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Clientes_Productos.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_login.Show()
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_despacho2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frm_usuario_conf2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_ventas_mod.Show()
    End Sub

    Private Sub frm_menu_principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Application.Exit()
    End Sub

    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Location = New Point(25, 50)
        'Me.Size = New System.Drawing.Size(280, 750)
        TB_menu.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frm_registro_llamada.Show()
        frm_registro_llamada.txt_cobranza.Text = "Venta"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frm_asociar.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Frm_visualizar_autorizar.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Frm_sol_nota_credito.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Frm_rutas.Show()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frm_serv_tec.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        frm_representates_ejec2.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frm_estado_de_cuenta.Show()
    End Sub

    Private Sub btn_consultaFacNP_Click(sender As Object, e As EventArgs) Handles btn_consultaFacNP.Click
        frm_consulta_np.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Frm_clientes_busqueda_mapa.Show()
    End Sub
End Class