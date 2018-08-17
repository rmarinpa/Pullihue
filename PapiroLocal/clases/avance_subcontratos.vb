Imports MySql.Data.MySqlClient
Public Class avance_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Movimiento de Tierra
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM avance_subcontrato where Obra like '%" & nombre_obra & "%' order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes_subcontratos where obra like '%" & nombre_obra & "%' order by Id_representante asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal codigo_subcontrato As String, ByVal fecha As Date, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal item As String, ByVal avance As Double, ByVal tipo_de_medicion As String, ByVal observaciones As String, ByVal obra As String)
        nue_var.consulta = "INSERT INTO avance_subcontrato VALUES('', ?Codigo, ?fecha, ?representante, ?tipo_subcontrato, ?item, ?avance, ?tipo_de_medicion, ?observaciones, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_subcontrato
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?avance", MySql.Data.MySqlClient.MySqlDbType.Double).Value = avance
            nue_var.cmd.Parameters.Add("?tipo_de_medicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_medicion
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Movimiento de Tierra   
    Public Sub modificar(ByVal Cod_Mov_Tierra As Integer, ByVal codigo_subcontrato As Double, ByVal fecha As Date, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal item As String, ByVal avance As Double, ByVal tipo_de_medicion As String, ByVal observaciones As String, ByVal obra As String)
        nue_var.consulta = "UPDATE avance_subcontrato SET codigo_subcontrato = ?Codigo, fecha = ?fecha, representante = ?representante, tipo_subcontrato = ?tipo_subcontrato, item = ?item, avance = ?avance, tipo_de_medicion = ?tipo_de_medicion, observaciones = ?observaciones, Obra = ?obra WHERE Id_avance_subcontrato = ?Cod_Mov_Tierra"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Mov_Tierra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Mov_Tierra
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = codigo_subcontrato
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?avance", MySql.Data.MySqlClient.MySqlDbType.Double).Value = avance
            nue_var.cmd.Parameters.Add("?tipo_de_medicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_medicion
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from avance_subcontrato WHERE Id_avance_subcontrato = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'funcion para buscar el nombre de la máquina.
    Public Function descripcion_representante(ByVal num_id As String, ByVal obra As String) As String
        nue_var.consulta = "SELECT Nombre FROM Representantes_subcontratos WHERE Id_representante = ?num_id and Obra = ?obra"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_id
        nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_representante = nue_var.dr("Nombre")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_representante
    End Function
    Public Function descripcion_tipo_subcontrato(ByVal num_id As String, ByVal obra As String) As String
        nue_var.consulta = "SELECT tipo_subcontrato FROM Representantes_subcontratos WHERE Id_representante = ?num_id and Obra = ?obra"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_id
        nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_tipo_subcontrato = nue_var.dr("tipo_subcontrato")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_tipo_subcontrato
    End Function
    Public Function descripcion_tipo_medicion(ByVal num_id As String, ByVal obra As String, ByVal glosa As String) As String
        nue_var.consulta = "SELECT tipo_de_medicion FROM registro_subcontrato WHERE codigo_subcontrato = ?num_id and Obra = ?obra and glosa = ?glosa"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_id
        nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
        nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_tipo_medicion = nue_var.dr("tipo_de_medicion")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_tipo_medicion
    End Function

    Public Function listar3(ByVal nombre_obra As String, ByVal codigo As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM registro_subcontrato where Obra like '%" & nombre_obra & "%' and codigo_subcontrato like '%" & codigo & "%' order by glosa desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
End Class
