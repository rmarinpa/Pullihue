Public Class frm_registro_llamadas
    Dim nue_cur As New clases.Registro_llamada
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub btn_vales_petroleo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vales_petroleo.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) Then
            CR_Registro_llamada4.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) Then
            CR_Resumen_llamada.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frm_registro_llamadas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Public Sub actualizar_llamadas()
        cmb_cliente.DataSource = nue_cur.listar2(Fecha_inicio, Fecha_final)
        cmb_cliente.DisplayMember = "Cliente"
        cmb_cliente.ValueMember = "Cliente"
    End Sub

    Private Sub cmb_cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_cliente.Click
        Fecha_inicio = Me.txt_fecha_in.Value.ToShortDateString
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        Fecha_final = Me.txt_fecha_fin.Value.ToShortDateString
        Fecha_final = Format(CDate(Fecha_final), "yyyy/MM/dd")
        actualizar_llamadas()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And cmb_cliente.Text <> "" Then
            CR_Registro_llamada5.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub actualizar_llamadas2()
        cmb_ejecutivo.DataSource = nue_cur.listar3(Fecha_inicio, Fecha_final)
        cmb_ejecutivo.DisplayMember = "usuario"
        cmb_ejecutivo.ValueMember = "usuario"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If IsDate(txt_fecha_in.Text) And IsDate(txt_fecha_fin.Text) And cmb_ejecutivo.Text <> "" Then
            CR_Registro_llamada6.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub cmb_ejecutivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ejecutivo.Click
        Fecha_inicio = Me.txt_fecha_in.Value.ToShortDateString
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        Fecha_final = Me.txt_fecha_fin.Value.ToShortDateString
        Fecha_final = Format(CDate(Fecha_final), "yyyy/MM/dd")
        actualizar_llamadas2()
    End Sub

    Private Sub cmb_ejecutivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ejecutivo.SelectedIndexChanged

    End Sub
End Class