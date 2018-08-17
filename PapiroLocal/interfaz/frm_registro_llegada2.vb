Public Class frm_registro_llegada2
    Dim nue_cur As New clases.Ruta
    Dim nueva_venta As New clases.ventas
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(200, 10)
        'Me.Size = New System.Drawing.Size(1772, 905)
        Timer1.Enabled = True
        txt_usuario.ReadOnly = True
        txt_usuario.Text = Nombre_Obra
        txt_hora.ReadOnly = True
        actualizar_folio()
        txt_fecha.Enabled = False
        actualizar_dgv_ruta2()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub
    Sub actualizar_dgv_ruta()
        Fecha_inicio = txt_fecha.Text
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        dgv_llegada.DataSource = nue_cur.listar14(cmb_folio.Text)
    End Sub
    Public Sub actualizar_folio()
        Fecha_inicio = txt_fecha.Text
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        cmb_folio.DataSource = nue_cur.listar6(Fecha_inicio)
        cmb_folio.DisplayMember = "folio_ruta"
        cmb_folio.ValueMember = "folio_ruta"
    End Sub


    Private Sub cmb_folio_TextChanged(sender As Object, e As EventArgs) Handles cmb_folio.TextChanged




        'limpiar()
        'chk_ok1.Enabled = False
        'chk_ok2.Enabled = False
        'chk_ok3.Enabled = False
        'chk_ok4.Enabled = False
        'chk_ok5.Enabled = False
        'chk_ok6.Enabled = False
        'chk_ok7.Enabled = False
        'chk_ok8.Enabled = False
        'chk_ok9.Enabled = False
        'chk_ok10.Enabled = False
        'chk_ok11.Enabled = False
        'chk_ok12.Enabled = False
        'chk_ok13.Enabled = False
        'chk_ok14.Enabled = False
        'chk_ok15.Enabled = False
        'chk_ok16.Enabled = False
        'chk_ok17.Enabled = False
        'chk_ok18.Enabled = False
        'chk_ok19.Enabled = False
        'chk_ok20.Enabled = False

        'txt_observacion1.Enabled = False
        'txt_observacion2.Enabled = False
        'txt_observacion3.Enabled = False
        'txt_observacion4.Enabled = False
        'txt_observacion5.Enabled = False
        'txt_observacion6.Enabled = False
        'txt_observacion7.Enabled = False
        'txt_observacion8.Enabled = False
        'txt_observacion9.Enabled = False
        'txt_observacion10.Enabled = False
        'txt_observacion11.Enabled = False
        'txt_observacion12.Enabled = False
        'txt_observacion13.Enabled = False
        'txt_observacion14.Enabled = False
        'txt_observacion15.Enabled = False
        'txt_observacion16.Enabled = False
        'txt_observacion17.Enabled = False
        'txt_observacion18.Enabled = False
        'txt_observacion19.Enabled = False
        'txt_observacion20.Enabled = False

        actualizar_dgv_ruta()
        'If dgv_llegada.Rows.Count > 1 Then
        '    For i = 0 To dgv_llegada.Rows.Count - 2
        '        If i = 0 Then
        '            txt_tipo1.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped1.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo1.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente1.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            'cmb_chofer.Text = dgv_llegada.Rows(i).Cells(2).Value.ToString() Se reemplaza el combobox por un text => txt_chofer
        '            'cmb_vehiculo.Text = dgv_llegada.Rows(i).Cells(3).Value.ToString() Se reemplaza el combobox por un text => txt_vehiculo
        '            txt_condicion1.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok1.Enabled = True
        '            txt_observacion1.Enabled = True
        '        End If
        '        If i = 1 Then
        '            txt_tipo2.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped2.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo2.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente2.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion2.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok2.Enabled = True
        '            txt_observacion2.Enabled = True
        '        End If
        '        If i = 2 Then
        '            txt_tipo3.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped3.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo3.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente3.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion3.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok3.Enabled = True
        '            txt_observacion3.Enabled = True
        '        End If
        '        If i = 3 Then
        '            txt_tipo4.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped4.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo4.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente4.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion4.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok4.Enabled = True
        '            txt_observacion4.Enabled = True
        '        End If
        '        If i = 4 Then
        '            txt_tipo5.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped5.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo5.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente5.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion5.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok5.Enabled = True
        '            txt_observacion5.Enabled = True
        '        End If
        '        If i = 5 Then
        '            txt_tipo6.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped6.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo6.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente6.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion6.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok6.Enabled = True
        '            txt_observacion6.Enabled = True
        '        End If
        '        If i = 6 Then
        '            txt_tipo7.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped7.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo7.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente7.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion7.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok7.Enabled = True
        '            txt_observacion7.Enabled = True
        '        End If
        '        If i = 7 Then
        '            txt_tipo8.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped8.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo8.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente8.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion8.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok8.Enabled = True
        '            txt_observacion8.Enabled = True
        '        End If
        '        If i = 8 Then
        '            txt_tipo9.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped9.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo9.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente9.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion9.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok9.Enabled = True
        '            txt_observacion9.Enabled = True
        '        End If
        '        If i = 9 Then
        '            txt_tipo10.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped10.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo10.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente10.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion10.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok10.Enabled = True
        '            txt_observacion10.Enabled = True
        '        End If
        '        If i = 10 Then
        '            txt_tipo11.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped11.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo11.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente11.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion11.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok11.Enabled = True
        '            txt_observacion11.Enabled = True
        '        End If
        '        If i = 11 Then
        '            txt_tipo12.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped12.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo12.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente12.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion12.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok12.Enabled = True
        '            txt_observacion12.Enabled = True
        '        End If
        '        If i = 12 Then
        '            txt_tipo13.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped13.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo13.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente13.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion13.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok13.Enabled = True
        '            txt_observacion13.Enabled = True
        '        End If
        '        If i = 13 Then
        '            txt_tipo14.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped14.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo14.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente14.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion14.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok14.Enabled = True
        '            txt_observacion14.Enabled = True
        '        End If
        '        If i = 14 Then
        '            txt_tipo15.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped15.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo15.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente15.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion15.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok15.Enabled = True
        '            txt_observacion15.Enabled = True
        '        End If
        '        If i = 15 Then
        '            txt_tipo16.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped16.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo16.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente16.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion16.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok16.Enabled = True
        '            txt_observacion16.Enabled = True
        '        End If
        '        If i = 16 Then
        '            txt_tipo17.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped17.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo17.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente17.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion17.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok17.Enabled = True
        '            txt_observacion17.Enabled = True
        '        End If
        '        If i = 17 Then
        '            txt_tipo18.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped18.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo18.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente18.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion18.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok18.Enabled = True
        '            txt_observacion18.Enabled = True
        '        End If
        '        If i = 18 Then
        '            txt_tipo19.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped19.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo19.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente19.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion19.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok19.Enabled = True
        '            txt_observacion19.Enabled = True
        '        End If
        '        If i = 19 Then
        '            txt_tipo20.Text = dgv_llegada.Rows(i).Cells(11).Value.ToString()
        '            txt_n_ped20.Text = dgv_llegada.Rows(i).Cells(6).Value.ToString()
        '            txt_ejecutivo20.Text = dgv_llegada.Rows(i).Cells(7).Value.ToString()
        '            txt_cliente20.Text = dgv_llegada.Rows(i).Cells(12).Value.ToString()
        '            txt_condicion20.Text = dgv_llegada.Rows(i).Cells("forma_pago").Value.ToString()
        '            chk_ok20.Enabled = True
        '            txt_observacion20.Enabled = True
        '        End If
        '    Next i
        'End If


        ' INICIO CODIGO CARLOS
        dgv_registrarLlegada.Rows.Clear()
        Dim datos As Integer = dgv_llegada.RowCount
        Dim filas_dgv_registrarLlegada As Integer = 0
        If datos >= 1 Then
            txt_chofer.Text = dgv_llegada.Rows(0).Cells("chofer").Value.ToString() ' 2
            txt_vehiculo.Text = dgv_llegada.Rows(0).Cells("vehiculo").Value.ToString() ' 3
            txt_revisa1.Text = dgv_llegada.Rows(0).Cells("revisa_camioneta").Value.ToString() ' 14
            txt_revisa2.Text = dgv_llegada.Rows(0).Cells("revisa_camioneta2").Value.ToString() ' 15

            For index As Integer = 0 To datos - 1
                dgv_registrarLlegada.Rows.Add()
                dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(1).Value = dgv_llegada.Rows(index).Cells(11).Value.ToString()
                dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(2).Value = dgv_llegada.Rows(index).Cells(6).Value.ToString()
                dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(3).Value = dgv_llegada.Rows(index).Cells(7).Value.ToString()
                dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(4).Value = dgv_llegada.Rows(index).Cells(12).Value.ToString()
                dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(5).Value = dgv_llegada.Rows(index).Cells("forma_pago").Value.ToString()
                Dim condicion As String = dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(5).Value.ToString()
                If (condicion = "Efectivo" Or condicion = "Transferencia" Or condicion = "Cheque Contra Entrega" Or condicion = "Efectivo o Transferencia" Or condicion = "") Then
                    dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(6).Value = Nothing
                Else
                    dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(6).Value = "Si"
                    dgv_registrarLlegada.Rows(filas_dgv_registrarLlegada).Cells(6).ReadOnly = True
                End If
                filas_dgv_registrarLlegada = filas_dgv_registrarLlegada + 1
            Next
        End If
        dgv_registrarLlegada.Columns(1).ReadOnly = True
        dgv_registrarLlegada.Columns(2).ReadOnly = True
        dgv_registrarLlegada.Columns(3).ReadOnly = True
        dgv_registrarLlegada.Columns(4).ReadOnly = True
        dgv_registrarLlegada.Columns(5).ReadOnly = True

        ' TERMINO DE CODIGO CARLOS

    End Sub

    Sub limpiar()
        txt_observacion1.Clear()
        txt_n_ped1.Clear()
        txt_ejecutivo1.Clear()
        txt_cliente1.Clear()
        txt_condicion1.Clear()
        chk_si1.Checked = False
        chk_no1.Checked = False


        txt_observacion2.Clear()
        txt_n_ped2.Clear()
        txt_ejecutivo2.Clear()
        txt_cliente2.Clear()
        txt_condicion2.Clear()
        chk_si2.Checked = False
        chk_no2.Checked = False


        txt_observacion3.Clear()
        txt_n_ped3.Clear()
        txt_ejecutivo3.Clear()
        txt_cliente3.Clear()
        txt_condicion3.Clear()
        chk_si3.Checked = False
        chk_no3.Checked = False


        txt_observacion4.Clear()
        txt_n_ped4.Clear()
        txt_ejecutivo4.Clear()
        txt_cliente4.Clear()
        txt_condicion4.Clear()
        chk_si4.Checked = False
        chk_no4.Checked = False


        txt_observacion5.Clear()
        txt_n_ped5.Clear()
        txt_ejecutivo5.Clear()
        txt_cliente5.Clear()
        txt_condicion5.Clear()
        chk_si5.Checked = False
        chk_no5.Checked = False


        txt_observacion6.Clear()
        txt_n_ped6.Clear()
        txt_ejecutivo6.Clear()
        txt_cliente6.Clear()
        txt_condicion6.Clear()
        chk_si6.Checked = False
        chk_no6.Checked = False


        txt_observacion7.Clear()
        txt_n_ped7.Clear()
        txt_ejecutivo7.Clear()
        txt_cliente7.Clear()
        txt_condicion7.Clear()
        chk_si7.Checked = False
        chk_no7.Checked = False


        txt_observacion8.Clear()
        txt_n_ped8.Clear()
        txt_ejecutivo8.Clear()
        txt_cliente8.Clear()
        txt_condicion8.Clear()
        chk_si8.Checked = False
        chk_no8.Checked = False


        txt_observacion9.Clear()
        txt_n_ped9.Clear()
        txt_ejecutivo9.Clear()
        txt_cliente9.Clear()
        txt_condicion9.Clear()
        chk_si9.Checked = False
        chk_no9.Checked = False


        txt_observacion10.Clear()
        txt_n_ped10.Clear()
        txt_ejecutivo10.Clear()
        txt_cliente10.Clear()
        txt_condicion10.Clear()
        chk_si10.Checked = False
        chk_no10.Checked = False


        txt_observacion11.Clear()
        txt_n_ped11.Clear()
        txt_ejecutivo11.Clear()
        txt_cliente11.Clear()
        txt_condicion11.Clear()
        chk_si11.Checked = False
        chk_no11.Checked = False


        txt_observacion12.Clear()
        txt_n_ped12.Clear()
        txt_ejecutivo12.Clear()
        txt_cliente12.Clear()
        txt_condicion12.Clear()
        chk_si12.Checked = False
        chk_no12.Checked = False


        txt_observacion13.Clear()
        txt_n_ped13.Clear()
        txt_ejecutivo13.Clear()
        txt_cliente13.Clear()
        txt_condicion13.Clear()
        chk_si13.Checked = False
        chk_no13.Checked = False


        txt_observacion14.Clear()
        txt_n_ped14.Clear()
        txt_ejecutivo14.Clear()
        txt_cliente14.Clear()
        txt_condicion14.Clear()
        chk_si14.Checked = False
        chk_no14.Checked = False


        txt_observacion15.Clear()
        txt_n_ped15.Clear()
        txt_ejecutivo15.Clear()
        txt_cliente15.Clear()
        txt_condicion15.Clear()
        chk_si15.Checked = False
        chk_no15.Checked = False


        txt_observacion16.Clear()
        txt_n_ped16.Clear()
        txt_ejecutivo16.Clear()
        txt_cliente16.Clear()
        txt_condicion16.Clear()
        chk_si16.Checked = False
        chk_no16.Checked = False


        txt_observacion17.Clear()
        txt_n_ped17.Clear()
        txt_ejecutivo17.Clear()
        txt_cliente17.Clear()
        txt_condicion17.Clear()
        chk_si17.Checked = False
        chk_no17.Checked = False


        txt_observacion18.Clear()
        txt_n_ped18.Clear()
        txt_ejecutivo18.Clear()
        txt_cliente18.Clear()
        txt_condicion18.Clear()
        chk_si18.Checked = False
        chk_no18.Checked = False


        txt_observacion19.Clear()
        txt_n_ped19.Clear()
        txt_ejecutivo19.Clear()
        txt_cliente19.Clear()
        txt_condicion19.Clear()
        chk_si19.Checked = False
        chk_no19.Checked = False


        txt_observacion20.Clear()
        txt_n_ped20.Clear()
        txt_ejecutivo20.Clear()
        txt_cliente20.Clear()
        txt_condicion20.Clear()
        chk_si20.Checked = False
        chk_no20.Checked = False


        txt_tipo1.Clear()
        txt_tipo2.Clear()
        txt_tipo3.Clear()
        txt_tipo4.Clear()
        txt_tipo5.Clear()
        txt_tipo6.Clear()
        txt_tipo7.Clear()
        txt_tipo8.Clear()
        txt_tipo9.Clear()
        txt_tipo10.Clear()
        txt_tipo11.Clear()
        txt_tipo12.Clear()
        txt_tipo13.Clear()
        txt_tipo14.Clear()
        txt_tipo15.Clear()
        txt_tipo16.Clear()
        txt_tipo17.Clear()
        txt_tipo18.Clear()
        txt_tipo19.Clear()
        txt_tipo20.Clear()

        chk_ok1.Checked = False
        chk_ok2.Checked = False
        chk_ok3.Checked = False
        chk_ok4.Checked = False
        chk_ok5.Checked = False
        chk_ok6.Checked = False
        chk_ok7.Checked = False
        chk_ok8.Checked = False
        chk_ok9.Checked = False
        chk_ok10.Checked = False
        chk_ok11.Checked = False
        chk_ok12.Checked = False
        chk_ok13.Checked = False
        chk_ok14.Checked = False
        chk_ok15.Checked = False
        chk_ok16.Checked = False
        chk_ok17.Checked = False
        chk_ok18.Checked = False
        chk_ok19.Checked = False
        chk_ok20.Checked = False

    End Sub

    Private Sub btn_otros_Click(sender As Object, e As EventArgs) Handles btn_otros.Click
        If cmb_folio.Text <> "" Then

            Dim folio_ruta As Double
            Dim usuario As String
            Dim pendiente1, pendiente2 As String
            Dim cumple As String = ""

            Dim tipo, observacion, condicionPago As String
            Dim nPedido As Double

            For contador As Integer = 0 To dgv_registrarLlegada.RowCount - 1
                If (dgv_registrarLlegada.Rows(contador).Cells(0).Value) Then
                    Dim cumplimiento As String = dgv_registrarLlegada.Rows(contador).Cells(6).Value
                    If (cumplimiento = Nothing) Then
                        MsgBox("Debe indicar cumplimiento, favor de verificar.", MsgBoxStyle.Information, "Información.")
                        Exit Sub
                    End If
                End If
            Next

            pendiente1 = "NO_OK"
            pendiente2 = "OK"
            usuario = txt_usuario.Text
            folio_ruta = cmb_folio.Text

            nue_cur.insertar2(usuario, folio_ruta, CDate(txt_fecha.Text), CDate(txt_hora.Text)) ' registro de llegada hora

            For index As Integer = 0 To dgv_registrarLlegada.RowCount - 1
                tipo = dgv_registrarLlegada.Rows(index).Cells(1).Value.ToString()
                nPedido = CDbl(dgv_registrarLlegada.Rows(index).Cells(2).Value)
                observacion = dgv_registrarLlegada.Rows(index).Cells(7).Value
                condicionPago = dgv_registrarLlegada.Rows(index).Cells(5).Value.ToString()
                cumple = dgv_registrarLlegada.Rows(index).Cells(6).Value
                If (Not dgv_registrarLlegada.Rows(index).Cells(0).Value) Then
                    nue_cur.insertar3("NO_OK", folio_ruta, tipo, nPedido, observacion, condicionPago, cumple)
                    nue_cur.eliminar3(tipo, nPedido)
                    nueva_venta.Pendiente(nPedido)
                Else
                    nue_cur.insertar3("OK", folio_ruta, tipo, nPedido, observacion, condicionPago, cumple)
                End If

            Next

            'If (chk_si1.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no1.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok1.Enabled = True And chk_ok1.Checked = False Then
            '    'nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo1.Text, txt_n_ped1.Text, txt_observacion1.Text, txt_condicion1.Text, cumple)
            '    'nue_cur.eliminar3(txt_tipo1.Text, txt_n_ped1.Text)
            'ElseIf chk_ok1.Enabled = True And chk_ok1.Checked = True Then
            '    'nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo1.Text, txt_n_ped1.Text, txt_observacion1.Text, txt_condicion1.Text, cumple)
            'End If


            'If (chk_si2.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no2.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok2.Enabled = True And chk_ok2.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo2.Text, txt_n_ped2.Text, txt_observacion2.Text, txt_condicion2.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo2.Text, txt_n_ped2.Text)
            'ElseIf chk_ok2.Enabled = True And chk_ok2.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo2.Text, txt_n_ped2.Text, txt_observacion2.Text, txt_condicion2.Text, cumple)
            'End If


            'If (chk_si3.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no3.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok3.Enabled = True And chk_ok3.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo3.Text, txt_n_ped3.Text, txt_observacion3.Text, txt_condicion3.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo3.Text, txt_n_ped3.Text)
            'ElseIf chk_ok3.Enabled = True And chk_ok3.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo3.Text, txt_n_ped3.Text, txt_observacion3.Text, txt_condicion3.Text, cumple)
            'End If


            'If (chk_si4.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no4.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok4.Enabled = True And chk_ok4.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo4.Text, txt_n_ped4.Text, txt_observacion4.Text, txt_condicion4.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo4.Text, txt_n_ped4.Text)
            'ElseIf chk_ok4.Enabled = True And chk_ok4.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo4.Text, txt_n_ped4.Text, txt_observacion4.Text, txt_condicion4.Text, cumple)
            'End If


            'If (chk_si5.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no5.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok5.Enabled = True And chk_ok5.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo5.Text, txt_n_ped5.Text, txt_observacion5.Text, txt_condicion5.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo5.Text, txt_n_ped5.Text)
            'ElseIf chk_ok5.Enabled = True And chk_ok5.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo5.Text, txt_n_ped5.Text, txt_observacion5.Text, txt_condicion5.Text, cumple)
            'End If


            'If (chk_si6.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no6.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok6.Enabled = True And chk_ok6.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo6.Text, txt_n_ped6.Text, txt_observacion6.Text, txt_condicion6.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo6.Text, txt_n_ped6.Text)
            'ElseIf chk_ok6.Enabled = True And chk_ok6.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo6.Text, txt_n_ped6.Text, txt_observacion6.Text, txt_condicion6.Text, cumple)
            'End If


            'If (chk_si7.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no7.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok7.Enabled = True And chk_ok7.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo7.Text, txt_n_ped7.Text, txt_observacion7.Text, txt_condicion7.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo7.Text, txt_n_ped7.Text)
            'ElseIf chk_ok7.Enabled = True And chk_ok7.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo7.Text, txt_n_ped7.Text, txt_observacion7.Text, txt_condicion7.Text, cumple)
            'End If


            'If (chk_si8.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no8.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok8.Enabled = True And chk_ok8.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo8.Text, txt_n_ped8.Text, txt_observacion8.Text, txt_condicion8.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo8.Text, txt_n_ped8.Text)
            'ElseIf chk_ok8.Enabled = True And chk_ok8.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo8.Text, txt_n_ped8.Text, txt_observacion8.Text, txt_condicion8.Text, cumple)
            'End If


            'If (chk_si9.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no9.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok9.Enabled = True And chk_ok9.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo9.Text, txt_n_ped9.Text, txt_observacion9.Text, txt_condicion9.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo9.Text, txt_n_ped9.Text)
            'ElseIf chk_ok9.Enabled = True And chk_ok9.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo9.Text, txt_n_ped9.Text, txt_observacion9.Text, txt_condicion9.Text, cumple)
            'End If


            'If (chk_si10.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no10.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok10.Enabled = True And chk_ok10.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo10.Text, txt_n_ped10.Text, txt_observacion10.Text, txt_condicion10.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo10.Text, txt_n_ped10.Text)
            'ElseIf chk_ok10.Enabled = True And chk_ok10.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo10.Text, txt_n_ped10.Text, txt_observacion10.Text, txt_condicion10.Text, cumple)
            'End If


            'If (chk_si11.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no11.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok11.Enabled = True And chk_ok11.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo11.Text, txt_n_ped11.Text, txt_observacion11.Text, txt_condicion11.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo11.Text, txt_n_ped11.Text)
            'ElseIf chk_ok11.Enabled = True And chk_ok11.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo11.Text, txt_n_ped11.Text, txt_observacion11.Text, txt_condicion11.Text, cumple)
            'End If


            'If (chk_si12.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no12.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok12.Enabled = True And chk_ok12.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo12.Text, txt_n_ped12.Text, txt_observacion12.Text, txt_condicion12.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo12.Text, txt_n_ped12.Text)
            'ElseIf chk_ok12.Enabled = True And chk_ok12.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo12.Text, txt_n_ped12.Text, txt_observacion12.Text, txt_condicion12.Text, cumple)
            'End If


            'If (chk_si13.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no13.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok13.Enabled = True And chk_ok13.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo13.Text, txt_n_ped13.Text, txt_observacion13.Text, txt_condicion13.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo13.Text, txt_n_ped13.Text)
            'ElseIf chk_ok13.Enabled = True And chk_ok13.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo13.Text, txt_n_ped13.Text, txt_observacion13.Text, txt_condicion13.Text, cumple)
            'End If


            'If (chk_si14.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no14.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok14.Enabled = True And chk_ok14.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo14.Text, txt_n_ped14.Text, txt_observacion14.Text, txt_condicion14.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo14.Text, txt_n_ped14.Text)
            'ElseIf chk_ok14.Enabled = True And chk_ok14.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo14.Text, txt_n_ped14.Text, txt_observacion14.Text, txt_condicion14.Text, cumple)
            'End If


            'If (chk_si15.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no15.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok15.Enabled = True And chk_ok15.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo15.Text, txt_n_ped15.Text, txt_observacion15.Text, txt_condicion15.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo15.Text, txt_n_ped15.Text)
            'ElseIf chk_ok15.Enabled = True And chk_ok15.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo15.Text, txt_n_ped15.Text, txt_observacion15.Text, txt_condicion15.Text, cumple)
            'End If


            'If (chk_si16.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no16.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok16.Enabled = True And chk_ok16.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo16.Text, txt_n_ped16.Text, txt_observacion16.Text, txt_condicion16.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo16.Text, txt_n_ped16.Text)
            'ElseIf chk_ok16.Enabled = True And chk_ok16.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo16.Text, txt_n_ped16.Text, txt_observacion16.Text, txt_condicion16.Text, cumple)
            'End If


            'If (chk_si17.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no17.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok17.Enabled = True And chk_ok17.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo17.Text, txt_n_ped17.Text, txt_observacion17.Text, txt_condicion17.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo17.Text, txt_n_ped17.Text)
            'ElseIf chk_ok17.Enabled = True And chk_ok17.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo17.Text, txt_n_ped17.Text, txt_observacion17.Text, txt_condicion17.Text, cumple)
            'End If


            'If (chk_si18.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no18.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok18.Enabled = True And chk_ok18.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo18.Text, txt_n_ped18.Text, txt_observacion18.Text, txt_condicion18.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo18.Text, txt_n_ped18.Text)
            'ElseIf chk_ok18.Enabled = True And chk_ok18.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo18.Text, txt_n_ped18.Text, txt_observacion18.Text, txt_condicion18.Text, cumple)
            'End If


            'If (chk_si19.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no19.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok19.Enabled = True And chk_ok19.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo19.Text, txt_n_ped19.Text, txt_observacion19.Text, txt_condicion19.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo19.Text, txt_n_ped19.Text)
            'ElseIf chk_ok19.Enabled = True And chk_ok19.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo19.Text, txt_n_ped19.Text, txt_observacion19.Text, txt_condicion19.Text, cumple)
            'End If


            'If (chk_si20.Checked) Then
            '    cumple = "Si"
            'ElseIf (chk_no20.Checked) Then
            '    cumple = "No"
            'End If
            'If chk_ok20.Enabled = True And chk_ok20.Checked = False Then
            '    nue_cur.insertar3(pendiente1, cmb_folio.Text, txt_tipo20.Text, txt_n_ped20.Text, txt_observacion20.Text, txt_condicion20.Text, cumple)
            '    nue_cur.eliminar3(txt_tipo20.Text, txt_n_ped20.Text)
            'ElseIf chk_ok20.Enabled = True And chk_ok20.Checked = True Then
            '    nue_cur.insertar3(pendiente2, cmb_folio.Text, txt_tipo20.Text, txt_n_ped20.Text, txt_observacion20.Text, txt_condicion20.Text, cumple)
            'End If

            CR_obs_llegada.Show()

            actualizar_dgv_ruta2()
            MessageBox.Show("LLEGADA REGISTRADA CON EXITO")
            actualizar_folio()
            frm_registro_ruta.actualizar_dgv()
            frm_registro_ruta.actualizar_folio()
            frm_registro_ruta.actualizar_dgv_retiros()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub
    Sub actualizar_dgv_ruta2()
        Fecha_inicio = txt_fecha.Text
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        dgv_llegada2.DataSource = nue_cur.listar5(Fecha_inicio)
        dgv_llegada2.Columns(0).Visible = False
        dgv_llegada2.Columns(1).HeaderText = "USUARIO"
        dgv_llegada2.Columns(2).HeaderText = "FOLIO RUTA"
        dgv_llegada2.Columns(3).HeaderText = "FECHA REGISTRO"
        dgv_llegada2.Columns(4).HeaderText = "HORA REGISTRO"
        dgv_llegada2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada2.Columns(1).Width = 65
        dgv_llegada2.Columns(2).Width = 65
        dgv_llegada2.Columns(3).Width = 65
        dgv_llegada2.Columns(4).Width = 65
    End Sub

    Private Sub btn_reemitir_Click(sender As Object, e As EventArgs) Handles btn_reemitir.Click
        If txt_folio_llegada.Text <> "" Then
            CR_obs_llegada2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub dgv_llegada2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_llegada2.CellClick
        txt_folio_llegada.Text = dgv_llegada2.CurrentRow.Cells(2).Value.ToString()
    End Sub
End Class