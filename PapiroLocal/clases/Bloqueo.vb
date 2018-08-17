Imports MySql.Data.MySqlClient
Public Class Bloqueo
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String


    Public Function listar(ByVal rut As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM bloqueo where rut like '" & rut & "'  order by fecha desc, hora desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
   
    Public Sub insertar2(ByVal usuario As String, ByVal rut As String, ByVal cliente As String, ByVal fecha As Date, ByVal hora As Date, ByVal bloqueo_desbloqueo As String, ByVal senal_advertencia As String, ByVal razon As String)
        nue_var.consulta = "INSERT INTO bloqueo VALUES('',?usuario, ?rut, ?cliente, ?fecha, ?hora, ?bloqueo_desbloqueo, ?senal_advertencia, ?razon)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?bloqueo_desbloqueo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = bloqueo_desbloqueo
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?razon", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
