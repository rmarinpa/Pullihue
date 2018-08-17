Imports MySql.Data.MySqlClient
Public Class ficha_maquinaria

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from maquinaria order by sigla asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Contratos
    Public Sub insertar(ByVal tipo_maq As String, ByVal sigla As String, ByVal maquinaria As String, ByVal ano As String, ByVal patente As String, ByVal hor_fin_2015 As String, ByVal motor As String, ByVal chassis As String, ByVal cuenta_repuesto As String, ByVal cuenta_operador As String, ByVal cuenta_mat_des As String, ByVal cuenta_lubricante As String, ByVal cuenta_petroleo As String, ByVal cuenta_g_o_p As String, ByVal cuenta_ingreso As String, ByVal obra As String, ByVal codigo_relacionado As String, ByVal maq_relacionada As String, ByVal fecha_actualizacion As Date, ByVal fecha_adquision As Date)
        nue_var.consulta = "INSERT INTO maquinaria VALUES('', ?tipo_maq, ?sigla, ?maquinaria, ?ano, ?patente, ?hor_fin_2015, ?motor, ?chassis, ?cuenta_repuesto, ?cuenta_operador, ?cuenta_mat_des, ?cuenta_lubricante, ?cuenta_petroleo, ?cuenta_g_o_p, ?cuenta_ingreso, ?obra, ?codigo_relacionado, ?maq_relacionada, ?fecha_actualizacion, ?fecha_adquision)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?tipo_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_maq
            nue_var.cmd.Parameters.Add("?sigla", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = sigla
            nue_var.cmd.Parameters.Add("?maquinaria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquinaria
            nue_var.cmd.Parameters.Add("?ano", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ano
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = patente
            nue_var.cmd.Parameters.Add("?hor_fin_2015", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = hor_fin_2015
            nue_var.cmd.Parameters.Add("?motor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = motor
            nue_var.cmd.Parameters.Add("?chassis", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chassis
            nue_var.cmd.Parameters.Add("?cuenta_repuesto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_repuesto
            nue_var.cmd.Parameters.Add("?cuenta_operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_operador
            nue_var.cmd.Parameters.Add("?cuenta_mat_des", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_mat_des
            nue_var.cmd.Parameters.Add("?cuenta_lubricante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_lubricante
            nue_var.cmd.Parameters.Add("?cuenta_petroleo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_petroleo
            nue_var.cmd.Parameters.Add("?cuenta_g_o_p", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_g_o_p
            nue_var.cmd.Parameters.Add("?cuenta_ingreso", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_ingreso
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?codigo_relacionado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_relacionado
            nue_var.cmd.Parameters.Add("?maq_relacionada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maq_relacionada
            nue_var.cmd.Parameters.Add("?fecha_actualizacion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_actualizacion
            nue_var.cmd.Parameters.Add("?fecha_adquision", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_adquision
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal tipo_maq As String, ByVal sigla As String, ByVal maquinaria As String, ByVal ano As String, ByVal patente As String, ByVal hor_fin_2015 As String, ByVal motor As String, ByVal chassis As String, ByVal cuenta_repuesto As String, ByVal cuenta_operador As String, ByVal cuenta_mat_des As String, ByVal cuenta_lubricante As String, ByVal cuenta_petroleo As String, ByVal cuenta_g_o_p As String, ByVal cuenta_ingreso As String, ByVal obra As String, ByVal codigo_relacionado As String, ByVal maq_relacionada As String, ByVal fecha_actualizacion As Date, ByVal fecha_adquision As Date)
        nue_var.consulta = "UPDATE maquinaria SET Tipo_maq = ?tipo_maq,	sigla = ?sigla,	maquinaria = ?maquinaria, ano = ?ano, patente = ?patente, hor_fin_2015 = ?hor_fin_2015, motor = ?motor, chassis = ?chassis, cuenta_repuesto = ?cuenta_repuesto, cuenta_operador = ?cuenta_operador,	cuenta_mat_des = ?cuenta_mat_des, cuenta_lubricante = ?cuenta_lubricante, cuenta_petroleo = ?cuenta_petroleo, cuenta_g_o_p = ?cuenta_g_o_p, cuenta_ingreso = ?cuenta_ingreso, Obra = ?obra, Codigo_relacionado = ?codigo_relacionado, maq_relacionada = ?maq_relacionada, fecha_actualizacion = ?fecha_actualizacion, fecha_adquision = ?fecha_adquision WHERE Id_maquinaria = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?tipo_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_maq
            nue_var.cmd.Parameters.Add("?sigla", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = sigla
            nue_var.cmd.Parameters.Add("?maquinaria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maquinaria
            nue_var.cmd.Parameters.Add("?ano", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ano
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = patente
            nue_var.cmd.Parameters.Add("?hor_fin_2015", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = hor_fin_2015
            nue_var.cmd.Parameters.Add("?motor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = motor
            nue_var.cmd.Parameters.Add("?chassis", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chassis
            nue_var.cmd.Parameters.Add("?cuenta_repuesto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_repuesto
            nue_var.cmd.Parameters.Add("?cuenta_operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_operador
            nue_var.cmd.Parameters.Add("?cuenta_mat_des", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_mat_des
            nue_var.cmd.Parameters.Add("?cuenta_lubricante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_lubricante
            nue_var.cmd.Parameters.Add("?cuenta_petroleo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_petroleo
            nue_var.cmd.Parameters.Add("?cuenta_g_o_p", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_g_o_p
            nue_var.cmd.Parameters.Add("?cuenta_ingreso", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_ingreso
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?codigo_relacionado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_relacionado
            nue_var.cmd.Parameters.Add("?maq_relacionada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = maq_relacionada
            nue_var.cmd.Parameters.Add("?fecha_actualizacion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_actualizacion
            nue_var.cmd.Parameters.Add("?fecha_adquision", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_adquision
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from maquinaria WHERE Id_maquinaria = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Obras order by Nombre asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Contrato where Obra like '%" & nombre_obra & "%' and Representante = 'Constructora FV' order by Codigo_maquina asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
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
End Class
