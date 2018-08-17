Imports MySql.Data.MySqlClient
Public Class Alerta
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String


    Public Function listar(ByVal fecha As String, ByVal fecha2 As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_alerta_precios where precio < precio_min and Fecha >= '" & fecha2 & "' and Fecha <= '" & fecha & "' order by num_pedido desc, codigo_producto asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Function listar2(ByVal fecha As String, ByVal fecha2 As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_alerta_precios where precio > precio_max and Fecha >= '" & fecha2 & "' and Fecha <= '" & fecha & "' order by num_pedido desc, codigo_producto asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    Public Function listar4() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM compras", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4()
    End Function
End Class
