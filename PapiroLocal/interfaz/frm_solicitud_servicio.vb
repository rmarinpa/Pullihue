Public Class frm_solicitud_servicio
    Dim nue_cur As New clases.Registro_llamada
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_fecha.ReadOnly = True
        Timer1.Enabled = True
        txt_usuario.ReadOnly = True
        txt_usuario.Text = Nombre_Obra
        txt_folio.ReadOnly = True
        limpiar()
    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    'txt_fecha.Text = Today
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frm_clientes_busqueda_serv.Show()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Sub limpiar()
        txt_cliente.Clear()
        txt_motivo.Clear()
        txt_solicitante.Clear()
        Timer1.Enabled = True
        txt_observacion.Clear()
        txt_telefono.Clear()
        txt_email.Clear()
        txt_direccion.Clear()
        txt_comuna.Clear()
        txt_motivo.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CR_Registro_llamada.Show()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        If (txt_solicitante.Text <> "" And txt_cliente.Text <> "" And txt_telefono.Text <> "" And txt_email.Text <> "" And txt_direccion.Text <> "" And txt_comuna.Text <> "" And txt_motivo.Text <> "" And txt_observacion.Text <> "" And cmb_dia.Text <> "") Then
            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient
            Dim cuenta, cuenta2, motivo As String

            cuenta = "tbustos@papirochile.cl"
            cuenta2 = "gsolis@cfv.cl"
            motivo = "Visita Servicio Técnico"
            'CONFIGURACIÓN DEL STMP
            '_SMTP.Credentials = New System.Net.NetworkCredential("cuenta de correo", "contraseña")
            _SMTP.Credentials = New System.Net.NetworkCredential("gsolis@cfv.cl", "gsolis2013")
            _SMTP.Host = "smtp.gmail.com"
            _SMTP.Port = 587
            _SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            '_Message.[To].Add(Me.txtPara.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.[To].Add(cuenta) 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.[To].Add(cuenta2)
            _Message.From = New System.Net.Mail.MailAddress("gsolis@cfv.cl", "gsolis2013", System.Text.Encoding.UTF8) 'Quien lo envía
            _Message.Subject = motivo 'Sujeto del e-mail
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
            _Message.Body = "CLIENTE: " + Me.txt_cliente.Text.ToString & vbCrLf &
                            "SOLICITANTE: " + Me.txt_solicitante.Text.ToString & vbCrLf &
                            "TELÉFONO: " + Me.txt_telefono.Text.ToString & vbCrLf &
                            "E-MAIL: " + Me.txt_email.Text.ToString & vbCrLf &
                            "DIRECCIÓN: " + Me.txt_direccion.Text.ToString & vbCrLf &
                            "COMUNA: " + Me.txt_comuna.Text.ToString & vbCrLf &
                            "FECHA PROPUESTA: " + Me.dtp_fecha.Text.ToString & vbCrLf &
                            "HORA PROPUESTA: " + Me.cmb_dia.Text.ToString & vbCrLf &
                            "MOTIVO: " + Me.txt_motivo.Text.ToString & vbCrLf &
                            "OBSERVACIÓN: " + Me.txt_observacion.Text.ToString
            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = False

            'ENVIO
            Try
                _SMTP.Send(_Message)
                MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
            Catch ex As System.Net.Mail.SmtpException
                MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
            End Try
            limpiar()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
End Class