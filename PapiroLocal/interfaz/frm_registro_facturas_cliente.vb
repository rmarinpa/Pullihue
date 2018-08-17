Imports System.Globalization
Public Class frm_registro_facturas_cliente

    Dim nue_cur As New clases.Registro_pagos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'actualizar_facturas()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        txt_cliente.Enabled = False
        txt_total.Enabled = False
        txt_saldo.Enabled = False
        txt_rut.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
        GroupBox2.Visible = False
        txt_acum.ReadOnly = True
        txt_saldo2.ReadOnly = True
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Me.Close()
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pago.TextChanged
        Dim total, pago, saldo As Integer

        If txt_total.Text <> "" And IsNumeric(txt_total.Text) Then
            total = CInt(txt_total.Text)
        Else
            total = 0
        End If
        If txt_pago.Text <> "" And IsNumeric(txt_pago.Text) Then
            pago = CInt(txt_pago.Text)
        Else
            pago = 0
        End If
        saldo = total - pago
        txt_saldo.Text = FormatNumber(saldo, 0)

        If txt_total.Text <> "" And IsNumeric(txt_total.Text) Then
            txt_total.Text = FormatNumber(txt_total.Text, 0)
        Else
            total = 0
        End If
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If (cmb_facturas.Text <> "" And txt_total.Text <> "" And txt_cliente.Text <> "" And txt_pago.Text <> "") Then
            If txt_saldo.Text < 0 And txt_pago.Text > 0 Then
                Dim lista As ListViewItem = New ListViewItem(cmb_facturas.Text)
                lista.SubItems.Add(FormatCurrency(txt_total.Text))
                lista.SubItems.Add(FormatCurrency(txt_pago.Text))
                lista.SubItems.Add(FormatCurrency(txt_saldo.Text))
                lista.SubItems.Add(txt_cliente.Text)
                frm_registro_pagos.lvpago.Items.Add(lista)
                MessageBox.Show("SALDO REGISTRADO EN LA FACTURA DEL CLIENTE " + txt_cliente.Text)
                cmb_facturas.Text = ""
                txt_total.Clear()
                If IsNumeric(txt_pago.Text) Then
                Else
                    txt_pago.Text = 0
                End If
                If IsNumeric(txt_acum.Text) Then
                Else
                    txt_acum.Text = 0
                End If
                txt_acum.Text = txt_acum.Text + CInt(txt_pago.Text)
                txt_pago.Clear()
                txt_saldo.Clear()
                frm_registro_pagos.suma_listview()
                frm_registro_pagos.dtp_fecha_pago.Visible = True
                frm_registro_pagos.lbl_pago.Visible = True
            ElseIf txt_saldo.Text >= 0 And txt_pago.Text < 0 Then
                Dim validar, validar2 As Integer
                validar = 0
                validar2 = 0
                If frm_registro_pagos.cmb_operacion.Text = "TRANSFERENCIA" Then
                    validar = 0
                    validar2 = 0
                Else
                    For Each item As ListViewItem In frm_registro_pagos.lvpago.Items
                        If item.SubItems(4).Text = txt_cliente.Text Then
                            validar = validar + 1
                        Else
                            validar = validar + 0
                        End If
                        validar2 = validar2 + 1
                    Next
                End If
                If validar = validar2 Then
                    Dim lista As ListViewItem = New ListViewItem(cmb_facturas.Text)
                    lista.SubItems.Add(FormatCurrency(txt_total.Text, 0))
                    lista.SubItems.Add(FormatCurrency(txt_pago.Text, 0))
                    lista.SubItems.Add(FormatCurrency(txt_saldo.Text, 0))
                    lista.SubItems.Add(txt_cliente.Text)
                    frm_registro_pagos.lvpago.Items.Add(lista)
                    cmb_facturas.Text = ""
                    txt_total.Clear()
                    If IsNumeric(txt_pago.Text) Then
                    Else
                        txt_pago.Text = 0
                    End If
                    If IsNumeric(txt_acum.Text) Then
                    Else
                        txt_acum.Text = 0
                    End If
                    txt_acum.Text = txt_acum.Text + CInt(txt_pago.Text)
                    txt_pago.Clear()
                    txt_saldo.Clear()
                    frm_registro_pagos.suma_listview()
                    frm_registro_pagos.dtp_fecha_pago.Visible = True
                    frm_registro_pagos.lbl_pago.Visible = True
                Else
                    MsgBox("CLIENTE NO ES EL MISMO")
                End If

            ElseIf txt_saldo.Text >= 0 And txt_pago.Text >= 0 Then
                Dim validar, validar2 As Integer
                validar = 0
                validar2 = 0
                If frm_registro_pagos.cmb_operacion.Text = "TRANSFERENCIA" Then
                    validar = 0
                    validar2 = 0
                Else
                    For Each item As ListViewItem In frm_registro_pagos.lvpago.Items
                        If item.SubItems(4).Text = txt_cliente.Text Then
                            validar = validar + 1
                        Else
                            validar = validar + 0
                        End If
                        validar2 = validar2 + 1
                    Next
                End If

                If validar = validar2 Then
                    Dim lista As ListViewItem = New ListViewItem(cmb_facturas.Text)
                    lista.SubItems.Add(FormatCurrency(txt_total.Text))
                    lista.SubItems.Add(FormatCurrency(txt_pago.Text))
                    lista.SubItems.Add(FormatCurrency(txt_saldo.Text))
                    lista.SubItems.Add(txt_cliente.Text)
                    frm_registro_pagos.lvpago.Items.Add(lista)
                    cmb_facturas.Text = ""
                    txt_total.Clear()
                    If IsNumeric(txt_pago.Text) Then
                    Else
                        txt_pago.Text = 0
                    End If
                    If IsNumeric(txt_acum.Text) Then
                    Else
                        txt_acum.Text = 0
                    End If
                    txt_acum.Text = txt_acum.Text + CInt(txt_pago.Text)
                    txt_pago.Clear()
                    txt_saldo.Clear()
                    frm_registro_pagos.suma_listview()
                    frm_registro_pagos.dtp_fecha_pago.Visible = True
                    frm_registro_pagos.lbl_pago.Visible = True
                Else
                    MsgBox("CLIENTE NO ES EL MISMO")
                End If
            End If
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        Dim total, pago, saldo As Double

        If txt_total.Text <> "" And IsNumeric(txt_total.Text) Then
            total = CDbl(txt_total.Text)
        Else
            total = 0
        End If
        If txt_pago.Text <> "" And IsNumeric(txt_pago.Text) Then
            pago = CDbl(txt_pago.Text)
        Else
            pago = 0
        End If
        saldo = total - pago
        txt_saldo.Text = saldo.ToString("C")
    End Sub

    Sub actualizar_dgv()
        dgv_facturas.DataSource = nue_cur.listar5(txt_rut.Text)
        dgv_facturas.Columns(0).HeaderText = "Número Factura"
        dgv_facturas.Columns(1).Visible = False
        dgv_facturas.Columns(2).HeaderText = "Venta Total"
        dgv_facturas.Columns(3).HeaderText = "Fecha"
        dgv_facturas.Columns(4).HeaderText = "Suma Monto"
        dgv_facturas.Columns(5).Visible = False
        dgv_facturas.Columns(6).HeaderText = "Saldo"
        dgv_facturas.Columns(1).Width = 200

        dgv_facturas.Columns(2).DefaultCellStyle.Format = "##,###."
        dgv_facturas.Columns(4).DefaultCellStyle.Format = "##,###."
        dgv_facturas.Columns(6).DefaultCellStyle.Format = "##,###."

        dgv_facturas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_facturas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txt_total.Text <> 0 Then
            txt_pago.Text = txt_total.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_clientes_busqueda_pago.Show()
    End Sub

    Private Sub dgv_facturas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_facturas.CellClick
        If (IsDBNull(dgv_facturas.CurrentRow.Cells(2).Value.ToString())) Then
        Else
            cmb_facturas.Text = dgv_facturas.CurrentRow.Cells(0).Value.ToString()
            txt_total.Text = dgv_facturas.CurrentRow.Cells(5).Value.ToString()
            txt_pago.Text = FormatNumber(dgv_facturas.CurrentRow.Cells(5).Value.ToString(), 0)
        End If
    End Sub

    Private Sub dgv_facturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_facturas.CellContentClick

    End Sub

    Private Sub txt_saldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_saldo.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox2.Visible = True
        txt_monto.Text = 0
        txt_acum.Text = 0
    End Sub

    Private Sub txt_acum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_acum.TextChanged
        If txt_acum.Text <> "" And txt_monto.Text <> "" Then
            txt_saldo2.Text = txt_monto.Text - txt_acum.Text
        End If
    End Sub

    Private Sub txt_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_monto.TextChanged
        If txt_acum.Text <> "" And txt_monto.Text <> "" Then
            txt_saldo2.Text = txt_monto.Text - txt_acum.Text
        End If
    End Sub

    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged
        actualizar_dgv()
    End Sub
End Class