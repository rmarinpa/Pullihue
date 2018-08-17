Imports MySql.Data.MySqlClient
Public Class Parametros_configuracion

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Plan de Cuentas
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Parametros_configuracion where Obra like '%" & nombre_obra & "%' order by id_configuracion asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Contrato where obra like '%" & nombre_obra & "%'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    'procedimiento para insertar registros de Plan de Cuentas
    Public Sub insertar(ByVal Encargado_oficina_tecnica As String, ByVal profesional_residente As String, ByVal Obra As String, ByVal Detalle_Obra As String)
        nue_var.consulta = "INSERT INTO Parametros_configuracion VALUES('', ?Encargado_oficina_tecnica, ?profesional_residente, ?obra, ?Detalle_Obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Encargado_oficina_tecnica", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Encargado_oficina_tecnica
            nue_var.cmd.Parameters.Add("?profesional_residente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = profesional_residente
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.Parameters.Add("?Detalle_Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Detalle_Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Plan de Cuentas   
    Public Sub modificar(ByVal Cod_Parametros_configuracion As Integer, ByVal Encargado_oficina_tecnica As String, ByVal profesional_residente As String, ByVal Obra As String, ByVal Detalle_Obra As String)
        nue_var.consulta = "UPDATE Parametros_configuracion SET Encargado_oficina_tecnica = ?Encargado_oficina_tecnica, profesional_residente = ?profesional_residente, Obra = ?obra, Detalle_Obra = ?Detalle_Obra WHERE Id_configuracion = ?Cod_Parametros_configuracion"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Parametros_configuracion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Parametros_configuracion
            nue_var.cmd.Parameters.Add("?Encargado_oficina_tecnica", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Encargado_oficina_tecnica
            nue_var.cmd.Parameters.Add("?profesional_residente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = profesional_residente
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?Detalle_Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Detalle_Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal Cod_Parametros_configuracion As Integer)
        nue_var.consulta = "Delete from Parametros_configuracion WHERE Id_plan_de_cuentas = " & Cod_Parametros_configuracion & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
