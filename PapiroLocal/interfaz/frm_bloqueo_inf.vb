Public Class frm_bloqueo_inf
    Dim nue_report As New clases.Bloqueo
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub frm_bloqueo_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizar_dgv()
    End Sub

    Sub actualizar_dgv()
        If bloqueo_inf = 1 Then
            dgv_bloqueo.DataSource = nue_report.listar(Frm_ventas_mod.txt_rut.Text)
        ElseIf bloqueo_inf = 2 Then
            dgv_bloqueo.DataSource = nue_report.listar(Frm_autorizar.txt_rut.Text)
        ElseIf bloqueo_inf = 3 Then
            dgv_bloqueo.DataSource = nue_report.listar(Frm_autorizar_gd.txt_rut.Text)
        End If
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
        dgv_bloqueo.Columns(7).Width = 100
        dgv_bloqueo.Columns(8).Width = 500

        dgv_bloqueo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_bloqueo.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class