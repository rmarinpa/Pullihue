Public Class frm_precios
    Dim nue_report As New clases.Alerta
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub frm_bloqueo_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_fecha_in.Text = Today
        dtp_fecha_fin.Text = Today
        actualizar_dgv()
        If tipo_precio = 1 Then
            lbl_precios.Text = "ALERTA PRECIOS MÍNIMOS"
        ElseIf tipo_precio = 0 Then
            lbl_precios.Text = "ALERTA PRECIOS MÁXIMOS"
        End If
    End Sub

    Sub actualizar_dgv()
        Dim fecha, fecha2 As String

        fecha = Me.dtp_fecha_fin.Value.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")

        fecha2 = Me.dtp_fecha_in.Value.ToShortDateString
        fecha2 = Format(CDate(fecha2), "yyyy/MM/dd")

        If tipo_precio = 1 Then
            dgv_alerta.DataSource = nue_report.listar(fecha, fecha2)
        ElseIf tipo_precio = 0 Then
            dgv_alerta.DataSource = nue_report.listar2(fecha, fecha2)
        End If

        dgv_alerta.Columns(0).Visible = False
        dgv_alerta.Columns(1).HeaderText = "Usuario"
        dgv_alerta.Columns(2).Visible = False
        dgv_alerta.Columns(3).HeaderText = "Nombre Cliente"
        dgv_alerta.Columns(4).HeaderText = "Fecha"
        dgv_alerta.Columns(5).HeaderText = "Número Pedido"
        dgv_alerta.Columns(6).HeaderText = "Código Producto"
        dgv_alerta.Columns(7).HeaderText = "Nombre Producto"
        dgv_alerta.Columns(8).HeaderText = "Cantidad"
        dgv_alerta.Columns(9).HeaderText = "Precio"
        dgv_alerta.Columns(10).HeaderText = "Precio Mín."
        dgv_alerta.Columns(11).HeaderText = "Precio Máx."
        dgv_alerta.Columns(12).Visible = False

        dgv_alerta.Columns(1).Width = 100
        dgv_alerta.Columns(3).Width = 350
        dgv_alerta.Columns(4).Width = 70
        dgv_alerta.Columns(5).Width = 80
        dgv_alerta.Columns(6).Width = 100
        dgv_alerta.Columns(7).Width = 250
        dgv_alerta.Columns(8).Width = 80
        dgv_alerta.Columns(9).Width = 80
        dgv_alerta.Columns(10).Width = 80
        dgv_alerta.Columns(11).Width = 80


        dgv_alerta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_alerta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar_dgv()
    End Sub
End Class