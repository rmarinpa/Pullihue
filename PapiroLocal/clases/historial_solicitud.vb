Imports MySql.Data.MySqlClient
Public Class Historial_solicitud

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Sub NuevaObservacion(ByVal comentario As String, ByVal ingresado As Date, ByVal usuario As String, ByVal imagen As String)
        nue_var.consulta = "INSERT INTO historial_solicitud_ticket (comentario, ingresado, usuario, solicitud_id, imagen) VALUES (?comentario, ?ingresado, ?usuario, (SELECT(Max(id)) FROM solicitud), ?imagen)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?comentario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comentario
            nue_var.cmd.Parameters.Add("?ingresado", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = ingresado
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?imagen", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = imagen
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha detactado un error inesperado al tratar de almacenar la observación del ticket." & vbNewLine & mierror.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub NuevaObservacion(ByVal comentario As String, ByVal ingresado As Date, ByVal usuario As String, ByVal solicitud_id As Integer, ByVal imagen As String)
        nue_var.consulta = "INSERT INTO historial_solicitud_ticket (comentario, ingresado, usuario, solicitud_id, imagen) VALUES (?comentario, ?ingresado, ?usuario, ?solicitud_id, ?imagen)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?comentario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comentario
            nue_var.cmd.Parameters.Add("?ingresado", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = ingresado
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?solicitud_id", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = solicitud_id
            nue_var.cmd.Parameters.Add("?imagen", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = imagen
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha detactado un error inesperado al tratar de almacenar la observación del ticket." & vbNewLine & mierror.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ModificarObservacion(ByVal id As Integer, ByVal prioridad As Integer, ByVal fecha As Date, ByVal estado As Boolean)
        nue_var.consulta = "UPDATE solicitud SET prioridad = ?prioridad, fecha_respuesta = ?fecha, estado = ?estado WHERE id = ?id;"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?prioridad", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = prioridad
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = estado
            nue_var.cmd.Parameters.Add("?id", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = id
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha detactado un error inesperado al tratar de modificar la observación del ticket." & vbNewLine & mierror.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function BuscarHistorialTicket(ByVal solicitud_id As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM historial_solicitud_ticket WHERE solicitud_id = " & solicitud_id & " ORDER BY ingresado DESC", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        BuscarHistorialTicket = nue_var.dt
        Return BuscarHistorialTicket
    End Function

End Class
