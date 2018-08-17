Imports MySql.Data.MySqlClient
Public Class Usuario_adm


    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    'funcion para listar los registros de Usuario
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_adm where modulo_id = 1 order by tipo_nombre asc, usuario asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar registros de Usuario
    Public Sub insertar(ByVal tipo_nombre As String, ByVal usuario As String, ByVal tipo_id As Integer, ByVal modulo_nombre As String, ByVal modulo_id As Integer)
        nue_var.consulta = "INSERT INTO usuario_adm VALUES('', ?tipo_nombre, ?usuario, ?tipo_id, ?modulo_nombre, ?modulo_id)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?tipo_nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_nombre
            nue_var.cmd.Parameters.Add("?tipo_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tipo_id
            nue_var.cmd.Parameters.Add("?modulo_nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = modulo_nombre
            nue_var.cmd.Parameters.Add("?modulo_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = modulo_id

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Usuario   
    Public Sub modificar(ByVal Cod_usuario As Integer, ByVal tipo_nombre As String, ByVal usuario As String, ByVal tipo_id As Integer, ByVal modulo_nombre As String, ByVal modulo_id As Integer)
        nue_var.consulta = "UPDATE usuario_adm SET tipo_nombre = ?tipo_nombre, usuario = ?usuario, tipo_id = ?tipo_id, modulo_nombre = ?modulo_nombre, modulo_id = ?modulo_id WHERE Id_usuario = ?Cod_usuario"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_usuario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_usuario
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?tipo_nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_nombre
            nue_var.cmd.Parameters.Add("?tipo_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tipo_id
            nue_var.cmd.Parameters.Add("?modulo_nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = modulo_nombre
            nue_var.cmd.Parameters.Add("?modulo_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = modulo_id
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal Cod_Usuario As Integer)
        nue_var.consulta = "Delete from usuario_adm WHERE Id_usuario = " & Cod_Usuario & ""

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
