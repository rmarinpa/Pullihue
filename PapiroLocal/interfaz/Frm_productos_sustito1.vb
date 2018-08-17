Imports System.Globalization
Public Class Frm_productos_sustito1

    Dim nue_report As New clases.consulta_productos
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
        dgv_clientes.DataSource = nue_report.listar8(txt_cliente.Text, cmb_marca.Text, cmb_medidas.Text)
        dgv_clientes.Columns(0).Visible = False
        dgv_clientes.Columns(1).HeaderText = "Código"
        dgv_clientes.Columns(2).HeaderText = "Marca"
        dgv_clientes.Columns(3).HeaderText = "Descripcion"
        dgv_clientes.Columns(4).HeaderText = "Tipo 1"
        dgv_clientes.Columns(5).HeaderText = "Medidas"
        dgv_clientes.Columns(6).HeaderText = "Unidad por Paquete"
        dgv_clientes.Columns(3).Width = 400
        dgv_clientes.Columns(5).Width = 200
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
        dgv_clientes.Columns(21).HeaderText = "Precio Lista"
        dgv_clientes.Columns(22).Visible = False
        dgv_clientes.AllowUserToOrderColumns = True
    End Sub

    Private Sub dgv_clientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick

    End Sub

    Private Sub dgv_clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_clientes.DoubleClick
        Frm_Sustitutos.txt_codigo1.Clear()
        Frm_Sustitutos.txt_descripcion1.Clear()
        Frm_Sustitutos.txt_codigo1.Text = dgv_clientes.CurrentRow.Cells(1).Value.ToString()
        Frm_Sustitutos.txt_descripcion1.Text = dgv_clientes.CurrentRow.Cells(3).Value.ToString()
        Me.Close()
    End Sub
    Public Sub actualizar_marca()
        cmb_marca.DataSource = nue_report.listar6()
        cmb_marca.DisplayMember = "Marca"
        cmb_marca.ValueMember = "Marca"
    End Sub

    Private Sub cmb_marca_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_marca.MouseClick
        actualizar_marca()
    End Sub

    Public Sub actualizar_medidas()
        cmb_medidas.DataSource = nue_report.listar7()
        cmb_medidas.DisplayMember = "medidas"
        cmb_medidas.ValueMember = "medidas"
    End Sub

    Private Sub cmb_medidas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_medidas.MouseClick
        actualizar_medidas()
    End Sub

    Private Sub cmb_medidas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_medidas.SelectedIndexChanged

    End Sub
End Class