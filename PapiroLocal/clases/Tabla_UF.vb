Imports MySql.Data.MySqlClient
Public Class Tabla_UF

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Plan de Cuentas
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Tabla_UF where obra like '%" & nombre_obra & "%' order by Fecha_termino desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Plan de Cuentas
    Public Sub insertar(ByVal fecha As Date, ByVal valor_uf As Double, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Tabla_UF VALUES('', ?fecha, ?valor_uf, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?valor_uf", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_uf
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Plan de Cuentas   
    Public Sub modificar(ByVal Cod_tabla_uf As Integer, ByVal fecha As Date, ByVal valor_uf As Double, ByVal obra As String)
        nue_var.consulta = "UPDATE Tabla_UF SET Fecha_termino = ?fecha, UF = ?valor_uf, Obra = ?obra WHERE Id_UF = ?Cod_tabla_uf"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_tabla_uf", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_tabla_uf
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?valor_uf", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_uf
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_plan_de_cuentas As Integer)
        nue_var.consulta = "Delete from Tabla_UF WHERE Id_UF = " & cod_plan_de_cuentas & ""

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
