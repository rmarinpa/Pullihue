Public Class frm_representates_ejec

    Dim nue_cur As New clases.Representante
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_rut2.Clear()
        txt_razon_social.Clear()
        txt_telefono.Clear()
        txt_direccion.Clear()
        txt_comuna.Clear()
        txt_forma_de_pago.Text = ""
        txt_linea_credito.Clear()
        txt_dicom.Clear()
        txt_senal_advertencia.Text = ""
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
        txt_condicion.Clear()
        txt_estado.Clear()
        txt_ejec_dig.Text = ""
        txt_ejec_led.Text = ""
        txt_ejec_mac.Text = ""
        txt_ejec_media.Text = ""
        txt_ejecnew.Text = ""
        txt_referencia.Text = ""
        txt_ficha_cliente.Text = ""

        txt_fecha_act.Text = DateTime.Now
        txt_giro.Clear()

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
        dgv_curso.Columns(15).Visible = False
        dgv_curso.Columns(16).Visible = False
        dgv_curso.Columns(17).Visible = False
        dgv_curso.Columns(18).Visible = False
        dgv_curso.Columns(19).Visible = False
        dgv_curso.Columns(20).Visible = False
        dgv_curso.Columns(21).Visible = False
        dgv_curso.Columns(22).Visible = False
        dgv_curso.Columns(23).Visible = False
        dgv_curso.Columns(24).Visible = False
        dgv_curso.Columns(25).Visible = False
        dgv_curso.Columns(26).Visible = False
        dgv_curso.Columns(27).Visible = False
        dgv_curso.Columns(28).Visible = False
        dgv_curso.Columns(29).Visible = False
        dgv_curso.Columns(30).Visible = False
        dgv_curso.Columns(31).Visible = False
        dgv_curso.Columns(32).Visible = False
        dgv_curso.Columns(33).Visible = False
        dgv_curso.Columns(34).Visible = False
        dgv_curso.Columns(35).Visible = False
        dgv_curso.Columns(36).Visible = False
        dgv_curso.Columns(37).Visible = False
        dgv_curso.Columns(38).Visible = False
        dgv_curso.Columns(39).Visible = False
        dgv_curso.Columns(40).Visible = False
        dgv_curso.Columns(41).Visible = False
    End Sub

    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
        txt_rut2.Enabled = False
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
        txt_condicion.Enabled = False
        txt_estado.Enabled = False
        txt_ejec_dig.Enabled = False
        txt_ejec_led.Enabled = False
        txt_ejec_mac.Enabled = False
        txt_ejec_media.Enabled = False
        txt_giro.Enabled = False
        txt_ejecnew.Enabled = False
        txt_referencia.Enabled = False
        txt_ficha_cliente.Enabled = False
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
        txt_rut2.Enabled = True
        txt_razon_social.Enabled = True
        txt_telefono.Enabled = True
        txt_direccion.Enabled = True
        txt_comuna.Enabled = True
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
        txt_giro.Enabled = True
        txt_referencia.Enabled = True
        txt_ficha_cliente.Enabled = True
        txt_estado.Enabled = True
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        txt_fecha_act.Text = DateTime.Now
        bloquear()

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_rut2.Text <> "" And txt_razon_social.Text <> "" And txt_direccion.Text <> "" And txt_comuna.Text <> "" And txt_telefono.Text <> "") Then
            Dim rut, razon_social, direccion, comuna, telefono, nombre_com, cargo_com, telefonos_com, email_com, nombre_fact, cargo_fact, telefonos_fact, email_fact, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_desp, email_despacho, telefonos_desp, nombre_desp, senal_advertencia, estado, linea_credito, dicom, fecha_ingreso, observacion, maquinas, email_contacto2, actualizado, giro, telefonos_desp2, email_contacto_despacho2, referencia, ficha_cliente, encargado_produccion, maquina16, maquina18, maquina320, ejec_new As String

            rut = txt_rut2.Text
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
            If txt_linea_credito.Text = "" Then
                linea_credito = "0"
            Else
                linea_credito = txt_linea_credito.Text
            End If
            dicom = txt_dicom.Text
            observacion = txt_observacion.Text
            cond = txt_condicion.Text
            ejec_digital = txt_ejec_dig.Text
            ejec_media = txt_ejec_media.Text
            ejec_led = txt_ejec_led.Text
            ejec_mac = txt_ejec_mac.Text
            email_despacho = txt_email_desp.Text
            estado = txt_estado.Text
            telefonos_desp2 = txt_telefonos_desp.Text
            maquinas = ""
            email_contacto2 = ""
            giro = txt_giro.Text
            email_contacto_despacho2 = ""
            referencia = txt_referencia.Text
            ficha_cliente = txt_ficha_cliente.Text
            encargado_produccion = ""
            maquina16 = ""
            maquina18 = ""
            maquina320 = ""
            ejec_new = txt_ejecnew.Text

            If sw = 0 Then
                If (nue_cur.listar2(Me.txt_rut2.Text) = Me.txt_rut2.Text) Then
                    MessageBox.Show("Este Cliente ya existe")
                Else
                    'nue_cur.insertar(rut, razon_social, direccion, comuna, telefono, nombre_com, cargo_com, telefonos_com, email_com, nombre_fact, cargo_fact, telefonos_fact, email_fact, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_desp, email_despacho, telefonos_desp, nombre_desp, telefonos_desp2, senal_advertencia, estado, linea_credito, dicom, CDate(txt_fecha.Text), observacion, maquinas, email_contacto2, CDate(txt_fecha_act.Text), giro, email_contacto_despacho2, referencia, ficha_cliente, encargado_produccion, maquina16, maquina18, maquina320, ejec_new)
                    actualizar_dgv3()
                End If
            Else
                'nue_cur.modificar(CInt(cod_cur), rut, razon_social, direccion, comuna, telefono, nombre_com, cargo_com, telefonos_com, email_com, nombre_fact, cargo_fact, telefonos_fact, email_fact, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_desp, email_despacho, telefonos_desp, nombre_desp, telefonos_desp2, senal_advertencia, estado, linea_credito, dicom, CDate(txt_fecha.Text), observacion, maquinas, email_contacto2, CDate(txt_fecha_act.Text), giro, email_contacto_despacho2, referencia, ficha_cliente, encargado_produccion, maquina16, maquina18, maquina320, ejec_new)
                actualizar_dgv3()
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
            txt_razon_social.Enabled = False
            txt_rut2.Enabled = False
        End If
    End Sub

    Private Sub dgv_curso_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_curso.CellDoubleClick
        cod_cur = dgv_curso.CurrentRow.Cells(0).Value.ToString()
        txt_rut2.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
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
        txt_condicion.Text = dgv_curso.CurrentRow.Cells(14).Value.ToString()
        txt_forma_de_pago.Text = dgv_curso.CurrentRow.Cells(15).Value.ToString()
        txt_ejec_dig.Text = dgv_curso.CurrentRow.Cells(16).Value.ToString()
        txt_ejec_media.Text = dgv_curso.CurrentRow.Cells(17).Value.ToString()
        txt_ejec_led.Text = dgv_curso.CurrentRow.Cells(18).Value.ToString()
        txt_ejec_mac.Text = dgv_curso.CurrentRow.Cells(19).Value.ToString()
        txt_direccion_desp.Text = dgv_curso.CurrentRow.Cells(20).Value.ToString()
        txt_email_desp.Text = dgv_curso.CurrentRow.Cells(21).Value.ToString()
        txt_telefonos_desp.Text = dgv_curso.CurrentRow.Cells(22).Value.ToString()
        txt_nombre_desp.Text = dgv_curso.CurrentRow.Cells(23).Value.ToString()
        txt_senal_advertencia.Text = dgv_curso.CurrentRow.Cells(25).Value.ToString()
        txt_estado.Text = dgv_curso.CurrentRow.Cells(26).Value.ToString()
        txt_linea_credito.Text = dgv_curso.CurrentRow.Cells(27).Value.ToString()
        txt_dicom.Text = dgv_curso.CurrentRow.Cells(28).Value.ToString()

        If IsDate(dgv_curso.CurrentRow.Cells(29).Value.ToString()) Then
            txt_fecha.Text = dgv_curso.CurrentRow.Cells(29).Value.ToString()
        End If

        txt_observacion.Text = dgv_curso.CurrentRow.Cells(30).Value.ToString()

        If IsDate(dgv_curso.CurrentRow.Cells(33).Value.ToString()) Then
            txt_fecha_act.Text = dgv_curso.CurrentRow.Cells(33).Value.ToString()
        End If

        txt_giro.Text = dgv_curso.CurrentRow.Cells(34).Value.ToString()
        txt_referencia.Text = dgv_curso.CurrentRow.Cells(36).Value.ToString()
        txt_ficha_cliente.Text = dgv_curso.CurrentRow.Cells(37).Value.ToString()
        txt_ejecnew.Text = dgv_curso.CurrentRow.Cells(42).Value.ToString()

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
        txt_condicion.Text = 1
        txt_forma_de_pago.Text = "Efectivo"
        txt_linea_credito.Text = 0
        txt_senal_advertencia.Text = "OK"
        txt_ejec_dig.Text = "PAPIRO"
        txt_ejec_media.Text = "PAPIRO"
        txt_ejec_led.Text = "PAPIRO"
        txt_ejec_mac.Text = "PAPIRO"
        txt_ejecnew.Text = "PAPIRO"
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizar_dgv3()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv2()
    End Sub

    Sub actualizar_dgv2()
        dgv_curso.DataSource = nue_cur.listar4(txt_rut.Text)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Rut"
        dgv_curso.Columns(2).HeaderText = "Cliente"
        dgv_curso.Columns(3).HeaderText = "Dirección"
        dgv_curso.Columns(4).HeaderText = "Comuna"
        dgv_curso.Columns(5).HeaderText = "Telefonos"
        dgv_curso.Columns(6).HeaderText = "Contacto Comercial"
        dgv_curso.Columns(2).Width = 300
        dgv_curso.Columns(3).Width = 200
        dgv_curso.Columns(4).Width = 200
        dgv_curso.Columns(6).Width = 200
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
        dgv_curso.Columns(22).Visible = False
        dgv_curso.Columns(23).Visible = False
        dgv_curso.Columns(24).Visible = False
        dgv_curso.Columns(25).Visible = False
        dgv_curso.Columns(26).Visible = False
        dgv_curso.Columns(27).Visible = False
        dgv_curso.Columns(28).Visible = False
        dgv_curso.Columns(29).Visible = False
        dgv_curso.Columns(30).Visible = False
        dgv_curso.Columns(31).Visible = False
        dgv_curso.Columns(32).Visible = False
        dgv_curso.Columns(33).Visible = False
        dgv_curso.Columns(34).Visible = False
        dgv_curso.Columns(35).Visible = False
        dgv_curso.Columns(36).Visible = False
        dgv_curso.Columns(37).Visible = False
        dgv_curso.Columns(38).Visible = False
        dgv_curso.Columns(39).Visible = False
        dgv_curso.Columns(40).Visible = False
        dgv_curso.Columns(41).Visible = False
        dgv_curso.Columns(42).Visible = False
        dgv_curso.AllowUserToOrderColumns = True
    End Sub
    Sub actualizar_dgv3()
        dgv_curso.DataSource = nue_cur.listar3(txt_cliente.Text)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "RUT"
        dgv_curso.Columns(2).HeaderText = "Cliente"
        dgv_curso.Columns(3).HeaderText = "Dirección"
        dgv_curso.Columns(4).HeaderText = "Comuna"
        dgv_curso.Columns(5).Visible = False
        dgv_curso.Columns(6).Visible = False
        dgv_curso.Columns(1).Width = 70
        dgv_curso.Columns(2).Width = 250
        dgv_curso.Columns(3).Width = 200
        dgv_curso.Columns(4).Width = 100
        dgv_curso.Columns(6).Width = 200
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
        dgv_curso.Columns(22).Visible = False
        dgv_curso.Columns(23).Visible = False
        dgv_curso.Columns(24).Visible = False
        dgv_curso.Columns(25).Visible = False
        dgv_curso.Columns(26).Visible = False
        dgv_curso.Columns(27).Visible = False
        dgv_curso.Columns(28).Visible = False
        dgv_curso.Columns(29).Visible = False
        dgv_curso.Columns(30).Visible = False
        dgv_curso.Columns(31).Visible = False
        dgv_curso.Columns(32).Visible = False
        dgv_curso.Columns(33).Visible = False
        dgv_curso.Columns(34).Visible = False
        dgv_curso.Columns(35).Visible = False
        dgv_curso.Columns(36).Visible = False
        dgv_curso.Columns(37).Visible = False
        dgv_curso.Columns(38).Visible = False
        dgv_curso.Columns(39).Visible = False
        dgv_curso.Columns(40).Visible = False
        dgv_curso.Columns(41).Visible = False
        dgv_curso.Columns(42).Visible = False
        dgv_curso.AllowUserToOrderColumns = True
    End Sub

    Private Sub dgv_curso_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_curso.CellContentClick

    End Sub
End Class