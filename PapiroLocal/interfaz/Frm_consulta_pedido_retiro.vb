Imports System.Globalization
Imports System.IO
Public Class Frm_consulta_pedido_retiro

    Dim nue_cur As New clases.Retiros
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim contador As Integer
    Dim suma_neto As Integer
    Dim suma_total As Integer

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        txt_retiro.ReadOnly = True
        txt_ruta.ReadOnly = True
        dtp_fecha_in.Text = Today
        txt_fecha.Text = Today
        Timer1.Enabled = True
    End Sub

    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        Dim numero_folio As Integer
        contador = 0
        numero_folio = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
        dgv_despachos2.DataSource = nue_cur.listar7(numero_folio)

        ' Columnas NO visibles
        dgv_despachos2.Columns(0).Visible = False
        dgv_despachos2.Columns(1).Visible = False
        dgv_despachos2.Columns(2).Visible = False
        dgv_despachos2.Columns(3).Visible = False
        dgv_despachos2.Columns(4).Visible = False
        dgv_despachos2.Columns(5).Visible = False
        dgv_despachos2.Columns(8).Visible = False
        dgv_despachos2.Columns(9).Visible = False
        dgv_despachos2.Columns(10).Visible = False
        dgv_despachos2.Columns(11).Visible = False


        ' Titulo a las columnas
        dgv_despachos2.Columns(6).HeaderText = "N° de Factura"
        dgv_despachos2.Columns(7).HeaderText = "Monto"

        ' Formato Celdas
        dgv_despachos2.Columns(6).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(7).DefaultCellStyle.Format = "##,###."

        ' Posicion columnas
        dgv_despachos2.Columns(6).DisplayIndex = 0
        dgv_despachos2.Columns(7).DisplayIndex = 1


        dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineacion Titulos columnas

        ' Alineación contenido celdas
        dgv_despachos2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Dimenciones columnas
        dgv_despachos2.Columns(6).Width = 80
        dgv_despachos2.Columns(7).Width = 80


        txt_retiro.Clear()
        txt_ruta.Clear()
        txt_retiro.Text = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
        txt_ruta.Text = dgv_despachos.CurrentRow.Cells(10).Value.ToString()

        suma_neto = 0
        For Each r As DataGridViewRow In dgv_despachos2.Rows
            'r.Cells(1).ReadOnly = False
            If IsNumeric(r.Cells(7).Value) Then
                suma_neto = r.Cells(7).Value + suma_neto
            End If
        Next
        txt_total.Text = FormatNumber(suma_neto, 0)
        txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv_fecha()
    End Sub

    Sub actualizar_dgv_fecha()
        dgv_despachos.DataSource = Nothing

        Dim fecha, fecha2 As String

        fecha = Me.txt_fecha.Value.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")

        fecha2 = Me.dtp_fecha_in.Value.ToShortDateString
        fecha2 = Format(CDate(fecha2), "yyyy/MM/dd")

        dgv_despachos.DataSource = nue_cur.listar8(fecha, fecha2)

        ' Columnas No visibles
        dgv_despachos.Columns(2).Visible = False
        dgv_despachos.Columns(4).Visible = False
        dgv_despachos.Columns(5).Visible = False
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(8).Visible = False
        dgv_despachos.Columns(9).Visible = False
        dgv_despachos.Columns(12).Visible = False

        ' Titulo columnas
        dgv_despachos.Columns(0).HeaderText = "N° Retiro Doc"
        dgv_despachos.Columns(10).HeaderText = "N° Ruta"
        dgv_despachos.Columns(1).HeaderText = "Cliente"
        dgv_despachos.Columns(3).HeaderText = "Fecha Retiro"
        dgv_despachos.Columns(11).HeaderText = "Ejecutivo Ruta"
        dgv_despachos.Columns(13).HeaderText = "Fecha Ruta"
        dgv_despachos.Columns(14).HeaderText = "Hora Ruta"


        ' Fromatos celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(10).DefaultCellStyle.Format = "###,###,###"

        ' Dimensión celdas
        dgv_despachos.Columns(0).Width = 70
        dgv_despachos.Columns(10).Width = 70
        dgv_despachos.Columns(1).Width = 250
        dgv_despachos.Columns(3).Width = 70
        dgv_despachos.Columns(11).Width = 90
        dgv_despachos.Columns(13).Width = 70
        dgv_despachos.Columns(14).Width = 70

        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineación titulos columnas

        ' Alineación celdas
        dgv_despachos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_despachos.Columns(0).DisplayIndex = 0
        dgv_despachos.Columns(10).DisplayIndex = 1
        dgv_despachos.Columns(1).DisplayIndex = 2
        dgv_despachos.Columns(3).DisplayIndex = 3
        dgv_despachos.Columns(11).DisplayIndex = 4
        dgv_despachos.Columns(13).DisplayIndex = 5
        dgv_despachos.Columns(14).DisplayIndex = 6


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anular.Click
        If IsNumeric(txt_retiro.Text) And Not IsNumeric(txt_ruta.Text) And txt_ruta.Text <> "0" Then

            nue_cur.insertar("ANULADO", "ANULADO", "ANULADO", Today, TimeOfDay, txt_retiro.Text, "ANULADO", "ANULADO", "ANULADO", 1, "RETIRO", "ANULADO", "ANULADO", "ANULADO", "ANULADO")
            MsgBox("RETIRO ANULADO")
            actualizar_dgv_fecha()
        Else
            MessageBox.Show("EL RETIRO TIENE UNA RUTA ASIGNADA")
        End If
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        txt_iva.Text = FormatNumber(txt_total.Text * 0.19, 0)
        txt_total2.Text = FormatNumber(CInt(txt_total.Text) + CInt(txt_iva.Text), 0)
    End Sub

    Sub actualizar_pendientes()
        dgv_pendientes.DataSource = Nothing

        dgv_pendientes.DataSource = nue_cur.listar6()

        ' Columnas No visibles
        dgv_pendientes.Columns(2).Visible = False
        dgv_pendientes.Columns(4).Visible = False
        dgv_pendientes.Columns(5).Visible = False
        dgv_pendientes.Columns(6).Visible = False
        dgv_pendientes.Columns(7).Visible = False
        dgv_pendientes.Columns(8).Visible = False
        dgv_pendientes.Columns(9).Visible = False
        dgv_pendientes.Columns(12).Visible = False

        ' Titulo columnas
        dgv_pendientes.Columns(0).HeaderText = "N° Retiro Doc"
        dgv_pendientes.Columns(10).HeaderText = "N° Ruta"
        dgv_pendientes.Columns(1).HeaderText = "Cliente"
        dgv_pendientes.Columns(3).HeaderText = "Fecha Retiro"
        dgv_pendientes.Columns(11).HeaderText = "Ejecutivo Ruta"
        dgv_pendientes.Columns(13).HeaderText = "Fecha Ruta"
        dgv_pendientes.Columns(14).HeaderText = "Hora Ruta"


        ' Fromatos celdas
        dgv_pendientes.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_pendientes.Columns(10).DefaultCellStyle.Format = "###,###,###"

        ' Dimensión celdas
        dgv_pendientes.Columns(0).Width = 70
        dgv_pendientes.Columns(10).Width = 70
        dgv_pendientes.Columns(1).Width = 250
        dgv_pendientes.Columns(3).Width = 70
        dgv_pendientes.Columns(11).Width = 90
        dgv_pendientes.Columns(13).Width = 70
        dgv_pendientes.Columns(14).Width = 70

        dgv_pendientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineación titulos columnas

        ' Alineación celdas
        dgv_pendientes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_pendientes.Columns(0).DisplayIndex = 0
        dgv_pendientes.Columns(10).DisplayIndex = 1
        dgv_pendientes.Columns(1).DisplayIndex = 2
        dgv_pendientes.Columns(3).DisplayIndex = 3
        dgv_pendientes.Columns(11).DisplayIndex = 4
        dgv_pendientes.Columns(13).DisplayIndex = 5
        dgv_pendientes.Columns(14).DisplayIndex = 6


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        actualizar_pendientes()
    End Sub
End Class

