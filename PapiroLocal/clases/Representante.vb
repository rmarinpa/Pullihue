Imports MySql.Data.MySqlClient
Public Class Representante

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los representantes
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes order by rut asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar Representantes
    Public Sub insertar(ByVal rut As String, ByVal razon_social As String, ByVal direccion As String, ByVal comuna As String, ByVal telefono As String, ByVal nombre_com As String, ByVal cargo_com As String, ByVal telefonos_com As String, ByVal email_com As String, ByVal nombre_fact As String, ByVal cargo_fact As String, ByVal telefonos_fact As String, ByVal email_fact As String, ByVal cond As String, ByVal forma_de_pago As String, ByVal ejec_digital As String, ByVal ejec_media As String, ByVal ejec_led As String, ByVal ejec_mac As String, ByVal direccion_desp As String, ByVal email_despacho As String, ByVal telefonos_desp As String, ByVal nombre_desp As String, ByVal telefono_desp As String, ByVal senal_advertencia As String, ByVal estado As String, ByVal linea_credito As String, ByVal dicom As String, ByVal fecha_ingreso As String, ByVal observacion As String, ByVal maquinas As String, ByVal email_contacto2 As String, ByVal actualizado As String, ByVal giro As String, ByVal email_contacto_despacho2 As String, ByVal referencia As String, ByVal ficha_cliente As String, ByVal encargado_produccion As String, ByVal maquina16 As String, ByVal maquina18 As String, ByVal maquina320 As String, ByVal ejec_new As String, ByVal ejec_cobranza As String)
        nue_var.consulta = "INSERT INTO Clientes VALUES('',?rut, ?razon_social, ?direccion, ?comuna, ?telefono, ?nombre_com, ?cargo_com, ?telefonos_com, ?email_com, ?nombre_fact, ?cargo_fact, ?telefonos_fact, ?email_fact, ?cond, ?forma_de_pago, ?ejec_digital, ?ejec_media, ?ejec_led, ?ejec_mac, ?direccion_desp, ?email_despacho, ?telefonos_desp, ?nombre_desp, ?telefono_desp, ?senal_advertencia, ?estado, ?linea_credito, ?dicom, ?fecha_ingreso, ?observacion, ?maquinas, ?email_contacto2, ?actualizado, ?giro, ?email_contacto_despacho2, ?referencia, ?ficha_cliente, ?encargado_produccion, ?maquina16, ?maquina18, ?maquina320, ?ejec_new, ?ejec_cobranza)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?razon_social", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon_social
            nue_var.cmd.Parameters.Add("?direccion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?telefono", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefono
            nue_var.cmd.Parameters.Add("?nombre_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_com
            nue_var.cmd.Parameters.Add("?cargo_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cargo_com
            nue_var.cmd.Parameters.Add("?telefonos_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_com
            nue_var.cmd.Parameters.Add("?email_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_com
            nue_var.cmd.Parameters.Add("?nombre_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_fact
            nue_var.cmd.Parameters.Add("?cargo_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cargo_fact
            nue_var.cmd.Parameters.Add("?telefonos_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_fact
            nue_var.cmd.Parameters.Add("?email_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_fact
            nue_var.cmd.Parameters.Add("?cond", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cond
            nue_var.cmd.Parameters.Add("?forma_de_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_de_pago
            nue_var.cmd.Parameters.Add("?ejec_digital", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_digital
            nue_var.cmd.Parameters.Add("?ejec_media", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_media
            nue_var.cmd.Parameters.Add("?ejec_led", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_led
            nue_var.cmd.Parameters.Add("?ejec_mac", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_mac
            nue_var.cmd.Parameters.Add("?direccion_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_desp
            nue_var.cmd.Parameters.Add("?email_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_despacho
            nue_var.cmd.Parameters.Add("?telefonos_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_desp
            nue_var.cmd.Parameters.Add("?nombre_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_desp
            nue_var.cmd.Parameters.Add("?telefono_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefono_desp
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado
            nue_var.cmd.Parameters.Add("?linea_credito", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = linea_credito
            nue_var.cmd.Parameters.Add("?dicom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dicom
            nue_var.cmd.Parameters.Add("?fecha_ingreso", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = fecha_ingreso
            nue_var.cmd.Parameters.Add("?observacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observacion
            nue_var.cmd.Parameters.Add("?maquinas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquinas
            nue_var.cmd.Parameters.Add("?email_contacto2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_contacto2
            nue_var.cmd.Parameters.Add("?actualizado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = actualizado
            nue_var.cmd.Parameters.Add("?giro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = giro
            nue_var.cmd.Parameters.Add("?email_contacto_despacho2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_contacto_despacho2
            nue_var.cmd.Parameters.Add("?referencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = referencia
            nue_var.cmd.Parameters.Add("?ficha_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ficha_cliente
            nue_var.cmd.Parameters.Add("?encargado_produccion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = encargado_produccion
            nue_var.cmd.Parameters.Add("?maquina16", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquina16
            nue_var.cmd.Parameters.Add("?maquina18", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquina18
            nue_var.cmd.Parameters.Add("?maquina320", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquina320
            nue_var.cmd.Parameters.Add("?ejec_new", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_new
            nue_var.cmd.Parameters.Add("?ejec_cobranza", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_cobranza

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal rut As String, ByVal razon_social As String, ByVal direccion As String, ByVal comuna As String, ByVal telefono As String, ByVal nombre_com As String, ByVal cargo_com As String, ByVal telefonos_com As String, ByVal email_com As String, ByVal nombre_fact As String, ByVal cargo_fact As String, ByVal telefonos_fact As String, ByVal email_fact As String, ByVal cond As String, ByVal forma_de_pago As String, ByVal ejec_digital As String, ByVal ejec_media As String, ByVal ejec_led As String, ByVal ejec_mac As String, ByVal direccion_desp As String, ByVal email_despacho As String, ByVal telefonos_desp As String, ByVal nombre_desp As String, ByVal telefono_despacho As String, ByVal senal_advertencia As String, ByVal estado As String, ByVal linea_credito As String, ByVal dicom As String, ByVal fecha_ingreso As String, ByVal observacion As String, ByVal maquinas As String, ByVal email_contacto2 As String, ByVal actualizado As String, ByVal giro As String, ByVal email_contacto_despacho2 As String, ByVal referencia As String, ByVal ficha_cliente As String, ByVal encargado_produccion As String, ByVal maquina16 As String, ByVal maquina18 As String, ByVal maquina320 As String, ByVal ejec_new As String, ByVal ejec_cobranza As String)
        nue_var.consulta = "UPDATE Clientes SET rut = ?rut, clientes = ?razon_social, direccion = ?direccion, comuna = ?comuna, telefonos = ?telefono, contacto_comercial = ?nombre_com, cargo_contacto_comercial = ?cargo_com, telefonos_contacto = ?telefonos_com, email_contacto_comercial = ?email_com, contacto_pago_proveedores = ?nombre_fact, cargo_contacto_pago = ?cargo_fact, telefonos_cargo_contacto = ?telefonos_fact, email_contacto_pago = ?email_fact, cond = ?cond, forma_de_pago = ?forma_de_pago, ejec_digital = ?ejec_digital, ejec_media = ?ejec_media, ejec_led = ?ejec_led, ejec_mac = ?ejec_mac, direccion_despacho = ?direccion_desp, email_despacho = ?email_despacho, telefonos_despacho = ?telefonos_desp, contacto_despacho = ?nombre_desp, telefono_despacho = ?telefono_despacho, senal_advertencia = ?senal_advertencia, estado = ?estado, linea_credito = ?linea_credito, dicom = ?dicom, fecha_ingreso = ?fecha_ingreso, observacion = ?observacion, maquinas = ?maquinas, email_contacto2 = ?email_contacto2, actualizado = ?actualizado, giro = ?giro, email_contacto_despacho2 = ?email_contacto_despacho2 , referencia = ?referencia, ficha_cliente = ?ficha_cliente, encargado_produccion = ?encargado_produccion, maquina16 = ?maquina16, maquina18 = ?maquina18, maquina320 = ?maquina320, ejec_new = ?ejec_new, ejec_cobranza = ?ejec_cobranza  WHERE id_clientes = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?razon_social", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon_social
            nue_var.cmd.Parameters.Add("?direccion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?telefono", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefono
            nue_var.cmd.Parameters.Add("?nombre_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_com
            nue_var.cmd.Parameters.Add("?cargo_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cargo_com
            nue_var.cmd.Parameters.Add("?telefonos_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_com
            nue_var.cmd.Parameters.Add("?email_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_com
            nue_var.cmd.Parameters.Add("?nombre_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_fact
            nue_var.cmd.Parameters.Add("?cargo_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cargo_fact
            nue_var.cmd.Parameters.Add("?telefonos_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_fact
            nue_var.cmd.Parameters.Add("?email_fact", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_fact
            nue_var.cmd.Parameters.Add("?cond", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cond
            nue_var.cmd.Parameters.Add("?forma_de_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_de_pago
            nue_var.cmd.Parameters.Add("?ejec_digital", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_digital
            nue_var.cmd.Parameters.Add("?ejec_media", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_media
            nue_var.cmd.Parameters.Add("?ejec_led", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_led
            nue_var.cmd.Parameters.Add("?ejec_mac", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_mac
            nue_var.cmd.Parameters.Add("?direccion_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_desp
            nue_var.cmd.Parameters.Add("?email_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_despacho
            nue_var.cmd.Parameters.Add("?telefonos_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_desp
            nue_var.cmd.Parameters.Add("?nombre_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_desp
            nue_var.cmd.Parameters.Add("?telefono_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefono_despacho
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado
            nue_var.cmd.Parameters.Add("?linea_credito", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = linea_credito
            nue_var.cmd.Parameters.Add("?dicom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dicom
            nue_var.cmd.Parameters.Add("?fecha_ingreso", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = fecha_ingreso
            nue_var.cmd.Parameters.Add("?observacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observacion
            nue_var.cmd.Parameters.Add("?maquinas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquinas
            nue_var.cmd.Parameters.Add("?email_contacto2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_contacto2
            nue_var.cmd.Parameters.Add("?actualizado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = actualizado
            nue_var.cmd.Parameters.Add("?giro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = giro
            nue_var.cmd.Parameters.Add("?email_contacto_despacho2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_contacto_despacho2
            nue_var.cmd.Parameters.Add("?referencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = referencia
            nue_var.cmd.Parameters.Add("?ficha_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ficha_cliente
            nue_var.cmd.Parameters.Add("?encargado_produccion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = encargado_produccion
            nue_var.cmd.Parameters.Add("?maquina16", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquina16
            nue_var.cmd.Parameters.Add("?maquina18", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquina18
            nue_var.cmd.Parameters.Add("?maquina320", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquina320
            nue_var.cmd.Parameters.Add("?ejec_new", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_new
            nue_var.cmd.Parameters.Add("?ejec_cobranza", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejec_cobranza

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para eliminar Representantes
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Clientes WHERE id_clientes = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2(ByVal nombre_rut As String) As String
        Dim Rut As String
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Rut FROM Clientes where rut like '%" & nombre_rut & "%'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        If nue_var.dt.Rows.Count > 0 Then
            Rut = nue_var.dt.Rows(0)("rut").ToString()
        Else
            Rut = ""
        End If
        nue_conexion.desconectar()
        'listar4 = nue_var.dt
        Return Rut
    End Function
    Public Function listar3(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes where clientes like '%" & cliente & "%' order by clientes desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes where rut like '%" & cliente & "%' order by rut desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Sub insertar2(ByVal usuario As String, ByVal rut As String, ByVal cliente As String, ByVal fecha As Date, ByVal hora As Date, ByVal bloqueo_desbloqueo As String, ByVal senal_advertencia As String, ByVal razon As String)
        nue_var.consulta = "INSERT INTO bloqueo VALUES('',?usuario, ?rut, ?cliente, ?fecha, ?hora, ?bloqueo_desbloqueo, ?senal_advertencia, ?razon)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?bloqueo_desbloqueo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = bloqueo_desbloqueo
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?razon", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

End Class