Imports MySql.Data.MySqlClient
Public Class tipo_trabajo

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los Tipos de máquina
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tipo_trabajo order by codigo desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar Representantes
    Public Sub insertar(ByVal codigo As String, ByVal tipo_de_trabajo As String, ByVal cuenta_contable As String, ByVal obra As String)
        nue_var.consulta = "INSERT INTO tipo_trabajo VALUES('',?codigo, ?tipo_de_trabajo, ?cuenta_contable, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?tipo_de_trabajo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar Tipo de máquina
    Public Sub modificar(ByVal cod_est As Integer, ByVal codigo As String, ByVal tipo_de_trabajo As String, ByVal cuenta_contable As String, ByVal obra As String)
        nue_var.consulta = "UPDATE tipo_trabajo SET codigo = ?codigo, tipo_de_trabajo = ?tipo_de_trabajo, cuenta_contable = ?cuenta_contable, obra = ?obra  WHERE Id_tipo_trabajo = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?tipo_de_trabajo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para eliminar Tipo de Maquina 
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from tipo_trabajo WHERE Id_tipo_trabajo = " & cod_est & ""

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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Contrato where obra like '%" & nombre_obra & "%' order by codigo_maquina asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Plan_de_cuentas where Obra like '%" & nombre_obra & "%' order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
End Class