Imports MySql.Data.MySqlClient
Public Class Nota_credito

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Notas de Crédito
    Public Function listar(ByVal factura As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM factura_venta where numero_pedido like '" & factura & "' order by descripcion desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal n_factura As String, ByVal nota_credito As String, ByVal razon_social As String, ByVal rut As String, ByVal accion As String, ByVal error1 As String, ByVal observaciones As String, ByVal motivo As String, ByVal venta_neta As Double, ByVal iva As Double, ByVal total As Double, ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date)
        nue_var.consulta = "INSERT INTO nota_credito VALUES('', ?n_factura, ?nota_credito, ?razon_social, ?rut, ?accion, ?error1, ?observaciones, ?motivo, ?venta_neta, ?iva, ?total, ?usuario, ?fecha, ?hora)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?n_factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = n_factura
            nue_var.cmd.Parameters.Add("?nota_credito", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nota_credito
            nue_var.cmd.Parameters.Add("?razon_social", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon_social
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?accion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = accion
            nue_var.cmd.Parameters.Add("?error1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = error1
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?motivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = motivo
            nue_var.cmd.Parameters.Add("?venta_neta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_neta
            nue_var.cmd.Parameters.Add("?iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = iva
            nue_var.cmd.Parameters.Add("?total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.Date).Value = hora
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar2(ByVal n_factura As String, ByVal nota_credito As String, ByVal codigo As String, ByVal precio_rollo As Double, ByVal cantidad_detalle As Double, ByVal total_detalle As Double)
        nue_var.consulta = "INSERT INTO nota_credito_detalle VALUES('', ?n_factura, ?nota_credito, ?codigo, ?precio_rollo, ?cantidad_detalle, ?total_detalle)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?n_factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = n_factura
            nue_var.cmd.Parameters.Add("?nota_credito", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nota_credito
            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?precio_rollo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_rollo
            nue_var.cmd.Parameters.Add("?cantidad_detalle", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad_detalle
            nue_var.cmd.Parameters.Add("?total_detalle", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_detalle
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Function descripcion_rut(ByVal factura As String) As String
        nue_var.consulta = "SELECT rut FROM factura_venta where numero_pedido = ?factura"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.Double).Value = factura
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("rut")) Then
                descripcion_rut = ""
            Else
                descripcion_rut = nue_var.dr("rut")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_rut
    End Function
    Public Function descripcion_razon(ByVal factura As String) As String
        nue_var.consulta = "SELECT cliente FROM factura_venta where numero_pedido = ?factura"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.Double).Value = factura
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("cliente")) Then
                descripcion_razon = ""
            Else
                descripcion_razon = nue_var.dr("cliente")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_razon
    End Function
    Public Function descripcion_nc(ByVal nota_credito As String) As String
        nue_var.consulta = "SELECT nota_credito FROM nota_credito where nota_credito = ?nota_credito"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nota_credito", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nota_credito
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("nota_credito")) Then
                descripcion_nc = ""
            Else
                descripcion_nc = nue_var.dr("nota_credito")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_nc
    End Function
    Public Function listar2(ByVal motivo_con As String, ByVal motivo2_con As String, ByVal motivo3_con As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM folio_nc where motivo = '" & motivo_con & "' or motivo = '" & motivo2_con & "' or motivo = '" & motivo3_con & "' order by Id_folio_nc desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function descripcion_numero_folio() As Double
        nue_var.consulta = "SELECT folio FROM folio_nc order by Id_folio_nc desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio")) Then
                descripcion_numero_folio = ""
            Else
                descripcion_numero_folio = nue_var.dr("folio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_folio
    End Function
    Public Sub insertar3(ByVal folio As String, ByVal nota_credito As String, ByVal factura As String, ByVal cliente As String, ByVal motivo As String, ByVal status As String, ByVal condicion As Integer)
        nue_var.consulta = "INSERT INTO folio_nc VALUES('', ?folio, ?nota_credito, ?factura, ?cliente,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL, ?motivo, ?status,NULL,NULL,NULL, ?condicion)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = folio
            nue_var.cmd.Parameters.Add("?nota_credito", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nota_credito
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?motivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = motivo
            nue_var.cmd.Parameters.Add("?status", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = status
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = condicion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function descripcion_numero_folio2(ByVal folio As Double) As Double
        nue_var.consulta = "SELECT folio FROM folio_nc where folio like '" & folio & "' order by folio desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio")) Then
                descripcion_numero_folio2 = ""
            Else
                descripcion_numero_folio2 = nue_var.dr("folio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_folio2
    End Function
    Public Sub modificar(ByVal folio As String, ByVal con_venta As String, ByVal con_prod As String, ByVal obs_venta As String, ByVal con_material As String, ByVal con_desp As String, ByVal obs_logistica As String, ByVal con_inv As String, ByVal obs_serv As String, ByVal autoriza_venta As String, ByVal autoriza_logistica As String, ByVal autoriza_serv As String, ByVal status As String, ByVal fecha_reclamo As Date, ByVal contacto As String, ByVal respuesta As String)
        nue_var.consulta = "UPDATE folio_nc SET con_venta = ?con_venta, con_prod  = ?con_prod , obs_venta = ?obs_venta, con_material  = ?con_material , con_desp  = ?con_desp, obs_logistica   = ?obs_logistica , con_inv   = ?con_inv , obs_serv   = ?obs_serv , autoriza_venta   = ?autoriza_venta , autoriza_logistica   = ?autoriza_logistica, autoriza_serv    = ?autoriza_serv , status    = ?status , fecha_reclamo    = ?fecha_reclamo, contacto     = ?contacto, respuesta     = ?respuesta      WHERE folio = ?folio"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = folio
            nue_var.cmd.Parameters.Add("?con_venta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = con_venta
            nue_var.cmd.Parameters.Add("?con_prod", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = con_prod
            nue_var.cmd.Parameters.Add("?obs_venta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obs_venta
            nue_var.cmd.Parameters.Add("?con_material", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = con_material
            nue_var.cmd.Parameters.Add("?con_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = con_desp
            nue_var.cmd.Parameters.Add("?obs_logistica", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obs_logistica
            nue_var.cmd.Parameters.Add("?con_inv", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = con_inv
            nue_var.cmd.Parameters.Add("?obs_serv", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obs_serv
            nue_var.cmd.Parameters.Add("?autoriza_venta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = autoriza_venta
            nue_var.cmd.Parameters.Add("?autoriza_logistica", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = autoriza_logistica
            nue_var.cmd.Parameters.Add("?autoriza_serv", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = autoriza_serv
            nue_var.cmd.Parameters.Add("?status", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = status
            nue_var.cmd.Parameters.Add("?fecha_reclamo", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_reclamo
            nue_var.cmd.Parameters.Add("?contacto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = contacto
            nue_var.cmd.Parameters.Add("?respuesta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = respuesta
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Function buscaNotasCredito(ByVal factura As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM nota_credito_con2 where factura = '" & factura & "' order by nota_credito desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        buscaNotasCredito = nue_var.dt
        Return buscaNotasCredito
    End Function

End Class
