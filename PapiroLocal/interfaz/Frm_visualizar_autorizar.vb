Imports System.Globalization
Public Class Frm_visualizar_autorizar
    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub actualizar_dgv()
        dgv_autorizacion.DataSource = nue_report.listar19()
        dgv_autorizacion.Columns(0).Visible = False
        dgv_autorizacion.Columns(3).Visible = False
        dgv_autorizacion.Columns(4).Visible = False
        dgv_autorizacion.Columns(5).HeaderText = "Toma Pedido"
        dgv_autorizacion.Columns(5).Width = 100
        dgv_autorizacion.Columns(10).Width = 100
        dgv_autorizacion.Columns(6).Visible = False
        dgv_autorizacion.Columns(7).Visible = False
        dgv_autorizacion.Columns(8).Visible = False
        dgv_autorizacion.Columns(9).Visible = False
        dgv_autorizacion.Columns(13).HeaderText = "Cliente"
        dgv_autorizacion.Columns(1).DefaultCellStyle.Format = "#,#"
        dgv_autorizacion.AllowUserToOrderColumns = True
        dgv_autorizacion.Columns(1).Width = 60
        dgv_autorizacion.Columns(2).Width = 80
        dgv_autorizacion.Columns(3).Width = 60
        dgv_autorizacion.Columns(4).Width = 60
        dgv_autorizacion.Columns(6).Width = 60
        dgv_autorizacion.Columns(13).Width = 200
        dgv_autorizacion.Columns(8).Visible = False
        dgv_autorizacion.Columns(9).Visible = False
        dgv_autorizacion.Columns(10).HeaderText = "Autoriza"
        dgv_autorizacion.Columns(11).HeaderText = "Tipo"
        dgv_autorizacion.Columns(12).HeaderText = "Observaciones"
        dgv_autorizacion.Columns(12).Width = 300



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
        Me.Location = New Point(200, 10)
        actualizar_dgv_folio()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizar_dgv()
    End Sub


    Sub actualizar_dgv_folio()
        dgv_nc.DataSource = nue_report.listar22()
        dgv_nc.Columns(0).Visible = False
        dgv_nc.Columns(1).HeaderText = "Folio"
        dgv_nc.Columns(2).HeaderText = "Nota de Crédito"
        dgv_nc.Columns(3).HeaderText = "Factura"
        dgv_nc.Columns(4).HeaderText = "Cliente"
        dgv_nc.Columns(5).Visible = False
        dgv_nc.Columns(6).Visible = False
        dgv_nc.Columns(7).Visible = False
        dgv_nc.Columns(8).Visible = False
        dgv_nc.Columns(9).Visible = False
        dgv_nc.Columns(10).Visible = False
        dgv_nc.Columns(11).Visible = False
        dgv_nc.Columns(12).Visible = False
        dgv_nc.Columns(13).Visible = False
        dgv_nc.Columns(14).Visible = False
        dgv_nc.Columns(15).Visible = False
        dgv_nc.Columns(16).Visible = False
        dgv_nc.Columns(17).HeaderText = "Status"
        dgv_nc.Columns(18).Visible = False
        dgv_nc.Columns(19).Visible = False
        dgv_nc.Columns(20).Visible = False

        dgv_nc.Columns(1).Width = 70
        dgv_nc.Columns(2).Width = 70
        dgv_nc.Columns(3).Width = 70
        dgv_nc.Columns(4).Width = 300
        dgv_nc.Columns(17).Width = 100

    End Sub

    Private Sub dgv_nc_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_nc.CellDoubleClick
        txt_nc.Text = dgv_nc.CurrentRow.Cells(1).Value.ToString()
        CR_Nota_Credito.Show()
    End Sub

    Private Sub dgv_nc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_nc.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CR_autorizacion.Show()
    End Sub
End Class