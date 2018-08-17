Imports MySql.Data.MySqlClient
Public Class Storage

    Dim nue_conexion As New conexion
    Dim nue_conexion2 As New conexion
    Dim nue_var As New variables
    Dim nue_var1 As New variables

    'funcion para listar las Contratos
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from Storage where Obra like '%" & nombre_obra & "%' order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Descuentos
    Public Sub insertar(ByVal N_guia As Double, ByVal Litros As Double, ByVal Fecha As Date, ByVal Obra As String)
        nue_var.consulta = "INSERT INTO Storage VALUES('', ?N_guia, ?Litros, ?fecha, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?N_guia", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_guia
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Litros
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Descuentos
    Public Sub modificar(ByVal cod_est As Integer, ByVal N_guia As Double, ByVal Litros As Double, ByVal Fecha As Date, ByVal Obra As String)
        nue_var.consulta = "UPDATE Storage SET N_guia = ?N_guia, Litros = ?Litros, Fecha = ?fecha, Obra = ?obra  WHERE Id_storage = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
             nue_var.cmd.Parameters.Add("?N_guia", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_guia
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Litros
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Storage WHERE Id_storage = " & cod_est & ""

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
