Imports System.Globalization
Public Class Frm_clientes_busqueda_cobranza_doc

    Dim nue_report As New clases.ventas_clientes
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizar_dgv()
    End Sub
    Sub actualizar_dgv()
        dgv_clientes.DataSource = nue_report.listar5(txt_documento.Text)
        dgv_clientes.Columns(0).Visible = False
        dgv_clientes.Columns(3).HeaderText = "Banco"
        dgv_clientes.Columns(4).HeaderText = "Serie"
        dgv_clientes.Columns(5).HeaderText = "Factura"
        dgv_clientes.Columns(6).HeaderText = "Monto"
        dgv_clientes.Columns(9).HeaderText = "Fecha Cheque"
        dgv_clientes.Columns(12).HeaderText = "Cliente"
        dgv_clientes.Columns(13).HeaderText = "RUT"

        dgv_clientes.Columns(1).Visible = False
        dgv_clientes.Columns(2).Visible = False
        dgv_clientes.Columns(7).Visible = False
        dgv_clientes.Columns(8).Visible = False
        dgv_clientes.Columns(10).Visible = False
        dgv_clientes.Columns(11).Visible = False

        ' Fromatos celdas
        dgv_clientes.Columns(5).DefaultCellStyle.Format = "###,###,###"
        dgv_clientes.Columns(6).DefaultCellStyle.Format = "###,###,###"

        ' Dimensión celdas
        dgv_clientes.Columns(3).Width = 100
        dgv_clientes.Columns(4).Width = 70
        dgv_clientes.Columns(5).Width = 70
        dgv_clientes.Columns(6).Width = 70
        dgv_clientes.Columns(9).Width = 70
        dgv_clientes.Columns(12).Width = 250
        dgv_clientes.Columns(13).Width = 70
        
        dgv_clientes.AllowUserToOrderColumns = True
    End Sub

    Private Sub dgv_clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_clientes.DoubleClick
        If (IsDBNull(dgv_clientes.CurrentRow.Cells(2).Value.ToString())) Then
        Else
            frm_consultaCheque.txt_nombre.Text = dgv_clientes.CurrentRow.Cells(12).Value.ToString()
            frm_consultaCheque.txt_rut.Text = dgv_clientes.CurrentRow.Cells(13).Value.ToString()
            frm_consultaCheque.actualiza_cheques()
            frm_consultaCheque.txt_numeroCheque.Text = dgv_clientes.CurrentRow.Cells(4).Value.ToString()
            Me.Close()
        End If
    End Sub


End Class