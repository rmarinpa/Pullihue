Imports MySql.Data.MySqlClient
Public Class guia_despacho

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from consulta_despacho2 order by Id_ventas desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM cliente_despacho order by cliente asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_pedido where cliente like '" & cliente & "' order by numero_pedido asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal cliente As String, ByVal numero_pedido As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from consulta_despacho2 where cliente like '" & cliente & "' and numero_pedido like '" & numero_pedido & "%' order by codigo_producto asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function

    Public Sub insertar(ByVal cliente As String, ByVal numero_pedido As Double, ByVal indicador_despacho As String, ByVal fecha As Date, ByVal hora As Date)
        nue_var.consulta = "INSERT INTO despachos VALUES('', ?cliente, ?numero_pedido, ?indicador_despacho, ?fecha, ?hora)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())


            nue_var.cmd.Parameters.Add("?cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cliente
            nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_pedido
            nue_var.cmd.Parameters.Add("?indicador_despacho", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = indicador_despacho
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
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from consulta_despachados Where fecha = '" & fecha & "' order by fecha desc, hora desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Function listar6() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio4 order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal numero_folio As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_un where numero_folio like '" & numero_folio & "' order by Id_ventas asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function listar27(ByVal numero_folio As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM venta_un_guias where numero_folio like '" & numero_folio & "' order by descripcion desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar27 = nue_var.dt
        Return listar27
    End Function
    Public Function listar8(ByVal fecha As String, ByVal fecha2 As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha8 Where Fecha >= '" & fecha2 & "' and Fecha <= '" & fecha & "' order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
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
    Public Sub modificar_guias(ByVal cod_est As Integer, ByVal factura As String)
        nue_var.consulta = "UPDATE folio_guias SET numero_pedido = ?factura WHERE Id_folio = ?cod_est"
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
    Public Function listar9(ByVal pedido As Double) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha8 Where folio = '" & pedido & "' order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar9 = nue_var.dt
        Return listar9
    End Function
    Public Function listar10(ByVal factura As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha8 Where numero_pedido like '" & factura & "' order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar10 = nue_var.dt
        Return listar10
    End Function
    Public Function descripcion_total(ByVal Fecha As Date, ByVal Fecha2 As Date) As String
        nue_var.consulta = "SELECT Sum(SumaDeventa_neta) FROM folio_fecha8 where Fecha <= ?Fecha and Fecha >= ?Fecha2 and CAST(numero_pedido AS UNSIGNED) <> 0"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
        nue_var.cmd.Parameters.Add("?Fecha2", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha2
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(SumaDeventa_neta)")) Then
                descripcion_total = ""
            Else
                descripcion_total = nue_var.dr("Sum(SumaDeventa_neta)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_total
    End Function
    Public Function listar11(ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha5 Where Fecha = '" & fecha & "' order by toma_pedido desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar11 = nue_var.dt
        Return listar11
    End Function
    Public Function listar12(ByVal rut As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from Clientes Where rut = '" & rut & "' order by id_clientes desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar12 = nue_var.dt
        Return listar12
    End Function
    Public Sub modificar_folio(ByVal ult_id As Integer, ByVal ult_fol As Integer)
        nue_var.consulta = "UPDATE Folios_factura SET ult_fol = ?ult_fol WHERE Id_folios = ?ult_id and tipo = 33"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?ult_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = ult_id
            nue_var.cmd.Parameters.Add("?ult_fol", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = ult_fol
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function buscar_folio() As Integer
        nue_var.consulta = "SELECT ult_fol FROM Folios_factura Where tipo = 33 and fol_fin >= ult_fol order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("ult_fol")) Then
                buscar_folio = 0
            Else
                buscar_folio = nue_var.dr("ult_fol")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return buscar_folio
    End Function
    Public Function ult_id() As Integer
        nue_var.consulta = "SELECT Id_folios FROM Folios_factura Where tipo = 33 order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Id_folios")) Then
                ult_id = ""
            Else
                ult_id = nue_var.dr("Id_folios")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return ult_id
    End Function
    Public Function listar13() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha8 Where numero_pedido = '0' and Fecha >= '2016-10-01' order by Fecha asc, Folio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar13 = nue_var.dt
        Return listar13
    End Function
    Public Sub modificar_fecha(ByVal numero_folio As Double, ByVal fecha As Date)
        nue_var.consulta = "UPDATE venta4 SET fecha = ?fecha WHERE numero_folio = ?numero_folio"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?numero_folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_folio
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_fecha_guias(ByVal numero_folio As Double, ByVal fecha As Date)
        nue_var.consulta = "UPDATE venta_guias SET fecha = ?fecha WHERE numero_folio = ?numero_folio"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?numero_folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_folio
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function verificar_folio(ByVal folio As Double) As Boolean
        nue_var.consulta = "SELECT * FROM folio4 WHERE numero_pedido = ?folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_folio = True
        Else
            verificar_folio = False
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_folio
    End Function
    Public Function listar14() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_guia3 Where condicion = 1 order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function
    Public Function buscar_folio_guia() As Integer
        nue_var.consulta = "SELECT ult_fol FROM Folios_factura Where tipo = 52 and fol_fin >= ult_fol order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("ult_fol")) Then
                buscar_folio_guia = 0
            Else
                buscar_folio_guia = nue_var.dr("ult_fol")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return buscar_folio_guia
    End Function
    Public Sub modificar_folio_guias(ByVal ult_id As Integer, ByVal ult_fol As Integer)
        nue_var.consulta = "UPDATE Folios_factura SET ult_fol = ?ult_fol WHERE Id_folios = ?ult_id and tipo = 52"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?ult_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = ult_id
            nue_var.cmd.Parameters.Add("?ult_fol", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = ult_fol
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function ult_id_guias() As Integer
        nue_var.consulta = "SELECT Id_folios FROM Folios_factura Where tipo = 52 order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Id_folios")) Then
                ult_id_guias = ""
            Else
                ult_id_guias = nue_var.dr("Id_folios")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return ult_id_guias
    End Function
    Public Function verificar_folio_guias(ByVal folio As Double) As Boolean
        nue_var.consulta = "SELECT * FROM folio_guias WHERE numero_pedido = ?folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_folio_guias = True
        Else
            verificar_folio_guias = False
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_folio_guias
    End Function
    Public Sub modificar2(ByVal cod_est As Integer, ByVal condicion As Integer)
        nue_var.consulta = "UPDATE folio_guias SET condicion = ?condicion WHERE Id_folio = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?condicion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = condicion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar15() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_guia3 Where condicion = 0 or isnull(condicion) order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar15 = nue_var.dt
        Return listar15
    End Function
    Public Sub insertar2(ByVal id_tipo_doc As Integer, ByVal tipo_doc As String, ByVal numero_doc As Integer, ByVal id_tipo_aut As Integer, ByVal tipo_aut As String, ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date)
        nue_var.consulta = "INSERT INTO autorizacion_otros VALUES('', ?id_tipo_doc, ?tipo_doc, ?numero_doc, ?id_tipo_aut, ?tipo_aut, ?usuario, ?fecha, ?hora)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?id_tipo_doc", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_tipo_doc
            nue_var.cmd.Parameters.Add("?tipo_doc", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_doc
            nue_var.cmd.Parameters.Add("?numero_doc", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = numero_doc
            nue_var.cmd.Parameters.Add("?id_tipo_aut", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_tipo_aut
            nue_var.cmd.Parameters.Add("?tipo_aut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_aut
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar3(ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date, ByVal tipo_doc As String, ByVal num_doc As Double, ByVal num_emi As Double)
        nue_var.consulta = "INSERT INTO registro_reemitir VALUES('', ?usuario, ?fecha, ?hora, ?tipo_doc, ?num_doc, ?num_emi)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?tipo_doc", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_doc
            nue_var.cmd.Parameters.Add("?num_doc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_doc
            nue_var.cmd.Parameters.Add("?num_emi", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_emi
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function ult_ver() As Integer
        nue_var.consulta = "SELECT ult_fol FROM Folios_factura Where tipo = 33 order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("ult_fol")) Then
                ult_ver = 1
            Else
                ult_ver = nue_var.dr("ult_fol")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return ult_ver
    End Function
    Public Sub modificar3(ByVal cod_est As Integer, ByVal factura As String)
        nue_var.consulta = "UPDATE folio_guias SET numero_pedido = ?factura WHERE Id_folio = ?cod_est"
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
    Public Function ult_ver2() As Integer
        nue_var.consulta = "SELECT ult_fol FROM Folios_factura Where tipo = 52 order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("ult_fol")) Then
                ult_ver2 = 1
            Else
                ult_ver2 = nue_var.dr("ult_fol")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return ult_ver2
    End Function
    Public Function descripcion_pedido(ByVal Fecha As Date, ByVal Fecha2 As Date) As String
        nue_var.consulta = "SELECT Sum(SumaDeventa_neta) FROM folio_fecha8 where Fecha <= ?Fecha and Fecha >= ?Fecha2 and (CAST(numero_pedido AS UNSIGNED) <> 0 or numero_pedido = '0')"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
        nue_var.cmd.Parameters.Add("?Fecha2", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha2
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(SumaDeventa_neta)")) Then
                descripcion_pedido = ""
            Else
                descripcion_pedido = nue_var.dr("Sum(SumaDeventa_neta)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_pedido
    End Function
    Public Function buscarIdentificadorFolioGuia(ByVal folio As Integer) As String
        nue_var.consulta = "SELECT Id_folio FROM folio_guias WHERE folio = ?folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Id_folio")) Then
                buscarIdentificadorFolioGuia = ""
            Else
                buscarIdentificadorFolioGuia = nue_var.dr("Id_folio")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return buscarIdentificadorFolioGuia
    End Function

    Public Function listar16(ByVal n_pedido As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from ruta_pedido Where n_pedido = '" & n_pedido & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar16 = nue_var.dt
        Return listar16
    End Function

    Public Function listar17(ByVal n_pedido As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from ruta_guia Where n_pedido = '" & n_pedido & "' order by Id_ruta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar17 = nue_var.dt
        Return listar17
    End Function

    Public Sub insertar4(ByVal pedido As Double, ByVal factura As String, ByVal rut_cliente As String, ByVal nombre_cliente As String, ByVal email As String)
        nue_var.consulta = "INSERT INTO log_emails (pedido, factura, rut_cliente, nombre_cliente, email) VALUES(?pedido, ?factura, ?rut_cliente, ?nombre_cliente, ?email)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = pedido
            nue_var.cmd.Parameters.Add("?factura", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = factura
            nue_var.cmd.Parameters.Add("?rut_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut_cliente
            nue_var.cmd.Parameters.Add("?nombre_cliente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_cliente
            nue_var.cmd.Parameters.Add("?email", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = email

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
End Class
