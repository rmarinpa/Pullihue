Imports MySql.Data.MySqlClient
Public Class matricula

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las matriculas
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * FROM matricula INNER JOIN estudiante ON estudiante.cod_estudiante = matricula.cod_estudiante INNER JOIN curso ON curso.cod_curso = matricula.cod_curso INNER JOIN jornada ON jornada.cod_jornada = matricula.cod_jornada INNER JOIN usuario ON usuario.cod_usuario = matricula.cod_usuario ", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar matriculas
    Public Sub insertar(ByVal tipo_mat As String, ByVal cod_est As Integer, ByVal curso As Integer, ByVal jor As Integer, ByVal fecha As Date, ByVal monto As Double, ByVal usuario As Integer)
        nue_var.consulta = "INSERT INTO matricula VALUES('', ?tip_mat, ?cod_est, ?cod_curso, ?cod_jor, ?fech, ?monto, ?cod_usua)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?tip_mat", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_mat
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?cod_curso", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = curso
            nue_var.cmd.Parameters.Add("?cod_jor", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = jor
            nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = monto
            nue_var.cmd.Parameters.Add("?cod_usua", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = usuario
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

End Class
