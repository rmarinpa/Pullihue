Imports MySql.Data.MySqlClient
Public Class Ruta

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

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
    'Public Function listar(ByVal fecha_in As String, ByVal fecha_anterior As String) As DataTable
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_rutas2 Where n_pedido is null and ((Fecha = '" & fecha_in & "' and Fecha_desp like 'Hoy') or (Fecha = '" & fecha_anterior & "' and Fecha_desp like 'Mañana')) order by Fecha asc, Hora asc", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_rutas2 Where n_pedido is null and Fecha >= (CURDATE() + INTERVAL -(7) DAY) order by Fecha desc, Hora desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    ' Carlos
    Public Function PedidosRetiraCliente() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_rutas2 Where n_pedido is null and ((Fecha = '" & fecha_in & "' and Fecha_desp like 'Hoy') or (Fecha = '" & fecha_anterior & "' and Fecha_desp like 'Mañana')) order by Fecha asc, Hora asc", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * FROM pedidos_retira_cliente;", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        PedidosRetiraCliente = nue_var.dt
        Return PedidosRetiraCliente
    End Function
    Public Function PedidosRetiraCliente(ByVal pedido As Integer) As DataTable ' Metodo que recibe un parametro para buscar el pedido mas preciso.
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_rutas2 Where n_pedido is null and ((Fecha = '" & fecha_in & "' and Fecha_desp like 'Hoy') or (Fecha = '" & fecha_anterior & "' and Fecha_desp like 'Mañana')) order by Fecha asc, Hora asc", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * FROM pedidos_retira_cliente where `N° Pedido` = " & pedido & ";", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        PedidosRetiraCliente = nue_var.dt
        Return PedidosRetiraCliente
    End Function
    Public Function Registrar_rutas_pendientes() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from `Registrar rutas pendientes`", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        Registrar_rutas_pendientes = nue_var.dt
        Return Registrar_rutas_pendientes
    End Function
    ' FIN

    Public Function descripcion_numero_folio() As Double
        nue_var.consulta = "SELECT folio_ruta FROM folio_ruta order by folio_ruta desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio_ruta")) Then
                descripcion_numero_folio = ""
            Else
                descripcion_numero_folio = nue_var.dr("folio_ruta")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_folio
    End Function
    Public Sub insertar2(ByVal folio_ruta As Double)
        nue_var.consulta = "INSERT INTO folio_ruta VALUES('', ?folio_ruta)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio_ruta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio_ruta
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2(ByVal folio_ruta As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM ruta Where folio_ruta = '" & folio_ruta & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2

    End Function

    Public Function listar3(ByVal n_ped As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_rutas2 Where Folio like '" & n_ped & "' order by Fecha asc, Hora asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3

    End Function

    Public Function listar3(ByVal tipo As String, ByVal n_ped As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_rutas2 Where Folio like '" & n_ped & "' order by Fecha asc, Hora asc", nue_conexion.conex())
        'Dim query As String
        'query = "SELECT " & _
        '            "np.Id_notas_de_pedido AS `Id_notas_de_pedido`, " & _
        '            "np.Folio AS `Folio`, " & _
        '            "np.Fecha AS `Fecha`, " & _
        '            "np.Hora AS `Hora`, " & _
        '            "np.Fecha_desp AS `Fecha_desp`, " & _
        '            "np.toma_pedido AS `toma_pedido`, " & _
        '            "np.solicitado AS `solicitado`, " & _
        '            "np.observaciones AS `observaciones`, " & _
        '            "np.comuna_despacho AS `comuna_despacho`, " & _
        '            "np.direccion_despacho AS `direccion_despacho`, " & _
        '            "np.Folio AS `n_pedido`, " & _
        '            "f4.cliente AS `cliente`, " & _
        '            "f4.numero_pedido AS `numero_pedido` " & _
        '        "FROM " & _
        '            "Notas_de_pedido np " & _
        '                "INNER JOIN " & _
        '            "folio4 f4 ON np.Folio = f4.folio " & _
        '        "WHERE " & _
        '            "((CAST(f4.numero_pedido  AS UNSIGNED) <> 0) " & _
        '            "OR (f4.numero_pedido  = '0')) AND " & _
        '            "np.Folio = " & n_ped & ";"
        nue_var.da = New MySqlDataAdapter("SELECT * FROM `Registrar rutas pendientes` Where pedido = '" & tipo & "' AND Folio like '" & n_ped & "' order by Fecha asc, Hora asc", nue_conexion.conex())
        'nue_var.da = New MySqlDataAdapter(query, nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3

    End Function
    Public Function listar4(ByVal fecha As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT DISTINCT(folio_ruta) FROM ruta where fecha = '" & fecha & "' order by folio_ruta asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Sub insertar2(ByVal usuario As String, ByVal folio As Double, ByVal fecha As Date, ByVal hora As Date)
        nue_var.consulta = "INSERT INTO llegada_ruta VALUES('', ?usuario, ?folio, ?fecha, ?hora)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar5(ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM llegada_ruta Where fecha = '" & fecha & "' order by hora asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5

    End Function
    Public Function listar6(ByVal fecha As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT folio_ruta FROM folio_llegada2 where fecha = '" & fecha & "' and folio is null order by folio_ruta asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal folio_ruta As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM ruta Where folio_ruta = '" & folio_ruta & "'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7

    End Function
    Public Sub eliminar(ByVal cod_ruta As Integer)
        nue_var.consulta = "Delete from ruta WHERE folio_ruta = " & cod_ruta & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar2(ByVal cod_ruta As Integer)
        nue_var.consulta = "Delete from folio_ruta WHERE folio_ruta = " & cod_ruta & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar8(ByVal pedido As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_ruta4 Where Folio = '" & pedido & "'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8

    End Function
    Public Function listar9(ByVal numero_pedido As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_ruta4 Where numero_pedido = '" & numero_pedido & "'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar9 = nue_var.dt
        Return listar9

    End Function
    Public Function listar10(ByVal Id_ruta As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_ruta4 Where folio_ruta = '" & Id_ruta & "' order by Id_ruta asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar10 = nue_var.dt
        Return listar10

    End Function
    Public Function listar11(ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_ruta4 Where fecha_nota = '" & fecha & "' order by Id_ruta desc, Folio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar11 = nue_var.dt
        Return listar11

    End Function
    Public Function listar12(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_ruta4 Where cliente = '" & cliente & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar12 = nue_var.dt
        Return listar12

    End Function
    Public Function listar13() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM retiro_agrupados order by fecha asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar13 = nue_var.dt
        Return listar13

    End Function
    Public Function listar14(ByVal folio_ruta As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM ruta Where folio_ruta = '" & folio_ruta & "' order by hora asc", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * FROM ruta_condicion Where folio_ruta = '" & folio_ruta & "' order by hora asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14

    End Function
    Public Sub eliminar3(ByVal tipo As String, ByVal pedido As String)
        nue_var.consulta = "Delete from ruta WHERE tipo = '" & tipo & "' and n_pedido = '" & pedido & "'"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar3(ByVal pendiente As String, ByVal folio_ruta As Double, ByVal tipo As String, ByVal num_doc As Double, ByVal observacion As String, ByVal condicion As String, ByVal cumple As String)
        nue_var.consulta = "INSERT INTO observaciones_llegada VALUES('', ?pendiente, ?folio_ruta, ?tipo, ?num_doc, ?observacion, ?condicion, ?cumple)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?pendiente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pendiente
            nue_var.cmd.Parameters.Add("?folio_ruta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio_ruta
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?num_doc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_doc
            nue_var.cmd.Parameters.Add("?observacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observacion
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = condicion
            nue_var.cmd.Parameters.Add("?cumple", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cumple
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar15(ByVal numero_pedido As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_retiros Where folio = '" & numero_pedido & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar15 = nue_var.dt
        Return listar15

    End Function
    Public Function listar16(ByVal fecha_in As String, ByVal fecha_anterior As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM np_rutas_guias2 Where n_pedido is null and ((Fecha = '" & fecha_in & "' and Fecha_desp like 'Hoy') or (Fecha = '" & fecha_anterior & "' and Fecha_desp like 'Mañana')) order by Fecha asc, Hora asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar16 = nue_var.dt
        Return listar16

    End Function
    Public Function listar17(ByVal n_ped As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM np_rutas_guias2 Where Folio like '" & n_ped & "' order by Fecha asc, Hora asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar17 = nue_var.dt
        Return listar17

    End Function
    Public Function listar18(ByVal folio_ruta As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_retiros Where folio_ruta = '" & folio_ruta & "' order by Id_ruta asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar18 = nue_var.dt
        Return listar18

    End Function
    Public Function listar19(ByVal fecha_ruta As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_retiros Where fecha_ruta = '" & fecha_ruta & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar19 = nue_var.dt
        Return listar19

    End Function
    Public Function listar20(ByVal factura As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_retiros Where factura = '" & factura & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar20 = nue_var.dt
        Return listar20

    End Function
    Public Function listar21(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_retiros Where cliente = '" & cliente & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar21 = nue_var.dt
        Return listar21

    End Function

    Public Function listar22(ByVal tipo_nombre As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_adm where tipo_nombre like '" & tipo_nombre & "' order by usuario asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar22 = nue_var.dt
        Return listar22
    End Function

    Public Function ConsultaDespacho(ByVal cliente As String, ByVal pedido As Integer, ByVal ruta As Integer, ByVal fecha As String, ByVal documento As Integer) As DataTable
        Dim query As String
        Dim union As String

        query = "SELECT `r`.`Id_ruta` AS `ID`, `r`.`folio_ruta` AS `Ruta`, `r`.`tipo` AS `Tipo`, `r`.`n_pedido` AS `N° Pedido`, " & _
            "IFNULL(`fg`.`numero_pedido`, `f4`.`numero_pedido`) AS `N° Documento`, " & _
            "`r`.`cliente` AS `Cliente`, `r`.`ejecutivo` AS `Ejecutivo`, `r`.`chofer` AS `Chofer`, `r`.`vehiculo` AS `Vehiculo`, `r`.`fecha` AS `Fecha`, " & _
            "`np`.`Hora` AS `Hora Pedido`, `r`.`hora` AS `Hora Salida`, `lr`.`Hora` AS `Hola Llegada` " & _
                "FROM " & _
            "`ruta` `r` " & _
            "LEFT JOIN `llegada_ruta` `lr` ON `lr`.`folio` = `r`.`folio_ruta` " & _
            "LEFT JOIN `folio4` `f4` ON `f4`.`folio` = `r`.`n_pedido` " & _
            "LEFT JOIN `Notas_de_pedido` `np` ON `f4`.`folio` = `np`.`Folio` " & _
            "LEFT JOIN `folio_guias` `fg` ON `r`.`n_pedido` = `fg`.`folio` " & _
                "WHERE " & _
            "`r`.`tipo` IN ('PEDIDO' , 'GUIA') "

        union = "UNION SELECT " & _
                    "`consulta_retiros`.`Id_ruta` AS `ID`, `consulta_retiros`.`folio_ruta` AS `Ruta`, 'COBRO' AS `Tipo`, `consulta_retiros`.`folio` AS `N° Pedido`, " & _
                    "`consulta_retiros`.`factura` AS `N° Documento`, `consulta_retiros`.`cliente` AS `Cliente`, `consulta_retiros`.`usuario` AS `Ejecutivo`, " & _
                    "`consulta_retiros`.`chofer` AS `Chofer`, `consulta_retiros`.`vehiculo` AS `Vehiculo`, `consulta_retiros`.`fecha_ruta` AS `Fecha`, " & _
                    "NULL AS `Hora Pedido`, " & _
                    "`consulta_retiros`.`hora_ruta` AS `Hora Salida`, " & _
                    "NULL AS `Hola Llegada` " & _
                "FROM " & _
                    "`consulta_retiros` "

        Dim y As String = " AND "

        Dim condionalQuery As String = Nothing
        Dim condionalUnion As String = Nothing
        If (cliente <> "" Or pedido <> 0 Or ruta <> 0 Or fecha <> "" Or documento <> 0) Then
            condionalUnion = "WHERE "
            If (cliente <> Nothing) Then
                condionalQuery = condionalQuery + "AND `r`.`cliente` = '" & cliente & "' "
                If (condionalUnion <> "WHERE ") Then
                    condionalUnion = condionalUnion + y
                End If
                condionalUnion = condionalUnion + "`consulta_retiros`.`cliente` = '" & cliente & "' "
            End If
            If (pedido <> 0) Then
                condionalQuery = condionalQuery + "AND `r`.`n_pedido` = " & pedido & " "
                If (condionalUnion <> "WHERE ") Then
                    condionalUnion = condionalUnion + y
                End If
                condionalUnion = condionalUnion + "`consulta_retiros`.`folio` = '" & pedido & "' "
            End If
            If (ruta <> 0) Then
                condionalQuery = condionalQuery + "AND `r`.`folio_ruta` = " & ruta & " "
                If (condionalUnion <> "WHERE ") Then
                    condionalUnion = condionalUnion + y
                End If
                condionalUnion = condionalUnion + "`consulta_retiros`.`folio_ruta` = '" & ruta & "' "
            End If
            If (fecha <> Nothing) Then
                condionalQuery = condionalQuery + "AND `r`.`fecha` = '" & fecha & "' "
                If (condionalUnion <> "WHERE ") Then
                    condionalUnion = condionalUnion + y
                End If
                condionalUnion = condionalUnion + "`consulta_retiros`.`fecha_ruta` = '" & fecha & "' "
            End If
            If (documento <> 0) Then
                condionalQuery = condionalQuery + "AND `r`.`n_pedido` = '" & documento & "' "
                If (condionalUnion <> "WHERE ") Then
                    condionalUnion = condionalUnion + y
                End If
                condionalUnion = condionalUnion + "`consulta_retiros`.`factura` = '" & documento & "' "
            End If
        End If
        Dim orden As String = "ORDER BY `ID`"
        query = query & condionalQuery
        union = union & condionalUnion & orden
        query = query & union
        'query = "SELECT * FROM test_despachos where `N° Pedido` = 294 AND `Tipo` = 'COBRO' ORDER BY ID DESC"
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_adm where tipo_nombre like '" & cliente & "' order by usuario asc", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter(query, nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        ConsultaDespacho = nue_var.dt
        Return ConsultaDespacho
    End Function
End Class
