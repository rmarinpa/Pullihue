Imports clases.conexion
Public Class frm_login

    Dim nue_usua As New clases.usuario
    Public var As String
    Public usuario As String = ""
    Public cod_usua As Integer = 0

    Public Sub actualizar_obras()
        cmb_obra.DataSource = nue_usua.listar2
        cmb_obra.DisplayMember = "Nombre"
        cmb_obra.ValueMember = "Nombre"
    End Sub

    Public Sub btn_entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entrar.Click

        If txt_password.Text <> "" And txt_username.Text <> "" Then
            If nue_usua.verificar(txt_username.Text, txt_password.Text, cmb_obra.Text) = True Then
                usuario = txt_username.Text
                cod_usua = nue_usua.cod_usuario(txt_username.Text, txt_password.Text)

                If cmb_obra.Text = "Administración" Then
                    Nombre_Obra = usuario
                    frm_menu_administracion.Enabled = True
                    frm_menu_administracion.Show()
                ElseIf cmb_obra.Text = "Ventas" Then
                    Nombre_Obra = usuario
                    frm_menu_principal.Enabled = True
                    frm_menu_principal.Show()
                ElseIf cmb_obra.Text = "Administración II" Then
                    Nombre_Obra = usuario
                    frm_menu_administracion2.Enabled = True
                    frm_menu_administracion2.Show()
                ElseIf cmb_obra.Text = "Cobranza" Then
                    Nombre_Obra = usuario
                    frm_menu_cobranza.Enabled = True
                    frm_menu_cobranza.Show()
                ElseIf cmb_obra.Text = "Logistica" Then
                    Nombre_Obra = usuario
                    frm_menu_logistica.Enabled = True
                    frm_menu_logistica.Show()
                ElseIf cmb_obra.Text = "Servicio Técnico" Then
                    Nombre_Obra = usuario
                    frm_menu_servicio.Enabled = True
                    frm_menu_servicio.Show()
                ElseIf cmb_obra.Text = "Facturación" Then
                    Nombre_Obra = usuario
                    frm_menu_facturacion.Enabled = True
                    frm_menu_facturacion.Show()
                ElseIf cmb_obra.Text = "Ticket" Then
                    'If usuario.Equals("GSOLIS") Or usuario.Equals("RBUSTOS") Or usuario.Equals("JTOBAR") Or usuario.Equals("CVALENZUELA") Then
                    Nombre_Obra = usuario
                    frm_ticket_solicitud.Enabled = True
                    frm_ticket_solicitud.Show()
                    'Else
                    'MsgBox("Usted no posee acceso a este módulo.")
                    'End If

                End If

                Me.Hide()

            Else
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS")
            End If
        Else
            MessageBox.Show("ESCRIBA SU NOMBRE DE USUARIO Y SU CONTRASEÑA")
        End If
    End Sub

    Private Sub txt_username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.LostFocus
        txt_username.Text = UCase(txt_username.Text)
    End Sub

    Private Sub txt_password_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.LostFocus
        txt_password.Text = UCase(txt_password.Text)
    End Sub
    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_obras()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class