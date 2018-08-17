Imports System.Net
Imports System.IO
Public Class frm_ticket_nuevo

    Dim asunto, comentario, departamento, fecha, hora, imagen, nombre, prioridad, usuario As String
    Dim solicitud_id, tipo_documento As Integer
    Dim carga_completa As Boolean = False

    Dim nuevo_ticket As New clases.Ticket
    Dim nuevo_historial As New clases.Historial_solicitud
    Dim nuevo_departamento As New clases.Departamento

    Dim cod_cur As String = ""
    Dim sw As Integer

    Dim usuarioFTP As String = "Papiro@constructorafv.com"
    Dim servidorFTP As String = "ftp://201.148.105.75/"
    Dim contrasenaFTP As String = "0F6iQF{j;Czw"
    Dim puertoFTP As String = "21"

    Dim nuevo_ftp As New clases.Ftp(servidorFTP, usuarioFTP, contrasenaFTP)


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Asignacion()
        If (Not nombre.Equals("") And Not comentario.Equals("") And Not asunto.Equals("") And Not prioridad.Equals("") And Not departamento.Equals("")) Then
            If txt_solicitud_id.Text.Trim().Equals("0") Then
                nuevo_ticket.NuevoTicket(nombre, asunto, departamento, prioridad, fecha)
                If txt_ruta_archivo.Text.Equals(Nothing) Then
                    imagen = Nothing
                End If
                nuevo_historial.NuevaObservacion(comentario, fecha, usuario, imagen)
                If imagen <> Nothing Then
                    CrearFichero()
                    My.Computer.Network.UploadFile(txt_ruta_archivo.Text, servidorFTP & frm_ticket_solicitud.lbl_fecha.Text & "/" & OpenFileDialog1.SafeFileName, usuarioFTP, contrasenaFTP)
                End If
            Else
                nuevo_historial.NuevaObservacion(comentario, fecha, usuario, CInt(txt_solicitud_id.Text.Trim()), imagen)
            End If
            MsgBox("Ticket generado.", MsgBoxStyle.Information, "Bien hecho.")
            Limpiar()
            'frm_solicitud_ticket.abrir_en_panel(frm_modificar, pnl_body)
        Else
            MsgBox("Hay campos que debe completar. Favor llenar campos necesarios.", MsgBoxStyle.Information, "Información.")
        End If
        Me.Close()
    End Sub

    Private Sub Asignacion()
        nombre = mtxt_nombre.Text
        departamento = cmb_departamento.SelectedValue.ToString()
        prioridad = cmb_prioridad.SelectedItem.ToString()
        asunto = txt_asunto.Text.Trim()
        comentario = txt_comentario.Text.Trim()
        fecha = frm_ticket_solicitud.lbl_fecha.Text
        hora = frm_ticket_solicitud.lbl_hora.Text
        fecha = fecha + " " + hora
        usuario = frm_ticket_solicitud.lbl_solicitante.Text
        'imagen = txt_ruta_archivo.Text
    End Sub

    Private Sub Limpiar()
        'txt_solicitud_id.Text = Nothing ' variable para agregar un historial.
        'mtxt_nombre.Text = Nothing
        txt_asunto.Text = Nothing
        txt_comentario.Text = Nothing
        cmb_departamento.SelectedIndex = 0
        cmb_prioridad.SelectedIndex = 0
        txt_ruta_archivo.Text = Nothing
    End Sub

    Public Sub Carga_departamento()
        cmb_departamento.DataSource = nuevo_departamento.Listar()
        cmb_departamento.DisplayMember = "Nombre"
        cmb_departamento.ValueMember = "Nombre"
        cmb_departamento.SelectedIndex = 0
    End Sub

    Private Sub frm_nuevo_ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        Carga_departamento()
        'cmb_prioridad.SelectedIndex = 0
        solicitud_id = txt_solicitud_id.Text.Trim()
        If Not solicitud_id = 0 Then
            RegistroExistente()
            'mtxt_nombre.Text = nuevo_ticket.BuscarTicket(solicitud_id)

            dgv_registro.DataSource = nuevo_ticket.BuscarTicket(solicitud_id)
            mtxt_nombre.Text = dgv_registro.Rows(0).Cells(6).Value ' NOMBRE
            txt_asunto.Text = dgv_registro.Rows(0).Cells(1).Value.ToString() ' ASUNTO
            cmb_prioridad.SelectedItem = dgv_registro.Rows(0).Cells(7).Value ' PRIORIDAD
            cmb_departamento.SelectedValue = dgv_registro.Rows(0).Cells(2).Value ' DEPARTAMENTO
        Else
            RegistroNuevo()
        End If
        carga_completa = True
    End Sub

    Private Sub cmb_departamento_TextChanged(sender As Object, e As EventArgs) Handles cmb_departamento.TextChanged
        If carga_completa Then
            If Not cmb_departamento.SelectedValue.Equals("Seleccione") Then
                nomenclatura(cmb_departamento.SelectedValue.ToString())
            Else
                mtxt_nombre.Text = Nothing
            End If
        End If
    End Sub

    Private Sub nomenclatura(departamento As String)
        Dim cantidad As Integer
        Dim valor As String
        Dim formato_date As Date

        valor = departamento.Substring(0, 3).ToUpper()
        formato_date = frm_ticket_solicitud.lbl_fecha.Text
        fecha = Format(formato_date, "yyyy/MM/dd")
        fecha = fecha.Replace("-", "")
        valor = valor & fecha
        cantidad = nuevo_ticket.BuscarNombre(valor) + 1 ' En caso que la nomenclatura este exista se le suma para crear una versión del día.
        mtxt_nombre.Text = valor & "-" & CStr(cantidad)
    End Sub

    Private Sub btn_adjuntar_Click(sender As Object, e As EventArgs) Handles btn_adjuntar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_ruta_archivo.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Function CrearFichero() As Boolean
        Try
            Dim ftp As FtpWebRequest = DirectCast(FtpWebRequest.Create(servidorFTP & frm_ticket_solicitud.lbl_fecha.Text), FtpWebRequest)
            Dim cred As New NetworkCredential(usuarioFTP, contrasenaFTP)
            ftp.Credentials = cred
            ftp.KeepAlive = False
            ftp.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequested
            ftp.Method = WebRequestMethods.Ftp.MakeDirectory
            ftp.UsePassive = False
            Dim ftpresp As FtpWebResponse = DirectCast(ftp.GetResponse(), FtpWebResponse)
            Dim sreader As New IO.StreamReader(ftpresp.GetResponseStream)
            ftpresp.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub txt_ruta_archivo_TextChanged(sender As Object, e As EventArgs) Handles txt_ruta_archivo.TextChanged
        If txt_ruta_archivo.Text.Length > 0 Then
            imagen = OpenFileDialog1.SafeFileName
        Else
            imagen = Nothing
        End If
    End Sub

    Private Sub RegistroExistente()
        cmb_prioridad.Enabled = False
        cmb_departamento.Enabled = False
        txt_asunto.Enabled = False
    End Sub
    Private Sub RegistroNuevo()
        cmb_prioridad.Enabled = True
        cmb_departamento.Enabled = True
        txt_asunto.Enabled = True
        cmb_prioridad.SelectedIndex = 0
    End Sub
End Class