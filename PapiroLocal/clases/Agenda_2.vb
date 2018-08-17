Imports MySql.Data.MySqlClient
Public Class Agenda_2

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    'funcion para listar los registros de Petroleo
    Public Function listar(ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM agenda where fecha_programada = '" & fecha & "' and importancia <> '' order by Tipo_programacion asc, Cliente asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Contrato where obra like '%" & nombre_obra & "%' order by Codigo_maquina asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    'procedimiento para insertar registros de Petroleo
    Public Sub insertar(ByVal N_de_vale As Double, ByVal Codigo As String, ByVal fecha As Date, ByVal litros_consumo As Double, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Petroleo VALUES('', ?N_de_vale, ?Codigo, ?fecha, ?litros_consumo, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?N_de_vale", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_de_vale
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = litros_consumo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Petroleo   
    Public Sub modificar(ByVal folio As Integer, ByVal hecho As String)
        nue_var.consulta = "UPDATE programacion_llamadas SET hecho = ?hecho WHERE folio = ?folio"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = folio
            nue_var.cmd.Parameters.Add("?hecho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = hecho
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'funcion para buscar el nombre de la máquina.
    Public Function descripcion_patente(ByVal num_id As String, ByVal obra As String) As String
        nue_var.consulta = "SELECT Ins_reg_civil FROM Contrato WHERE Codigo_maquina = ?num_id and Obra = ?obra"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_id
        nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_patente = nue_var.dr("Ins_reg_civil")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_patente
    End Function
    Public Sub eliminar(ByVal cod_petroleo As Integer)
        nue_var.consulta = "Delete from Petroleo WHERE Id_petroleo = " & cod_petroleo & ""

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
