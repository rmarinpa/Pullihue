Imports System.Globalization
Public Class Frm_reports

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
        txt_hor_final.Clear()
        txt_n_report.Clear()
        txt_dias_trabajados.Clear()
        txt_total_horas.Clear()
        txt_hor_inicial.Clear()
        txt_panne_descuentos.Clear()
        txt_total_horas_con_desc.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_Mov_Tierra.DataSource = nue_report.listar(Nombre_Obra, Fecha_inicio, Fecha_final)
        dgv_Mov_Tierra.Columns(0).Visible = False
        dgv_Mov_Tierra.AllowUserToOrderColumns = True
        dgv_Mov_Tierra.Columns(1).HeaderText = "Código Máquina"
        dgv_Mov_Tierra.Columns(2).Visible = False
        dgv_Mov_Tierra.Columns(3).HeaderText = "Fecha"
        dgv_Mov_Tierra.Columns(4).HeaderText = "N° de report"
        dgv_Mov_Tierra.Columns(5).HeaderText = "Horómetro Inicial"
        dgv_Mov_Tierra.Columns(6).HeaderText = "Horómetro Final"
        dgv_Mov_Tierra.Columns(7).HeaderText = "Días Trabajados"
        dgv_Mov_Tierra.Columns(8).HeaderText = "Total Horas"
        dgv_Mov_Tierra.Columns(9).HeaderText = "Panne/Descuentos"
        dgv_Mov_Tierra.Columns(10).HeaderText = "Total Horas con Descuento"
        dgv_Mov_Tierra.Columns(11).HeaderText = "Día/Noche"
        dgv_Mov_Tierra.Columns(12).HeaderText = "Operador"
        dgv_Mov_Tierra.Columns(13).HeaderText = "Observaciones"
        dgv_Mov_Tierra.Columns(27).HeaderText = "Tipo de Trabajo"
        dgv_Mov_Tierra.Columns(15).Visible = False
        dgv_Mov_Tierra.Columns(16).Visible = False
        dgv_Mov_Tierra.Columns(17).Visible = False
        dgv_Mov_Tierra.Columns(18).Visible = False
        dgv_Mov_Tierra.Columns(19).Visible = False
        dgv_Mov_Tierra.Columns(20).Visible = False
        dgv_Mov_Tierra.Columns(21).Visible = False
        dgv_Mov_Tierra.Columns(22).Visible = False
        dgv_Mov_Tierra.Columns(23).Visible = False
        dgv_Mov_Tierra.Columns(24).Visible = False
        dgv_Mov_Tierra.Columns(25).Visible = False
        dgv_Mov_Tierra.Columns(26).Visible = False
        dgv_Mov_Tierra.Columns(28).Visible = False
        dgv_Mov_Tierra.Columns(14).Visible = False

    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_descripcion.Enabled = False
        actualizar_contratos()
        txt_descripcion.Text = nue_report.descripcion_patente(txt_codigo.Text, txt_nombre_obra.Text)
        txt_dias_trabajados.Text = "1"
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        actualizar_tipo_trabajo()
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
        txt_dias_trabajados.Text = "1"
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim codigo, patente, dia_noche, Operador, observaciones, Tipo_de_trabajo, observacion_2, txt_revision, a_consultar, tipo_rendimiento, obra As String
        Dim Hor_inicial, N_de_report, Hor_final, dias_trabajados, total_horas, panne_descuentos, total_horas_con_desc, id_tipo_de_trabajo, m3, mes, viatico, horas_extras, otro_gasto, form_2, form_3, trabajo_rendimiento As Double
        If (txt_codigo.Text <> "" And txt_hor_final.Text <> "" And txt_n_report.Text <> "" And txt_dias_trabajados.Text <> "" And txt_total_horas.Text <> "" And txt_hor_inicial.Text <> "" And txt_panne_descuentos.Text <> "" And txt_total_horas_con_desc.Text <> "") Then
            If (txt_descripcion.Text = "") Then
                MessageBox.Show("LA MÁQUINA NO ESTA REGISTRADA")
            Else
                codigo = txt_codigo.Text
                N_de_report = Convert.ToDouble(txt_n_report.Text)
                Hor_inicial = Convert.ToDouble(txt_hor_inicial.Text)
                Hor_final = Convert.ToDouble(txt_hor_final.Text)
                dias_trabajados = Convert.ToDouble(txt_dias_trabajados.Text)
                total_horas = Convert.ToDouble(txt_total_horas.Text)
                panne_descuentos = Convert.ToDouble(txt_panne_descuentos.Text)
                total_horas_con_desc = Convert.ToDouble(txt_total_horas_con_desc.Text)
                patente = ""
                dia_noche = cmb_dia_noche.Text
                Operador = cmb_operador.Text
                observaciones = txt_observaciones.Text
                Tipo_de_trabajo = cmb_tipo_de_trabajo.Text
                id_tipo_de_trabajo = "0"
                m3 = "0"
                mes = "0"
                viatico = "0"
                horas_extras = "0"
                otro_gasto = "0"
                observacion_2 = "0"
                form_2 = "0"
                txt_revision = ""
                a_consultar = ""
                form_3 = "1"
                trabajo_rendimiento = "0"
                tipo_rendimiento = ""
                obra = txt_nombre_obra.Text
                If sw = 0 Then
                    nue_report.insertar(codigo, patente, CDate(txt_fecha.Text), N_de_report, Hor_inicial, Hor_final, dias_trabajados, total_horas, panne_descuentos, total_horas_con_desc, dia_noche, Operador, observaciones, Tipo_de_trabajo, id_tipo_de_trabajo, m3, mes, viatico, horas_extras, otro_gasto, observacion_2, form_2, txt_revision, a_consultar, form_3, trabajo_rendimiento, tipo_rendimiento, obra)
                    actualizar_dgv()
                Else
                    nue_report.modificar(CInt(Cod_Mov_Tierra), codigo, patente, CDate(txt_fecha.Text), N_de_report, Hor_inicial, Hor_final, dias_trabajados, total_horas, panne_descuentos, total_horas_con_desc, dia_noche, Operador, observaciones, Tipo_de_trabajo, id_tipo_de_trabajo, m3, mes, viatico, horas_extras, otro_gasto, observacion_2, form_2, txt_revision, a_consultar, form_3, trabajo_rendimiento, tipo_rendimiento, obra)
                    actualizar_dgv()
                End If
                limpiar()
                bloquear()
            End If
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
        txt_hor_final.Text = dgv_Mov_Tierra.CurrentRow.Cells(6).Value.ToString()
        txt_n_report.Text = dgv_Mov_Tierra.CurrentRow.Cells(4).Value.ToString()
        txt_dias_trabajados.Text = dgv_Mov_Tierra.CurrentRow.Cells(7).Value.ToString()
        txt_fecha.Text = dgv_Mov_Tierra.CurrentRow.Cells(3).Value.ToString()
        txt_total_horas.Text = dgv_Mov_Tierra.CurrentRow.Cells(8).Value.ToString()
        txt_hor_inicial.Text = dgv_Mov_Tierra.CurrentRow.Cells(5).Value.ToString()
        txt_panne_descuentos.Text = dgv_Mov_Tierra.CurrentRow.Cells(9).Value.ToString()
        txt_total_horas_con_desc.Text = dgv_Mov_Tierra.CurrentRow.Cells(10).Value.ToString()
        cmb_dia_noche.Text = dgv_Mov_Tierra.CurrentRow.Cells(11).Value.ToString()
        cmb_operador.Text = dgv_Mov_Tierra.CurrentRow.Cells(12).Value.ToString()
        cmb_tipo_de_trabajo.Text = dgv_Mov_Tierra.CurrentRow.Cells(27).Value.ToString()
        txt_observaciones.Text = dgv_Mov_Tierra.CurrentRow.Cells(13).Value.ToString()
    End Sub


    Private Sub txt_hor_final_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_hor_final.TextChanged
        If (Not IsNumeric(Me.txt_hor_final.Text)) Then
            Me.txt_hor_final.Text = 0
        End If

        If (Not IsNumeric(Me.txt_hor_inicial.Text)) Then
            Me.txt_hor_inicial.Text = 0
        End If
        If (Not IsNumeric(Me.txt_panne_descuentos.Text)) Then
            Me.txt_panne_descuentos.Text = 0
        End If

        hor2 = CDbl(txt_hor_final.Text) - CDbl(txt_hor_inicial.Text) - CDbl(txt_panne_descuentos.Text)
        hor1 = CDbl(txt_hor_final.Text) - CDbl(txt_hor_inicial.Text)

        txt_total_horas.Text = hor1
        txt_total_horas_con_desc.Text = hor2
    End Sub

    Private Sub txt_hor_inicial_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_hor_inicial.TextChanged
        If (Not IsNumeric(Me.txt_hor_final.Text)) Then
            Me.txt_hor_final.Text = 0
        End If

        If (Not IsNumeric(Me.txt_hor_inicial.Text)) Then
            Me.txt_hor_inicial.Text = 0
        End If
        If (Not IsNumeric(Me.txt_panne_descuentos.Text)) Then
            Me.txt_panne_descuentos.Text = 0
        End If

        hor1 = CDbl(txt_hor_final.Text) - CDbl(txt_hor_inicial.Text)
        hor2 = CDbl(txt_hor_final.Text) - CDbl(txt_hor_inicial.Text) - CDbl(txt_panne_descuentos.Text)

        txt_total_horas.Text = hor1
        txt_total_horas_con_desc.Text = hor2
    End Sub

    Private Sub txt_panne_descuentos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_panne_descuentos.TextChanged
        If (Not IsNumeric(Me.txt_hor_final.Text)) Then
            Me.txt_hor_final.Text = 0
        End If

        If (Not IsNumeric(Me.txt_hor_inicial.Text)) Then
            Me.txt_hor_inicial.Text = 0
        End If
        If (Not IsNumeric(Me.txt_panne_descuentos.Text)) Then
            Me.txt_panne_descuentos.Text = 0
        End If
        hor2 = CDbl(txt_hor_final.Text) - CDbl(txt_hor_inicial.Text) - CDbl(txt_panne_descuentos.Text)

        txt_total_horas_con_desc.Text = hor2
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

    Public Sub actualizar_tipo_trabajo()
        cmb_tipo_de_trabajo.DataSource = nue_report.listar4(txt_codigo.Text, Nombre_Obra)
        cmb_tipo_de_trabajo.DisplayMember = "tipo_de_trabajo"
        cmb_tipo_de_trabajo.ValueMember = "tipo_de_trabajo"
    End Sub

    Private Sub cmb_tipo_de_trabajo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_tipo_de_trabajo.MouseClick
        actualizar_tipo_trabajo()
    End Sub

    Private Sub cmb_tipo_de_trabajo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo_de_trabajo.SelectedIndexChanged

    End Sub

    Private Sub txt_codigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.SelectedIndexChanged

    End Sub
End Class