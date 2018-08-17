Imports System.Globalization
Imports System.IO
Public Class Frm_consulta_nc

    Dim nue_cur As New clases.emitir_nota_credito
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        txt_pedido.ReadOnly = True
        txt_factura.ReadOnly = True
        txt_nc.ReadOnly = True
        actualizar_dgv_fecha()
        txt_total.ReadOnly = True
        txt_iva.ReadOnly = True
        txt_total2.ReadOnly = True
        txt_pedido2.ReadOnly = True
        If filtro_nc = 0 Then
            gp_anular.Visible = True
            gp_relacionar.Visible = False
            gp_autorizar.Visible = True
            GroupBox1.Visible = False
        ElseIf filtro_nc = 1 Then
            gp_anular.Visible = False
            gp_relacionar.Visible = True
            gp_autorizar.Visible = False
            GroupBox1.Visible = True
        End If
        Timer1.Enabled = True
    End Sub


    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        Dim numero_folio As Double
        numero_folio = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        btn_actualizar.DataSource = nue_cur.listar7(numero_folio)
        btn_actualizar.Columns(0).Visible = False
        btn_actualizar.Columns(1).Visible = False
        btn_actualizar.Columns(2).Visible = False
        btn_actualizar.Columns(3).Visible = False
        btn_actualizar.Columns(4).Visible = False
        btn_actualizar.Columns(5).Visible = False
        btn_actualizar.Columns(6).Visible = False
        btn_actualizar.Columns(7).Visible = False
        btn_actualizar.Columns(8).Visible = False
        btn_actualizar.Columns(9).Visible = False
        btn_actualizar.Columns(10).Visible = False
        btn_actualizar.Columns(11).Visible = False
        btn_actualizar.Columns(12).Visible = False
        btn_actualizar.Columns(13).Visible = False
        btn_actualizar.Columns(14).Visible = False
        btn_actualizar.Columns(15).Visible = False
        btn_actualizar.Columns(16).HeaderText = "Precio"
        btn_actualizar.Columns(16).DefaultCellStyle.Format = "##,###.##"
        btn_actualizar.Columns(17).HeaderText = "Cantidad"
        btn_actualizar.Columns(17).DefaultCellStyle.Format = "##,###"
        btn_actualizar.Columns(18).HeaderText = "Total"
        btn_actualizar.Columns(18).DefaultCellStyle.Format = "##,###"
        btn_actualizar.Columns(19).Visible = False
        btn_actualizar.Columns(20).Visible = False
        btn_actualizar.Columns(21).Visible = False
        btn_actualizar.Columns(22).Visible = False
        btn_actualizar.Columns(23).Visible = False
        btn_actualizar.Columns(24).Visible = False
        btn_actualizar.Columns(25).Visible = False
        btn_actualizar.Columns(26).Visible = False
        btn_actualizar.Columns(27).Visible = False
        btn_actualizar.Columns(28).Visible = False
        btn_actualizar.Columns(29).Visible = False
        btn_actualizar.Columns(30).Visible = False
        btn_actualizar.Columns(31).Visible = False
        btn_actualizar.Columns(32).Visible = False
        btn_actualizar.Columns(33).Visible = False
        btn_actualizar.Columns(34).Visible = False
        btn_actualizar.Columns(35).HeaderText = "Descripción"
        btn_actualizar.Columns(36).HeaderText = "Medidas"


        btn_actualizar.Columns(35).DisplayIndex = 0
        btn_actualizar.Columns(36).DisplayIndex = 1
        btn_actualizar.Columns(16).DisplayIndex = 2
        btn_actualizar.Columns(17).DisplayIndex = 3
        btn_actualizar.Columns(18).DisplayIndex = 4

        btn_actualizar.Columns(35).Width = 200
        btn_actualizar.Columns(36).Width = 50
        btn_actualizar.Columns(16).Width = 50
        btn_actualizar.Columns(17).Width = 50
        btn_actualizar.Columns(18).Width = 80


        txt_pedido.Clear()
        txt_factura.Clear()
        txt_nc.Clear()
        cod_cur = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
        txt_pedido.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        txt_pedido2.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        txt_folio2.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        If dgv_despachos.CurrentRow.Cells(3).Value.ToString() <> "" Then
            txt_factura.Text = dgv_despachos.CurrentRow.Cells(3).Value.ToString()
        Else
        End If
        If dgv_despachos.CurrentRow.Cells(2).Value.ToString() <> "" Then
            txt_nc.Text = dgv_despachos.CurrentRow.Cells(2).Value.ToString()
            txt_nc2.Text = dgv_despachos.CurrentRow.Cells(2).Value.ToString()
        Else
        End If
        txt_id.Text = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
        actualizar_dgv_cliente()
        txt_total.Text = btn_actualizar.Rows(0).Cells(9).Value.ToString()
        txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar_dgv_fecha()
    End Sub
    Sub actualizar_dgv_fecha()
        dgv_despachos.DataSource = Nothing

        If Not dgv_despachos.Columns("col_motivo") Is Nothing Then ' Condicional negativa en la que si existe la columna TIPO.
            'Dim col As New DataGridViewTextBoxColumn
            'col.Name = "Motivo"
            dgv_despachos.Columns.Remove("col_motivo") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If Not dgv_despachos.Columns("btn_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            'Dim col As New DataGridViewTextBoxColumn
            'col.Name = "Ver"
            dgv_despachos.Columns.Remove("btn_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If filtro_nc = 0 Then
            dgv_despachos.DataSource = nue_cur.listar14()
        ElseIf filtro_nc = 1 Then
            dgv_despachos.DataSource = nue_cur.listar8()
        End If

        If dgv_despachos.Columns("col_motivo") Is Nothing Then ' Condicional en la que si no existe columna TIPO entra.
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = "Motivo"
            col.Name = "col_motivo" ' Se agrega el nombre de la columna 
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

        With dgv_despachos

            ' Columnas NO visibles
            .Columns(0).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False

            ' Titulo columnas
            .Columns(1).HeaderText = "N° de Folio"
            .Columns(2).HeaderText = "Nota de Crédito"
            .Columns(3).HeaderText = "Factura"
            .Columns(4).HeaderText = "Cliente"

            ' Dimenciones de celdas
            .Columns(1).Width = 55
            .Columns(2).Width = 50
            .Columns(3).Width = 55
            .Columns(4).Width = 300
            .Columns("col_motivo").Width = 150
            .Columns("btn_ver").Width = 70

            .Columns(1).DefaultCellStyle.Format = "###,###,###" ' Formato de celda
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinación titulo columnas

            ' Alineamineto del contenido
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
        ' Bucle en el que itera sobre el resoltado (Cantidad de resultado encontrados)
        For x As Integer = 0 To dgv_despachos.RowCount - 1
            Dim valor As String = System.Convert.ToString(dgv_despachos.Rows(x).Cells(16).Value) ' Se convierte a String el valor de la celda iterada
            ' Agrega valor a la columna TIPO el valor dependiendo de valor de la celda de la columna tipo guia (13)
            Select Case valor
                Case "Motivo_1"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Diferencia precio"
                Case "Motivo_2"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Descuento comercial"
                Case "Motivo_3"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Mercadería defectuosa"
                Case "Motivo_4"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Devolución mercadería"
                Case "Motivo_5"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "No sale de bodega"
            End Select
        Next
    End Sub
    Private Sub btn_informe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txt_pedido.Text <> "" Then
            CR_guia_de_despacho4.Show()
        Else
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txt_pedido.Text <> "" And txt_nc.Text = 0 Then
            Dim sRenglon As String = Nothing
            Dim strStreamW As Stream = Nothing
            Dim strStreamWriter As StreamWriter = Nothing
            Dim ContenidoArchivo As String = Nothing
            ' Donde guardamos los paths de los archivos que se va a utilizar
            Dim PathArchivo As String
            Dim i As Integer
            Dim forma_pago As String
            Dim fecha_emision, fecha_vencimiento As String
            Dim rut_recep, razon_recep, giro_recep, email_recep, direccion_recep, comuna_recep, ciudad_recep, observaciones, accion As String
            Dim dias, folio, Id_folio As Integer

            folio = nue_cur.buscar_folio() + 1

            If folio = 1 Then
                MessageBox.Show("TIENE QUE SOLICITAR MÁS FOLIOS DE NOTA DE CRÉDITO")
            Else

                txt_nc.Text = folio
                'Id_folio = nue_cur.ult_id()
                If btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Con Monto Pesos" Then
                    accion = "3"
                ElseIf btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Con Monto Cantidad" Then
                    accion = "3"
                ElseIf btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Anular" Then
                    accion = "1"

                ElseIf btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Con Texto" Then
                    accion = "2"
                Else
                    accion = "3"
                End If
                observaciones = btn_actualizar.Rows(0).Cells(7).Value.ToString()
                fecha_emision = DateTime.Today.ToString("yyyy-MM-dd")
                fecha_vencimiento = DateTime.Today.ToString("yyyy-MM-dd")
                rut_recep = dgv_clientes.Rows(0).Cells(1).Value.ToString()
                razon_recep = dgv_clientes.Rows(0).Cells(2).Value.ToString()
                giro_recep = dgv_clientes.Rows(0).Cells(34).Value.ToString()
                email_recep = dgv_clientes.Rows(0).Cells(9).Value.ToString()
                direccion_recep = dgv_clientes.Rows(0).Cells(3).Value.ToString()
                comuna_recep = dgv_clientes.Rows(0).Cells(4).Value.ToString()
                ciudad_recep = dgv_clientes.Rows(0).Cells(26).Value.ToString()
                If accion = "2" Then
                    Try
                        If Directory.Exists("C:\Acepta\DTEService\input-produccion") = True Then
                            Windows.Forms.Cursor.Current = Cursors.WaitCursor
                            PathArchivo = "C:\Acepta\DTEService\input-produccion\" & txt_nc.Text & ".txt" ' Se determina el nombre del archivo con el N° de la Nota de Crédito
                            strStreamW = File.Create(PathArchivo) ' Creamos el archivo
                            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
                            '(forma de pago --> 1 Contado 2 Crédito)
                            'If dgv_despachos2.Rows(0).Cells(23).Value.ToString() = "Crédito" Then
                            '    forma_pago = 2
                            'Else
                            '    forma_pago = 1
                            'End If
                            strStreamWriter.WriteLine("61|" & folio & "|" & fecha_emision & "||2||1|" & fecha_vencimiento & "}")
                            strStreamWriter.WriteLine("96956180-8|PAPIRO S.A|Com. Prod. Derivados de Papel. Plástico y Equipos Tecnológicos e Iluminación|513940|||Alberto Riesco 0223 Bodega 1|Huechuraba|Santiago||}")
                            strStreamWriter.WriteLine(rut_recep & "||" & razon_recep & "|" & giro_recep & "|" & email_recep & "|" & direccion_recep & "|" & comuna_recep & "|" & ciudad_recep & "||}")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine("||19||0|||||||||||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|" & observaciones & "||||||0||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("33||" & txt_factura.Text & "|" & fecha_emision & "|" & accion & "|||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("||||||||||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("\")
                            strStreamWriter.Close() ' Cerramos
                            MessageBox.Show("NOTA DE CRÉDITO CREADA CON ÉXITO")
                            Id_folio = nue_cur.ult_id()
                            nue_cur.modificar(txt_id.Text, txt_nc.Text)
                            nue_cur.modificar_folio(Id_folio, txt_nc.Text)
                            actualizar_dgv_fecha()
                        Else
                            MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA EMITIR NOTAS DE CRÉDITO")
                        End If
                    Catch ex As Exception
                        MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                        strStreamWriter.Close() ' cerramos
                    End Try
                Else

                    Try
                        If Directory.Exists("C:\Acepta\DTEService\input-produccion") = True Then
                            Windows.Forms.Cursor.Current = Cursors.WaitCursor
                            PathArchivo = "C:\Acepta\DTEService\input-produccion\" & txt_nc.Text & ".txt" ' Se determina el nombre del archivo con el N° de la Nota de Crédito
                            strStreamW = File.Create(PathArchivo) ' Creamos el archivo
                            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
                            '(forma de pago --> 1 Contado 2 Crédito)
                            'If dgv_despachos2.Rows(0).Cells(23).Value.ToString() = "Crédito" Then
                            '    forma_pago = 2
                            'Else
                            '    forma_pago = 1
                            'End If
                            strStreamWriter.WriteLine("61|" & folio & "|" & fecha_emision & "||2||1|" & fecha_vencimiento & "}")
                            strStreamWriter.WriteLine("96956180-8|PAPIRO S.A|Com. Prod. Derivados de Papel. Plástico y Equipos Tecnológicos e Iluminación|513940|||Alberto Riesco 0223 Bodega 1|Huechuraba|Santiago||}")
                            strStreamWriter.WriteLine(rut_recep & "||" & razon_recep & "|" & giro_recep & "|" & email_recep & "|" & direccion_recep & "|" & comuna_recep & "|" & ciudad_recep & "||}")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine(CInt(-1 * txt_total.Text) & "|0|19|" & CInt(-1 * txt_iva.Text) & "|" & CInt(-1 * txt_total2.Text) & "|||||||||||||}")
                            strStreamWriter.WriteLine("~")
                            Dim nombre, descripcion, cantidad, unidad, precio, total, codigo As String
                            If btn_actualizar.Rows.Count > 0 Then
                                For i = 0 To btn_actualizar.Rows.Count - 1
                                    nombre = btn_actualizar.Rows(i).Cells(35).Value.ToString()
                                    descripcion = btn_actualizar.Rows(i).Cells(36).Value.ToString()
                                    cantidad = btn_actualizar.Rows(i).Cells(17).Value.ToString()
                                    cantidad = cantidad.Replace(",", ".")
                                    unidad = "UNI"
                                    precio = btn_actualizar.Rows(i).Cells(16).Value.ToString()
                                    precio = precio.Replace(",", ".")
                                    total = -1 * btn_actualizar.Rows(i).Cells(18).Value.ToString()
                                    total = total.Replace(",", ".")
                                    codigo = btn_actualizar.Rows(i).Cells(15).Value.ToString()
                                    strStreamWriter.WriteLine("|" & nombre & " " & descripcion & "||" & cantidad & "|" & unidad & "|" & precio & "|||" & total & "|" & codigo & "|}")
                                Next i
                            End If

                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("33||" & txt_factura.Text & "|" & fecha_emision & "|" & accion & "|||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|||" & observaciones & "|||||||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("\")
                            strStreamWriter.Close() ' Cerramos
                            MessageBox.Show("NOTA DE CRÉDITO CREADA CON ÉXITO")
                            Id_folio = nue_cur.ult_id()
                            nue_cur.modificar(txt_id.Text, txt_nc.Text)
                            nue_cur.modificar_folio(Id_folio, txt_nc.Text)
                            actualizar_dgv_fecha()
                        Else
                            MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA EMITIR NOTAS DE CRÉDITO")
                        End If
                    Catch ex As Exception
                        MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                        strStreamWriter.Close() ' cerramos
                    End Try
                End If
            End If
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR O YA ESTA CREADA LA NOTA DE CRÉDITO PARA ESTE DOCUMENTO")
        End If
    End Sub
    Sub actualizar_dgv_cliente()
        Dim rut As String
        rut = btn_actualizar.Rows(0).Cells(4).Value.ToString()
        dgv_clientes.DataSource = nue_cur.listar12(rut)
    End Sub
    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        txt_iva.Text = FormatNumber(txt_total.Text * 0.19, 0)
        txt_total2.Text = FormatNumber(CInt(txt_total.Text) + CInt(txt_iva.Text), 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nue_cur.modificar(txt_id.Text, txt_nc2.Text)
        actualizar_dgv_fecha()
    End Sub

    Private Sub btn_autorizar_Click(sender As Object, e As EventArgs) Handles btn_autorizar.Click
        If txt_folio2.Text <> "" Then
            nue_cur.modificar2(CInt(cod_cur), 1)
            nue_cur.insertar2(2, "NC", txt_folio2.Text, 1, "Autoriza", Nombre_Obra, CDate(DateTime.Today), CDate(txt_hora.Text))
            actualizar_dgv_fecha()
            MsgBox("SE HA AUTORIZADO LA NOTA DE CRÉDITO")
        Else
            MsgBox("DEBE SELECCIONAR PRIMERO LA NOTA DE CRÉDITO RESPECTIVA")
        End If
    End Sub

    Private Sub btn_rechazar_Click(sender As Object, e As EventArgs) Handles btn_rechazar.Click
        If txt_folio2.Text <> "" Then
            nue_cur.modificar2(CInt(cod_cur), 2)
            nue_cur.insertar2(2, "NC", txt_folio2.Text, 2, "Rechaza", Nombre_Obra, CDate(DateTime.Today), CDate(txt_hora.Text))
            actualizar_dgv_fecha()
            MsgBox("SE HA RECHAZADO LA NOTA DE CRÉDITO")
        Else
            MsgBox("DEBE SELECCIONAR PRIMERO LA NOTA DE CRÉDITO RESPECTIVA")
        End If
    End Sub

    Private Sub txt_hora_TextChanged(sender As Object, e As EventArgs) Handles txt_hora.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub btn_reemitir_Click(sender As Object, e As EventArgs) Handles btn_reemitir.Click
        If MessageBox.Show("¿Seguro que desea volver a emitir este documento?", "Confirmación de procedimiento.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            If txt_pedido.Text <> "" And txt_nc.Text <> 0 Then
                Dim sRenglon As String = Nothing
                Dim strStreamW As Stream = Nothing
                Dim strStreamWriter As StreamWriter = Nothing
                Dim ContenidoArchivo As String = Nothing
                ' Donde guardamos los paths de los archivos que se va a utilizar
                Dim PathArchivo As String
                Dim i As Integer
                Dim forma_pago As String
                Dim fecha_emision, fecha_vencimiento As String
                Dim rut_recep, razon_recep, giro_recep, email_recep, direccion_recep, comuna_recep, ciudad_recep, observaciones, accion As String
                Dim dias, folio, Id_folio, folio_ver As Integer

                folio = txt_nc.Text
                txt_nc.Text = folio

                If btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Con Monto Pesos" Then
                    accion = "3"
                ElseIf btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Con Monto Cantidad" Then
                    accion = "3"
                ElseIf btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Anular" Then
                    accion = "1"

                ElseIf btn_actualizar.Rows(0).Cells(5).Value.ToString() = "Con Texto" Then
                    accion = "2"
                Else
                    accion = "3"
                End If
                observaciones = btn_actualizar.Rows(0).Cells(7).Value.ToString()
                fecha_emision = DateTime.Today.ToString("yyyy-MM-dd")
                fecha_vencimiento = DateTime.Today.ToString("yyyy-MM-dd")
                rut_recep = dgv_clientes.Rows(0).Cells(1).Value.ToString()
                razon_recep = dgv_clientes.Rows(0).Cells(2).Value.ToString()
                giro_recep = dgv_clientes.Rows(0).Cells(34).Value.ToString()
                email_recep = dgv_clientes.Rows(0).Cells(9).Value.ToString()
                direccion_recep = dgv_clientes.Rows(0).Cells(3).Value.ToString()
                comuna_recep = dgv_clientes.Rows(0).Cells(4).Value.ToString()
                ciudad_recep = dgv_clientes.Rows(0).Cells(26).Value.ToString()

                nue_cur.insertar3(Nombre_Obra, DateTime.Today.ToString("yyyy-MM-dd"), txt_hora.Text, "Nota de Crédito", txt_pedido.Text, txt_nc.Text)

                If accion = "2" Then
                    Try
                        If Directory.Exists("C:\Acepta\DTEService\input-produccion") = True Then
                            Windows.Forms.Cursor.Current = Cursors.WaitCursor
                            PathArchivo = "C:\Acepta\DTEService\input-produccion\" & txt_nc.Text & ".txt" ' Se determina el nombre del archivo con el N° de la Nota de Crédito
                            strStreamW = File.Create(PathArchivo) ' Creamos el archivo
                            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' Tipo de codificacion para escritura
                            strStreamWriter.WriteLine("61|" & folio & "|" & fecha_emision & "||2||1|" & fecha_vencimiento & "}")
                            strStreamWriter.WriteLine("96956180-8|PAPIRO S.A|Com. Prod. Derivados de Papel. Plástico y Equipos Tecnológicos e Iluminación|513940|||Alberto Riesco 0223 Bodega 1|Huechuraba|Santiago||}")
                            strStreamWriter.WriteLine(rut_recep & "||" & razon_recep & "|" & giro_recep & "|" & email_recep & "|" & direccion_recep & "|" & comuna_recep & "|" & ciudad_recep & "||}")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine("||19||0|||||||||||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|" & observaciones & "||||||0||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("33||" & txt_factura.Text & "|" & fecha_emision & "|" & accion & "|||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("||||||||||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("\")
                            strStreamWriter.Close() ' Cerramos

                            folio_ver = nue_cur.ult_ver()
                            If folio > folio_ver Then
                                Id_folio = nue_cur.ult_id()
                                nue_cur.modificar_folio(Id_folio, txt_nc.Text)
                            End If
                            MessageBox.Show("NOTA DE CRÉDITO CREADA CON ÉXITO")
                        Else
                            MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA EMITIR NOTAS DE CRÉDITO")
                        End If
                    Catch ex As Exception
                        MsgBox("Error al Guardar la información en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                        strStreamWriter.Close() ' Cerramos
                    End Try
                Else

                    Try
                        If Directory.Exists("C:\Acepta\DTEService\input-produccion") = True Then
                            Windows.Forms.Cursor.Current = Cursors.WaitCursor
                            PathArchivo = "C:\Acepta\DTEService\input-produccion\" & txt_nc.Text & ".txt" ' Se determina el nombre del archivo con el N° de la Nota de Crédito
                            strStreamW = File.Create(PathArchivo) ' Creamos el archivo
                            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' Tipo de codificacion para escritura
                            strStreamWriter.WriteLine("61|" & folio & "|" & fecha_emision & "||2||1|" & fecha_vencimiento & "}")
                            strStreamWriter.WriteLine("96956180-8|PAPIRO S.A|Com. Prod. Derivados de Papel. Plástico y Equipos Tecnológicos e Iluminación|513940|||Alberto Riesco 0223 Bodega 1|Huechuraba|Santiago||}")
                            strStreamWriter.WriteLine(rut_recep & "||" & razon_recep & "|" & giro_recep & "|" & email_recep & "|" & direccion_recep & "|" & comuna_recep & "|" & ciudad_recep & "||}")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine(CInt(-1 * txt_total.Text) & "|0|19|" & CInt(-1 * txt_iva.Text) & "|" & CInt(-1 * txt_total2.Text) & "|||||||||||||}")
                            strStreamWriter.WriteLine("~")
                            Dim nombre, descripcion, cantidad, unidad, precio, total, codigo As String
                            If btn_actualizar.Rows.Count > 0 Then
                                For i = 0 To btn_actualizar.Rows.Count - 1
                                    nombre = btn_actualizar.Rows(i).Cells(35).Value.ToString()
                                    descripcion = btn_actualizar.Rows(i).Cells(36).Value.ToString()
                                    cantidad = btn_actualizar.Rows(i).Cells(17).Value.ToString()
                                    cantidad = cantidad.Replace(",", ".")
                                    unidad = "UNI"
                                    precio = btn_actualizar.Rows(i).Cells(16).Value.ToString()
                                    precio = precio.Replace(",", ".")
                                    total = -1 * btn_actualizar.Rows(i).Cells(18).Value.ToString()
                                    total = total.Replace(",", ".")
                                    codigo = btn_actualizar.Rows(i).Cells(15).Value.ToString()
                                    strStreamWriter.WriteLine("|" & nombre & " " & descripcion & "||" & cantidad & "|" & unidad & "|" & precio & "|||" & total & "|" & codigo & "|}")
                                Next i
                            End If

                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("33||" & txt_factura.Text & "|" & fecha_emision & "|" & accion & "|||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("|||" & observaciones & "|||||||||}")
                            strStreamWriter.WriteLine("~")
                            strStreamWriter.WriteLine("\")
                            strStreamWriter.Close() ' Cerramos

                            folio_ver = nue_cur.ult_ver()
                            If folio > folio_ver Then
                                Id_folio = nue_cur.ult_id()
                                nue_cur.modificar_folio(Id_folio, txt_nc.Text)
                            End If
                            MessageBox.Show("NOTA DE CRÉDITO CREADA CON ÉXITO")
                        Else
                            MessageBox.Show("ESTE COMPUTADOR NO ESTA DISPONIBLE PARA EMITIR NOTAS DE CRÉDITO")
                        End If
                    Catch ex As Exception
                        MsgBox("Error al Guardar la información en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                        strStreamWriter.Close() ' Cerramos
                    End Try
                End If
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR O YA ESTA CREADA LA NOTA DE CRÉDITO PARA ESTE DOCUMENTO")
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar_dgv_fecha()
    End Sub
End Class

