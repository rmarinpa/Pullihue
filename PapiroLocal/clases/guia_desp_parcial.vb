Imports MySql.Data.MySqlClient
Public Class guia_desp_parcial


    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Movimiento de Tierra
    Public Function listar(ByVal rut As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT DISTINCT(numero_pedido) FROM consulta_factura where rut = '" & rut & "' and numero_pedido <> 'NULO' and numero_pedido <> '0' order by numero_pedido desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar registros de Movimiento de Tierra
    Public Sub insertar(ByVal cliente As String, ByVal rut As String, ByVal factura As String)
        nue_var.consulta = "INSERT INTO guias_facturar (cliente, rut, factura) VALUES(?cliente, ?rut, ?factura)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
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


    Function DespachoPedido(ByVal factura As String)
        'Dim query As String = "call papiro.guia_despacho_parcial('" & rut & "');"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("guia_despacho_parcial", nue_conexion.conex()) ' se indica el nombre de la accion
            With nue_var.cmd
                .CommandType = CommandType.StoredProcedure
                ' Se pasan el valor a los parametros.
                .Parameters.AddWithValue("@_factura", factura)
                .ExecuteNonQuery()
            End With
            nue_conexion.desconectar()
        Catch ex As Exception
            nue_conexion.desconectar()
            MsgBox("Problema inesperado, intente mas tarde." & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function busca_clientes_despacho_parcial(ByVal nombre As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM guias_facturar WHERE cliente LIKE '%" & nombre & "%' AND pendiente <> 0 ORDER BY factura ASC", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            busca_clientes_despacho_parcial = nue_var.dt
            Return busca_clientes_despacho_parcial
        Catch ex As Exception
            nue_conexion.desconectar()
        End Try
    End Function

    Public Function concluir_despacho_parcial(ByVal id As Integer) As Boolean
        nue_var.consulta = "UPDATE guias_facturar SET pendiente = 0 WHERE Id_guias_facturar = ?id"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = id
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            Return True
        Catch ex As Exception
            nue_conexion.desconectar()
            MsgBox("Se ha producido un error inesperado, favor intente mas tarde. " & vbLf & ex.Message, MsgBoxStyle.Critical, "Error.")
            Return False
        End Try
    End Function
End Class
