Imports System.Globalization
Public Class Frm_compras

    Dim nue_report As New clases.Compras
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet_Compras.DataTable' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'Const113_PapiroDataSet4.DataTable' Puede moverla o quitarla según sea necesario.

        Me.WindowState = FormWindowState.Maximized
        txt_nombre_ejecutivo.Text = Nombre_Obra
        txt_nombre_ejecutivo.ReadOnly = True
        Timer1.Enabled = True
        txt_folio_compra.Text = 1
        txt_folio_compra.Enabled = False
        txt_codigo.ReadOnly = True
        txt_descripcion.ReadOnly = True
        txt_ancho.ReadOnly = True
        txt_largo.ReadOnly = True
        txt_items.ReadOnly = True
        txt_stock.ReadOnly = True
        lbl_pai.Visible = False
        lbl_cn.Visible = False
        txt_pai.Visible = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Sub actualizar_dgv_compras()
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
    End Sub
    Public Sub actualizar_categorias()
        txt_categoria2.DataSource = nue_report.listar13(txt_cliente.Text)
        txt_categoria2.DisplayMember = "Categoria2"
        txt_categoria2.ValueMember = "Categoria2"
    End Sub
    Private Sub txt_cliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cliente.TextChanged
        cmb_medidas.Text = ""
        cmb_medidas2.Text = ""
        txt_categoria2.Text = ""
        actualizar_categorias()
        actualizar_dgv_compras()
    End Sub
    Private Sub txt_categoria2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_categoria2.TextChanged
        actualizar_dgv_compras()
    End Sub
    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        If Len(txt_nombre.Text) = 0 Or Len(txt_nombre.Text) > 2 Then
            actualizar_dgv2()
        Else

        End If

    End Sub
    Sub actualizar_dgv2()
        dgv_clientes.DataSource = nue_report.listar14(txt_nombre.Text)
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

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Me.txt_fecha_act.Text = Today
    '    Me.txt_hora.Text = TimeOfDay
    'End Sub
    Sub actualizar_dgv_compra()
        dgv_compra.DataSource = nue_report.listar(txt_folio_compra.Text)
        dgv_compra.AllowUserToOrderColumns = True
        dgv_compra.Columns(0).Visible = False
        dgv_compra.Columns(1).Visible = False
        dgv_compra.Columns(1).Visible = False
        dgv_compra.Columns(2).HeaderText = "Código"
        dgv_compra.Columns(3).HeaderText = "Ancho"
        dgv_compra.Columns(4).HeaderText = "Largo"
        dgv_compra.Columns(5).HeaderText = "Cant."
        dgv_compra.Columns(6).HeaderText = "Descripción"
        dgv_compra.Columns(7).HeaderText = "ETA"
        dgv_compra.Columns(8).HeaderText = "Fecha de Ingreso Bodega"
        dgv_compra.Columns(9).HeaderText = "obs"
        dgv_compra.Columns(10).Visible = False
        dgv_compra.Columns(11).Visible = False
        dgv_compra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_compra.Columns(2).Width = 100
        dgv_compra.Columns(3).Width = 40
        dgv_compra.Columns(4).Width = 40
        dgv_compra.Columns(5).Width = 40
        dgv_compra.Columns(6).Width = 180
        dgv_compra.Columns(7).Width = 40
        dgv_compra.Columns(8).Width = 70
        dgv_compra.Columns(9).Width = 50

        dgv_compra.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PAI, Codigo, Descripcion, ETA, obs As String
        Dim fecha_ingreso As Date
        Dim folio_compra, Cantidad, ancho, largo, pai_cn As Double

        If (cmb_PAI.Text <> "" And txt_codigo.Text <> "" And txt_descripcion.Text <> "" And cmb_cantidad.Text <> "" And txt_pai.Text <> "") Then

            If nue_report.descripcion_numero_folio2(CDbl(txt_folio_compra.Text), cmb_cliente.Text) = txt_folio_compra.Text Then
                txt_folio_compra.Visible = True
                lbl_folio_compra.Visible = True
            Else
                txt_folio_compra.Text = nue_report.descripcion_numero_folio() + 1
                nue_report.insertar3(CDbl(txt_folio_compra.Text), 0, cmb_cliente.Text)
                txt_folio_compra.Visible = True
                lbl_folio_compra.Visible = True
            End If

            PAI = cmb_PAI.Text
            Codigo = txt_codigo.Text
            Descripcion = txt_descripcion.Text
            Cantidad = cmb_cantidad.Text
            ETA = ""
            fecha_ingreso = txt_fecha_act.Text
            obs = txt_nombre_ejecutivo.Text
            folio_compra = txt_folio_compra.Text
            ancho = txt_ancho.Text
            largo = txt_largo.Text
            pai_cn = txt_pai.Text
            nue_report.insertar(PAI, Codigo, ancho, largo, Cantidad, Descripcion, ETA, fecha_ingreso, obs, folio_compra, pai_cn)
            actualizar_dgv_compra()
            txt_items.Text = nue_report.descripcion_items(txt_folio_compra.Text)
            limpiar()

        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
    Sub limpiar()
        txt_codigo.Clear()
        txt_descripcion.Clear()
        txt_ancho.Clear()
        txt_largo.Clear()
        cmb_cantidad.Text = ""
        txt_stock.Clear()

    End Sub

    Private Sub cmb_PAI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PAI.SelectedIndexChanged

    End Sub

    Private Sub cmb_PAI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PAI.TextChanged
        If cmb_PAI.Text = "Importación" Then
            lbl_pai.Visible = True
            lbl_cn.Visible = False
            txt_pai.Visible = True
        ElseIf cmb_PAI.Text = "Compra Nacional" Then
            lbl_cn.Visible = True
            lbl_pai.Visible = False
            txt_pai.Visible = True
        Else
            lbl_pai.Visible = False
            lbl_cn.Visible = False
            txt_pai.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nue_report.insertar4(txt_folio_compra.Text, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), txt_nombre_ejecutivo.Text, txt_pai.Text)
        Dim i As Integer
        Dim id As Integer
        Dim stck As Double
        If dgv_compra.Rows.Count > 0 Then
            For i = 0 To dgv_compra.Rows.Count - 1

                id = nue_report.Seleccionar_id(dgv_compra.Rows(i).Cells(2).Value.ToString())
                stck = dgv_compra.Rows(i).Cells(5).Value.ToString() + nue_report.Seleccionar_stock(dgv_compra.Rows(i).Cells(2).Value.ToString())
                nue_report.modificar(CInt(id), stck)
            Next (i)
        End If
        MessageBox.Show("COMPRA GENERADA")
        CR_Compra.Show()
        limpiar()
        txt_folio_compra.Text = 1
        txt_items.Clear()
        cmb_PAI.Text = ""
        txt_pai.Clear()
        txt_cliente.Text = ""
        txt_categoria2.Text = ""
        txt_nombre.Clear()
        dgv_compra.DataSource = Nothing
        dgv_clientes.DataSource = Nothing

    End Sub

    Private Sub dgv_compra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_compra.DoubleClick
        Cod_Mov_Tierra = dgv_compra.CurrentRow.Cells(0).Value.ToString()
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Mov_Tierra))
                actualizar_dgv_compra()

            Else

            End If
        End If
    End Sub
    Private Sub dgv_compra_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_compra.MouseDoubleClick

    End Sub

    Private Sub dgv_clientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick

    End Sub

    Private Sub dgv_clientes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_clientes.MouseDoubleClick
        If (cmb_PAI.Text = "Ajuste") Then
            datos_compra.Show()
        Else
            txt_codigo.Text = dgv_clientes.CurrentRow.Cells(1).Value.ToString()
            txt_descripcion.Text = dgv_clientes.CurrentRow.Cells(3).Value.ToString()
            txt_ancho.Text = dgv_clientes.CurrentRow.Cells(7).Value.ToString()
            txt_largo.Text = dgv_clientes.CurrentRow.Cells(8).Value.ToString()
            txt_stock.Text = dgv_clientes.CurrentRow.Cells(19).Value.ToString()
        End If
    End Sub

    Private Sub dgv_compra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_compra.CellContentClick

    End Sub
End Class