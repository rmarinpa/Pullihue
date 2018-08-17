Public Class frm_lc_representates

    Dim nue_cur As New clases.Representante_lc
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_rut.Clear()
        txt_razon_social.Clear()
        txt_telefono.Clear()
        txt_direccion.Clear()
        txt_comuna.Clear()
        txt_forma_de_pago.Clear()
        txt_linea_credito.Clear()
        txt_dicom.Clear()
        txt_senal_advertencia.Clear()
        txt_nombre_com.Clear()
        txt_cargo_com.Clear()
        txt_telefonos_com.Clear()
        txt_email_com.Clear()
        txt_nombre_fact.Clear()
        txt_cargo_fact.Clear()
        txt_telefonos_fact.Clear()
        txt_email_fact.Clear()
        txt_nombre_desp.Clear()
        txt_direccion_desp.Clear()
        txt_telefonos_desp.Clear()
        txt_email_desp.Clear()
        txt_observacion.Clear()

    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "RUT Empresa"
        dgv_curso.Columns(2).HeaderText = "Razón Social"
        dgv_curso.Columns(2).Width = 300
        dgv_curso.Columns(3).HeaderText = "Dirección"
        dgv_curso.Columns(3).Width = 300
        dgv_curso.Columns(4).HeaderText = "Comuna"
        dgv_curso.Columns(5).HeaderText = "Teléfonos"
        dgv_curso.Columns(6).Visible = False
        dgv_curso.Columns(7).Visible = False
        dgv_curso.Columns(8).Visible = False
        dgv_curso.Columns(9).Visible = False
        dgv_curso.Columns(10).Visible = False
        dgv_curso.Columns(11).Visible = False
        dgv_curso.Columns(12).Visible = False
        dgv_curso.Columns(13).Visible = False
        dgv_curso.Columns(14).Visible = False
        dgv_curso.Columns(15).HeaderText = "Forma de Pago"
        dgv_curso.Columns(16).Visible = False
        dgv_curso.Columns(17).Visible = False
        dgv_curso.Columns(18).Visible = False
        dgv_curso.Columns(19).Visible = False
        dgv_curso.Columns(20).Visible = False
        dgv_curso.Columns(21).Visible = False
        dgv_curso.Columns(22).Visible = False
        dgv_curso.Columns(23).Visible = False
        dgv_curso.Columns(24).HeaderText = "Señal Advertencia"
        dgv_curso.Columns(25).Visible = False
        dgv_curso.Columns(26).HeaderText = "Línea de Crédito"
        dgv_curso.Columns(27).HeaderText = "Dicom"
        dgv_curso.Columns(28).Visible = False
        dgv_curso.Columns(29).Visible = False
        dgv_curso.Columns(30).Visible = False
        dgv_curso.Columns(31).Visible = False
        dgv_curso.Columns(32).Visible = False
        dgv_curso.Columns(33).Visible = False
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_rut.Enabled = False
        txt_razon_social.Enabled = False
        txt_telefono.Enabled = False
        txt_direccion.Enabled = False
        txt_comuna.Enabled = False
        txt_forma_de_pago.Enabled = False
        txt_linea_credito.Enabled = False
        txt_dicom.Enabled = False
        txt_senal_advertencia.Enabled = False
        txt_nombre_com.Enabled = False
        txt_cargo_com.Enabled = False
        txt_telefonos_com.Enabled = False
        txt_email_com.Enabled = False
        txt_nombre_fact.Enabled = False
        txt_cargo_fact.Enabled = False
        txt_telefonos_fact.Enabled = False
        txt_email_fact.Enabled = False
        txt_nombre_desp.Enabled = False
        txt_direccion_desp.Enabled = False
        txt_telefonos_desp.Enabled = False
        txt_email_desp.Enabled = False
        txt_observacion.Enabled = False
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_cancelar.Enabled = True
        txt_forma_de_pago.Enabled = True
        txt_linea_credito.Enabled = True
        txt_dicom.Enabled = True
        txt_senal_advertencia.Enabled = True
        txt_nombre_com.Enabled = True
        txt_cargo_com.Enabled = True
        txt_telefonos_com.Enabled = True
        txt_email_com.Enabled = True
        txt_nombre_fact.Enabled = True
        txt_cargo_fact.Enabled = True
        txt_telefonos_fact.Enabled = True
        txt_email_fact.Enabled = True
        txt_nombre_desp.Enabled = True
        txt_direccion_desp.Enabled = True
        txt_telefonos_desp.Enabled = True
        txt_email_desp.Enabled = True
        txt_observacion.Enabled = True
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_dgv()
        bloquear()
        txt_rut.Enabled = False
        txt_razon_social.Enabled = False
        txt_direccion.Enabled = False
        txt_comuna.Enabled = False
        txt_telefono.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_rut.Text <> "" And txt_razon_social.Text <> "" And txt_direccion.Text <> "" And txt_comuna.Text <> "" And txt_telefono.Text <> "") Then
            Dim rut, razon_social, direccion, comuna, telefono, nombre_com, cargo_com, telefonos_com, email_com, nombre_fact, cargo_fact, telefonos_fact, email_fact, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_desp, email_despacho, telefonos_desp, nombre_desp, senal_advertencia, estado, linea_credito, dicom, fecha_ingreso, observacion, maquinas, email_contacto2, actualizado, giro As String

            rut = txt_rut.Text
            razon_social = txt_razon_social.Text
            direccion = txt_direccion.Text
            comuna = txt_comuna.Text
            telefono = txt_telefono.Text
            nombre_com = txt_nombre_com.Text
            cargo_com = txt_cargo_com.Text
            telefonos_com = txt_telefonos_com.Text
            email_com = txt_email_com.Text
            nombre_fact = txt_nombre_fact.Text
            cargo_fact = txt_cargo_fact.Text
            telefonos_fact = txt_telefonos_fact.Text
            email_fact = txt_email_fact.Text
            forma_de_pago = txt_forma_de_pago.Text
            direccion_desp = txt_direccion_desp.Text
            telefonos_desp = txt_telefonos_desp.Text
            nombre_desp = txt_nombre_desp.Text
            senal_advertencia = txt_senal_advertencia.Text
            linea_credito = txt_linea_credito.Text
            dicom = txt_dicom.Text
            observacion = txt_observacion.Text
            cond = ""
            ejec_digital = ""
            ejec_media = ""
            ejec_led = ""
            ejec_mac = ""
            email_despacho = txt_email_desp.Text
            estado = ""
            fecha_ingreso = ""
            maquinas = ""
            email_contacto2 = ""
            actualizado = ""
            giro = ""

            If sw = 0 Then
                If (nue_cur.listar2(Me.txt_rut.Text) = Me.txt_rut.Text) Then
                    MessageBox.Show("Este Cliente ya existe")
                Else
                    nue_cur.insertar(rut, razon_social, direccion, comuna, telefono, nombre_com, cargo_com, telefonos_com, email_com, nombre_fact, cargo_fact, telefonos_fact, email_fact, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_desp, email_despacho, telefonos_desp, nombre_desp, senal_advertencia, estado, linea_credito, dicom, fecha_ingreso, observacion, maquinas, email_contacto2, actualizado, giro)
                    actualizar_dgv()
                End If
            Else
                nue_cur.modificar(CInt(cod_cur), rut, razon_social, direccion, comuna, telefono, nombre_com, cargo_com, telefonos_com, email_com, nombre_fact, cargo_fact, telefonos_fact, email_fact, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_desp, email_despacho, telefonos_desp, nombre_desp, senal_advertencia, estado, linea_credito, dicom, fecha_ingreso, observacion, maquinas, email_contacto2, actualizado, giro)
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
        txt_rut.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_razon_social.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        txt_direccion.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
        txt_comuna.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        txt_telefono.Text = dgv_curso.CurrentRow.Cells(5).Value.ToString()
        txt_nombre_com.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        txt_cargo_com.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        txt_telefonos_com.Text = dgv_curso.CurrentRow.Cells(8).Value.ToString()
        txt_email_com.Text = dgv_curso.CurrentRow.Cells(9).Value.ToString()
        txt_nombre_fact.Text = dgv_curso.CurrentRow.Cells(10).Value.ToString()
        txt_cargo_fact.Text = dgv_curso.CurrentRow.Cells(11).Value.ToString()
        txt_telefonos_fact.Text = dgv_curso.CurrentRow.Cells(12).Value.ToString()
        txt_email_fact.Text = dgv_curso.CurrentRow.Cells(13).Value.ToString()
        txt_forma_de_pago.Text = dgv_curso.CurrentRow.Cells(15).Value.ToString()
        txt_direccion_desp.Text = dgv_curso.CurrentRow.Cells(20).Value.ToString()
        txt_email_desp.Text = dgv_curso.CurrentRow.Cells(21).Value.ToString()
        txt_telefonos_desp.Text = dgv_curso.CurrentRow.Cells(22).Value.ToString()
        txt_nombre_desp.Text = dgv_curso.CurrentRow.Cells(23).Value.ToString()
        txt_senal_advertencia.Text = dgv_curso.CurrentRow.Cells(24).Value.ToString()
        txt_linea_credito.Text = dgv_curso.CurrentRow.Cells(26).Value.ToString()
        txt_dicom.Text = dgv_curso.CurrentRow.Cells(27).Value.ToString()
        txt_observacion.Text = dgv_curso.CurrentRow.Cells(29).Value.ToString()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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