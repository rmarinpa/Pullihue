Imports MySql.Data.MySqlClient
Public Class Compras

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar8(ByVal producto As String, ByVal categoria As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where Categoria like '%" & producto & "%' and Categoria2 like '%" & categoria & "' and activo = 1 order by largo asc, ancho asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function
    Public Function listar14(ByVal producto As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Codigos4 where Descripcion like '%" & producto & "%' order by largo asc, ancho asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function
    Public Function listar13(ByVal categoria As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Categoria where Categoria1 like '%" & categoria & "%' order by Categoria2 asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar13 = nue_var.dt
        Return listar13
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
    Public Sub insertar(ByVal Pai As String, ByVal Codigo As String, ByVal ancho As Double, ByVal largo As Double, ByVal Cantidad As Double, ByVal Descripcion As String, ByVal Eta As String, ByVal fecha_ingreso As Date, ByVal obs As String, ByVal folio_compra As Double, ByVal pai_cn As String)
        nue_var.consulta = "INSERT INTO Compras VALUES('', ?Pai, ?Codigo, ?ancho, ?largo, ?Cantidad, ?Descripcion, ?Eta, ?fecha_ingreso, ?obs, ?folio_compra, ?pai_cn)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Pai", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Pai
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?ancho", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ancho
            nue_var.cmd.Parameters.Add("?largo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = largo
            nue_var.cmd.Parameters.Add("?Cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cantidad
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?Eta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Eta
            nue_var.cmd.Parameters.Add("?fecha_ingreso", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_ingreso
            nue_var.cmd.Parameters.Add("?obs", MySql.Data.MySqlClient.MySqlDbType.String).Value = obs
            nue_var.cmd.Parameters.Add("?folio_compra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio_compra
            nue_var.cmd.Parameters.Add("?pai_cn", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pai_cn
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function descripcion_numero_folio() As Double
        nue_var.consulta = "SELECT folio_compra FROM folio_compra order by folio_compra desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio_compra")) Then
                descripcion_numero_folio = ""
            Else
                descripcion_numero_folio = nue_var.dr("folio_compra")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_folio
    End Function
    Public Function descripcion_numero_folio2(ByVal folio As Double, ByVal cliente As String) As Double
        nue_var.consulta = "SELECT folio_compra FROM folio_compra where folio_compra like '" & folio & "' and proveedor like '" & cliente & "' order by folio_compra desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("folio_compra")) Then
                descripcion_numero_folio2 = ""
            Else
                descripcion_numero_folio2 = nue_var.dr("folio_compra")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_numero_folio2
    End Function
    Public Sub insertar3(ByVal folio As Double, ByVal numero_pedido As Double, ByVal proveedor As String)
        nue_var.consulta = "INSERT INTO folio_compra VALUES('', ?folio, ?numero_pedido, ?proveedor)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio
            nue_var.cmd.Parameters.Add("?numero_pedido", MySql.Data.MySqlClient.MySqlDbType.Double).Value = numero_pedido
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar(ByVal folio As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Compras where folio_compra like '%" & folio & "%' order by folio_compra desc, Codigo desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function descripcion_items(ByVal folio As Double) As String
        nue_var.consulta = "SELECT Sum(Cantidad) FROM Compras where folio_compra = ?numero_folio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?numero_folio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = folio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(Cantidad)")) Then
                descripcion_items = ""
            Else
                descripcion_items = nue_var.dr("Sum(Cantidad)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_items
    End Function
    Public Sub insertar4(ByVal folio_compra As Double, ByVal fecha_compra As Date, ByVal hora_compra As Date, ByVal nombre_ejecutivo As String, ByVal pai_cn As String)
        nue_var.consulta = "INSERT INTO nota_compra VALUES('', ?folio_compra, ?fecha_compra, ?hora_compra, ?nombre_ejecutivo, ?pai_cn)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?folio_compra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = folio_compra
            nue_var.cmd.Parameters.Add("?fecha_compra", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_compra
            nue_var.cmd.Parameters.Add("?hora_compra", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora_compra
            nue_var.cmd.Parameters.Add("?nombre_ejecutivo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_ejecutivo
            nue_var.cmd.Parameters.Add("?pai_cn", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pai_cn
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
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
                Seleccionar_stock = ""
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
    Public Sub eliminar(ByVal cod_Mov_Tierra As Integer)
        nue_var.consulta = "Delete from Compras WHERE Id_Compras = " & cod_Mov_Tierra & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
