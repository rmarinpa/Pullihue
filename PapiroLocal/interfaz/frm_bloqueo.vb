Public Class frm_bloqueo
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
        txt_rut.Text = frm_representates.txt_rut2.Text
        txt_rut.Text = frm_representates.txt_rut_empresa.Text

        If frm_representates.txt_senal_advertencia.Text = "OK" Then
            txt_bloqueo_desbloqueo.Text = "DESBLOQUEO"
        Else
            txt_bloqueo_desbloqueo.Text = "BLOQUEO"
        End If

        txt_senal_advertencia.Text = frm_representates.txt_senal_advertencia.Text

        actualizar_dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        frm_representates.txt_senal_advertencia.Text = senal_ver
        bloqueo = 1
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If (txt_razon.Text <> "") Then
            bloqueo = 0
            frm_representates.txt_bl_cliente.Clear()
            frm_representates.txt_bl_rut.Clear()
            frm_representates.txt_bl_fecha.Clear()
            frm_representates.txt_bl_hora.Clear()
            frm_representates.txt_bl_razon.Clear()
            frm_representates.txt_bl_usuario.Clear()
            frm_representates.txt_bl_bloqueo.Clear()
            frm_representates.txt_bl_senal.Clear()

            frm_representates.txt_bl_cliente.Text = frm_representates.txt_razon_social.Text
            frm_representates.txt_bl_rut.Text = frm_representates.txt_rut_empresa.Text
            frm_representates.txt_bl_fecha.Text = txt_fecha_act.Text
            frm_representates.txt_bl_hora.Text = txt_hora.Text
            frm_representates.txt_bl_razon.Text = txt_razon.Text
            frm_representates.txt_bl_usuario.Text = txt_nombre_ejecutivo.Text
            frm_representates.txt_bl_bloqueo.Text = txt_bloqueo_desbloqueo.Text
            frm_representates.txt_bl_senal.Text = txt_senal_advertencia.Text
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