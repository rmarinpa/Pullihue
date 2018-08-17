Public Class frm_categoria_maq


    Dim nue_cur As New clases.categoria_maquina
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_categoria.Clear()
        txt_capacidad.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).Width = 300
        dgv_curso.Columns(2).Width = 300
        dgv_curso.Columns(3).Width = 300
        dgv_curso.Columns(1).HeaderText = "Tipo de Categoría"
        dgv_curso.Columns(2).HeaderText = "Capacidad"
        dgv_curso.Columns(3).HeaderText = "Unidad"



    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_categoria.Enabled = False
        txt_capacidad.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_categoria.Enabled = True
        txt_capacidad.Enabled = True
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        bloquear()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_categoria.Text <> "" And txt_capacidad.Text <> "") Then
            Dim categoria, tipo_de_maquina, unidad As String

            categoria = txt_categoria.Text
            tipo_de_maquina = txt_capacidad.Text
            unidad = cmb_unidad.Text
            If sw = 0 Then
                nue_cur.insertar(categoria, tipo_de_maquina, unidad)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), categoria, tipo_de_maquina, unidad)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (cod_cur = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            sw = 1
            desbloquear()
        End If
    End Sub

    Private Sub dgv_curso_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_curso.CellDoubleClick
        cod_cur = dgv_curso.CurrentRow.Cells(0).Value.ToString()
        txt_categoria.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_capacidad.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        cmb_unidad.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (cod_cur = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_cur.eliminar(CInt(cod_cur))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class