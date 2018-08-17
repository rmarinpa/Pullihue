Public Class frm_curso

    Dim nue_cur As New clases.curso
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_nombre.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(1).Width = 170
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_nombre.Enabled = False
        btn_nuevo.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_nombre.Enabled = True
        btn_nuevo.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_nombre.Text <> "") Then
            Dim nom = txt_nombre.Text
            If sw = 0 Then
                nue_cur.insertar(nom)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), nom)
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
        txt_nombre.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub txt_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.LostFocus
        txt_nombre.Text = UCase(txt_nombre.Text)
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
    End Sub
End Class