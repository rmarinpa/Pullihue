Imports System.Globalization
Public Class Frm_ventas_clientes

    Dim nue_report As New clases.ventas_clientes
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub bloquear()
        cmb_cliente.Enabled = False
        txt_rut.Enabled = False
        txt_senal_advertencia.Enabled = False
        txt_comuna.Enabled = False
        txt_direccion_despacho.Enabled = False
        txt_nombre_comercial.Enabled = False
        txt_email_comercial.Enabled = False
        txt_telefonos_comercial.Enabled = False
        txt_cargo_comercial.Enabled = False
    End Sub

    Sub desbloquear()
        gbx_Mov_Tierra.Enabled = True
    End Sub


    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        desbloquear()
        sw = 0
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frm_menu_servicio.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmb_cliente.Text <> "" Then
            cliente = cmb_cliente.Text
            rut = txt_rut.Text
            senal_advertencia = txt_senal_advertencia.Text
            direccion = txt_direccion_despacho.Text
            comuna = txt_comuna.Text
            Frm_ventas.Show()
        Else
            MessageBox.Show("Ingrese un Cliente Valido")
        End If
    End Sub

    Private Sub cmb_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Frm_ventas_clientes_busqueda.Show()
    End Sub
End Class