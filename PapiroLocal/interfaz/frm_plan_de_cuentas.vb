Public Class frm_plan_de_cuentas

    Dim nue_usua As New clases.Plan_de_cuentas
    Dim cod_usua As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_cuenta_costo.Clear()
        txt_descripcion.Clear()
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_cuenta_costo.Enabled = False
        txt_descripcion.Enabled = False
        btn_nuevo.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_cuenta_costo.Enabled = True
        txt_descripcion.Enabled = True
        btn_nuevo.Enabled = False
    End Sub

    Sub actualizar_dgv()
        dgv_usuario.DataSource = nue_usua.listar(Nombre_Obra)
        dgv_usuario.Columns(0).Visible = False
        dgv_usuario.Columns(2).Width = 170
        dgv_usuario.Columns(1).HeaderText = "Cuenta Costo"
        dgv_usuario.Columns(2).HeaderText = "Descripción"
    End Sub

    Private Sub frm_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_cuenta_costo.Text <> "") Then
            Dim nom = txt_cuenta_costo.Text
            Dim pass = txt_descripcion.Text
            Dim obra As String
            obra = txt_nombre_obra.Text
            If sw = 0 Then
                nue_usua.insertar(nom, pass, obra)
                actualizar_dgv()
            Else
                nue_usua.modificar(CInt(cod_usua), nom, pass, obra)
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
        txt_cuenta_costo.Text = dgv_usuario.CurrentRow.Cells(1).Value.ToString()
        txt_descripcion.Text = dgv_usuario.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub txt_username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cuenta_costo.LostFocus
        txt_cuenta_costo.Text = UCase(txt_cuenta_costo.Text)
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        limpiar()
        desbloquear()
        sw = 0

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