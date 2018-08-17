Imports MySql.Data.MySqlClient
Public Class registro_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Movimiento de Tierra
    Public Function listar(ByVal nombre_obra As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM avance_estado_de_pago where obra like '%" & nombre_obra & "%' order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal Codigo As String, ByVal glosa As String, ByVal cantidad As Double, ByVal fecha As Date, ByVal obra As String)
        nue_var.consulta = "INSERT INTO avance_estado_de_pago VALUES('', ?Codigo, ?glosa, ?cantidad, ?fecha, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Movimiento de Tierra   
    Public Sub modificar(ByVal Cod_Mov_Tierra As Integer, ByVal Codigo As String, ByVal glosa As String, ByVal cantidad As Double, ByVal fecha As Date, ByVal obra As String)
        nue_var.consulta = "UPDATE avance_estado_de_pago SET codigo_subcontrato = ?Codigo, Glosa = ?glosa, cantidad = ?cantidad, Fecha = ?fecha, Obra = ?obra WHERE Id_registro_subcontrato = ?Cod_Mov_Tierra"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Mov_Tierra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Mov_Tierra
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from avance_estado_de_pago WHERE Id_registro_subcontrato = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes_subcontratos where obra like '%" & nombre_obra & "%' order by Id_representante asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal nombre_obra As String, ByVal codigo_subcontrato As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM registro_subcontrato where Obra like '%" & nombre_obra & "%' and codigo_subcontrato like '" & codigo_subcontrato & "' order by codigo_subcontrato desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
End Class
