Imports MySql.Data.MySqlClient
Public Class Descuentos_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_conexion2 As New conexion
    Dim nue_var As New variables
    Dim nue_var1 As New variables

    'funcion para listar las Contratos
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from descuentos_subcontratos where obra like '%" & nombre_obra & "%' order by fecha desc, representante desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Descuentos
    Public Sub insertar(ByVal codigo_subcontrato As Double, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal item As String, ByVal descripcion As String, ByVal fecha As Date, ByVal monto As Double, ByVal obra As String, ByVal cuenta_contable As String)
        nue_var.consulta = "INSERT INTO descuentos_subcontratos VALUES('', ?codigo_subcontrato, ?representante, ?tipo_subcontrato, ?item, ?descripcion, ?fecha, ?monto, ?obra, ?cuenta_contable)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_subcontrato
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Descuentos
    Public Sub modificar(ByVal cod_est As Integer, ByVal codigo_subcontrato As Double, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal item As String, ByVal descripcion As String, ByVal fecha As Date, ByVal monto As Double, ByVal obra As String, ByVal cuenta_contable As String)
        nue_var.consulta = "UPDATE descuentos_subcontratos SET codigo_subcontrato = ?codigo_subcontrato, representante = ?representante, tipo_subcontrato = ?tipo_subcontrato, item = ?item, descripcion = ?descripcion, fecha = ?fecha, monto = ?monto,  obra = ?obra, cuenta_contable = ?cuenta_contable  WHERE id_descuentos_subcontratos = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_subcontrato
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from descuentos_subcontratos WHERE id_descuentos_subcontratos = " & cod_est & ""

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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes_subcontratos where obra like '%" & nombre_obra & "%' order by Id_representante asc", nue_conexion.conex())
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
End Class
