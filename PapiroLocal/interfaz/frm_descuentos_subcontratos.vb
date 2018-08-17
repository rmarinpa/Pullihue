Imports System.Globalization
Public Class frm_descuentos_subcontratos


    Dim nue_cur As New clases.Descuentos_subcontratos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_representante.Clear()
        txt_tipo_subcontrato.Clear()
        txt_monto.Clear()
        txt_monto.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar(Nombre_Obra)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Código Subcontrato"
        dgv_curso.Columns(2).HeaderText = "Representante"
        dgv_curso.Columns(3).HeaderText = "Tipo Subcontrato"
        dgv_curso.Columns(4).HeaderText = "Ítem"
        dgv_curso.Columns(5).Visible = False
        dgv_curso.Columns(6).HeaderText = "Fecha"
        dgv_curso.Columns(7).HeaderText = "Monto"
        dgv_curso.Columns(8).HeaderText = "Obra"
        dgv_curso.Columns(9).HeaderText = "Cuenta Contable"
        dgv_curso.Columns(4).Width = 200
        dgv_curso.Columns(2).Width = 200


    End Sub
    Public Sub actualizar_representantes()
        cmb_codigo_subcontrato.DataSource = nue_cur.listar3(Nombre_Obra)
        cmb_codigo_subcontrato.DisplayMember = "Id_representante"
        cmb_codigo_subcontrato.ValueMember = "Id_representante"
    End Sub
    Public Sub actualizar_cuentas()
        cmb_cuenta_contable2.DataSource = nue_cur.listar2(Nombre_Obra)
        cmb_cuenta_contable2.DisplayMember = "Cuenta_costo"
        cmb_cuenta_contable2.ValueMember = "Cuenta_costo"
    End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        cmb_codigo_subcontrato.Enabled = False
        cmb_cuenta_contable2.Enabled = False
        txt_fecha.Enabled = False
        cmb_item.Enabled = False
        txt_monto.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        cmb_codigo_subcontrato.Enabled = True
        cmb_cuenta_contable2.Enabled = True
        txt_fecha.Enabled = True
        cmb_item.Enabled = True
        txt_monto.Enabled = True
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        actualizar_representantes()
        actualizar_cuentas()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        txt_representante.Enabled = False
        txt_tipo_subcontrato.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_representante.Text <> "" And txt_tipo_subcontrato.Text <> "" And txt_monto.Text <> "" And cmb_item.Text <> "" And cmb_codigo_subcontrato.Text <> "" And cmb_cuenta_contable2.Text <> "") Then
            Dim codigo_subcontrato, representante, tipo_subcontrato, item, cuenta_contable, obra, descripcion As String
            Dim monto As Double

            If txt_monto.Text > 0 Then
                txt_monto.Text = -txt_monto.Text
            End If
            codigo_subcontrato = cmb_codigo_subcontrato.Text
            representante = txt_representante.Text
            tipo_subcontrato = txt_tipo_subcontrato.Text
            item = cmb_item.Text
            monto = txt_monto.Text
            descripcion = ""
            cuenta_contable = cmb_cuenta_contable2.Text
            obra = txt_nombre_obra.Text

            If sw = 0 Then
                nue_cur.insertar(codigo_subcontrato, representante, tipo_subcontrato, item, descripcion, CDate(txt_fecha.Text), monto, obra, cuenta_contable)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), codigo_subcontrato, representante, tipo_subcontrato, item, descripcion, CDate(txt_fecha.Text), monto, obra, cuenta_contable)
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
        cmb_codigo_subcontrato.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_representante.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        txt_tipo_subcontrato.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
        cmb_item.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        txt_fecha.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        txt_monto.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        cmb_cuenta_contable2.Text = dgv_curso.CurrentRow.Cells(9).Value.ToString()

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
    Private Sub cmb_codigo_subcontrato_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_codigo_subcontrato.TextChanged
        txt_representante.Text = nue_cur.descripcion_representante(cmb_codigo_subcontrato.Text, txt_nombre_obra.Text)
        txt_tipo_subcontrato.Text = nue_cur.descripcion_tipo_subcontrato(cmb_codigo_subcontrato.Text, txt_nombre_obra.Text)
    End Sub

    Private Sub cmb_codigo_subcontrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codigo_subcontrato.SelectedIndexChanged
        txt_representante.Text = nue_cur.descripcion_representante(cmb_codigo_subcontrato.Text, txt_nombre_obra.Text)
        txt_tipo_subcontrato.Text = nue_cur.descripcion_tipo_subcontrato(cmb_codigo_subcontrato.Text, txt_nombre_obra.Text)
    End Sub
End Class