Public Class frm_bloqueos_mod
    Dim nue_report As New clases.Bloqueos
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Sub actualizar_dgv()
        dgv_alerta.DataSource = nue_report.listar()

        dgv_alerta.Columns(0).HeaderText = "Cliente"
        dgv_alerta.Columns(1).HeaderText = "Rut"
        dgv_alerta.Columns(2).HeaderText = "Fecha última Venta"
        dgv_alerta.Columns(3).HeaderText = "Señal advertencia"

        dgv_alerta.Columns(0).Width = 200
        dgv_alerta.Columns(1).Width = 100
        dgv_alerta.Columns(2).Width = 100
        dgv_alerta.Columns(3).Width = 100

    End Sub

    Sub actualizar_dgv2()
        dgv_alerta2.DataSource = nue_report.listar2()

        dgv_alerta2.Columns(0).HeaderText = "Cliente"
        dgv_alerta2.Columns(1).HeaderText = "Rut"
        dgv_alerta2.Columns(2).HeaderText = "Señal advertencia"

        dgv_alerta2.Columns(0).Width = 200
        dgv_alerta2.Columns(1).Width = 100
        dgv_alerta2.Columns(2).Width = 100

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_bloqueos.Click
        actualizar_dgv()
    End Sub

    Private Sub frm_bloqueos_mod_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_bloqueos2_Click(sender As Object, e As EventArgs) Handles btn_bloqueos2.Click
        actualizar_dgv2()
    End Sub
End Class