Imports System.Globalization
Public Class Frm_clientes_busqueda_agenda

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
        dgv_clientes.DataSource = nue_report.listar3(txt_cliente.Text)
        dgv_clientes.Columns(0).Visible = False
        dgv_clientes.Columns(1).HeaderText = "RUT"
        dgv_clientes.Columns(2).HeaderText = "Cliente"
        dgv_clientes.Columns(3).HeaderText = "Dirección"
        dgv_clientes.Columns(4).HeaderText = "Comuna"
        dgv_clientes.Columns(5).Visible = False
        dgv_clientes.Columns(6).Visible = False
        dgv_clientes.Columns(1).Width = 70
        dgv_clientes.Columns(2).Width = 250
        dgv_clientes.Columns(3).Width = 200
        dgv_clientes.Columns(4).Width = 100
        dgv_clientes.Columns(6).Width = 200
        dgv_clientes.Columns(7).Visible = False
        dgv_clientes.Columns(8).Visible = False
        dgv_clientes.Columns(9).Visible = False
        dgv_clientes.Columns(10).Visible = False
        dgv_clientes.Columns(11).Visible = False
        dgv_clientes.Columns(12).Visible = False
        dgv_clientes.Columns(13).Visible = False
        dgv_clientes.Columns(14).Visible = False
        dgv_clientes.Columns(15).Visible = False
        dgv_clientes.Columns(16).Visible = False
        dgv_clientes.Columns(17).Visible = False
        dgv_clientes.Columns(18).Visible = False
        dgv_clientes.Columns(19).Visible = False
        dgv_clientes.Columns(20).Visible = False
        dgv_clientes.Columns(21).Visible = False
        dgv_clientes.Columns(22).Visible = False
        dgv_clientes.Columns(23).Visible = False
        dgv_clientes.Columns(24).Visible = False
        dgv_clientes.Columns(25).Visible = False
        dgv_clientes.Columns(26).Visible = False
        dgv_clientes.Columns(27).Visible = False
        dgv_clientes.Columns(28).Visible = False
        dgv_clientes.Columns(29).Visible = False
        dgv_clientes.Columns(30).Visible = False
        dgv_clientes.Columns(31).Visible = False
        dgv_clientes.Columns(32).Visible = False
        dgv_clientes.Columns(33).Visible = False
        dgv_clientes.Columns(34).Visible = False
        dgv_clientes.Columns(35).Visible = False
        dgv_clientes.Columns(36).Visible = False
        dgv_clientes.Columns(37).Visible = False
        dgv_clientes.Columns(38).Visible = False
        dgv_clientes.Columns(39).Visible = False
        dgv_clientes.Columns(40).Visible = False
        dgv_clientes.Columns(41).Visible = False
        dgv_clientes.Columns(42).Visible = False
        dgv_clientes.AllowUserToOrderColumns = True
    End Sub

    Private Sub dgv_clientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick

    End Sub

    Private Sub dgv_clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_clientes.DoubleClick
        If (IsDBNull(dgv_clientes.CurrentRow.Cells(2).Value.ToString())) Then
        Else
            frm_programar_agenda.txt_cliente.Text = dgv_clientes.CurrentRow.Cells(2).Value.ToString()
            Me.Close()
        End If
    End Sub

    Sub actualizar_dgv2()
        dgv_clientes.DataSource = nue_report.listar4(txt_rut.Text)
        dgv_clientes.Columns(0).Visible = False
        dgv_clientes.Columns(1).HeaderText = "Rut"
        dgv_clientes.Columns(2).HeaderText = "Cliente"
        dgv_clientes.Columns(3).HeaderText = "Dirección"
        dgv_clientes.Columns(4).HeaderText = "Comuna"
        dgv_clientes.Columns(5).HeaderText = "Telefonos"
        dgv_clientes.Columns(6).HeaderText = "Contacto Comercial"
        dgv_clientes.Columns(2).Width = 300
        dgv_clientes.Columns(3).Width = 200
        dgv_clientes.Columns(4).Width = 200
        dgv_clientes.Columns(6).Width = 200
        dgv_clientes.Columns(7).Visible = False
        dgv_clientes.Columns(8).Visible = False
        dgv_clientes.Columns(9).Visible = False
        dgv_clientes.Columns(10).Visible = False
        dgv_clientes.Columns(11).Visible = False
        dgv_clientes.Columns(12).Visible = False
        dgv_clientes.Columns(13).Visible = False
        dgv_clientes.Columns(14).Visible = False
        dgv_clientes.Columns(15).Visible = False
        dgv_clientes.Columns(16).Visible = False
        dgv_clientes.Columns(17).Visible = False
        dgv_clientes.Columns(18).Visible = False
        dgv_clientes.Columns(19).Visible = False
        dgv_clientes.Columns(20).Visible = False
        dgv_clientes.Columns(21).Visible = False
        dgv_clientes.Columns(22).Visible = False
        dgv_clientes.Columns(23).Visible = False
        dgv_clientes.Columns(24).Visible = False
        dgv_clientes.Columns(25).Visible = False
        dgv_clientes.Columns(26).Visible = False
        dgv_clientes.Columns(27).Visible = False
        dgv_clientes.Columns(28).Visible = False
        dgv_clientes.Columns(29).Visible = False
        dgv_clientes.Columns(30).Visible = False
        dgv_clientes.Columns(31).Visible = False
        dgv_clientes.Columns(32).Visible = False
        dgv_clientes.Columns(33).Visible = False
        dgv_clientes.Columns(34).Visible = False
        dgv_clientes.Columns(35).Visible = False
        dgv_clientes.Columns(36).Visible = False
        dgv_clientes.Columns(37).Visible = False
        dgv_clientes.Columns(38).Visible = False
        dgv_clientes.Columns(39).Visible = False
        dgv_clientes.Columns(40).Visible = False
        dgv_clientes.Columns(41).Visible = False
        dgv_clientes.Columns(42).Visible = False
        dgv_clientes.AllowUserToOrderColumns = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv2()
    End Sub

    Private Sub txt_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cliente.TextChanged
        ' If Len(txt_cliente.Text) > 2 Then
        '  actualizar_dgv()
        '   Else

        '  End If
    End Sub



End Class