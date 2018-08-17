Imports MySql.Data.MySqlClient
Public Class Registro_pagos

    Dim nue_conexion As New conexion
    Dim nue_conexion2 As New conexion
    Dim nue_var As New variables
    Dim nue_var1 As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from registro_pagos order by id_registro_pagos", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Descuentos
    Public Sub insertar(ByVal fecha As Date, ByVal operacion As String, ByVal banco As String, ByVal serie As String, ByVal factura As String, ByVal total_adeudado As Double, ByVal monto As Double, ByVal diferencia As Double, ByVal fecha_cheque As Date, ByVal pendiente As String, ByVal estado As String, ByVal cliente As String)
        nue_var.consulta = "INSERT INTO registro_pagos VALUES('', ?fecha, ?operacion, ?banco, ?serie, ?factura, ?total_adeudado, ?monto, ?diferencia, ?fecha_cheque, ?pendiente, ?estado, ?cliente)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?operacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operacion
            nue_var.cmd.Parameters.Add("?banco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = banco
            nue_var.cmd.Parameters.Add("?serie", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = serie
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
            nue_var.cmd.Parameters.Add("?total_adeudado", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_adeudado
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?diferencia", MySql.Data.MySqlClient.MySqlDbType.Double).Value = diferencia
            nue_var.cmd.Parameters.Add("?fecha_cheque", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_cheque
            nue_var.cmd.Parameters.Add("?pendiente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pendiente
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
          
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT numero_pedido FROM folio4 Where LENGTH(numero_pedido) >= 5 order by numero_pedido desc limit 100", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function descripcion_cliente(ByVal factura As String) As String
        nue_var.consulta = "SELECT cliente FROM folio4 WHERE numero_pedido = ?factura"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_cliente = nue_var.dr("cliente")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_cliente
    End Function
    Public Function descripcion_factura(ByVal factura As String) As String
        nue_var.consulta = "SELECT Expr2 FROM Cobranza_1 WHERE numero_pedido = ?factura"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_factura = nue_var.dr("Expr2")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_factura
    End Function
    Public Function listar3(ByVal numero_pedido As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Cobranza_edp where numero_pedido like '" & numero_pedido & "'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal cliente As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT * FROM registro_pagos WHERE cliente like '" & cliente & "' and operacion = 'CHEQUE' and fecha_cheque >= now() order by Id_registro_pagos desc", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * FROM registro_pagos WHERE cliente like '" & cliente & "' order by Id_registro_pagos desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function

    Public Sub modificar(ByVal Cod_Pago As Integer, ByVal operacion As String, ByVal banco As String, ByVal serie As String, ByVal fecha_cheque As Date, ByVal factura As String, ByVal monto As Double, ByVal total_adecuado As Double, ByVal diferencia As Double)
        nue_var.consulta = "UPDATE registro_pagos SET operacion = ?operacion, banco = ?banco, serie = ?serie, fecha_cheque = ?fecha_cheque, factura = ?factura, monto = ?monto, total_adecuado = ?total_adecuado, diferencia = ?diferencia WHERE Id_registro_pagos = ?Cod_Pago"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Pago
            nue_var.cmd.Parameters.Add("?operacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operacion
            nue_var.cmd.Parameters.Add("?banco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = banco
            nue_var.cmd.Parameters.Add("?serie", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = serie
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
            nue_var.cmd.Parameters.Add("?fecha_cheque", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_cheque
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?total_adecuado", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_adecuado
            nue_var.cmd.Parameters.Add("?diferencia", MySql.Data.MySqlClient.MySqlDbType.Double).Value = diferencia

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar5(ByVal cliente As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Cobranza_edp2 where cliente like '" & cliente & "' and (Expr2 > 1 or Expr2 < -1) order by numero_pedido asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Sub insertar2(ByVal folio As Integer, ByVal cliente As String, ByVal rut As String, ByVal fecha As Date, ByVal usuario As String, ByVal factura As String, ByVal monto As Double, ByVal contacto As String, ByVal horario As String, ByVal direccion As String, ByVal comuna As String)
        nue_var.consulta = "INSERT INTO retiro_documentos VALUES('', ?folio, ?cliente, ?rut, ?fecha, ?usuario, ?factura, ?monto, ?contacto, ?horario, ?direccion, ?comuna)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = folio
            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?contacto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = contacto
            nue_var.cmd.Parameters.Add("?horario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = horario
            nue_var.cmd.Parameters.Add("?direccion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = direccion
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function buscar_folio() As Integer
        nue_var.consulta = "SELECT folio FROM retiro_documentos order by Id_retiro desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio")) Then
                buscar_folio = 0
            Else
                buscar_folio = nue_var.dr("folio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return buscar_folio
    End Function
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from registro_pagos WHERE Id_registro_pagos = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar6(ByVal Factura As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Cobranza_edp where numero_pedido = '" & Factura & "' and (Expr2 > 1 or Expr2 < -1)", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
End Class
