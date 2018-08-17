Imports MySql.Data.MySqlClient
Public Class Folios

   
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    'funcion para listar los folios
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Folios_factura order by Id_folios desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar registros de folios
    Public Sub insertar(ByVal tipo As String, ByVal doc As String, ByVal fol_in As Integer, ByVal fol_fin As Integer, ByVal ult_fol As Integer)
        nue_var.consulta = "INSERT INTO Folios_factura VALUES('', ?tipo, ?doc, ?fol_in, ?fol_fin, ?ult_fol)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?doc", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = doc
            nue_var.cmd.Parameters.Add("?fol_in", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = fol_in
            nue_var.cmd.Parameters.Add("?fol_fin", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = fol_fin
            nue_var.cmd.Parameters.Add("?ult_fol", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = ult_fol

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Petroleo   
    Public Sub modificar(ByVal Cod_folios As Integer, ByVal tipo As String, ByVal doc As String, ByVal fol_in As Integer, ByVal fol_fin As Integer, ByVal ult_fol As Integer)
        nue_var.consulta = "UPDATE Folios_factura SET tipo = ?tipo, doc = ?doc, fol_in = ?fol_in, fol_fin = ?fol_fin, ult_fol = ?ult_fol WHERE Id_folios = ?Cod_folios"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_folios", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_folios
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?doc", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = doc
            nue_var.cmd.Parameters.Add("?fol_in", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = fol_in
            nue_var.cmd.Parameters.Add("?fol_fin", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = fol_fin
            nue_var.cmd.Parameters.Add("?ult_fol", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = ult_fol
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal Cod_folios As Integer)
        nue_var.consulta = "Delete from Folios_factura WHERE Id_folios = " & Cod_folios & ""

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
