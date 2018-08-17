Public Class frm_sel_guia
    Dim nue_report As New clases.guia_desp_parcial
    Dim nue_var As New clases.variables
    Dim nueva_venta As New clases.ventas ' variable para indicar que pedido esta despachado
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double


    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(100, 100)
    End Sub
    Public Sub actualizar_facturas()
        cmb_factura.DataSource = nue_report.listar(txt_rut.Text)
        cmb_factura.DisplayMember = "numero_pedido"
        cmb_factura.ValueMember = "numero_pedido"
    End Sub
    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Me.Close()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If txt_cliente.Text <> "" And txt_rut.Text <> "" And cmb_factura.Text <> "" Then
            nue_report.insertar(txt_cliente.Text, txt_rut.Text, cmb_factura.Text)
            nue_report.DespachoPedido(cmb_factura.Text) ' Deja despachado el pedido generado cuando se asigna la factura del pedido a un despacho parcial.
            MsgBox("FACTURA INGRESADA PARA DESPACHO PARCIAL")
            Me.Close()
        Else
            MsgBox("SE DEBE SELECCIONAR AL CLIENTE PRIMERO")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_guias_clientes_busqueda.Show()
    End Sub
End Class