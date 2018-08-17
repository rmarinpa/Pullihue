Public Class frm_parametros_configuracion

    Dim nue_usua As New clases.Parametros_configuracion
    Dim cod_usua As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_profesional_residente.Clear()
        txt_oficina_tecnica.Clear()
        txt_obra.Clear()
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_profesional_residente.Enabled = False
        txt_oficina_tecnica.Enabled = False
        txt_obra.Enabled = False
        btn_nuevo.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_profesional_residente.Enabled = True
        txt_oficina_tecnica.Enabled = True
        txt_obra.Enabled = True
        btn_nuevo.Enabled = False
    End Sub

    Sub actualizar_dgv()
        dgv_usuario.DataSource = nue_usua.listar(Nombre_Obra)
        dgv_usuario.Columns(0).Visible = False
        dgv_usuario.Columns(1).Width = 100
        dgv_usuario.Columns(2).Width = 100
        dgv_usuario.Columns(3).Width = 100
        dgv_usuario.Columns(4).Width = 300
        dgv_usuario.Columns(1).DisplayIndex = 2
        dgv_usuario.Columns(2).DisplayIndex = 1
        dgv_usuario.Columns(1).HeaderText = "Encargado Oficina Técnica"
        dgv_usuario.Columns(2).HeaderText = "Profesional residente"
        dgv_usuario.Columns(3).HeaderText = "Obra"
        dgv_usuario.Columns(4).HeaderText = "Detalle de Obra"
    End Sub

    Private Sub frm_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_profesional_residente.Text <> "") Then
            Dim pass = txt_profesional_residente.Text
            Dim nom = txt_oficina_tecnica.Text
            Dim detalle = txt_obra.Text
            Dim obra As String
            obra = txt_nombre_obra.Text
            If sw = 0 Then
                nue_usua.insertar(nom, pass, obra, detalle)
                actualizar_dgv()
            Else
                nue_usua.modificar(CInt(cod_usua), nom, pass, obra, detalle)
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
        txt_oficina_tecnica.Text = dgv_usuario.CurrentRow.Cells(1).Value.ToString()
        txt_profesional_residente.Text = dgv_usuario.CurrentRow.Cells(2).Value.ToString()
        txt_obra.Text = dgv_usuario.CurrentRow.Cells(4).Value.ToString()
    End Sub


    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        limpiar()
        desbloquear()
        sw = 0

    End Sub
End Class