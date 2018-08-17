Public Class frm_observacion
    Dim nue_report As New clases.Bloqueo
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_fecha_act.Text = Today
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub frm_bloqueo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        txt_nombre_ejecutivo.Text = Nombre_Obra
        txt_nombre_ejecutivo.ReadOnly = True
        txt_fecha_act.ReadOnly = True
        txt_hora.ReadOnly = True
        txt_cliente.ReadOnly = True
        txt_rut.ReadOnly = True
        txt_bloqueo_desbloqueo.ReadOnly = True
        txt_senal_advertencia.ReadOnly = True

        txt_cliente.Text = frm_representates.txt_razon_social.Text
        'txt_rut.Text = frm_representates.txt_rut2.Text

        txt_bloqueo_desbloqueo.Text = "OBSERVACIÓN"
        txt_senal_advertencia.Text = frm_representates.txt_senal_advertencia.Text

        actualizar_dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If (txt_razon.Text <> "") Then
            Dim bl_usuario, bl_rut, bl_cliente, bl_bloqueo, bl_senal, bl_razon As String
            bl_usuario = txt_nombre_ejecutivo.Text
            bl_rut = txt_rut.Text
            bl_cliente = txt_cliente.Text
            bl_bloqueo = txt_bloqueo_desbloqueo.Text
            bl_senal = txt_senal_advertencia.Text
            bl_razon = txt_razon.Text

            nue_report.insertar2(bl_usuario, bl_rut, bl_cliente, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), bl_bloqueo, bl_senal, bl_razon)
            MsgBox("OBSERVACIÓN AGREGADA CON ÉXITO")
            Me.Close()
        Else
            MsgBox("FALTA LLENAR LA RAZÓN")
        End If
    End Sub

    Sub actualizar_dgv()
        dgv_bloqueo.DataSource = nue_report.listar(frm_representates.txt_rut_empresa.Text)
        dgv_bloqueo.Columns(0).Visible = False
        dgv_bloqueo.Columns(1).HeaderText = "Usuario"
        dgv_bloqueo.Columns(2).Visible = False
        dgv_bloqueo.Columns(3).Visible = False
        dgv_bloqueo.Columns(4).HeaderText = "Fecha"
        dgv_bloqueo.Columns(5).HeaderText = "Hora"
        dgv_bloqueo.Columns(5).DefaultCellStyle.Format = "hh:mm"
        dgv_bloqueo.Columns(6).HeaderText = "Status"
        dgv_bloqueo.Columns(7).HeaderText = "Señal Advertencia"
        dgv_bloqueo.Columns(8).HeaderText = "Razón"

        dgv_bloqueo.Columns(1).Width = 70
        dgv_bloqueo.Columns(4).Width = 70
        dgv_bloqueo.Columns(5).Width = 70
        dgv_bloqueo.Columns(6).Width = 100
        dgv_bloqueo.Columns(7).Width = 70
        dgv_bloqueo.Columns(8).Width = 500

        dgv_bloqueo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
End Class