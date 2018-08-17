Imports System.Globalization
Public Class frm_registro_subcontrato

    Dim nue_cur As New clases.registro_subcontrato
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_glosa.Clear()
        txt_precio.Clear()
        txt_representante.Clear()
        txt_tipo_subcontrato.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar(Nombre_Obra)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Código Subcontrato"
        dgv_curso.Columns(2).HeaderText = "Representante"
        dgv_curso.Columns(3).HeaderText = "Tipo de subcontrato"
        dgv_curso.Columns(4).HeaderText = "Glosa"
        dgv_curso.Columns(4).Width = 300
        dgv_curso.Columns(12).DisplayIndex = 4
        dgv_curso.Columns(10).DisplayIndex = 5
        dgv_curso.Columns(11).DisplayIndex = 6
        dgv_curso.Columns(5).HeaderText = "Forma de Pago"
        dgv_curso.Columns(6).HeaderText = "Precio"
        dgv_curso.Columns(7).HeaderText = "Tipo de Medición"
        dgv_curso.Columns(8).HeaderText = "Cuenta Costo"
        dgv_curso.Columns(9).HeaderText = "Obra"
        dgv_curso.Columns(10).HeaderText = "Cantidad Contratada"
        dgv_curso.Columns(11).HeaderText = "Cantidad Modificación"
        dgv_curso.Columns(12).HeaderText = "Tipo Registro"
    End Sub
    Public Sub actualizar_subcontrato()
        cmb_codigo_subcontrato.DataSource = nue_cur.listar2(Nombre_Obra)
        cmb_codigo_subcontrato.DisplayMember = "Id_representante"
        cmb_codigo_subcontrato.ValueMember = "Id_representante"
    End Sub
    Public Sub actualizar_cuenta_costo()
        cmb_cuenta_costo.DataSource = nue_cur.listar3(Nombre_Obra)
        cmb_cuenta_costo.DisplayMember = "Cuenta_costo"
        cmb_cuenta_costo.ValueMember = "Cuenta_costo"
    End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_glosa.Enabled = False
        txt_precio.Enabled = False
        txt_cantidad_contratada.Enabled = False
        txt_cantidad_modificacion.Enabled = False
        cmb_forma_de_pago.Enabled = False
        txt_precio.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_glosa.Enabled = True
        txt_precio.Enabled = True
        txt_cantidad_contratada.Enabled = True
        txt_cantidad_modificacion.Enabled = True
        cmb_forma_de_pago.Enabled = True
        txt_precio.Enabled = True
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        bloquear()
        actualizar_subcontrato()
        actualizar_cuenta_costo()
        txt_nombre_obra.Text = Nombre_Obra
        txt_cantidad_modificacion.Text = 0
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
        If (txt_representante.Text <> "" And txt_tipo_subcontrato.Text <> "" And txt_precio.Text <> "" And txt_glosa.Text <> "") Then
            Dim cod_subcontrato, representante, tipo_subcontrato, glosa, forma_de_pago, tipo_de_medicion, cuenta_costo, obra, tipo_registro As String
            Dim precio, cantidad_contratada, cantidad_modificacion As Double

            precio = Convert.ToDouble(txt_precio.Text)
            cod_subcontrato = cmb_codigo_subcontrato.Text
            representante = txt_representante.Text
            tipo_subcontrato = txt_tipo_subcontrato.Text
            glosa = txt_glosa.Text
            forma_de_pago = cmb_forma_de_pago.Text
            tipo_de_medicion = cmb_tipo_de_medicion.Text
            cuenta_costo = cmb_cuenta_costo.Text
            obra = txt_nombre_obra.Text
            cantidad_contratada = txt_cantidad_contratada.Text
            cantidad_modificacion = txt_cantidad_modificacion.Text
            tipo_registro = cmb_tipo_registro.Text

            If sw = 0 Then
                nue_cur.insertar(cod_subcontrato, representante, tipo_subcontrato, glosa, forma_de_pago, precio, tipo_de_medicion, cuenta_costo, obra, cantidad_contratada, cantidad_modificacion, tipo_registro)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), cod_subcontrato, representante, tipo_subcontrato, glosa, forma_de_pago, precio, tipo_de_medicion, cuenta_costo, obra, cantidad_contratada, cantidad_modificacion, tipo_registro)
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
        txt_glosa.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        cmb_forma_de_pago.Text = dgv_curso.CurrentRow.Cells(5).Value.ToString()
        txt_precio.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        cmb_tipo_de_medicion.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        cmb_cuenta_costo.Text = dgv_curso.CurrentRow.Cells(8).Value.ToString()
        txt_cantidad_contratada.Text = dgv_curso.CurrentRow.Cells(10).Value.ToString()
        txt_cantidad_modificacion.Text = dgv_curso.CurrentRow.Cells(11).Value.ToString()
        cmb_tipo_registro.Text = dgv_curso.CurrentRow.Cells(12).Value.ToString()

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

    Private Sub cmb_codigo_subcontrato_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_codigo_subcontrato.MouseClick
        actualizar_subcontrato()
    End Sub
    Private Sub cmb_cuenta_costo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_cuenta_costo.MouseClick
        actualizar_cuenta_costo()
    End Sub
    Private Sub cmb_codigo_subcontrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codigo_subcontrato.SelectedIndexChanged
        txt_representante.Text = nue_cur.descripcion_representante(cmb_codigo_subcontrato.Text, txt_nombre_obra.Text)
        txt_tipo_subcontrato.Text = nue_cur.descripcion_tipo_subcontrato(cmb_codigo_subcontrato.Text, txt_nombre_obra.Text)
    End Sub
End Class