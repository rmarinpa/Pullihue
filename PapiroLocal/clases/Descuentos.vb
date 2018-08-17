Imports MySql.Data.MySqlClient
Public Class Descuentos

    Dim nue_conexion As New conexion
    Dim nue_conexion2 As New conexion
    Dim nue_var As New variables
    Dim nue_var1 As New variables

    'funcion para listar las Contratos
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from Descuentos_empresa where obra like '%" & nombre_obra & "%' order by Fecha desc, Nombre_representante desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Descuentos
    Public Sub insertar(ByVal Nombre_representante As String, ByVal Clasificacion As String, ByVal Descripcion As String, ByVal Cantidad As Double, ByVal unidad As String, ByVal precio_unitario As Double, ByVal Total As Double, ByVal Cuenta_contable As String, ByVal Fecha As Date, ByVal Obra As String)
        nue_var.consulta = "INSERT INTO Descuentos_empresa VALUES('', ?nombre_representate, ?clasificacion, ?descripcion, ?cantidad, ?unidad, ?precio_unitario, ?total, ?cuenta_contable, ?fecha, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?nombre_representate", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nombre_representante
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.Parameters.Add("?precio_unitario", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_unitario
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cantidad
            nue_var.cmd.Parameters.Add("?total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?clasificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Clasificacion
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Descuentos
    Public Sub modificar(ByVal cod_est As Integer, ByVal Nombre_representante As String, ByVal Clasificacion As String, ByVal Descripcion As String, ByVal Cantidad As Double, ByVal unidad As String, ByVal precio_unitario As Double, ByVal Total As Double, ByVal Cuenta_contable As String, ByVal Fecha As Date, ByVal Obra As String)
        nue_var.consulta = "UPDATE Descuentos_empresa SET Nombre_representante = ?nombre_representate, Descripcion = ?descripcion, unidad = ?unidad, precio_unitario = ?precio_unitario, Cantidad = ?cantidad, Total = ?total, Fecha = ?fecha,  Clasificacion = ?clasificacion, Cuenta_contable = ?cuenta_contable, Obra = ?obra  WHERE Id_descuentos = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?nombre_representate", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nombre_representante
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.Parameters.Add("?precio_unitario", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_unitario
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cantidad
            nue_var.cmd.Parameters.Add("?total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?clasificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Clasificacion
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Descuentos_empresa WHERE Id_descuentos = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar6() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes order by Nombre asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6()
    End Function

    Public Function listar3(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes where Obra like '%" & nombre_obra & "%' order by Nombre asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Plan_de_cuentas where Obra like '%" & nombre_obra & "%' order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
End Class
