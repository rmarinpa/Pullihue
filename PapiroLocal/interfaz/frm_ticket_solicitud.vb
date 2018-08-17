Public Class frm_ticket_solicitud

    'Inherits interfaz.frm_modificar_ticket

    Dim nue_cur As New clases.Ruta
    Dim nueva_venta As New clases.ventas
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim tipo_documento As Integer


    Dim accion As Integer
    Public Sub abrir_en_panel(ByVal form_hijo As Object, ByVal panel As Panel)
        panel.Controls.Clear()
        Dim form As Form = CType(form_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_ticket_modificar.Close()
        frm_ticket_historial.Close()
        ' frm a llamar, ubicación a llamar
        frm_ticket_nuevo.Close()
        abrir_en_panel(frm_ticket_nuevo, pnl_body)
        lbl_titulo.Text = "Nuevo Ticket"
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        frm_ticket_nuevo.Close()
        frm_ticket_modificar.Limpiar()
        frm_ticket_historial.Close()
        ' frm a llamar, ubicación a llamar
        abrir_en_panel(frm_ticket_modificar, pnl_body)
        lbl_titulo.Text = "Modificar ticket"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_fecha.Text = Today
        lbl_hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub frm_solicitud_ticket_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_login.Show()
    End Sub

    Private Sub frm_solicitud_ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not (lbl_solicitante.Text.Equals("GSOLIS")) Then
            btn_modificar.Visible = False
        End If

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."

        Me.lbl_hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()

        lbl_solicitante.Text = Nombre_Obra ' Asinga el nombre del usuario
        lbl_titulo.Text = "Ticket's"
    End Sub

    Private Sub btn_historial_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        frm_ticket_nuevo.Close()
        frm_ticket_modificar.Close()
        ' frm a llamar, ubicación a llamar
        abrir_en_panel(frm_ticket_ver, pnl_body)
        lbl_titulo.Text = "Tickets"
    End Sub
End Class