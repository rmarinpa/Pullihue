Public Class frm_tipo_subcontrato

    Dim nue_cur As New clases.Subcontrato
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_tipo_subcontrato.Clear()
        txt_descripcion.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).Width = 200
        dgv_curso.Columns(2).Width = 400
        dgv_curso.Columns(1).HeaderText = "Tipo de Subcontrato"
        dgv_curso.Columns(2).HeaderText = "Descripción"



    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_tipo_subcontrato.Enabled = False
        txt_descripcion.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_tipo_subcontrato.Enabled = True
        txt_descripcion.Enabled = True
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
        If (txt_tipo_subcontrato.Text <> "" And txt_descripcion.Text <> "") Then
            Dim tipo_subcontrato, descripcion As String

            tipo_subcontrato = txt_tipo_subcontrato.Text
            descripcion = txt_descripcion.Text

            If sw = 0 Then
                nue_cur.insertar(tipo_subcontrato, descripcion)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), tipo_subcontrato, descripcion)
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
        txt_tipo_subcontrato.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_descripcion.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
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
End Class