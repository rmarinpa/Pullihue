Imports MySql.Data.MySqlClient
Public Class ficha_trabajador

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from ficha_trabajador order by Nombres asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'procedimiento para insertar Contratos
    Public Sub insertar(ByVal Nombres As String, ByVal Apellidos As String, ByVal Rut As String, ByVal Fecha_de_nacimiento As Date, ByVal Lugar_de_nacimiento As String, ByVal Estado_Civil As String, ByVal Domicilio As String, ByVal Telefonos As String, ByVal E_mail As String, ByVal Tipo_de_contrato As String, ByVal Faena_actual As String, ByVal Profesion_Oficio As String, ByVal Cargo_labor As String, ByVal AFP As String, ByVal Salud As String, ByVal Fecha_de_Ingreso_Empresa As Date, ByVal Nivel_de_escolaridad As String, ByVal Situacion_habitacional As String, ByVal Integrantes_hogar As String, ByVal Cargas_familiares As Double, ByVal observaciones As String)
        nue_var.consulta = "INSERT INTO ficha_trabajador VALUES('', ?Nombres, ?Apellidos, ?Rut, ?Fecha_de_nacimiento, ?Lugar_de_nacimiento, ?Estado_Civil, ?Domicilio, ?Telefonos, ?E_mail, ?Tipo_de_contrato, ?Faena_actual, ?Profesion_Oficio, ?Cargo_labor, ?AFP, ?Salud, ?Fecha_de_Ingreso_Empresa, ?Nivel_de_escolaridad, ?Situacion_habitacional, ?Integrantes_hogar, ?Cargas_familiares, ?observaciones)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Nombres", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nombres
            nue_var.cmd.Parameters.Add("?Apellidos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Apellidos
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Fecha_de_nacimiento", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_de_nacimiento
            nue_var.cmd.Parameters.Add("?Lugar_de_nacimiento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Lugar_de_nacimiento
            nue_var.cmd.Parameters.Add("?Estado_Civil", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Estado_Civil
            nue_var.cmd.Parameters.Add("?Domicilio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Domicilio
            nue_var.cmd.Parameters.Add("?Telefonos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Telefonos
            nue_var.cmd.Parameters.Add("?E_mail", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = E_mail
            nue_var.cmd.Parameters.Add("?Tipo_de_contrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_de_contrato
            nue_var.cmd.Parameters.Add("?Faena_actual", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Faena_actual
            nue_var.cmd.Parameters.Add("?Profesion_Oficio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Profesion_Oficio
            nue_var.cmd.Parameters.Add("?Cargo_labor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cargo_labor
            nue_var.cmd.Parameters.Add("?AFP", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = AFP
            nue_var.cmd.Parameters.Add("?Salud", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Salud
            nue_var.cmd.Parameters.Add("?Fecha_de_Ingreso_Empresa", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_de_Ingreso_Empresa
            nue_var.cmd.Parameters.Add("?Nivel_de_escolaridad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nivel_de_escolaridad
            nue_var.cmd.Parameters.Add("?Situacion_habitacional", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Situacion_habitacional
            nue_var.cmd.Parameters.Add("?Integrantes_hogar", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Integrantes_hogar
            nue_var.cmd.Parameters.Add("?Cargas_familiares", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cargas_familiares
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal Rut As String, ByVal Fecha_de_nacimiento As Date, ByVal Lugar_de_nacimiento As String, ByVal Estado_Civil As String, ByVal Domicilio As String, ByVal Telefonos As String, ByVal E_mail As String, ByVal Tipo_de_contrato As String, ByVal Faena_actual As String, ByVal Profesion_Oficio As String, ByVal Cargo_labor As String, ByVal AFP As String, ByVal Salud As String, ByVal Fecha_de_Ingreso_Empresa As Date, ByVal Nivel_de_escolaridad As String, ByVal Situacion_habitacional As String, ByVal Integrantes_hogar As String, ByVal Cargas_familiares As Double, ByVal observaciones As String)
        nue_var.consulta = "UPDATE ficha_trabajador SET Nombres = ?Nombres, Apellidos = ?Apellidos, Rut = ?Rut, Fecha_de_nacimiento = ?Fecha_de_nacimiento, Lugar_de_nacimiento = ?Lugar_de_nacimiento, Estado_Civil = ?Estado_Civil, Domicilio = ?Domicilio,  Telefonos = ?Telefonos, E_mail = ?E_mail, Tipo_de_contrato = ?Tipo_de_contrato, Faena_actual = ?Faena_actual, Profesion_Oficio = ?Profesion_Oficio, Cargo_labor = ?Cargo_labor, AFP = ?AFP, Salud = ?Salud, Fecha_de_Ingreso_Empresa = ?Fecha_de_Ingreso_Empresa, Nivel_de_escolaridad = ?Nivel_de_escolaridad, Situacion_habitacional = ?Situacion_habitacional, Integrantes_hogar = ?Integrantes_hogar, Cargas_familiares = ?Cargas_familiares, observaciones = ?observaciones WHERE Id_ficha_trabajador = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?Nombres", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nombres
            nue_var.cmd.Parameters.Add("?Apellidos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Apellidos
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Fecha_de_nacimiento", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_de_nacimiento
            nue_var.cmd.Parameters.Add("?Lugar_de_nacimiento", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Lugar_de_nacimiento
            nue_var.cmd.Parameters.Add("?Estado_Civil", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Estado_Civil
            nue_var.cmd.Parameters.Add("?Domicilio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Domicilio
            nue_var.cmd.Parameters.Add("?Telefonos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Telefonos
            nue_var.cmd.Parameters.Add("?E_mail", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = E_mail
            nue_var.cmd.Parameters.Add("?Tipo_de_contrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tipo_de_contrato
            nue_var.cmd.Parameters.Add("?Faena_actual", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Faena_actual
            nue_var.cmd.Parameters.Add("?Profesion_Oficio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Profesion_Oficio
            nue_var.cmd.Parameters.Add("?Cargo_labor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cargo_labor
            nue_var.cmd.Parameters.Add("?AFP", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = AFP
            nue_var.cmd.Parameters.Add("?Salud", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Salud
            nue_var.cmd.Parameters.Add("?Fecha_de_Ingreso_Empresa", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_de_Ingreso_Empresa
            nue_var.cmd.Parameters.Add("?Nivel_de_escolaridad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nivel_de_escolaridad
            nue_var.cmd.Parameters.Add("?Situacion_habitacional", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Situacion_habitacional
            nue_var.cmd.Parameters.Add("?Integrantes_hogar", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Integrantes_hogar
            nue_var.cmd.Parameters.Add("?Cargas_familiares", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cargas_familiares
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from ficha_trabajador WHERE Id_ficha_trabajador = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
