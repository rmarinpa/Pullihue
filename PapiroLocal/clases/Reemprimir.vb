Imports MySql.Data.MySqlClient
Public Class Reemprimir


    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    'funcion para listar los registros de Reemprimir
    Public Function listar(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Petroleo where obra like '%" & nombre_obra & "%' order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    'procedimiento para insertar registros de Reemprimir
    Public Sub insertar(ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date, ByVal tipo_doc As Integer, ByVal num_doc As Integer, ByVal cuenta_imp As Integer)
        nue_var.consulta = "INSERT INTO reemprimir VALUES('', ?usuario, ?fecha, ?hora, ?tipo_doc, ?num_doc, ?cuenta_imp)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?tipo_doc", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tipo_doc
            nue_var.cmd.Parameters.Add("?num_doc", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_doc
            nue_var.cmd.Parameters.Add("?cuenta_imp", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = cuenta_imp

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Reemprimir   
    Public Sub modificar(ByVal Cod_Petroleo As Integer, ByVal N_de_vale As Double, ByVal Codigo As String, ByVal fecha As Date, ByVal litros_consumo As Double, ByVal obra As String)
        nue_var.consulta = "UPDATE Petroleo SET N_de_vale = ?N_de_vale, Codigo = ?Codigo, fecha = ?fecha, litros_consumo = ?litros_consumo, obra = ?obra WHERE Id_petroleo = ?Cod_Petroleo"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Petroleo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Petroleo
            nue_var.cmd.Parameters.Add("?N_de_vale", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_de_vale
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = litros_consumo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_petroleo As Integer)
        nue_var.consulta = "Delete from Petroleo WHERE Id_petroleo = " & cod_petroleo & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Function reemprimir(ByVal num_doc As Double, ByVal tipo_doc As Double) As Double
        nue_var.consulta = "SELECT cuenta FROM cuenta_reemprimir WHERE num_doc = ?num_doc and tipo_doc = ?tipo_doc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_doc", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_doc
        nue_var.cmd.Parameters.Add("?tipo_doc", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tipo_doc
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            reemprimir = nue_var.dr("cuenta")
        Else
            reemprimir = 0
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return reemprimir
    End Function
End Class
