Imports MySql.Data.MySqlClient
Public Class Retiros

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar8(ByVal fecha1 As String, ByVal fecha2 As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM retiro_agrupados_consulta where fecha >= '" & fecha2 & "' and fecha <= '" & fecha1 & "' order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function

    Public Function listar7(ByVal folio As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM retiro_documentos where folio = " & folio & " order by factura asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function listar6() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM retiro_agrupados_consulta where isnull(folio_ruta) order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function

    Public Sub insertar(ByVal usuario As String, ByVal chofer As String, ByVal vehiculo As String, ByVal fecha As Date, ByVal hora As Date, ByVal n_pedido As Double, ByVal ejecutivo As String, ByVal direccion As String, ByVal comuna As String, ByVal folio_ruta As Double, ByVal tipo As String, ByVal cliente As String, ByVal peoneta As String, ByVal revisa_camioneta As String, ByVal revisa_camioneta2 As String)
        nue_var.consulta = "INSERT INTO ruta VALUES('', ?usuario, ?chofer, ?vehiculo, ?fecha, ?hora, ?n_pedido, ?ejecutivo, ?direccion, ?comuna, ?folio_ruta, ?tipo, ?cliente, ?peoneta, ?revisa_camioneta, ?revisa_camioneta2)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?chofer", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chofer
            nue_var.cmd.Parameters.Add("?vehiculo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = vehiculo
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?n_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = n_pedido
            nue_var.cmd.Parameters.Add("?ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejecutivo
            nue_var.cmd.Parameters.Add("?direccion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?folio_ruta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio_ruta
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?peoneta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = peoneta
            nue_var.cmd.Parameters.Add("?revisa_camioneta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = revisa_camioneta
            nue_var.cmd.Parameters.Add("?revisa_camioneta2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = revisa_camioneta2
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

End Class
