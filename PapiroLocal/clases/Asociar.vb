Imports MySql.Data.MySqlClient
Public Class Asociar

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

       Public Function listar8(ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha2_1 Where Fecha = '" & fecha & "' and numero_pedido = '0' order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function
    Public Function listar7(ByVal numero_folio As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta4 where numero_folio like '" & numero_folio & "' order by descripcion desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Sub modificar(ByVal cod_est As Integer, ByVal factura As String)
        nue_var.consulta = "UPDATE folio4 SET numero_pedido = ?factura WHERE Id_folio = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar(ByVal fecha As Date, ByVal numero_pedido As String, ByVal numero_documento As String, ByVal tipo As String, ByVal cliente As String, ByVal corresponde_cliente As String, ByVal monto As String, ByVal corresponde_monto As String, ByVal ejecutivo As String)
        nue_var.consulta = "INSERT INTO tabla_asociar VALUES('', ?fecha, ?numero_pedido, ?numero_documento, ?tipo, ?cliente, ?corresponde_cliente, ?monto, ?corresponde_monto, ?ejecutivo)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = numero_pedido
            nue_var.cmd.Parameters.Add("?numero_documento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = numero_documento
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?corresponde_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = corresponde_cliente
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = monto
            nue_var.cmd.Parameters.Add("?corresponde_monto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = corresponde_monto
            nue_var.cmd.Parameters.Add("?ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejecutivo
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function descripcion_id(ByVal folio As String) As String
        nue_var.consulta = "SELECT Id_folio FROM folio4 where folio = ?folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Id_folio")) Then
                descripcion_id = ""
            Else
                descripcion_id = nue_var.dr("Id_folio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_id
    End Function
    Public Function descripcion_cliente(ByVal folio As String) As String
        nue_var.consulta = "SELECT cliente FROM folio4 where folio = ?folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("cliente")) Then
                descripcion_cliente = ""
            Else
                descripcion_cliente = nue_var.dr("cliente")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_cliente
    End Function
    Public Function descripcion_monto(ByVal numero_folio As String) As Double
        nue_var.consulta = "SELECT SUM(venta_neta) FROM venta4 where numero_folio = ?numero_folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?numero_folio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = numero_folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("SUM(venta_neta)")) Then
                descripcion_monto = 0
            Else
                descripcion_monto = nue_var.dr("SUM(venta_neta)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_monto
    End Function
End Class
