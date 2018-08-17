Imports System.Globalization
Public Class Frm_despacho

    Dim nue_cur As New clases.guia_despacho
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar()
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Cliente"
        dgv_curso.Columns(2).HeaderText = "N° de Ped."
        dgv_curso.Columns(3).Visible = False
        dgv_curso.Columns(3).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_curso.Columns(4).HeaderText = "Fecha Pedido"
        dgv_curso.Columns(5).HeaderText = "Hora Pedido"
        dgv_curso.Columns(6).HeaderText = "Cant."
        dgv_curso.Columns(7).HeaderText = "Código Producto"
        dgv_curso.Columns(8).HeaderText = "Descripción"
        dgv_curso.Columns(9).Visible = False
        dgv_curso.Columns(10).Visible = False
        dgv_curso.Columns(11).Visible = False
        dgv_curso.Columns(12).Visible = False
        dgv_curso.Columns(13).Visible = False
        dgv_curso.Columns(3).Width = 70
        dgv_curso.Columns(4).Width = 65
        dgv_curso.Columns(8).Width = 210
        dgv_curso.Columns(1).Width = 200
        dgv_curso.Columns(2).Width = 30
        dgv_curso.Columns(5).Width = 50
        dgv_curso.Columns(6).Width = 33
        dgv_curso.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Public Sub actualizar_clientes()
        cmb_cliente.DataSource = nue_cur.listar2()
        cmb_cliente.DisplayMember = "cliente"
        cmb_cliente.ValueMember = "cliente"
    End Sub

    Private Sub cmb_cliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        cmb_pedido.DataSource = nue_cur.listar3(cmb_cliente.Text)
        cmb_pedido.DisplayMember = "numero_pedido"
        cmb_pedido.ValueMember = "numero_pedido"
    End Sub

    Private Sub cmb_pedido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        actualizar_dgv_despachos()

    End Sub
    Sub actualizar_dgv_despachos()
        dgv_guia_despacho.DataSource = nue_cur.listar4(cmb_cliente.Text, cmb_pedido.Text)
        dgv_guia_despacho.Columns(0).Visible = False
        dgv_guia_despacho.Columns(1).HeaderText = "Cliente"
        dgv_guia_despacho.Columns(2).HeaderText = "N° de Ped."
        dgv_guia_despacho.Columns(3).Visible = False
        dgv_guia_despacho.Columns(3).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_guia_despacho.Columns(4).HeaderText = "Fecha Pedido"
        dgv_guia_despacho.Columns(5).HeaderText = "Hora Pedido"
        dgv_guia_despacho.Columns(6).HeaderText = "Cant."
        dgv_guia_despacho.Columns(7).HeaderText = "Código Producto"
        dgv_guia_despacho.Columns(8).HeaderText = "Descripción"
        dgv_guia_despacho.Columns(9).Visible = False
        dgv_guia_despacho.Columns(10).Visible = False
        dgv_guia_despacho.Columns(11).Visible = False
        dgv_guia_despacho.Columns(12).Visible = False
        dgv_guia_despacho.Columns(13).Visible = False
        dgv_guia_despacho.Columns(3).Width = 70
        dgv_guia_despacho.Columns(4).Width = 65
        dgv_guia_despacho.Columns(8).Width = 210
        dgv_guia_despacho.Columns(1).Width = 200
        dgv_guia_despacho.Columns(2).Width = 30
        dgv_guia_despacho.Columns(5).Width = 50
        dgv_guia_despacho.Columns(6).Width = 33
        dgv_guia_despacho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_guia_despacho.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_guia_despacho.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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
            MessageBox.Show("DESPACHO EMITIDO")
            actualizar_dgv2()
            cmb_cliente.DataSource = nue_cur.listar2()
            cmb_cliente.DisplayMember = "cliente"
            cmb_cliente.ValueMember = "cliente"
            cmb_pedido.DataSource = nue_cur.listar3(cmb_cliente.Text)
            cmb_pedido.DisplayMember = "numero_pedido"
            cmb_pedido.ValueMember = "numero_pedido"
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar_dgv()
        actualizar_clientes()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (cmb_cliente.Text <> "" And cmb_pedido.Text <> "") Then
            CR_guia_de_despacho.Show()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_clientes()
        txt_fecha.Enabled = False
        txt_hora.Enabled = False
        Timer1.Enabled = True
        actualizar_dgv()
        actualizar_dgv2()
        Me.WindowState = FormWindowState.Maximized
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Sub actualizar_dgv2()
        Dim fecha3 As String
        fecha3 = Format(Today, "yyyy-MM-dd")
        dgv_curso1.DataSource = nue_cur.listar5(fecha3)
        dgv_curso1.Columns(0).HeaderText = "Cliente"
        dgv_curso1.Columns(1).HeaderText = "N° de Ped."
        dgv_curso1.Columns(2).Visible = False
        dgv_curso1.Columns(2).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_curso1.Columns(3).HeaderText = "Hora de Despacho"
        dgv_curso1.Columns(4).HeaderText = "Fecha de Pedido"
        dgv_curso1.Columns(4).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgv_curso1.Columns(5).HeaderText = "Hora de Pedido"
        dgv_curso1.Columns(6).HeaderText = "Cant."
        dgv_curso1.Columns(7).Visible = False
        dgv_curso1.Columns(8).HeaderText = "Descripción"
        dgv_curso1.Columns(9).Visible = False
        dgv_curso1.Columns(10).Visible = False
        dgv_curso1.Columns(11).Visible = False
        dgv_curso1.Columns(2).Width = 65
        dgv_curso1.Columns(4).Width = 65
        dgv_curso1.Columns(8).Width = 210
        dgv_curso1.Columns(0).Width = 210
        dgv_curso1.Columns(1).Width = 30
        dgv_curso1.Columns(3).Width = 60
        dgv_curso1.Columns(5).Width = 50
        dgv_curso1.Columns(6).Width = 33
        dgv_curso1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub cmb_cliente_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_cliente.TextChanged
        cmb_pedido.DataSource = nue_cur.listar3(cmb_cliente.Text)
        cmb_pedido.DisplayMember = "numero_pedido"
        cmb_pedido.ValueMember = "numero_pedido"
    End Sub

    Private Sub cmb_pedido_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_pedido.TextChanged
        actualizar_dgv_despachos()
    End Sub
End Class