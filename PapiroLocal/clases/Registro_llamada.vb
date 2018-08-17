Imports MySql.Data.MySqlClient
Public Class Registro_llamada

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal Cliente As String, ByVal atendio As String, ByVal motivo As String, ByVal telefono As String, ByVal tipo_llamada As String, ByVal llamada_iniciada As Date, ByVal llamada_finalizada As Date, ByVal duracion As Date, ByVal estado_de_linea As String, ByVal importancia As String, ByVal informe As String, ByVal fecha As Date, ByVal usuario As String, ByVal tipo As String, ByVal tipo_medio As String, ByVal folio As Double)
        nue_var.consulta = "INSERT INTO registro_llamada VALUES('', ?Cliente, ?atendio, ?motivo, ?telefono, ?tipo_llamada, ?llamada_iniciada, ?llamada_finalizada, ?duracion, ?estado_de_linea, ?importancia, ?informe, ?fecha, ?usuario, ?tipo, ?tipo_medio, ?folio)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cliente
            nue_var.cmd.Parameters.Add("?atendio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = atendio
            nue_var.cmd.Parameters.Add("?motivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = motivo
            nue_var.cmd.Parameters.Add("?telefono", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefono
            nue_var.cmd.Parameters.Add("?tipo_llamada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_llamada
            nue_var.cmd.Parameters.Add("?llamada_iniciada", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = llamada_iniciada
            nue_var.cmd.Parameters.Add("?llamada_finalizada", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = llamada_finalizada
            nue_var.cmd.Parameters.Add("?duracion", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = duracion
            nue_var.cmd.Parameters.Add("?estado_de_linea", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado_de_linea
            nue_var.cmd.Parameters.Add("?importancia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = importancia
            nue_var.cmd.Parameters.Add("?informe", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = informe
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?tipo_medio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_medio
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2(ByVal fecha_in As String, ByVal fecha_fin As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Cliente FROM registro_llamada Where fecha >= '" & fecha_in & "' and fecha <= '" & fecha_fin & "' GROUP BY Cliente", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal fecha_in As String, ByVal fecha_fin As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT usuario FROM registro_llamada Where fecha >= '" & fecha_in & "' and fecha <= '" & fecha_fin & "' GROUP BY usuario", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Sub insertar2(ByVal fecha_actual As Date, ByVal fecha_programada As Date, ByVal Tipo As String, ByVal folio As Double, ByVal hecho As String)
        nue_var.consulta = "INSERT INTO programacion_llamadas VALUES('', ?fecha_actual, ?fecha_programada, ?Tipo, ?folio, ?hecho)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha_actual", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_actual
            nue_var.cmd.Parameters.Add("?fecha_programada", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_programada
            nue_var.cmd.Parameters.Add("?Tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?hecho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = hecho
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function descripcion_numero_folio() As Double
        nue_var.consulta = "SELECT folio FROM programacion_llamadas order by folio desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio")) Then
                descripcion_numero_folio = 0
            Else
                descripcion_numero_folio = nue_var.dr("folio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_folio
    End Function
    Public Sub modificar(ByVal Cliente As String, ByVal motivo As String, ByVal informe As String, ByVal folio As Double)
        nue_var.consulta = "UPDATE registro_llamada SET Cliente = ?Cliente, motivo = ?motivo, informe = ?informe WHERE folio = ?folio"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cliente
            nue_var.cmd.Parameters.Add("?motivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = motivo
            nue_var.cmd.Parameters.Add("?informe", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = informe
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar2(ByVal fecha_programada As Date, ByVal Tipo As String, ByVal folio As Double)
        nue_var.consulta = "UPDATE programacion_llamadas SET fecha_programada = ?fecha_programada WHERE folio = ?folio"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha_programada", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_programada
            nue_var.cmd.Parameters.Add("?Tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar3(ByVal rut As String, ByVal contacto_pago_proveedores As String, ByVal cargo_contacto_pago As String, ByVal telefonos_cargo_contacto As String, ByVal email_contacto_pago As String)
        nue_var.consulta = "UPDATE Clientes SET contacto_pago_proveedores = ?contacto_pago_proveedores, cargo_contacto_pago = ?cargo_contacto_pago, telefonos_cargo_contacto = ?telefonos_cargo_contacto, email_contacto_pago = ?email_contacto_pago WHERE rut = ?rut"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?contacto_pago_proveedores", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = contacto_pago_proveedores
            nue_var.cmd.Parameters.Add("?cargo_contacto_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cargo_contacto_pago
            nue_var.cmd.Parameters.Add("?telefonos_cargo_contacto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = telefonos_cargo_contacto
            nue_var.cmd.Parameters.Add("?email_contacto_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email_contacto_pago
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
