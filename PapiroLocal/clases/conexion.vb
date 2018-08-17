Imports MySql.Data.MySqlClient

Public Class conexion

    'Cadena de conexión a base de datos MYSQL

    Private con As New MySqlConnection("server=localhost; database=const113_papiro; user id=root; password=toor; convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false; default command timeout=70")
    'procedimiento que abre la conexion mysql

    'Metodo que se utiliza para conectar la base de datos y hacer consultas
    Public Sub conectar()
        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & vbCrLf & ex.Message)
        End Try
    End Sub

    'Metodo que cierra la conexion mysql, para no dejar sesiones abiertas y asi, saturar la BD con  conexiones
    Public Sub desconectar()
        Try
            con.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & vbCrLf & ex.Message)
        End Try
    End Sub

    'funcion que devuelve la conexion mysql
    Function conex() As MySqlConnection
        conex = con
        Return conex
    End Function
End Class