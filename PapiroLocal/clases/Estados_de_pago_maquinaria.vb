Imports MySql.Data.MySqlClient
Public Class Estados_de_pago_maquinaria

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes where obra like '%" & nombre_obra & "%' order by Nombre asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
End Class
