Imports MySql.Data.MySqlClient
Public Class usuario_conf

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los usuarios
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar usuarios
    Public Sub insertar(ByVal nom As String, ByVal pass As String, ByVal departamento As String)
        nue_var.consulta = "INSERT INTO usuario VALUES('', ?nom, ?pass, ?departamento)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
            nue_var.cmd.Parameters.Add("?departamento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = departamento
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar usuarios
    Public Sub modificar(ByVal cod_usua As Integer, ByVal nom As String, ByVal pass As String, ByVal Obra As String)
        nue_var.consulta = "UPDATE usuario SET nombre = ?nom, password = ?pass, Obra = ?Obra WHERE cod_usuario = ?cod_usua"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_usua", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_usua
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_petroleo As Integer)
        nue_var.consulta = "Delete from usuario WHERE cod_usuario = " & cod_petroleo & ""

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
