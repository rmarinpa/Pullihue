Imports MySql.Data.MySqlClient
Public Class estudiante

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los estudiantes
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MysqlDataAdapter("SELECT * FROM estudiante", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar estudiantes
    Public Sub insertar(ByVal num_id As Double, ByVal nom As String, ByVal ape1 As String, ByVal ape2 As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As Double)
        nue_var.consulta = "INSERT INTO estudiante VALUES('', ?num_id, ?nom, ?ape1, ?ape2, ?fech, ?dir, ?tel)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?ape1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape1
            nue_var.cmd.Parameters.Add("?ape2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape2
            nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?dir", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dir
            nue_var.cmd.Parameters.Add("?tel", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tel
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar estudiantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal num_id As Double, ByVal nom As String, ByVal ape1 As String, ByVal ape2 As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As Double)
        nue_var.consulta = "UPDATE estudiante SET num_documento = ?num_id, nombres = ?nom, apellido1 = ?ape1, apellido2 = ?ape2, direccion= ?dir, telefono = ?tel WHERE cod_estudiante = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?ape1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape1
            nue_var.cmd.Parameters.Add("?ape2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape2
            nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?dir", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dir
            nue_var.cmd.Parameters.Add("?tel", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tel
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'funcion para buscar el nombre del estudiante
    Public Function nombre_estudiante(ByVal num_id As Double) As String
        nue_var.consulta = "SELECT nombres FROM estudiante WHERE num_documento = ?num_id"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            nombre_estudiante = nue_var.dr("nombres")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return nombre_estudiante
    End Function

    'funcion para buscar el apellido del estudiante
    Public Function apellido_estudiante(ByVal num_id As Double) As String
        nue_var.consulta = "SELECT apellido1 FROM estudiante WHERE num_documento = ?num_id"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            apellido_estudiante = nue_var.dr("apellido1")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return apellido_estudiante
    End Function

    'funcion que retorna el codigo del estudiante
    Public Function cod_estudiante(ByVal num_id As Double) As Integer
        nue_var.consulta = "SELECT cod_estudiante FROM estudiante WHERE num_documento = ?num_id"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            cod_estudiante = nue_var.dr("cod_estudiante")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return cod_estudiante
    End Function

    'funcion que verifica si un estudiante existe
    Public Function verificar(ByVal num_id As Double) As Boolean
        nue_var.consulta = "SELECT * FROM estudiante WHERE num_documento = ?num_id"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar = True
        Else
            verificar = False
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar
    End Function

End Class
