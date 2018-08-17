Imports MySql.Data.MySqlClient '
Public Class jornada

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las jornadas
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MysqlDataAdapter("SELECT * FROM jornada", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

End Class
