Imports MySql.Data.MySqlClient
Public Class Tipo_Maquina

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los Tipos de máquina
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Tipo_maq order by Categoria desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar Representantes
    Public Sub insertar(ByVal Categoria As String, ByVal Tipo_de_maquinaria As String, ByVal Recupera As String)
        nue_var.consulta = "INSERT INTO Tipo_maq VALUES('',?categoria, ?tipo_de_maquinaria, ?recupera)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?categoria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Categoria
            nue_var.cmd.Parameters.Add("?Tipo_de_maquinaria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_de_maquinaria
            nue_var.cmd.Parameters.Add("?recupera", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Recupera
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar Tipo de máquina
    Public Sub modificar(ByVal cod_est As Integer, ByVal Categoria As String, ByVal Tipo_de_maquinaria As String, ByVal Recupera As String)
        nue_var.consulta = "UPDATE Tipo_maq SET Categoria = ?categoria, Tipo_de_maquinaria = ?tipo_de_maquinaria, Recupera = ?recupera  WHERE Id_tipo_maq = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?categoria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Categoria
            nue_var.cmd.Parameters.Add("?Tipo_de_maquinaria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_de_maquinaria
            nue_var.cmd.Parameters.Add("?recupera", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Recupera
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para eliminar Tipo de Maquina 
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Tipo_maq WHERE Id_tipo_maq = " & cod_est & ""

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