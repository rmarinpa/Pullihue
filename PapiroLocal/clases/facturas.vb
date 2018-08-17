Imports MySql.Data.MySqlClient
Public Class facturas

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los registros de Movimiento de Tierra


    Public Function listar12(ByVal rut As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM facturas where rut like '" & rut & "' and estado like 'PENDIENTE' order by fecha_cheques desc, vencimiento asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar12 = nue_var.dt
        Return listar12
    End Function
    Public Function deuda_sin_doc(ByVal rut As String) As Double
        nue_var.consulta = "SELECT Sum(deuda_sin_documentar) FROM facturas where rut = ?rut and estado like 'PENDIENTE'"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(deuda_sin_documentar)")) Then
                deuda_sin_doc = 0
            Else
                deuda_sin_doc = nue_var.dr("Sum(deuda_sin_documentar)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return deuda_sin_doc
    End Function
    Public Function deuda_con_doc(ByVal rut As String) As Double
        nue_var.consulta = "SELECT Sum(cheques_en_cartera) FROM facturas where rut = ?rut and estado like 'PENDIENTE'"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(cheques_en_cartera)")) Then
                deuda_con_doc = 0
            Else
                deuda_con_doc = nue_var.dr("Sum(cheques_en_cartera)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return deuda_con_doc
    End Function

    Public Function descripcion_cupo(ByVal rut As String) As Double
        nue_var.consulta = "SELECT linea_credito FROM Clientes where rut = ?rut"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("linea_credito")) Then
                descripcion_cupo = 0
            Else
                descripcion_cupo = nue_var.dr("linea_credito")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_cupo
    End Function
    Public Function deuda_sin_doc2(ByVal rut As String) As Double
        nue_var.consulta = "SELECT Sum(deuda_sin_doc_ven) FROM facturas where rut = ?rut and estado like 'PENDIENTE'"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Sum(deuda_sin_doc_ven)")) Then
                deuda_sin_doc2 = 0
            Else
                deuda_sin_doc2 = nue_var.dr("Sum(deuda_sin_doc_ven)")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return deuda_sin_doc2
    End Function
End Class
