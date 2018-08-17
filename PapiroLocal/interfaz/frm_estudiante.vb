Public Class frm_estudiante

    Dim nue_est As New clases.estudiante
    Dim nue_var As New clases.variables
    Dim cod_est As String = ""
    Dim sw As Integer

    Sub bloquear()
        gbx_estudiante.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_estudiante.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
    End Sub

    Sub limpiar()
        txt_num_doc.Clear()
        txt_nombre.Clear()
        txt_apellido1.Clear()
        txt_apellido2.Clear()
        txt_direccion.Clear()
        txt_telefono.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_estudiante.DataSource = nue_est.listar()
        dgv_estudiante.Columns(0).Visible = False
    End Sub

    Private Sub frm_estudiante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim nom, ape1, ape2, dir As String
        Dim num_id, tel As Double
        If (txt_num_doc.Text <> "" And txt_nombre.Text <> "" And txt_apellido1.Text <> "" And txt_apellido2.Text <> "" And txt_direccion.Text <> "" And txt_telefono.Text <> "") Then
            nom = txt_nombre.Text
            num_id = Convert.ToInt64(txt_num_doc.Text)
            ape1 = txt_apellido1.Text
            ape2 = txt_apellido2.Text
            dir = txt_direccion.Text
            tel = Convert.ToInt64(txt_telefono.Text)
            If sw = 0 Then
                nue_est.insertar(num_id, nom, ape1, ape2, CDate(txt_fecha.Text), dir, tel)
                actualizar_dgv()
            Else
                nue_est.modificar(CInt(cod_est), num_id, nom, ape1, ape2, CDate(txt_fecha.Text), dir, tel)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (cod_est = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_estudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_estudiante.CellDoubleClick
        cod_est = dgv_estudiante.CurrentRow.Cells(0).Value.ToString()
        txt_num_doc.Text = dgv_estudiante.CurrentRow.Cells(1).Value.ToString()
        txt_nombre.Text = dgv_estudiante.CurrentRow.Cells(2).Value.ToString()
        txt_apellido1.Text = dgv_estudiante.CurrentRow.Cells(3).Value.ToString()
        txt_apellido2.Text = dgv_estudiante.CurrentRow.Cells(4).Value.ToString()
        txt_fecha.Text = dgv_estudiante.CurrentRow.Cells(5).Value.ToString()
        txt_direccion.Text = dgv_estudiante.CurrentRow.Cells(6).Value.ToString()
        txt_telefono.Text = dgv_estudiante.CurrentRow.Cells(7).Value.ToString()
    End Sub

    Private Sub txt_num_doc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_num_doc.KeyPress
        If nue_var.solo_numeros(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If nue_var.solo_numeros(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_direccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_direccion.LostFocus
        txt_direccion.Text = UCase(txt_direccion.Text)
    End Sub

    Private Sub txt_apellido2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_apellido2.LostFocus
        txt_apellido2.Text = UCase(txt_apellido2.Text)
    End Sub

    Private Sub txt_apellido1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_apellido1.LostFocus
        txt_apellido1.Text = UCase(txt_apellido1.Text)
    End Sub

    Private Sub txt_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.LostFocus
        txt_nombre.Text = UCase(txt_nombre.Text)
    End Sub

    Private Sub txt_num_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_num_doc.TextChanged

    End Sub
End Class