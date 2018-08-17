Imports MySql.Data.MySqlClient
Public Class Departamento

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function Listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Departamento;", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)

        ' Inserta una fila en el datatable y lo posiciona 
        Dim allRow As DataRow = nue_var.dt.NewRow
        allRow("Id_obras") = 0 ' Id tabla
        allRow("Nombre") = "Seleccione" ' Nombre dato
        nue_var.dt.Rows.InsertAt(allRow, 0) ' valores a insertar, posición

        nue_conexion.desconectar()
        Listar = nue_var.dt
        Return Listar
    End Function

End Class