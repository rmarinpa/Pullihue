Public Class frm_usua_log

    Dim nue_report As New clases.Usuario_adm
    Dim nue_var As New clases.variables
    Dim Cod_Usuario As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Sub bloquear()
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
        txt_nombre.Enabled = False
        cmb_tipo.Enabled = False

    End Sub
    Sub desbloquear()
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
        txt_nombre.Enabled = True
        cmb_tipo.Enabled = True
    End Sub
    Sub limpiar()
        txt_nombre.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_usuarios.DataSource = nue_report.listar()
        dgv_usuarios.Columns(0).Visible = False
        dgv_usuarios.Columns(1).HeaderText = "Tipo Usuario"
        dgv_usuarios.Columns(2).HeaderText = "Nombre"
        dgv_usuarios.Columns(3).Visible = False
        dgv_usuarios.Columns(4).Visible = False
        dgv_usuarios.Columns(5).Visible = False

        dgv_usuarios.Columns(1).Width = 80
        dgv_usuarios.Columns(2).Width = 150
        dgv_usuarios.AllowUserToOrderColumns = True
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim usuario, tipo_nombre, modulo_nombre As String
        Dim tipo_id, modulo_id As Integer

        If (cmb_tipo.Text <> "" And txt_nombre.Text <> "") Then

            usuario = txt_nombre.Text
            tipo_nombre = cmb_tipo.Text
            modulo_id = 1
            modulo_nombre = "Logistica"
            tipo_id = 1

            If sw = 0 Then
                nue_report.insertar(tipo_nombre, usuario, tipo_id, modulo_nombre, modulo_id)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Usuario), tipo_nombre, usuario, tipo_id, modulo_nombre, modulo_id)
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
        If (Cod_Usuario = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub
    Private Sub dgv_Petroleo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        Cod_Usuario = dgv_usuarios.CurrentRow.Cells(0).Value.ToString()
        cmb_tipo.Text = dgv_usuarios.CurrentRow.Cells(1).Value.ToString()
        txt_nombre.Text = dgv_usuarios.CurrentRow.Cells(2).Value.ToString()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Usuario = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Usuario))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub
End Class