Imports MySql.Data.MySqlClient
Public Class Cuentas_Contables

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Cuentas_Contables
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from Cuentas_contables where obra like '%" & nombre_obra & "%' order by Codigo asc", nue_conexion.conex())
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

    'procedimiento para insertar Cuentas Contables
    Public Sub insertar(ByVal cod_maq As String, ByVal Cuenta_contable As String, ByVal Cuenta_contable_maquinaria As String, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Cuentas_contables VALUES('', ?cod_maq, ?cuenta_contable, ?cuen_con_maq, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?cod_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod_maq
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable
            nue_var.cmd.Parameters.Add("?cuen_con_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable_maquinaria
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Cuentas Contables
    Public Sub modificar(ByVal cod_est As Integer, ByVal cod_maq As String, ByVal Cuenta_contable As String, ByVal Cuenta_contable_maquinaria As String, ByVal obra As String)
        nue_var.consulta = "UPDATE Cuentas_contables SET Codigo = ?cod_maq, Cuenta_contable = ?cuenta_contable, Cuenta_contable_Maquinaria = ?cuen_con_maq, obra = ?obra  WHERE Id_cuentas_Contables = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?cod_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod_maq
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable
            nue_var.cmd.Parameters.Add("?cuen_con_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable_maquinaria
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Cuentas_contables WHERE Id_cuentas_Contables = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar3(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Plan_de_cuentas where Obra like '%" & nombre_obra & "%' order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Plan_de_cuentas where Obra like '%" & nombre_obra & "%' order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
End Class
