Imports MySql.Data.MySqlClient
Public Class Plan_de_cuentas

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Plan de Cuentas
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Plan_de_cuentas where obra like '%" & nombre_obra & "%' order by cuenta_costo asc", nue_conexion.conex())
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
    Public Sub insertar(ByVal Cuenta_Costo As String, ByVal Descripcion As String, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Plan_de_cuentas VALUES('', ?Cuenta_costo, ?Descripcion, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cuenta_Costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_Costo
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Plan de Cuentas   
    Public Sub modificar(ByVal Cod_Plan_de_cuentas As Integer, ByVal Cuenta_costo As String, ByVal Descripcion As String, ByVal obra As String)
        nue_var.consulta = "UPDATE Plan_de_cuentas SET Cuenta_costo = ?Cuenta_costo, Descripcion = ?Descripcion, Obra = ?obra WHERE Id_plan_de_cuentas = ?Cod_Plan_de_cuentas"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Plan_de_cuentas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Plan_de_cuentas
            nue_var.cmd.Parameters.Add("?Cuenta_costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_costo
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_plan_de_cuentas As Integer)
        nue_var.consulta = "Delete from Plan_de_cuentas WHERE Id_plan_de_cuentas = " & cod_plan_de_cuentas & ""

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
