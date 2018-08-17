Imports System.Globalization
Public Class Frm_despacho2

    Dim nue_cur As New clases.guia_despacho
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        actualizar_dgv()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Sub actualizar_dgv()
        dgv_despachos.DataSource = nue_cur.listar6()
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(2).Visible = False
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        Dim numero_folio As Double
        numero_folio = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        dgv_despachos2.DataSource = nue_cur.listar7(numero_folio)
        dgv_despachos2.Columns(0).Visible = False
        dgv_despachos2.AllowUserToOrderColumns = True
        dgv_despachos2.Columns(1).Visible = False
        dgv_despachos2.Columns(1).Width = 200
        dgv_despachos2.Columns(2).Visible = False
        dgv_despachos2.Columns(3).Visible = False
        dgv_despachos2.Columns(4).Visible = False
        dgv_despachos2.Columns(5).Visible = False
        dgv_despachos2.Columns(6).Visible = False
        dgv_despachos2.Columns(7).Visible = False
        dgv_despachos2.Columns(8).Visible = False
        dgv_despachos2.Columns(9).Visible = False
        dgv_despachos2.Columns(10).HeaderText = "Medidas"
        dgv_despachos2.Columns(11).Visible = False
        dgv_despachos2.Columns(12).Visible = False
        dgv_despachos2.Columns(13).HeaderText = "Descripción"
        dgv_despachos2.Columns(13).Width = 210
        dgv_despachos2.Columns(14).HeaderText = "Área Un."
        dgv_despachos2.Columns(14).DefaultCellStyle.Format = "##,###.##"
        dgv_despachos2.Columns(15).HeaderText = "Cantidad"
        dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(16).Visible = False
        dgv_despachos2.Columns(17).Visible = False
        dgv_despachos2.Columns(18).HeaderText = "Precio M2"
        dgv_despachos2.Columns(18).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(19).HeaderText = "Venta"
        dgv_despachos2.Columns(19).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(20).Visible = False
        dgv_despachos2.Columns(21).Visible = False
        dgv_despachos2.Columns(22).Visible = False
        dgv_despachos2.Columns(23).Visible = False
        dgv_despachos2.Columns(24).Visible = False
        dgv_despachos2.Columns(25).Visible = False
        dgv_despachos2.Columns(26).Visible = False
        dgv_despachos2.Columns(27).Visible = False
        dgv_despachos2.Columns(27).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(28).HeaderText = "Precio Un."
        dgv_despachos2.Columns(28).DefaultCellStyle.Format = "##,###."
        dgv_despachos2.Columns(31).HeaderText = "Fecha"
        dgv_despachos2.Columns(30).Visible = False
        dgv_despachos2.Columns(29).Visible = False
        dgv_despachos2.Columns(32).Visible = False
        dgv_despachos2.Columns(33).Visible = False
        dgv_despachos2.Columns(34).HeaderText = "N° Folio"
        dgv_despachos2.Columns(34).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos2.Columns(31).DisplayIndex = 1
        dgv_despachos2.Columns(13).DisplayIndex = 2
        dgv_despachos2.Columns(10).DisplayIndex = 3
        dgv_despachos2.Columns(15).DisplayIndex = 4
        dgv_despachos2.Columns(18).DisplayIndex = 5
        dgv_despachos2.Columns(14).DisplayIndex = 6
        dgv_despachos2.Columns(28).DisplayIndex = 7
        dgv_despachos2.Columns(19).DisplayIndex = 8
        dgv_despachos2.Columns(30).DisplayIndex = 9
        dgv_despachos2.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos2.Columns(30).Width = 50
        dgv_despachos2.Columns(34).Width = 50
        dgv_despachos2.Columns(10).Width = 60
        dgv_despachos2.Columns(15).Width = 50
        dgv_despachos2.Columns(28).Width = 60
        dgv_despachos2.Columns(31).Width = 65
        dgv_despachos2.Columns(18).Width = 60
        dgv_despachos2.Columns(19).Width = 60
        dgv_despachos2.Columns(14).Width = 40
        dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Private Sub dgv_despachos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellContentDoubleClick

    End Sub

    Private Sub dgv_despachos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellContentClick

    End Sub

    Private Sub dgv_despachos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellDoubleClick

    End Sub
End Class

