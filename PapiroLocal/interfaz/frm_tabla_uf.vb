Public Class frm_tabla_uf

    Dim nue_usua As New clases.Tabla_UF
    Dim cod_usua As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_valor_uf.Clear()
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_fecha.Enabled = False
        txt_valor_uf.Enabled = False
        btn_nuevo.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_fecha.Enabled = True
        txt_valor_uf.Enabled = True
        btn_nuevo.Enabled = False
    End Sub

    Sub actualizar_dgv()
        dgv_usuario.DataSource = nue_usua.listar(Nombre_Obra)
        dgv_usuario.Columns(0).Visible = False
        dgv_usuario.Columns(2).Width = 170
        dgv_usuario.Columns(1).HeaderText = "Fecha"
        dgv_usuario.Columns(2).HeaderText = "Valor UF"
    End Sub

    Private Sub frm_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_valor_uf.Text <> "") Then
            Dim fecha = txt_fecha.Text
            Dim valor_uf = txt_valor_uf.Text
            Dim obra As String
            obra = txt_nombre_obra.Text
            If sw = 0 Then
                nue_usua.insertar(fecha, valor_uf, obra)
                actualizar_dgv()
            Else
                nue_usua.modificar(CInt(cod_usua), fecha, valor_uf, obra)
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
        txt_fecha.Text = dgv_usuario.CurrentRow.Cells(1).Value.ToString()
        txt_valor_uf.Text = dgv_usuario.CurrentRow.Cells(2).Value.ToString()
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