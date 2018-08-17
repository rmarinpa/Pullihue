Imports System.Globalization
Public Class frm_prod_despachados

    Dim nue_cur As New clases.prod_despachados
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub actualizar_dgv()
        dgv_curso1.DataSource = nue_cur.listar()
        dgv_curso1.Columns(0).HeaderText = "Cliente"
        dgv_curso1.Columns(1).HeaderText = "Número de Pedido"
        dgv_curso1.Columns(2).HeaderText = "Fecha de Despacho"
        dgv_curso1.Columns(2).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_curso1.Columns(3).HeaderText = "Hora de Despacho"
        dgv_curso1.Columns(4).HeaderText = "Fecha de Pedido"
        dgv_curso1.Columns(4).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_curso1.Columns(5).HeaderText = "Hora de Pedido"
        dgv_curso1.Columns(6).HeaderText = "Cantidad"
        dgv_curso1.Columns(7).HeaderText = "Código Producto"
        dgv_curso1.Columns(8).HeaderText = "Descripción"
        dgv_curso1.Columns(9).HeaderText = "Venta Neta"
        dgv_curso1.Columns(10).HeaderText = "IVA"
        dgv_curso1.Columns(11).HeaderText = "Venta Total"
        dgv_curso1.Columns(8).Width = 400
        dgv_curso1.Columns(0).Width = 300


    End Sub
    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_clientes()
        actualizar_dgv()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Public Sub actualizar_clientes()
        cmb_cliente.DataSource = nue_cur.listar2()
        cmb_cliente.DisplayMember = "cliente"
        cmb_cliente.ValueMember = "cliente"
    End Sub

    Private Sub cmb_cliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_cliente.TextChanged
        cmb_pedido.DataSource = nue_cur.listar3(cmb_cliente.Text)
        cmb_pedido.DisplayMember = "numero_pedido"
        cmb_pedido.ValueMember = "numero_pedido"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cmb_cliente.Text <> "" And cmb_pedido.Text <> "") Then
            CR_guia_de_despacho2.Show()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        actualizar_dgv()
        actualizar_clientes()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CR_guia_de_despacho2.Show()
    End Sub
End Class