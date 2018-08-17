Imports System.Globalization
Public Class Frm_liquidacion_maq

    Dim nue_report As New clases.Mov_Tierra
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
        gbx_Mov_Tierra.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_Mov_Tierra.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Public Sub actualizar_contratos()
        txt_codigo.DataSource = nue_report.listar2(Nombre_Obra)
        txt_codigo.DisplayMember = "Codigo_maquina"
        txt_codigo.ValueMember = "Id_contrato"
    End Sub

    Sub limpiar()
        txt_mes.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_Mov_Tierra.DataSource = nue_report.listar3(Nombre_Obra)
        dgv_Mov_Tierra.Columns(0).Visible = False
        dgv_Mov_Tierra.AllowUserToOrderColumns = True
        dgv_Mov_Tierra.Columns(1).HeaderText = "Código Máquina"
        dgv_Mov_Tierra.Columns(2).Visible = False
        dgv_Mov_Tierra.Columns(3).HeaderText = "Fecha"
        dgv_Mov_Tierra.Columns(4).Visible = False
        dgv_Mov_Tierra.Columns(5).Visible = False
        dgv_Mov_Tierra.Columns(6).Visible = False
        dgv_Mov_Tierra.Columns(7).Visible = False
        dgv_Mov_Tierra.Columns(8).Visible = False
        dgv_Mov_Tierra.Columns(9).Visible = False
        dgv_Mov_Tierra.Columns(10).Visible = False
        dgv_Mov_Tierra.Columns(11).Visible = False
        dgv_Mov_Tierra.Columns(12).Visible = False
        dgv_Mov_Tierra.Columns(13).Visible = False
        dgv_Mov_Tierra.Columns(14).Visible = False
        dgv_Mov_Tierra.Columns(15).Visible = False
        dgv_Mov_Tierra.Columns(16).Visible = False
        dgv_Mov_Tierra.Columns(17).HeaderText = "Mes"
        dgv_Mov_Tierra.Columns(18).Visible = False
        dgv_Mov_Tierra.Columns(19).Visible = False
        dgv_Mov_Tierra.Columns(20).Visible = False
        dgv_Mov_Tierra.Columns(21).Visible = False
        dgv_Mov_Tierra.Columns(22).Visible = False
        dgv_Mov_Tierra.Columns(23).Visible = False
        dgv_Mov_Tierra.Columns(24).Visible = False
        dgv_Mov_Tierra.Columns(25).Visible = False
        dgv_Mov_Tierra.Columns(26).Visible = False
        dgv_Mov_Tierra.Columns(27).Visible = False
        dgv_Mov_Tierra.Columns(28).Visible = False




    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_descripcion.Enabled = False
        actualizar_contratos()
        txt_descripcion.Text = nue_report.descripcion_patente(txt_codigo.Text, txt_nombre_obra.Text)
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
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
        Dim codigo, patente, dia_noche, Operador, observaciones, Tipo_de_trabajo, observacion_2, txt_revision, a_consultar, tipo_rendimiento, obra As String
        Dim Hor_inicial, N_de_report, Hor_final, dias_trabajados, total_horas, panne_descuentos, total_horas_con_desc, id_tipo_de_trabajo, m3, mes, viatico, horas_extras, otro_gasto, form_2, form_3, trabajo_rendimiento As Double
        If (txt_codigo.Text <> "" And txt_mes.Text <> "") Then

            codigo = txt_codigo.Text
            id_tipo_de_trabajo = "0"
            m3 = "0"
            mes = txt_mes.Text
            viatico = "0"
            horas_extras = "0"
            otro_gasto = "0"
            observacion_2 = "0"
            form_2 = "1"
            txt_revision = ""
            a_consultar = ""
            form_3 = "0"
            trabajo_rendimiento = "0"
            tipo_rendimiento = ""
            obra = txt_nombre_obra.Text
            patente = "0"
            dia_noche = "0"
            Operador = "0"
            observaciones = "0"
            Tipo_de_trabajo = "0"
            If sw = 0 Then
                nue_report.insertar(codigo, patente, CDate(txt_fecha.Text), N_de_report, Hor_inicial, Hor_final, dias_trabajados, total_horas, panne_descuentos, total_horas_con_desc, dia_noche, Operador, observaciones, Tipo_de_trabajo, id_tipo_de_trabajo, m3, mes, viatico, horas_extras, otro_gasto, observacion_2, form_2, txt_revision, a_consultar, form_3, trabajo_rendimiento, tipo_rendimiento, obra)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Mov_Tierra), codigo, patente, CDate(txt_fecha.Text), N_de_report, Hor_inicial, Hor_final, dias_trabajados, total_horas, panne_descuentos, total_horas_con_desc, dia_noche, Operador, observaciones, Tipo_de_trabajo, id_tipo_de_trabajo, m3, mes, viatico, horas_extras, otro_gasto, observacion_2, form_2, txt_revision, a_consultar, form_3, trabajo_rendimiento, tipo_rendimiento, obra)
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
        txt_codigo.Text = dgv_Mov_Tierra.CurrentRow.Cells(1).Value.ToString()
        txt_mes.Text = dgv_Mov_Tierra.CurrentRow.Cells(17).Value.ToString()
        txt_fecha.Text = dgv_Mov_Tierra.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_descripcion.Text = nue_report.descripcion_patente(txt_codigo.Text, txt_nombre_obra.Text)
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
End Class