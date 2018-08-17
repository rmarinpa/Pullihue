Imports System.Globalization
Public Class frm_ficha_trabajador

    Dim nue_cur As New clases.ficha_trabajador
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_nombres.Clear()
        txt_apellidos.Clear()
        txt_rut.Clear()
        txt_lugar_nacimiento.Clear()
        txt_estado_civil.Clear()
        txt_domicilio.Clear()
        txt_telefonos.Clear()
        txt_email.Clear()
        txt_tipo_contrato.Clear()
        txt_faena_actual.Clear()
        txt_profesion.Clear()
        txt_cargo.Clear()
        txt_afp.Clear()
        txt_salud.Clear()
        txt_nivel_escolaridad.Clear()
        txt_situacion_habitacional.Clear()
        txt_integrantes.Clear()
        txt_cargas.Clear()
        txt_observaciones.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Nombres"
        dgv_curso.Columns(2).HeaderText = "Apellidos"
        dgv_curso.Columns(3).HeaderText = "Rut"
        dgv_curso.Columns(1).Width = 150
        dgv_curso.Columns(2).Width = 150
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
        dgv_curso.Columns(16).Visible = False
        dgv_curso.Columns(17).Visible = False
        dgv_curso.Columns(18).Visible = False
        dgv_curso.Columns(19).Visible = False
        dgv_curso.Columns(20).Visible = False
        dgv_curso.Columns(21).Visible = False

    End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_nombres.Enabled = False
        txt_apellidos.Enabled = False
        txt_rut.Enabled = False
        txt_fecha_nacimiento.Enabled = False
        txt_lugar_nacimiento.Enabled = False
        txt_estado_civil.Enabled = False
        txt_domicilio.Enabled = False
        txt_telefonos.Enabled = False
        txt_email.Enabled = False
        txt_tipo_contrato.Enabled = False
        txt_faena_actual.Enabled = False
        txt_profesion.Enabled = False
        txt_cargo.Enabled = False
        txt_afp.Enabled = False
        txt_salud.Enabled = False
        txt_fecha_ingreso.Enabled = False
        txt_nivel_escolaridad.Enabled = False
        txt_situacion_habitacional.Enabled = False
        txt_integrantes.Enabled = False
        txt_cargas.Enabled = False
        txt_observaciones.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_nombres.Enabled = True
        txt_apellidos.Enabled = True
        txt_rut.Enabled = True
        txt_fecha_nacimiento.Enabled = True
        txt_lugar_nacimiento.Enabled = True
        txt_estado_civil.Enabled = True
        txt_domicilio.Enabled = True
        txt_telefonos.Enabled = True
        txt_email.Enabled = True
        txt_tipo_contrato.Enabled = True
        txt_faena_actual.Enabled = True
        txt_profesion.Enabled = True
        txt_cargo.Enabled = True
        txt_afp.Enabled = True
        txt_salud.Enabled = True
        txt_fecha_ingreso.Enabled = True
        txt_nivel_escolaridad.Enabled = True
        txt_situacion_habitacional.Enabled = True
        txt_integrantes.Enabled = True
        txt_cargas.Enabled = True
        txt_observaciones.Enabled = True
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False

    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        bloquear()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_nombres.Text <> "" And txt_apellidos.Text <> "" And txt_rut.Text <> "") Then
            Dim Nombres, Apellidos, Rut, Lugar_de_nacimiento, Estado_Civil, Domicilio, Telefonos, E_mail, Tipo_de_contrato, Faena_actual, Profesion_Oficio, Cargo_labor, AFP, Salud, Nivel_de_escolaridad, Situacion_habitacional, integrantes_hogar, observaciones As String
            Dim Cargas_familiares As Double

            Nombres = txt_nombres.Text
            Apellidos = txt_apellidos.Text
            Rut = txt_rut.Text
            Lugar_de_nacimiento = txt_lugar_nacimiento.Text
            Estado_Civil = txt_estado_civil.Text
            Domicilio = txt_domicilio.Text
            Telefonos = txt_telefonos.Text
            E_mail = txt_email.Text
            Tipo_de_contrato = txt_tipo_contrato.Text
            Faena_actual = txt_faena_actual.Text
            Profesion_Oficio = txt_profesion.Text
            Cargo_labor = txt_cargo.Text
            AFP = txt_afp.Text
            Salud = txt_salud.Text
            Nivel_de_escolaridad = txt_nivel_escolaridad.Text
            Situacion_habitacional = txt_situacion_habitacional.Text
            observaciones = txt_observaciones.Text

            If (Not IsNumeric(txt_cargas.Text)) Then
                txt_cargas.Text = 0
            End If
            integrantes_hogar = txt_integrantes.Text
            Cargas_familiares = Convert.ToDouble(txt_cargas.Text)


            If sw = 0 Then
                nue_cur.insertar(Nombres, Apellidos, Rut, CDate(txt_fecha_nacimiento.Text), Lugar_de_nacimiento, Estado_Civil, Domicilio, Telefonos, E_mail, Tipo_de_contrato, Faena_actual, Profesion_Oficio, Cargo_labor, AFP, Salud, CDate(txt_fecha_ingreso.Text), Nivel_de_escolaridad, Situacion_habitacional, integrantes_hogar, Cargas_familiares, observaciones)
                actualizar_dgv()

            Else
                nue_cur.modificar(CInt(cod_cur), Nombres, Apellidos, Rut, CDate(txt_fecha_nacimiento.Text), Lugar_de_nacimiento, Estado_Civil, Domicilio, Telefonos, E_mail, Tipo_de_contrato, Faena_actual, Profesion_Oficio, Cargo_labor, AFP, Salud, CDate(txt_fecha_ingreso.Text), Nivel_de_escolaridad, Situacion_habitacional, integrantes_hogar, Cargas_familiares, observaciones)
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
        txt_nombres.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_apellidos.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        txt_rut.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
        txt_fecha_nacimiento.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        txt_lugar_nacimiento.Text = dgv_curso.CurrentRow.Cells(5).Value.ToString()
        txt_estado_civil.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        txt_domicilio.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        txt_telefonos.Text = dgv_curso.CurrentRow.Cells(8).Value.ToString()
        txt_email.Text = dgv_curso.CurrentRow.Cells(9).Value.ToString()
        txt_tipo_contrato.Text = dgv_curso.CurrentRow.Cells(10).Value.ToString()
        txt_faena_actual.Text = dgv_curso.CurrentRow.Cells(11).Value.ToString()
        txt_profesion.Text = dgv_curso.CurrentRow.Cells(12).Value.ToString()
        txt_cargo.Text = dgv_curso.CurrentRow.Cells(13).Value.ToString()
        txt_afp.Text = dgv_curso.CurrentRow.Cells(14).Value.ToString()
        txt_salud.Text = dgv_curso.CurrentRow.Cells(15).Value.ToString()
        txt_fecha_ingreso.Text = dgv_curso.CurrentRow.Cells(16).Value.ToString()
        txt_nivel_escolaridad.Text = dgv_curso.CurrentRow.Cells(17).Value.ToString()
        txt_situacion_habitacional.Text = dgv_curso.CurrentRow.Cells(18).Value.ToString()
        txt_integrantes.Text = dgv_curso.CurrentRow.Cells(19).Value.ToString()
        txt_cargas.Text = dgv_curso.CurrentRow.Cells(20).Value.ToString()
        txt_observaciones.Text = dgv_curso.CurrentRow.Cells(21).Value.ToString()

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
End Class