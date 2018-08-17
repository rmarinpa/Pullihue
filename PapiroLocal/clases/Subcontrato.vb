Imports MySql.Data.MySqlClient
Public Class Subcontrato

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los Tipos de Subcontratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tipo_subcontrato order by tipo_subcontrato desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar Tipos de Subcontratos
    Public Sub insertar(ByVal tipo_subcontrato As String, ByVal descripcion As String)
        nue_var.consulta = "INSERT INTO tipo_subcontrato VALUES('',?tipo_subcontrato, ?descripcion)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar Tipo de Subcontrato 
    Public Sub modificar(ByVal cod_est As Integer, ByVal tipo_subcontrato As String, ByVal descripcion As String)
        nue_var.consulta = "UPDATE tipo_subcontrato SET tipo_subcontrato = ?tipo_subcontrato, descripcion = ?descripcion  WHERE Id_tipo_subcontrato = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para eliminar Tipo de Subcontrato 
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from tipo_subcontrato WHERE Id_tipo_subcontrato = " & cod_est & ""

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