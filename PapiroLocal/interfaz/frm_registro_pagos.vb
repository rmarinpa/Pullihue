Imports System.Globalization
Public Class frm_registro_pagos

    Dim nue_cur As New clases.Registro_pagos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        txt_total.Enabled = False
        dtp_fecha.Enabled = False
        dtp_fecha_pago.Visible = False
        lbl_pago.Visible = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub
    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If (cmb_operacion.Text = "CHEQUE" And cmb_banco.Text <> "" And txt_serie.Text <> "") Then
            frm_registro_facturas.Show()
        ElseIf (cmb_operacion.Text <> "CHEQUE" And cmb_operacion.Text <> "" And cmb_banco.Text <> "") Then
            frm_registro_facturas.Show()
        Else
            MsgBox("DEBE LLENAR PRIMERO TODOS LOS DATOS DE INFORMACIÓN GENERAL")
        End If

    End Sub
    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            lvpago.Items.Remove(lvpago.SelectedItems(0))
            suma_listview()
        Catch
            MsgBox("SELECCIONE UNA FACTURA VALIDA")
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim operacion, banco, serie, factura, cliente, estado, pendiente As String
        Dim total_adeudado, monto, diferencia As Double

        operacion = cmb_operacion.Text
        serie = txt_serie.Text
        banco = cmb_banco.Text

        If (cmb_operacion.Text = "CHEQUE" And cmb_banco.Text <> "" And txt_serie.Text <> "" And txt_total.Text <> "") Or (cmb_operacion.Text <> "CHEQUE" And cmb_banco.Text <> "" And txt_total.Text <> "") Then
            Dim Pregunta As Integer

            Pregunta = MsgBox("¿Finalizar registro de pago con " & operacion & " serie " & serie & " del " & banco & " por " & txt_total.Text & "?", vbYesNo + vbExclamation + vbDefaultButton2, "Eliminar Usuario.")

            If Pregunta = vbYes Then
                If (dtp_fecha_pago.Value.DayOfYear - dtp_fecha.Value.DayOfYear) <= 0 Then
                    estado = "PAGADO"
                Else
                    estado = "CARTERA"
                End If

                For Each item As ListViewItem In lvpago.Items
                    If (cmb_operacion.Text = "CHEQUE") And (item.SubItems(3).Text > 0) Then
                        pendiente = "SI"
                    Else
                        pendiente = "NO"
                    End If

                    factura = item.Text
                    total_adeudado = item.SubItems(1).Text
                    monto = item.SubItems(2).Text
                    diferencia = item.SubItems(3).Text
                    cliente = item.SubItems(4).Text
                    nue_cur.insertar(CDate(dtp_fecha.Text), operacion, banco, serie, factura, total_adeudado, monto, diferencia, CDate(dtp_fecha_pago.Text), pendiente, estado, cliente)
                Next
                lvpago.Items.Clear()
                txt_serie.Clear()
                cmb_banco.Text = ""
                cmb_operacion.Text = ""
                dtp_fecha.Value = DateTime.Now
                txt_total.Clear()
                dtp_fecha_pago.Visible = False
                lbl_pago.Visible = False
            Else
            End If
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
    Public Sub suma_listview()
        Dim Total As Integer, i As Integer
        Total = 0
        For Each item As ListViewItem In lvpago.Items
            Total = Total + item.SubItems(2).Text
        Next
        txt_total.Text = Total.ToString("C")
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
    End Sub

    Private Sub lvpago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvpago.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (cmb_operacion.Text = "CHEQUE" And cmb_banco.Text <> "" And txt_serie.Text <> "") Then
            frm_registro_facturas_cliente.Show()
        ElseIf (cmb_operacion.Text <> "CHEQUE" And cmb_operacion.Text <> "" And cmb_banco.Text <> "") Then
            frm_registro_facturas_cliente.Show()
        Else
            MsgBox("DEBE LLENAR PRIMERO TODOS LOS DATOS DE INFORMACIÓN GENERAL")
        End If
    End Sub
End Class