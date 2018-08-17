Public Class frm_guias
    Dim nue_report As New clases.guias_despacho
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double


    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(100, 100)
        actualizar_facturas()
        actualizar_facturas2()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cmb_tipo.TextChanged
        If cmb_tipo.Text = "Por Muestra" Then
            tipo_guia = 1
            gpb_guia.Visible = True
            gpb_guia2.Visible = False

        ElseIf cmb_tipo.Text = "Por Dirección" Then
            tipo_guia = 2
            gpb_guia.Visible = True
            gpb_guia2.Visible = False

        ElseIf cmb_tipo.Text = "Cambio de Material" Then
            tipo_guia = 3
            gpb_guia.Visible = True
            gpb_guia2.Visible = False

        ElseIf cmb_tipo.Text = "Por Facturar" Then
            tipo_guia = 4
            gpb_guia.Visible = False
            gpb_guia2.Visible = False

        ElseIf cmb_tipo.Text = "Despacho Parcial" Then
            tipo_guia = 5
            actualizar_facturas2()
            gpb_guia.Visible = False
            gpb_guia2.Visible = True

        End If
    End Sub
    Public Sub actualizar_facturas()
        cmb_factura.DataSource = nue_report.listar(Frm_ventas_mod.txt_rut.Text)
        cmb_factura.DisplayMember = "numero_pedido"
        cmb_factura.ValueMember = "numero_pedido"
    End Sub
    Public Sub actualizar_facturas2()
        cmb_factura2.DataSource = nue_report.listar25(Frm_ventas_mod.txt_rut.Text)
        cmb_factura2.DisplayMember = "numero_pedido"
        cmb_factura2.ValueMember = "numero_pedido"
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If cmb_tipo.Text = "Por Facturar" Then
            Frm_ventas_mod.txt_tipo_guia.Text = tipo_guia
            Frm_ventas_mod.txt_factura_ref.Text = "0"
            Frm_ventas_mod.txt_fecha_ref.Text = Today
            Frm_ventas_mod.txt_factura_ref.Visible = False
            Frm_ventas_mod.lbl_fact_rel.Visible = False
            Frm_ventas_mod.txt_fecha_ref.Visible = False
            Frm_ventas_mod.lbl_fact_rel.Visible = False
            Me.Close()
        ElseIf tipo_guia = 5 Then
            Frm_ventas_mod.txt_tipo_guia.Text = tipo_guia
            Frm_ventas_mod.txt_factura_ref.Text = cmb_factura2.Text
            Frm_ventas_mod.txt_fecha_ref.Text = nue_report.descripcion_fecha(Frm_ventas_mod.txt_rut.Text, cmb_factura2.Text)
            Frm_ventas_mod.actualizar_guia()
            Frm_ventas_mod.cmb_codigo.Enabled = False
            Me.Close()
        Else

            Frm_ventas_mod.txt_tipo_guia.Text = tipo_guia
            Frm_ventas_mod.txt_factura_ref.Text = cmb_factura.Text
            Frm_ventas_mod.txt_fecha_ref.Text = nue_report.descripcion_fecha(Frm_ventas_mod.txt_rut.Text, cmb_factura.Text)
            Me.Close()
        End If
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Frm_ventas_mod.cmb_cliente_MouseClick(sender, e)
        Me.Close()
    End Sub

End Class