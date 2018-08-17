Imports System.Globalization
Imports System.Net.Mail 'referencia
Imports System.IO
Imports System.Web.Mail
Public Class Frm_consulta_pedido_fact

    Dim nue_cur As New clases.guia_despacho
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim contador As Integer


    Dim nueva_venta As New clases.ventas

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_fecha_in.Text = Today
        txt_fecha.Text = Today
        Timer1.Enabled = True
        Me.WindowState = FormWindowState.Maximized
        txt_pedido.ReadOnly = True
        txt_factura.ReadOnly = True
        txt_total.ReadOnly = True
        txt_fecha.Text = DateTime.Now
        actualizar_dgv_fecha()
        txt_iva.ReadOnly = True
        txt_total2.ReadOnly = True
        'actualizar_dgv_fecha_ejecutivos()
        '   System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        '   System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        '    System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        '   System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        '   System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        '   System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Sub actualizar_dgv()
        dgv_despachos.DataSource = nue_cur.listar6()
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(2).Visible = False
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(4).Width = 50
        dgv_despachos.Columns(4).HeaderText = "Hora"
        dgv_despachos.Columns(4).DefaultCellStyle.Format = "hh:mm"
        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        If Not e.ColumnIndex = 11 Then
            Dim numero_folio As Double
            contador = 0
            numero_folio = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
            dgv_despachos2.DataSource = nue_cur.listar7(numero_folio)

            txt_email.Clear()

            ' Columnas NO visibles
            dgv_despachos2.Columns(0).Visible = False
            dgv_despachos2.Columns(1).Visible = False
            dgv_despachos2.Columns(2).Visible = False
            dgv_despachos2.Columns(3).Visible = False
            dgv_despachos2.Columns(4).Visible = False
            dgv_despachos2.Columns(5).Visible = False
            dgv_despachos2.Columns(6).Visible = False
            dgv_despachos2.Columns(7).Visible = False
            dgv_despachos2.Columns(8).Visible = False
            dgv_despachos2.Columns(9).Visible = False
            dgv_despachos2.Columns(11).Visible = False
            dgv_despachos2.Columns(12).Visible = False
            dgv_despachos2.Columns(14).Visible = False
            dgv_despachos2.Columns(16).Visible = False
            dgv_despachos2.Columns(17).Visible = False
            dgv_despachos2.Columns(18).Visible = False
            dgv_despachos2.Columns(20).Visible = False
            dgv_despachos2.Columns(21).Visible = False
            dgv_despachos2.Columns(22).Visible = False
            dgv_despachos2.Columns(23).Visible = False
            dgv_despachos2.Columns(24).Visible = False
            dgv_despachos2.Columns(25).Visible = False
            dgv_despachos2.Columns(26).Visible = False
            dgv_despachos2.Columns(27).Visible = False
            dgv_despachos2.Columns(31).Visible = False
            dgv_despachos2.Columns(30).Visible = False
            dgv_despachos2.Columns(29).Visible = False
            dgv_despachos2.Columns(32).Visible = False
            dgv_despachos2.Columns(33).Visible = False
            dgv_despachos2.Columns(34).Visible = False
            dgv_despachos2.Columns(35).Visible = False
            dgv_despachos2.Columns(36).Visible = False
            dgv_despachos2.Columns(37).Visible = False
            dgv_despachos2.Columns(38).Visible = False
            dgv_despachos2.Columns(39).Visible = False

            ' Titulo a las columnas
            dgv_despachos2.Columns(10).HeaderText = "Medidas"
            dgv_despachos2.Columns(13).HeaderText = "Descripción"
            dgv_despachos2.Columns(15).HeaderText = "Cantidad"
            dgv_despachos2.Columns(19).HeaderText = "Venta"
            dgv_despachos2.Columns(28).HeaderText = "Precio Un"

            ' Formato Celdas
            dgv_despachos2.Columns(14).DefaultCellStyle.Format = "##,###.##"
            dgv_despachos2.Columns(18).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(19).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(27).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(28).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(34).DefaultCellStyle.Format = "###,###,###"

            ' Posicion columnas
            dgv_despachos2.Columns(10).DisplayIndex = 3
            dgv_despachos2.Columns(13).DisplayIndex = 2
            dgv_despachos2.Columns(14).DisplayIndex = 6
            dgv_despachos2.Columns(15).DisplayIndex = 4
            dgv_despachos2.Columns(18).DisplayIndex = 5
            dgv_despachos2.Columns(19).DisplayIndex = 8
            dgv_despachos2.Columns(28).DisplayIndex = 7
            dgv_despachos2.Columns(30).DisplayIndex = 9
            dgv_despachos2.Columns(31).DisplayIndex = 1

            dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineacion Titulos columnas

            ' Alineación contenido celdas
            dgv_despachos2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_despachos2.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Dimenciones columnas
            dgv_despachos2.Columns(1).Width = 200
            dgv_despachos2.Columns(10).Width = 60
            dgv_despachos2.Columns(13).Width = 210
            dgv_despachos2.Columns(14).Width = 40
            dgv_despachos2.Columns(15).Width = 50
            dgv_despachos2.Columns(18).Width = 60
            dgv_despachos2.Columns(19).Width = 60
            dgv_despachos2.Columns(28).Width = 60
            dgv_despachos2.Columns(30).Width = 50
            dgv_despachos2.Columns(31).Width = 65
            dgv_despachos2.Columns(34).Width = 50

            txt_pedido.Clear()
            txt_factura.Clear()
            txt_pedido.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
            If dgv_despachos.CurrentRow.Cells(2).Value.ToString() <> "" Then
                txt_factura.Text = dgv_despachos.CurrentRow.Cells(2).Value.ToString()
            End If

            txt_id.Text = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
            txt_total.Text = dgv_despachos.CurrentRow.Cells(9).Value.ToString()
            txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
            actualizar_dgv_cliente()

            actualizar_dgv_rutas()

            If dgv_clientes.Rows(0).Cells(3).Value.ToString() = dgv_despachos.CurrentRow.Cells(7).Value.ToString() Then
                txt_observacion.Text = dgv_despachos.CurrentRow.Cells(10).Value.ToString()
            Else
                If dgv_despachos.CurrentRow.Cells(10).Value.ToString() <> "" Then
                    txt_observacion.Text = "DIRECCIÓN DE DESPACHO: " & dgv_despachos.CurrentRow.Cells(7).Value.ToString() & " COMUNA: " & dgv_despachos.CurrentRow.Cells(6).Value.ToString() & " / " & dgv_despachos.CurrentRow.Cells(10).Value.ToString()
                Else
                    txt_observacion.Text = "DIRECCIÓN DE DESPACHO: " & dgv_despachos.CurrentRow.Cells(7).Value.ToString() & " COMUNA: " & dgv_despachos.CurrentRow.Cells(6).Value.ToString()
                End If
            End If

            txt_email.Text = dgv_clientes.CurrentRow.Cells(9).Value.ToString()
        End If
        
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv_fecha()
        'actualizar_dgv_fecha_ejecutivos()
    End Sub
    Sub actualizar_dgv_fecha()
        dgv_despachos.DataSource = Nothing

        If Not dgv_despachos.Columns("col_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            dgv_despachos.Columns.Remove("col_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        Dim fecha, fecha2 As String

        fecha = Me.txt_fecha.Value.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")

        fecha2 = Me.dtp_fecha_in.Value.ToShortDateString
        fecha2 = Format(CDate(fecha2), "yyyy/MM/dd")

        dgv_despachos.DataSource = nue_cur.listar8(fecha, fecha2)

        If dgv_despachos.Columns("col_ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_despachos.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "col_ver"
            col.UseColumnTextForButtonValue = True
        End If

        ' Columnas No visibles
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(10).Visible = False

        ' Titulo columnas
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(2).HeaderText = "N° de Factura"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(4).HeaderText = "Fecha"
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"

        ' Fromatos celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"

        ' Dimensión celdas
        dgv_despachos.Columns(1).Width = 55
        dgv_despachos.Columns(2).Width = 50
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(4).Width = 70
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(9).Width = 60
        dgv_despachos.Columns("col_ver").Width = 60 ' Boton VER

        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineación titulos columnas

        ' Alineación celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If nue_cur.descripcion_total(txt_fecha.Text, dtp_fecha_in.Text) <> "" Then
            txt_suma_dia.Text = nue_cur.descripcion_total(txt_fecha.Text, dtp_fecha_in.Text)
            txt_suma_dia.Text = Format(CDbl(txt_suma_dia.Text), "###,##0.")
        Else
            txt_suma_dia.Text = 0
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_factura.Text <> "" Then
            nue_cur.modificar(txt_id.Text, txt_factura.Text)
            actualizar_dgv_fecha()
        Else
            MessageBox.Show("FALTA LLENAR EL CAMPO DEL N° DE FACTURA")
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If chk_pedido.Checked = True Then
            actualizar_dgv_fecha_pedido()
        ElseIf chk_factura.Checked = True Then
            actualizar_dgv_fecha_factura()
        End If
    End Sub

    Private Sub chk_factura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_factura.CheckedChanged
        If chk_factura.Checked = True Then
            chk_pedido.Checked = False
        Else
            chk_pedido.Checked = True
        End If
    End Sub

    Private Sub chk_pedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pedido.CheckedChanged
        If chk_pedido.Checked = True Then
            chk_factura.Checked = False
        Else
            chk_factura.Checked = True
        End If
    End Sub
    Sub actualizar_dgv_fecha_pedido()
        dgv_despachos.DataSource = Nothing

        If Not dgv_despachos.Columns("col_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            dgv_despachos.Columns.Remove("col_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        dgv_despachos.DataSource = nue_cur.listar9(txt_buscar.Text)

        If dgv_despachos.Columns("col_ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_despachos.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "col_ver"
            col.UseColumnTextForButtonValue = True
        End If

        ' Columnas No visibles
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False

        ' Titulo columnas
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(2).HeaderText = "N° de Factura"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"

        ' Formatos celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"

        ' Dimensión celdas
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(9).Width = 60

        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineación titulos columnas

        ' Alineación celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Sub actualizar_dgv_fecha_factura()
        dgv_despachos.DataSource = Nothing

        If Not dgv_despachos.Columns("col_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            dgv_despachos.Columns.Remove("col_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        dgv_despachos.DataSource = nue_cur.listar10(txt_buscar.Text)

        If dgv_despachos.Columns("col_ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_despachos.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "col_ver"
            col.UseColumnTextForButtonValue = True
        End If

        ' Columnas No visibles
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(10).Visible = False

        ' Titulo columnas
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(2).HeaderText = "N° de Factura"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"

        ' Fromatos celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"

        ' Dimensión celdas
        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(9).Width = 60

        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineación titulos columnas

        ' Alineación celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CR_Resumen_ejecutivos2.Show()
    End Sub

    Private Sub btn_informe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe1.Click
        If txt_pedido.Text <> "" Then
            CR_guia_de_despacho4.Show()
        Else
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txt_pedido.Text <> "" And txt_factura.Text = 0 Then
            ' Función que verifica el pedido

            'MsgBox(nueva_venta.verifica_pedido_unico(txt_pedido.Text))

            If (nueva_venta.verifica_pedido_unico(txt_pedido.Text)) Then
                MsgBox("Duplicidad de pedido " & txt_pedido.Text & ", favor volver a generar el pedido.")
                Exit Sub
            End If

            If (nueva_venta.verifica_valor_pedido(txt_pedido.Text) <> 0) Then
                MsgBox("Los valores del pedido " & txt_pedido.Text & ", favor volver a generar el pedido.")
                Exit Sub
            End If

            'Exit Sub

            contador = contador + 1
            Dim sRenglon As String = Nothing
            Dim strStreamW As Stream = Nothing
            Dim strStreamWriter As StreamWriter = Nothing
            Dim ContenidoArchivo As String = Nothing
            ' Donde guardamos los paths de los archivos que se va a utilizar
            Dim PathArchivo As String
            Dim i As Integer
            Dim forma_pago As String
            Dim fecha_emision, fecha_vencimiento, tipo_pago As String
            Dim telefonos, rut_recep, razon_recep, forma_pago2, toma_pedido, giro_recep, email_recep, direccion_recep, comuna_recep, ciudad_recep As String
            Dim dias, folio, Id_folio As Integer

            If dgv_despachos2.Rows(0).Cells(22).Value.ToString() <> "" Then
                dias = CInt(dgv_despachos2.Rows(0).Cells(22).Value.ToString())
            Else
                dias = 1
            End If

            folio = nue_cur.buscar_folio() + 1

            If folio = 1 Then
                MessageBox.Show("TIENE QUE SOLICITAR MÁS FOLIOS DE FACTURA")
            Else
                Do While nue_cur.verificar_folio(folio) = True
                    folio = folio + 1
                Loop

                If contador = 1 Then
                    contador = contador + 1
                    txt_factura.Text = folio
                    nue_cur.modificar(txt_id.Text, txt_factura.Text)
                    actualizar_dgv_fecha()
                    Dim i_desp As Integer = 0

                    'Elige lo desplegado  en la tabla.

                    Do While dgv_despachos.Rows(i_desp).Cells(1).Value.ToString() <> txt_pedido.Text
                        i_desp = i_desp + 1
                    Loop

                    If dgv_despachos.Rows(i_desp).Cells(2).Value.ToString() = 0 Or dgv_despachos.Rows(i_desp).Cells(2).Value.ToString() = "0" Then
                        MsgBox("ERROR DE CONEXIÓN CON INTERNET, FAVOR REVISAR EL PEDIDO N°" + txt_pedido.Text)
                    Else

                        fecha_emision = DateTime.Today.ToString("yyyy-MM-dd")
                        fecha_vencimiento = DateTime.Today.AddDays(dias).ToString("yyyy-MM-dd")
                        rut_recep = dgv_clientes.Rows(0).Cells(1).Value.ToString()
                        razon_recep = dgv_clientes.Rows(0).Cells(2).Value.ToString()

                        If dgv_clientes.Rows(0).Cells(24).Value.ToString() = "" Then
                            telefonos = dgv_clientes.Rows(0).Cells(5).Value.ToString()
                        Else
                            telefonos = dgv_clientes.Rows(0).Cells(24).Value.ToString()
                        End If
                        forma_pago2 = dgv_despachos2.Rows(0).Cells(23).Value.ToString()
                        toma_pedido = dgv_despachos.Rows(i_desp).Cells(5).Value.ToString()

                        giro_recep = dgv_clientes.Rows(0).Cells(34).Value.ToString()
                        email_recep = dgv_clientes.Rows(0).Cells(9).Value.ToString()
                        direccion_recep = dgv_clientes.Rows(0).Cells(3).Value.ToString()
                        comuna_recep = dgv_clientes.Rows(0).Cells(4).Value.ToString()
                        ciudad_recep = dgv_clientes.Rows(0).Cells(26).Value.ToString()

                        Try
                            If Directory.Exists("C:\Acepta\DTEService\input-produccion") = True Then
                                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                                PathArchivo = "C:\Acepta\DTEService\input-produccion\" & txt_factura.Text & ".txt" ' Se determina el nombre del archivo con el N° de pedido
                                strStreamW = File.Create(PathArchivo) ' Creamos el archivo
                                strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
                                'escribimos en el archivo
                                '(forma de pago --> 1 Contado 2 Crédito)
                                tipo_pago = dgv_despachos2.Rows(0).Cells(23).Value.ToString()
                                If tipo_pago = "Efectivo" Or tipo_pago = "Efectivo o Transferencia" Or tipo_pago = "Transferencia" Then
                                    forma_pago = 1
                                    dias = 0
                                    fecha_vencimiento = DateTime.Today.AddDays(dias).ToString("yyyy-MM-dd")
                                Else
                                    forma_pago = 2
                                End If
                                strStreamWriter.WriteLine("33|" & folio & "|" & fecha_emision & "||2||" & forma_pago & "|" & fecha_vencimiento & "|||}")
                                strStreamWriter.WriteLine("96956180-8|PAPIRO S.A|Com. Prod. Derivados de Papel. Plástico y Equipos Tecnológicos e Iluminación|513940|||Alberto Riesco 0223 Bodega 1|Huechuraba|Santiago||}")
                                strStreamWriter.WriteLine(rut_recep & "||" & razon_recep & "|" & giro_recep & "|" & email_recep & "|" & direccion_recep & "|" & comuna_recep & "|" & ciudad_recep & "||}")
                                strStreamWriter.WriteLine("|||||}")
                                strStreamWriter.WriteLine(CInt(txt_total.Text) & "|0|19|" & CInt(txt_iva.Text) & "|" & CInt(txt_total2.Text) & "|||||||||||||}")
                                strStreamWriter.WriteLine("~")

                                'strStreamWriter.WriteLine("|SPRAYER ENV.PERFUMERO|PRODUCTOS CON ENVASE ALTERNATIVO|90|UNI|2000|||180000|SPRA1001|}")
                                Dim nombre, descripcion, cantidad, unidad, precio, total, codigo As String
                                If dgv_despachos2.Rows.Count > 0 Then
                                    For i = 0 To dgv_despachos2.Rows.Count - 1
                                        nombre = dgv_despachos2.Rows(i).Cells(13).Value.ToString()
                                        descripcion = dgv_despachos2.Rows(i).Cells(10).Value.ToString()
                                        cantidad = dgv_despachos2.Rows(i).Cells(15).Value.ToString()
                                        cantidad = cantidad.Replace(",", ".")
                                        If dgv_despachos2.Rows(i).Cells(39).Value.ToString() <> "" Then
                                            unidad = dgv_despachos2.Rows(i).Cells(39).Value.ToString()
                                        Else
                                            unidad = "UNI"
                                        End If
                                        precio = dgv_despachos2.Rows(i).Cells(28).Value.ToString()
                                        precio = precio.Replace(",", ".")
                                        total = dgv_despachos2.Rows(i).Cells(19).Value.ToString()
                                        total = total.Replace(",", ".")
                                        codigo = dgv_despachos2.Rows(i).Cells(11).Value.ToString()
                                        strStreamWriter.WriteLine("|" & nombre & " " & descripcion & "||" & cantidad & "|" & unidad & "|" & precio & "|||" & total & "|" & codigo & "|}")
                                    Next i
                                End If

                                strStreamWriter.WriteLine("~")
                                strStreamWriter.WriteLine("|||||}")
                                strStreamWriter.WriteLine("~")
                                strStreamWriter.WriteLine("|||||||}")
                                strStreamWriter.WriteLine("~")
                                strStreamWriter.WriteLine("" & forma_pago2 & "|" & telefonos & "|" & toma_pedido & "|NP:" & txt_pedido.Text & " HORA DE EMISIÓN: " & txt_hora.Text & " " & txt_observacion.Text & "|||||||NPI2E2303 (HP Laserjet MFP M426fdw)|2|}")
                                strStreamWriter.WriteLine("~")
                                strStreamWriter.WriteLine("\")
                                strStreamWriter.Close() ' Cerramos
                                MessageBox.Show("FACTURA CREADA CON ÉXITO")

                                'enviar_mail()

                                Id_folio = nue_cur.ult_id()
                                nue_cur.modificar_folio(Id_folio, txt_factura.Text)
                                nue_cur.modificar_fecha(txt_pedido.Text, fecha_emision)
                                txt_id.Clear()
                                txt_factura.Clear()
                                txt_pedido.Clear()
                                'actualizar_dgv_fecha()
                            Else
                                MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA FACTURAR")
                            End If
                        Catch ex As Exception
                            MsgBox("Error al Guardar la informacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                            strStreamWriter.Close() ' cerramos
                        End Try
                    End If
                Else

                End If
            End If
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR O YA ESTA CREADA LA FACTURA PARA ESTE DOCUMENTO")
        End If
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        txt_iva.Text = FormatNumber(txt_total.Text * 0.19, 0)
        txt_total2.Text = FormatNumber(CInt(txt_total.Text) + CInt(txt_iva.Text), 0)
    End Sub

    Sub actualizar_dgv_cliente()
        Dim rut As String
        rut = dgv_despachos2.Rows(0).Cells(2).Value.ToString()
        dgv_clientes.DataSource = nue_cur.listar12(rut)
    End Sub

    Sub actualizar_dgv_rutas()
        Dim pedido As String
        pedido = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        dgv_rutas.DataSource = nue_cur.listar16(pedido)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        actualizar_pendientes()
    End Sub
    Sub actualizar_pendientes()
        dgv_pendientes.DataSource = Nothing

        If Not dgv_pendientes.Columns("col_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            dgv_pendientes.Columns.Remove("col_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        dgv_pendientes.DataSource = nue_cur.listar13()

        If dgv_pendientes.Columns("col_ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_pendientes.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "col_ver"
            col.UseColumnTextForButtonValue = True
        End If

        ' Columnas NO visibles
        dgv_pendientes.Columns(0).Visible = False
        dgv_pendientes.Columns(6).Visible = False
        dgv_pendientes.Columns(7).Visible = False
        dgv_pendientes.Columns(10).Visible = False

        ' Titulo de las columnas
        dgv_pendientes.Columns(1).HeaderText = "N° de Folio"
        dgv_pendientes.Columns(2).HeaderText = "N° de Factura"
        dgv_pendientes.Columns(3).HeaderText = "Cliente"
        dgv_pendientes.Columns(4).HeaderText = "Fecha"
        dgv_pendientes.Columns(5).HeaderText = "Toma Pedido"
        dgv_pendientes.Columns(6).HeaderText = "Comuna"
        dgv_pendientes.Columns(7).HeaderText = "Dirección"
        dgv_pendientes.Columns(8).HeaderText = "Hora"
        dgv_pendientes.Columns(9).HeaderText = "Venta Neta"

        ' Formato de celdas
        dgv_pendientes.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_pendientes.Columns(9).DefaultCellStyle.Format = "###,###,###"

        ' Dimenciones columnas
        dgv_pendientes.Columns(1).Width = 55
        dgv_pendientes.Columns(2).Width = 50
        dgv_pendientes.Columns(3).Width = 300
        dgv_pendientes.Columns(4).Width = 70
        dgv_pendientes.Columns(5).Width = 90
        dgv_pendientes.Columns(8).Width = 50
        dgv_pendientes.Columns(9).Width = 60
        dgv_pendientes.Columns("col_ver").Width = 60

        dgv_pendientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alineamiento de los titulos de las columnas

        ' Alineamiento de las celdas
        dgv_pendientes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub dgv_pendientes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pendientes.CellClick
        If e.ColumnIndex = 11 Then ' Solamente entra en la condicional si se hace click en el botón indexado con el número 11
            Dim filaNumero As Integer = dgv_despachos.Rows(e.RowIndex).Cells(1).Value ' Variable contenedora del identificador sobre el que se hace click
            Folio_ruta = filaNumero
            CR_guia_de_despacho_ruta.Show()
        End If

        'Dim numero_folio As Double
        'numero_folio = dgv_pendientes.CurrentRow.Cells(1).Value.ToString()
        'dgv_despachos2.DataSource = nue_cur.listar7(numero_folio)
        'dgv_despachos2.Columns(0).Visible = False
        'dgv_despachos2.AllowUserToOrderColumns = True
        'dgv_despachos2.Columns(1).Visible = False
        'dgv_despachos2.Columns(1).Width = 200
        'dgv_despachos2.Columns(2).Visible = False
        'dgv_despachos2.Columns(3).Visible = False
        'dgv_despachos2.Columns(4).Visible = False
        'dgv_despachos2.Columns(5).Visible = False
        'dgv_despachos2.Columns(6).Visible = False
        'dgv_despachos2.Columns(7).Visible = False
        'dgv_despachos2.Columns(8).Visible = False
        'dgv_despachos2.Columns(9).Visible = False
        'dgv_despachos2.Columns(10).HeaderText = "Medidas"
        'dgv_despachos2.Columns(11).Visible = False
        'dgv_despachos2.Columns(12).Visible = False
        'dgv_despachos2.Columns(13).HeaderText = "Descripción"
        'dgv_despachos2.Columns(13).Width = 210
        'dgv_despachos2.Columns(14).Visible = False
        'dgv_despachos2.Columns(14).DefaultCellStyle.Format = "##,###.##"
        'dgv_despachos2.Columns(15).HeaderText = "Cantidad"
        'dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(16).Visible = False
        'dgv_despachos2.Columns(17).Visible = False
        'dgv_despachos2.Columns(18).Visible = False
        'dgv_despachos2.Columns(18).DefaultCellStyle.Format = "##,###."
        'dgv_despachos2.Columns(19).HeaderText = "Venta"
        'dgv_despachos2.Columns(19).DefaultCellStyle.Format = "##,###."
        'dgv_despachos2.Columns(20).Visible = False
        'dgv_despachos2.Columns(21).Visible = False
        'dgv_despachos2.Columns(22).Visible = False
        'dgv_despachos2.Columns(23).Visible = False
        'dgv_despachos2.Columns(24).Visible = False
        'dgv_despachos2.Columns(25).Visible = False
        'dgv_despachos2.Columns(26).Visible = False
        'dgv_despachos2.Columns(27).Visible = False
        'dgv_despachos2.Columns(27).DefaultCellStyle.Format = "##,###."
        'dgv_despachos2.Columns(28).HeaderText = "Precio Un."
        'dgv_despachos2.Columns(28).DefaultCellStyle.Format = "##,###."
        'dgv_despachos2.Columns(31).Visible = False
        'dgv_despachos2.Columns(30).Visible = False
        'dgv_despachos2.Columns(29).Visible = False
        'dgv_despachos2.Columns(32).Visible = False
        'dgv_despachos2.Columns(33).Visible = False
        'dgv_despachos2.Columns(34).Visible = False
        'dgv_despachos2.Columns(35).Visible = False
        'dgv_despachos2.Columns(36).Visible = False
        'dgv_despachos2.Columns(37).Visible = False
        'dgv_despachos2.Columns(38).Visible = False
        'dgv_despachos2.Columns(39).Visible = False
        'dgv_despachos2.Columns(34).DefaultCellStyle.Format = "###,###,###"
        'dgv_despachos2.Columns(31).DisplayIndex = 1
        'dgv_despachos2.Columns(13).DisplayIndex = 2
        'dgv_despachos2.Columns(10).DisplayIndex = 3
        'dgv_despachos2.Columns(15).DisplayIndex = 4
        'dgv_despachos2.Columns(18).DisplayIndex = 5
        'dgv_despachos2.Columns(14).DisplayIndex = 6
        'dgv_despachos2.Columns(28).DisplayIndex = 7
        'dgv_despachos2.Columns(19).DisplayIndex = 8
        'dgv_despachos2.Columns(30).DisplayIndex = 9
        'dgv_despachos2.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_despachos2.Columns(30).Width = 50
        'dgv_despachos2.Columns(34).Width = 50
        'dgv_despachos2.Columns(10).Width = 60
        'dgv_despachos2.Columns(15).Width = 50
        'dgv_despachos2.Columns(28).Width = 60
        'dgv_despachos2.Columns(31).Width = 65
        'dgv_despachos2.Columns(18).Width = 60
        'dgv_despachos2.Columns(19).Width = 60
        'dgv_despachos2.Columns(14).Width = 40
        'dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'txt_pedido.Clear()
        'txt_factura.Clear()
        'txt_pedido.Text = dgv_pendientes.CurrentRow.Cells(1).Value.ToString()
        'If dgv_pendientes.CurrentRow.Cells(2).Value.ToString() <> "" Then
        '    txt_factura.Text = dgv_pendientes.CurrentRow.Cells(2).Value.ToString()
        'Else
        'End If
        'txt_id.Text = dgv_pendientes.CurrentRow.Cells(0).Value.ToString()
        'txt_total.Text = dgv_pendientes.CurrentRow.Cells(9).Value.ToString()
        'txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
        'actualizar_dgv_cliente()

        'If dgv_clientes.Rows(0).Cells(3).Value.ToString() = dgv_pendientes.CurrentRow.Cells(7).Value.ToString() Then
        '    txt_observacion.Text = dgv_pendientes.CurrentRow.Cells(10).Value.ToString()
        'Else
        '    If dgv_pendientes.CurrentRow.Cells(10).Value.ToString() <> "" Then
        '        txt_observacion.Text = "DIRECCIÓN DE DESPACHO: " & dgv_pendientes.CurrentRow.Cells(7).Value.ToString() & " COMUNA: " & dgv_pendientes.CurrentRow.Cells(6).Value.ToString() & " / " & dgv_pendientes.CurrentRow.Cells(10).Value.ToString()
        '    Else
        '        txt_observacion.Text = "DIRECCIÓN DE DESPACHO: " & dgv_pendientes.CurrentRow.Cells(7).Value.ToString() & " COMUNA: " & dgv_pendientes.CurrentRow.Cells(6).Value.ToString()
        '    End If
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        CR_resumen_autorizaciones.Show()
    End Sub

    Private Sub btn_reemitir_Click(sender As Object, e As EventArgs) Handles btn_reemitir.Click
        If MessageBox.Show("¿Seguro que desea volver a emitir este documento?", "Confirmación de procedimiento.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            If txt_pedido.Text <> "" And txt_factura.Text <> 0 Then
                Dim sRenglon As String = Nothing
                Dim strStreamW As Stream = Nothing
                Dim strStreamWriter As StreamWriter = Nothing
                Dim ContenidoArchivo As String = Nothing
                Dim PathArchivo As String
                Dim i As Integer
                Dim forma_pago As String
                Dim fecha_emision, fecha_vencimiento, tipo_pago As String
                Dim telefonos, rut_recep, razon_recep, forma_pago2, toma_pedido, giro_recep, email_recep, direccion_recep, comuna_recep, ciudad_recep As String
                Dim dias, folio, Id_folio, folio_ver As Integer

                If dgv_despachos2.Rows(0).Cells(22).Value.ToString() <> "" Then
                    dias = CInt(dgv_despachos2.Rows(0).Cells(22).Value.ToString())
                Else
                    dias = 1
                End If

                nue_cur.insertar3(Nombre_Obra, DateTime.Today.ToString("yyyy-MM-dd"), txt_hora.Text, "Factura", txt_pedido.Text, txt_factura.Text)

                folio = txt_factura.Text
                Dim i_desp As Integer = 0
                Do While dgv_despachos.Rows(i_desp).Cells(1).Value.ToString() <> txt_pedido.Text
                    i_desp = i_desp + 1
                Loop
                fecha_emision = DateTime.Today.ToString("yyyy-MM-dd")
                fecha_vencimiento = DateTime.Today.AddDays(dias).ToString("yyyy-MM-dd")
                rut_recep = dgv_clientes.Rows(0).Cells(1).Value.ToString()
                razon_recep = dgv_clientes.Rows(0).Cells(2).Value.ToString()

                If dgv_clientes.Rows(0).Cells(24).Value.ToString() = "" Then
                    telefonos = dgv_clientes.Rows(0).Cells(5).Value.ToString()
                Else
                    telefonos = dgv_clientes.Rows(0).Cells(24).Value.ToString()
                End If
                forma_pago2 = dgv_despachos2.Rows(0).Cells(23).Value.ToString()
                toma_pedido = dgv_despachos.Rows(i_desp).Cells(5).Value.ToString()

                giro_recep = dgv_clientes.Rows(0).Cells(34).Value.ToString()
                email_recep = dgv_clientes.Rows(0).Cells(9).Value.ToString()
                direccion_recep = dgv_clientes.Rows(0).Cells(3).Value.ToString()
                comuna_recep = dgv_clientes.Rows(0).Cells(4).Value.ToString()
                ciudad_recep = dgv_clientes.Rows(0).Cells(26).Value.ToString()
                Try
                    If Directory.Exists("C:\Acepta\DTEService\input-produccion") = True Then
                        Windows.Forms.Cursor.Current = Cursors.WaitCursor
                        PathArchivo = "C:\Acepta\DTEService\input-produccion\" & txt_factura.Text & ".txt" ' Se determina el nombre del archivo con el N° de pedido
                        strStreamW = File.Create(PathArchivo) ' Creamos el archivo
                        strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
                        'Escribimos en el archivo
                        '(forma de pago --> 1 Contado 2 Crédito)
                        tipo_pago = dgv_despachos2.Rows(0).Cells(23).Value.ToString()
                        If tipo_pago = "Efectivo" Or tipo_pago = "Efectivo o Transferencia" Or tipo_pago = "Transferencia" Then
                            forma_pago = 1
                            dias = 0
                            fecha_vencimiento = DateTime.Today.AddDays(dias).ToString("yyyy-MM-dd")
                        Else
                            forma_pago = 2
                        End If
                        strStreamWriter.WriteLine("33|" & folio & "|" & fecha_emision & "||2||" & forma_pago & "|" & fecha_vencimiento & "|||}")
                        strStreamWriter.WriteLine("96956180-8|PAPIRO S.A|Com. Prod. Derivados de Papel. Plástico y Equipos Tecnológicos e Iluminación|513940|||Alberto Riesco 0223 Bodega 1|Huechuraba|Santiago||}")
                        strStreamWriter.WriteLine(rut_recep & "||" & razon_recep & "|" & giro_recep & "|" & email_recep & "|" & direccion_recep & "|" & comuna_recep & "|" & ciudad_recep & "||}")
                        strStreamWriter.WriteLine("|||||}")
                        strStreamWriter.WriteLine(CInt(txt_total.Text) & "|0|19|" & CInt(txt_iva.Text) & "|" & CInt(txt_total2.Text) & "|||||||||||||}")
                        strStreamWriter.WriteLine("~")

                        Dim nombre, descripcion, cantidad, unidad, precio, total, codigo As String
                        If dgv_despachos2.Rows.Count > 0 Then
                            For i = 0 To dgv_despachos2.Rows.Count - 1
                                nombre = dgv_despachos2.Rows(i).Cells(13).Value.ToString()
                                descripcion = dgv_despachos2.Rows(i).Cells(10).Value.ToString()
                                cantidad = dgv_despachos2.Rows(i).Cells(15).Value.ToString()
                                cantidad = cantidad.Replace(",", ".")
                                If dgv_despachos2.Rows(i).Cells(39).Value.ToString() <> "" Then
                                    unidad = dgv_despachos2.Rows(i).Cells(39).Value.ToString()
                                Else
                                    unidad = "UNI"
                                End If
                                precio = dgv_despachos2.Rows(i).Cells(28).Value.ToString()
                                precio = precio.Replace(",", ".")
                                total = dgv_despachos2.Rows(i).Cells(19).Value.ToString()
                                total = total.Replace(",", ".")
                                codigo = dgv_despachos2.Rows(i).Cells(11).Value.ToString()
                                strStreamWriter.WriteLine("|" & nombre & " " & descripcion & "||" & cantidad & "|" & unidad & "|" & precio & "|||" & total & "|" & codigo & "|}")
                            Next i
                        End If

                        strStreamWriter.WriteLine("~")
                        strStreamWriter.WriteLine("|||||}")
                        strStreamWriter.WriteLine("~")
                        strStreamWriter.WriteLine("|||||||}")
                        strStreamWriter.WriteLine("~")
                        strStreamWriter.WriteLine("" & forma_pago2 & "|" & telefonos & "|" & toma_pedido & "|NP:" & txt_pedido.Text & " HORA DE EMISIÓN: " & txt_hora.Text & " " & txt_observacion.Text & "|||||||||}")
                        strStreamWriter.WriteLine("~")
                        strStreamWriter.WriteLine("\")
                        strStreamWriter.Close() ' Cerramos

                        folio_ver = nue_cur.ult_ver()
                        If folio > folio_ver Then
                            Id_folio = nue_cur.ult_id()
                            nue_cur.modificar_folio(Id_folio, txt_factura.Text)
                        End If
                        MessageBox.Show("SE HA VUELTO A EMITIR LA FACTURA")
                        nue_cur.modificar_fecha(txt_pedido.Text, fecha_emision)
                        txt_id.Clear()
                        txt_factura.Clear()
                        txt_pedido.Clear()
                    Else
                        MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA FACTURAR")
                    End If
                Catch ex As Exception
                    MsgBox("Error al Guardar la informacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                    strStreamWriter.Close() ' cerramos
                End Try
            Else
                MessageBox.Show("ESTE DOCUMENTO ESTA COMO NO EMITIDO")
            End If
        End If
    End Sub

    Private Sub dgv_despachos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_despachos.CellContentClick
        If e.ColumnIndex = 11 Then ' Solamente entra en la condicional si se hace click en el botón indexado con el número 11
            Dim filaNumero As Integer = dgv_despachos.Rows(e.RowIndex).Cells(1).Value ' Variable contenedora del identificador sobre el que se hace click
            Folio_ruta = filaNumero
            CR_guia_de_despacho_ruta.Show()
        End If
    End Sub

    Private Sub verificar_pedido(pedido)
        If (Not nueva_venta.verifica_pedido_unico(pedido)) Then

        End If
    End Sub

    Sub enviar_mail()
        'Dim smtp As New System.Net.Mail.SmtpClient
        'Dim correo As New System.Net.Mail.MailMessage
        'Dim adjunto As System.Net.Mail.Attachment

        'With smtp
        '    .Port = 587
        '    .EnableSsl = True
        '    .Host = "smtp.gmail.com"
        '    .UseDefaultCredentials = False
        '    .Credentials = New System.Net.NetworkCredential("gsolis@cfv.cl", "greell1930")
        '    .EnableSsl = False
        'End With
        'adjunto = New System.Net.Mail.Attachment("C:\Users\German\Desktop\Adjunto.pdf")
        'With correo
        '    .From = New System.Net.Mail.MailAddress("gsolis@cfv.cl")
        '    .To.Add("german.solis@alumnos.usm.cl")
        '    .Subject = "Factura Papiro S.A."
        '    .Body = "<strong>Señores...  Su pedido se encuentra en ruta de despacho, con el documento/s .... El transportista asignado es. Si su pedido es dentro de Santiago, el tiempo estimado de llegada es de 3 horas. Atentamente Logística Suministros Gráficos S.A. Este mensaje ha sido generado automáticamente. Por favor no responda a este correo.</strong>"
        '    .IsBodyHtml = True
        '    .Priority = System.Net.Mail.MailPriority.Normal
        '    .Attachments.Add(adjunto)
        'End With

        ''Try
        'smtp.Send(correo)
        ''    MessageBox.Show("Su mensaje de correo ha sido enviado.", _
        ''                    "Correo enviado", _
        ''                     MessageBoxButtons.OK)
        ''Catch ex As Exception
        ''    MessageBox.Show("Error: " & ex.Message, _
        ''                    "Error al enviar correo", _
        ''                     MessageBoxButtons.OK)
        ''End Try


        Try
            Dim insMail As New System.Net.Mail.MailMessage
            'Dim adjunto As System.Net.Mail.Attachment

            'adjunto = New System.Net.Mail.Attachment("C:\Users\USUARIO\Desktop\Adjunto.pdf")
            With insMail

                .Subject = "Factura Papiro S.A."
                .IsBodyHtml = True 'envia el mensaje como html

                Dim nombre, descripcion, cantidad, unidad, precio, total, codigo, texto As String
                texto = ""

                If dgv_despachos2.Rows.Count > 0 Then
                    For i = 0 To dgv_despachos2.Rows.Count - 1
                        nombre = dgv_despachos2.Rows(i).Cells(13).Value.ToString()
                        descripcion = dgv_despachos2.Rows(i).Cells(10).Value.ToString()
                        cantidad = dgv_despachos2.Rows(i).Cells(15).Value.ToString()
                        cantidad = cantidad.Replace(",", ".")
                        If dgv_despachos2.Rows(i).Cells(39).Value.ToString() <> "" Then
                            unidad = dgv_despachos2.Rows(i).Cells(39).Value.ToString()
                        Else
                            unidad = "UNI"
                        End If
                        precio = dgv_despachos2.Rows(i).Cells(28).Value.ToString()
                        precio = precio.Replace(",", ".")
                        total = dgv_despachos2.Rows(i).Cells(19).Value.ToString()
                        total = total.Replace(",", ".")
                        codigo = dgv_despachos2.Rows(i).Cells(11).Value.ToString()
                        texto = texto + "<br>" + ("<strong> Producto: </strong>" & nombre & " " & descripcion & "<strong> Cantidad: </strong>" & cantidad & "<strong> Unidad: </strong>" & unidad & "<strong> Precio: </strong>" & precio & "<strong> Total: </strong>" & total & "")
                    Next i
                End If

                .Body = "Señores " + dgv_clientes.Rows(0).Cells(2).Value.ToString() + "<br>          Su pedido se encuentra en ruta de despacho, con la Factura N°" + dgv_despachos.CurrentRow.Cells(2).Value.ToString() + ". El transportista asignado es " + dgv_rutas.Rows(0).Cells(2).Value.ToString() + ". Si su pedido es dentro de Santiago, el tiempo estimado de llegada es de 3 horas. A continuación un resumen de su pedido: <br>" + texto + " <br> <br> Atentamente Papiro S.A. <br> <br> </i> Este mensaje ha sido generado automáticamente. Por favor no responda a este correo.</i>"
                .From = New MailAddress("facturapapiro@papirochile.cl")
                .To.Add(txt_email.Text)
                '.Attachments.Add(adjunto)

            End With
            Dim smtp As New System.Net.Mail.SmtpClient
            'smtp.Host = "smtp.gmail.com"
            'smtp.Port = 587
            smtp.Host = "mail.papirochile.cl"
            smtp.Port = 26
            smtp.EnableSsl = True
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential("facturapapiro@papirochile.cl", "Papi0223#")


            smtp.Send(insMail)
            MessageBox.Show("SU MENSAJE DE CORREO HA SIDO ENVIADO EXITOSAMENTE.", _
                            "CORREO ENVIADO", _
                             MessageBoxButtons.OK)
        Catch ex As Exception

            nue_cur.insertar4(dgv_despachos.CurrentRow.Cells(1).Value.ToString(), "F:" + dgv_despachos.CurrentRow.Cells(2).Value.ToString(), dgv_despachos2.Rows(0).Cells(2).Value.ToString(), dgv_despachos.CurrentRow.Cells(3).Value.ToString(), txt_email.Text)

            MessageBox.Show("Error: " & ex.Message, _
                            "Error al enviar correo", _
                             MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If txt_factura.Text <> 0 Then
            txt_email.Text = txt_email2.Text
            enviar_mail()
        Else
            MessageBox.Show("SELECCIONAR DOCUMENTO FACTURADO")
        End If
    End Sub

    Private Sub btn_error_Click(sender As Object, e As EventArgs) Handles btn_error.Click
        CR_log_emails.Show()
    End Sub
End Class

