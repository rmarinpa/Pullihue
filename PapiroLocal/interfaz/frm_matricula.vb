Public Class frm_matricula

    Dim nue_mat As New clases.matricula
    Dim nue_cur As New clases.curso
    Dim nue_jor As New clases.jornada
    Dim nue_est As New clases.estudiante
    Dim nue_var As New clases.variables
    Dim cod_estu As String = ""
    Dim cod_usua As Integer = frm_login.cod_usua

    Sub bloquear()
        gbx_busq_est.Enabled = False
        gbx_info_mat.Enabled = False
        btn_nuevo.Enabled = True
        btn_guardar.Enabled = False
        btn_cancelar.Enabled = False
    End Sub

    Sub desbloquear()
        gbx_busq_est.Enabled = True
        gbx_info_mat.Enabled = True
        btn_nuevo.Enabled = False
        btn_guardar.Enabled = True
        btn_cancelar.Enabled = True
    End Sub

    Sub limpiar()
        txt_apellido1.Clear()
        txt_monto.Clear()
        txt_num_doc.Clear()
        txt_nombre.Clear()
    End Sub

    Sub actualizar_cursos()
        cmbx_curso.DataSource = nue_cur.listar()
        cmbx_curso.DisplayMember = "nombre"
        cmbx_curso.ValueMember = "cod_curso"
    End Sub

    Sub actualizar_jornadas()
        cmbx_jornada.DataSource = nue_jor.listar()
        cmbx_jornada.DisplayMember = "nombre"
        cmbx_jornada.ValueMember = "cod_jornada"
    End Sub

    Sub actualizar_dgv()
        dgv_matricula.DataSource = nue_mat.listar()
        'de aqui en adelante solo oculto las columnas del inner join que no me interesa mostrar
        'en el dtagridview donde se realizan las matriculas 
        '(recordar que en la tabla matricula solo se guardan codigos o ids de las otras tablas que estan relacionadas)
        dgv_matricula.Columns(0).Visible = False
        dgv_matricula.Columns(2).Visible = False
        dgv_matricula.Columns(3).Visible = False
        dgv_matricula.Columns(4).Visible = False
        dgv_matricula.Columns(7).Visible = False
        dgv_matricula.Columns(8).Visible = False
        dgv_matricula.Columns(9).Visible = False
        dgv_matricula.Columns(11).HeaderText = "apellido"
        dgv_matricula.Columns(12).Visible = False
        dgv_matricula.Columns(13).Visible = False
        dgv_matricula.Columns(14).Visible = False
        dgv_matricula.Columns(15).Visible = False
        dgv_matricula.Columns(16).Visible = False
        dgv_matricula.Columns(17).HeaderText = "curso"
        dgv_matricula.Columns(18).Visible = False
        dgv_matricula.Columns(19).HeaderText = "jornada"
        dgv_matricula.Columns(20).Visible = False
        dgv_matricula.Columns(21).HeaderText = "emitida por"
        dgv_matricula.Columns(22).Visible = False
    End Sub

    Private Sub frm_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        actualizar_cursos()
        actualizar_jornadas()
        bloquear()
        lbl_usuario.Text = frm_login.usuario
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim cod_curso, cod_jor As Integer
        Dim monto As Double
        Dim tipo_mat As String
        If (txt_num_doc.Text <> "" And txt_nombre.Text <> "" And txt_apellido1.Text <> "" And cmbx_curso.Text <> "" And cmbx_jornada.Text <> "" And txt_monto.Text <> "" And (rbtn_nueva.Checked = True Or rbtn_renovacion.Checked = True)) Then
            If rbtn_nueva.Checked = True Then
                tipo_mat = rbtn_nueva.Text
            Else
                tipo_mat = rbtn_renovacion.Text
            End If
            cod_jor = CInt(cmbx_jornada.SelectedValue)
            cod_curso = CInt(cmbx_curso.SelectedValue)
            monto = Convert.ToInt64(txt_monto.Text)
            nue_mat.insertar(tipo_mat, CInt(cod_estu), cod_curso, cod_jor, CDate(txt_fecha.Text), monto, cod_usua)
            limpiar()
            actualizar_dgv()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If txt_num_doc.Text <> "" Then
            txt_nombre.Clear()
            txt_apellido1.Clear()
            If nue_est.verificar(Val(txt_num_doc.Text)) = True Then
                txt_nombre.Text = nue_est.nombre_estudiante(Val(txt_num_doc.Text))
                txt_apellido1.Text = nue_est.apellido_estudiante(Val(txt_num_doc.Text))
                cod_estu = nue_est.cod_estudiante(Val(txt_num_doc.Text))
            Else
                MessageBox.Show("EL NUMERO INGRESADO NO PERTENECE A NINGUN ESTUDIANTE REGISTRADO")
            End If
        Else
            MessageBox.Show("LLENA ESTE CAMPO")
        End If
    End Sub

    Private Sub txt_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto.KeyPress
        If nue_var.solo_numeros(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_num_doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num_doc.KeyPress
        If nue_var.solo_numeros(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class