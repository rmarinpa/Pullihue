Imports MySql.Data.MySqlClient
Public Class ventas2

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar24() As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM folio4 order by folio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar24 = nue_var.dt
        Return listar24
    End Function
End Class
