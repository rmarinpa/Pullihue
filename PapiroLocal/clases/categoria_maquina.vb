Imports MySql.Data.MySqlClient
Public Class categoria_maquina

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los Tipos de máquina
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tipo_categoria order by tipo_categoria desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar Representantes
    Public Sub insertar(ByVal tipo_categoria As String, ByVal capacidad As Double, ByVal unidad As String)
        nue_var.consulta = "INSERT INTO tipo_categoria VALUES('',?tipo_categoria, ?capacidad, ?unidad)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?tipo_categoria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_categoria
            nue_var.cmd.Parameters.Add("?capacidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = capacidad
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar Tipo de máquina
    Public Sub modificar(ByVal cod_est As Integer, ByVal Tipo_categoria As String, ByVal Capacidad As Double, ByVal Unidad As String)
        nue_var.consulta = "UPDATE tipo_categoria SET Tipo_categoria = ?Tipo_categoria, Capacidad = ?Capacidad, Unidad = ?Unidad  WHERE Id_categoria = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?Tipo_categoria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_categoria
            nue_var.cmd.Parameters.Add("?Capacidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Capacidad
            nue_var.cmd.Parameters.Add("?Unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Unidad
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para eliminar Tipo de Maquina 
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from tipo_categoria WHERE Id_categoria = " & cod_est & ""

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