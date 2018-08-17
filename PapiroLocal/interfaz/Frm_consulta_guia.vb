Imports System.Globalization
Imports System.IO
Imports System.Net.Mail 'referencia
Imports System.Web.Mail
Public Class Frm_consulta_guia

    Dim nue_cur As New clases.guia_despacho
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim contador As Integer
    Dim indicador_traslado As Integer

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Me.WindowState = FormWindowState.Maximized
        txt_pedido.ReadOnly = True
        txt_factura.ReadOnly = True
        txt_total.ReadOnly = True
        actualizar_dgv_fecha()
        txt_iva.ReadOnly = True
        txt_total2.ReadOnly = True
        If filtro_guia = 0 Then
            gp_autorizar.Visible = True
            gp_anular.Visible = True
            gp_relacionar.Visible = False
            gp_reemitir.Visible = False
        ElseIf filtro_guia = 1 Then
            gp_autorizar.Visible = False
            gp_relacionar.Visible = True
            gp_reemitir.Visible = True
            gp_anular.Visible = True
        End If
    End Sub

    Sub actualizar_dgv()
        dgv_despachos.DataSource = nue_cur.listar6()
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(2).Visible = False
        dgv_despachos.Columns(5).Visible = False

        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(4).HeaderText = "Hora"

        dgv_despachos.Columns(1).Width = 70
        dgv_despachos.Columns(2).Width = 70
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(4).Width = 50

        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(4).DefaultCellStyle.Format = "hh:mm"

        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        If Not e.ColumnIndex = 16 Then
            Dim numero_folio As Double
            contador = 0
            numero_folio = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
            dgv_despachos2.DataSource = nue_cur.listar27(numero_folio)

            txt_email.Clear()

            ' Columnas NO visible
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

            ' Titulo columnas
            dgv_despachos2.Columns(10).HeaderText = "Medidas"
            dgv_despachos2.Columns(13).HeaderText = "Descripción"
            dgv_despachos2.Columns(15).HeaderText = "Cantidad"
            dgv_despachos2.Columns(19).HeaderText = "Venta"
            dgv_despachos2.Columns(28).HeaderText = "Precio Un"

            ' Orden columnas
            dgv_despachos2.Columns(10).DisplayIndex = 3
            dgv_despachos2.Columns(13).DisplayIndex = 2
            dgv_despachos2.Columns(14).DisplayIndex = 6
            dgv_despachos2.Columns(15).DisplayIndex = 4
            dgv_despachos2.Columns(18).DisplayIndex = 5
            dgv_despachos2.Columns(19).DisplayIndex = 8
            dgv_despachos2.Columns(28).DisplayIndex = 7
            dgv_despachos2.Columns(30).DisplayIndex = 9
            dgv_despachos2.Columns(31).DisplayIndex = 1

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

            ' Formato celdas
            dgv_despachos2.Columns(14).DefaultCellStyle.Format = "##,###.##"
            dgv_despachos2.Columns(18).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(19).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(27).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(28).DefaultCellStyle.Format = "##,###."
            dgv_despachos2.Columns(34).DefaultCellStyle.Format = "###,###,###"

            ' Alinacion celdas
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

            dgv_despachos2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinación titulo columnas

            'txt_pedido.Clear()
            'txt_factura.Clear()
            ' txt_pedido => Folio guía
            txt_pedido.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()

            txt_pedido2.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
            txt_folio2.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
            cod_cur = dgv_despachos.CurrentRow.Cells(0).Value.ToString()

            ' txt_factura => Número Guía
            If dgv_despachos.CurrentRow.Cells(2).Value.ToString() <> "" Then
                txt_factura.Text = dgv_despachos.CurrentRow.Cells(2).Value.ToString()
                txt_guia2.Text = dgv_despachos.CurrentRow.Cells(2).Value.ToString()
            End If

            txt_id.Text = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
            txt_total.Text = dgv_despachos.CurrentRow.Cells(9).Value.ToString()
            txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
            actualizar_dgv_cliente()
            txt_fact_ref.Text = dgv_despachos.CurrentRow.Cells(11).Value.ToString()
            txt_fecha_ref.Text = CDate(dgv_despachos.CurrentRow.Cells(12).Value.ToString())

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
    Sub actualizar_dgv_fecha()
        dgv_despachos.DataSource = Nothing

        If Not dgv_despachos.Columns("Tipo") Is Nothing Then ' Condicional negativa en la que si existe la columna TIPO.
            Dim col As New DataGridViewTextBoxColumn
            col.Name = "Tipo"
            dgv_despachos.Columns.Remove("Tipo") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If Not dgv_despachos.Columns("btn_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            Dim col As New DataGridViewTextBoxColumn
            col.Name = "Ver"
            dgv_despachos.Columns.Remove("btn_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If filtro_guia = 0 Then
            dgv_despachos.DataSource = nue_cur.listar15() ' Carga la vista de  en donde la condicion sea igual a 0 (cero)
        ElseIf filtro_guia = 1 Then
            dgv_despachos.DataSource = nue_cur.listar14()
        End If

        If dgv_despachos.Columns("Tipo") Is Nothing Then ' Condicional en la que si no existe columna TIPO entra.
            Dim col As New DataGridViewTextBoxColumn
            col.Name = "Tipo" ' Se agrega el nombre de la columna 
            dgv_despachos.Columns.Add(col) ' Se agrega columna
        End If

        If dgv_despachos.Columns("Ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_despachos.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "btn_ver"
            col.UseColumnTextForButtonValue = True
        End If

        ' Columnas NO visibles
        dgv_despachos.Columns(0).Visible = False
        dgv_despachos.Columns(6).Visible = False
        dgv_despachos.Columns(7).Visible = False
        dgv_despachos.Columns(10).Visible = False
        dgv_despachos.Columns(11).Visible = False
        dgv_despachos.Columns(12).Visible = False
        dgv_despachos.Columns(13).Visible = False
        dgv_despachos.Columns(14).Visible = False

        ' Nombre columnas
        dgv_despachos.Columns(1).HeaderText = "N° de Folio"
        dgv_despachos.Columns(2).HeaderText = "N° de Guía"
        dgv_despachos.Columns(3).HeaderText = "Cliente"
        dgv_despachos.Columns(4).HeaderText = "Fecha"
        dgv_despachos.Columns(5).HeaderText = "Toma Pedido"
        dgv_despachos.Columns(6).HeaderText = "Comuna"
        dgv_despachos.Columns(7).HeaderText = "Dirección"
        dgv_despachos.Columns(8).HeaderText = "Hora"
        dgv_despachos.Columns(9).HeaderText = "Venta Neta"

        ' Dimensión columnas
        dgv_despachos.Columns(1).Width = 55
        dgv_despachos.Columns(2).Width = 50
        dgv_despachos.Columns(3).Width = 300
        dgv_despachos.Columns(4).Width = 70
        dgv_despachos.Columns(5).Width = 90
        dgv_despachos.Columns(8).Width = 50
        dgv_despachos.Columns(9).Width = 60
        dgv_despachos.Columns(16).Width = 60 ' Boton ver guía

        ' Texto centrado de las celdas
        dgv_despachos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_despachos.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_despachos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Titulo centrado

        ' Formato 
        dgv_despachos.Columns(1).DefaultCellStyle.Format = "###,###,###"
        dgv_despachos.Columns(9).DefaultCellStyle.Format = "###,###,###"

        ' Bucle en el que itera sobre el resoltado (Cantidad de resultado encontrados)
        For x As Integer = 0 To dgv_despachos.RowCount - 1
            Dim valor As String = System.Convert.ToString(dgv_despachos.Rows(x).Cells(13).Value) ' Se convierte a String el valor de la celda iterada
            ' Agrega valor a la columna TIPO el valor dependiendo de valor de la celda de la columna tipo guia (13)
            Select Case valor
                Case "1"
                    dgv_despachos.Rows(x).Cells("Tipo").Value = "Por muestra"
                Case "2"
                    dgv_despachos.Rows(x).Cells("Tipo").Value = "Por dirección"
                Case "3"
                    dgv_despachos.Rows(x).Cells("Tipo").Value = "Cambio de material"
                Case "4"
                    dgv_despachos.Rows(x).Cells("Tipo").Value = "Por facturar"
                Case "5"
                    dgv_despachos.Rows(x).Cells("Tipo").Value = "Despacho parcial"
            End Select
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_factura.Text <> "" Then
            nue_cur.modificar(txt_id.Text, txt_factura.Text)
            actualizar_dgv_fecha()
        Else
            MessageBox.Show("FALTA LLENAR EL CAMPO DEL N° DE FACTURA")
        End If
    End Sub

    Private Sub btn_informe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_informe1.Click
        If txt_pedido.Text <> "" Then
            CR_guia_de_despacho5.Show()
        Else
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txt_pedido.Text <> "" And txt_factura.Text = 0 Then
            contador = contador + 1
            Dim sRenglon As String = Nothing
            Dim strStreamW As Stream = Nothing
            Dim strStreamWriter As StreamWriter = Nothing
            Dim ContenidoArchivo As String = Nothing
            ' Donde guardamos los paths de los archivos que se va a utilizar
            Dim PathArchivo As String
            Dim i As Integer
            Dim forma_pago As String
            Dim fecha_emision, fecha_vencimiento, tipo_pago, fecha_recep As String
            Dim telefonos, rut_recep, razon_recep, forma_pago2, toma_pedido, giro_recep, email_recep, direccion_recep, comuna_recep, ciudad_recep As String
            Dim dias, folio, Id_folio As Integer
            Dim fecha_ref As Date

            'dias = 1
            folio = nue_cur.buscar_folio_guia() + 1
            If folio = 1 Then
                MessageBox.Show("TIENE QUE SOLICITAR MÁS FOLIOS DE GUÍA DE DESPACHO")
            Else
                Do While nue_cur.verificar_folio_guias(folio) = True
                    folio = folio + 1
                Loop
                If contador = 1 Then
                    contador = contador + 1
                    txt_factura.Text = folio
                    nue_cur.modificar_guias(txt_id.Text, txt_factura.Text)
                    actualizar_dgv_fecha()
                    Dim i_desp As Integer = 0
                    Do While dgv_despachos.Rows(i_desp).Cells(1).Value.ToString() <> txt_pedido.Text
                        i_desp = i_desp + 1
                    Loop
                    If dgv_despachos.Rows(i_desp).Cells(2).Value.ToString() = 0 Or dgv_despachos.Rows(i_desp).Cells(2).Value.ToString() = "0" Then
                        MsgBox("ERROR DE CONEXIÓN CON INTERNET, FAVOR REVISAR EL PEDIDO N°" + txt_pedido.Text)
                    Else
                        fecha_ref = CDate(txt_fecha_ref.Text)
                        fecha_recep = fecha_ref.ToString("yyyy-MM-dd")
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
                                tipo_pago = dgv_despachos2.Rows(0).Cells(23).Value.ToString()
                                forma_pago = 1
                                dias = 0
                                indicador_traslado = 4
                                fecha_vencimiento = DateTime.Today.AddDays(dias).ToString("yyyy-MM-dd")
                                strStreamWriter.WriteLine("52|" & folio & "|" & fecha_emision & "||2|" & indicador_traslado & "|" & forma_pago & "|" & fecha_vencimiento & "|||}")
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
                                strStreamWriter.WriteLine("33||" & txt_fact_ref.Text & "|" & fecha_recep & "||SEGUN FACTURA " & txt_fact_ref.Text & "|}")
                                strStreamWriter.WriteLine("~")
                                strStreamWriter.WriteLine("" & forma_pago2 & "|" & telefonos & "|" & toma_pedido & "|NP:" & txt_pedido.Text & " HORA DE EMISIÓN: " & txt_hora.Text & " " & txt_observacion.Text & "|||||||||}")
                                strStreamWriter.WriteLine("~")
                                strStreamWriter.WriteLine("\")
                                strStreamWriter.Close() ' Cerramos
                                MessageBox.Show("GUÍA DE DESPACHO GENERADA CON ÉXITO")

                                Id_folio = nue_cur.ult_id_guias()
                                nue_cur.modificar_folio_guias(Id_folio, txt_factura.Text)
                                nue_cur.modificar_fecha_guias(txt_pedido.Text, fecha_emision)
                                txt_id.Clear()
                                txt_factura.Clear()
                                txt_pedido.Clear()
                                txt_fecha_ref.Clear()
                                txt_fact_ref.Clear()
                            Else
                                MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA EMITIR GUÍAS")
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
            MessageBox.Show("FALTAN CAMPOS POR LLENAR O YA ESTA EMITIDA LA GUÍA PARA ESTE DOCUMENTO")
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub dgv_despachos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_despachos.CellContentClick
        Dim filaNumero As Integer = dgv_despachos.Rows(e.RowIndex).Cells(1).Value ' Variable contenedora del identificador sobre el que se hace click
        If e.ColumnIndex = 16 Then ' Solamente entra en la condicional si se hace click en el botón indexado con el número 16
            Folio_ruta = filaNumero
            frm_cr_guia_despacho.Show()
        End If
    End Sub

    Private Sub btn_autorizar_Click(sender As Object, e As EventArgs) Handles btn_autorizar.Click
        If txt_folio2.Text <> "" Then
            nue_cur.modificar2(CInt(cod_cur), 1)
            nue_cur.insertar2(1, "Guia", txt_folio2.Text, 1, "Autoriza", Nombre_Obra, CDate(DateTime.Today), CDate(txt_hora.Text))
            actualizar_dgv_fecha()
            MsgBox("SE HA AUTORIZADO LA GUÍA DE DESPACHO")
        Else
            MsgBox("DEBE SELECCIONAR PRIMERO LA NOTA DE CRÉDITO RESPECTIVA")
        End If
    End Sub

    Private Sub btn_rechazar_Click(sender As Object, e As EventArgs) Handles btn_rechazar.Click
        If txt_folio2.Text <> "" Then
            nue_cur.modificar2(CInt(cod_cur), 2) ' Al rechazar la GD se almacena en la tabla [folio_guias] cambiando el dato de condición por dos (2).
            nue_cur.insertar2(1, "Guia", txt_folio2.Text, 2, "Rechaza", Nombre_Obra, CDate(DateTime.Today), CDate(txt_hora.Text))
            actualizar_dgv_fecha()
            MsgBox("SE HA RECHAZADO LA GUÍA DE DESPACHO")
        Else
            MsgBox("DEBE SELECCIONAR PRIMERO LA NOTA DE CRÉDITO RESPECTIVA")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar_dgv_fecha()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nue_cur.modificar3(txt_id.Text, txt_guia2.Text)
        actualizar_dgv_fecha()
    End Sub

    Private Sub btn_reemitir_Click(sender As Object, e As EventArgs) Handles btn_reemitir.Click
        If MessageBox.Show("¿Seguro que desea volver a emitir este documento?", "Confirmación de procedimiento.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            If txt_pedido.Text <> "" And txt_factura.Text <> 0 Then
                Dim sRenglon As String = Nothing
                Dim strStreamW As Stream = Nothing
                Dim strStreamWriter As StreamWriter = Nothing
                Dim ContenidoArchivo As String = Nothing
                ' Donde guardamos los paths de los archivos que se va a utilizar
                Dim PathArchivo As String
                Dim i As Integer
                Dim forma_pago As String
                Dim fecha_emision, fecha_vencimiento, tipo_pago, fecha_recep As String
                Dim telefonos, rut_recep, razon_recep, forma_pago2, toma_pedido, giro_recep, email_recep, direccion_recep, comuna_recep, ciudad_recep As String
                Dim dias, folio, Id_folio, folio_ver As Integer
                Dim fecha_ref As Date

                folio = txt_factura.Text
                dias = 1

                Dim i_desp As Integer = 0
                Do While dgv_despachos.Rows(i_desp).Cells(1).Value.ToString() <> txt_pedido.Text
                    i_desp = i_desp + 1
                Loop

                nue_cur.insertar3(Nombre_Obra, DateTime.Today.ToString("yyyy-MM-dd"), txt_hora.Text, "Guía de Despacho", txt_pedido.Text, txt_factura.Text)

                fecha_ref = CDate(txt_fecha_ref.Text)
                fecha_recep = fecha_ref.ToString("yyyy-MM-dd")
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
                        tipo_pago = dgv_despachos2.Rows(0).Cells(23).Value.ToString()
                        forma_pago = 1
                        dias = 0
                        indicador_traslado = 4
                        fecha_vencimiento = DateTime.Today.AddDays(dias).ToString("yyyy-MM-dd")
                        strStreamWriter.WriteLine("52|" & folio & "|" & fecha_emision & "||2|" & indicador_traslado & "|" & forma_pago & "|" & fecha_vencimiento & "|||}")
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
                        strStreamWriter.WriteLine("33||" & txt_fact_ref.Text & "|" & fecha_recep & "||SEGUN FACTURA " & txt_fact_ref.Text & "|}")
                        strStreamWriter.WriteLine("~")
                        strStreamWriter.WriteLine("" & forma_pago2 & "|" & telefonos & "|" & toma_pedido & "|NP:" & txt_pedido.Text & " HORA DE EMISIÓN: " & txt_hora.Text & " " & txt_observacion.Text & "|||||||||}")
                        strStreamWriter.WriteLine("~")
                        strStreamWriter.WriteLine("\")
                        strStreamWriter.Close() ' Cerramos

                        folio_ver = nue_cur.ult_ver2()
                        If folio > folio_ver Then
                            Id_folio = nue_cur.ult_id_guias()
                            nue_cur.modificar_folio_guias(Id_folio, txt_factura.Text)
                        End If

                        MessageBox.Show("GUÍA DE DESPACHO GENERADA CON ÉXITO")
                        txt_id.Clear()
                        txt_factura.Clear()
                        txt_pedido.Clear()
                        txt_fecha_ref.Clear()
                        txt_fact_ref.Clear()
                    Else
                        MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA EMITIR GUÍAS")
                    End If
                Catch ex As Exception
                    MsgBox("Error al Guardar la informacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                    strStreamWriter.Close() ' cerramos
                End Try
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR O YA ESTA EMITIDA LA GUÍA PARA ESTE DOCUMENTO")
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txt_factura.Text <> 0 Then
            txt_email.Text = txt_email2.Text
            enviar_mail()
        Else
            MessageBox.Show("SELECCIONAR DOCUMENTO FACTURADO")
        End If
    End Sub
    Sub actualizar_dgv_rutas()
        Dim pedido As String
        pedido = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        dgv_rutas.DataSource = nue_cur.listar17(pedido)
    End Sub
    Sub enviar_mail()
        Try
            Dim insMail As New System.Net.Mail.MailMessage
            'Dim adjunto As System.Net.Mail.Attachment

            'adjunto = New System.Net.Mail.Attachment("C:\Users\USUARIO\Desktop\Adjunto.pdf")
            With insMail

                .Subject = "Guía Papiro S.A."
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

                .Body = "Señores " + dgv_clientes.Rows(0).Cells(2).Value.ToString() + "<br>          Su pedido se encuentra en ruta de despacho, con la Guía N°" + dgv_despachos.CurrentRow.Cells(2).Value.ToString() + ". El transportista asignado es " + dgv_rutas.Rows(0).Cells(2).Value.ToString() + ". Si su pedido es dentro de Santiago, el tiempo estimado de llegada es de 3 horas. A continuación un resumen de su pedido: <br>" + texto + " <br> <br> Atentamente Papiro S.A. <br> <br> </i> Este mensaje ha sido generado automáticamente. Por favor no responda a este correo.</i>"
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

            nue_cur.insertar4(dgv_despachos.CurrentRow.Cells(1).Value.ToString(), "G:" + dgv_despachos.CurrentRow.Cells(2).Value.ToString(), dgv_despachos2.Rows(0).Cells(2).Value.ToString(), dgv_despachos.CurrentRow.Cells(3).Value.ToString(), txt_email.Text)

            MessageBox.Show("Error: " & ex.Message, _
                            "Error al enviar correo", _
                             MessageBoxButtons.OK)
        End Try
    End Sub
End Class

