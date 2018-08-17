Imports System.Globalization
Public Class Frm_avance_subcontratos

    Dim nue_report As New clases.avance_subcontratos
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Public Sub abrir_en_panel(ByVal form_hijo As Object, ByVal panel As Panel)
        panel.Controls.Clear()
        Dim form As Form = CType(form_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
    End Sub
    Sub bloquear()
        gbx_avance_subcontrato.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_avance_subcontrato.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Public Sub actualizar_contratos()
        txt_codigo_subcontrato.DataSource = nue_report.listar2(Nombre_Obra)
        txt_codigo_subcontrato.DisplayMember = "Id_representante"
        txt_codigo_subcontrato.ValueMember = "Id_representante"
    End Sub

    Public Sub actualizar_items()
        cmb_item.DataSource = nue_report.listar3(Nombre_Obra, txt_codigo_subcontrato.Text)
        cmb_item.DisplayMember = "glosa"
        cmb_item.ValueMember = "glosa"
    End Sub

    Sub limpiar()
        txt_tipo_subcontrato.Clear()
        txt_representante.Clear()
        txt_avance.Clear()
        txt_tipo_de_medicion.Clear()
        txt_observaciones.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_Mov_Tierra.DataSource = nue_report.listar(Nombre_Obra)
        dgv_Mov_Tierra.Columns(0).Visible = False
        dgv_Mov_Tierra.Columns(1).HeaderText = "Código Subcontrato"
        dgv_Mov_Tierra.Columns(2).HeaderText = "Fecha"
        dgv_Mov_Tierra.Columns(3).HeaderText = "Representante"
        dgv_Mov_Tierra.Columns(4).HeaderText = "Tipo de Subcontrato"
        dgv_Mov_Tierra.Columns(4).Width = 200
        dgv_Mov_Tierra.Columns(5).HeaderText = "Ítem"
        dgv_Mov_Tierra.Columns(5).Width = 200
        dgv_Mov_Tierra.Columns(6).HeaderText = "Avance"
        dgv_Mov_Tierra.Columns(7).HeaderText = "Tipo de medición"
        dgv_Mov_Tierra.Columns(8).HeaderText = "Observaciones"
        dgv_Mov_Tierra.Columns(9).HeaderText = "Obra"
        
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        actualizar_contratos()
        actualizar_items()
        txt_representante.Text = nue_report.descripcion_representante(txt_codigo_subcontrato.Text, txt_nombre_obra.Text)
        txt_tipo_subcontrato.Text = nue_report.descripcion_tipo_subcontrato(txt_codigo_subcontrato.Text, txt_nombre_obra.Text)
        txt_tipo_de_medicion.Text = nue_report.descripcion_tipo_medicion(txt_codigo_subcontrato.Text, txt_nombre_obra.Text, cmb_item.Text)
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        txt_representante.Enabled = False
        txt_tipo_subcontrato.Enabled = False
        txt_tipo_de_medicion.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim representante, tipo_subcontrato, item, tipo_de_medicion, observaciones, obra As String
        Dim avance, codigo As Double
        If (txt_codigo_subcontrato.Text <> "" And txt_avance.Text <> "") Then

            codigo = Convert.ToDouble(txt_codigo_subcontrato.Text)
            representante = txt_representante.Text
            tipo_subcontrato = txt_tipo_subcontrato.Text
            item = cmb_item.Text
            avance = Convert.ToDouble(txt_avance.Text)
            tipo_de_medicion = txt_tipo_de_medicion.Text
            observaciones = txt_observaciones.Text
            obra = txt_nombre_obra.Text
            If sw = 0 Then
                nue_report.insertar(codigo, CDate(txt_fecha.Text), representante, tipo_subcontrato, item, avance, tipo_de_medicion, observaciones, obra)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Mov_Tierra), codigo, CDate(txt_fecha.Text), representante, tipo_subcontrato, item, avance, tipo_de_medicion, observaciones, obra)
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
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_estudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Mov_Tierra.CellDoubleClick
        Cod_Mov_Tierra = dgv_Mov_Tierra.CurrentRow.Cells(0).Value.ToString()
        txt_codigo_subcontrato.Text = dgv_Mov_Tierra.CurrentRow.Cells(1).Value.ToString()
        txt_fecha.Text = dgv_Mov_Tierra.CurrentRow.Cells(2).Value.ToString()
        txt_representante.Text = dgv_Mov_Tierra.CurrentRow.Cells(3).Value.ToString()
        txt_tipo_subcontrato.Text = dgv_Mov_Tierra.CurrentRow.Cells(4).Value.ToString()
        cmb_item.SelectedValue = dgv_Mov_Tierra.CurrentRow.Cells(5).Value.ToString()
        txt_avance.Text = dgv_Mov_Tierra.CurrentRow.Cells(6).Value.ToString()
        txt_tipo_de_medicion.Text = dgv_Mov_Tierra.CurrentRow.Cells(7).Value.ToString()
        txt_observaciones.Text = dgv_Mov_Tierra.CurrentRow.Cells(8).Value.ToString()
        txt_nombre_obra.Text = dgv_Mov_Tierra.CurrentRow.Cells(9).Value.ToString()

    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Mov_Tierra))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub

    Private Sub dgv_Mov_Tierra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Mov_Tierra.CellContentClick

    End Sub

    Private Sub txt_codigo_subcontrato_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_codigo_subcontrato.MouseClick
        actualizar_contratos()
    End Sub

    Private Sub txt_codigo_subcontrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo_subcontrato.SelectedIndexChanged
        txt_representante.Text = nue_report.descripcion_representante(txt_codigo_subcontrato.Text, txt_nombre_obra.Text)
        txt_tipo_subcontrato.Text = nue_report.descripcion_tipo_subcontrato(txt_codigo_subcontrato.Text, txt_nombre_obra.Text)
    End Sub

    Private Sub txt_tipo_de_medicion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tipo_de_medicion.TextChanged

    End Sub

    Private Sub cmb_item_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_item.MouseClick
        actualizar_items()
    End Sub

    Private Sub cmb_item_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_item.SelectedIndexChanged
        txt_tipo_de_medicion.Text = nue_report.descripcion_tipo_medicion(txt_codigo_subcontrato.Text, txt_nombre_obra.Text, cmb_item.Text)
    End Sub
End Class