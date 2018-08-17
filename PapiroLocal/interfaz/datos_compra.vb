Public Class datos_compra

    Dim sw As Integer
    Dim nue_report As New clases.Compras
    Dim nue_var As New clases.variables

    Private Sub datos_nota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_stock.Clear()
        txt_solicitado.Clear()
        txt_stock_mod.Clear()
        txt_stock.Text = Frm_compras.dgv_clientes.CurrentRow.Cells(19).Value.ToString()
        txt_stock.ReadOnly = True
        txt_solicitado.Text = Frm_compras.txt_nombre_ejecutivo.Text
        txt_solicitado.ReadOnly = True
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim txt_id_codigos As Integer
        Dim stock As Double

        txt_id_codigos = Frm_compras.dgv_clientes.CurrentRow.Cells(0).Value.ToString()
        stock = txt_stock_mod.Text
        nue_report.modificar(CInt(txt_id_codigos), stock)
        MessageBox.Show("AJUSTE REALIZADO")
        Frm_compras.Show()
        Frm_compras.actualizar_dgv2()
        Me.Close()

    End Sub
End Class