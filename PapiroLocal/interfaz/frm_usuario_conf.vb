Public Class frm_usuario_conf

    Dim nue_usua As New clases.usuario_conf
    Dim cod_usua As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_username.Clear()
        txt_password.Clear()
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_username.Enabled = False
        txt_password.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_username.Enabled = True
        txt_password.Enabled = True
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub actualizar_dgv()
        dgv_usuario.DataSource = nue_usua.listar()
        dgv_usuario.Columns(0).Visible = False
        dgv_usuario.Columns(1).Width = 100
        dgv_usuario.Columns(1).HeaderText = "Nombre"
        dgv_usuario.Columns(2).Visible = False
        dgv_usuario.Columns(3).HeaderText = "Departamento"
        dgv_usuario.Columns(3).Width = 140
    End Sub

    Private Sub frm_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_username.Text <> "" And txt_password.Text <> "") Then
            Dim nom, pass, departamento As String
            nom = txt_username.Text
            pass = txt_password.Text
            departamento = cmb_departamento.Text
            If sw = 0 Then
                nue_usua.insertar(nom, pass, departamento)
                actualizar_dgv()
            Else
                nue_usua.modificar(CInt(cod_usua), nom, pass, departamento)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (cod_usua = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            sw = 1
            desbloquear()
        End If
    End Sub

    Private Sub dgv_curso_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_usuario.CellDoubleClick
        cod_usua = dgv_usuario.CurrentRow.Cells(0).Value.ToString()
        txt_username.Text = dgv_usuario.CurrentRow.Cells(1).Value.ToString()
        txt_password.Text = dgv_usuario.CurrentRow.Cells(2).Value.ToString()
        cmb_departamento.Text = dgv_usuario.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub txt_username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.LostFocus
        txt_username.Text = UCase(txt_username.Text)
    End Sub

    Private Sub txt_password_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.LostFocus
        txt_password.Text = UCase(txt_password.Text)
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (cod_usua = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_usua.eliminar(CInt(cod_usua))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub
End Class