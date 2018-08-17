Public Class frm_tipo_trabajo

    Dim nue_cur As New clases.tipo_trabajo
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_categoria.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).Width = 300
        dgv_curso.Columns(2).Width = 300
        dgv_curso.Columns(3).Width = 300
        dgv_curso.Columns(1).HeaderText = "Código"
        dgv_curso.Columns(2).HeaderText = "Tipo de Trabajo"
        dgv_curso.Columns(3).HeaderText = "Cuenta Contable"



    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_categoria.Enabled = False
        cmb_cuenta_contable.Enabled = False
        cmb_codigo.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_categoria.Enabled = True
        cmb_cuenta_contable.Enabled = True
        cmb_codigo.Enabled = True
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        bloquear()
        actualizar_contratos()
        actualizar_cuentas()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_categoria.Text <> "" And cmb_cuenta_contable.Text <> "") Then
            Dim codigo, categoria, cuenta_contable, obra As String

            codigo = cmb_codigo.Text
            categoria = txt_categoria.Text
            cuenta_contable = cmb_cuenta_contable.Text
            obra = txt_nombre_obra.Text
            If sw = 0 Then
                nue_cur.insertar(codigo, categoria, cuenta_contable, obra)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), codigo, categoria, cuenta_contable, obra)
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
        cmb_codigo.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_categoria.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        cmb_cuenta_contable.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
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

    Public Sub actualizar_contratos()
        cmb_codigo.DataSource = nue_cur.listar2(Nombre_Obra)
        cmb_codigo.DisplayMember = "Codigo_maquina"
        cmb_codigo.ValueMember = "Id_contrato"
    End Sub
    Public Sub actualizar_cuentas()
        cmb_cuenta_contable.DataSource = nue_cur.listar3(Nombre_Obra)
        cmb_cuenta_contable.DisplayMember = "Cuenta_costo"
        cmb_cuenta_contable.ValueMember = "Cuenta_costo"
    End Sub

    Private Sub cmb_codigo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_codigo.MouseClick
        actualizar_contratos()
    End Sub

    Private Sub cmb_codigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codigo.SelectedIndexChanged

    End Sub

    Private Sub cmb_cuenta_contable_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_cuenta_contable.MouseClick
        actualizar_cuentas()
    End Sub

    Private Sub cmb_cuenta_contable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cuenta_contable.SelectedIndexChanged

    End Sub
End Class