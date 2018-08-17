Imports MySql.Data.MySqlClient
Public Class Sustitutos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    'funcion para listar los registros de Petroleo
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM sustituto order by codigo1 desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Petroleo
    Public Sub insertar(ByVal codigo1 As String, ByVal descripcion1 As String, ByVal codigo2 As String, ByVal descripcion2 As String)
        nue_var.consulta = "INSERT INTO sustituto VALUES('', ?codigo1, ?descripcion1, ?codigo2, ?descripcion2)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?codigo1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo1
            nue_var.cmd.Parameters.Add("?descripcion1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion1
            nue_var.cmd.Parameters.Add("?codigo2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo2
            nue_var.cmd.Parameters.Add("?descripcion2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion2

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Petroleo   
    Public Sub modificar(ByVal Cod_Petroleo As Integer, ByVal codigo1 As String, ByVal descripcion1 As String, ByVal codigo2 As String, ByVal descripcion2 As String)
        nue_var.consulta = "UPDATE sustituto SET codigo1 = ?codigo1, descripcion1 = ?descripcion1, codigo2 = ?codigo2, descripcion2 = ?descripcion2 WHERE Id_sustituto = ?Cod_Petroleo"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Petroleo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Petroleo
            nue_var.cmd.Parameters.Add("?codigo1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo1
            nue_var.cmd.Parameters.Add("?descripcion1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion1
            nue_var.cmd.Parameters.Add("?codigo2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo2
            nue_var.cmd.Parameters.Add("?descripcion2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion2
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'funcion para buscar el nombre de la máquina.
    Public Function descripcion_producto(ByVal cod As String) As String
        nue_var.consulta = "SELECT Descripcion FROM Codigos4 WHERE Codigo = ?cod"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cod", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_producto = nue_var.dr("Descripcion")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_producto
    End Function
    Public Function descripcion_producto2(ByVal cod As String) As String
        nue_var.consulta = "SELECT Descripcion FROM Codigos4 WHERE Codigo = ?cod"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cod", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_producto2 = nue_var.dr("Descripcion")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_producto2
    End Function
    Public Sub eliminar(ByVal cod_petroleo As Integer)
        nue_var.consulta = "Delete from sustituto WHERE Id_sustituto = " & cod_petroleo & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 order by Codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4  order by Codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
End Class
