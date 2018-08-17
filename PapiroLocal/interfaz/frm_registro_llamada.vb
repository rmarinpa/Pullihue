Public Class frm_registro_llamada
    Dim nue_cur As New clases.Registro_llamada
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_duracion.ReadOnly = True
        txt_duracion.ReadOnly = True
        txt_fecha.ReadOnly = True
        txt_inicio.ReadOnly = True
        txt_final.ReadOnly = True
        Timer1.Enabled = True
        txt_cobranza.ReadOnly = True
        txt_usuario.ReadOnly = True
        txt_usuario.Text = Nombre_Obra
        txt_folio.ReadOnly = True
        txt_fecha_prog.Visible = False
        cmb_dia.Visible = False
        lbl_programacion.Visible = False
        limpiar()
        'txt_contacto_pago.ReadOnly = True
        'txt_cargo_pago.ReadOnly = True
        'txt_telefonos_pago.ReadOnly = True
        'txt_email_pago.ReadOnly = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '   txt_inicio.Text = Date.Now.ToLongTimeString
    '   txt_fecha.Text = Today
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txt_final.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tiempo1, tiempo2, resta As TimeSpan
        If txt_final.Text <> "" Then
            tiempo1 = TimeSpan.Parse(txt_final.Text)
            tiempo2 = TimeSpan.Parse(txt_inicio.Text)
            resta = tiempo1 - tiempo2
            Timer2.Enabled = False
            txt_duracion.Text = resta.ToString
        Else
            MessageBox.Show("DEBE PRIMERO INICIALIZAR LA LLAMADA PARA LUEGO TERMINARLA")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frm_clientes_busqueda.Show()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim cliente, atendio, motivo, telefono, tipo, linea, importancia, informe, usuario, tipo_llamada, tipo_medio, hecho As String
        Dim inicio, fin, duracion As Date
        hecho = "no"
        If cmb_tipo_llamada.Text = "Cobranza" Then
            If cmb_importancia.Text <> "" And cmb_dia.Text <> "" Then

                If (txt_cliente.Text <> "" And txt_atendio.Text <> "" And txt_motivo.Text <> "" And txt_duracion.Text <> "" And txt_informe.Text <> "" And txt_final.Text <> "" And cmb_tipo_llamada.Text <> "" And cmb_linea.Text <> "" And (chk_email.Checked = True Or chk_tel.Checked = True Or chk_what.Checked = True)) Then

                    cliente = txt_cliente.Text
                    atendio = txt_atendio.Text
                    motivo = txt_motivo.Text
                    telefono = cmb_telefono.Text
                    tipo = cmb_tipo_llamada.Text
                    linea = cmb_linea.Text
                    importancia = cmb_importancia.Text
                    informe = txt_informe.Text
                    usuario = txt_usuario.Text
                    tipo_llamada = txt_cobranza.Text
                    If chk_email.Checked = True Then
                        tipo_medio = "E-mail"
                    ElseIf chk_tel.Checked = True Then
                        tipo_medio = "Teléfono"
                    ElseIf chk_what.Checked = True Then
                        tipo_medio = "Whatsapp"
                    End If
                    txt_folio.Text = nue_cur.descripcion_numero_folio() + 1
                    nue_cur.insertar(cliente, atendio, motivo, telefono, tipo, CDate(txt_inicio.Text), CDate(txt_final.Text), CDate(txt_duracion.Text), linea, importancia, informe, CDate(txt_fecha.Text), usuario, tipo_llamada, tipo_medio, txt_folio.Text)
                    If cmb_tipo_llamada.Text = "Cobranza" Then
                        nue_cur.insertar2(CDate(txt_fecha.Text), CDate(txt_fecha_prog.Text), cmb_dia.Text, txt_folio.Text, hecho)
                    End If
                    limpiar()
                    MessageBox.Show("SU LLAMADA HA SIDO REGISTRADA EXITOSAMENTE")
                    limpiar()
                Else
                    MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                End If
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            End If
        Else
            If (txt_cliente.Text <> "" And txt_atendio.Text <> "" And txt_motivo.Text <> "" And txt_duracion.Text <> "" And txt_informe.Text <> "" And txt_final.Text <> "" And cmb_tipo_llamada.Text <> "" And (chk_email.Checked = True Or chk_tel.Checked = True Or chk_what.Checked = True)) Then

                cliente = txt_cliente.Text
                atendio = txt_atendio.Text
                motivo = txt_motivo.Text
                telefono = cmb_telefono.Text
                tipo = cmb_tipo_llamada.Text
                linea = cmb_linea.Text
                importancia = cmb_importancia.Text
                informe = txt_informe.Text
                usuario = txt_usuario.Text
                tipo_llamada = txt_cobranza.Text
                If chk_email.Checked = True Then
                    tipo_medio = "E-mail"
                ElseIf chk_tel.Checked = True Then
                    tipo_medio = "Teléfono"
                ElseIf chk_what.Checked = True Then
                    tipo_medio = "Whatsapp"
                End If
                txt_folio.Text = nue_cur.descripcion_numero_folio() + 1
                nue_cur.insertar(cliente, atendio, motivo, telefono, tipo, CDate(txt_inicio.Text), CDate(txt_final.Text), CDate(txt_duracion.Text), linea, importancia, informe, CDate(txt_fecha.Text), usuario, tipo_llamada, tipo_medio, txt_folio.Text)
                If cmb_tipo_llamada.Text = "Cobranza" Then
                    nue_cur.insertar2(CDate(txt_fecha.Text), CDate(txt_fecha_prog.Text), cmb_dia.Text, txt_folio.Text, hecho)
                End If
                limpiar()
                MessageBox.Show("SU LLAMADA HA SIDO REGISTRADA EXITOSAMENTE")
                limpiar()
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            End If
        End If
    End Sub
    Sub limpiar()
        txt_atendio.Clear()
        txt_cliente.Clear()
        txt_motivo.Clear()
        cmb_telefono.Text = ""
        cmb_tipo_llamada.Text = ""
        txt_final.Clear()
        txt_inicio.Clear()
        Timer1.Enabled = True
        txt_duracion.Clear()
        cmb_linea.Text = ""
        cmb_importancia.Text = ""
        txt_informe.Clear()
        cmb_tipo_llamada.Text = ""
        cmb_importancia.Items.Clear()
        cmb_linea.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CR_Registro_llamada.Show()
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub chk_tel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tel.CheckedChanged
        If chk_tel.Checked = True Then
            chk_email.Checked = False
            chk_what.Checked = False
        End If
    End Sub

    Private Sub chk_email_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_email.CheckedChanged
        If chk_email.Checked = True Then
            chk_tel.Checked = False
            chk_what.Checked = False
        End If
    End Sub

    Private Sub chk_what_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_what.CheckedChanged
        If chk_what.Checked = True Then
            chk_tel.Checked = False
            chk_email.Checked = False
        End If
    End Sub

    Private Sub cmb_importancia_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_importancia.MouseClick
        If cmb_tipo_llamada.Text = "Cobranza" Then
            cmb_importancia.Items.Clear()
            cmb_importancia.Items.Add("Retiro Documento")
            cmb_importancia.Items.Add("Reprogramar llamada")
            cmb_importancia.Items.Add("Enviar Estado de Cuenta")

        Else
            cmb_importancia.Items.Clear()
        End If
    End Sub
    Private Sub cmb_importancia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_importancia.SelectedIndexChanged

    End Sub

    Private Sub cmb_tipo_llamada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo_llamada.SelectedIndexChanged

    End Sub

    Private Sub cmb_tipo_llamada_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_tipo_llamada.TextChanged
        If cmb_tipo_llamada.Text = "Cobranza" Then
            txt_fecha_prog.Visible = True
            cmb_dia.Visible = True
            lbl_programacion.Visible = True

        Else
            txt_fecha_prog.Visible = False
            cmb_dia.Visible = False
            lbl_programacion.Visible = False
        End If
    End Sub

    Private Sub btn_retiro_Click(sender As Object, e As EventArgs) Handles btn_retiro.Click
        If txt_cliente.Text <> "" And txt_rut.Text <> "" Then
            variable_retiro = 0
            frm_retiro_documentos_2.Show()
        Else
            MsgBox("PRIMERO DEBE INGRESAR EL CLIENTE QUE SE LE REQUIERE HACER EL RETIRO DE DOCUMENTOS")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txt_rut.Text <> "" Then
            Dim rut, contacto_pago, cargo_contacto, telefono_contacto, email_contacto As String

            rut = txt_rut.Text
            contacto_pago = txt_contacto_pago.Text
            cargo_contacto = txt_cargo_pago.Text
            telefono_contacto = txt_telefonos_pago.Text
            email_contacto = txt_email_pago.Text

            nue_cur.modificar3(rut, contacto_pago, cargo_contacto, telefono_contacto, email_contacto)
            MsgBox("CAMBIOS REALIZADOS SATISFACTORIAMENTE")
        End If
    End Sub
End Class