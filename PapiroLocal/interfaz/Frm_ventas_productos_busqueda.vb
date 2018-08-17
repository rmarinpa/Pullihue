Imports System.Globalization
Public Class Frm_ventas_productos_busqueda

    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_nombre.Select()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
        txt_codigo.Select()
        'actualizar_categorias_1()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar_dgv()
    End Sub
    Sub actualizar_dgv()
        dgv_clientes.DataSource = nue_report.listar8(txt_cliente.Text, txt_categoria2.Text)
        dgv_clientes.Columns(0).Visible = False
        dgv_clientes.Columns(1).Visible = False
        dgv_clientes.Columns(2).Visible = False
        dgv_clientes.Columns(3).HeaderText = "Descripción"
        dgv_clientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(4).Visible = False
        dgv_clientes.Columns(5).Visible = False
        dgv_clientes.Columns(6).Visible = False
        dgv_clientes.Columns(3).Width = 250
        dgv_clientes.Columns(5).Width = 60
        dgv_clientes.Columns(21).Width = 60
        dgv_clientes.Columns(7).Width = 60
        dgv_clientes.Columns(8).Width = 60
        dgv_clientes.Columns(19).Width = 60
        dgv_clientes.Columns(7).HeaderText = "Ancho"
        dgv_clientes.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(8).HeaderText = "Largo"
        dgv_clientes.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
        dgv_clientes.Columns(19).HeaderText = "Stock"
        dgv_clientes.Columns(20).Visible = False
        dgv_clientes.Columns(21).Visible = False
        dgv_clientes.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(22).Visible = False
        dgv_clientes.Columns(23).HeaderText = "Precio Máximo"
        dgv_clientes.Columns(24).HeaderText = "Precio Mínimo"
        dgv_clientes.Columns(25).Visible = False
        dgv_clientes.Columns(26).Visible = False
        dgv_clientes.Columns(27).Visible = False
        dgv_clientes.AllowUserToOrderColumns = True
        dgv_clientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(21).DefaultCellStyle.Format = "##,###."
        dgv_clientes.Columns(23).DefaultCellStyle.Format = "##,###."
        dgv_clientes.Columns(24).DefaultCellStyle.Format = "##,###."
        dgv_clientes.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Private Sub dgv_clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_clientes.DoubleClick
        Frm_ventas.cmb_codigo.Clear()
        Frm_ventas.txt_descripcion.Clear()
        Frm_ventas.txt_area_calculada.Clear()
        Frm_ventas.txt_area_negocio.Clear()
        Frm_ventas.txt_familia1.Clear()
        Frm_ventas.txt_familia2.Clear()
        Frm_ventas.txt_familia3.Clear()
        Frm_ventas.txt_precio_lista.Clear()
        Frm_ventas.txt_proveedor.Clear()
        Frm_ventas.txt_precio_lista.Clear()
        Frm_ventas.txt_cantidad.Text = 0
        Frm_ventas.txt_descuento.Text = 0
        Frm_ventas_mod.cmb_codigo.Text = dgv_clientes.CurrentRow.Cells(1).Value.ToString()
        Frm_ventas_mod.txt_descripcion.Text = dgv_clientes.CurrentRow.Cells(3).Value.ToString()
        Frm_ventas_mod.txt_area_calculada.Text = dgv_clientes.CurrentRow.Cells(9).Value.ToString()
        Frm_ventas_mod.txt_area_negocio.Text = dgv_clientes.CurrentRow.Cells(11).Value.ToString()
        Frm_ventas_mod.txt_familia1.Text = dgv_clientes.CurrentRow.Cells(16).Value.ToString()
        Frm_ventas_mod.txt_familia2.Text = dgv_clientes.CurrentRow.Cells(17).Value.ToString()
        Frm_ventas_mod.txt_familia3.Text = dgv_clientes.CurrentRow.Cells(18).Value.ToString()
        Frm_ventas_mod.txt_precio_lista.Text = dgv_clientes.CurrentRow.Cells(21).Value.ToString()
        Frm_ventas_mod.txt_proveedor.Text = dgv_clientes.CurrentRow.Cells(2).Value.ToString()
        Frm_ventas_mod.txt_medidas.Text = dgv_clientes.CurrentRow.Cells(5).Value.ToString()
        Frm_ventas_mod.txt_ult_venta.Text = Frm_ventas_mod.txt_precio_lista.Text / Frm_ventas_mod.txt_area_calculada.Text
        Frm_ventas_mod.txt_precio_min.Text = dgv_clientes.CurrentRow.Cells(24).Value.ToString()
        Frm_ventas_mod.txt_precio_max.Text = dgv_clientes.CurrentRow.Cells(23).Value.ToString()
        Frm_ventas_mod.txt_ancho.Text = dgv_clientes.CurrentRow.Cells(7).Value.ToString()
        Frm_ventas_mod.txt_largo.Text = dgv_clientes.CurrentRow.Cells(8).Value.ToString()
        Frm_ventas_mod.txt_tipo1.Text = dgv_clientes.CurrentRow.Cells(4).Value.ToString()

        If nue_report.descripcion_precio(Frm_ventas_mod.cmb_cliente.Text, Frm_ventas_mod.cmb_codigo.Text) <> "" Then
            Frm_ventas_mod.txt_venta_m2.Text = nue_report.descripcion_precio(Frm_ventas_mod.cmb_cliente.Text, Frm_ventas_mod.cmb_codigo.Text)
            If Frm_ventas_mod.txt_venta_m2.Text <> "" Then
                Frm_ventas_mod.txt_venta_m2.Text = CDbl(Frm_ventas_mod.txt_venta_m2.Text)
            Else
            End If
        Else
            Frm_ventas_mod.txt_venta_m2.Text = dgv_clientes.CurrentRow.Cells(23).Value.ToString()
            If Frm_ventas_mod.txt_venta_m2.Text <> "" Then
                Frm_ventas_mod.txt_venta_m2.Text = CDbl(Frm_ventas_mod.txt_venta_m2.Text)
            Else
            End If
        End If
        Me.Close()
    End Sub
    Public Sub actualizar_medidas()
        cmb_medidas.DataSource = nue_report.listar7(txt_cliente.Text)
        cmb_medidas.DisplayMember = "ancho"
        cmb_medidas.ValueMember = "ancho"
    End Sub

    Public Sub actualizar_categorias()
        'txt_categoria2.DataSource = nue_report.listar13(txt_cliente.Text)
        'txt_categoria2.DisplayMember = "Categoria2"
        'txt_categoria2.ValueMember = "Categoria2"
        txt_categoria2.DataSource = nue_report.listar13(txt_cliente.Text)
        txt_categoria2.DisplayMember = "familia_2"
        txt_categoria2.ValueMember = "familia_2"
    End Sub
    Public Sub actualizar_categorias_1()
        txt_categoria2.DataSource = nue_report.listar21()
        txt_categoria2.DisplayMember = "familia"
        txt_categoria2.ValueMember = "familia"
    End Sub
    Private Sub txt_cliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cliente.TextChanged
        cmb_medidas.Text = ""
        cmb_medidas2.Text = ""
        txt_categoria2.Text = ""
        actualizar_categorias()
        'actualizar_dgv()
    End Sub
    Public Sub actualizar_medidas2()
        cmb_medidas2.DataSource = nue_report.listar9(txt_cliente.Text, cmb_medidas.Text)
        cmb_medidas2.DisplayMember = "largo"
        cmb_medidas2.ValueMember = "largo"
    End Sub

    Private Sub cmb_medidas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_medidas.MouseClick
        cmb_medidas2.Text = ""
        actualizar_medidas()
        cmb_medidas.Text = ""
    End Sub

    Private Sub cmb_medidas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_medidas.SelectedIndexChanged

    End Sub

    Private Sub cmb_medidas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_medidas.TextChanged
        actualizar_dgv()
    End Sub

    Private Sub cmb_medidas2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_medidas2.MouseClick
        actualizar_medidas2()
        cmb_medidas2.Text = ""
    End Sub

    Private Sub cmb_medidas2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_medidas2.TextChanged
        actualizar_dgv()
    End Sub

    Private Sub txt_categoria2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_categoria2.TextChanged
        actualizar_dgv()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        ' If Len(txt_nombre.Text) = 0 Or Len(txt_nombre.Text) > 2 Then
        'actualizar_dgv2()
        '  Else

        ' End If

    End Sub
    Sub actualizar_dgv2()
        dgv_clientes.DataSource = nue_report.listar14(txt_codigo.Text, txt_nombre.Text)
        dgv_clientes.Columns(0).Visible = False
        dgv_clientes.Columns(1).HeaderText = "Código"
        dgv_clientes.Columns(2).Visible = False
        dgv_clientes.Columns(3).HeaderText = "Descripción"
        dgv_clientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(4).Visible = False
        dgv_clientes.Columns(5).Visible = False
        dgv_clientes.Columns(6).Visible = False
        dgv_clientes.Columns(3).Width = 250
        dgv_clientes.Columns(5).Width = 60
        dgv_clientes.Columns(21).Width = 60
        dgv_clientes.Columns(7).Width = 60
        dgv_clientes.Columns(8).Width = 60
        dgv_clientes.Columns(19).Width = 60
        dgv_clientes.Columns(7).HeaderText = "Ancho"
        dgv_clientes.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(8).HeaderText = "Largo"
        dgv_clientes.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
        dgv_clientes.Columns(19).HeaderText = "Stock"
        dgv_clientes.Columns(20).Visible = False
        dgv_clientes.Columns(21).Visible = False
        dgv_clientes.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(22).Visible = False
        dgv_clientes.Columns(23).HeaderText = "Precio Máximo"
        dgv_clientes.Columns(24).HeaderText = "Precio Mínimo"
        dgv_clientes.Columns(25).Visible = False
        dgv_clientes.Columns(26).Visible = False
        dgv_clientes.Columns(27).Visible = False
        dgv_clientes.AllowUserToOrderColumns = True
        dgv_clientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(21).DefaultCellStyle.Format = "##,###."
        dgv_clientes.Columns(23).DefaultCellStyle.Format = "##,###."
        dgv_clientes.Columns(24).DefaultCellStyle.Format = "##,###."
        dgv_clientes.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_clientes.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv2()
    End Sub
End Class