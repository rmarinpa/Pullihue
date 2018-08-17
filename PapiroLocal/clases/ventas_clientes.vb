Imports MySql.Data.MySqlClient
Public Class ventas_clientes

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes order by clientes asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
 
    Public Function descripcion_comuna(ByVal clientes As String) As String
        nue_var.consulta = "SELECT comuna FROM Clientes WHERE clientes = ?clientes"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?clientes", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = clientes
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("comuna")) Then
                descripcion_comuna = ""
            Else
                descripcion_comuna = nue_var.dr("comuna")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_comuna
    End Function
    Public Function descripcion_direccion(ByVal clientes As String) As String
        nue_var.consulta = "SELECT direccion FROM Clientes WHERE clientes = ?clientes"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?clientes", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = clientes
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("direccion")) Then
                descripcion_direccion = ""
            Else
                descripcion_direccion = nue_var.dr("direccion")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_direccion
    End Function
    Public Function descripcion_senal_advertencia(ByVal clientes As String) As String
        nue_var.consulta = "SELECT senal_advertencia FROM Clientes WHERE clientes = ?clientes"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?clientes", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = clientes
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("senal_advertencia")) Then
                descripcion_senal_advertencia = ""
            Else
                descripcion_senal_advertencia = nue_var.dr("senal_advertencia")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_senal_advertencia
    End Function
    Public Function descripcion_rut(ByVal clientes As String) As String
        nue_var.consulta = "SELECT rut FROM Clientes WHERE clientes = ?clientes"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?clientes", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = clientes
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("rut")) Then
                descripcion_rut = ""
            Else
                descripcion_rut = nue_var.dr("rut")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_rut
    End Function
    Public Function listar3(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes where clientes like '%" & cliente & "%' order by clientes desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal cliente As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Clientes where rut like '%" & cliente & "%' order by rut desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Function BuscarCliente(ByVal nombre As String, ByVal rut As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar() ' se abre la conexion
        nue_var.cmd = New MySqlCommand("buscar_cliente", nue_conexion.conex()) ' se indica el nombre de la accion
        With nue_var.cmd
            ' Se indica que se utilizara un procedimiento almacenado
            .CommandType = CommandType.StoredProcedure
            ' Se pasan el valor a los parametros.
            .Parameters.AddWithValue("@_nombre", nombre)
            .Parameters.AddWithValue("@_rut", rut)
        End With
        nue_var.da = New MySqlDataAdapter(nue_var.cmd)
        With nue_var.da
            .Fill(nue_var.dt)
        End With
        nue_conexion.desconectar()
        BuscarCliente = nue_var.dt
        Return BuscarCliente
    End Function

    Public Function listar5(ByVal serie As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM registro_pagos_rut3 where serie like '%" & serie & "%' and operacion like 'CHEQUE' order by cliente asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
End Class
