Imports MySql.Data.MySqlClient
Public Class Compra_petroleo

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Compras de Petróleo
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Compras_petroleo where obra like '%" & nombre_obra & "%' order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar registros de Compras de Petróleo
    Public Sub insertar(ByVal fecha As Date, ByVal N_factura As Double, ByVal proveedor As String, ByVal rut As String, ByVal descuento As Double, ByVal imp_esp_var As Double, ByVal imp_esp_fijo As Double, ByVal precio_base As Double, ByVal total_neto As Double, ByVal total_iva As Double, ByVal total_iev As Double, ByVal total_ief As Double, ByVal total_ventas As Double, ByVal precio As Double, ByVal litros As Double, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Compras_petroleo VALUES('', ?fecha, ?N_factura, ?proveedor, ?rut, ?Descuento, ?Imp_esp_var, ?Imp_esp_fijo, ?Precio_base, ?Total_neto, ?Total_iva, ?Total_IEV, ?Total_IEF, ?Total_ventas, ?Precio, ?Litros, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?N_factura", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_factura
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_neto
            nue_var.cmd.Parameters.Add("?Total_iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_iev
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_ief
            nue_var.cmd.Parameters.Add("?Total_ventas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_ventas
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = litros
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Compras Petróleo   
    Public Sub modificar(ByVal Cod_Petroleo As Integer, ByVal fecha As Date, ByVal N_factura As Double, ByVal proveedor As String, ByVal rut As String, ByVal descuento As Double, ByVal imp_esp_var As Double, ByVal imp_esp_fijo As Double, ByVal precio_base As Double, ByVal total_neto As Double, ByVal total_iva As Double, ByVal total_iev As Double, ByVal total_ief As Double, ByVal total_ventas As Double, ByVal precio As Double, ByVal litros As Double, ByVal obra As String)
        nue_var.consulta = "UPDATE Compras_petroleo SET fecha = ?fecha, N_factura = ?N_factura, Proveedor = ?proveedor, Rut = ?rut, Descuento = ?descuento, imp_esp_var = ?imp_esp_var, imp_esp_fijo = ?imp_esp_fijo, Precio_base = ?precio_base, Total_neto = ?total_neto, Total_Iva = ?total_Iva, Total_IEV = ?total_iev, Total_IEF = ?total_ief, Total_Ventas = ?total_ventas, Precio = ?precio, Litros = ?litros, obra = ?Obra WHERE Id_compras = ?Cod_Petroleo"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Petroleo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Petroleo
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?N_factura", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_factura
            nue_var.cmd.Parameters.Add("?proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = proveedor
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Double).Value = descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_neto
            nue_var.cmd.Parameters.Add("?Total_iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_iev
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_ief
            nue_var.cmd.Parameters.Add("?Total_ventas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_ventas
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = litros
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_petroleo As Integer)
        nue_var.consulta = "Delete from Compras_petroleo WHERE Id_compras = " & cod_petroleo & ""

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






