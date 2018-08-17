Imports MySql.Data.MySqlClient
Public Class Ticket


    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    'nombre, , fecha
    Public Sub NuevoTicket(ByVal nombre As String, ByVal asunto As String, ByVal departamento As String, ByVal prioridad As String, ByVal fecha As Date)
        nue_var.consulta = "INSERT INTO solicitud (nombre, asunto, departamento, prioridad, fecha_ingreso) VALUES(?nombre, ?asunto, ?departamento, ?prioridad, ?fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?asunto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = asunto
            nue_var.cmd.Parameters.Add("?departamento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = departamento
            nue_var.cmd.Parameters.Add("?prioridad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = prioridad
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha detactado un error inesperado al tratar de almacenar el ticket." & vbNewLine & mierror.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ModificarTicket(ByVal id As Integer, ByVal prioridad As String, ByVal fecha As Date, ByVal estado As Boolean, ByVal nombre As String)
        nue_var.consulta = "UPDATE solicitud SET prioridad = ?prioridad, fecha_respuesta = ?fecha, estado = ?estado, nombre = ?nombre WHERE id = ?id;"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?prioridad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = prioridad
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = estado
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?id", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = id
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha detactado un error inesperado al tratar de modificar el ticket." & vbNewLine & mierror.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function BuscarTicket(ByVal nombre As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM solicitud WHERE nombre LIKE '%" & nombre & "%' ORDER BY fecha_ingreso ASC", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        BuscarTicket = nue_var.dt
        Return BuscarTicket
    End Function
    Public Function BuscarTicket(ByVal id As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM solicitud WHERE id = " & id, nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        BuscarTicket = nue_var.dt
        Return BuscarTicket
    End Function
    'Public Function BuscarTicket(ByVal id As Integer) As String
    '    nue_var.consulta = "SELECT nombre FROM solicitud WHERE id = " & id
    '    nue_conexion.conectar()
    '    nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
    '    nue_var.dr = nue_var.cmd.ExecuteReader()
    '    If nue_var.dr.Read Then
    '        If IsDBNull(nue_var.dr("nombre")) Then
    '            BuscarTicket = ""
    '        Else
    '            BuscarTicket = nue_var.dr("nombre")
    '        End If
    '    End If
    '    nue_var.dr.Close()
    '    nue_conexion.desconectar()
    '    Return BuscarTicket
    'End Function
    Public Function ListarTicket(ByVal minimo As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM solicitud WHERE estado = 1 ORDER BY fecha_ingreso ASC LIMIT " & minimo & ", 10;", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        ListarTicket = nue_var.dt
        Return ListarTicket
    End Function
    Public Function ListarTicket(ByVal nombre As String, ByVal asunto As String) As Integer
        nue_var.consulta = "SELECT COUNT(*) as cantidad FROM solicitud WHERE nombre LIKE '%" & nombre & "%' AND asunto LIKE '%" & asunto & "%' ORDER BY fecha_ingreso ASC"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("cantidad")) Then
                ListarTicket = ""
            Else
                ListarTicket = nue_var.dr("cantidad")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return ListarTicket
    End Function
    Public Function ListarTicket(ByVal nombre As String, ByVal asunto As String, ByVal minimo As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM solicitud WHERE nombre LIKE '%" & nombre & "%' AND asunto LIKE '%" & asunto & "%' ORDER BY fecha_ingreso ASC LIMIT " & minimo & ", 10;", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        ListarTicket = nue_var.dt
        Return ListarTicket
    End Function

    Public Function BuscarDatosTicket(ByVal id As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM solicitud WHERE id = " & id & ";", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        BuscarDatosTicket = nue_var.dt
        Return BuscarDatosTicket
    End Function

    Public Function BuscarNombre(ByVal nombre As String) As String
        nue_var.consulta = "SELECT COUNT(nombre) As cantidad FROM solicitud WHERE nombre LIKE '" & nombre & "%'"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("cantidad")) Then
                BuscarNombre = ""
            Else
                BuscarNombre = nue_var.dr("cantidad")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return BuscarNombre
    End Function

End Class