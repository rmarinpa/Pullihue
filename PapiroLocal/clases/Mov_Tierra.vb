Imports MySql.Data.MySqlClient
Public Class Mov_Tierra

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Movimiento de Tierra
    Public Function listar(ByVal nombre_obra As String, ByVal fecha_inicio As String, ByVal fecha_final As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Mov_Tierra where obra like '%" & nombre_obra & "%' and Fecha >= '" & fecha_inicio & "' and Fecha <= '" & fecha_final & "' and Form_3 = 1 order by Fecha desc, Codigo desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Contrato where obra like '%" & nombre_obra & "%' order by codigo_maquina asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal Codigo As String, ByVal Patente As String, ByVal fecha As Date, ByVal N_de_report As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal dias_trabajados As Double, ByVal total_horas As Double, ByVal Panne As Double, ByVal Total_horas_con_desc As Double, ByVal dia_noche As String, ByVal operador As String, ByVal observaciones As String, ByVal tipo_de_trabajo As String, ByVal id_tipo_de_trabajo As Double, ByVal m3 As Double, ByVal mes As Double, ByVal viatico As Double, ByVal horas_extras As Double, ByVal otro_gasto As Double, ByVal observacion_2 As String, ByVal form_2 As Double, ByVal txt_revision As String, ByVal a_consultar As String, ByVal form_3 As Double, ByVal trabajo_rendimiento As Double, ByVal tipo_rendimiento As String, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Mov_Tierra VALUES('', ?Codigo, ?patente, ?fecha, ?N_de_report, ?Hor_inicial, ?Hor_final, ?dias_trabajados, ?total_horas, ?Panne, ?Total_horas_con_desc, ?dia_noche, ?Operador, ?observaciones, ?Tipo_de_trabajo, ?id_tipo_de_trabajo, ?m3, ?mes, ?viatico, ?horas_extras, ?otro_gasto, ?observacion_2, ?form_2, ?txt_revision, ?a_consultar, ?form_3, ?trabajo_rendimiento, ?tipo_rendimiento, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Patente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_report
            nue_var.cmd.Parameters.Add("?Hor_inicial", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_inicial
            nue_var.cmd.Parameters.Add("?Hor_final", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_final
            nue_var.cmd.Parameters.Add("?dias_trabajados", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_trabajados
            nue_var.cmd.Parameters.Add("?total_horas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_horas
            nue_var.cmd.Parameters.Add("?Panne", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Panne
            nue_var.cmd.Parameters.Add("?total_horas_con_desc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_horas_con_desc
            nue_var.cmd.Parameters.Add("?dia_noche", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dia_noche
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?Tipo_de_trabajo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?id_tipo_de_trabajo", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = id_tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?m3", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = m3
            nue_var.cmd.Parameters.Add("?mes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = mes
            nue_var.cmd.Parameters.Add("?viatico", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = viatico
            nue_var.cmd.Parameters.Add("?horas_extras", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = horas_extras
            nue_var.cmd.Parameters.Add("?otro_gasto", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = otro_gasto
            nue_var.cmd.Parameters.Add("?observacion_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observacion_2
            nue_var.cmd.Parameters.Add("?form_2", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = form_2
            nue_var.cmd.Parameters.Add("?txt_revision", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txt_revision
            nue_var.cmd.Parameters.Add("?a_consultar", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = a_consultar
            nue_var.cmd.Parameters.Add("?form_3", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = form_3
            nue_var.cmd.Parameters.Add("?trabajo_rendimiento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = trabajo_rendimiento
            nue_var.cmd.Parameters.Add("?tipo_rendimiento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Movimiento de Tierra   
    Public Sub modificar(ByVal Cod_Mov_Tierra As Integer, ByVal Codigo As String, ByVal Patente As String, ByVal fecha As Date, ByVal N_de_report As String, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal dias_trabajados As Double, ByVal total_horas As Double, ByVal Panne As Double, ByVal Total_horas_con_desc As Double, ByVal dia_noche As String, ByVal operador As String, ByVal observaciones As String, ByVal tipo_de_trabajo As String, ByVal id_tipo_de_trabajo As Double, ByVal m3 As Double, ByVal mes As Double, ByVal viatico As Double, ByVal horas_extras As Double, ByVal otro_gasto As Double, ByVal observacion_2 As String, ByVal form_2 As Double, ByVal txt_revision As String, ByVal a_consultar As String, ByVal form_3 As Double, ByVal trabajo_rendimiento As Double, ByVal tipo_rendimiento As String, ByVal obra As String)
        nue_var.consulta = "UPDATE Mov_Tierra SET Codigo = ?Codigo, Patente = ?patente, Fecha = ?Fecha, N_de_report = ?N_de_report, Hor_inicial = ?Hor_inicial, Hor_final = ?Hor_final, dias_trabajados = ?dias_trabajados, total_horas = ?total_horas, Panne_Descuentos = ?Panne, Total_horas_con_desc = ?Total_horas_con_desc, dia_noche = ?dia_noche, operador = ?Operador, observaciones = ?observaciones, tipo_de_trabajo = ?Tipo_de_trabajo, id_tipo_de_trabajo = ?id_tipo_de_trabajo, m3 = ?m3, mes = ?mes, viatico = ?viatico, horas_extras = ?horas_extras, otro_gasto = ?otro_gasto, observacion_2 = ?observacion_2, form_2 = ?form_2, txt_revision = ?txt_revision, a_consultar = ?a_consultar, form_3 = ?form_3, trabajo_rendimiento = ?trabajo_rendimiento, tipo_rendimiento = ?tipo_rendimiento, obra = ?obra WHERE Id_Mov_Tierra = ?Cod_Mov_Tierra"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Mov_Tierra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Mov_Tierra
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Patente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = N_de_report
            nue_var.cmd.Parameters.Add("?Hor_inicial", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_inicial
            nue_var.cmd.Parameters.Add("?Hor_final", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_final
            nue_var.cmd.Parameters.Add("?dias_trabajados", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_trabajados
            nue_var.cmd.Parameters.Add("?total_horas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_horas
            nue_var.cmd.Parameters.Add("?Panne", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Panne
            nue_var.cmd.Parameters.Add("?total_horas_con_desc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_horas_con_desc
            nue_var.cmd.Parameters.Add("?dia_noche", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dia_noche
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?Tipo_de_trabajo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?id_tipo_de_trabajo", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = id_tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?m3", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = m3
            nue_var.cmd.Parameters.Add("?mes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = mes
            nue_var.cmd.Parameters.Add("?viatico", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = viatico
            nue_var.cmd.Parameters.Add("?horas_extras", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = horas_extras
            nue_var.cmd.Parameters.Add("?otro_gasto", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = otro_gasto
            nue_var.cmd.Parameters.Add("?observacion_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observacion_2
            nue_var.cmd.Parameters.Add("?form_2", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = form_2
            nue_var.cmd.Parameters.Add("?txt_revision", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txt_revision
            nue_var.cmd.Parameters.Add("?a_consultar", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = a_consultar
            nue_var.cmd.Parameters.Add("?form_3", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = form_3
            nue_var.cmd.Parameters.Add("?trabajo_rendimiento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = trabajo_rendimiento
            nue_var.cmd.Parameters.Add("?tipo_rendimiento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_trabajo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
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
    Public Sub eliminar(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from Mov_Tierra WHERE Id_Mov_Tierra = " & cod_Mov_Tierra & ""

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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Mov_Tierra where obra like '%" & nombre_obra & "%' and Form_2 = 1 order by Fecha desc, Codigo desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal codigo As String, ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tipo_trabajo where obra like '%" & nombre_obra & "%' and codigo like '%" & codigo & "%' order by tipo_de_trabajo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
End Class
