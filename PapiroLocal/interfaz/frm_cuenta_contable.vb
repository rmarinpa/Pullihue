Public Class frm_cuenta_contable

    Dim nue_cur As New clases.Cuentas_Contables
    Dim cod_cur As String = ""
    Dim sw As Integer

    Public Sub actualizar_contratos()
        txt_codigo.DataSource = nue_cur.listar2(Nombre_Obra)
        txt_codigo.DisplayMember = "Codigo_maquina"
        txt_codigo.ValueMember = "Id_contrato"
    End Sub
    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar(Nombre_Obra)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(2).Width = 200
        dgv_curso.Columns(3).Width = 200
        dgv_curso.Columns(1).HeaderText = "Código"
        dgv_curso.Columns(2).HeaderText = "Cuenta Contable Petróleo"
        dgv_curso.Columns(3).HeaderText = "Cuenta Contable Maquinaria"
        dgv_curso.Columns(4).HeaderText = "Obra"
    End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        cmb_cuenta_maquinaria.Enabled = False
        cmb_cuenta_petroleo.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        cmb_cuenta_maquinaria.Enabled = True
        cmb_cuenta_petroleo.Enabled = True
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        bloquear()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        actualizar_contratos()
        actualizar_cuentas()
        actualizar_cuentas2()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (cmb_cuenta_maquinaria.Text <> "" And cmb_cuenta_petroleo.Text <> "") Then
            Dim cod_maq, cuenta_contable, cuenta_contable_maq, obra As String

            cod_maq = txt_codigo.Text
            cuenta_contable = cmb_cuenta_petroleo.Text
            cuenta_contable_maq = cmb_cuenta_maquinaria.Text
            obra = txt_nombre_obra.Text

            If sw = 0 Then
                nue_cur.insertar(cod_maq, cuenta_contable, cuenta_contable_maq, obra)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), cod_maq, cuenta_contable, cuenta_contable_maq, obra)
                actualizar_dgv()
            End If
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
        txt_codigo.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        cmb_cuenta_petroleo.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        cmb_cuenta_maquinaria.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()


    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
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
    Public Sub actualizar_cuentas()
        cmb_cuenta_maquinaria.DataSource = nue_cur.listar3(Nombre_Obra)
        cmb_cuenta_maquinaria.DisplayMember = "Cuenta_costo"
        cmb_cuenta_maquinaria.ValueMember = "Cuenta_costo"
    End Sub
    Public Sub actualizar_cuentas2()
        cmb_cuenta_petroleo.DataSource = nue_cur.listar4(Nombre_Obra)
        cmb_cuenta_petroleo.DisplayMember = "Cuenta_costo"
        cmb_cuenta_petroleo.ValueMember = "Cuenta_costo"
    End Sub
End Class