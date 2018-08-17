Imports MySql.Data.MySqlClient
Public Class emitir_nota_credito

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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM nota_credito_con2 where folio like '" & numero_folio & "' order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function listar7_pend(ByVal numero_folio As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM nota_credito_con2_pend where folio like '" & numero_folio & "' and condicion = 0 order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7_pend = nue_var.dt
        Return listar7_pend
    End Function
    Public Function listar8() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_nc Where condicion = 1 order by CAST(folio AS UNSIGNED) desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function
    Public Sub modificar(ByVal cod_est As Integer, ByVal factura As String)
        nue_var.consulta = "UPDATE folio_nc SET nota_credito = ?factura WHERE Id_folio_nc = ?cod_est"
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
    Public Function descripcion_total(ByVal Fecha As Date) As String
        nue_var.consulta = "SELECT Sum(SumaDeventa_neta) FROM folio_fecha8 where Fecha = ?Fecha and numero_pedido <> 'NULO'"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
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
        nue_var.consulta = "UPDATE Folios_factura SET ult_fol = ?ult_fol WHERE Id_folios = ?ult_id and tipo = 61"
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
        nue_var.consulta = "SELECT ult_fol FROM Folios_factura Where tipo = 61 and fol_fin >= ult_fol order by Id_folios desc"
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
        nue_var.consulta = "SELECT Id_folios FROM Folios_factura Where tipo = 61 order by Id_folios desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Id_folios")) Then
                ult_id = 1
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
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_fecha8 Where Fecha >= '2016-10-01' and numero_pedido = '0' order by Fecha asc, Folio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar13 = nue_var.dt
        Return listar13
    End Function
    Public Function listar14() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_nc Where condicion = 0 or isnull(condicion) order by CAST(folio AS UNSIGNED) desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function
    Public Function listar14_pend() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from folio_nc Where condicion like '0' order by CAST(folio AS UNSIGNED) desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14_pend = nue_var.dt
        Return listar14_pend
    End Function
    Public Sub modificar2(ByVal cod_est As Integer, ByVal condicion As Integer)
        nue_var.consulta = "UPDATE folio_nc SET condicion = ?condicion WHERE Id_folio_nc = ?cod_est"
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
    Public Sub modificar_folio2(ByVal ult_id As Integer, ByVal ult_fol As Integer)
        nue_var.consulta = "UPDATE Folios_factura SET ult_fol = ?ult_fol WHERE Id_folios = ?ult_id and tipo = 61"
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
    Public Function ult_ver() As Integer
        nue_var.consulta = "SELECT ult_fol FROM Folios_factura Where tipo = 61 order by Id_folios desc"
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
End Class
