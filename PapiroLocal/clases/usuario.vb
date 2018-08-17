Imports MySql.Data.MySqlClient
Public Class usuario

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

    'funcion para listar las obras
    Public Function listar2() As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM Departamento", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            listar2 = nue_var.dt
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & vbCrLf & ex.Message)
        End Try
        Return listar2
    End Function

    'procedimiento para insertar usuarios
    Public Sub insertar(ByVal nom As String, ByVal pass As String)
        nue_var.consulta = "INSERT INTO usuario VALUES('', ?nom, ?pass)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar usuarios
    Public Sub modificar(ByVal cod_usua As Integer, ByVal nom As String, ByVal pass As String)
        nue_var.consulta = "UPDATE usuario SET nombre = ?nom, password = ?pass WHERE cod_usuario = ?cod_usua"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_usua
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'funcion que verifica si un usuario existe
    Public Function verificar(ByVal nom As String, ByVal pass As String, ByVal obra As String) As Boolean


        Try
            nue_var.consulta = "SELECT * FROM usuario WHERE nombre = ?nom and password = ?pass and obra = ?obra"
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
            nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.dr = nue_var.cmd.ExecuteReader()
            If nue_var.dr.Read Then
                verificar = True
            Else
                verificar = False
            End If
            nue_var.dr.Close()
            nue_conexion.desconectar()

        Catch ex As Exception
            MsgBox("Ha ocurrido un errors: " & vbCrLf & ex.Message)
        End Try
        Return verificar

    End Function

    'funcion que retorna el codigo usuario
    Public Function cod_usuario(ByVal nom As String, ByVal pass As String) As Integer
        nue_var.consulta = "SELECT * FROM usuario WHERE nombre = ?nom and password = ?pass"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
        nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            cod_usuario = nue_var.dr("cod_usuario")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return cod_usuario
    End Function

End Class
