Imports MySql.Data.MySqlClient
Public Class curso

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los cursos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MysqlDataAdapter("SELECT * FROM curso", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar cursos
    Public Sub insertar(ByVal nom As String)
        nue_var.consulta = "INSERT INTO curso VALUES('', ?nom)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar cursos
    Public Sub modificar(ByVal cod_cur As Integer, ByVal nom As String)
        nue_var.consulta = "UPDATE curso SET nombre = ?nom WHERE cod_curso = ?cod_cur"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_cur
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

End Class