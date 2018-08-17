Imports MySql.Data.MySqlClient
Public Class registro_subcontrato

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from registro_subcontrato where Obra like '%" & nombre_obra & "%' order by codigo_subcontrato asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Contratos
    Public Sub insertar(ByVal cod_subcontrato As String, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal glosa As String, ByVal forma_de_pago As String, ByVal precio As Double, ByVal tipo_de_medicion As String, ByVal cuenta_costo As String, ByVal obra As String, ByVal cantidad_contrada As Double, ByVal cantidad_modificacion As Double, ByVal tipo_registro As String)
        nue_var.consulta = "INSERT INTO registro_subcontrato VALUES('', ?cod_subcontrato, ?representante, ?tipo_subcontrato, ?glosa, ?forma_de_pago, ?precio, ?tipo_de_medicion, ?cuenta_costo, ?obra, ?cantidad_contratada, ?cantidad_modificacion, ?tipo_registro)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod_subcontrato
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?forma_de_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_de_pago
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?tipo_de_medicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_medicion
            nue_var.cmd.Parameters.Add("?cuenta_costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_costo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?cantidad_contratada", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad_contrada
            nue_var.cmd.Parameters.Add("?cantidad_modificacion", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad_modificacion
            nue_var.cmd.Parameters.Add("?tipo_registro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_registro

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal cod_subcontrato As String, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal glosa As String, ByVal forma_de_pago As String, ByVal precio As Double, ByVal tipo_de_medicion As String, ByVal cuenta_costo As String, ByVal obra As String, ByVal cantidad_contrada As Double, ByVal cantidad_modificacion As Double, ByVal tipo_registro As String)
        nue_var.consulta = "UPDATE registro_subcontrato SET codigo_subcontrato = ?cod_subcontrato, representante = ?representante, tipo_de_subcontrato = ?tipo_subcontrato, glosa = ?glosa, forma_de_pago = ?forma_de_pago, precio = ?precio, tipo_de_medicion = ?tipo_de_medicion,  cuenta_costo = ?cuenta_costo, Obra = ?obra, cantidad_contrato = ?cantidad_contratada, cantidad_modificacion = ?cantidad_modificacion, tipo_registro = ?tipo_registro WHERE Id_registro_subcontrato = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?cod_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod_subcontrato
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?forma_de_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_de_pago
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?tipo_de_medicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_medicion
            nue_var.cmd.Parameters.Add("?cuenta_costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_costo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?cantidad_contratada", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad_contrada
            nue_var.cmd.Parameters.Add("?cantidad_modificacion", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad_modificacion
            nue_var.cmd.Parameters.Add("?tipo_registro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_registro
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from registro_subcontrato WHERE Id_registro_subcontrato = " & cod_est & ""

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

    Public Function listar3(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Plan_de_cuentas where obra like '%" & nombre_obra & "%' order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
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
    'funcion para buscar el nombre de la máquina.
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
End Class
