Imports System.Globalization
Public Class Frm_visualizar_autorizar2
    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub actualizar_dgv()
        dgv_autorizacion.DataSource = nue_report.listar20()
        dgv_autorizacion.Columns(0).Visible = False
        dgv_autorizacion.Columns(1).HeaderText = "Folio"
        dgv_autorizacion.Columns(2).HeaderText = "Fecha"
        dgv_autorizacion.Columns(3).HeaderText = "Hora"
        dgv_autorizacion.Columns(3).Visible = False
        dgv_autorizacion.Columns(4).Visible = False
        dgv_autorizacion.Columns(5).Visible = False
        dgv_autorizacion.Columns(6).Visible = False
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).Visible = False
        dgv_autorizacion.Columns(9).Visible = False
        dgv_autorizacion.Columns(1).DefaultCellStyle.Format = "#,#"
        dgv_autorizacion.AllowUserToOrderColumns = True
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 80
        dgv_autorizacion.Columns(3).Width = 60
        dgv_autorizacion.Columns(4).Width = 60
        dgv_autorizacion.Columns(5).Width = 60
        dgv_autorizacion.Columns(6).Width = 60
        dgv_autorizacion.Columns(7).Width = 200
        dgv_autorizacion.Columns(8).Visible = False
        dgv_autorizacion.Columns(9).Visible = False
        dgv_autorizacion.Columns(10).HeaderText = "Autoriza"
        dgv_autorizacion.Columns(11).HeaderText = "Tipo"
        dgv_autorizacion.Columns(12).HeaderText = "Observaciones"
        dgv_autorizacion.Columns(12).Width = 200
        dgv_autorizacion.Columns(10).Width = 100
        dgv_autorizacion.Columns(11).Width = 100

    End Sub

    Private Sub dgv_autorizacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_autorizacion.CellClick
        If dgv_autorizacion.CurrentRow.Cells(11).Value.ToString() = "RECHAZA" Then
            MsgBox("ESTE PEDIDO HA SIDO RECHAZADO")
        Else
            txt_folio.Text = dgv_autorizacion.CurrentRow.Cells(1).Value.ToString()
            CR_guia_de_despacho_aut3.Show()
        End If
    End Sub

    Private Sub Frm_visualizar_autorizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizar_dgv()
    End Sub
End Class