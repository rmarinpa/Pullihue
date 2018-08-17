Imports MySql.Data.MySqlClient
Public Class conexion

    'aqui coloca tu cadena de conexion de xampp, wampp o lo que sea que uses
    Private con As New MySqlConnection("server=201.148.105.75; database=const113_Papiro; user id=const113_papiro2; password=papiro2017;Convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false; default command timeout=40")
    'Private con As New MySqlConnection("server=localhost; database=papiro_local; user id=root; password=;Convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false; default command timeout=40")
    'procedimiento que abre la conexion mysql
    Public Sub conectar()
        con.Open()
    End Sub

    'procedimiento quecierra la conexion mysql
    Public Sub desconectar()
        con.Close()
    End Sub

    'funcion que devuelve la conexion mysql
    Function conex() As MySqlConnection
        conex = con
        Return conex
    End Function

End Class