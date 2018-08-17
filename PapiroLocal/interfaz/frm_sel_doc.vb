Imports System.Globalization
Public Class frm_sel_doc

    Dim nue_cur As New clases.guia_despacho
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).HeaderText = "Cliente"
        dgv_curso.Columns(1).HeaderText = "Número de Pedido"
        dgv_curso.Columns(2).HeaderText = "Fecha Venta"
        dgv_curso.Columns(2).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_curso.Columns(3).HeaderText = "Fecha Pedido"
        dgv_curso.Columns(4).HeaderText = "Hora Pedido"
        dgv_curso.Columns(5).HeaderText = "Cantidad"
        dgv_curso.Columns(6).HeaderText = "Código Producto"
        dgv_curso.Columns(7).HeaderText = "Descripción"
        dgv_curso.Columns(8).HeaderText = "Venta Neta"
        dgv_curso.Columns(9).HeaderText = "IVA"
        dgv_curso.Columns(10).HeaderText = "Venta Total"
        dgv_curso.Columns(11).Visible = False
        dgv_curso.Columns(12).Visible = False
        dgv_curso.Columns(7).Width = 400
        dgv_curso.Columns(0).Width = 300


    End Sub
    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        actualizar_clientes()
        txt_fecha.Enabled = False
        txt_hora.Enabled = False
        Timer1.Enabled = True
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

    Private Sub cmb_pedido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_pedido.TextChanged
        actualizar_dgv_despachos()

    End Sub
    Sub actualizar_dgv_despachos()
        dgv_guia_despacho.DataSource = nue_cur.listar4(cmb_cliente.Text, cmb_pedido.Text)
        dgv_guia_despacho.Columns(0).Visible = False
        dgv_guia_despacho.Columns(1).Visible = False
        dgv_guia_despacho.Columns(2).HeaderText = "Fecha Venta"
        dgv_guia_despacho.Columns(3).HeaderText = "Fecha Pedido"
        dgv_guia_despacho.Columns(4).HeaderText = "Hora Pedido"
        dgv_guia_despacho.Columns(5).HeaderText = "Cantidad"
        dgv_guia_despacho.Columns(6).HeaderText = "Código Producto"
        dgv_guia_despacho.Columns(7).HeaderText = "Descripción"
        dgv_guia_despacho.Columns(8).HeaderText = "Venta Neta"
        dgv_guia_despacho.Columns(9).HeaderText = "IVA"
        dgv_guia_despacho.Columns(10).HeaderText = "Venta Total"
        dgv_guia_despacho.Columns(11).Visible = False
        dgv_guia_despacho.Columns(12).Visible = False
        dgv_guia_despacho.Columns(7).Width = 200



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero_pedido As Double
        Dim cliente, indicador_despacho As String

        If (cmb_cliente.Text <> "" And cmb_pedido.Text <> "") Then

            cliente = cmb_cliente.Text
            numero_pedido = cmb_pedido.Text
            indicador_despacho = "Despachado"
            nue_cur.insertar(cliente, numero_pedido, indicador_despacho, CDate(txt_fecha.Text), CDate(txt_hora.Text))
            actualizar_dgv()
            actualizar_dgv_despachos()
            MessageBox.Show("GUÍA DE DESPACHO EMITIDA")
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (cmb_cliente.Text <> "" And cmb_pedido.Text <> "") Then
            CR_guia_de_despacho.Show()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizar_dgv()
        actualizar_clientes()
    End Sub

    Private Sub txt_fecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fecha.TextChanged

    End Sub
End Class