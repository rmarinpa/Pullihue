Imports MySql.Data.MySqlClient
Public Class Autorizacion

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Notas_de_pedido_val_clientes_guias order by Folio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal cliente As String, ByVal rut As String, ByVal area_negocio As String, ByVal senal_advertencia As String, ByVal comuna As String, ByVal familia_1 As String, ByVal familia_2 As String, ByVal familia_3 As String, ByVal tipo_1 As String, ByVal medidas As String, ByVal codigo_producto As String, ByVal proveedor As String, ByVal descripcion As String, ByVal area_calc As Double, ByVal cantidad As Double, ByVal area_total As Double, ByVal venta_rollo As Double, ByVal unit_venta_m2 As Double, ByVal venta_neta As Double, ByVal venta_iva As Double, ByVal venta_total As Double, ByVal condicion As String, ByVal forma_pago As String, ByVal dias_pago As String, ByVal ejecutivo As String, ByVal observaciones As String, ByVal precio_lista As Double, ByVal precio_cliente As Double, ByVal fecha As Date, ByVal pedido As Double, ByVal fecha_act As Date, ByVal hora As Date, ByVal descuento As Double, ByVal folio As Double, ByVal toma_pedido As String, ByVal ancho As Double, ByVal largo As Double, ByVal solicitado As String)
        nue_var.consulta = "INSERT INTO venta4 VALUES('', ?cliente, ?rut, ?area_negocio, ?senal_advertencia, ?comuna, ?familia_1, ?familia_2, ?familia_3, ?tipo_1, ?medidas, ?codigo_producto, ?proveedor, ?descripcion, ?area_calc, ?cantidad, ?area_total, ?venta_rollo, ?unit_venta_m2, ?venta_neta, ?venta_iva, ?venta_total, ?condicion, ?forma_pago, ?dias_pago, ?ejecutivo, ?observaciones, ?precio_lista, ?precio_cliente, ?fecha, ?pedido, ?fecha_act, ?hora, ?descuento, ?folio, ?toma_pedido, ?ancho, ?largo, ?solicitado)"
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
    Public Function listar18(ByVal numero_pedido As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_guias where numero_folio like '" & numero_pedido & "' order by Id_ventas asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar18 = nue_var.dt
        Return listar18
    End Function
    Public Sub insertar4(ByVal Folio As Double, ByVal Fecha As Date, ByVal Hora As Date, ByVal Fecha_desp As String, ByVal toma_pedido As String, ByVal solicitado As String, ByVal observaciones As String, ByVal comuna_despacho As String, ByVal direccion_despacho As String)
        nue_var.consulta = "INSERT INTO Notas_de_pedido VALUES('', ?Folio, ?Fecha, ?Hora, ?Fecha_desp, ?toma_pedido, ?solicitado, ?observaciones, ?comuna_despacho, ?direccion_despacho)"
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
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
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
        nue_var.consulta = "Delete from Notas_de_pedido_val_guias WHERE Id_notas_de_pedido = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
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
End Class
