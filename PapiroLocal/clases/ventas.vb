Imports MySql.Data.MySqlClient
Public Class ventas

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Movimiento de Tierra
    Public Function listar(ByVal rut As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_nota where rut = '" & rut & "' order by numero_folio desc, fecha desc, hora desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal cliente As String, ByVal rut As String, ByVal area_negocio As String, ByVal senal_advertencia As String, ByVal comuna As String, ByVal familia_1 As String, ByVal familia_2 As String, ByVal familia_3 As String, ByVal tipo_1 As String, ByVal medidas As String, ByVal codigo_producto As String, ByVal proveedor As String, ByVal descripcion As String, ByVal area_calc As Double, ByVal cantidad As Double, ByVal area_total As Double, ByVal venta_rollo As Double, ByVal unit_venta_m2 As Double, ByVal venta_neta As Double, ByVal venta_iva As Double, ByVal venta_total As Double, ByVal condicion As String, ByVal forma_pago As String, ByVal dias_pago As String, ByVal ejecutivo As String, ByVal observaciones As String, ByVal precio_lista As Double, ByVal precio_cliente As Double, ByVal fecha As Date, ByVal pedido As Double, ByVal fecha_act As Date, ByVal hora As Date, ByVal descuento As Double, ByVal folio As Double, ByVal toma_pedido As String, ByVal ancho As Double, ByVal largo As Double, ByVal solicitado As String)
        nue_var.consulta = "INSERT INTO venta4 (`cliente`, `rut`, `area_negocio`, `senal_advertencia`, `comuna`, `familia_1`, `familia_2`, `familia_3`, `tipo_1`, `medidas`, `codigo_producto`, `proveedor`, `descripcion`, `area_calc`, `cantidad`, `area_total`, `venta_rollo`, `unit_venta_m2`, `venta_neta`, `venta_iva`, `venta_total`, `condicion`, `forma_pago`, `dias_pago`, `ejecutivo`, `observaciones`, `precio_lista`, `precio_cliente`, `fecha`, `numero_pedido`, `fecha_act`, `hora`, `descuento`, `numero_folio`, `toma_pedido`, `ancho`, `largo`, `solicitado`)  VALUES(?cliente, ?rut, ?area_negocio, ?senal_advertencia, ?comuna, ?familia_1, ?familia_2, ?familia_3, ?tipo_1, ?medidas, ?codigo_producto, ?proveedor, ?descripcion, ?area_calc, ?cantidad, ?area_total, ?venta_rollo, ?unit_venta_m2, ?venta_neta, ?venta_iva, ?venta_total, ?condicion, ?forma_pago, ?dias_pago, ?ejecutivo, ?observaciones, ?precio_lista, ?precio_cliente, ?fecha, ?pedido, ?fecha_act, ?hora, ?descuento, ?folio, ?toma_pedido, ?ancho, ?largo, ?solicitado)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?area_negocio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = area_negocio
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?familia_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_1
            nue_var.cmd.Parameters.Add("?familia_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_2
            nue_var.cmd.Parameters.Add("?familia_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_3
            nue_var.cmd.Parameters.Add("?tipo_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_1
            nue_var.cmd.Parameters.Add("?medidas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medidas
            nue_var.cmd.Parameters.Add("?codigo_producto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_producto
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?area_calc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_calc
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?area_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_total
            nue_var.cmd.Parameters.Add("?venta_rollo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_rollo
            nue_var.cmd.Parameters.Add("?unit_venta_m2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unit_venta_m2
            nue_var.cmd.Parameters.Add("?venta_neta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_neta
            nue_var.cmd.Parameters.Add("?venta_iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_iva
            nue_var.cmd.Parameters.Add("?venta_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_total
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = condicion
            nue_var.cmd.Parameters.Add("?forma_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_pago
            nue_var.cmd.Parameters.Add("?dias_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dias_pago
            nue_var.cmd.Parameters.Add("?ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejecutivo
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?precio_lista", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_lista
            nue_var.cmd.Parameters.Add("?precio_cliente", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_cliente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = pedido
            nue_var.cmd.Parameters.Add("?fecha_act", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_act
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?descuento", MySql.Data.MySqlClient.MySqlDbType.Double).Value = descuento
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?ancho", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ancho
            nue_var.cmd.Parameters.Add("?largo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = largo
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub insertar2(ByVal cliente As String, ByVal rut As String, ByVal medidas As String, ByVal codigo_producto As String, ByVal descripcion As String, ByVal area_calc As Double, ByVal cantidad As Double, ByVal area_total As Double, ByVal venta_rollo As Double, ByVal unit_venta_m2 As Double, ByVal venta_neta As Double, ByVal venta_iva As Double, ByVal venta_total As Double, ByVal ejecutivo As String, ByVal fecha_act As Date, ByVal folio As Double, ByVal precio_cliente As Double)
        nue_var.consulta = "INSERT INTO venta_mod VALUES('', ?cliente, ?rut, ?medidas, ?codigo_producto, ?descripcion, ?area_calc, ?cantidad, ?area_total, ?venta_rollo, ?unit_venta_m2, ?venta_neta, ?venta_iva, ?venta_total, ?ejecutivo, ?fecha_act, ?folio, ?precio_cliente)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?medidas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medidas
            nue_var.cmd.Parameters.Add("?codigo_producto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_producto
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?area_calc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_calc
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?area_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_total
            nue_var.cmd.Parameters.Add("?venta_rollo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_rollo
            nue_var.cmd.Parameters.Add("?unit_venta_m2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unit_venta_m2
            nue_var.cmd.Parameters.Add("?venta_neta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_neta
            nue_var.cmd.Parameters.Add("?venta_iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_iva
            nue_var.cmd.Parameters.Add("?venta_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_total
            nue_var.cmd.Parameters.Add("?ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejecutivo
            nue_var.cmd.Parameters.Add("?fecha_act", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_act
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?precio_cliente", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_cliente
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub



    'procedimiento para modificar registros de Movimiento de Tierra   
    Public Sub modificar(ByVal Cod_Mov_Tierra As Integer, ByVal cliente As String, ByVal rut As String, ByVal area_negocio As String, ByVal senal_advertencia As String, ByVal comuna As String, ByVal familia_1 As String, ByVal familia_2 As String, ByVal familia_3 As String, ByVal tipo_1 As String, ByVal medidas As String, ByVal codigo_producto As String, ByVal proveedor As String, ByVal descripcion As String, ByVal area_calc As Double, ByVal cantidad As Double, ByVal area_total As Double, ByVal venta_rollo As Double, ByVal unit_venta_m2 As Double, ByVal venta_neta As Double, ByVal venta_iva As Double, ByVal venta_total As Double, ByVal condicion As String, ByVal forma_pago As String, ByVal dias_pago As Double, ByVal ejecutivo As String, ByVal observaciones As String, ByVal precio_lista As Double, ByVal precio_cliente As Double, ByVal fecha As Date, ByVal pedido As Double, ByVal fecha_act As Date, ByVal hora As Date, ByVal descuento As Double, ByVal folio As Double)
        nue_var.consulta = "UPDATE venta4 SET cliente = ?cliente, rut = ?rut, area_negocio = ?area_negocio, senal_advertencia = ?senal_advertencia, comuna = ?comuna, familia_1 = ?familia_1, familia_2 = ?familia_2, familia_3 = ?familia_3, tipo_1 = ?tipo_1, medidas = ?medidas, codigo_producto = ?codigo_producto, proveedor = ?proveedor, descripcion = ?descripcion, area_calc = ?area_calc, cantidad = ?cantidad, area_total = ?area_total, venta_rollo = ?venta_rollo, unit_venta_m2 = ?unit_venta_m2, venta_neta = ?venta_neta, venta_iva = ?venta_iva, venta_total = ?venta_total, condicion = ?condicion, forma_pago = ?forma_pago, dias_pago = ?dias_pago, ejecutivo = ?ejecutivo, observaciones = ?observaciones, precio_lista = ?precio_lista, precio_cliente = ?precio_cliente, fecha = ?fecha, numero_pedido = ?pedido, fecha_act = ?fecha_act, hora = ?hora, descuento = ?descuento, folio = ?folio WHERE Id_ventas = ?Cod_Mov_Tierra"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Mov_Tierra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Mov_Tierra
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?area_negocio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = area_negocio
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?familia_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_1
            nue_var.cmd.Parameters.Add("?familia_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_2
            nue_var.cmd.Parameters.Add("?familia_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_3
            nue_var.cmd.Parameters.Add("?tipo_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_1
            nue_var.cmd.Parameters.Add("?medidas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medidas
            nue_var.cmd.Parameters.Add("?codigo_producto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_producto
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?area_calc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_calc
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?area_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_total
            nue_var.cmd.Parameters.Add("?venta_rollo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_rollo
            nue_var.cmd.Parameters.Add("?unit_venta_m2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unit_venta_m2
            nue_var.cmd.Parameters.Add("?venta_neta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_neta
            nue_var.cmd.Parameters.Add("?venta_iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_iva
            nue_var.cmd.Parameters.Add("?venta_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_total
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = condicion
            nue_var.cmd.Parameters.Add("?forma_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_pago
            nue_var.cmd.Parameters.Add("?dias_pago", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_pago
            nue_var.cmd.Parameters.Add("?ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejecutivo
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?precio_lista", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_lista
            nue_var.cmd.Parameters.Add("?precio_cliente", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_cliente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = pedido
            nue_var.cmd.Parameters.Add("?fecha_act", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_act
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?descuento", MySql.Data.MySqlClient.MySqlDbType.Double).Value = descuento
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio

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
        nue_var.consulta = "Delete from venta4 WHERE Id_ventas = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar4(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from venta_guias WHERE Id_ventas = " & cod_Mov_Tierra & ""

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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes order by clientes asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal fecha As Date) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where fecha_caducidad >= '%" & fecha & "%' order by Codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function descripcion_descripcion(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT Descripcion FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Descripcion")) Then
                descripcion_descripcion = ""
            Else
                descripcion_descripcion = nue_var.dr("Descripcion")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_descripcion
    End Function
    Public Function descripcion_proveedor(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT proveedor FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("proveedor")) Then
                descripcion_proveedor = ""
            Else
                descripcion_proveedor = nue_var.dr("proveedor")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_proveedor
    End Function
    Public Function descripcion_total(ByVal cliente As String, ByVal numero_pedido As Double) As String
        nue_var.consulta = "SELECT Sum(venta_total) FROM venta4 where cliente = ?cliente and numero_folio = ?numero_pedido"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
        nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_pedido
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(venta_total)")) Then
                descripcion_total = ""
            Else
                descripcion_total = nue_var.dr("Sum(venta_total)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_total
    End Function
    Public Function descripcion_area_negocio(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT area_negocio FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("area_negocio")) Then
                descripcion_area_negocio = ""
            Else
                descripcion_area_negocio = nue_var.dr("area_negocio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_area_negocio
    End Function
    Public Function descripcion_familia(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT familia FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("familia")) Then
                descripcion_familia = ""
            Else
                descripcion_familia = nue_var.dr("familia")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_familia
    End Function
    Public Function descripcion_familia_2(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT familia_2 FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("familia_2")) Then
                descripcion_familia_2 = ""
            Else
                descripcion_familia_2 = nue_var.dr("familia_2")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_familia_2
    End Function
    Public Function descripcion_familia_3(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT familia_3 FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("familia_3")) Then
                descripcion_familia_3 = ""
            Else
                descripcion_familia_3 = nue_var.dr("familia_3")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_familia_3
    End Function

    Public Function listar4(ByVal Codigo As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM sustitutos_consulta where codigo1 like '%" & Codigo & "%' order by codigo2 asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Function descripcion_numero_pedido(ByVal cliente As String) As Double
        nue_var.consulta = "SELECT numero_pedido FROM numero_pedido where cliente like '%" & cliente & "%'order by numero_pedido desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("numero_pedido")) Then
                descripcion_numero_pedido = ""
            Else
                descripcion_numero_pedido = nue_var.dr("numero_pedido")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_pedido
    End Function
    Public Sub insertar2(ByVal pedido As Double, ByVal cliente As String)
        nue_var.consulta = "INSERT INTO numero_pedido VALUES('', ?pedido, ?cliente)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = pedido
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function descripcion_stock(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT stock FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("stock")) Then
                descripcion_stock = 0
            Else
                descripcion_stock = nue_var.dr("stock")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_stock
    End Function
    Public Function listar5(ByVal Codigo As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM familia_complementaria where familia like '" & Codigo & "' order by orden asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Function descripcion_precio(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT Precio_lista FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Precio_lista")) Then
                descripcion_precio = 0
            Else
                descripcion_precio = nue_var.dr("Precio_lista")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_precio
    End Function
    Public Function listar8(ByVal producto As String, ByVal categoria As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where familia like '" & producto & "' and familia_2 like '" & categoria & "' order by largo asc, ancho asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function
    Public Function listar6() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM folio4 order by folio desc limit 1", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal medida1 As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT distinct ancho FROM Codigos4 where Descripcion like '%" & medida1 & "%' order by ancho asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function listar9(ByVal medida1 As String, ByVal medida2 As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT distinct largo FROM Codigos4 where Descripcion like '%" & medida1 & "%' and ancho like '%" & medida2 & "' order by largo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar9 = nue_var.dt
        Return listar9
    End Function
    Public Function listar10(ByVal numero_pedido As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta4 where numero_folio = '" & numero_pedido & "' order by Id_ventas asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar10 = nue_var.dt
        Return listar10
    End Function
    Public Function descripcion_iva(ByVal cliente As String, ByVal numero_pedido As Double) As String
        nue_var.consulta = "SELECT Sum(venta_iva) FROM venta4 where cliente = ?cliente and numero_folio = ?numero_pedido"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
        nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_pedido
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(venta_iva)")) Then
                descripcion_iva = ""
            Else
                descripcion_iva = nue_var.dr("Sum(venta_iva)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_iva
    End Function
    Public Function descripcion_neto(ByVal cliente As String, ByVal numero_pedido As Double) As String
        nue_var.consulta = "SELECT Sum(venta_neta) FROM venta4 where cliente = ?cliente and numero_folio = ?numero_pedido"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
        nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_pedido
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(venta_neta)")) Then
                descripcion_neto = ""
            Else
                descripcion_neto = nue_var.dr("Sum(venta_neta)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_neto
    End Function
    Public Function descripcion_numero_folio() As Double
        nue_var.consulta = "SELECT folio FROM folio4 order by folio desc"
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
    Public Sub insertar3(ByVal folio As Double, ByVal numero_pedido As String, ByVal cliente As String)
        nue_var.consulta = "INSERT INTO folio4 (folio, numero_pedido, cliente) VALUES(?folio, ?numero_pedido, ?cliente)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = numero_pedido
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function descripcion_numero_folio2(ByVal folio As Double) As Double
        nue_var.consulta = "SELECT folio FROM folio4 where folio like '" & folio & "' order by folio desc"
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
    Public Function listar11() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM ofertas", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar11 = nue_var.dt
        Return listar11
    End Function

    Public Function listar12(ByVal rut As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM facturas where rut like '" & rut & "' and estado like 'PENDIENTE' order by fecha_cheques desc, vencimiento asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar12 = nue_var.dt
        Return listar12
    End Function
    Public Sub Despachado(ByVal despacho As Integer)
        nue_var.consulta = "UPDATE Notas_de_pedido SET despachado = 1 WHERE Folio = ?despacho;"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?despacho", MySql.Data.MySqlClient.MySqlDbType.Int16).Value = despacho
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub Pendiente(ByVal despacho As Double)
        nue_var.consulta = "UPDATE Notas_de_pedido SET despachado = 0 WHERE Folio = ?despacho;"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?despacho", MySql.Data.MySqlClient.MySqlDbType.Double).Value = despacho
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar4(ByVal Folio As Double, ByVal Fecha As Date, ByVal Hora As Date, ByVal Fecha_desp As String, ByVal toma_pedido As String, _
                         ByVal solicitado As String, ByVal observaciones As String, ByVal comuna_despacho As String, ByVal direccion_despacho As String, _
                         ByVal retira_cliente As Boolean)
        nue_var.consulta = "INSERT INTO Notas_de_pedido (Folio,Fecha,Hora,Fecha_desp,toma_pedido,solicitado,observaciones,comuna_despacho,direccion_despacho,retira_cliente)" & _
                        "VALUES(?Folio,?Fecha,?Hora,?Fecha_desp,?toma_pedido,?solicitado,?observaciones,?comuna_despacho,?direccion_despacho, ?retira_cliente)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Folio
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = Hora
            nue_var.cmd.Parameters.Add("?Fecha_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Fecha_desp
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?comuna_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna_despacho
            nue_var.cmd.Parameters.Add("?direccion_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_despacho
            nue_var.cmd.Parameters.Add("?retira_cliente", MySql.Data.MySqlClient.MySqlDbType.Bit).Value = retira_cliente
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar13(ByVal categoria As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT DISTINCT(familia_2) FROM Codigos4 where familia like '" & categoria & "' order by Descripcion asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar13 = nue_var.dt
        Return listar13
    End Function
    Public Function precio_min(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT precio_min FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("precio_min")) Then
                precio_min = 0
            Else
                precio_min = nue_var.dr("precio_min")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return precio_min
    End Function
    Public Function precio_max(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT precio_max FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("precio_max")) Then
                precio_max = 0
            Else
                precio_max = nue_var.dr("precio_max")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return precio_max
    End Function
    Public Function descripcion_precio(ByVal cliente As String, ByVal codigo As String) As String
        nue_var.consulta = "SELECT unit_venta_m2 FROM venta4 WHERE codigo_producto = ?Codigo and cliente = ?cliente order by fecha_act desc, hora desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
        nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("unit_venta_m2")) Then
                descripcion_precio = 0
            Else
                descripcion_precio = nue_var.dr("unit_venta_m2")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_precio
    End Function
    Public Function listar14(ByVal codigo As String, ByVal producto As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where Descripcion like '%" & producto & "%'and Codigo like '%" & codigo & "%' order by largo asc, ancho asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function
    Public Function listar15(ByVal cliente As String, ByVal producto As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_nota where cliente like '" & cliente & "' and descripcion like '%" & producto & "%' order by numero_folio desc, fecha desc, hora desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar15 = nue_var.dt
        Return listar15
    End Function
    Public Sub eliminar2(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from venta_mod WHERE Id_ventas = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar16(ByVal nombre_cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_nota_folio where cliente like '%" & nombre_cliente & "%' order by numero_folio desc limit 30", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar16 = nue_var.dt
        Return listar16
    End Function
    Public Function descripcion_cupo(ByVal cliente As String) As String
        nue_var.consulta = "SELECT linea_credito FROM Clientes where clientes = ?cliente"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("linea_credito")) Then
                descripcion_cupo = ""
            Else
                descripcion_cupo = nue_var.dr("linea_credito")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_cupo
    End Function
    Public Sub modificar(ByVal cod_est As Integer, ByVal stock As Double)
        nue_var.consulta = "UPDATE Codigos4 SET stock = ?stock WHERE id_codigos = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?stock", MySql.Data.MySqlClient.MySqlDbType.Double).Value = stock
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function Seleccionar_stock(ByVal Codigo As String) As Double
        nue_var.consulta = "SELECT stock FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("stock")) Then
                Seleccionar_stock = 0
            Else
                Seleccionar_stock = nue_var.dr("stock")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return Seleccionar_stock
    End Function
    Public Function Seleccionar_id(ByVal Codigo As String) As Integer
        nue_var.consulta = "SELECT id_codigos FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("id_codigos")) Then
                Seleccionar_id = ""
            Else
                Seleccionar_id = nue_var.dr("id_codigos")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return Seleccionar_id
    End Function
    Public Function listar11(ByVal cliente As String, ByVal numero_pedido As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM codigo_folio where cliente like '%" & cliente & "%' and numero_folio like '" & numero_pedido & "' order by codigo_producto desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar11 = nue_var.dt
        Return listar11
    End Function

    Public Function marca(ByVal Codigo As String) As String
        nue_var.consulta = "SELECT Marca FROM Codigos4 WHERE Codigo = ?Codigo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Marca")) Then
                marca = ""
            Else
                marca = nue_var.dr("Marca")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return marca
    End Function
    Public Function listar16(ByVal cliente As String, ByVal numero_pedido As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta4 where cliente like '%" & cliente & "%' and numero_folio like '" & numero_pedido & "' order by Id_ventas asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar16 = nue_var.dt
        Return listar16
    End Function
    Public Sub insertar5(ByVal Folio As Double, ByVal Fecha As Date, ByVal Hora As Date, ByVal Fecha_desp As String, _
                         ByVal toma_pedido As String, ByVal solicitado As String, ByVal observaciones As String, _
                         ByVal comuna_despacho As String, ByVal direccion_despacho As String, ByVal retiraCliente As Boolean, ByVal monto As Double)
        nue_var.consulta = "INSERT INTO Notas_de_pedido_val VALUES('', ?Folio, ?Fecha, ?Hora, ?Fecha_desp, ?toma_pedido, ?solicitado, ?observaciones, ?comuna_despacho, ?direccion_despacho, ?retiraCliente, ?monto)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Folio
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = Hora
            nue_var.cmd.Parameters.Add("?Fecha_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Fecha_desp
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?comuna_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna_despacho
            nue_var.cmd.Parameters.Add("?direccion_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_despacho
            nue_var.cmd.Parameters.Add("?retiraCliente", MySql.Data.MySqlClient.MySqlDbType.Byte).Value = retiraCliente
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar17() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM val_monto order by Id_notas_de_pedido asc", nue_conexion.conex()) ' GERMAN
        nue_var.da = New MySqlDataAdapter("SELECT * FROM autoriza_pedidos_cliente", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar17 = nue_var.dt
        Return listar17
    End Function
    Public Function listar18(ByVal numero_pedido As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta4 where numero_folio like '" & numero_pedido & "' order by Id_ventas asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar18 = nue_var.dt
        Return listar18
    End Function
    Public Sub insertar6(ByVal Folio As Double, ByVal Fecha As Date, ByVal Hora As Date, ByVal Fecha_desp As String, ByVal toma_pedido As String, ByVal solicitado As String, ByVal observaciones As String, ByVal comuna_despacho As String, ByVal direccion_despacho As String, ByVal autoriza As String, ByVal tipo As String, ByVal observaciones_aut As String)
        nue_var.consulta = "INSERT INTO Notas_de_pedido_val_aut VALUES('', ?Folio, ?Fecha, ?Hora, ?Fecha_desp, ?toma_pedido, ?solicitado, ?observaciones, ?comuna_despacho, ?direccion_despacho, ?autoriza, ?tipo, ?observaciones_aut)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Folio
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = Hora
            nue_var.cmd.Parameters.Add("?Fecha_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Fecha_desp
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?comuna_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna_despacho
            nue_var.cmd.Parameters.Add("?direccion_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_despacho
            nue_var.cmd.Parameters.Add("?autoriza", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = autoriza
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?observaciones_aut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones_aut
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar3(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from Notas_de_pedido_val WHERE Id_notas_de_pedido = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar19() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM notas_de_pedido_val_aut3 order by Id_notas_de_pedido desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar19 = nue_var.dt
        Return listar19
    End Function
    Public Function listar20() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Notas_de_pedido_val_aut2 order by Id_notas_de_pedido desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar20 = nue_var.dt
        Return listar20()
    End Function
    Public Function listar21() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar21 = nue_var.dt
        Return listar21()
    End Function
    Public Function listar22() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM folio_nc order by Id_folio_nc desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar22 = nue_var.dt
        Return listar22
    End Function
    Public Function listar23(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT DISTINCT(numero_folio) FROM venta4 where cliente like '" & cliente & "' order by Id_ventas desc limit 10", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar23 = nue_var.dt
        Return listar23
    End Function
    Public Function listar24(ByVal Codigo As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where Codigo like '" & Codigo & "' order by id_codigos desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar24 = nue_var.dt
        Return listar24
    End Function
    Public Sub insertar7(ByVal folio As Double, ByVal contacto As String, ByVal medio As String, ByVal documento As Double)
        nue_var.consulta = "INSERT INTO contacto_venta VALUES('', ?folio, ?contacto, ?medio, ?documento)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?contacto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = contacto
            nue_var.cmd.Parameters.Add("?medio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medio
            nue_var.cmd.Parameters.Add("?documento", MySql.Data.MySqlClient.MySqlDbType.Double).Value = documento
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar8(ByVal Folio As Double, ByVal Fecha As Date, ByVal Hora As Date, ByVal Fecha_desp As String, ByVal toma_pedido As String, ByVal solicitado As String, ByVal observaciones As String, ByVal comuna_despacho As String, ByVal direccion_despacho As String, ByVal tipo_doc As Double, ByVal factura_ref As String, ByVal fecha_ref As Date)
        nue_var.consulta = "INSERT INTO Notas_guias VALUES('', ?Folio, ?Fecha, ?Hora, ?Fecha_desp, ?toma_pedido, ?solicitado, ?observaciones, ?comuna_despacho, ?direccion_despacho, ?tipo_doc, ?factura_ref, ?fecha_ref)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Folio
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = Hora
            nue_var.cmd.Parameters.Add("?Fecha_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Fecha_desp
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?comuna_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna_despacho
            nue_var.cmd.Parameters.Add("?direccion_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_despacho
            nue_var.cmd.Parameters.Add("?tipo_doc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = tipo_doc
            nue_var.cmd.Parameters.Add("?factura_ref", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura_ref
            nue_var.cmd.Parameters.Add("?fecha_ref", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_ref
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar25() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM folio_guias order by folio desc limit 1", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar25 = nue_var.dt
        Return listar25
    End Function
    ' error de ingreso de datos en el campo Id_folio, al ingresar un dato vacio.
    Public Sub insertar9(ByVal folio As Double, ByVal numero_pedido As String, ByVal cliente As String, ByVal condicion As Integer)
        nue_var.consulta = "INSERT INTO folio_guias (folio, numero_pedido, cliente, condicion) VALUES(?folio, ?numero_pedido, ?cliente, ?condicion)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = numero_pedido
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = condicion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar10(ByVal cliente As String, ByVal rut As String, ByVal area_negocio As String, ByVal senal_advertencia As String, ByVal comuna As String, ByVal familia_1 As String, ByVal familia_2 As String, ByVal familia_3 As String, ByVal tipo_1 As String, ByVal medidas As String, ByVal codigo_producto As String, ByVal proveedor As String, ByVal descripcion As String, ByVal area_calc As Double, ByVal cantidad As Double, ByVal area_total As Double, ByVal venta_rollo As Double, ByVal unit_venta_m2 As Double, ByVal venta_neta As Double, ByVal venta_iva As Double, ByVal venta_total As Double, ByVal condicion As String, ByVal forma_pago As String, ByVal dias_pago As String, ByVal ejecutivo As String, ByVal observaciones As String, ByVal precio_lista As Double, ByVal precio_cliente As Double, ByVal fecha As Date, ByVal pedido As Double, ByVal fecha_act As Date, ByVal hora As Date, ByVal descuento As Double, ByVal folio As Double, ByVal toma_pedido As String, ByVal ancho As Double, ByVal largo As Double, ByVal solicitado As String)
        nue_var.consulta = "INSERT INTO venta_guias (cliente, rut, area_negocio, senal_advertencia, comuna, familia_1, familia_2, familia_3, tipo_1, medidas, codigo_producto, proveedor, descripcion, area_calc, cantidad, area_total, venta_rollo, unit_venta_m2, venta_neta, venta_iva, venta_total, condicion, forma_pago, dias_pago, ejecutivo, observaciones, precio_lista, precio_cliente, fecha, numero_pedido, fecha_act, hora, descuento, numero_folio, toma_pedido, ancho, largo, solicitado) VALUES (?cliente, ?rut, ?area_negocio, ?senal_advertencia, ?comuna, ?familia_1, ?familia_2, ?familia_3, ?tipo_1, ?medidas, ?codigo_producto, ?proveedor, ?descripcion, ?area_calc, ?cantidad, ?area_total, ?venta_rollo, ?unit_venta_m2, ?venta_neta, ?venta_iva, ?venta_total, ?condicion, ?forma_pago, ?dias_pago, ?ejecutivo, ?observaciones, ?precio_lista, ?precio_cliente, ?fecha, ?pedido, ?fecha_act, ?hora, ?descuento, ?folio, ?toma_pedido, ?ancho, ?largo, ?solicitado)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?area_negocio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = area_negocio
            nue_var.cmd.Parameters.Add("?senal_advertencia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = senal_advertencia
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?familia_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_1
            nue_var.cmd.Parameters.Add("?familia_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_2
            nue_var.cmd.Parameters.Add("?familia_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_3
            nue_var.cmd.Parameters.Add("?tipo_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_1
            nue_var.cmd.Parameters.Add("?medidas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medidas
            nue_var.cmd.Parameters.Add("?codigo_producto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_producto
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?area_calc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_calc
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?area_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area_total
            nue_var.cmd.Parameters.Add("?venta_rollo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_rollo
            nue_var.cmd.Parameters.Add("?unit_venta_m2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unit_venta_m2
            nue_var.cmd.Parameters.Add("?venta_neta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_neta
            nue_var.cmd.Parameters.Add("?venta_iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_iva
            nue_var.cmd.Parameters.Add("?venta_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = venta_total
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = condicion
            nue_var.cmd.Parameters.Add("?forma_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_pago
            nue_var.cmd.Parameters.Add("?dias_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dias_pago
            nue_var.cmd.Parameters.Add("?ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ejecutivo
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?precio_lista", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_lista
            nue_var.cmd.Parameters.Add("?precio_cliente", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_cliente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = pedido
            nue_var.cmd.Parameters.Add("?fecha_act", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_act
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?descuento", MySql.Data.MySqlClient.MySqlDbType.Double).Value = descuento
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?ancho", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ancho
            nue_var.cmd.Parameters.Add("?largo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = largo
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar26(ByVal numero_pedido As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_guias where numero_folio = '" & numero_pedido & "' order by Id_ventas asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar26 = nue_var.dt
        Return listar26
    End Function
    Public Sub insertar11(ByVal Folio As Double, ByVal Fecha As Date, ByVal Hora As Date, ByVal Fecha_desp As String, ByVal toma_pedido As String, ByVal solicitado As String, ByVal observaciones As String, ByVal comuna_despacho As String, ByVal direccion_despacho As String, ByVal tipo_doc As Double, ByVal factura_ref As String, ByVal fecha_ref As Date)
        nue_var.consulta = "INSERT INTO Notas_de_pedido_val_guias VALUES('', ?Folio, ?Fecha, ?Hora, ?Fecha_desp, ?toma_pedido, ?solicitado, ?observaciones, ?comuna_despacho, ?direccion_despacho, ?tipo_doc, ?factura_ref, ?fecha_ref)"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Folio
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = Hora
            nue_var.cmd.Parameters.Add("?Fecha_desp", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Fecha_desp
            nue_var.cmd.Parameters.Add("?toma_pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = toma_pedido
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.Parameters.Add("?comuna_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna_despacho
            nue_var.cmd.Parameters.Add("?direccion_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion_despacho
            nue_var.cmd.Parameters.Add("?tipo_doc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = tipo_doc
            nue_var.cmd.Parameters.Add("?factura_ref", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura_ref
            nue_var.cmd.Parameters.Add("?fecha_ref", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_ref

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar27(ByVal factura As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM dif_producto where numero_pedido = '" & factura & "' order by numero_pedido desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar27 = nue_var.dt
        Return listar27
    End Function

    ' Actualiza fila tabla venta4, en caso que el articulo agregado en el modulo venta exista
    ' esto dejará de crear datos basuras
    Public Sub actualizar_articulo(ByVal cantidad As Double, ByVal areaTotal As Double, ByVal unit_venta_m2 As Double, ByVal ventaNeta As Double, ByVal ventaIva As Double, ByVal ventaTotal As Double, ByVal precioCliente As Double, ByVal id As Integer)
        nue_var.consulta = "UPDATE venta4 SET cantidad = ?cantidad, area_total = ?areaTotal, unit_venta_m2 = ?unit_venta_m2, venta_neta = ?ventaNeta, venta_iva = ?ventaIva, venta_total = ?ventaTotal, precio_cliente = ?precioCliente WHERE Id_ventas = ?id"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?areaTotal", MySql.Data.MySqlClient.MySqlDbType.Double).Value = areaTotal
            nue_var.cmd.Parameters.Add("?unit_venta_m2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unit_venta_m2
            nue_var.cmd.Parameters.Add("?ventaNeta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ventaNeta
            nue_var.cmd.Parameters.Add("?ventaIva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ventaIva
            nue_var.cmd.Parameters.Add("?precioCliente", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precioCliente
            nue_var.cmd.Parameters.Add("?ventaTotal", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ventaTotal
            nue_var.cmd.Parameters.Add("?id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = id
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch ex As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha producido un error inesperado, favor intente mas tarde. " & vbLf & ex.Message, MsgBoxStyle.Critical, "Error.")
        End Try
    End Sub

    ' Actualiza fila tabla venta_guia, en caso que el articulo agregado en el modulo venta exista
    ' esto dejará de crear datos basuras
    Public Sub actualizar_articulo_guia(ByVal cantidad As Double, ByVal areaTotal As Double, ByVal unit_venta_m2 As Double, ByVal ventaNeta As Double, ByVal ventaIva As Double, ByVal ventaTotal As Double, ByVal precioCliente As Double, ByVal id As Integer)
        nue_var.consulta = "UPDATE venta_guias SET cantidad = ?cantidad, area_total = ?areaTotal, unit_venta_m2 = ?unit_venta_m2, venta_neta = ?ventaNeta, venta_iva = ?ventaIva, venta_total = ?ventaTotal, precio_cliente = ?precioCliente WHERE Id_ventas = ?id"
        Try
            nue_conexion.desconectar()
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?areaTotal", MySql.Data.MySqlClient.MySqlDbType.Double).Value = areaTotal
            nue_var.cmd.Parameters.Add("?unit_venta_m2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unit_venta_m2
            nue_var.cmd.Parameters.Add("?ventaNeta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ventaNeta
            nue_var.cmd.Parameters.Add("?ventaIva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ventaIva
            nue_var.cmd.Parameters.Add("?ventaTotal", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ventaTotal
            nue_var.cmd.Parameters.Add("?precioCliente", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precioCliente
            nue_var.cmd.Parameters.Add("?id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = id
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch ex As MySqlException
            nue_conexion.desconectar()
            MsgBox("Se ha producido un error inesperado, favor intente mas tarde. " & vbLf & ex.Message, MsgBoxStyle.Critical, "Error.")
        End Try
    End Sub

    Public Function verifica_pedido_unico(ByVal pedido As String) As Boolean
        nue_var.consulta = "SELECT count(*) AS cantidad_pedido FROM folio4 WHERE folio = ?pedido GROUP BY folio HAVING cantidad_pedido > 1"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pedido
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("cantidad_pedido")) Then
                verifica_pedido_unico = False
            Else
                verifica_pedido_unico = True
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verifica_pedido_unico
    End Function

    'SELECT precio_cliente, cantidad, venta_neta, SUM(precio_cliente*cantidad - venta_neta) as monto  FROM venta4 WHERE numero_folio = 45727 HAVING monto > 5 OR monto < -5

    Public Function verifica_valor_pedido(ByVal pedido As String) As Integer
        nue_var.consulta = "SELECT SUM(precio_cliente*cantidad - venta_neta) as monto  FROM venta4 WHERE numero_folio = ?pedido HAVING monto > 5 OR monto < -5"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pedido
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("monto")) Then
                verifica_valor_pedido = 0
            Else
                verifica_valor_pedido = nue_var.dr("monto")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verifica_valor_pedido
    End Function

    Public Sub insertar_alerta_precio(ByVal usuario As String, ByVal rut_cliente As String, ByVal nom_cliente As String, ByVal fecha As Date, ByVal num_pedido As Double, ByVal codigo_producto As String, ByVal nom_producto As String, ByVal cantidad As Double, ByVal precio As Double, ByVal precio_min As Double, ByVal precio_max As Double, ByVal tipo As Double)
        nue_var.consulta = "INSERT INTO alerta_precios (`usuario`, `rut_cliente`, `nom_cliente`, `fecha`, `num_pedido`, `codigo_producto`, `nom_producto`, `cantidad`, `precio`, `precio_min`, `precio_max`, `tipo`)  VALUES(?usuario, ?rut_cliente, ?nom_cliente, ?fecha, ?num_pedido, ?codigo_producto, ?nom_producto, ?cantidad, ?precio, ?precio_min, ?precio_max, ?tipo)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?rut_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut_cliente
            nue_var.cmd.Parameters.Add("?nom_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_cliente
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?num_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_pedido
            nue_var.cmd.Parameters.Add("?codigo_producto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo_producto
            nue_var.cmd.Parameters.Add("?nom_producto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_producto
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?precio_min", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_min
            nue_var.cmd.Parameters.Add("?precio_max", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_max
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = tipo
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
