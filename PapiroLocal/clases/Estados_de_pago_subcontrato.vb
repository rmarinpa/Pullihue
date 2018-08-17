Imports MySql.Data.MySqlClient
Public Class Estados_de_pago_subcontrato

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes_subcontratos where Obra like '%" & nombre_obra & "%' order by Nombre asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal nombre_obra As String, ByVal representante As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes_subcontratos where Obra like '%" & nombre_obra & "%' and Nombre like '%" & representante & "%' order by tipo_subcontrato asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal nombre_obra As String, ByVal representante As String, ByVal subcontrato As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_avance where Obra like '%" & nombre_obra & "%' and representante like '%" & representante & "%' and tipo_subcontrato like '%" & subcontrato & "%' order by fecha asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Function listar5(ByVal nombre_obra As String, ByVal representante As String, ByVal subcontrato As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_avance where Obra like '%" & nombre_obra & "%' and representante like '%" & representante & "%' and tipo_subcontrato like '%" & subcontrato & "%' order by fecha asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Function fecha_anterior(ByVal nombre_obra As String, ByVal representante As String, ByVal subcontrato As String, ByVal fecha_actual As String) As String
        nue_var.consulta = "SELECT fecha FROM fecha_avance WHERE Obra = ?nombre_obra and representante = ?representante and tipo_subcontrato = ?subcontrato and fecha < ?fecha_actual order by fecha desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
        nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
        nue_var.cmd.Parameters.Add("?subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontrato
        nue_var.cmd.Parameters.Add("?fecha_actual", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = fecha_actual
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            fecha_anterior = nue_var.dr("fecha")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return fecha_anterior
    End Function
    Public Function Cuenta_fecha(ByVal nombre_obra As String, ByVal representante As String, ByVal subcontrato As String, ByVal fecha_actual As Date) As String
        nue_var.consulta = "SELECT Count(*) as Cuenta FROM Cuenta_fecha_avance Where Obra = ?nombre_obra and representante = ?representante and tipo_subcontrato = ?subcontrato and fecha <= ?fecha_actual"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
        nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
        nue_var.cmd.Parameters.Add("?subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontrato
        nue_var.cmd.Parameters.Add("?fecha_actual", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_actual
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            Cuenta_fecha = nue_var.dr("Cuenta")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return Cuenta_fecha
    End Function
End Class
