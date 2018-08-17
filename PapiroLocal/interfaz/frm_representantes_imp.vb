Public Class frm_representates_imp

    Dim nue_usua As New clases.Representante_imp
    Public usuario As String = ""
    Public cod_item As String
    Public sw As Integer = 0


    Sub actualizar_items()
        dgv_items.DataSource = nue_usua.listar()
        dgv_items.Columns(0).Visible = False
        dgv_items.Columns(1).HeaderText = "Rut"
        dgv_items.Columns(2).HeaderText = "Cliente"
        dgv_items.Columns(3).HeaderText = "Dirección"
        dgv_items.Columns(4).HeaderText = "Comuna"
        dgv_items.Columns(5).HeaderText = "Telefonos"
        dgv_items.Columns(6).HeaderText = "Contacto Comercial"
        dgv_items.Columns(2).Width = 300
        dgv_items.Columns(3).Width = 200
        dgv_items.Columns(4).Width = 200
        dgv_items.Columns(6).Width = 200
        dgv_items.Columns(7).Visible = False
        dgv_items.Columns(8).Visible = False
        dgv_items.Columns(9).Visible = False
        dgv_items.Columns(10).Visible = False
        dgv_items.Columns(11).Visible = False
        dgv_items.Columns(12).Visible = False
        dgv_items.Columns(13).Visible = False
        dgv_items.Columns(14).Visible = False
        dgv_items.Columns(15).Visible = False
        dgv_items.Columns(16).Visible = False
        dgv_items.Columns(17).Visible = False
        dgv_items.Columns(18).Visible = False
        dgv_items.Columns(19).Visible = False
        dgv_items.Columns(20).Visible = False
        dgv_items.Columns(21).Visible = False
        dgv_items.Columns(22).Visible = False
        dgv_items.Columns(23).Visible = False
        dgv_items.Columns(24).Visible = False
        dgv_items.Columns(25).Visible = False
        dgv_items.Columns(26).Visible = False
        dgv_items.Columns(27).Visible = False
        dgv_items.Columns(28).Visible = False
        dgv_items.Columns(29).Visible = False
        dgv_items.Columns(30).Visible = False
        dgv_items.Columns(31).Visible = False
        dgv_items.Columns(32).Visible = False
        dgv_items.Columns(33).Visible = False
        dgv_items.Columns(34).Visible = False
        dgv_items.Columns(35).Visible = False
        dgv_items.Columns(36).Visible = False
        dgv_items.Columns(37).Visible = False
        dgv_items.Columns(38).Visible = False
        dgv_items.Columns(39).Visible = False
        dgv_items.Columns(40).Visible = False
        dgv_items.Columns(41).Visible = False
        dgv_items.Columns(42).Visible = False
        dgv_items.AllowUserToOrderColumns = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rut, clientes, direccion, comuna, telefonos, contacto_comercial, cargo_contacto_comercial, telefonos_contacto, email_contacto_comercial, contacto_pago_proveedores, cargo_contacto_pago, telefonos_cargo_contacto, email_contacto_pago, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_despacho, email_despacho, telefonos_despacho, contacto_despacho, telefono_despacho, senal_advertencia, estado, linea_credito, dicom, fecha_ingreso, observacion, maquinas, email_contacto2, actualizado, giro, email_contacto_despacho2, referencia, ficha_cliente, encargado_produccion, maquina16, maquina18, maquina320, ejec_new As String

        If dgv_imp.Rows.Count > 0 Then
            For i = 0 To dgv_imp.Rows.Count - 1
                Try
                    rut = dgv_imp.Rows(i).Cells(0).Value.ToString()
                    clientes = dgv_imp.Rows(i).Cells(1).Value.ToString()
                    direccion = dgv_imp.Rows(i).Cells(2).Value.ToString()
                    comuna = dgv_imp.Rows(i).Cells(3).Value.ToString()
                    telefonos = dgv_imp.Rows(i).Cells(4).Value.ToString()
                    contacto_comercial = dgv_imp.Rows(i).Cells(5).Value.ToString()
                    cargo_contacto_comercial = dgv_imp.Rows(i).Cells(6).Value.ToString()
                    telefonos_contacto = dgv_imp.Rows(i).Cells(7).Value.ToString()
                    email_contacto_comercial = dgv_imp.Rows(i).Cells(8).Value.ToString()
                    contacto_pago_proveedores = dgv_imp.Rows(i).Cells(9).Value.ToString()
                    cargo_contacto_pago = dgv_imp.Rows(i).Cells(10).Value.ToString()
                    telefonos_cargo_contacto = dgv_imp.Rows(i).Cells(11).Value.ToString()
                    email_contacto_pago = dgv_imp.Rows(i).Cells(12).Value.ToString()
                    cond = dgv_imp.Rows(i).Cells(13).Value.ToString()
                    forma_de_pago = dgv_imp.Rows(i).Cells(14).Value.ToString()
                    ejec_digital = dgv_imp.Rows(i).Cells(15).Value.ToString()
                    ejec_media = dgv_imp.Rows(i).Cells(16).Value.ToString()
                    ejec_led = dgv_imp.Rows(i).Cells(17).Value.ToString()
                    ejec_mac = dgv_imp.Rows(i).Cells(18).Value.ToString()
                    direccion_despacho = dgv_imp.Rows(i).Cells(19).Value.ToString()
                    email_despacho = dgv_imp.Rows(i).Cells(20).Value.ToString()
                    telefonos_despacho = dgv_imp.Rows(i).Cells(21).Value.ToString()
                    contacto_despacho = dgv_imp.Rows(i).Cells(22).Value.ToString()
                    telefono_despacho = dgv_imp.Rows(i).Cells(23).Value.ToString()
                    senal_advertencia = dgv_imp.Rows(i).Cells(24).Value.ToString()
                    estado = dgv_imp.Rows(i).Cells(25).Value.ToString()
                    linea_credito = dgv_imp.Rows(i).Cells(26).Value.ToString()
                    dicom = dgv_imp.Rows(i).Cells(27).Value.ToString()
                    fecha_ingreso = dgv_imp.Rows(i).Cells(28).Value.ToString()
                    observacion = dgv_imp.Rows(i).Cells(29).Value.ToString()
                    maquinas = dgv_imp.Rows(i).Cells(30).Value.ToString()
                    email_contacto2 = dgv_imp.Rows(i).Cells(31).Value.ToString()
                    actualizado = dgv_imp.Rows(i).Cells(32).Value.ToString()
                    giro = dgv_imp.Rows(i).Cells(33).Value.ToString()
                    email_contacto_despacho2 = dgv_imp.Rows(i).Cells(34).Value.ToString()
                    referencia = dgv_imp.Rows(i).Cells(35).Value.ToString()
                    ficha_cliente = dgv_imp.Rows(i).Cells(36).Value.ToString()
                    encargado_produccion = dgv_imp.Rows(i).Cells(37).Value.ToString()
                    maquina16 = dgv_imp.Rows(i).Cells(38).Value.ToString()
                    maquina18 = dgv_imp.Rows(i).Cells(39).Value.ToString()
                    maquina320 = dgv_imp.Rows(i).Cells(40).Value.ToString()
                    ejec_new = dgv_imp.Rows(i).Cells(41).Value.ToString()

                    ProgressBar1.Value = (i / (dgv_imp.Rows.Count - 1)) * 100
                    nue_usua.insertar(rut, clientes, direccion, comuna, telefonos, contacto_comercial, cargo_contacto_comercial, telefonos_contacto, email_contacto_comercial, contacto_pago_proveedores, cargo_contacto_pago, telefonos_cargo_contacto, email_contacto_pago, cond, forma_de_pago, ejec_digital, ejec_media, ejec_led, ejec_mac, direccion_despacho, email_despacho, telefonos_despacho, contacto_despacho, telefono_despacho, senal_advertencia, estado, linea_credito, dicom, actualizado, observacion, maquinas, email_contacto2, fecha_ingreso, giro, email_contacto_despacho2, referencia, ficha_cliente, encargado_produccion, maquina16, maquina18, maquina320, ejec_new)
                Catch ex As Exception
                    ProgressBar1.Value = 100
                    MsgBox("HA TERMINADO EL INGRESO DE LOS DATOS")
                End Try
            Next i
            actualizar_items()
            dgv_imp.DataSource = Nothing
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub dgv_items_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_items.CellContentClick

    End Sub

    Private Sub dgv_items_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_items.DoubleClick
        Dim Cod_item As String
        Dim eliminar As MsgBoxResult
        Cod_item = dgv_items.CurrentRow.Cells(0).Value.ToString()
        If (Cod_item = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")
            If eliminar = MsgBoxResult.Ok Then
                nue_usua.eliminar(CInt(Cod_item))
                actualizar_items()
            Else
            End If
        End If
    End Sub

    Private Sub btn_template_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ruta2 As String
        Dim nombre2 As String
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta2 = SaveFileDialog1.FileName
            nombre2 = "Template_Excel.xlsx"
            My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.53/Templates/" & nombre2 & "", ruta2, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim ruta As String
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = OpenFileDialog1.FileName
            End If
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = ruta

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [clientes$]", MyConnection)
            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            dgv_imp.DataSource = dataSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgv_items.Rows.Count > 0 Then
            For i = 0 To dgv_items.Rows.Count - 1
                Try
                    cod_item = dgv_items.Rows(i).Cells(0).Value.ToString()
                    ProgressBar1.Value = (i / (dgv_items.Rows.Count - 1)) * 100
                    nue_usua.eliminar(CInt(cod_item))
                Catch ex As Exception
                    ProgressBar1.Value = 100
                    MsgBox("HA TERMINADO LA ELIMINACIÓN DE LOS DATOS")
                End Try
            Next i
            actualizar_items()
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub frm_representates_imp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_items()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class