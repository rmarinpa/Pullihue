Imports MySql.Data.MySqlClient
Public Class Contratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from Codigos4 order by Codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar4(ByVal nombre_codigo As String) As String
        Dim codigo As String
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Codigo FROM Codigos4 where Codigo like '%" & nombre_codigo & "%' order by Codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        If nue_var.dt.Rows.Count > 0 Then
            codigo = nue_var.dt.Rows(0)("Codigo").ToString()
        Else
            codigo = ""
        End If
        nue_conexion.desconectar()
        'listar4 = nue_var.dt
        Return codigo
    End Function
    'procedimiento para insertar Contratos
    Public Sub insertar(ByVal Codigo As String, ByVal Marca As String, ByVal Descripcion As String, ByVal Tipo_1 As String, ByVal medidas As String, ByVal unid_paquete As Double, ByVal ancho As Double, ByVal largo As Double, ByVal area As Double, ByVal descripcion_2 As String, ByVal area_negocio As String, ByVal proveedor As String, ByVal mapa As String, ByVal descripcion_3 As String, ByVal obs As String, ByVal familia As String, ByVal familia_2 As String, ByVal familia_3 As String, ByVal stock As Double, ByVal medida_unid As Double, ByVal precio As Double, ByVal fecha_caducidad As Date, ByVal precio_max As Double, ByVal precio_min As Double, ByVal activo As String, ByVal Categoria As String, ByVal Categoria2 As String)
        nue_var.consulta = "INSERT INTO Codigos4 VALUES('', ?Codigo, ?Marca, ?Descripcion, ?Tipo_1, ?medidas, ?unid_paquete, ?ancho, ?largo, ?area, ?descripcion_2, ?area_negocio, ?proveedor, ?mapa, ?descripcion_3, ?obs, ?familia, ?familia_2, ?familia_3, ?stock, ?medida_unid, ?precio, ?fecha_caducidad, ?precio_max, ?precio_min, ?activo, ?Categoria, ?Categoria2)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?Marca", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Marca
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?Tipo_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_1
            nue_var.cmd.Parameters.Add("?medidas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medidas
            nue_var.cmd.Parameters.Add("?unid_paquete", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unid_paquete
            nue_var.cmd.Parameters.Add("?ancho", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ancho
            nue_var.cmd.Parameters.Add("?largo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = largo
            nue_var.cmd.Parameters.Add("?area", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area
            nue_var.cmd.Parameters.Add("?descripcion_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion_2
            nue_var.cmd.Parameters.Add("?area_negocio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = area_negocio
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?mapa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = mapa
            nue_var.cmd.Parameters.Add("?descripcion_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion_3
            nue_var.cmd.Parameters.Add("?obs", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obs
            nue_var.cmd.Parameters.Add("?familia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia
            nue_var.cmd.Parameters.Add("?familia_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_2
            nue_var.cmd.Parameters.Add("?familia_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_3
            nue_var.cmd.Parameters.Add("?stock", MySql.Data.MySqlClient.MySqlDbType.Double).Value = stock
            nue_var.cmd.Parameters.Add("?medida_unid", MySql.Data.MySqlClient.MySqlDbType.Double).Value = medida_unid
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?fecha_caducidad", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_caducidad
            nue_var.cmd.Parameters.Add("?precio_max", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_max
            nue_var.cmd.Parameters.Add("?precio_min", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_min
            nue_var.cmd.Parameters.Add("?activo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = activo
            nue_var.cmd.Parameters.Add("?Categoria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Categoria
            nue_var.cmd.Parameters.Add("?Categoria2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Categoria2
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal Codigo As String, ByVal Marca As String, ByVal Descripcion As String, ByVal Tipo_1 As String, ByVal medidas As String, ByVal unid_paquete As Double, ByVal ancho As Double, ByVal largo As Double, ByVal area As Double, ByVal descripcion_2 As String, ByVal area_negocio As String, ByVal proveedor As String, ByVal mapa As String, ByVal descripcion_3 As String, ByVal obs As String, ByVal familia As String, ByVal familia_2 As String, ByVal familia_3 As String, ByVal stock As Double, ByVal medida_unid As Double, ByVal precio As Double, ByVal fecha_caducidad As Date, ByVal precio_max As Double, ByVal precio_min As Double, ByVal activo As String, ByVal Categoria As String, ByVal Categoria2 As String)
        nue_var.consulta = "UPDATE Codigos4 SET Codigo = ?Codigo, Marca = ?Marca, Descripcion = ?Descripcion, Tipo_1 = ?Tipo_1, medidas = ?medidas, unid_paquete = ?unid_paquete, ancho = ?ancho, largo = ?largo, area = ?area, descripcion_2 = ?descripcion_2, area_negocio = ?area_negocio, proveedor = ?proveedor, mapa = ?mapa, descripcion_3 = ?descripcion_3, obs = ?obs, familia = ?familia, familia_2 = ?familia_2, familia_3 = ?familia_3, stock = ?stock, medida_unid = ?medida_unid, Precio_lista = ?precio, fecha_caducidad = ?fecha_caducidad, precio_max = ?precio_max, precio_min = ?precio_min, activo = ?activo, Categoria = ?Categoria, Categoria2 = ?Categoria2 WHERE id_codigos = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?Marca", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Marca
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?Tipo_1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_1
            nue_var.cmd.Parameters.Add("?medidas", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = medidas
            nue_var.cmd.Parameters.Add("?unid_paquete", MySql.Data.MySqlClient.MySqlDbType.Double).Value = unid_paquete
            nue_var.cmd.Parameters.Add("?ancho", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ancho
            nue_var.cmd.Parameters.Add("?largo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = largo
            nue_var.cmd.Parameters.Add("?area", MySql.Data.MySqlClient.MySqlDbType.Double).Value = area
            nue_var.cmd.Parameters.Add("?descripcion_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion_2
            nue_var.cmd.Parameters.Add("?area_negocio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = area_negocio
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?mapa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = mapa
            nue_var.cmd.Parameters.Add("?descripcion_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion_3
            nue_var.cmd.Parameters.Add("?obs", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obs
            nue_var.cmd.Parameters.Add("?familia", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia
            nue_var.cmd.Parameters.Add("?familia_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_2
            nue_var.cmd.Parameters.Add("?familia_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia_3
            nue_var.cmd.Parameters.Add("?stock", MySql.Data.MySqlClient.MySqlDbType.Double).Value = stock
            nue_var.cmd.Parameters.Add("?medida_unid", MySql.Data.MySqlClient.MySqlDbType.Double).Value = medida_unid
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?fecha_caducidad", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_caducidad
            nue_var.cmd.Parameters.Add("?precio_max", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_max
            nue_var.cmd.Parameters.Add("?precio_min", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_min
            nue_var.cmd.Parameters.Add("?activo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = activo
            nue_var.cmd.Parameters.Add("?Categoria", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Categoria
            nue_var.cmd.Parameters.Add("?Categoria2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Categoria2
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar(ByVal tipo As String, ByVal familia1 As String, ByVal familia2 As String, ByVal familia3 As String, ByVal precioMin As Integer, _
                    ByVal precioMax As Integer, ByVal mapa As String)
        nue_var.consulta = "UPDATE Codigos4 SET Tipo_1 = ?tipo, familia = ?familia1, familia_2 = ?familia2, familia_3 = ?familia3, precio_max = ?precioMax, precio_min = ?precioMin WHERE mapa = ?mapa"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?familia1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia1
            nue_var.cmd.Parameters.Add("?familia2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia2
            nue_var.cmd.Parameters.Add("?familia3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = familia3
            nue_var.cmd.Parameters.Add("?precioMin", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = precioMin
            nue_var.cmd.Parameters.Add("?precioMax", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = precioMax
            nue_var.cmd.Parameters.Add("?mapa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = mapa
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            nue_conexion.desconectar()
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Codigos4 WHERE id_codigos = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar14(ByVal codigo As String, ByVal producto As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where Descripcion like '%" & producto & "%'and Codigo like '%" & codigo & "%' order by largo asc, ancho asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function
End Class
