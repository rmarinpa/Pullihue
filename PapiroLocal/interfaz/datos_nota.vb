Imports System.Globalization
Public Class datos_nota

    Dim sw As Integer
    Dim nue_report As New clases.ventas
    Dim nue_var As New clases.variables
    Dim nueva_guia As New clases.guia_despacho
    Dim retiraCliente As Boolean

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim direccion, comuna, solicitado, fecha, observaciones, ejecutivo, factura_ref As String
        Dim folio, tipo_doc As Double
        If cerrar_nota = 0 Then
            If (rbtn_factura.Checked = True) Then
                direccion = txt_direccion_despacho2.Text
                comuna = txt_comuna2.Text
            ElseIf (rbtn_despacho.Checked = True) Then
                direccion = txt_direccion_despacho3.Text
                comuna = txt_comuna3.Text
            ElseIf (rbtn_otra.Checked = True) Then
                direccion = txt_direccion_despacho4.Text
                comuna = txt_comuna4.Text
            End If

            If (txt_fecha.Text <> "" And txt_solicitado.Text <> "" And txt_direccion_despacho2.Text <> "" And txt_comuna2.Text <> "") Then
                folio = Frm_ventas_mod.txt_folio.Text
                folio_reemprimir = Frm_ventas_mod.txt_folio.Text
                solicitado = txt_solicitado.Text.Trim()
                fecha = txt_fecha.Text
                observaciones = txt_observaciones.Text.Trim()
                ejecutivo = Frm_ventas_mod.txt_nombre_ejecutivo.Text
                If documento = 1 Then
                    tipo_doc = Frm_ventas_mod.txt_tipo_guia.Text
                    factura_ref = Frm_ventas_mod.txt_factura_ref.Text
                End If

                Dim i As Integer
                Dim id As Integer
                Dim stck As Double

                If Frm_ventas_mod.txt_senal_advertencia.Text <> "OK" Then
                    If documento = 0 Then
                        nue_report.insertar5(folio, CDate(Frm_ventas_mod.txt_fecha_act.Text), CDate(Frm_ventas_mod.txt_hora.Text), fecha, ejecutivo, solicitado, observaciones, comuna, direccion, retiraCliente, Frm_ventas_mod.txt_consulta_monto.Text)
                        MessageBox.Show("SE HA BLOQUEADO SU PEDIDO PARA FACTURA, SE REQUIERE AUTORIZACIÓN")
                        cerrar_nota = 1
                        Frm_ventas_mod.txt_folio.Text = 1
                        folio_condicion = 0
                    ElseIf documento = 1 Then
                        nue_report.insertar11(folio, CDate(Frm_ventas_mod.txt_fecha_act.Text), CDate(Frm_ventas_mod.txt_hora.Text), fecha, ejecutivo, solicitado, observaciones, comuna, direccion, tipo_doc, factura_ref, CDate(Frm_ventas_mod.txt_fecha_ref.Text))
                        MessageBox.Show("SE HA BLOQUEADO SU PEDIDO PARA GUÍA DE DESPACHO, SE REQUIERE AUTORIZACIÓN")
                        cerrar_nota = 1
                        Frm_ventas_mod.txt_folio.Text = 1
                        folio_condicion = 0
                    End If
                Else
                    If documento = 0 Then
                        nue_report.insertar4(folio, CDate(Frm_ventas_mod.txt_fecha_act.Text), CDate(Frm_ventas_mod.txt_hora.Text), fecha, ejecutivo, solicitado, observaciones, comuna, direccion, retiraCliente)
                        MessageBox.Show("NOTA DE PEDIDO GENERADA PARA FACTURA")
                    ElseIf documento = 1 And (tipo_guia = 2 Or tipo_guia = 3 Or tipo_guia = 4) Then
                        nue_report.insertar11(folio, CDate(Frm_ventas_mod.txt_fecha_act.Text), CDate(Frm_ventas_mod.txt_hora.Text), fecha, ejecutivo, solicitado, observaciones, comuna, direccion, tipo_doc, factura_ref, CDate(Frm_ventas_mod.txt_fecha_ref.Text))
                        MessageBox.Show("SE HA BLOQUEADO SU PEDIDO PARA GUÍA DE DESPACHO, SE REQUIERE AUTORIZACIÓN")
                        cerrar_nota = 1
                        Frm_ventas_mod.txt_folio.Text = 1
                        folio_condicion = 0
                    ElseIf documento = 1 And (tipo_guia <> 2 And tipo_guia <> 3 And tipo_guia <> 4) Then
                        Dim identificador As Integer
                        nue_report.insertar8(folio, CDate(Frm_ventas_mod.txt_fecha_act.Text), CDate(Frm_ventas_mod.txt_hora.Text), fecha, ejecutivo, solicitado, observaciones, comuna, direccion, tipo_doc, factura_ref, CDate(Frm_ventas_mod.txt_fecha_ref.Text))
                        identificador = nueva_guia.buscarIdentificadorFolioGuia(CInt(Frm_ventas_mod.txt_folio.Text))
                        nueva_guia.modificar2(CInt(identificador), 1)
                        nueva_guia.insertar2(1, "Guia", Frm_ventas_mod.txt_folio.Text, 1, "Autoriza", Nombre_Obra, CDate(DateTime.Today), CDate(Frm_ventas_mod.txt_hora.Text))
                        MessageBox.Show("NOTA DE PEDIDO GENERADA PARA GUÍA DE DESPACHO")
                    End If

                    cerrar_nota = 1
                    If documento = 0 Then
                        CR_guia_de_despacho.Show()
                    Else
                        CR_guia_de_despacho6.Show()
                    End If
                    If dgv_venta2.Rows.Count > 0 Then
                        For i = 0 To dgv_venta2.Rows.Count - 1
                            id = nue_report.Seleccionar_id(dgv_venta2.Rows(i).Cells(11).Value.ToString())
                            stck = nue_report.Seleccionar_stock(dgv_venta2.Rows(i).Cells(11).Value.ToString()) - dgv_venta2.Rows(i).Cells(15).Value.ToString()
                            nue_report.modificar(CInt(id), stck)
                        Next i
                    End If
                End If
                Dim contacto, medio As String

                If Frm_ventas_mod.rdbtn_entrante.Checked = True Then
                    contacto = "Entrante"
                ElseIf Frm_ventas_mod.rdbtn_saliente.Checked = True Then
                    contacto = "Saliente"
                End If

                If Frm_ventas_mod.rdbtn_llamada.Checked = True Then
                    medio = "Llamada"
                ElseIf Frm_ventas_mod.rdbtn_personal.Checked = True Then
                    medio = "Personal"
                ElseIf Frm_ventas_mod.rdbtn_what.Checked = True Then
                    medio = "Whatsapp"
                ElseIf Frm_ventas_mod.rdbtn_email.Checked = True Then
                    medio = "E-mail"
                End If

                nue_report.insertar7(folio, contacto, medio, documento)
                Frm_ventas_mod.limpiar()
                Frm_ventas_mod.borrar_grid()
                Frm_ventas_mod.txt_folio.Text = 1
                Frm_ventas_mod.txt_consulta_monto.Text = 0
                Frm_ventas_mod.txt_consulta_iva.Text = 0
                Frm_ventas_mod.txt_consulta_total.Text = 0
                Frm_ventas_mod.actualizar_dgv()
                Frm_ventas_mod.cmb_codigo.Enabled = True
                folio_condicion = 0
                documento = 0
                Frm_ventas_mod.txt_venta_m2.Enabled = True
                Frm_ventas_mod.txt_venta_m2.Clear()
                Frm_ventas_mod.txt_tipo.Text = "Factura de Venta"
                Frm_ventas_mod.txt_factura_ref.Visible = False
                Frm_ventas_mod.lbl_fact_rel.Visible = False
                Frm_ventas_mod.txt_fecha_ref.Visible = False
                Frm_ventas_mod.lbl_fact_rel.Visible = False
                Me.Close()


            Else
                MessageBox.Show("INGRESE DATOS DE PEDIDO")
            End If
        ElseIf cerrar_nota = 1 Then
            MessageBox.Show("ESTE PEDIDO YA SE EMITIO")
            Me.Close()
        End If
    End Sub

    Private Sub datos_nota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbtn_factura.Checked = True
        txt_direccion_despacho2.Clear()
        txt_comuna2.Clear()
        txt_direccion_despacho2.Text = Frm_ventas_mod.txt_direccion_despacho.Text
        txt_comuna2.Text = Frm_ventas_mod.txt_comuna.Text
        txt_direccion_despacho3.Text = Frm_ventas_mod.txt_direccion_1.Text
        txt_comuna3.Text = Frm_ventas_mod.txt_comuna1.Text
        txt_direccion_despacho2.ReadOnly = True
        txt_comuna2.ReadOnly = True
        txt_fecha.Text = "Hoy"
        actualizar_dgv_venta2()

        txt_direccion_despacho2.Text = Frm_ventas_mod.txt_direccion_despacho.Text
        txt_comuna2.Text = Frm_ventas_mod.txt_comuna.Text
        txt_direccion_despacho2.ReadOnly = True
        txt_comuna2.ReadOnly = True

        txt_direccion_despacho3.Text = Frm_ventas_mod.txt_direccion_1.Text
        txt_comuna3.Text = Frm_ventas_mod.txt_comuna1.Text
        txt_direccion_despacho3.ReadOnly = True
        txt_comuna3.ReadOnly = True



        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Sub actualizar_dgv_venta2()
        dgv_venta2.DataSource = nue_report.listar16(Frm_ventas_mod.cmb_cliente.Text, Frm_ventas_mod.txt_folio.Text)
        dgv_venta2.AllowUserToOrderColumns = True
        dgv_venta2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub chk_direccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbtn_1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_factura.CheckedChanged

    End Sub

    Private Sub rbtn_1_Click(sender As Object, e As EventArgs) Handles rbtn_factura.Click
        If rbtn_factura.Checked = True Then
            txt_observaciones.Clear()
        Else

        End If
    End Sub

    Private Sub rbtn_2_Click(sender As Object, e As EventArgs) Handles rbtn_despacho.Click
        If rbtn_despacho.Checked = True Then
            txt_observaciones.Clear()
            txt_observaciones.Text = txt_direccion_despacho3.Text & " " & txt_comuna3.Text
        End If
    End Sub

    Private Sub rbtn_3_Click(sender As Object, e As EventArgs) Handles rbtn_otra.Click
        If rbtn_otra.Checked = True Then
            txt_observaciones.Clear()
            txt_observaciones.Text = txt_direccion_despacho4.Text & " " & txt_comuna4.Text
        End If
    End Sub

    Private Sub txt_direccion_despacho4_TextChanged(sender As Object, e As EventArgs) Handles txt_direccion_despacho4.TextChanged
        If rbtn_otra.Checked = True Then
            txt_observaciones.Clear()
            txt_observaciones.Text = txt_direccion_despacho4.Text & " " & txt_comuna4.Text
        End If
    End Sub

    Private Sub txt_comuna4_TextChanged(sender As Object, e As EventArgs) Handles txt_comuna4.TextChanged
        If rbtn_otra.Checked = True Then
            txt_observaciones.Clear()
            txt_observaciones.Text = txt_direccion_despacho4.Text & " " & txt_comuna4.Text
        End If
    End Sub

    Private Sub chbRetiraCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chbRetiraCliente.CheckedChanged
        If (chbRetiraCliente.Checked) Then
            GB_despacho.Enabled = False
            rbtn_otra.Checked = True
            retiraCliente = True
            txt_direccion_despacho4.Text = Nothing
            txt_comuna4.Text = Nothing
        Else
            GB_despacho.Enabled = True
            rbtn_factura.Checked = True
            retiraCliente = False
        End If
    End Sub

    Private Sub lbl_factura_click(sender As Object, e As EventArgs) Handles lbl_factura.Click
        rbtn_factura.Checked = True
    End Sub
End Class