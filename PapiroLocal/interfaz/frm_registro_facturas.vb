Imports System.Globalization
Public Class frm_registro_facturas

    Dim nue_cur As New clases.Registro_pagos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_facturas()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        txt_cliente.Enabled = False
        txt_total.Enabled = False
        txt_saldo.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Me.Close()
    End Sub
    Public Sub actualizar_facturas()
        cmb_facturas.DataSource = nue_cur.listar2()
        cmb_facturas.DisplayMember = "numero_pedido"
        cmb_facturas.ValueMember = "numero_pedido"
    End Sub
    Private Sub cmb_facturas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_facturas.TextChanged
        If Len(cmb_facturas.Text) > 4 And cmb_facturas.Text <> "" Then
            actualizar_dgv()
            If String.IsNullOrEmpty(dgv_registro.Rows(0).Cells(1).Value) Then
            Else
                txt_cliente.Text = dgv_registro.Rows(0).Cells(1).Value.ToString()
                If txt_cliente.Text <> "" Then
                    txt_total.Text = dgv_registro.Rows(0).Cells(6).Value.ToString()
                    txt_pago.Clear()
                Else
                End If
            End If
        Else

        End If
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
        txt_saldo.Text = saldo.ToString("C")
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
                txt_pago.Clear()
                txt_saldo.Clear()
                txt_cliente.Clear()
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
                    txt_pago.Clear()
                    txt_saldo.Clear()
                    txt_cliente.Clear()
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
                        txt_pago.Clear()
                        txt_saldo.Clear()
                        txt_cliente.Clear()
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

    Private Sub cmb_facturas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_facturas.SelectedIndexChanged

    End Sub
    Sub actualizar_dgv()
        dgv_registro.DataSource = nue_cur.listar3(cmb_facturas.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_total.Text <> 0 Then
            txt_pago.Text = txt_total.Text
        End If
    End Sub
End Class