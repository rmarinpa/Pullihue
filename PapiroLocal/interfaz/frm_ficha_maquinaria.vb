Imports System.Globalization
Public Class frm_ficha_maquinaria

    Dim nue_cur As New clases.ficha_maquinaria
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_tipo_maq.Clear()
        txt_sigla.Clear()
        txt_maquinaria.Clear()
        txt_ano.Clear()
        txt_patente.Clear()
        txt_hor_final.Clear()
        txt_motor.Clear()
        txt_chassis.Clear()
        txt_cuenta_repuesto.Clear()
        txt_operador.Clear()
        txt_material_desgaste.Clear()
        txt_lubricante.Clear()
        txt_petroleo.Clear()
        txt_go.Clear()
        txt_cuenta_ingreso.Clear()
        txt_maq_relacionada.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Tipo de Maquinaria"
        dgv_curso.Columns(2).HeaderText = "Sigla"
        dgv_curso.Columns(3).HeaderText = "Descripción Maquinaria"
        dgv_curso.Columns(1).Width = 150
        dgv_curso.Columns(3).Width = 150
        dgv_curso.Columns(4).Visible = False
        dgv_curso.Columns(5).Visible = False
        dgv_curso.Columns(6).Visible = False
        dgv_curso.Columns(7).Visible = False
        dgv_curso.Columns(8).Visible = False
        dgv_curso.Columns(9).Visible = False
        dgv_curso.Columns(10).Visible = False
        dgv_curso.Columns(11).Visible = False
        dgv_curso.Columns(12).Visible = False
        dgv_curso.Columns(13).Visible = False
        dgv_curso.Columns(14).Visible = False
        dgv_curso.Columns(15).Visible = False
        dgv_curso.Columns(16).HeaderText = "Obra"
        dgv_curso.Columns(17).HeaderText = "Código relacionado"
        dgv_curso.Columns(18).HeaderText = "Máquina relacionada"
        dgv_curso.Columns(18).Width = 150
        dgv_curso.Columns(19).HeaderText = "Fecha actualización"
        dgv_curso.Columns(20).Visible = False



    End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_tipo_maq.Enabled = False
        txt_sigla.Enabled = False
        txt_maquinaria.Enabled = False
        txt_fecha_adquision.Enabled = False
        txt_ano.Enabled = False
        txt_patente.Enabled = False
        txt_hor_final.Enabled = False
        txt_motor.Enabled = False
        txt_chassis.Enabled = False
        txt_cuenta_repuesto.Enabled = False
        txt_operador.Enabled = False
        txt_material_desgaste.Enabled = False
        txt_lubricante.Enabled = False
        txt_petroleo.Enabled = False
        txt_go.Enabled = False
        txt_fecha_actualizacion.Enabled = False
        txt_cuenta_ingreso.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_tipo_maq.Enabled = True
        txt_sigla.Enabled = True
        txt_maquinaria.Enabled = True
        txt_fecha_adquision.Enabled = True
        txt_ano.Enabled = True
        txt_patente.Enabled = True
        txt_hor_final.Enabled = True
        txt_motor.Enabled = True
        txt_chassis.Enabled = True
        txt_cuenta_repuesto.Enabled = True
        txt_operador.Enabled = True
        txt_material_desgaste.Enabled = True
        txt_lubricante.Enabled = True
        txt_petroleo.Enabled = True
        txt_go.Enabled = True
        txt_fecha_actualizacion.Enabled = True
        txt_cuenta_ingreso.Enabled = True
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False

    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        actualizar_obras()
        txt_maq_relacionada.Enabled = False
        bloquear()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_tipo_maq.Text <> "" And txt_sigla.Text <> "" And txt_maquinaria.Text <> "") Then
            Dim tipo_maq, sigla, maquinaria, ano, patente, hor_fin_2015, motor, chassis, cuenta_repuesto, cuenta_operador, cuenta_mat_des, cuenta_lubricante, cuenta_petroleo, cuenta_g_o_p, cuenta_ingreso, obra, codigo_relacionado, maq_relacionada As String

            tipo_maq = txt_tipo_maq.Text
            sigla = txt_sigla.Text
            maquinaria = txt_maquinaria.Text
            ano = txt_ano.Text
            patente = txt_patente.Text
            hor_fin_2015 = txt_hor_final.Text
            motor = txt_motor.Text
            chassis = txt_chassis.Text
            cuenta_repuesto = txt_cuenta_repuesto.Text
            cuenta_operador = txt_operador.Text
            cuenta_mat_des = txt_material_desgaste.Text
            cuenta_lubricante = txt_lubricante.Text
            cuenta_petroleo = txt_petroleo.Text
            cuenta_g_o_p = txt_go.Text
            cuenta_ingreso = txt_cuenta_ingreso.Text
            obra = cmb_obra.Text
            codigo_relacionado = cmb_codigo_relacionado.Text
            maq_relacionada = txt_maq_relacionada.Text

            If sw = 0 Then
                nue_cur.insertar(tipo_maq, sigla, maquinaria, ano, patente, hor_fin_2015, motor, chassis, cuenta_repuesto, cuenta_operador, cuenta_mat_des, cuenta_lubricante, cuenta_petroleo, cuenta_g_o_p, cuenta_ingreso, obra, codigo_relacionado, maq_relacionada, CDate(txt_fecha_actualizacion.Text), CDate(txt_fecha_adquision.Text))
                actualizar_dgv()

            Else
                nue_cur.modificar(CInt(cod_cur), tipo_maq, sigla, maquinaria, ano, patente, hor_fin_2015, motor, chassis, cuenta_repuesto, cuenta_operador, cuenta_mat_des, cuenta_lubricante, cuenta_petroleo, cuenta_g_o_p, cuenta_ingreso, obra, codigo_relacionado, maq_relacionada, CDate(txt_fecha_actualizacion.Text), CDate(txt_fecha_adquision.Text))
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
        txt_tipo_maq.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_sigla.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        txt_maquinaria.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
        txt_ano.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        txt_patente.Text = dgv_curso.CurrentRow.Cells(5).Value.ToString()
        txt_hor_final.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        txt_motor.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        txt_chassis.Text = dgv_curso.CurrentRow.Cells(8).Value.ToString()
        txt_cuenta_repuesto.Text = dgv_curso.CurrentRow.Cells(9).Value.ToString()
        txt_operador.Text = dgv_curso.CurrentRow.Cells(10).Value.ToString()
        txt_material_desgaste.Text = dgv_curso.CurrentRow.Cells(11).Value.ToString()
        txt_lubricante.Text = dgv_curso.CurrentRow.Cells(12).Value.ToString()
        txt_petroleo.Text = dgv_curso.CurrentRow.Cells(13).Value.ToString()
        txt_go.Text = dgv_curso.CurrentRow.Cells(14).Value.ToString()
        txt_cuenta_ingreso.Text = dgv_curso.CurrentRow.Cells(15).Value.ToString()
        cmb_obra.Text = dgv_curso.CurrentRow.Cells(16).Value.ToString()
        cmb_codigo_relacionado.Text = dgv_curso.CurrentRow.Cells(17).Value.ToString()
        txt_maq_relacionada.Text = dgv_curso.CurrentRow.Cells(18).Value.ToString()
        txt_fecha_actualizacion.Text = dgv_curso.CurrentRow.Cells(19).Value.ToString()
        txt_fecha_adquision.Text = dgv_curso.CurrentRow.Cells(20).Value.ToString()

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

    Public Sub actualizar_obras()
        cmb_obra.DataSource = nue_cur.listar2()
        cmb_obra.DisplayMember = "Nombre"
        cmb_obra.ValueMember = "Nombre"
    End Sub
    Public Sub actualizar_cuentas()
        cmb_codigo_relacionado.DataSource = nue_cur.listar3(cmb_obra.Text)
        cmb_codigo_relacionado.DisplayMember = "Codigo_maquina"
        cmb_codigo_relacionado.ValueMember = "Codigo_maquina"
    End Sub

    Private Sub cmb_obra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_obra.SelectedIndexChanged
        actualizar_cuentas()
    End Sub

    Private Sub cmb_codigo_relacionado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codigo_relacionado.SelectedIndexChanged
        txt_maq_relacionada.Text = nue_cur.descripcion_patente(cmb_codigo_relacionado.Text, cmb_obra.Text)
    End Sub
End Class