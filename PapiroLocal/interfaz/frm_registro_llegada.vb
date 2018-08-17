Public Class frm_registro_llegada
    Dim nue_cur As New clases.Ruta
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(200, 10)
        Timer1.Enabled = True
        txt_usuario.ReadOnly = True
        txt_usuario.Text = Nombre_Obra
        txt_hora.ReadOnly = True
        actualizar_folio()
        txt_fecha.Enabled = False
        actualizar_dgv_ruta()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub
    Sub actualizar_dgv_ruta()
        Fecha_inicio = txt_fecha.Text
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        dgv_llegada.DataSource = nue_cur.listar5(Fecha_inicio)
        dgv_llegada.Columns(0).Visible = False
        dgv_llegada.Columns(1).HeaderText = "USUARIO"
        dgv_llegada.Columns(2).HeaderText = "FOLIO RUTA"
        dgv_llegada.Columns(3).HeaderText = "FECHA REGISTRO"
        dgv_llegada.Columns(4).HeaderText = "HORA REGISTRO"
        dgv_llegada.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_llegada.Columns(1).Width = 65
        dgv_llegada.Columns(2).Width = 65
        dgv_llegada.Columns(3).Width = 65
        dgv_llegada.Columns(4).Width = 65
    End Sub
    Public Sub actualizar_folio()
        Fecha_inicio = txt_fecha.Text
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        cmb_folio.DataSource = nue_cur.listar6(Fecha_inicio)
        cmb_folio.DisplayMember = "folio_ruta"
        cmb_folio.ValueMember = "folio_ruta"
    End Sub


    Private Sub btn_consulta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulta.Click
        If cmb_folio.Text <> "" Then
            CR_hoja_de_ruta2.Show()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub

    Private Sub btn_llegada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_llegada.Click
        If cmb_folio.Text <> "" Then
            Dim folio_ruta As Double
            Dim usuario As String
            usuario = txt_usuario.Text
            folio_ruta = cmb_folio.Text
            nue_cur.insertar2(usuario, folio_ruta, CDate(txt_fecha.Text), CDate(txt_hora.Text))
            actualizar_dgv_ruta()
            MessageBox.Show("LLEGADA REGISTRADA CON EXITO")
            actualizar_folio()
        Else
            MessageBox.Show("SELECCIONE UN REGISTRO")
        End If
    End Sub
End Class